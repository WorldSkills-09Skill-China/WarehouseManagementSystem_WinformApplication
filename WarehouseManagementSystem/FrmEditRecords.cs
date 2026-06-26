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
            string url = $@"http://localhost:5070//{info.Data}";

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
            var info = await cbmItem.V.GetItemImageAsync<ItemInfoData>();
            string url = $@"http://localhost:5070//{info.Data.ImageName}";

            if (info.Data.ImageName != null)
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

            _isFixedAsset = info.Data.IsFixedAsset;
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

            var places = PlaceForStorageDetailsNetworkRequest.GetPlacesAsync(-1);

            var states = TypesAndStateNetworkRequest.GetRecordStatesAsync();

            var record = _id.GetRecordDetail<TaskData>();

            await Task.WhenAll(operatorsData, items, types, places, states, record);

            operatorsData.Result.Data.Insert(0, new CbmData { Id = -1, Name = null });
            operatorsData.Result.Data.Bind(cbmOperator);
            items.Result.Data.Bind(cbmItem);
            types.Result.Data.Bind(cbmType);
            places.Result.Data.Bind(cbmPlaceForStorage);
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

        private void cbmBatch_SelectedIndexChanged(object sender, EventArgs e)
        {

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
