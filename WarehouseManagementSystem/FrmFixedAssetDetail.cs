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
    public partial class FrmFixedAssetDetail : FrmTemplate
    {
        string _code;
        public FrmFixedAssetDetail(string code)
        {
            InitializeComponent();
            _code = code;
        }

        private void dtpFirstTime_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFirstTime.Value > dtpLastTime.Value)
            {
                "时间逻辑错误".Msg();
                return;
            }
            LoadInfor();
        }

        private void dtpLastTime_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFirstTime.Value > dtpLastTime.Value)
            {
                "时间逻辑错误".Msg();
                return;
            }
            LoadInfor();
        }

        public async void LoadInfor()
        {
            dgvFixedAssetHistoryList.Columns.Clear();
            var fixedAssetHistoryListInfo = await _code.GetFixedAssetHistory<List<FixedAssetData>>(dtpFirstTime.Value, dtpLastTime.Value);
            fixedAssetHistoryListInfo.Data.Bind(dgvFixedAssetHistoryList);
            var deleteColumn = new DataGridViewLinkColumn
            {
                Text = "Delete",
                Name = "Delete",
                UseColumnTextForLinkValue = true
            };
            dgvFixedAssetHistoryList.Hide("ItemId");
            dgvFixedAssetHistoryList.Hide("UserId");
            dgvFixedAssetHistoryList.Hide("PlaceForStorageDetailId");
        }

        private void FrmFixedAssetDetail_Load(object sender, EventArgs e)
        {
            LoadInfor();
        }
    }

    public class FixedAssetHistory
    {
        int Id { get; set; }
        string ItemName { get; set; }
        string Code { get; set; }
        string UserName { get; set; }
        string Note { get; set; }
        DateTime OperationTime { get; set; }
        string PlaceForStorageDetail { get; set; }
    }
}
