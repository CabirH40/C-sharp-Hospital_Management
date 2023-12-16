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
    public partial class addpro : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N6C0S9Q;Initial Catalog=hos_fadi;Integrated Security=True");

        public addpro()
        {
            InitializeComponent();
        }

        private void addpro_Load(object sender, EventArgs e)
        {
            SqlDataAdapter d = new SqlDataAdapter("select * from doctor", con);
            DataTable t1 = new DataTable();

            d.Fill(t1);
            comboBox2.DataSource = t1;
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "id";



            SqlDataAdapter d1 = new SqlDataAdapter("select * from patient", con);
            DataTable t2 = new DataTable();
            d1.Fill(t2);
            comboBox1.DataSource = t2;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
                SqlCommand cmd = new SqlCommand("INSERT INTO [proc] values('" + comboBox1.DisplayMember + "','" + comboBox2.DisplayMember + "','" 
                    + Convert.ToInt32( comboBox2.SelectedValue) + "','"
                    + Convert.ToInt32(comboBox1.SelectedValue) + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + txt_state_patient.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Add pro successfully..!");
        }
    }
    
}
