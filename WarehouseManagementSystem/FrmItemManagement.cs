using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManagementSystem
{
    public partial class FrmItemManagement : FrmTemplate
    {
        public FrmItemManagement()
        {
            InitializeComponent();
        }

        private async void btnAddItem_Click(object sender, EventArgs e)
        {
            new FrmEditItem(-1).ShowDialog();
            await LoadInfo();
        }

        public async Task LoadInfo()
        {
            var itemData = await ItemNetworkRequest.GetItemsAsync<List<ItemDataInfo>>(cbmType.V, tbItemName.V);
            if (itemData.Data != null)
            {
                HttpClient client = new HttpClient();
                var itemDatas = itemData.Data.ToList().Select(async a =>
                {
                    byte[] image = null;
                    if (a.ImageFileName != null)
                    {
                        try
                        {
                            image = await client.GetByteArrayAsync("http://localhost:5070//" + a.ImageFileName);
                        }
                        catch
                        {
                            image = null;
                        }
                    }

                    return new
                    {
                        a.Id,
                        a.ItemName,
                        Image = image == null ? null : new Bitmap(Image.FromStream(new MemoryStream(image)), new Size(40, 40)),
                        a.ItemType,
                        a.SafeCount,
                        a.IsFixedAsset,
                    };
                }).ToList();
                var reault = await Task.WhenAll(itemDatas);
                reault.Bind(dgvItemsData);

                var imageColumn = new DataGridViewImageColumn
                {
                    Name = "Image",
                    DataPropertyName = "Image",
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                };

                var deleteColumn = new DataGridViewLinkColumn
                {
                    Name = "Delete",
                    Text = "Delete",
                    UseColumnTextForLinkValue = true,
                };

                var editColumn = new DataGridViewLinkColumn
                {
                    Name = "Edit",
                    Text = "Edit",
                    UseColumnTextForLinkValue = true,
                };

                dgvItemsData.Columns.Add(deleteColumn);
                dgvItemsData.Columns.Add(editColumn);
            }
        }

        private async void FrmItemManagement_Load(object sender, EventArgs e)
        {
            var types = TypesAndStateNetworkRequest.GetItemTypesAsync();

            await Task.WhenAll(types, LoadInfo());
            types.Result.Data.Insert(0, new CbmData { Id = -1, Name = "All" });
            types.Result.Data.ToList().Bind(cbmType);
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await LoadInfo();
        }

        private async void btnImportData_Click(object sender, EventArgs e)
        {
            new FrmImportData().ShowDialog();
            await LoadInfo();
        }

        private async void dgvItemsData_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var currentColumn = dgvItemsData.Columns[e.ColumnIndex];
            var id = dgvItemsData.CurrentRow.Cells["Id"].Value._2Int();
            if (currentColumn == dgvItemsData.Columns["Edit"])
            {
                var frm = new FrmEditItem(id);
                frm.FormClosed += async delegate
                {
                    await LoadInfo();
                };
                this.GoFrm(frm);
            }

            if (currentColumn == dgvItemsData.Columns["Delete"])
            {
                var info = await id.DeleteItemAsync<string>();
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
        }
    }
    public class ItemDataInfo
    {
        public int? Id { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public int SafeCount { get; set; }
        public string ImageFileName { get; set; }
        public bool IsFixedAsset { get; set; }
    }
}
