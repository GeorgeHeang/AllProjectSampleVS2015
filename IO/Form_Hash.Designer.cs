namespace IO
{
    partial class Form_Hash
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnmd5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAES = new System.Windows.Forms.Button();
            this.btndes = new System.Windows.Forms.Button();
            this.btnTripleDES = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(484, 30);
            this.textBox1.TabIndex = 1;
            // 
            // btnmd5
            // 
            this.btnmd5.Location = new System.Drawing.Point(5, 139);
            this.btnmd5.Name = "btnmd5";
            this.btnmd5.Size = new System.Drawing.Size(148, 53);
            this.btnmd5.TabIndex = 2;
            this.btnmd5.Text = "MD5";
            this.btnmd5.UseVisualStyleBackColor = true;
            this.btnmd5.Click += new System.EventHandler(this.btnmd5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(5, 354);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(484, 30);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hash Text";
            // 
            // btnAES
            // 
            this.btnAES.Location = new System.Drawing.Point(179, 139);
            this.btnAES.Name = "btnAES";
            this.btnAES.Size = new System.Drawing.Size(148, 53);
            this.btnAES.TabIndex = 5;
            this.btnAES.Text = "AES";
            this.btnAES.UseVisualStyleBackColor = true;
            this.btnAES.Click += new System.EventHandler(this.btnAES_Click);
            // 
            // btndes
            // 
            this.btndes.Location = new System.Drawing.Point(341, 139);
            this.btndes.Name = "btndes";
            this.btndes.Size = new System.Drawing.Size(148, 53);
            this.btndes.TabIndex = 6;
            this.btndes.Text = "DES";
            this.btndes.UseVisualStyleBackColor = true;
            // 
            // btnTripleDES
            // 
            this.btnTripleDES.Location = new System.Drawing.Point(179, 230);
            this.btnTripleDES.Name = "btnTripleDES";
            this.btnTripleDES.Size = new System.Drawing.Size(148, 53);
            this.btnTripleDES.TabIndex = 7;
            this.btnTripleDES.Text = "Triple DES";
            this.btnTripleDES.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(501, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // Form_Hash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 427);
            this.Controls.Add(this.btnTripleDES);
            this.Controls.Add(this.btndes);
            this.Controls.Add(this.btnAES);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnmd5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Hash";
            this.Text = "Form_Hash";
            this.Load += new System.EventHandler(this.Form_Hash_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnmd5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAES;
        private System.Windows.Forms.Button btndes;
        private System.Windows.Forms.Button btnTripleDES;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}