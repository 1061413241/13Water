namespace _13water
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.sbtnBattle = new CCWin.SkinControl.SkinButton();
            this.sbtnRecord = new CCWin.SkinControl.SkinButton();
            this.sbtnRank = new CCWin.SkinControl.SkinButton();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            this.spbClose = new CCWin.SkinControl.SkinPictureBox();
            this.sToolTipMain = new CCWin.SkinToolTip(this.components);
            this.spbPlayer = new CCWin.SkinControl.SkinPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // sbtnBattle
            // 
            this.sbtnBattle.BackColor = System.Drawing.Color.Transparent;
            this.sbtnBattle.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sbtnBattle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtnBattle.DownBack = null;
            this.sbtnBattle.Font = new System.Drawing.Font("华文行楷", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtnBattle.ForeColor = System.Drawing.SystemColors.Menu;
            this.sbtnBattle.Location = new System.Drawing.Point(639, 397);
            this.sbtnBattle.MouseBack = null;
            this.sbtnBattle.Name = "sbtnBattle";
            this.sbtnBattle.NormlBack = null;
            this.sbtnBattle.Radius = 60;
            this.sbtnBattle.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.sbtnBattle.Size = new System.Drawing.Size(300, 133);
            this.sbtnBattle.TabIndex = 0;
            this.sbtnBattle.Text = "对战";
            this.sbtnBattle.UseVisualStyleBackColor = false;
            this.sbtnBattle.Click += new System.EventHandler(this.sbtnBattle_Click);
            // 
            // sbtnRecord
            // 
            this.sbtnRecord.BackColor = System.Drawing.Color.Transparent;
            this.sbtnRecord.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.sbtnRecord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.sbtnRecord.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sbtnRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtnRecord.DownBack = null;
            this.sbtnRecord.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.sbtnRecord.Font = new System.Drawing.Font("华文行楷", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtnRecord.ForeColor = System.Drawing.SystemColors.Menu;
            this.sbtnRecord.Location = new System.Drawing.Point(639, 587);
            this.sbtnRecord.MouseBack = null;
            this.sbtnRecord.Name = "sbtnRecord";
            this.sbtnRecord.NormlBack = null;
            this.sbtnRecord.Radius = 60;
            this.sbtnRecord.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.sbtnRecord.Size = new System.Drawing.Size(300, 133);
            this.sbtnRecord.TabIndex = 1;
            this.sbtnRecord.Text = "历史战局";
            this.sbtnRecord.UseVisualStyleBackColor = false;
            this.sbtnRecord.Click += new System.EventHandler(this.sbtnRecord_Click);
            // 
            // sbtnRank
            // 
            this.sbtnRank.BackColor = System.Drawing.Color.Transparent;
            this.sbtnRank.BaseColor = System.Drawing.Color.Green;
            this.sbtnRank.BorderColor = System.Drawing.Color.Green;
            this.sbtnRank.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sbtnRank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtnRank.DownBack = null;
            this.sbtnRank.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.sbtnRank.Font = new System.Drawing.Font("华文行楷", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtnRank.ForeColor = System.Drawing.SystemColors.Menu;
            this.sbtnRank.Location = new System.Drawing.Point(1046, 397);
            this.sbtnRank.MouseBack = null;
            this.sbtnRank.Name = "sbtnRank";
            this.sbtnRank.NormlBack = null;
            this.sbtnRank.Radius = 60;
            this.sbtnRank.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.sbtnRank.Size = new System.Drawing.Size(300, 133);
            this.sbtnRank.TabIndex = 2;
            this.sbtnRank.Text = "排行榜";
            this.sbtnRank.UseVisualStyleBackColor = false;
            this.sbtnRank.Click += new System.EventHandler(this.sbtnRank_Click);
            // 
            // skinButton3
            // 
            this.skinButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.skinButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton3.DownBack = null;
            this.skinButton3.DownBaseColor = System.Drawing.Color.Purple;
            this.skinButton3.Font = new System.Drawing.Font("华文行楷", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton3.ForeColor = System.Drawing.SystemColors.Menu;
            this.skinButton3.Location = new System.Drawing.Point(1046, 587);
            this.skinButton3.MouseBack = null;
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = null;
            this.skinButton3.Radius = 60;
            this.skinButton3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton3.Size = new System.Drawing.Size(300, 133);
            this.skinButton3.TabIndex = 3;
            this.skinButton3.Text = "更多玩法";
            this.skinButton3.UseVisualStyleBackColor = false;
            this.skinButton3.Click += new System.EventHandler(this.skinButton3_Click);
            // 
            // spbClose
            // 
            this.spbClose.BackColor = System.Drawing.Color.Transparent;
            this.spbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spbClose.Image = ((System.Drawing.Image)(resources.GetObject("spbClose.Image")));
            this.spbClose.Location = new System.Drawing.Point(1346, 20);
            this.spbClose.Name = "spbClose";
            this.spbClose.Size = new System.Drawing.Size(64, 68);
            this.spbClose.TabIndex = 4;
            this.spbClose.TabStop = false;
            this.spbClose.Click += new System.EventHandler(this.spbClose_Click);
            // 
            // sToolTipMain
            // 
            this.sToolTipMain.AutoPopDelay = 5000;
            this.sToolTipMain.InitialDelay = 500;
            this.sToolTipMain.OwnerDraw = true;
            this.sToolTipMain.ReshowDelay = 800;
            // 
            // spbPlayer
            // 
            this.spbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.spbPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spbPlayer.Image = ((System.Drawing.Image)(resources.GetObject("spbPlayer.Image")));
            this.spbPlayer.Location = new System.Drawing.Point(30, 20);
            this.spbPlayer.Name = "spbPlayer";
            this.spbPlayer.Size = new System.Drawing.Size(64, 64);
            this.spbPlayer.TabIndex = 5;
            this.spbPlayer.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = ((System.Drawing.Image)(resources.GetObject("$this.Back")));
            this.ClientSize = new System.Drawing.Size(1440, 810);
            this.CloseBoxSize = new System.Drawing.Size(0, 0);
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.Controls.Add(this.spbPlayer);
            this.Controls.Add(this.spbClose);
            this.Controls.Add(this.skinButton3);
            this.Controls.Add(this.sbtnRank);
            this.Controls.Add(this.sbtnRecord);
            this.Controls.Add(this.sbtnBattle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 810);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1440, 810);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton sbtnBattle;
        private CCWin.SkinControl.SkinButton sbtnRecord;
        private CCWin.SkinControl.SkinButton sbtnRank;
        private CCWin.SkinControl.SkinButton skinButton3;
        private CCWin.SkinControl.SkinPictureBox spbClose;
        private CCWin.SkinToolTip sToolTipMain;
        private CCWin.SkinControl.SkinPictureBox spbPlayer;
    }
}