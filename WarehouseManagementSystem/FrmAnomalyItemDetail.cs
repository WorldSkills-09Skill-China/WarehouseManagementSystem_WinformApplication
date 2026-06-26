using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManagementSystem
{
    public partial class FrmAnomalyItemDetail : FrmTemplate
    {
        int _id;
        Form _frm;
        public FrmAnomalyItemDetail(int id, Control frm)
        {
            InitializeComponent();
            _id = id;
            _frm = frm as Form;
        }

        private void FrmAnomalyItemDetail_Load(object sender, EventArgs e)
        {
            Loadinfo();
        }

        public async void Loadinfo()
        {
            flpAnomalyItemDetail.Controls.Clear();
            var data = await _id.GetItemAnomaliesAsync<List<ItemAnomaly>>();
            foreach (var itemAnomalies in data.Data)
            {
                var ucAnomalyRecord = new UCAnomalyRecord(itemAnomalies, _id);
                flpAnomalyItemDetail.Controls.Add(ucAnomalyRecord);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class ItemAnomaly
    {
        public int ItemCount { get; set; }
        public string Anomaly { get; set; }
        public bool TypeId { get; set; }
        public string State { get; set; }
    }
}
