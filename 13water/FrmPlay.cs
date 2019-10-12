using CCWin;
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

namespace _13water
{
    public partial class FrmPlay : CCSkinMain
    {
        public FrmPlay()
        {
            InitializeComponent();
        }

        private void FrmPlay_Load(object sender, EventArgs e)
        {
            MessageBox.Show(User.card);
        }

        private void sbtnSubmit_Click(object sender, EventArgs e)
        {
            string cardFirst = string.Join(" ", User.cardFirst);
            string cardSecond = string.Join(" ", User.cardSecond);
            string cardThird = string.Join(" ", User.cardThird);

            JObject data = new JObject();
            data.Add("id", User.battle_id);
            JArray poker = new JArray();
            poker.Add(cardFirst);
            poker.Add(cardSecond);
            poker.Add(cardThird);
            data.Add("card", poker);
            string dataStr = JsonConvert.SerializeObject(data);

            string str = API_Helper.HttpPost("https://api.shisanshui.rtxux.xyz/game/submit", dataStr, User.token);
            JObject jo = (JObject)JsonConvert.DeserializeObject(str);
            int status = (int)jo["status"];
            if (status == 0)
            {
                string msg = jo["data"]["msg"].ToString();
                if(msg== "Success")
                {
                    MessageBox.Show("出牌成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("登陆失败，用户名或密码错误", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            //结束当前战局，清空手牌
            User.cardFirst.Clear();
            User.cardSecond.Clear();
            User.cardThird.Clear();
        }
    }
}
