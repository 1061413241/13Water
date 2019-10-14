namespace _13water
{
    partial class FrmRank
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRank));
            this.sdgvRank = new CCWin.SkinControl.SkinDataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sdgvRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sdgvRank
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.sdgvRank.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.sdgvRank.BackgroundColor = System.Drawing.SystemColors.Window;
            this.sdgvRank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sdgvRank.ColumnFont = null;
            this.sdgvRank.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sdgvRank.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.sdgvRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sdgvRank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColScore,
            this.ColName});
            this.sdgvRank.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sdgvRank.DefaultCellStyle = dataGridViewCellStyle3;
            this.sdgvRank.EnableHeadersVisualStyles = false;
            this.sdgvRank.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sdgvRank.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sdgvRank.HeadFont = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sdgvRank.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.sdgvRank.Location = new System.Drawing.Point(470, 219);
            this.sdgvRank.Name = "sdgvRank";
            this.sdgvRank.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sdgvRank.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.sdgvRank.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.sdgvRank.RowTemplate.Height = 23;
            this.sdgvRank.Size = new System.Drawing.Size(513, 502);
            this.sdgvRank.TabIndex = 0;
            this.sdgvRank.TitleBack = null;
            this.sdgvRank.TitleBackColorBegin = System.Drawing.Color.White;
            this.sdgvRank.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.sdgvRank.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sdgvRank_CellContentClick);
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("skinPictureBox1.Image")));
            this.skinPictureBox1.Location = new System.Drawing.Point(30, 20);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(69, 62);
            this.skinPictureBox1.TabIndex = 5;
            this.skinPictureBox1.TabStop = false;
            this.skinPictureBox1.Click += new System.EventHandler(this.skinPictureBox1_Click);
            // 
            // ColID
            // 
            this.ColID.DataPropertyName = "play_id";
            this.ColID.HeaderText = "用户ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 110;
            // 
            // ColScore
            // 
            this.ColScore.DataPropertyName = "score";
            this.ColScore.HeaderText = "分数";
            this.ColScore.Name = "ColScore";
            this.ColScore.ReadOnly = true;
            this.ColScore.Width = 110;
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "name";
            this.ColName.HeaderText = "昵称";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Width = 250;
            // 
            // FrmRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = ((System.Drawing.Image)(resources.GetObject("$this.Back")));
            this.ClientSize = new System.Drawing.Size(1440, 810);
            this.CloseBoxSize = new System.Drawing.Size(0, 0);
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.Controls.Add(this.skinPictureBox1);
            this.Controls.Add(this.sdgvRank);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 810);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1440, 810);
            this.Name = "FrmRank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "";
            this.Load += new System.EventHandler(this.FrmRank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sdgvRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinDataGridView sdgvRank;
        private System.Windows.Forms.ToolTip toolTip1;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
    }
}