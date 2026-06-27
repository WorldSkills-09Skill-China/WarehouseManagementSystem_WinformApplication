using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManagementSystem
{
    public partial class FrmEditRecords : FrmTemplate
    {
        int _id;
        bool _isFixedAsset;
        public FrmEditRecords(int id)
        {
            InitializeComponent();
            nudItemCount.Maximum = int.MaxValue;
            nudItemCount.Controls.Remove(nudItemCount.Controls[0]);

            _id = id;
        }

        private async void btnCommit_Click(object sender, EventArgs e)
        {
            if (nudItemCount.Value <= 0)
            {
                "物品数量不能是0或负数".Msg();
                return;
            }

            var task = new TaskData
            {
                Id = _id,
                ItemName = cbmItem.Text.Trim(),
                RecordTypeId = cbmType.V,
                ItemId = cbmItem.V,
                ItemCount = nudItemCount.Value._2Int(),
                RecordStateId = cbmState.V,
                Note = tbNote.V,
                CreateTime = DateTime.Now,
                EndTime = dtpEndTime.Value,
                FindishedTime = dtpFinishedTime.Value,
                UserId = cbmOperator.V,
                PlaceForStorageDetailId = cbmPlaceForStorage.V,
                IsDelete = false,
                IsUserExistingItems = cbIsUserExistingItems.Checked,
                Batch = cbmBatch.V
            };

            var info = await task.EditRecordsAsync<TaskData>();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void cbmPlaceForStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            var info = await cbmPlaceForStorage.V.GetPlaceImageAsync<string>();
            string url = $@"http:/192.168.20.145:7014/api/{info.Data}";

            if (info.Data != null)
            {
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        var bytes = await client.GetByteArrayAsync(url);
                        using (var ms = new MemoryStream(bytes))
                        {
                            pbItem.Image = Image.FromStream(ms);
                            pbItem.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                    catch
                    {
                        pbItem.ImageLocation = null;
                    }
                }
            }
        }

        private async void cbmItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIsUserExistingItems.Checked = false;
            cbIsUserExistingItems.Enabled = false;
            var info = cbmItem.V.GetItemImageAsync<ItemInfoData>();
            var batches = cbmItem.V.GetItemBatches(cbmType.V);
            await Task.WhenAll(info, batches);
            if (cbIsUserExistingItems.Checked || cbmType.V == 1)
            {
                batches.Result.Data.Insert(0, new CbmData
                {
                    Id = -1,
                    Name = "",
                });
                batches.Result.Data.Bind(cbmBatch);
            }
            else
            {
                cbmBatch.DataSource = null;
            }
            string url = $@"http:/192.168.20.145:7014/api/{info.Result.Data.ImageName}";

            if (info.Result.Data.ImageName != null)
            {
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        var bytes = await client.GetByteArrayAsync(url);

                        using (var ms = new MemoryStream(bytes))
                        {
                            pbItem.Image = Image.FromStream(ms);
                            pbItem.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                    catch
                    {
                        pbItem.ImageLocation = null;
                    }
                }
            }

            _isFixedAsset = info.Result.Data.IsFixedAsset;
            if (cbmType.V == 2 && _isFixedAsset)
            {
                cbIsUserExistingItems.Enabled = true;
            }
        }

        private async void FrmEditRecords_Load(object sender, EventArgs e)
        {
            var operatorsData = UsersNetworkRequest.GetOperatorsAsync();

            var items = ItemNetworkRequest.GetItemsAsync();

            var types = TypesAndStateNetworkRequest.GetRecordTypesAsync();

            var states = TypesAndStateNetworkRequest.GetRecordStatesAsync();

            var record = _id.GetRecordDetail<TaskData>();

            await Task.WhenAll(operatorsData, items, types, states, record);

            operatorsData.Result.Data.Insert(0, new CbmData { Id = -1, Name = null });
            operatorsData.Result.Data.Bind(cbmOperator);
            items.Result.Data.Bind(cbmItem);
            types.Result.Data.Bind(cbmType);
            states.Result.Data.Bind(cbmState);
            var info = record.Result.Data;

            cbmOperator.SelectedValue = info.UserId == null ? -1 : info.UserId;
            cbmItem.SelectedValue = info.ItemId;
            cbmType.SelectedValue = info.RecordTypeId;
            cbmPlaceForStorage.SelectedValue = info.PlaceForStorageDetailId;
            cbmState.SelectedValue = info.RecordStateId;
            nudItemCount.Value = info.ItemCount;
            tbNote.Text = info.Note;
            cbIsUserExistingItems.Checked = info.IsUserExistingItems;
        }

        private void cbmOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIsUserExistingItems.Checked = false;
            cbIsUserExistingItems.Enabled = false;
            if (cbmType.V == 2 && _isFixedAsset)
            {
                cbIsUserExistingItems.Enabled = true;
            }
        }

        private async void cbmBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmType.V == 2)
            {
                var places = await PlaceForStorageDetailsNetworkRequest.GetPlacesAsync(-1, -1);
                places.Data.Insert(0, new CbmData { Id = -1, Name = "多个存放位置" });
                places.Data.Bind(cbmPlaceForStorage);
            }
            if (cbmType.V == 1)
            {
                cbmPlaceForStorage.DataSource = null;
                var places = await PlaceForStorageDetailsNetworkRequest.GetPlacesAsync(cbmItem.V, cbmBatch.V);
                places.Data.Bind(cbmPlaceForStorage);
            }
        }

        private async void cbmType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIsUserExistingItems.Checked = false;
            cbIsUserExistingItems.Enabled = false;

            if (cbIsUserExistingItems.Checked)
            {
                var batches = await cbmItem.V.GetItemBatches(cbmType.V);
                batches.Data.Insert(0, new CbmData
                {
                    Id = -1,
                    Name = "",
                });
                batches.Data.Bind(cbmBatch);
            }
            else
            {
                cbmBatch.DataSource = null;
            }

            if (cbmType.V == 2)
            {
                var places = await PlaceForStorageDetailsNetworkRequest.GetPlacesAsync(-1, -1);
                places.Data.Insert(0, new CbmData { Id = -1, Name = "多个存放位置" });
                places.Data.Bind(cbmPlaceForStorage);

                if (_isFixedAsset)
                {
                    cbIsUserExistingItems.Enabled = true;
                }
            }
            if (cbmType.V == 1)
            {
                cbmPlaceForStorage.DataSource = null;

                var places = await PlaceForStorageDetailsNetworkRequest.GetPlacesAsync(cbmItem.V, cbmBatch.V);
                places.Data.Bind(cbmPlaceForStorage);
            }
        }

        private async void cbIsUserExistingItems_CheckedChanged(object sender, EventArgs e)
        {
            var batches = await cbmItem.V.GetItemBatches(cbmType.V);
            if (cbIsUserExistingItems.Checked)
            {
                cbmBatch.DataSource = null;
                batches.Data.ToList().Bind(cbmBatch);
            }
            else if (cbmType.V == 2)
            {
                batches.Data.Insert(0, new CbmData
                {
                    Id = -1,
                    Name = "",
                });
                batches.Data.ToList().Bind(cbmBatch);
            }
            else
            {
                cbmBatch.DataSource = null;
                batches.Data.ToList().Bind(cbmBatch);
            }
            if (batches.Data.Count <= 0)
            {
                "仓库中没有该物品".Msg();
                cbIsUserExistingItems.Checked = false;
                return;
            }
        }
    }

    public class TaskData
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int ItemId { get; set; }
        public int ItemCount { get; set; }
        public int PlaceForStorageDetailId { get; set; }
        public int RecordTypeId { get; set; }
        public int RecordStateId { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? FindishedTime { get; set; }
        public int? UserId { get; set; }
        public bool IsDelete { get; set; }
        public string Note { get; set; }
        public bool IsUserExistingItems { get; set; }
        public int Batch { get; set; }
    }

    public class ItemInfoData
    {
        public string ImageName { get; set; }
        public bool IsFixedAsset { get; set; }
    }

}
