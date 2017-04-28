namespace WaterMarkTextbox
{
    partial class LoginandSignup
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.YearBox = new System.Windows.Forms.ComboBox();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.dayBox = new System.Windows.Forms.ComboBox();
            this.signupButton = new System.Windows.Forms.Button();
            this.signupPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.signupUsername = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.emAil = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addRess = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginUsername = new System.Windows.Forms.TextBox();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.YearBox);
            this.groupBox.Controls.Add(this.monthBox);
            this.groupBox.Controls.Add(this.dayBox);
            this.groupBox.Controls.Add(this.signupButton);
            this.groupBox.Controls.Add(this.signupPassword);
            this.groupBox.Controls.Add(this.label12);
            this.groupBox.Controls.Add(this.signupUsername);
            this.groupBox.Controls.Add(this.label11);
            this.groupBox.Controls.Add(this.label10);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.Controls.Add(this.emAil);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.addRess);
            this.groupBox.Controls.Add(this.lastName);
            this.groupBox.Controls.Add(this.label8);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.firstName);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(231, -7);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(313, 406);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // YearBox
            // 
            this.YearBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.YearBox.FormattingEnabled = true;
            this.YearBox.Location = new System.Drawing.Point(83, 143);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(64, 23);
            this.YearBox.TabIndex = 24;
            this.YearBox.Text = "Year";
            this.YearBox.SelectedIndexChanged += new System.EventHandler(this.YearBox_SelectedIndexChanged);
            this.YearBox.Leave += new System.EventHandler(this.YearLeave);
            // 
            // monthBox
            // 
            this.monthBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "Septeber",
            "October",
            "November",
            "December"});
            this.monthBox.Location = new System.Drawing.Point(153, 143);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(82, 23);
            this.monthBox.TabIndex = 25;
            this.monthBox.Text = "Month";
            this.monthBox.DragLeave += new System.EventHandler(this.MonthLeave);
            // 
            // dayBox
            // 
            this.dayBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.dayBox.FormattingEnabled = true;
            this.dayBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayBox.Location = new System.Drawing.Point(241, 142);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(52, 23);
            this.dayBox.TabIndex = 23;
            this.dayBox.Text = "Day";
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.signupButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.signupButton.FlatAppearance.BorderSize = 0;
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signupButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.Location = new System.Drawing.Point(218, 255);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(75, 23);
            this.signupButton.TabIndex = 5;
            this.signupButton.Text = "Sign Up";
            this.signupButton.UseVisualStyleBackColor = false;
            // 
            // signupPassword
            // 
            this.signupPassword.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.signupPassword.Location = new System.Drawing.Point(83, 227);
            this.signupPassword.MaxLength = 11;
            this.signupPassword.Name = "signupPassword";
            this.signupPassword.Size = new System.Drawing.Size(210, 21);
            this.signupPassword.TabIndex = 22;
            this.signupPassword.Text = "Enter password";
            this.signupPassword.TextChanged += new System.EventHandler(this.signupPassword_TextChanged);
            this.signupPassword.Enter += new System.EventHandler(this.entersignupPassword);
            this.signupPassword.Leave += new System.EventHandler(this.leavesignupPassword);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(6, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "Password";
            // 
            // signupUsername
            // 
            this.signupUsername.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupUsername.ForeColor = System.Drawing.SystemColors.GrayText;
            this.signupUsername.Location = new System.Drawing.Point(83, 199);
            this.signupUsername.Name = "signupUsername";
            this.signupUsername.Size = new System.Drawing.Size(210, 21);
            this.signupUsername.TabIndex = 20;
            this.signupUsername.Text = "Enter username";
            this.signupUsername.Enter += new System.EventHandler(this.enterUsername);
            this.signupUsername.Leave += new System.EventHandler(this.leaveUsername);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(6, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Username";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(6, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Date of Birth";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(21, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 15;
            // 
            // emAil
            // 
            this.emAil.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emAil.ForeColor = System.Drawing.SystemColors.GrayText;
            this.emAil.Location = new System.Drawing.Point(83, 171);
            this.emAil.Name = "emAil";
            this.emAil.Size = new System.Drawing.Size(210, 21);
            this.emAil.TabIndex = 14;
            this.emAil.Text = "Enter your Email";
            this.emAil.Enter += new System.EventHandler(this.EmailEnter);
            this.emAil.Leave += new System.EventHandler(this.EmailLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(6, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email";
            // 
            // addRess
            // 
            this.addRess.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRess.ForeColor = System.Drawing.SystemColors.GrayText;
            this.addRess.Location = new System.Drawing.Point(83, 115);
            this.addRess.Name = "addRess";
            this.addRess.Size = new System.Drawing.Size(210, 21);
            this.addRess.TabIndex = 12;
            this.addRess.Text = "Enter you address";
            this.addRess.Enter += new System.EventHandler(this.addressEnter);
            this.addRess.Leave += new System.EventHandler(this.addressLeave);
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lastName.Location = new System.Drawing.Point(83, 87);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(210, 21);
            this.lastName.TabIndex = 11;
            this.lastName.Text = "Enter your last name";
            this.lastName.Enter += new System.EventHandler(this.enterlastName);
            this.lastName.Leave += new System.EventHandler(this.leavelastName);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(6, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(6, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(6, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Address";
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.firstName.Location = new System.Drawing.Point(83, 59);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(210, 21);
            this.firstName.TabIndex = 5;
            this.firstName.Text = "Enter your first name";
            this.firstName.Enter += new System.EventHandler(this.enterfirstname);
            this.firstName.Leave += new System.EventHandler(this.leavefirstname);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Log In";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username";
            // 
            // loginUsername
            // 
            this.loginUsername.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.loginUsername.ForeColor = System.Drawing.SystemColors.GrayText;
            this.loginUsername.Location = new System.Drawing.Point(78, 47);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(147, 21);
            this.loginUsername.TabIndex = 1;
            this.loginUsername.Text = "Enter your username";
            this.loginUsername.Enter += new System.EventHandler(this.enterloginUsername);
            this.loginUsername.Leave += new System.EventHandler(this.leaveloginUsername);
            // 
            // loginPassword
            // 
            this.loginPassword.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.loginPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.loginPassword.Location = new System.Drawing.Point(78, 78);
            this.loginPassword.MaxLength = 10;
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.Size = new System.Drawing.Size(147, 21);
            this.loginPassword.TabIndex = 4;
            this.loginPassword.Text = "Enter your password";
            this.loginPassword.Enter += new System.EventHandler(this.enterloginPassword);
            this.loginPassword.Leave += new System.EventHandler(this.leaveloginPassword);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Location = new System.Drawing.Point(150, 108);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = false;
            // 
            // LoginandSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(539, 282);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginPassword);
            this.Controls.Add(this.loginUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoginandSignup";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LoginandSignup_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox emAil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addRess;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.TextBox loginUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.TextBox signupPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox signupUsername;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.ComboBox monthBox;
        private System.Windows.Forms.ComboBox dayBox;
        private System.Windows.Forms.ComboBox YearBox;
    }
}

