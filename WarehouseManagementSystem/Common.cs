using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WarehouseManagementSystem
{
    static class Common
    {
        public static string firstUrl = "http://localhost:5070/api/"/*"http://192.168.20.145:7014/api/"*/;
        public static HttpClient client = new HttpClient();
        static public void GoFrm(this Form thisFrm, Form toFrm)
        {
            toFrm.Owner = thisFrm;
            thisFrm.Hide();
            toFrm.Show();
        }

        static public void BackFrm(this Form toFrm)
        {
            toFrm.Owner?.Show();
        }

        public static void Msg(this string msg)
        {
            MessageBox.Show(msg);
        }

        public static int _2Int(this object data)
        {
            if (int.TryParse(data.ToString(), out int n)) return n;
            return -1;
        }

        public static void Bind(this object dataSource, Dgv dgv)
        {
            dgv.Columns.Clear();
            dgv.DataSource = dataSource;
        }

        public static void Bind(this object dataSource, Cbm cbm)
        {
            cbm.ValueMember = "Id";
            cbm.DisplayMember = "Name";
            cbm.DataSource = dataSource;
        }

        public static async Task<ClassData<T>> Get<T>(this string url)
        {
            var allUrl = firstUrl + url;
            var response = await client.GetAsync(allUrl);
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ClassData<T>>(json);
        }

        public static async Task<ClassData<T>> Post<T>(this string url, object data)
        {
            var allUrl = firstUrl + url;
            string json = JsonConvert.SerializeObject(data);
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(allUrl, stringContent);
            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ClassData<T>>(result);
        }
    }

    public class Cbm : ComboBox
    {
        public Cbm()
        {
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public int V => SelectedValue?._2Int() ?? -1;
    }

    public class Btn : Button
    {
        public Btn()
        {
            this.BackColor = Color.Blue;
            this.ForeColor = Color.Blue;
            this.FlatStyle = FlatStyle.Flat;
        }
    }

    public class Dgv : DataGridView
    {
        public Dgv()
        {
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.RowHeadersVisible = false;
            this.RowTemplate.Height = 25;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void Hide(string name)
        {
            if (this.Rows.Count <= 0)
            {
                return;
            }
            this.Columns[name].Visible = false;
        }

        public string GetSelectedVal(string cellName)
        {
            if (this.Rows.Count <= 0 || this.CurrentRow == null)
            {
                return null;
            }
            return this.CurrentRow.Cells[cellName].Value.ToString();
        }
    }

    public class Tb : TextBox
    {
        public Tb()
        {

        }
        public string V => this.Text.ToString().Trim();
    }

    public class ClassData<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public DateTime TimeStamp { get; set; }
        public T Data { get; set; }
    }

    public static class PlaceForStorageDetailsNetworkRequest
    {
        public static async Task<ClassData<List<CbmData>>> GetPlacesAsync(int id, int batch)
        {
            return await $"PlaceForStorageDetails/showAllLocation?id={id}&batch={batch}".Get<List<CbmData>>();
        }

        public static async Task<ClassData<T>> GetPlaceImageAsync<T>(this int id)
        {
            return await "PlaceForStorageDetails/showLocationImage".Post<T>(id);
        }
    }

    public static class UsersNetworkRequest
    {
        public static async Task<ClassData<T>> LoginAsync<T>(this object data)
        {
            return await "Users/login".Post<T>(data);
        }

        public static async Task<ClassData<List<CbmData>>> GetOperatorsAsync()
        {
            return await "Users/showUserList".Get<List<CbmData>>();
        }
    }

    public static class FixedAssetHistoryNetworkRequest
    {
        public static async Task<ClassData<T>> GetFixedAssetHistory<T>(this string code, DateTime firstTime, DateTime lastTime)
        {
            return await $"Items/showAssetHistory?id={code}&first={firstTime}&end={lastTime}".Get<T>();
        }

        public static async Task<ClassData<T>> DeleteFixedAssetHistory<T>(this int id)
        {
            return await $"Items/deleteFixAssetHistory?id={id}".Get<T>();
        }
    }

    public static class FixedAssetDataNetworkRequest
    {
        public static async Task<ClassData<T>> EditItemSpecification<T>(SpecificationAsk specification)
        {
            return await "Items/editItemSpecification".Post<T>(specification);
        }

        public static async Task<ClassData<int>> GetLastId()
        {
            return await "Items/showLargestFixedAsset".Get<int>();
        }

        public static async Task<ClassData<T>> GetFixedAssetData<T>(this int id)
        {
            return await "Items/showFixedAsset".Post<T>(id);
        }

        public static async Task<ClassData<T>> GetFixedAssetSepcification<T>(this string code)
        {
            return await $"Items/getItemSpecification?code={code}".Get<T>();
        }
    }

    public static class ItemNetworkRequest
    {
        public static async Task<ClassData<List<CbmData>>> GetTypeItems(this int typeId)
        {
            return await "Types/displayTypeItem".Post<List<CbmData>>(typeId);
        }

        public static async Task<ClassData<List<CbmData>>> GetItemType()
        {
            return await $"Types/showAllType".Get<List<CbmData>>();
        }

        public static async Task<ClassData<T>> ReturnBatchItem<T>(int count, int batch, int itemId)
        {
            return await $"Items/returnBatchItem?count={count}&batch={batch}&id={itemId}".Get<T>();
        }

        public static async Task<ClassData<T>> ImportItemsData<T>(List<ItemData> items)
        {
            return await "Items/batchImportOfData".Post<T>(items);
        }

        public static async Task<ClassData<T>> IsHaveAbnormalItems<T>()
        {
            return await "Items/unresolvedAbnormalItem".Get<T>();
        }
        public static async Task<ClassData<T>> GetAbnormalItemsAsync<T>()
        {
            return await "Items/showAbnormalItems".Get<T>();
        }

        public static async Task<ClassData<T>> GetItemAnomaliesAsync<T>(this int id)
        {
            return await "Items/abnormalJudgmentProblem".Post<T>(id);
        }

        public static async Task<ClassData<List<CbmData>>> GetItemsAsync()
        {
            return await "Items/showItemList".Get<List<CbmData>>();
        }

        public static async Task<ClassData<T>> GetItemImageAsync<T>(this int id)
        {
            return await "Items/showItemImage".Post<T>(id);
        }

        public static async Task<ClassData<T>> GetItemsAsync<T>(int typeId, string itemName)
        {
            return await $"Items/showSearchItems".Post<T>(new
            {
                typeId,
                itemName
            });
        }

        public static async Task<ClassData<T>> AddItemAsync<T>(this AskItem item)
        {
            return await "Items/addItems".Post<T>(item);
        }

        public static async Task<ClassData<T>> DeleteItemAsync<T>(this int id)
        {
            return await "Items/deleteItems".Post<T>(id);
        }

        public static async Task<ClassData<T>> GetItemAsync<T>(this int id)
        {
            return await "Items/showItemDetail".Post<T>(id);
        }

        public static async Task<ClassData<T>> EditItemAsync<T>(this AskItem item)
        {
            return await "Items/editItems".Post<T>(item);
        }
    }

    public static class WarehouseRecordsNetworkRequest
    {
        public static async Task<ClassData<T>> QueryRecord<T>(int itemId, int itemTypeId, bool isFinishRecords)
        {
            return await $"WarehouseRecords/quaryRecord?itemId={itemId}&itemTypeId={itemTypeId}&isFinishRecords={isFinishRecords}".Get<T>();
        }
        public static async Task<ClassData<List<CbmData>>> GetItemBatches(this int itemId, int recordTypeId)
        {
            return await $"WarehouseRecords/itemBatches?itemId={itemId}&recordTypeId={recordTypeId}".Get<List<CbmData>>();
        }
        public static async Task<ClassData<T>> GetRecordDetail<T>(this int id)
        {
            return await "WarehouseRecords/showRecordDetail".Post<T>(id);
        }
        public static async Task<ClassData<T>> GetRecordsCountAsync<T>()
        {
            return await "WarehouseRecords/showDeliveryAndStorageCount".Get<T>();
        }
        public static async Task<ClassData<T>> GetUnfinishedTasksAsync<T>()
        {
            return await "WarehouseRecords/showUnFinishedTask".Get<T>();
        }

        public static async Task<ClassData<T>> DeleteRecordAsync<T>(this int id)
        {
            return await "WarehouseRecords/deleteTheTask".Post<T>(id);
        }

        public static async Task<ClassData<T>> AddTask<T>(this TaskData task)
        {
            return await "WarehouseRecords/addRecord".Post<T>(task);
        }

        public static async Task<ClassData<T>> GetTaskDetail<T>(this int id)
        {
            return await "WarehouseRecords/showTaskDetail".Post<T>(id);
        }

        public static async Task<ClassData<T>> ApprocalTaskAsync<T>(this int id)
        {
            return await "WarehouseRecords/approvalTask".Post<T>(id);
        }

        public static async Task<ClassData<T>> EditRecordsAsync<T>(this TaskData task)
        {
            return await "WarehouseRecords/editRecord".Post<T>(task);
        }
    }

    public static class TypesAndStateNetworkRequest
    {
        public static async Task<ClassData<List<CbmData>>> GetItemTypesAsync()
        {
            return await "Types/showAllType".Get<List<CbmData>>();
        }

        public static async Task<ClassData<List<CbmData>>> GetRecordStatesAsync()
        {
            return await "RecordStates/showRecordStates".Get<List<CbmData>>();
        }

        public static async Task<ClassData<List<CbmData>>> GetRecordTypesAsync()
        {
            return await "RecordTypesValues/showRecordType".Get<List<CbmData>>();
        }
    }


    public class CbmData
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
