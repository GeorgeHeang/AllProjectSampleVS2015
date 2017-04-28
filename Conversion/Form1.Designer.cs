namespace Conversion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.firstTextbox = new System.Windows.Forms.TextBox();
            this.secondTextbox = new System.Windows.Forms.TextBox();
            this.firstListbox = new System.Windows.Forms.ListBox();
            this.secondListbox = new System.Windows.Forms.ListBox();
            this.ConversionType = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // firstTextbox
            // 
            this.firstTextbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstTextbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.firstTextbox.Location = new System.Drawing.Point(22, 120);
            this.firstTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.firstTextbox.Name = "firstTextbox";
            this.firstTextbox.Size = new System.Drawing.Size(178, 26);
            this.firstTextbox.TabIndex = 0;
            this.firstTextbox.Text = "Enter value";
            this.firstTextbox.Enter += new System.EventHandler(this.firstTextboxEnter);
            this.firstTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPresss);
            this.firstTextbox.Leave += new System.EventHandler(this.firstTextboxLeave);
            // 
            // secondTextbox
            // 
            this.secondTextbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondTextbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.secondTextbox.Location = new System.Drawing.Point(243, 120);
            this.secondTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.secondTextbox.Name = "secondTextbox";
            this.secondTextbox.Size = new System.Drawing.Size(170, 26);
            this.secondTextbox.TabIndex = 1;
            this.secondTextbox.Text = "Enter value";
            this.secondTextbox.Enter += new System.EventHandler(this.secondTextboxEnter);
            this.secondTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPresss);
            this.secondTextbox.Leave += new System.EventHandler(this.secondTextboxLeave);
            // 
            // firstListbox
            // 
            this.firstListbox.FormattingEnabled = true;
            this.firstListbox.ItemHeight = 19;
            this.firstListbox.Items.AddRange(new object[] {
            "Conversion"});
            this.firstListbox.Location = new System.Drawing.Point(22, 89);
            this.firstListbox.Margin = new System.Windows.Forms.Padding(4);
            this.firstListbox.Name = "firstListbox";
            this.firstListbox.Size = new System.Drawing.Size(106, 23);
            this.firstListbox.TabIndex = 3;
            // 
            // secondListbox
            // 
            this.secondListbox.FormattingEnabled = true;
            this.secondListbox.ItemHeight = 19;
            this.secondListbox.Items.AddRange(new object[] {
            "Conversion"});
            this.secondListbox.Location = new System.Drawing.Point(243, 89);
            this.secondListbox.Name = "secondListbox";
            this.secondListbox.Size = new System.Drawing.Size(106, 23);
            this.secondListbox.TabIndex = 4;
            // 
            // ConversionType
            // 
            this.ConversionType.FormattingEnabled = true;
            this.ConversionType.ItemHeight = 19;
            this.ConversionType.Items.AddRange(new object[] {
            "Select conversion type",
            "Lenght",
            "Weight",
            "Area"});
            this.ConversionType.Location = new System.Drawing.Point(22, 27);
            this.ConversionType.Name = "ConversionType";
            this.ConversionType.Size = new System.Drawing.Size(178, 23);
            this.ConversionType.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(421, 166);
            this.Controls.Add(this.secondTextbox);
            this.Controls.Add(this.ConversionType);
            this.Controls.Add(this.secondListbox);
            this.Controls.Add(this.firstListbox);
            this.Controls.Add(this.firstTextbox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(537, 304);
            this.MinimumSize = new System.Drawing.Size(437, 204);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstTextbox;
        private System.Windows.Forms.TextBox secondTextbox;
        private System.Windows.Forms.ListBox firstListbox;
        private System.Windows.Forms.ListBox secondListbox;
        private System.Windows.Forms.ListBox ConversionType;
    }
}

