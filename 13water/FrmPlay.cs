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

            //牌墩1
            LoadCard(spbCard_First1, User.cardFirst[0]);
            LoadCard(spbCard_First2, User.cardFirst[1]);
            LoadCard(spbCard_First3, User.cardFirst[2]);
            //牌墩2
            LoadCard(spbCard_Second1, User.cardSecond[0]);
            LoadCard(spbCard_Second2, User.cardSecond[1]);
            LoadCard(spbCard_Second3, User.cardSecond[2]);
            LoadCard(spbCard_Second4, User.cardSecond[3]);
            LoadCard(spbCard_Second5, User.cardSecond[4]);
            //牌墩3
            LoadCard(spbCard_Third1, User.cardThird[0]);
            LoadCard(spbCard_Third2, User.cardThird[1]);
            LoadCard(spbCard_Third3, User.cardThird[2]);
            LoadCard(spbCard_Third4, User.cardThird[3]);
            LoadCard(spbCard_Third5, User.cardThird[4]);
        }

        /// <summary>
        /// 根据传入的牌型在相应的picturebox里加载
        /// </summary>
        /// <param name="spb"></param>
        /// <param name="cardtype"></param>
        private void LoadCard(CCWin.SkinControl.SkinPictureBox spb,string cardtype)
        {
            string card = cardtype;
            if(card[0]=='*')
            {
                card = card.Substring(1);
                spb.Load("images/扑克牌图片/_" + card + ".jpg");
            }
            else
            {
                spb.Load("images/扑克牌图片/" + card + ".jpg");

            }
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
                MessageBox.Show("出牌失败", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            //结束当前战局，清空手牌
            User.cardFirst.Clear();
            User.cardSecond.Clear();
            User.cardThird.Clear();
        }

        private void skinPictureBox1_Click(object sender, EventArgs e)
        {
            //结束当前战局，清空手牌
            User.cardFirst.Clear();
            User.cardSecond.Clear();
            User.cardThird.Clear();
            this.Close();
        }
    }
}
