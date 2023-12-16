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
//using System.Data.SqlClient;
namespace login_with_sql_server
{
    public partial class addoctor : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N6C0S9Q;Initial Catalog=hos_fadi;Integrated Security=True");
        public addoctor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into doctor values('"+txtBox_ad_doctor.Text+"','"+txtBox_tlf_doctor.Text +"','"+comboBox1.Text +"','"+txtBox_adres_doctor.Text +"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Add doctor successfully..!");
            txtBox_adres_doctor.Text = "";
            txtBox_ad_doctor.Text = "";
            txtBox_tlf_doctor.Text = "";
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_adres_doctor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_tlf_doctor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_ad_doctor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
