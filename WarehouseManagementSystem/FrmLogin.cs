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
    public partial class FrmLogin : FrmTemplate
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.V))
            {
                "名字不可以为空".Msg();
                return;
            }

            if (string.IsNullOrEmpty(tbPwd.V))
            {
                "密码不可以为空".Msg();
                return;
            }

            var data = await new { Name = tbName.V, Password = tbPwd.V }.LoginAsync<UserInfo>();
            if (!data.Success)
            {
                data.Message.Msg();
                return;
            }

            if (data.Data.RoleId == 2)
            {
                "只有管理员才能登录这个程序".Msg();
                return;
            }

            this.GoFrm(new FrmMain());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class UserInfo
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
    }
}
