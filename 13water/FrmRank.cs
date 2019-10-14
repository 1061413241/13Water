using CCWin;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13water
{
    public partial class FrmRank : CCSkinMain
    {
        public FrmRank()
        {
            InitializeComponent();
        }

        private void FrmRank_Load(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.shisanshui.rtxux.xyz/rank");
            request.Method = "GET";
            request.AllowAutoRedirect = false;
            HttpWebResponse reponse = (HttpWebResponse)request.GetResponse();
            string cc = reponse.GetResponseHeader("Location");
            var client = new RestClient(cc);
            var request1 = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request1);
            JArray ja = (JArray)JsonConvert.DeserializeObject(response.Content);

            List<RankInfo> listRank = new List<RankInfo>();
            foreach (var item in ja)
            {
                RankInfo tmp = new RankInfo();
                tmp.play_id = (int)item["player_id"];
                tmp.score = (int)item["score"];
                tmp.name = item["name"].ToString();
                listRank.Add(tmp);
            }
            sdgvRank.AutoGenerateColumns = false;
            sdgvRank.DataSource = null;
            sdgvRank.DataSource = listRank;

            //列宽自适应
            //foreach (DataGridViewColumn column in sdgvRank.Columns)
            //{
            //    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //}

        }

        private void skinPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 单击单元格发生的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sdgvRank_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
