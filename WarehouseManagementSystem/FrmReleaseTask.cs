using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManagementSystem
{
    public partial class FrmReleaseTask : Form
    {
        int _id;
        ItemAnomaly _item;
        bool _isFixedAsset;
        public FrmReleaseTask(ItemAnomaly item, int id)
        {
            InitializeComponent();
            _id = id;
            _item = item;

            nudItemCount.Maximum = int.MaxValue;
            nudItemCount.Minimum = int.MinValue;
            nudItemCount.Controls.Remove(nudItemCount.Controls[0]);
        }

        private async void FrmReleaseTask_Load(object sender, EventArgs e)
        {
            var operatorsData = UsersNetworkRequest.GetOperatorsAsync();

            var items = ItemNetworkRequest.GetItemsAsync();

            var types = TypesAndStateNetworkRequest.GetRecordTypesAsync();

            var places = PlaceForStorageDetailsNetworkRequest.GetPlacesAsync(-1);

            await Task.WhenAll(operatorsData, items, types, places);

            operatorsData.Result.Data.Insert(0, new CbmData { Id = -1, Name = null });
            operatorsData.Result.Data.Bind(cbmOperator);
            items.Result.Data.Bind(cbmItem);
            types.Result.Data.Bind(cbmType);
            places.Result.Data.Insert(0, new CbmData { Id = -1, Name = "多个存放位置" });
            places.Result.Data.Bind(cbmPlaceForStorage);

            if (_id != 0)
            {
                cbmItem.SelectedValue = _id;
                cbmType.SelectedValue = _item.TypeId ? 1 : 2;
                nudItemCount.Value = _item.ItemCount;
            }
        }

        private async void btnReleaseTask_Click(object sender, EventArgs e)
        {
            if (nudItemCount.Value <= 0)
            {
                "物品数量不可以为0或者负数".Msg();
                return;
            }

            var info = new TaskData
            {
                RecordTypeId = cbmType.V,
                ItemId = cbmItem.V,
                ItemCount = nudItemCount.Value._2Int(),
                Note = tbNote.V,
                CreateTime = DateTime.Now,
                EndTime = dtpEndTime.Value,
                FindishedTime = null,
                UserId = cbmOperator.V,
                PlaceForStorageDetailId = cbmPlaceForStorage.V,
                IsDelete = false,
                IsUserExistingItems = cbIsUserExistingItems.Checked
            };

            if (cbIsUserExistingItems.Checked && cbmPlaceForStorage.V == -1)
            {
                this.GoFrm(new FrmSelectMorePlaceForStorages(true, info, _isFixedAsset));
            }
            else if (cbmPlaceForStorage.V == -1 && cbmType.V == 2 )
            {
                this.GoFrm(new FrmSelectMorePlaceForStorages(false, info, _isFixedAsset));
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

        private async void cbmType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIsUserExistingItems.Checked = false;
            cbIsUserExistingItems.Enabled = false;
            if (cbmType.V == 2 && _isFixedAsset)
            {
                cbIsUserExistingItems.Enabled = true;
            }
            if (cbmType.V == 1 && _isFixedAsset)
            {
                var places = await PlaceForStorageDetailsNetworkRequest.GetPlacesAsync(-1);
                places.Data.Add(new CbmData { Id = -1, Name = "" });
                places.Data.Bind(cbmPlaceForStorage);
            }
        }

        private void cbmBatch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
