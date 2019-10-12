namespace _13water
{
    partial class FrmPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlay));
            this.sbtnSubmit = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // sbtnSubmit
            // 
            this.sbtnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.sbtnSubmit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sbtnSubmit.DownBack = null;
            this.sbtnSubmit.Location = new System.Drawing.Point(647, 472);
            this.sbtnSubmit.MouseBack = null;
            this.sbtnSubmit.Name = "sbtnSubmit";
            this.sbtnSubmit.NormlBack = null;
            this.sbtnSubmit.Size = new System.Drawing.Size(139, 64);
            this.sbtnSubmit.TabIndex = 0;
            this.sbtnSubmit.Text = "出牌";
            this.sbtnSubmit.UseVisualStyleBackColor = false;
            this.sbtnSubmit.Click += new System.EventHandler(this.sbtnSubmit_Click);
            // 
            // FrmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = ((System.Drawing.Image)(resources.GetObject("$this.Back")));
            this.ClientSize = new System.Drawing.Size(1440, 810);
            this.Controls.Add(this.sbtnSubmit);
            this.Name = "FrmPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmPlay";
            this.Load += new System.EventHandler(this.FrmPlay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton sbtnSubmit;
    }
}