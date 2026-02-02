namespace ATM
{
    partial class Blance
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
            panel2 = new Panel();
            label3 = new Label();
            AccNumLbl = new Label();
            BlanceLbl = new Label();
            label6 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 534);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 16);
            panel2.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(56, 159);
            label3.Name = "label3";
            label3.Size = new Size(362, 47);
            label3.TabIndex = 31;
            label3.Text = "Account Number : ";
            // 
            // AccNumLbl
            // 
            AccNumLbl.AutoSize = true;
            AccNumLbl.BackColor = SystemColors.Control;
            AccNumLbl.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccNumLbl.ForeColor = Color.DarkSlateGray;
            AccNumLbl.Location = new Point(458, 159);
            AccNumLbl.Name = "AccNumLbl";
            AccNumLbl.Size = new Size(177, 46);
            AccNumLbl.TabIndex = 32;
            AccNumLbl.Text = "Acc Num";
            // 
            // BlanceLbl
            // 
            BlanceLbl.AutoSize = true;
            BlanceLbl.BackColor = SystemColors.Control;
            BlanceLbl.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BlanceLbl.ForeColor = Color.DarkSlateGray;
            BlanceLbl.Location = new Point(458, 241);
            BlanceLbl.Name = "BlanceLbl";
            BlanceLbl.Size = new Size(205, 46);
            BlanceLbl.TabIndex = 34;
            BlanceLbl.Text = "Balance Tk";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(56, 241);
            label6.Name = "label6";
            label6.Size = new Size(289, 47);
            label6.TabIndex = 33;
            label6.Text = "Your Balance : ";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(335, 446);
            button2.Name = "button2";
            button2.Size = new Size(156, 64);
            button2.TabIndex = 35;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 117);
            panel1.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(779, 4);
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
            label1.Location = new Point(72, 28);
            label1.Name = "label1";
            label1.Size = new Size(612, 58);
            label1.TabIndex = 2;
            label1.Text = "ATM Management System";
            // 
            // Blance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 550);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(BlanceLbl);
            Controls.Add(label6);
            Controls.Add(AccNumLbl);
            Controls.Add(label3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Blance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Blance";
            Load += Blance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label3;
        private Label AccNumLbl;
        private Label BlanceLbl;
        private Label label6;
        private Button button2;
        private Panel panel1;
        private Label label1;
        private Label label2;
    }
}