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
    public partial class mange_doctor : Form
    {   /*sql bağlamak kurmak*/
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N6C0S9Q;Initial Catalog=hos_fadi;Integrated Security=True");
        public mange_doctor()
        {/*sql table bağlamak*/
            InitializeComponent();
            SqlDataAdapter ad = new SqlDataAdapter("select * from doctor" , con);
            DataTable d = new DataTable();
            ad.Fill(d);
            dataGridView1.DataSource = d;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Editdoctor f = new Editdoctor(this);
            f.txtBox_adedit_doctor.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f.txtBox_tlf_doctor.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f.comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f.txtBox_adres_doctor.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            f.txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
    





            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {      /*silme işlemi*/
            SqlCommand cmd = new SqlCommand("delete from doctor where id='" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("delete successfully..!");

          /*bu işlem ekren silmekten sonra ekran temizlenr*/
            SqlDataAdapter ad = new SqlDataAdapter("select * from doctor", con);
            DataTable d = new DataTable();
            ad.Fill(d);
            dataGridView1.DataSource = d;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
