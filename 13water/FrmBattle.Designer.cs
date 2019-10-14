namespace _13water
{
    partial class FrmBattle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBattle));
            this.sbtnStart = new CCWin.SkinControl.SkinButton();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sbtnStart
            // 
            this.sbtnStart.BackColor = System.Drawing.Color.Transparent;
            this.sbtnStart.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sbtnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtnStart.DownBack = null;
            this.sbtnStart.Font = new System.Drawing.Font("华文行楷", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtnStart.Location = new System.Drawing.Point(626, 413);
            this.sbtnStart.MouseBack = null;
            this.sbtnStart.Name = "sbtnStart";
            this.sbtnStart.NormlBack = null;
            this.sbtnStart.Radius = 50;
            this.sbtnStart.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.sbtnStart.Size = new System.Drawing.Size(189, 80);
            this.sbtnStart.TabIndex = 0;
            this.sbtnStart.Text = "开始游戏";
            this.sbtnStart.UseVisualStyleBackColor = false;
            this.sbtnStart.Click += new System.EventHandler(this.sbtnStart_Click);
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
            // FrmBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = ((System.Drawing.Image)(resources.GetObject("$this.Back")));
            this.ClientSize = new System.Drawing.Size(1440, 810);
            this.CloseBoxSize = new System.Drawing.Size(0, 0);
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.Controls.Add(this.skinPictureBox1);
            this.Controls.Add(this.sbtnStart);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 810);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1440, 810);
            this.Name = "FrmBattle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton sbtnStart;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
    }
}