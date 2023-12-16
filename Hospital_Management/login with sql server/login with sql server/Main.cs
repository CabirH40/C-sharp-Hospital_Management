using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_with_sql_server
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void doctToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Left += 8;
            if (label2.Left > this.Width)
                label2.Left -= this.Width;
        }

        private void addDoctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addoctor f = new addoctor();
            f.Show();

          }

        private void mangeDoktorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mange_doctor f = new mange_doctor();
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patient frm = new patient();
            frm.Show();
        }

        private void addProccessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addpro f = new addpro();
            f.Show();

        }

        private void mangeProccessToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
