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

namespace ATM
{
    public partial class Blance : Form
    {
        public Blance()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\USER\OneDrive - American International University-Bangladesh\Documents\ATMDB.mdf"";Integrated Security=True;Connect Timeout=30");
        public void GetBlanceMethod()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Blance from AccountTbl1 where AccNum='"+AccNumLbl.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BlanceLbl.Text = dt.Rows[0][0].ToString();
            con.Close();
        }
        private void Blance_Load(object sender, EventArgs e)
        {
            AccNumLbl.Text = Login.accountNum;
            GetBlanceMethod();
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
