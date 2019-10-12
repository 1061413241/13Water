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
    }
}
