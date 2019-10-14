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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecord));
            this.sdgvMyRecord = new CCWin.SkinControl.SkinDataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColCard = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sdgvMyRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.sdgvMyRecord.Location = new System.Drawing.Point(259, 282);
            this.sdgvMyRecord.Name = "sdgvMyRecord";
            this.sdgvMyRecord.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sdgvMyRecord.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.sdgvMyRecord.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.sdgvMyRecord.RowTemplate.Height = 23;
            this.sdgvMyRecord.Size = new System.Drawing.Size(964, 380);
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
            // FrmRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = ((System.Drawing.Image)(resources.GetObject("$this.Back")));
            this.ClientSize = new System.Drawing.Size(1440, 810);
            this.CloseBoxSize = new System.Drawing.Size(0, 0);
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
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
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinDataGridView sdgvMyRecord;
        private System.Windows.Forms.DataGridViewLinkColumn ColID;
        private System.Windows.Forms.DataGridViewLinkColumn ColCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
    }
}