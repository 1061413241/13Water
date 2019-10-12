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
            this.SuspendLayout();
            // 
            // sbtnStart
            // 
            this.sbtnStart.BackColor = System.Drawing.Color.Transparent;
            this.sbtnStart.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sbtnStart.DownBack = null;
            this.sbtnStart.Location = new System.Drawing.Point(620, 454);
            this.sbtnStart.MouseBack = null;
            this.sbtnStart.Name = "sbtnStart";
            this.sbtnStart.NormlBack = null;
            this.sbtnStart.Size = new System.Drawing.Size(189, 80);
            this.sbtnStart.TabIndex = 0;
            this.sbtnStart.Text = "开始游戏";
            this.sbtnStart.UseVisualStyleBackColor = false;
            this.sbtnStart.Click += new System.EventHandler(this.sbtnStart_Click);
            // 
            // FrmBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = ((System.Drawing.Image)(resources.GetObject("$this.Back")));
            this.ClientSize = new System.Drawing.Size(1440, 810);
            this.Controls.Add(this.sbtnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBattle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "";
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton sbtnStart;
    }
}