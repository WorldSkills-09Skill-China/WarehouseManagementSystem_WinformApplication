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
        Dictionary<string, string> fixedAssetsPlaceForStorage = new Dictionary<string, string>();
        Dictionary<string, int> itemsPlaceForStorages = new Dictionary<string, int>();
        List<ReturnBatchItem> returnBatchItems = new List<ReturnBatchItem>();
        List<ItemRecord> itemRecords = new List<ItemRecord>();
        public FrmSelectMorePlaceForStorages(bool isReturn, TaskData record, bool isFixedAsset)
        {
            InitializeComponent();
            _isReturn = isReturn;
            _taskData = record;
            _isFixedAsset = isFixedAsset;

            nudItemCount.Maximum = int.MaxValue;
            nudItemCount.Controls.Remove(nudItemCount.Controls[0]);

            dgvItemsData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItemsData.MultiSelect = true;
        }

        private async void FrmSelectMorePlaceForStorages_Load(object sender, EventArgs e)
        {
            var places = await PlaceForStorageDetailsNetworkRequest.GetPlacesAsync(-1, -1);
            places.Data.Bind(cbmStorageRack);

            nudItemCount.Visible = false;
            btnAdd.Visible = false;
            btnReduce.Visible = false;
            lblItemCount.Visible = false;
            if (_isReturn)
            {
                var info = await ItemNetworkRequest.ReturnBatchItem<List<ReturnBatchItem>>(_taskData.ItemCount, _taskData.Batch, _taskData.ItemId);
                returnBatchItems.AddRange(info.Data);

                if (returnBatchItems.Count < _taskData.ItemCount && _taskData.Batch != -1)
                {
                    "库存不足".Msg();
                    this.Close();
                }
                returnBatchItems.Select(a =>
                {
                    fixedAssetsPlaceForStorage[a.Code] = "-1|未设置";
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
                        PlaceForStorageDetail = fixedAssetsPlaceForStorage.ContainsKey(a.Code) ? fixedAssetsPlaceForStorage[a.Code].Split('|')[1] : null,
                    };
                }).Bind(dgvItemsData);
            }
            else if (_isFixedAsset)
            {
                for (int i = 1; i <= _taskData.ItemCount; i++)
                {
                    fixedAssetsPlaceForStorage[i.ToString()] = "-1|未设置";
                    returnBatchItems.Add(new ReturnBatchItem
                    {
                        Code = i.ToString(),
                        ItemName = _taskData.ItemName,
                        PlaceForStorageDetail = fixedAssetsPlaceForStorage.ContainsKey(i.ToString()) ? fixedAssetsPlaceForStorage[i.ToString()].Split('|')[1] : null,
                    });
                }

                if (returnBatchItems.Count < _taskData.ItemCount && _taskData.Batch != -1)
                {
                    "库存不足".Msg();
                    this.Close();
                }
                returnBatchItems.Bind(dgvItemsData);
            }
            else
            {
                lblItemCount.Visible = false;
                nudItemCount.Visible = true;
                dgvItemsData.MultiSelect = false;
                btnAdd.Visible = true;
                btnReduce.Visible = true;
                btnChange.Visible = false;

                itemsPlaceForStorages["-1|未设置"] = _taskData.ItemCount;
                var info = new List<ItemRecord>();
                info.Add(new ItemRecord
                {
                    ItemName = _taskData.ItemName,
                    Count = _taskData.ItemCount,
                    PlaceForStorageDetail = "未设置",
                    PlaceForStorageDetailId = -1
                });

                if (info.Count < _taskData.ItemCount && _taskData.Batch != -1)
                {
                    "库存不足".Msg();
                    this.Close();
                }
                info.Bind(dgvItemsData);
            }
            dgvItemsData.Hide("PlaceForStorageDetailId");
        }

        public void ReturnItemsLoadInfo()
        {
            foreach (var item in returnBatchItems)
            {
                var placeForStorage = fixedAssetsPlaceForStorage[item.Code].Split('|');
                item.PlaceForStorageDetail = placeForStorage[1];
                item.PlaceForStorageDetailId = Convert.ToInt32(placeForStorage[0]);
            }
            dgvItemsData.DataSource = null;
            dgvItemsData.DataSource = returnBatchItems;
            dgvItemsData.Hide("PlaceForStorageDetailId");
        }
        public void ItemRecordsLoadInfo()
        {
            itemRecords.Clear();
            foreach (var item in itemsPlaceForStorages)
            {
                itemRecords.Add(new ItemRecord
                {
                    ItemName = _taskData.ItemName,
                    Count = item.Value,
                    PlaceForStorageDetailId = Convert.ToInt32(item.Key.Split('|')[0]),
                    PlaceForStorageDetail = item.Key.Split('|')[1]
                });
            }
            dgvItemsData.DataSource = null;
            dgvItemsData.DataSource = itemRecords;
            dgvItemsData.Hide("PlaceForStorageDetailId");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvItemsData.CurrentRow != null)
            {
                var count = Convert.ToInt32(dgvItemsData.CurrentRow.Cells["Count"].Value);
                if (count < nudItemCount.Value)
                {
                    "当前所选存放位置物品数量不足".Msg();
                    return;
                }
                if (!itemsPlaceForStorages.ContainsKey($"{cbmStorageRack.V}|{cbmStorageRack.Text.Trim()}"))
                {
                    itemsPlaceForStorages[$"{cbmStorageRack.V}|{cbmStorageRack.Text.Trim()}"] = 0;
                }
                itemsPlaceForStorages[$"{cbmStorageRack.V}|{cbmStorageRack.Text.Trim()}"] += Convert.ToInt32(nudItemCount.Value);
                itemsPlaceForStorages[$"{dgvItemsData.CurrentRow.Cells["PlaceForStorageDetailId"].Value}|{dgvItemsData.CurrentRow.Cells["PlaceForStorageDetail"].Value}"] -= Convert.ToInt32(nudItemCount.Value);
                ItemRecordsLoadInfo();
            }
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            if (dgvItemsData.CurrentRow != null
                && dgvItemsData.CurrentRow.Cells["PlaceForStorageDetail"].Value.ToString() != "未设置")
            {
                var count = Convert.ToInt32(dgvItemsData.CurrentRow.Cells["Count"].Value);
                if (count < nudItemCount.Value)
                {
                    "当前所选存放位置物品数量不足".Msg();
                    return;
                }
                itemsPlaceForStorages[$"{cbmStorageRack.V}|{cbmStorageRack.Text.Trim()}"] -= Convert.ToInt32(nudItemCount.Value);
                itemsPlaceForStorages[$"-1|未设置"] += Convert.ToInt32(nudItemCount.Value);
                ItemRecordsLoadInfo();
            }
        }

        private async void btnFinish_Click(object sender, EventArgs e)
        {

            if (_isFixedAsset)
            {
                if (returnBatchItems.Any(a => a.PlaceForStorageDetailId == -1) || itemRecords.Any(a => a.PlaceForStorageDetailId == -1))
                {
                    "还有物品为设置位置".Msg();
                    return;
                }
                foreach (var item in returnBatchItems.GroupBy(a => a.PlaceForStorageDetailId))
                {
                    var info = await new TaskData
                    {
                        RecordTypeId = 2,
                        ItemId = _taskData.ItemId,
                        ItemCount = item.Count(),
                        Note = _taskData.Note,
                        CreateTime = DateTime.Now,
                        EndTime = _taskData.EndTime,
                        UserId = _taskData.UserId,
                        PlaceForStorageDetailId = item.Key,
                        Batch = _taskData.Batch,
                    }.AddTask<string>();
                    if (!info.Success)
                    {
                        info.Message.Msg();
                        return;
                    }
                }
            }
            else
            {
                if (itemsPlaceForStorages["-1|未设置"] > 0)
                {
                    "还有物品为设置位置".Msg();
                    return;
                }
                foreach (var item in itemRecords)
                {
                    if (item.PlaceForStorageDetailId == -1)
                    {
                        continue;
                    }
                    var info = await new TaskData
                    {
                        RecordTypeId = 2,
                        ItemId = _taskData.ItemId,
                        ItemCount = item.Count,
                        Note = _taskData.Note,
                        CreateTime = DateTime.Now,
                        EndTime = _taskData.EndTime,
                        UserId = _taskData.UserId,
                        PlaceForStorageDetailId = item.PlaceForStorageDetailId,
                        Batch = _taskData.Batch,
                    }.AddTask<string>();
                    if (!info.Success)
                    {
                        info.Message.Msg();
                        return;
                    }
                }
            }
            "添加成功".Msg();
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dgvItemsData.SelectedRows.Count <= 0)
            {
                "请选择一个或多个固定资产".Msg();
                return;
            }

            foreach (DataGridViewRow row in dgvItemsData.SelectedRows)
            {
                var code = row.Cells["Code"].Value.ToString();
                fixedAssetsPlaceForStorage[code] = $"{cbmStorageRack.V}|{cbmStorageRack.Text.Trim()}";
            }
            ReturnItemsLoadInfo();
        }
    }

    public class ReturnBatchItem
    {
        public int PlaceForStorageDetailId { get; set; }
        public string ItemName { get; set; }
        public string Code { get; set; }
        public int Batch { get; set; }
        public string Detail { get; set; }
        public string PlaceForStorageDetail { get; set; }
    }

    public class ItemRecord
    {
        public int Count { get; set; }
        public string ItemName { get; set; }
        public string PlaceForStorageDetail { get; set; }
        public int PlaceForStorageDetailId { get; set; }
    }

    public class Specification
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
