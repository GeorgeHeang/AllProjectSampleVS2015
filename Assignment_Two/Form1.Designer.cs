namespace Assignment_Two
{
    partial class assgnment_two
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbfirstname = new System.Windows.Forms.TextBox();
            this.tbgender = new System.Windows.Forms.TextBox();
            this.tblastname = new System.Windows.Forms.TextBox();
            this.libbiketype = new System.Windows.Forms.ListBox();
            this.outPut = new System.Windows.Forms.Label();
            this.btsubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bike Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name";
            // 
            // tbfirstname
            // 
            this.tbfirstname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfirstname.Location = new System.Drawing.Point(148, 24);
            this.tbfirstname.Name = "tbfirstname";
            this.tbfirstname.Size = new System.Drawing.Size(162, 26);
            this.tbfirstname.TabIndex = 4;
            this.tbfirstname.TextChanged += new System.EventHandler(this.tbfirstname_TextChanged);
            // 
            // tbgender
            // 
            this.tbgender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgender.Location = new System.Drawing.Point(148, 83);
            this.tbgender.Name = "tbgender";
            this.tbgender.Size = new System.Drawing.Size(77, 26);
            this.tbgender.TabIndex = 5;
            // 
            // tblastname
            // 
            this.tblastname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblastname.Location = new System.Drawing.Point(148, 54);
            this.tblastname.Name = "tblastname";
            this.tblastname.Size = new System.Drawing.Size(162, 26);
            this.tblastname.TabIndex = 6;
            // 
            // libbiketype
            // 
            this.libbiketype.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libbiketype.FormattingEnabled = true;
            this.libbiketype.ItemHeight = 19;
            this.libbiketype.Items.AddRange(new object[] {
            "Cube",
            "C125",
            "C250",
            "C600"});
            this.libbiketype.Location = new System.Drawing.Point(148, 113);
            this.libbiketype.Name = "libbiketype";
            this.libbiketype.Size = new System.Drawing.Size(77, 23);
            this.libbiketype.TabIndex = 7;
            // 
            // outPut
            // 
            this.outPut.AutoSize = true;
            this.outPut.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outPut.Location = new System.Drawing.Point(111, 199);
            this.outPut.Name = "outPut";
            this.outPut.Size = new System.Drawing.Size(0, 21);
            this.outPut.TabIndex = 8;
            // 
            // btsubmit
            // 
            this.btsubmit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsubmit.ForeColor = System.Drawing.Color.Blue;
            this.btsubmit.Location = new System.Drawing.Point(148, 138);
            this.btsubmit.Name = "btsubmit";
            this.btsubmit.Size = new System.Drawing.Size(75, 27);
            this.btsubmit.TabIndex = 9;
            this.btsubmit.Text = "Submit";
            this.btsubmit.UseVisualStyleBackColor = true;
            this.btsubmit.Click += new System.EventHandler(this.btsubmit_Click);
          //  this.btsubmit.Enter += new System.EventHandler(this.label2_Click);
            // 
            // assgnment_two
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(376, 361);
            this.Controls.Add(this.btsubmit);
            this.Controls.Add(this.outPut);
            this.Controls.Add(this.libbiketype);
            this.Controls.Add(this.tblastname);
            this.Controls.Add(this.tbgender);
            this.Controls.Add(this.tbfirstname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "assgnment_two";
            this.Text = "Assignment Two";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbfirstname;
        private System.Windows.Forms.TextBox tbgender;
        private System.Windows.Forms.TextBox tblastname;
        private System.Windows.Forms.ListBox libbiketype;
        private System.Windows.Forms.Label outPut;
        private System.Windows.Forms.Button btsubmit;
    }
}

