using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using CCWin.SkinClass;
using CCWin;

namespace _13water
{
    public partial class FrmLogin : MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        //登录按钮
        private void btnEnter_Click(object sender, EventArgs e)
        {
            Login();
        }

        //取消按钮
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //注册按钮
        private void lblReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmReg frm = new FrmReg();
            frm.ShowDialog();

        }


        private void Login()//登录方法
        {
            string user_id = txtUser.Text;
            string user_pwd = txtPwd.Text;
            
            string str=API_Helper.HttpPost("https://api.shisanshui.rtxux.xyz/auth/login", "{\"username\":\""+user_id+"\",\"password\":\""+user_pwd+"\"}", "");
            JObject jo = (JObject)JsonConvert.DeserializeObject(str);
            int status = (int)jo["status"];
            if (status==0)
            {
                string token = (string)jo["data"]["token"];
                User.token = token;
                int id = (int)jo["data"]["user_id"];
                User.user_id = id;
                //FrmMain.user_id = user_id;
                MessageBox.Show("登录成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;

            }
            else
            {
                MessageBox.Show("登陆失败，用户名或密码错误", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            //if (string.IsNullOrEmpty(message))
            //{
            //    FrmMain.user_id = user_id;
            //    //MessageBox.Show("登录成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //      this.DialogResult = System.Windows.Forms.DialogResult.OK;
            //}
            //else
            //{
            //    MessageBox.Show(message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Return)
            {
                Login();
            }
        }
    }
}
