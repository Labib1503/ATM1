using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;
namespace ATM
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\USER\OneDrive - American International University-Bangladesh\Documents\ATMDB.mdf"";Integrated Security=True;Connect Timeout=30");
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (AccNumTb.Text == "" || AccNameTb.Text == "" || AccFnameTb.Text == "" || AddressTb.Text == "" || PinTb.Text == "" || OccupationTB.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into AccountTbl1 values('" + AccNumTb.Text + "','" + AccNameTb.Text + "','" + AccFnameTb.Text + "','" + DOBdate.Value.Date + "','" + PhoneTb.Text + "','" + OccupationTB.Text + "','" + AddressTb.Text + "','" + EducationCb.SelectedText + "'," + PinTb.Text + "," + bal + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                    con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
