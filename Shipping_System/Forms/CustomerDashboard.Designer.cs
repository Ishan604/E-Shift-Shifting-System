namespace Shipping_System.Forms
{
    partial class CustomerDashboard
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
            panelnavigation = new Panel();
            btnlogout = new Button();
            btnsettings = new Button();
            btnstatus = new Button();
            btnjobs = new Button();
            btnpersonalinfo = new Button();
            panel2 = new Panel();
            pcblogo = new PictureBox();
            label2 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            paneldesktop = new Panel();
            panelnavigation.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcblogo).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelnavigation
            // 
            panelnavigation.BackColor = Color.FromArgb(64, 64, 64);
            panelnavigation.Controls.Add(btnlogout);
            panelnavigation.Controls.Add(btnsettings);
            panelnavigation.Controls.Add(btnstatus);
            panelnavigation.Controls.Add(btnjobs);
            panelnavigation.Controls.Add(btnpersonalinfo);
            panelnavigation.Controls.Add(panel2);
            panelnavigation.Dock = DockStyle.Left;
            panelnavigation.Location = new Point(0, 0);
            panelnavigation.Name = "panelnavigation";
            panelnavigation.Size = new Size(194, 625);
            panelnavigation.TabIndex = 0;
            // 
            // btnlogout
            // 
            btnlogout.Dock = DockStyle.Top;
            btnlogout.FlatAppearance.BorderSize = 0;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogout.ForeColor = Color.White;
            btnlogout.Location = new Point(0, 292);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(194, 54);
            btnlogout.TabIndex = 6;
            btnlogout.Text = "Log Out";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnsettings
            // 
            btnsettings.Dock = DockStyle.Top;
            btnsettings.FlatAppearance.BorderSize = 0;
            btnsettings.FlatStyle = FlatStyle.Flat;
            btnsettings.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsettings.ForeColor = Color.White;
            btnsettings.Location = new Point(0, 238);
            btnsettings.Name = "btnsettings";
            btnsettings.Size = new Size(194, 54);
            btnsettings.TabIndex = 5;
            btnsettings.Text = "Settings";
            btnsettings.UseVisualStyleBackColor = true;
            btnsettings.Click += btnsettings_Click;
            // 
            // btnstatus
            // 
            btnstatus.Dock = DockStyle.Top;
            btnstatus.FlatAppearance.BorderSize = 0;
            btnstatus.FlatStyle = FlatStyle.Flat;
            btnstatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnstatus.ForeColor = Color.White;
            btnstatus.Location = new Point(0, 184);
            btnstatus.Name = "btnstatus";
            btnstatus.Size = new Size(194, 54);
            btnstatus.TabIndex = 4;
            btnstatus.Text = "User Satatus";
            btnstatus.UseVisualStyleBackColor = true;
            btnstatus.Click += btnstatus_Click;
            // 
            // btnjobs
            // 
            btnjobs.Dock = DockStyle.Top;
            btnjobs.FlatAppearance.BorderSize = 0;
            btnjobs.FlatStyle = FlatStyle.Flat;
            btnjobs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnjobs.ForeColor = Color.White;
            btnjobs.Location = new Point(0, 130);
            btnjobs.Name = "btnjobs";
            btnjobs.Size = new Size(194, 54);
            btnjobs.TabIndex = 3;
            btnjobs.Text = "Jobs";
            btnjobs.UseVisualStyleBackColor = true;
            btnjobs.Click += btnjobs_Click;
            // 
            // btnpersonalinfo
            // 
            btnpersonalinfo.Dock = DockStyle.Top;
            btnpersonalinfo.FlatAppearance.BorderSize = 0;
            btnpersonalinfo.FlatStyle = FlatStyle.Flat;
            btnpersonalinfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnpersonalinfo.ForeColor = Color.White;
            btnpersonalinfo.Location = new Point(0, 76);
            btnpersonalinfo.Name = "btnpersonalinfo";
            btnpersonalinfo.Size = new Size(194, 54);
            btnpersonalinfo.TabIndex = 2;
            btnpersonalinfo.Text = "Personal Info";
            btnpersonalinfo.UseVisualStyleBackColor = true;
            btnpersonalinfo.Click += btnpersonalinfo_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(pcblogo);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 76);
            panel2.TabIndex = 1;
            // 
            // pcblogo
            // 
            pcblogo.Location = new Point(13, 14);
            pcblogo.Name = "pcblogo";
            pcblogo.Size = new Size(53, 49);
            pcblogo.TabIndex = 2;
            pcblogo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(72, 30);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 1;
            label2.Text = "E-shift Shifting";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(194, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(873, 76);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(366, 20);
            label1.Name = "label1";
            label1.Size = new Size(72, 30);
            label1.TabIndex = 0;
            label1.Text = "Home";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // paneldesktop
            // 
            paneldesktop.Dock = DockStyle.Fill;
            paneldesktop.Location = new Point(194, 76);
            paneldesktop.Name = "paneldesktop";
            paneldesktop.Size = new Size(873, 549);
            paneldesktop.TabIndex = 3;
            paneldesktop.Paint += paneldesktop_Paint;
            // 
            // CustomerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1067, 625);
            Controls.Add(paneldesktop);
            Controls.Add(panel3);
            Controls.Add(panelnavigation);
            Name = "CustomerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home Page";
            Load += CustomerDashboard_Load;
            panelnavigation.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcblogo).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelnavigation;
        private Panel panel2;
        private Button btnpersonalinfo;
        private Panel panel3;
        private Button btnsettings;
        private Button btnstatus;
        private Button btnjobs;
        private Button btnlogout;
        private Label label1;
        private Label label2;
        private PictureBox pcblogo;
        private Panel paneldesktop;
    }
}