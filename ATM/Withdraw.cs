using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\USER\OneDrive - American International University-Bangladesh\Documents\ATMDB.mdf"";Integrated Security=True;Connect Timeout=30");
        string Acc = Login.accountNum;
        int blance;
        int newBlance;
        public void GetBlanceMethod()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Blance from AccountTbl1 where AccNum='" + Acc + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BlanceLbl.Text = "Balance Tk: " + dt.Rows[0][0].ToString();
            blance = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }
        private void AddTransctionMethod()
        {
            string transactionType = "Withdraw";
            try
            {
                con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "','" + transactionType + "'," + WithdrawAmtTb.Text + ",'" + DateTime.Today.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Created Successfully");
                con.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            GetBlanceMethod();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(WithdrawAmtTb.Text=="")
            {
                MessageBox.Show("Missing Amount");
            }
            else if (Convert.ToInt32(WithdrawAmtTb.Text )<=0)
            {
                MessageBox.Show("Enter a Valid Amount");
            }
            else if (Convert.ToInt32(WithdrawAmtTb.Text) > blance )
            {
                MessageBox.Show("Balance Can't Be Negative");
            }
            else
            {
                newBlance = blance  - Convert.ToInt32(WithdrawAmtTb.Text);

                try
                {
                    con.Open();
                    string query = "Update AccountTbl1 set Blance=" + newBlance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfully Withdraw");
                    con.Close();
                    GetBlanceMethod();
                    Login log = new Login();
                    log.Show();
                    this.Hide();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
