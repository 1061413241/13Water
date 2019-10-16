using CCWin;
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
    public partial class FrmBattle : CCSkinMain
    {
        public FrmBattle()
        {
            InitializeComponent();
        }

        private void sbtnStart_Click(object sender, EventArgs e)
        {
            string str = API_Helper.HttpPost("https://api.shisanshui.rtxux.xyz/game/open", "", User.token);
            JObject jo = (JObject)JsonConvert.DeserializeObject(str);
            int status = (int)jo["status"];
            if (status == 0)
            {
                string card = (string)jo["data"]["card"];
                User.card = card;
                int id = (int)jo["data"]["id"];
                User.battle_id = id;
                DealCards.Deal();

                //FrmMain.user_id = user_id;
                MessageBox.Show("加入战局成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.DialogResult = System.Windows.Forms.DialogResult.OK;
                FrmPlay frm = new FrmPlay();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("开启战局失败", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void skinPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBattle_Load(object sender, EventArgs e)
        {
            skinToolTipBattle.SetToolTip(spbPlayer, "玩家ID：" + User.user_id);
            skinToolTipBattle.SetToolTip(skinPictureBox1, "返回");
        }

        private void sbtnRound_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已开启循环赛(默认100局)", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            int count = 100;
            while((count--)>0)
            {
                string str = API_Helper.HttpPost("https://api.shisanshui.rtxux.xyz/game/open", "", User.token);
                JObject jo = (JObject)JsonConvert.DeserializeObject(str);
                int status = (int)jo["status"];
                if (status == 0)
                {
                    string card = (string)jo["data"]["card"];
                    User.card = card;
                    int id = (int)jo["data"]["id"];
                    User.battle_id = id;
                    DealCards.Deal();

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

                    string str2 = API_Helper.HttpPost("https://api.shisanshui.rtxux.xyz/game/submit", dataStr, User.token);
                    JObject jo2 = (JObject)JsonConvert.DeserializeObject(str2);
                    int status2 = (int)jo2["status"];
                    if (status2 == 0)
                    {
                        string msg = jo2["data"]["msg"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("出牌失败", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    //结束当前战局，清空手牌
                    User.cardFirst.Clear();
                    User.cardSecond.Clear();
                    User.cardThird.Clear();

                }
                else
                {
                    MessageBox.Show("开启战局失败，参与战局数已达上限，请稍后再开启循环赛", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

            }
            MessageBox.Show("100场战局已完成", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
