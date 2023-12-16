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

namespace login_with_sql_server
{
    public partial class Editdoctor : Form
    {
        mange_doctor fgrid;
        public Editdoctor(mange_doctor fg)
        {
            InitializeComponent();
            this.fgrid = fg;
   

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N6C0S9Q;Initial Catalog=hos_fadi;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update doctor set name='" + txtBox_adedit_doctor.Text + "',phone='" + txtBox_tlf_doctor.Text + "',section='" + comboBox1.Text + "',address='" + txtBox_adres_doctor.Text + "' where id ='" + Convert.ToInt32(txt_id.Text) + "'", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("edit successfully..!", "updata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            /*bu işlem ekren silmekten sonra ekran temizlenr*/
            SqlDataAdapter ad = new SqlDataAdapter("select * from doctor", con);
            DataTable d = new DataTable();
            ad.Fill(d);
            fgrid.dataGridView1.DataSource = d;
        }
    }
}
