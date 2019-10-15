namespace _13water
{
    partial class FrmRecord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecord));
            this.sdgvMyRecord = new CCWin.SkinControl.SkinDataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColCard = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.stxtQuery_id = new CCWin.SkinControl.SkinTextBox();
            this.skbtnSearch = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.spbPlayer = new CCWin.SkinControl.SkinPictureBox();
            this.skinToolTipRecord = new CCWin.SkinToolTip(this.components);
            this.skinPictureBoxPre = new CCWin.SkinControl.SkinPictureBox();
            this.skinPictureBoxNext = new CCWin.SkinControl.SkinPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sdgvMyRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBoxPre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBoxNext)).BeginInit();
            this.SuspendLayout();
            // 
            // sdgvMyRecord
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.sdgvMyRecord.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.sdgvMyRecord.BackgroundColor = System.Drawing.SystemColors.Window;
            this.sdgvMyRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sdgvMyRecord.ColumnFont = null;
            this.sdgvMyRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sdgvMyRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.sdgvMyRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sdgvMyRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColCard,
            this.ColScore,
            this.ColTime});
            this.sdgvMyRecord.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sdgvMyRecord.DefaultCellStyle = dataGridViewCellStyle7;
            this.sdgvMyRecord.EnableHeadersVisualStyles = false;
            this.sdgvMyRecord.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sdgvMyRecord.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sdgvMyRecord.HeadFont = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sdgvMyRecord.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.sdgvMyRecord.Location = new System.Drawing.Point(259, 282);
            this.sdgvMyRecord.Name = "sdgvMyRecord";
            this.sdgvMyRecord.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sdgvMyRecord.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.sdgvMyRecord.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.sdgvMyRecord.RowTemplate.Height = 23;
            this.sdgvMyRecord.Size = new System.Drawing.Size(964, 376);
            this.sdgvMyRecord.TabIndex = 3;
            this.sdgvMyRecord.TitleBack = null;
            this.sdgvMyRecord.TitleBackColorBegin = System.Drawing.Color.White;
            this.sdgvMyRecord.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.sdgvMyRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sdgvMyRecord_CellContentClick);
            // 
            // ColID
            // 
            this.ColID.DataPropertyName = "battle_id";
            this.ColID.HeaderText = "战局ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColID.Width = 110;
            // 
            // ColCard
            // 
            this.ColCard.DataPropertyName = "cardStr";
            this.ColCard.HeaderText = "牌型";
            this.ColCard.Name = "ColCard";
            this.ColCard.ReadOnly = true;
            this.ColCard.Width = 550;
            // 
            // ColScore
            // 
            this.ColScore.DataPropertyName = "score";
            this.ColScore.HeaderText = "得分";
            this.ColScore.Name = "ColScore";
            this.ColScore.ReadOnly = true;
            this.ColScore.Width = 110;
            // 
            // ColTime
            // 
            this.ColTime.DataPropertyName = "timestamp";
            this.ColTime.HeaderText = "结算时间";
            this.ColTime.Name = "ColTime";
            this.ColTime.ReadOnly = true;
            this.ColTime.Width = 150;
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("skinPictureBox1.Image")));
            this.skinPictureBox1.Location = new System.Drawing.Point(30, 20);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(69, 62);
            this.skinPictureBox1.TabIndex = 4;
            this.skinPictureBox1.TabStop = false;
            this.skinPictureBox1.Click += new System.EventHandler(this.skinPictureBox1_Click);
            // 
            // stxtQuery_id
            // 
            this.stxtQuery_id.BackColor = System.Drawing.Color.Transparent;
            this.stxtQuery_id.DownBack = null;
            this.stxtQuery_id.Icon = ((System.Drawing.Image)(resources.GetObject("stxtQuery_id.Icon")));
            this.stxtQuery_id.IconIsButton = false;
            this.stxtQuery_id.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.stxtQuery_id.IsPasswordChat = '\0';
            this.stxtQuery_id.IsSystemPasswordChar = false;
            this.stxtQuery_id.Lines = new string[0];
            this.stxtQuery_id.Location = new System.Drawing.Point(530, 239);
            this.stxtQuery_id.Margin = new System.Windows.Forms.Padding(0);
            this.stxtQuery_id.MaxLength = 32767;
            this.stxtQuery_id.MinimumSize = new System.Drawing.Size(28, 28);
            this.stxtQuery_id.MouseBack = null;
            this.stxtQuery_id.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.stxtQuery_id.Multiline = false;
            this.stxtQuery_id.Name = "stxtQuery_id";
            this.stxtQuery_id.NormlBack = null;
            this.stxtQuery_id.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.stxtQuery_id.ReadOnly = false;
            this.stxtQuery_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stxtQuery_id.Size = new System.Drawing.Size(403, 28);
            // 
            // 
            // 
            this.stxtQuery_id.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stxtQuery_id.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stxtQuery_id.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.stxtQuery_id.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.stxtQuery_id.SkinTxt.Name = "BaseText";
            this.stxtQuery_id.SkinTxt.Size = new System.Drawing.Size(370, 18);
            this.stxtQuery_id.SkinTxt.TabIndex = 0;
            this.stxtQuery_id.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.stxtQuery_id.SkinTxt.WaterText = "";
            this.stxtQuery_id.TabIndex = 6;
            this.stxtQuery_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stxtQuery_id.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.stxtQuery_id.WaterText = "";
            this.stxtQuery_id.WordWrap = true;
            // 
            // skbtnSearch
            // 
            this.skbtnSearch.BackColor = System.Drawing.Color.Transparent;
            this.skbtnSearch.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skbtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skbtnSearch.DownBack = null;
            this.skbtnSearch.Font = new System.Drawing.Font("华文行楷", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skbtnSearch.Location = new System.Drawing.Point(949, 239);
            this.skbtnSearch.MouseBack = null;
            this.skbtnSearch.Name = "skbtnSearch";
            this.skbtnSearch.NormlBack = null;
            this.skbtnSearch.Radius = 20;
            this.skbtnSearch.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skbtnSearch.Size = new System.Drawing.Size(75, 28);
            this.skbtnSearch.TabIndex = 1;
            this.skbtnSearch.Text = "查询";
            this.skbtnSearch.UseVisualStyleBackColor = false;
            this.skbtnSearch.Click += new System.EventHandler(this.skbtnSearch_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.skinLabel1.Location = new System.Drawing.Point(468, 242);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(59, 21);
            this.skinLabel1.TabIndex = 7;
            this.skinLabel1.Text = "玩家ID";
            // 
            // spbPlayer
            // 
            this.spbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.spbPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spbPlayer.Image = ((System.Drawing.Image)(resources.GetObject("spbPlayer.Image")));
            this.spbPlayer.Location = new System.Drawing.Point(1346, 20);
            this.spbPlayer.Name = "spbPlayer";
            this.spbPlayer.Size = new System.Drawing.Size(64, 64);
            this.spbPlayer.TabIndex = 8;
            this.spbPlayer.TabStop = false;
            // 
            // skinToolTipRecord
            // 
            this.skinToolTipRecord.AutoPopDelay = 5000;
            this.skinToolTipRecord.InitialDelay = 500;
            this.skinToolTipRecord.OwnerDraw = true;
            this.skinToolTipRecord.ReshowDelay = 800;
            // 
            // skinPictureBoxPre
            // 
            this.skinPictureBoxPre.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBoxPre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinPictureBoxPre.Image = ((System.Drawing.Image)(resources.GetObject("skinPictureBoxPre.Image")));
            this.skinPictureBoxPre.Location = new System.Drawing.Point(530, 674);
            this.skinPictureBoxPre.Name = "skinPictureBoxPre";
            this.skinPictureBoxPre.Size = new System.Drawing.Size(64, 64);
            this.skinPictureBoxPre.TabIndex = 9;
            this.skinPictureBoxPre.TabStop = false;
            this.skinPictureBoxPre.Click += new System.EventHandler(this.skinPictureBoxPre_Click);
            // 
            // skinPictureBoxNext
            // 
            this.skinPictureBoxNext.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBoxNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinPictureBoxNext.Image = ((System.Drawing.Image)(resources.GetObject("skinPictureBoxNext.Image")));
            this.skinPictureBoxNext.Location = new System.Drawing.Point(869, 674);
            this.skinPictureBoxNext.Name = "skinPictureBoxNext";
            this.skinPictureBoxNext.Size = new System.Drawing.Size(64, 64);
            this.skinPictureBoxNext.TabIndex = 10;
            this.skinPictureBoxNext.TabStop = false;
            this.skinPictureBoxNext.Click += new System.EventHandler(this.skinPictureBoxNext_Click);
            // 
            // FrmRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = ((System.Drawing.Image)(resources.GetObject("$this.Back")));
            this.ClientSize = new System.Drawing.Size(1440, 810);
            this.CloseBoxSize = new System.Drawing.Size(0, 0);
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.Controls.Add(this.skinPictureBoxNext);
            this.Controls.Add(this.skinPictureBoxPre);
            this.Controls.Add(this.spbPlayer);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skbtnSearch);
            this.Controls.Add(this.stxtQuery_id);
            this.Controls.Add(this.skinPictureBox1);
            this.Controls.Add(this.sdgvMyRecord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 810);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1440, 810);
            this.Name = "FrmRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRecord_FormClosed);
            this.Load += new System.EventHandler(this.FrmRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sdgvMyRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBoxPre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBoxNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinDataGridView sdgvMyRecord;
        private System.Windows.Forms.DataGridViewLinkColumn ColID;
        private System.Windows.Forms.DataGridViewLinkColumn ColCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private CCWin.SkinControl.SkinTextBox stxtQuery_id;
        private CCWin.SkinControl.SkinButton skbtnSearch;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinPictureBox spbPlayer;
        private CCWin.SkinToolTip skinToolTipRecord;
        private CCWin.SkinControl.SkinPictureBox skinPictureBoxPre;
        private CCWin.SkinControl.SkinPictureBox skinPictureBoxNext;
    }
}