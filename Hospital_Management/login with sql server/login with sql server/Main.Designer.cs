
namespace login_with_sql_server
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.doctToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDoctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeDoktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeProccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.proccessToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doctToolStripMenuItem
            // 
            this.doctToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDoctorsToolStripMenuItem,
            this.mangeDoktorToolStripMenuItem});
            this.doctToolStripMenuItem.Name = "doctToolStripMenuItem";
            this.doctToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.doctToolStripMenuItem.Text = "doctors";
            this.doctToolStripMenuItem.Click += new System.EventHandler(this.doctToolStripMenuItem_Click);
            // 
            // addDoctorsToolStripMenuItem
            // 
            this.addDoctorsToolStripMenuItem.Name = "addDoctorsToolStripMenuItem";
            this.addDoctorsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.addDoctorsToolStripMenuItem.Text = "Add Doctors";
            this.addDoctorsToolStripMenuItem.Click += new System.EventHandler(this.addDoctorsToolStripMenuItem_Click);
            // 
            // mangeDoktorToolStripMenuItem
            // 
            this.mangeDoktorToolStripMenuItem.Name = "mangeDoktorToolStripMenuItem";
            this.mangeDoktorToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.mangeDoktorToolStripMenuItem.Text = "Mange doktor";
            this.mangeDoktorToolStripMenuItem.Click += new System.EventHandler(this.mangeDoktorToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.patientToolStripMenuItem.Text = "patient";
            this.patientToolStripMenuItem.Click += new System.EventHandler(this.patientToolStripMenuItem_Click);
            // 
            // proccessToolStripMenuItem
            // 
            this.proccessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProccessToolStripMenuItem,
            this.mangeProccessToolStripMenuItem});
            this.proccessToolStripMenuItem.Name = "proccessToolStripMenuItem";
            this.proccessToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.proccessToolStripMenuItem.Text = "proccess";
            // 
            // addProccessToolStripMenuItem
            // 
            this.addProccessToolStripMenuItem.Name = "addProccessToolStripMenuItem";
            this.addProccessToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addProccessToolStripMenuItem.Text = "Add proccess";
            this.addProccessToolStripMenuItem.Click += new System.EventHandler(this.addProccessToolStripMenuItem_Click);
            // 
            // mangeProccessToolStripMenuItem
            // 
            this.mangeProccessToolStripMenuItem.Name = "mangeProccessToolStripMenuItem";
            this.mangeProccessToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mangeProccessToolStripMenuItem.Text = "View ALL proccess";
            this.mangeProccessToolStripMenuItem.Click += new System.EventHandler(this.mangeProccessToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(107, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hospiytal Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(413, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "programmed By : Gaber Hasan";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(866, 470);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doctToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDoctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangeDoktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangeProccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}