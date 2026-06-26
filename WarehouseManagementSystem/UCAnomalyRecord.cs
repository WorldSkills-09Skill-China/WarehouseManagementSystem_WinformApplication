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
    public partial class UCAnomalyRecord : UserControl
    {
        ItemAnomaly _item;
        int _id;
        public UCAnomalyRecord(ItemAnomaly item, int id)
        {
            InitializeComponent();
            _item = item;
            _id = id;
        }

        private void UCAnomalyRecord_Load(object sender, EventArgs e)
        {
            lblAnomaly.Text = _item.Anomaly;
            lblState.Visible = false;
            if (_item.State == "处理中")
            {
                lklblSolveTheAnomaly.Visible = false;
                lblState.Visible = true;
                lblState.Text = "处理中";
            }
        }

        private void lklblSolveTheAnomaly_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frmMain = new FrmMain();
            (this.Parent.Parent as FrmAnomalyItemDetail).GoFrm(frmMain);
            frmMain.LoadFrm(new FrmReleaseTask(_item, _id), frmMain.btnReleaseTask);
            frmMain.FormClosed += delegate
            {
                (this.Parent.Parent as FrmAnomalyItemDetail).Loadinfo();
            };
        }
    }
}
