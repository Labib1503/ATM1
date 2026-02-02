namespace ATM
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            AccNumTb = new TextBox();
            PinTb = new TextBox();
            label4 = new Label();
            LoginBtn = new Button();
            SignUpBtn = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            label5 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(321, 121);
            label2.Name = "label2";
            label2.Size = new Size(176, 69);
            label2.TabIndex = 2;
            label2.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 214);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(227, 191);
            label3.Name = "label3";
            label3.Size = new Size(314, 46);
            label3.TabIndex = 4;
            label3.Text = "Account Number";
            // 
            // AccNumTb
            // 
            AccNumTb.Font = new Font("Microsoft YaHei UI", 18F);
            AccNumTb.Location = new Point(227, 240);
            AccNumTb.Multiline = true;
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(515, 46);
            AccNumTb.TabIndex = 5;
            // 
            // PinTb
            // 
            PinTb.Font = new Font("Microsoft YaHei UI", 18F);
            PinTb.Location = new Point(227, 338);
            PinTb.Multiline = true;
            PinTb.Name = "PinTb";
            PinTb.Size = new Size(515, 46);
            PinTb.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(227, 289);
            label4.Name = "label4";
            label4.Size = new Size(183, 46);
            label4.TabIndex = 6;
            label4.Text = "PIN Code";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.DarkSlateGray;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(254, 440);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(156, 64);
            LoginBtn.TabIndex = 8;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = Color.DarkSlateGray;
            SignUpBtn.FlatStyle = FlatStyle.Flat;
            SignUpBtn.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpBtn.ForeColor = Color.White;
            SignUpBtn.Location = new Point(571, 440);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(156, 64);
            SignUpBtn.TabIndex = 9;
            SignUpBtn.Text = "Sign Up";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 534);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 16);
            panel2.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 118);
            panel1.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkSlateGray;
            label5.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(779, 5);
            label5.Name = "label5";
            label5.Size = new Size(66, 69);
            label5.TabIndex = 33;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(130, 24);
            label1.Name = "label1";
            label1.Size = new Size(612, 58);
            label1.TabIndex = 2;
            label1.Text = "ATM Management System";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 550);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(SignUpBtn);
            Controls.Add(LoginBtn);
            Controls.Add(PinTb);
            Controls.Add(label4);
            Controls.Add(AccNumTb);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox AccNumTb;
        private TextBox PinTb;
        private Label label4;
        private Button LoginBtn;
        private Button SignUpBtn;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Label label5;
    }
}