using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\USER\OneDrive - American International University-Bangladesh\Documents\ATMDB.mdf"";Integrated Security=True;Connect Timeout=30");
        int oldBlance, newBlance;
        string Acc = Login.accountNum;
        public void GetBlanceMethod()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Blance from AccountTbl1 where AccNum='" + Acc + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldBlance = Convert.ToInt32 ( dt.Rows[0][0].ToString());
            con.Close();
        }

        private void AddTransctionMethod()
        {
            string transactionType = "Deposit";
            try
            {
                con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "','" + transactionType  + "'," + DepositAmtLbl.Text + ",'" + DateTime.Today.ToString() + "')";
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
        private void Deposit_Load(object sender, EventArgs e)
        {
            GetBlanceMethod();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DepositAmtLbl.Text == "" || Convert.ToInt32(DepositAmtLbl.Text) <= 0)
            {
                MessageBox.Show("Enter Amount To Deposit");
            }
            else
            {
             
                newBlance = oldBlance + Convert.ToInt32(DepositAmtLbl.Text);

                try
                {
                    con.Open();
                    string query = "Update AccountTbl1 set Blance=" + newBlance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfully Deposit");
                    con.Close();
                    AddTransctionMethod();
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

        private void button2_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
