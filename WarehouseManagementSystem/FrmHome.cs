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
    public partial class FrmHome : FrmTemplate
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        public async void LoadInfo()
        {
            dgvUnfinishedTaskData.Columns.Clear();
            dgvAbnormalItemData.Columns.Clear();

            var allRecords = WarehouseRecordsNetworkRequest.GetRecordsAsync<List<Record>>();
            var unfinishedTasks = WarehouseRecordsNetworkRequest.GetUnfinishedTasksAsync<List<Record>>();
            var abnormalItems = ItemNetworkRequest.GetAbnormalItemsAsync<List<Item>>();

            await Task.WhenAll(allRecords, unfinishedTasks, abnormalItems);
            lblStorageRecordCount.Text = allRecords.Result.Data.ToList()
                .Where(a => a.Type == "入库" && a.RecordState == "已完成").ToList().Count().ToString();
            lblStockOutRecordCount.Text = allRecords.Result.Data.ToList()
                .Where(a => a.Type == "出库" && a.RecordState == "已完成").ToList().Count().ToString();
            lblUnfinishedTaskCount.Text = unfinishedTasks.Result.Data.Count.ToString();
            //lblAbnormalItemCount.Text = abnormalItems.Result.Data.Count.ToString();

            //abnormalItems.Result.Data.ToList().Bind(dgvAbnormalItemData);
            unfinishedTasks.Result.Data.ToList().Bind(dgvUnfinishedTaskData);
            var itemAnomalyDetailColumn = new DataGridViewLinkColumn
            {
                Text = "Detail",
                Name = "Detail",
                UseColumnTextForLinkValue = true
            };
            dgvAbnormalItemData.Columns.Add(itemAnomalyDetailColumn);

            var cancelTask = new DataGridViewLinkColumn
            {
                Text = "Cancel",
                Name = "Cancel",
                UseColumnTextForLinkValue = true
            };
            dgvUnfinishedTaskData.Columns.Add(cancelTask);
        }

        private async void dgvUnfinishedTaskData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvUnfinishedTaskData.Columns["Cancel"] != dgvUnfinishedTaskData.Columns[e.ColumnIndex])
                return;

            var info = await dgvUnfinishedTaskData.Rows[e.RowIndex].Cells["Id"].Value._2Int().DeleteRecordAsync<string>();
            if (info.Success)
            {
                "取消成功".Msg();
                LoadInfo();
            }
            else
            {
                "取消失败".Msg();
            }
        }

        private void dgvAbnormalItemData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvAbnormalItemData.Columns["Detail"] != dgvAbnormalItemData.Columns[e.ColumnIndex]) return;

            var frm = new FrmAnomalyItemDetail(dgvAbnormalItemData.Rows[e.RowIndex].Cells["ItemId"].Value._2Int(), this.Parent);
            frm.FormClosed += delegate
            {
                LoadInfo();
            };
            frm.Show();
        }
    }

    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public int ItemCount { get; set; }
        public int ItemSafeCount { get; set; }
    }


    public class Record
    {
        public int Id { get; set; }
        public string RecordState { get; set; }
        public string Type { set; get; }
        public int ItemId { set; get; }
        public string ItemName { set; get; }
        public int Count { set; get; }
        public string Note { set; get; }
        public DateTime CreateTime { set; get; }
        public DateTime EndTime { set; get; }
        public DateTime? FinishedTime { set; get; }
        public int? UserId { set; get; }
        public string UserName { set; get; }
        public int PlaceForStorageDetailId { set; get; }
        public string PlaceForStorageDetailName { set; get;}
    }
}
