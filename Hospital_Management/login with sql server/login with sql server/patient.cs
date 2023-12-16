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
    public partial class patient : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N6C0S9Q;Initial Catalog=hos_fadi;Integrated Security=True");
        public patient()
        {
            InitializeComponent();
            btn_edit_patient.Enabled = false;
            SqlDataAdapter ad = new SqlDataAdapter("select * from patient", con);
            DataTable d = new DataTable();
            ad.Fill(d);
            dataGridView2.DataSource = d;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void patient_Load(object sender, EventArgs e)
        {

        }

   

        private void btn_new_patient_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into patient values('"+txtBox_ad_patient.Text+"','"+txt_tlf_patient.Text+"','"+txt_adres_patient.Text+"','"+Convert.ToInt32(txt_age_patient.Text)+"','"+ txt_state_patient.Text+"','"+comboBox_sectione.Text+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Add patient successfully..!");

            txtBox_ad_patient.Text = "";
            txt_tlf_patient.Text = "";
            txt_adres_patient.Text = "";
            txt_state_patient.Text = "";
            txt_age_patient.Text = "";
            SqlDataAdapter ad = new SqlDataAdapter("select * from patient", con);
            DataTable d = new DataTable();
            ad.Fill(d);
            dataGridView2.DataSource = d;

        }

        private void btn_edit_patient_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update patient set name='" + txtBox_ad_patient.Text + "',phone='" + txt_tlf_patient.Text + "',adress='"+txt_adres_patient.Text+"',age='"+ Convert.ToInt32( txt_age_patient.Text )+ "',state='" + txt_state_patient.Text + "',sectione='"+comboBox_sectione.Text+"' where id ='" + Convert.ToInt32(textBox1.Text) + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("edit successfully..!", "updata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            /*bu işlem ekren silmekten sonra ekran temizlenr*/
            SqlDataAdapter ad = new SqlDataAdapter("select * from patient", con);
            DataTable d = new DataTable();
            ad.Fill(d);
            dataGridView2.DataSource = d;
            txtBox_ad_patient.Text = "";
            txt_tlf_patient.Text = "";
            txt_adres_patient.Text = "";
            txt_state_patient.Text = "";
            txt_age_patient.Text = "";
            btn_edit_patient.Enabled = false;
            btn_new_patient.Enabled = true;
        }

        private void btn_delete_patient_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want delete the selected row!?...")== DialogResult.OK)
            {
                /*silme işlemi*/
                SqlCommand cmd = new SqlCommand("delete from patient where id='" + Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value) + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("delete successfully..!");

                /*bu işlem ekren silmekten sonra ekran temizlenr*/
                SqlDataAdapter ad = new SqlDataAdapter("select * from patient", con);
                DataTable d = new DataTable();
                ad.Fill(d);
                dataGridView2.DataSource = d;
            }
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label8.Visible = true;
            textBox1.Visible = true;
            btn_new_patient.Visible = false;
            btn_edit_patient.Enabled = true;
       
          
     
            textBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtBox_ad_patient.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_tlf_patient.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_adres_patient.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_age_patient.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_state_patient.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            comboBox_sectione.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
