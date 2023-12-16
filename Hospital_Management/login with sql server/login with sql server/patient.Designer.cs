
namespace login_with_sql_server
{
    partial class patient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_delete_patient = new System.Windows.Forms.Button();
            this.btn_edit_patient = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_ad_patient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tlf_patient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_adres_patient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_age_patient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_state_patient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_sectione = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_new_patient = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(347, 337);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
            // 
            // btn_delete_patient
            // 
            this.btn_delete_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_patient.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_patient.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_delete_patient.Location = new System.Drawing.Point(131, 355);
            this.btn_delete_patient.Name = "btn_delete_patient";
            this.btn_delete_patient.Size = new System.Drawing.Size(111, 54);
            this.btn_delete_patient.TabIndex = 1;
            this.btn_delete_patient.Text = "Delete";
            this.btn_delete_patient.UseVisualStyleBackColor = true;
            this.btn_delete_patient.Click += new System.EventHandler(this.btn_delete_patient_Click);
            // 
            // btn_edit_patient
            // 
            this.btn_edit_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_patient.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_patient.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_edit_patient.Location = new System.Drawing.Point(14, 355);
            this.btn_edit_patient.Name = "btn_edit_patient";
            this.btn_edit_patient.Size = new System.Drawing.Size(111, 54);
            this.btn_edit_patient.TabIndex = 2;
            this.btn_edit_patient.Text = "Edit";
            this.btn_edit_patient.UseVisualStyleBackColor = true;
            this.btn_edit_patient.Click += new System.EventHandler(this.btn_edit_patient_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(248, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 400);
            this.label1.TabIndex = 4;
            // 
            // txtBox_ad_patient
            // 
            this.txtBox_ad_patient.Location = new System.Drawing.Point(458, 48);
            this.txtBox_ad_patient.Name = "txtBox_ad_patient";
            this.txtBox_ad_patient.Size = new System.Drawing.Size(228, 20);
            this.txtBox_ad_patient.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(389, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // txt_tlf_patient
            // 
            this.txt_tlf_patient.Location = new System.Drawing.Point(458, 74);
            this.txt_tlf_patient.Name = "txt_tlf_patient";
            this.txt_tlf_patient.Size = new System.Drawing.Size(228, 20);
            this.txt_tlf_patient.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(389, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone :";
            // 
            // txt_adres_patient
            // 
            this.txt_adres_patient.Location = new System.Drawing.Point(458, 100);
            this.txt_adres_patient.Name = "txt_adres_patient";
            this.txt_adres_patient.Size = new System.Drawing.Size(228, 20);
            this.txt_adres_patient.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(383, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address:";
            // 
            // txt_age_patient
            // 
            this.txt_age_patient.Location = new System.Drawing.Point(458, 136);
            this.txt_age_patient.Name = "txt_age_patient";
            this.txt_age_patient.Size = new System.Drawing.Size(228, 20);
            this.txt_age_patient.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(393, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Age:";
            // 
            // txt_state_patient
            // 
            this.txt_state_patient.Location = new System.Drawing.Point(458, 173);
            this.txt_state_patient.Multiline = true;
            this.txt_state_patient.Name = "txt_state_patient";
            this.txt_state_patient.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_state_patient.Size = new System.Drawing.Size(228, 116);
            this.txt_state_patient.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(393, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "State:";
            // 
            // comboBox_sectione
            // 
            this.comboBox_sectione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sectione.FormattingEnabled = true;
            this.comboBox_sectione.Items.AddRange(new object[] {
            "Heart",
            "Bonse",
            "Eyee",
            "Fmale"});
            this.comboBox_sectione.Location = new System.Drawing.Point(458, 295);
            this.comboBox_sectione.Name = "comboBox_sectione";
            this.comboBox_sectione.Size = new System.Drawing.Size(228, 21);
            this.comboBox_sectione.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(390, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Section :";
            // 
            // btn_new_patient
            // 
            this.btn_new_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new_patient.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_patient.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_new_patient.Location = new System.Drawing.Point(468, 327);
            this.btn_new_patient.Name = "btn_new_patient";
            this.btn_new_patient.Size = new System.Drawing.Size(209, 79);
            this.btn_new_patient.TabIndex = 18;
            this.btn_new_patient.Text = "Add New Patient";
            this.btn_new_patient.UseVisualStyleBackColor = true;
            this.btn_new_patient.Click += new System.EventHandler(this.btn_new_patient_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(458, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(409, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "ID";
            // 
            // patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 418);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_new_patient);
            this.Controls.Add(this.comboBox_sectione);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_state_patient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_age_patient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_adres_patient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tlf_patient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_ad_patient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_edit_patient);
            this.Controls.Add(this.btn_delete_patient);
            this.Controls.Add(this.dataGridView2);
            this.Name = "patient";
            this.Text = "patient";
            this.Load += new System.EventHandler(this.patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_delete_patient;
        private System.Windows.Forms.Button btn_edit_patient;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_ad_patient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tlf_patient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_adres_patient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_age_patient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_state_patient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_sectione;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_new_patient;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
    }
}