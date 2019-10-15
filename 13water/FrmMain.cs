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
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13water
{
    public partial class FrmMain : CCSkinMain
    {
        int trick = 10;
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 打开对战界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbtnBattle_Click(object sender, EventArgs e)
        {
            FrmBattle frm = new FrmBattle();
            frm.ShowDialog();
            //this.Visible = false;
        }

        /// <summary>
        /// 打开排行榜
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbtnRank_Click(object sender, EventArgs e)
        {
            FrmRank frm = new FrmRank();
            frm.ShowDialog();
            //this.Visible = false;
        }

        /// <summary>
        /// 打开历史战局
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbtnRecord_Click(object sender, EventArgs e)
        {
            FrmRecord frm = new FrmRecord();
            frm.ShowDialog();
            //this.Visible = false;
        }

        private void spbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            if(trick==0)
            {
                MessageBox.Show("哈哈哈，被骗了吧", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                trick = 10;
            }
            else
            {
                MessageBox.Show("点击" + trick.ToString() + "下开启更多玩法！","信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                trick--;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            sToolTipMain.SetToolTip(spbPlayer, "玩家ID：" + User.user_id);
            sToolTipMain.SetToolTip(spbClose, "退出游戏");
        }
    }
}
