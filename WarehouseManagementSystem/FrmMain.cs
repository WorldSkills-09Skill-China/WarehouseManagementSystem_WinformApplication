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
    public partial class FrmMain : FrmTemplate
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public void ResetMenu()
        {
            btnHome.FlatAppearance.BorderSize = 0;
            btnItemManagement.FlatAppearance.BorderSize = 0;
            btnReleaseTask.FlatAppearance.BorderSize = 0;
            btnWarehouseRecords.FlatAppearance.BorderSize = 0;
        }

        public void LoadFrm(Form frm, Button btn)
        {
            if (btn.FlatAppearance.BorderSize == 1)
            {
                return;
            }
            ResetMenu();
            btn.FlatAppearance.BorderSize = 1;
            plFrm.Controls.Clear();
            frm.TopLevel = false;
            frm.Parent = plFrm;
            plFrm.Controls.Add(frm);
            frm.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadFrm(new FrmHome(), btnHome);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadFrm(new FrmHome(), btnHome);
        }

        private void btnWarehouseRecords_Click(object sender, EventArgs e)
        {
            LoadFrm(new FrmWarehouseRecords(), btnWarehouseRecords);
        }

        private void btnReleaseTask_Click(object sender, EventArgs e)
        {
            LoadFrm(new FrmReleaseTask(null, 0), btnReleaseTask);
        }

        private void btnItemManagement_Click(object sender, EventArgs e)
        {
            LoadFrm(new FrmItemManagement(), btnItemManagement);
        }

        private async void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //var abnormalItems = await ItemNetworkRequest.IsHaveAbnormalItems<bool>();
            //if (abnormalItems.Data)
            //{
            //    if (MessageBox.Show("还有异常物品为处理，是否退出", "系统提示", MessageBoxButtons.YesNo) == DialogResult.No)
            //    {
            //        e.Cancel= true;
            //    }
            //}
        }
    }
}
