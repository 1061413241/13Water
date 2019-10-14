using MetroFramework.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13water
{
    public partial class FrmReg : MetroForm
    {
        public FrmReg()
        {
            InitializeComponent();
        }

        private void FrmReg_Load(object sender, EventArgs e)
        {

        }

        //注册按钮
        private void btnReg_Click(object sender, EventArgs e)
        {
            string user_id = txtUser.Text.Trim();
            string user_pwd = txtPwd.Text.Trim();

            string str = API_Helper.HttpPost("https://api.shisanshui.rtxux.xyz/auth/register", "{\"username\":\"" + user_id + "\",\"password\":\"" + user_pwd + "\"}", "");
            JObject jo = (JObject)JsonConvert.DeserializeObject(str);
            int status = (int)jo["status"];
            if (status == 0)
            {
                //FrmMain.user_id = user_id;
                MessageBox.Show("注册成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;

            }
            else
            {
                MessageBox.Show("注册失败", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        //取消按钮
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
