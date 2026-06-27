using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace WarehouseManagementSystem
{
    public partial class FrmImportData : FrmTemplate
    {
        List<ItemData> items = new List<ItemData>();
        public FrmImportData()
        {
            InitializeComponent();
        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "|*.csv;*.xlsx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.EndsWith(".xlsx"))
                {
                    XLSXImportData(openFileDialog.FileName);
                }
                else
                {
                    CSVImportData(openFileDialog.FileName);
                }
            }
        }

        public void XLSXImportData(string filName)
        {
            ExcelPackage.License.SetNonCommercialPersonal("WarehouseManagementSystem");
            using (var package = new ExcelPackage(new FileInfo(filName)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;
                int columnCount = worksheet.Dimension.Columns;

                var column = $"{worksheet.Cells[1, 1].Text},{worksheet.Cells[1, 2].Text},{worksheet.Cells[1, 3].Text},{worksheet.Cells[1, 4].Text},{worksheet.Cells[1, 5].Text},{worksheet.Cells[1, 6].Text},{worksheet.Cells[1, 7].Text}";
                if (column != "ItemName,ItemType,SafeCount,Count,IsFixedAsset,PlaceForStorageDetail,Unit")
                {
                    "数据格式错误解析失败".Msg();
                    return;
                }

                var currentItems = new List<ItemData>();
                try
                {
                    for (int row = 2; row <= rowCount; row++)
                    {
                        currentItems.Add(new ItemData
                        {
                            ItemName = worksheet.Cells[row, 1].Text,
                            ItemType = worksheet.Cells[row, 2].Text,
                            SafeCount = Convert.ToInt32(worksheet.Cells[row, 3].Text),
                            Count = Convert.ToInt32(worksheet.Cells[row, 4].Text),
                            IsFixedAsset = Convert.ToBoolean(worksheet.Cells[row, 5].Text),
                            PlaceForStorageDetail = worksheet.Cells[row, 6].Text,
                            Unit = worksheet.Cells[row, 7].Text,
                        });
                    }
                    items.AddRange(currentItems);
                    dgvItemData.DataSource = null;
                    dgvItemData.DataSource = items;
                }
                catch
                {
                    "数据错误解析失败".Msg();
                    return;
                }
            }
        }

        public void CSVImportData(string fileName)
        {
            try
            {
                var itemsInfo = File.ReadAllText(fileName).Trim();
                var itemsData = itemsInfo.Split('\n');
                if (itemsData[0].TrimEnd('\r') != "ItemName,ItemType,SafeCount,Count,IsFixedAsset,PlaceForStorageDetail,Unit")
                {
                    "数据格式错误解析失败".Msg();
                    return;
                }

                var currentItems = new List<ItemData>();

                try
                {
                    for (int i = 1; i < itemsData.Count(); i++)
                    {
                        var itemData = itemsData[i].TrimEnd('\r').Split(',');
                        currentItems.Add(new ItemData
                        {
                            ItemName = itemData[0],
                            ItemType = itemData[1],
                            SafeCount = Convert.ToInt32(itemData[2]),
                            Count = Convert.ToInt32(itemData[3]),
                            IsFixedAsset = Convert.ToBoolean(itemData[4]),
                            PlaceForStorageDetail = itemData[5],
                            Unit = itemData[6],
                        });
                    }
                    items.AddRange(currentItems);
                    dgvItemData.DataSource = null;
                    dgvItemData.DataSource = items;
                }
                catch
                {
                    "数据错误解析失败".Msg();
                    return;
                }
            }
            catch
            {
                "文件被打开请关闭该文件".Msg();
                return;
            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            items.Clear();
            dgvItemData.DataSource = null;
            dgvItemData.DataSource = items;
        }

        private async void btnCommit_Click(object sender, EventArgs e)
        {
            if (items.Count <= 0)
            {
                "导入的数据不能为空".Msg();
                return;
            }

            var info = await ItemNetworkRequest.ImportItemsData<string>(items);
            if (info.Success)
            {
                "导入成功".Msg();
                this.Close();
            }
            else
            {
                info.Message.Msg();
            }
        }

        private void dgvItemData_DragDrop_1(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            var filesData = files.Where(a =>
            a.EndsWith(".csv", StringComparison.OrdinalIgnoreCase)
            || a.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase)
            ).ToList();

            foreach (var item in filesData)
            {
                if (item.EndsWith(".xlsx"))
                {
                    XLSXImportData(item);
                }
                else
                {
                    CSVImportData(item);
                }
            }
        }

        private void dgvItemData_DragEnter_1(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }

    public class ItemData
    {
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public int SafeCount { get; set; }
        public int Count { get; set; }
        public bool IsFixedAsset { get; set; }
        public string PlaceForStorageDetail { set; get; }
        public string Unit { get; set; }
    }

}
