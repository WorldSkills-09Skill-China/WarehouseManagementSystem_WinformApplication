using Newtonsoft.Json;
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
    public partial class FrmEdtiItemSpecification : FrmTemplate
    {
        int i = 0;
        List<string> _codeList = new List<string>();
        public List<ItemSpecification> _specificationData = new List<ItemSpecification>();
        public SpecificationAccept specificationAccept = new SpecificationAccept();
        public List<SpecificationData> SpecificationList = new List<SpecificationData>();
        public FrmEdtiItemSpecification(List<string> codeList)
        {
            InitializeComponent();
            _codeList = codeList;

            dgvItemSpecifications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItemSpecifications.MultiSelect = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbKey.V))
            {
                "规格名不可以为空".Msg();
                return;
            }

            if (string.IsNullOrEmpty(tbValue.V))
            {
                "规格值不可以为空".Msg();
                return;
            }

            _specificationData.Add(new ItemSpecification
            {
                Id = i,
                Key = tbKey.V,
                Value = tbValue.V,
            });
            i++;
            LoadData();
        }

        private void dgvItemSpecifications_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dgvItemSpecifications.Columns[e.ColumnIndex] == dgvItemSpecifications.Columns["Delete"])
            {
                var specification = _specificationData.FirstOrDefault(a => a.Id == Convert.ToInt32(dgvItemSpecifications.CurrentRow.Cells["Id"].Value));
                _specificationData.Remove(specification);
                LoadData();
            }
        }

        public void LoadData()
        {
            var deleteColumn = new DataGridViewLinkColumn
            {
                Name = "Delete",
                Text = "Delete",
                UseColumnTextForLinkValue = true
            };
            dgvItemSpecifications.DataSource = null;
            _specificationData.Bind(dgvItemSpecifications);
            dgvItemSpecifications.Columns.Add(deleteColumn);
            dgvItemSpecifications.Hide("Id");
        }

        private async void EdtiItemSpecification_Load(object sender, EventArgs e)
        {
            if (_codeList.Count == 1)
            {
                var info = await _codeList[0].GetFixedAssetSepcification<string>();
                var specificationList = JsonConvert.DeserializeObject<List<SpecificationData>>(info.Data);
                foreach (var specification in specificationList)
                {
                    _specificationData.Add(new ItemSpecification
                    {
                        Id = i,
                        Key = specification.Key,
                        Value = specification.Value,
                    });
                    i++;
                }
                LoadData();
            }
        }

        private async void btnCommit_Click(object sender, EventArgs e)
        {
            foreach (var specification in _specificationData)
            {
                SpecificationList.Add(new SpecificationData
                {
                    Key = specification.Key,
                    Value = specification.Value,
                });
            }
            var specificationJson = JsonConvert.SerializeObject(SpecificationList);
            var info = await FixedAssetDataNetworkRequest.EditItemSpecification<SpecificationAccept>(new SpecificationAsk
            {
                Specification = specificationJson,
                codeList = _codeList,
            });
            if (info.Success)
            {
                "更改成功".Msg();
                specificationAccept = info.Data;
                this.Close();
            }
            else
            {
                "更改失败".Msg();
            }
        }
    }

    public class ItemSpecification
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class SpecificationData
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class SpecificationAsk
    {
        public string Specification { get; set; }
        public List<string> codeList { get; set; }
    }

    public class SpecificationAccept
    {
        public int SpecificationId { get; set; }
        public List<string> NewFixedAssets { get; set; }
    }
}

