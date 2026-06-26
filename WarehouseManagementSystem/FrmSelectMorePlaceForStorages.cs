using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManagementSystem
{
    public partial class FrmSelectMorePlaceForStorages : FrmTemplate
    {
        bool _isReturn;
        TaskData _taskData;
        bool _isFixedAsset;
        Dictionary<string, int> itemsPlaceForStorages = new Dictionary<string, int>();
        public FrmSelectMorePlaceForStorages(bool isReturn, TaskData record, bool isFixedAsset)
        {
            InitializeComponent();
            _isReturn = isReturn;
            _taskData = record;
            _isFixedAsset = isFixedAsset;

            nudItemCount.Maximum = int.MaxValue;
            nudItemCount.Controls.Remove(nudItemCount.Controls[0]);
        }

        private async void FrmSelectMorePlaceForStorages_Load(object sender, EventArgs e)
        {
            var places = await PlaceForStorageDetailsNetworkRequest.GetPlacesAsync(-1);
            places.Data.Bind(cbmStorageRack);

            if (_isReturn)
            {

                var info = await ItemNetworkRequest.ReturnBatchItem<List<ReturnBatchItem>>(_taskData.ItemCount, _taskData.Batch, _taskData.ItemId);
                info.Data.Select(a =>
                {
                    var specificationsData = JsonConvert.DeserializeObject<List<Specification>>(a.Detail);
                    var specification = "";
                    foreach (var item in specificationsData)
                    {
                        specification += $"{item.Key}:{item.Value};";
                    }
                    return new
                    {
                        a.ItemName,
                        a.Code,
                        a.Batch,
                        Detail = specification,
                    };
                }).Bind(dgvItemsData);
            }
            else if (_isFixedAsset)
            {
                var info = new List<ReturnBatchItem>();
                for (int i = 1; i <= _taskData.ItemCount; i++)
                {
                    info.Add(new ReturnBatchItem
                    {
                        ItemName = _taskData.ItemName,
                        Code = i.ToString(),
                    });
                }
                info.Select(a => new
                {
                    a.ItemName,
                    a.Code,
                }
                ).Bind(dgvItemsData);
            }
            else
            {
                var info = new List<ReturnBatchItem>();
                info.Add(new ReturnBatchItem
                {
                    ItemName = _taskData.ItemName,
                    Batch = _taskData.Batch,
                });
                info.Bind(dgvItemsData);
            }
            var placeForStorage = new DataGridViewColumn
            {
                Name = "PlaceForStorage"
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnReduce_Click(object sender, EventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

        }
    }

    public class ReturnBatchItem
    {
        public string ItemName { get; set; }
        public string Code { get; set; }
        public int Batch { get; set; }
        public string Detail { get; set; }
    }

    public class ItemRecord
    {
        public int Count { get; set; }
        public string ItemName { get; set; }
    }

    public class Specification
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
