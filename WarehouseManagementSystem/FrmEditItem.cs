using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManagementSystem
{
    public partial class FrmEditItem : FrmTemplate
    {
        bool _isFixedAsset;
        int itemCount;
        List<FixedAssetData> addFixedAssetList = new List<FixedAssetData>();
        List<FixedAssetData> fixedAssetDatas = new List<FixedAssetData>();
        List<FixedAssetData> deleteFixedAssetList = new List<FixedAssetData>();
        Dictionary<string, string> placeForStorageDetailIdChangedFixedAsset = new Dictionary<string, string>();
        Dictionary<string, string> userIdChangedFixedAsset = new Dictionary<string, string>();
        Dictionary<string, string> newFixedAssetListSpecification = new Dictionary<string, string>();

        int _id;
        public FrmEditItem(int id)
        {
            InitializeComponent();
            _id = id;

            nudSafeStock.Maximum = int.MaxValue;
            nudSafeStock.Controls.Remove(nudSafeStock.Controls[0]);

            nudCount.Maximum = int.MaxValue;
            nudCount.Controls.Remove(nudCount.Controls[0]);

            dgvFixedAsset.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFixedAsset.MultiSelect = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetImage_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "图片|*.jpg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbImagePath.Text = openFileDialog.FileName;
                pbItemImage.ImageLocation = openFileDialog.FileName;
            }
        }

        private async void btnCommit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbItemName.V))
            {
                "物品名不可以为空".Msg();
                return;
            }

            if (string.IsNullOrEmpty(tbUnit.V))
            {
                "物品单位不可以为空".Msg();
                return;
            }

            if (nudSafeStock.Value <= 0)
            {
                "安全库存不能是0或负数".Msg();
                return;
            }

            var item = new AskItem
            {
                Id = _id,
                ItemName = tbItemName.V,
                ItemTypeId = cbmType.V,
                SafeCount = nudSafeStock.Value._2Int(),
                ImageFile = string.IsNullOrEmpty(tbImagePath.V) ? null : Convert.ToBase64String(File.ReadAllBytes(tbImagePath.V)),
                ImageFileName = Path.GetFileName(tbImagePath.V),
                IsFixedAsset = _isFixedAsset,
                AddFixedAssets = addFixedAssetList,
                DeleteFixedAssets = deleteFixedAssetList,
                PlaceForStorageDetailIdChangedFixedAsset = placeForStorageDetailIdChangedFixedAsset,
                UserChangedFixedAsset = userIdChangedFixedAsset,
                Unit = tbUnit.V,
            };

            var info = await item.EditItemAsync<string>();
            if (_id == -1)
            {
                info = await item.AddItemAsync<string>();
            }
            if (info.Success)
            {
                "提交成功".Msg();
                this.Close();
            }
            else
            {
                "提交失败".Msg();
            }
        }

        private async void FrmEditItem_Load(object sender, EventArgs e)
        {
            gbFixedAssetEdit.Enabled = false;
            var types = await TypesAndStateNetworkRequest.GetItemTypesAsync();
            types.Data.ToList().Bind(cbmType);
            var placeForStorages = PlaceForStorageDetailsNetworkRequest.GetPlacesAsync(-1, -1);
            var users = UsersNetworkRequest.GetOperatorsAsync();
            await Task.WhenAll(placeForStorages, users);

            placeForStorages.Result.Data.ToList().Bind(cbmPlaceforStorage);
            users.Result.Data.ToList().Bind(cbmUser);
            if (_id != -1)
            {

                lblTitle.Text = "物品编辑";
                var info = _id.GetItemAsync<AcceptItem>();
                var fixedAssetData = _id.GetFixedAssetData<List<FixedAssetData>>();
                await Task.WhenAll(info, fixedAssetData);

                if (fixedAssetData.Result.Data != null)
                {
                    fixedAssetDatas.AddRange(fixedAssetData.Result.Data);
                }

                var item = info.Result.Data;
                string url = $@"http:/192.168.20.145:7014/api/{item.ImageFileName}";

                if (item.ImageFileName != null)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        try
                        {
                            var bytes = await client.GetByteArrayAsync(url);

                            using (var ms = new MemoryStream(bytes))
                            {
                                pbItemImage.Image = Image.FromStream(ms);
                                pbItemImage.SizeMode = PictureBoxSizeMode.Zoom;
                            }
                        }
                        catch
                        {
                            pbItemImage.ImageLocation = null;
                        }
                    }
                }

                tbUnit.Text = item.Unit;
                tbItemName.Text = item.ItemName;
                cbmType.SelectedValue = item.ItemTypeId;
                nudSafeStock.Value = item.SafeCount;
                _isFixedAsset = item.IsFixedAssetpublic;
                gbFixedAssetEdit.Enabled = item.IsFixedAssetpublic;
                btnAddFixedAsset.Enabled = item.IsFixedAssetpublic;
                cbIsFixedAsset.Visible = false;
            }
            LoadInfor();
        }

        public void LoadInfor()
        {
            dgvFixedAsset.Columns.Clear();
            var allFixedAssetDatas = new List<FixedAssetData>();
            allFixedAssetDatas.AddRange(fixedAssetDatas);
            allFixedAssetDatas.AddRange(addFixedAssetList);
            allFixedAssetDatas.Select(a => new
            {
                PlaceForstorageDetail = placeForStorageDetailIdChangedFixedAsset.ContainsKey(a.Code) ? placeForStorageDetailIdChangedFixedAsset[a.Code].Split('|')[2]
                : a.PlaceForStorageDetail,
                UserName = userIdChangedFixedAsset.ContainsKey(a.Code) ? userIdChangedFixedAsset[a.Code].Split('|')[2] : a.UserName,
                Item = a.ItemName,
                Code = a.Code,
                Batch = a.Batch,
                Specification = newFixedAssetListSpecification.ContainsKey(a.Code) ? newFixedAssetListSpecification[a.Code].Split('|')[1] : a.Specification,
            }).ToList().Bind(dgvFixedAsset);
            var deleteColumn = new DataGridViewLinkColumn
            {
                Text = "Delete",
                Name = "Delete",
                UseColumnTextForLinkValue = true
            };
            var detail = new DataGridViewLinkColumn
            {
                Text = "Detail",
                Name = "Detail",
                UseColumnTextForLinkValue = true
            };
            dgvFixedAsset.Columns.Add(deleteColumn);
            dgvFixedAsset.Columns.Add(detail);
        }

        private async void btnAddFixedAsset_Click(object sender, EventArgs e)
        {
            var lastIdInfor = await FixedAssetDataNetworkRequest.GetLastId();
            var id = lastIdInfor.Data;
            if (nudCount.Value <= 0)
            {
                "物品数量不可以是0或负数".Msg();
                return;
            }
            var now = DateTime.Now;
            for (lastIdInfor.Data = lastIdInfor.Data + 1; lastIdInfor.Data <= id + nudCount.Value; lastIdInfor.Data++)
            {
                var fixedAsset = new FixedAssetData
                {
                    UserId = null,
                    Code = $"{now.Year}{now.Month.ToString("00")}{now.Day.ToString("00")}{lastIdInfor.Data.ToString("000000")}",
                    UserName = null,
                    ItemName = tbItemName.V,
                    ItemId = _id,
                    PlaceForStorageDetail = null,
                };
                addFixedAssetList.Add(fixedAsset);
            }
            LoadInfor();
        }

        private void cbIsFixedAsset_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvFixedAsset.RowCount > 0 && cbIsFixedAsset.Checked == false)
            {
                "如果要更改为普通物品，请将所有的固定资产清除".Msg();
                cbIsFixedAsset.Checked = true;
                return;
            }
            if (cbIsFixedAsset.Checked)
            {
                gbFixedAssetEdit.Enabled = true;
            }
            else
            {
                gbFixedAssetEdit.Enabled = false;
            }
        }

        private void dgvFixedAsset_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var fixedAsset = fixedAssetDatas.FirstOrDefault(a => a.Code == dgvFixedAsset.CurrentRow.Cells["Code"].Value.ToString());
            var addFixedAsset = addFixedAssetList.FirstOrDefault(a => a.Code == dgvFixedAsset.CurrentRow.Cells["Code"].Value.ToString());
            if (dgvFixedAsset.Columns[e.ColumnIndex] == dgvFixedAsset.Columns["Delete"])
            {

                if (fixedAsset != null)
                {

                    fixedAssetDatas.Remove(fixedAsset);
                    deleteFixedAssetList.Add(fixedAsset);
                    LoadInfor();
                    return;
                }
                addFixedAssetList.Remove(addFixedAsset);
                LoadInfor();
            }

            if (dgvFixedAsset.Columns[e.ColumnIndex] == dgvFixedAsset.Columns["Detail"])
            {

                if (addFixedAssetList.Contains(addFixedAsset))
                {
                    "该物品未被添加没有记录".Msg();
                    return;
                }
                new FrmFixedAssetDetail(dgvFixedAsset.CurrentRow.Cells["Code"].Value.ToString()).ShowDialog();
                LoadInfor();
            }
        }

        private void btnChangePlaceForStorage_Click(object sender, EventArgs e)
        {
            if (dgvFixedAsset.SelectedRows.Count <= 0)
            {
                "请选择要更改的物品".Msg();
                return;
            }

            foreach (DataGridViewRow row in dgvFixedAsset.SelectedRows)
            {
                var code = row.Cells["Code"].Value.ToString();
                var batch = row.Cells["Batch"].Value?.ToString();
                placeForStorageDetailIdChangedFixedAsset[code] = batch + "|" + cbmPlaceforStorage.V + "|" + cbmPlaceforStorage.Text.Trim();
                if (userIdChangedFixedAsset.ContainsKey(code))
                {
                    userIdChangedFixedAsset.Remove(code);
                }
            }
            LoadInfor();
        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            if (dgvFixedAsset.SelectedRows.Count <= 0)
            {
                "请选择要更改的物品".Msg();
                return;
            }

            foreach (DataGridViewRow row in dgvFixedAsset.SelectedRows)
            {
                var code = row.Cells["Code"].Value.ToString();
                var batch = row.Cells["Batch"].Value?.ToString();
                userIdChangedFixedAsset[code] = batch + "|" + cbmUser.V + "|" + cbmUser.Text.Trim();
                if (placeForStorageDetailIdChangedFixedAsset.ContainsKey(code))
                {
                    placeForStorageDetailIdChangedFixedAsset.Remove(code);
                }
            }
            LoadInfor();
        }

        private void btnEditSpecification_Click(object sender, EventArgs e)
        {
            if (dgvFixedAsset.SelectedRows.Count <= 0)
            {
                "请选择要更改的物品".Msg();
                return;
            }
            var codeList = new List<string>();
            foreach (DataGridViewRow row in dgvFixedAsset.SelectedRows)
            {
                codeList.Add(row.Cells["Code"].Value.ToString());
            }
            var frm = new FrmEdtiItemSpecification(codeList);
            frm.ShowDialog();
            foreach (var item in frm.specificationAccept.NewFixedAssets)
            {
                newFixedAssetListSpecification[item] = frm.specificationAccept.SpecificationId + "|" + JsonConvert.SerializeObject(frm.SpecificationList);
            };
            foreach (var fixedAsset in addFixedAssetList.Where(a => newFixedAssetListSpecification.ContainsKey(a.Code)))
            {
                fixedAsset.SpecificationId = Convert.ToInt32(newFixedAssetListSpecification[fixedAsset.Code].Split('|')[0]);
            }
            LoadInfor();
        }
    }

    public class FixedAssetData
    {
        public int? PlaceForStorageDetailId { get; set; }
        public int? UserId { get; set; }
        public string Code { get; set; }
        public string UserName { get; set; }
        public string ItemName { get; set; }
        public int ItemId { get; set; }
        public string PlaceForStorageDetail { get; set; }
        public int? Batch { get; set; }
        public string Specification { get; set; }
        public int SpecificationId { get; set; }
    }


    public class AskItem
    {
        public string Unit { get; set; }
        public string ImageFile { get; set; }
        public int? Id { get; set; }
        public string ItemName { get; set; }
        public int ItemTypeId { get; set; }
        public bool IsFixedAsset { get; set; }
        public int SafeCount { get; set; }
        public string ImageFileName { get; set; }
        public List<FixedAssetData> AddFixedAssets { get; set; }
        public List<FixedAssetData> DeleteFixedAssets { get; set; }
        public Dictionary<string, string> PlaceForStorageDetailIdChangedFixedAsset { get; set; }
        public Dictionary<string, string> UserChangedFixedAsset { get; set; }
    }

    public class AcceptItem
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int ItemTypeId { get; set; }
        public int SafeCount { get; set; }
        public string ImageFileName { get; set; }
        public bool IsFixedAssetpublic { get; set; }
        public string Unit { get; set; }
    }
}
