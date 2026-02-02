namespace ATM
{
    partial class Account
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            AccNumTb = new TextBox();
            label3 = new Label();
            AccNameTb = new TextBox();
            label4 = new Label();
            AccFnameTb = new TextBox();
            label5 = new Label();
            AddressTb = new TextBox();
            label6 = new Label();
            PhoneTb = new TextBox();
            label7 = new Label();
            label8 = new Label();
            OccupationTB = new TextBox();
            label9 = new Label();
            label10 = new Label();
            PinTb = new TextBox();
            label12 = new Label();
            DOBdate = new DateTimePicker();
            LogoutBtn = new Button();
            LoginBtn = new Button();
            panel2 = new Panel();
            EducationCb = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 109);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(979, 5);
            label2.Name = "label2";
            label2.Size = new Size(66, 69);
            label2.TabIndex = 2;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(147, 9);
            label1.Name = "label1";
            label1.Size = new Size(724, 69);
            label1.TabIndex = 1;
            label1.Text = "ATM Management System";
            // 
            // AccNumTb
            // 
            AccNumTb.Font = new Font("Microsoft YaHei UI", 18F);
            AccNumTb.Location = new Point(42, 234);
            AccNumTb.Multiline = true;
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(416, 46);
            AccNumTb.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(48, 185);
            label3.Name = "label3";
            label3.Size = new Size(314, 46);
            label3.TabIndex = 6;
            label3.Text = "Account Number";
            // 
            // AccNameTb
            // 
            AccNameTb.Font = new Font("Microsoft YaHei UI", 18F);
            AccNameTb.Location = new Point(37, 332);
            AccNameTb.Multiline = true;
            AccNameTb.Name = "AccNameTb";
            AccNameTb.Size = new Size(421, 46);
            AccNameTb.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(42, 283);
            label4.Name = "label4";
            label4.Size = new Size(123, 46);
            label4.TabIndex = 8;
            label4.Text = "Name";
            // 
            // AccFnameTb
            // 
            AccFnameTb.Font = new Font("Microsoft YaHei UI", 18F);
            AccFnameTb.Location = new Point(37, 430);
            AccFnameTb.Multiline = true;
            AccFnameTb.Name = "AccFnameTb";
            AccFnameTb.Size = new Size(421, 46);
            AccFnameTb.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(42, 381);
            label5.Name = "label5";
            label5.Size = new Size(242, 46);
            label5.TabIndex = 10;
            label5.Text = "Father Name";
            // 
            // AddressTb
            // 
            AddressTb.Font = new Font("Microsoft YaHei UI", 18F);
            AddressTb.Location = new Point(32, 528);
            AddressTb.Multiline = true;
            AddressTb.Name = "AddressTb";
            AddressTb.Size = new Size(426, 144);
            AddressTb.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(37, 479);
            label6.Name = "label6";
            label6.Size = new Size(159, 46);
            label6.TabIndex = 12;
            label6.Text = "Address";
            // 
            // PhoneTb
            // 
            PhoneTb.Font = new Font("Microsoft YaHei UI", 18F);
            PhoneTb.Location = new Point(580, 536);
            PhoneTb.Multiline = true;
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(426, 46);
            PhoneTb.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(585, 487);
            label7.Name = "label7";
            label7.Size = new Size(163, 46);
            label7.TabIndex = 14;
            label7.Text = "Phone #";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(580, 585);
            label8.Name = "label8";
            label8.Size = new Size(99, 46);
            label8.TabIndex = 24;
            label8.Text = "DOB";
            // 
            // OccupationTB
            // 
            OccupationTB.Font = new Font("Microsoft YaHei UI", 18F);
            OccupationTB.Location = new Point(580, 438);
            OccupationTB.Multiline = true;
            OccupationTB.Name = "OccupationTB";
            OccupationTB.Size = new Size(421, 46);
            OccupationTB.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkSlateGray;
            label9.Location = new Point(581, 389);
            label9.Name = "label9";
            label9.Size = new Size(218, 46);
            label9.TabIndex = 22;
            label9.Text = "Occupation";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.Control;
            label10.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkSlateGray;
            label10.Location = new Point(585, 291);
            label10.Name = "label10";
            label10.Size = new Size(191, 46);
            label10.TabIndex = 20;
            label10.Text = "Education";
            // 
            // PinTb
            // 
            PinTb.Font = new Font("Microsoft YaHei UI", 18F);
            PinTb.Location = new Point(585, 234);
            PinTb.Multiline = true;
            PinTb.Name = "PinTb";
            PinTb.Size = new Size(416, 46);
            PinTb.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.Control;
            label12.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DarkSlateGray;
            label12.Location = new Point(591, 185);
            label12.Name = "label12";
            label12.Size = new Size(82, 46);
            label12.TabIndex = 16;
            label12.Text = "PIN";
            // 
            // DOBdate
            // 
            DOBdate.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DOBdate.Location = new Point(580, 634);
            DOBdate.Name = "DOBdate";
            DOBdate.Size = new Size(421, 38);
            DOBdate.TabIndex = 26;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.DarkSlateGray;
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutBtn.ForeColor = Color.White;
            LogoutBtn.Location = new Point(606, 769);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(156, 64);
            LogoutBtn.TabIndex = 28;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.DarkSlateGray;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(289, 769);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(156, 64);
            LoginBtn.TabIndex = 27;
            LoginBtn.Text = "Submit";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 864);
            panel2.Name = "panel2";
            panel2.Size = new Size(1050, 16);
            panel2.TabIndex = 29;
            // 
            // EducationCb
            // 
            EducationCb.Font = new Font("Microsoft YaHei UI", 18F);
            EducationCb.FormattingEnabled = true;
            EducationCb.Items.AddRange(new object[] { "Non Graduate", "Under Graduate", "Post Graduate" });
            EducationCb.Location = new Point(585, 332);
            EducationCb.Name = "EducationCb";
            EducationCb.Size = new Size(416, 54);
            EducationCb.TabIndex = 30;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 880);
            Controls.Add(EducationCb);
            Controls.Add(panel2);
            Controls.Add(LogoutBtn);
            Controls.Add(LoginBtn);
            Controls.Add(DOBdate);
            Controls.Add(label8);
            Controls.Add(OccupationTB);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(PinTb);
            Controls.Add(label12);
            Controls.Add(PhoneTb);
            Controls.Add(label7);
            Controls.Add(AddressTb);
            Controls.Add(label6);
            Controls.Add(AccFnameTb);
            Controls.Add(label5);
            Controls.Add(AccNameTb);
            Controls.Add(label4);
            Controls.Add(AccNumTb);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox AccNumTb;
        private Label label3;
        private TextBox AccNameTb;
        private Label label4;
        private TextBox AccFnameTb;
        private Label label5;
        private TextBox AddressTb;
        private Label label6;
        private TextBox PhoneTb;
        private Label label7;
        private Label label8;
        private TextBox OccupationTB;
        private Label label9;
        private Label label10;
        private TextBox PinTb;
        private Label label12;
        private DateTimePicker DOBdate;
        private Button LogoutBtn;
        private Button LoginBtn;
        private Panel panel2;
        private Label label2;
        private ComboBox EducationCb;
    }
}