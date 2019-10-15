using CCWin;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
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
    public partial class FrmBattleDetail : CCSkinMain
    {
        static public int QueryBattle_id { get; set; }
        public FrmBattleDetail()
        {
            InitializeComponent();
            //FrmBattleDetail frm = new FrmBattleDetail();
            //frm.ShowDialog();
        }

        public void FrmBattleDetail_Load(object sender, EventArgs e)
        {
            skinToolTipBattleDetail.SetToolTip(spbPlayer, "玩家ID：" + User.user_id);
            skinToolTipBattleDetail.SetToolTip(skinPictureBox1, "返回");
            var client = new RestClient("https://api.shisanshui.rtxux.xyz/history/" + QueryBattle_id.ToString());
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-auth-token", User.token);
            IRestResponse response = client.Execute(request);
            JObject jo = (JObject)JsonConvert.DeserializeObject(response.Content);

            if ((int)jo["status"] == 0)
            {


                JArray ja = (JArray)jo["data"]["detail"];
                List<BattleDetailInfo> listBattleDetail = new List<BattleDetailInfo>();
                foreach (var item in ja)
                {
                    BattleDetailInfo tmp = new BattleDetailInfo();
                    tmp.battle_id = (int)jo["data"]["id"];
                    tmp.timestamp = (long)jo["data"]["timestamp"];
                    tmp.player_id = (int)item["player_id"];
                    tmp.name = item["name"].ToString();
                    tmp.score = (int)item["score"];
                    tmp.cardStr = item["card"].ToString();
                    listBattleDetail.Add(tmp);
                }
                sdgvBattleDetail.AutoGenerateColumns = false;
                sdgvBattleDetail.DataSource = null;
                sdgvBattleDetail.DataSource = listBattleDetail;
            }
            else
            {
                this.Close();
                MessageBox.Show("战局不存在或未结束", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void skinPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
