namespace WaterMarkTextbox
{
    partial class Information
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
            this.showInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showInfo
            // 
            this.showInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showInfo.Location = new System.Drawing.Point(-2, -1);
            this.showInfo.Name = "showInfo";
            this.showInfo.Size = new System.Drawing.Size(414, 292);
            this.showInfo.TabIndex = 0;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 288);
            this.Controls.Add(this.showInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Information";
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Information_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label showInfo;
    }
}