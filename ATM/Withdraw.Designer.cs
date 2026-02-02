namespace ATM
{
    partial class Withdraw
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
            label4 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            WithdrawAmtTb = new TextBox();
            label3 = new Label();
            BlanceLbl = new Label();
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
            panel1.Size = new Size(850, 99);
            panel1.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(780, 4);
            label2.Name = "label2";
            label2.Size = new Size(66, 69);
            label2.TabIndex = 3;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(79, 9);
            label1.Name = "label1";
            label1.Size = new Size(612, 58);
            label1.TabIndex = 2;
            label1.Text = "ATM Management System";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(328, 111);
            label4.Name = "label4";
            label4.Size = new Size(199, 47);
            label4.TabIndex = 46;
            label4.Text = "Withdraw";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 534);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 16);
            panel2.TabIndex = 45;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(445, 403);
            button2.Name = "button2";
            button2.Size = new Size(217, 64);
            button2.TabIndex = 44;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(153, 403);
            button1.Name = "button1";
            button1.Size = new Size(217, 64);
            button1.TabIndex = 43;
            button1.Text = "Withdraw";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // WithdrawAmtTb
            // 
            WithdrawAmtTb.Font = new Font("Microsoft YaHei UI", 18F);
            WithdrawAmtTb.Location = new Point(153, 291);
            WithdrawAmtTb.Multiline = true;
            WithdrawAmtTb.Name = "WithdrawAmtTb";
            WithdrawAmtTb.Size = new Size(527, 46);
            WithdrawAmtTb.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(159, 242);
            label3.Name = "label3";
            label3.Size = new Size(159, 46);
            label3.TabIndex = 41;
            label3.Text = "Amount";
            // 
            // BlanceLbl
            // 
            BlanceLbl.AutoSize = true;
            BlanceLbl.BackColor = SystemColors.Control;
            BlanceLbl.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BlanceLbl.ForeColor = Color.DarkSlateGray;
            BlanceLbl.Location = new Point(277, 158);
            BlanceLbl.Name = "BlanceLbl";
            BlanceLbl.Size = new Size(321, 46);
            BlanceLbl.TabIndex = 47;
            BlanceLbl.Text = "Available Balance";
            // 
            // Withdraw
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 550);
            Controls.Add(BlanceLbl);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(WithdrawAmtTb);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Withdraw";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Withdraw";
            Load += Withdraw_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private TextBox WithdrawAmtTb;
        private Label label3;
        private Label BlanceLbl;
    }
}