
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
    public partial class FrmWarehouseRecords : FrmTemplate
    {
        public FrmWarehouseRecords()
        {
            InitializeComponent();
        }

        public async Task LoadInfo()
        {
            var allRecords = await WarehouseRecordsNetworkRequest.GetRecordsAsync<List<Record>>();
            allRecords.Data.Where(a =>
            (a.UserId == cbmItemType.V || cbmItemType.V == -1) &&
                (a.ItemId == cbmItem.V || cbmItem.V == -1) &&
                (string.IsNullOrEmpty(tbSearch.V) || a.ItemName.Contains(tbSearch.V)) &&
                (!cbOnlyLoadUnfinishedTask.Checked || a.RecordState == "未完成") &&
                a.CreateTime.Date >= dtpFirstTime.Value.Date &&
                a.CreateTime.Date <= dtpLastTime.Value.Date
            ).ToList()
            .OrderByDescending(a => a.RecordState == "待审核").ToList().Bind(dgvRecordsData);

            dgvRecordsData.Hide("UserId");
            dgvRecordsData.Hide("ItemId");
            dgvRecordsData.Hide("PlaceForStorageDetailId");

            var editColumn = new DataGridViewLinkColumn
            {
                Name = "Edit",
            };

            var deleteColumn = new DataGridViewLinkColumn
            {
                Name = "Delete",
                Text = "Delete",
                UseColumnTextForLinkValue = true,
            };

            var cancelColumn = new DataGridViewLinkColumn
            {
                Name = "Cancel",
            };

            var approvalRecord = new DataGridViewLinkColumn
            {
                Name = "Approval",
            };

            dgvRecordsData.Columns.Add(editColumn);
            dgvRecordsData.Columns.Add(deleteColumn);
            dgvRecordsData.Columns.Add(cancelColumn);
            dgvRecordsData.Columns.Add(approvalRecord);

            foreach (DataGridViewRow row in dgvRecordsData.Rows)
            {
                if (row.Cells["RecordState"].Value.ToString() == "待审核")
                {
                    row.DefaultCellStyle.ForeColor = Color.Green;
                    row.Cells["Cancel"].Value = "Cancel";
                    row.Cells["Approval"].Value = "Approval";
                }
                if (row.Cells["RecordState"].Value.ToString() == "未完成")
                {
                    row.Cells["Edit"].Value = "Edit";
                }
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await LoadInfo();
        }

        private async void dtpFirstTime_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFirstTime.Value > dtpLastTime.Value)
            {
                "时间逻辑错误".Msg();
                return;
            }
            await LoadInfo();
        }

        private async void dtpLastTime_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFirstTime.Value > dtpLastTime.Value)
            {
                "时间逻辑错误".Msg();
                return;
            }
            await LoadInfo();
        }

        private async void cbOnlyLoadUnfinishedTask_CheckedChanged(object sender, EventArgs e)
        {
            await LoadInfo();
        }

        private async void FrmWarehouseRecords_Load(object sender, EventArgs e)
        {
            var operatorsData = await UsersNetworkRequest.GetOperatorsAsync();
            operatorsData.Data.Insert(0, new CbmData { Name = "All", Id = -1 });
            operatorsData.Data.Bind(cbmItemType);

            var items = await ItemNetworkRequest.GetItemsAsync();
            items.Data.Insert(0, new CbmData { Name = "All", Id = -1 });
            items.Data.Bind(cbmItem);
            await LoadInfo();
        }

        private async void dgvRecordsData_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var currentColumn = dgvRecordsData.Columns[e.ColumnIndex];
            var id = dgvRecordsData.CurrentRow.Cells["Id"].Value._2Int();
            if (currentColumn == dgvRecordsData.Columns["Edit"] && dgvRecordsData.CurrentCell.Value != null)
            {
                var frm = new FrmEditRecords(id);
                frm.FormClosed += async delegate
                {
                    await LoadInfo();
                };
                this.GoFrm(frm);
            }

            if (currentColumn == dgvRecordsData.Columns["Delete"])
            {
                var info = await id.DeleteRecordAsync<string>();
                if (info.Success)
                {
                    "删除成功".Msg();
                    await LoadInfo();
                }
                else
                {
                    "删除失败".Msg();
                }
            }

            if (currentColumn == dgvRecordsData.Columns["Approval"] && dgvRecordsData.CurrentCell.Value != null)
            {
                var info = await id.ApprocalTaskAsync<string>();
                if (info.Success)
                {
                    await LoadInfo();
                }
                else
                {
                    "审批失败".Msg();
                }
            }

            if (currentColumn == dgvRecordsData.Columns["Cancel"] && dgvRecordsData.CurrentCell.Value != null)
            {
                var info = await id.DeleteRecordAsync<string>();
                if (info.Success)
                {
                    "取消成功".Msg();
                    await LoadInfo();
                }
                else
                {
                    "取消失败".Msg();
                }
            }
        }

        private void cbmItemType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
