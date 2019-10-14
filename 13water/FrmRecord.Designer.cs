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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecord));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("hhh", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("xxx", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "fdfd",
            "fdfdfdffd",
            "asasas",
            "fdfdafdas"}, 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("fdfdfd", 1);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sdgvMyRecord = new CCWin.SkinControl.SkinDataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColCard = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sdgvMyRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bitbug_favicon.ico");
            this.imageList1.Images.SetKeyName(1, "timg (1).png");
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            listViewGroup1.Header = "hhh";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "xxx";
            listViewGroup2.Name = "listViewGroup2";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listView1.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup2;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(-16, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(417, 145);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Width = 124;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Width = 128;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Width = 96;
            // 
            // sdgvMyRecord
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.sdgvMyRecord.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.sdgvMyRecord.BackgroundColor = System.Drawing.SystemColors.Window;
            this.sdgvMyRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sdgvMyRecord.ColumnFont = null;
            this.sdgvMyRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sdgvMyRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.sdgvMyRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sdgvMyRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColCard,
            this.ColScore,
            this.ColTime});
            this.sdgvMyRecord.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sdgvMyRecord.DefaultCellStyle = dataGridViewCellStyle3;
            this.sdgvMyRecord.EnableHeadersVisualStyles = false;
            this.sdgvMyRecord.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sdgvMyRecord.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sdgvMyRecord.HeadFont = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sdgvMyRecord.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.sdgvMyRecord.Location = new System.Drawing.Point(229, 255);
            this.sdgvMyRecord.Name = "sdgvMyRecord";
            this.sdgvMyRecord.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sdgvMyRecord.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.sdgvMyRecord.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.sdgvMyRecord.RowTemplate.Height = 23;
            this.sdgvMyRecord.Size = new System.Drawing.Size(964, 399);
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
            // FrmRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = ((System.Drawing.Image)(resources.GetObject("$this.Back")));
            this.ClientSize = new System.Drawing.Size(1440, 810);
            this.Controls.Add(this.sdgvMyRecord);
            this.Controls.Add(this.listView1);
            this.Name = "FrmRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRecord";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRecord_FormClosed);
            this.Load += new System.EventHandler(this.FrmRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sdgvMyRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private CCWin.SkinControl.SkinDataGridView sdgvMyRecord;
        private System.Windows.Forms.DataGridViewLinkColumn ColID;
        private System.Windows.Forms.DataGridViewLinkColumn ColCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
    }
}