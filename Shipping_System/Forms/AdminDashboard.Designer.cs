namespace Shipping_System.Forms
{
    partial class AdminDashboard
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
            btnassignedloads = new Button();
            btntransportunit = new Button();
            btnjobstatus = new Button();
            btnjobrequests = new Button();
            btnregcustomers = new Button();
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
            panelnavigation.Controls.Add(btnassignedloads);
            panelnavigation.Controls.Add(btntransportunit);
            panelnavigation.Controls.Add(btnjobstatus);
            panelnavigation.Controls.Add(btnjobrequests);
            panelnavigation.Controls.Add(btnregcustomers);
            panelnavigation.Controls.Add(btnpersonalinfo);
            panelnavigation.Controls.Add(panel2);
            panelnavigation.Dock = DockStyle.Left;
            panelnavigation.Location = new Point(0, 0);
            panelnavigation.Margin = new Padding(3, 4, 3, 4);
            panelnavigation.Name = "panelnavigation";
            panelnavigation.Size = new Size(222, 908);
            panelnavigation.TabIndex = 1;
            // 
            // btnlogout
            // 
            btnlogout.Dock = DockStyle.Top;
            btnlogout.FlatAppearance.BorderSize = 0;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogout.ForeColor = Color.White;
            btnlogout.Location = new Point(0, 533);
            btnlogout.Margin = new Padding(3, 4, 3, 4);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(222, 72);
            btnlogout.TabIndex = 8;
            btnlogout.Text = "Log Out";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnassignedloads
            // 
            btnassignedloads.Dock = DockStyle.Top;
            btnassignedloads.FlatAppearance.BorderSize = 0;
            btnassignedloads.FlatStyle = FlatStyle.Flat;
            btnassignedloads.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnassignedloads.ForeColor = Color.White;
            btnassignedloads.Location = new Point(0, 461);
            btnassignedloads.Margin = new Padding(3, 4, 3, 4);
            btnassignedloads.Name = "btnassignedloads";
            btnassignedloads.Size = new Size(222, 72);
            btnassignedloads.TabIndex = 7;
            btnassignedloads.Text = "Assign Loads";
            btnassignedloads.UseVisualStyleBackColor = true;
            btnassignedloads.Click += btnassignedloads_Click;
            // 
            // btntransportunit
            // 
            btntransportunit.Dock = DockStyle.Top;
            btntransportunit.FlatAppearance.BorderSize = 0;
            btntransportunit.FlatStyle = FlatStyle.Flat;
            btntransportunit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntransportunit.ForeColor = Color.White;
            btntransportunit.Location = new Point(0, 389);
            btntransportunit.Margin = new Padding(3, 4, 3, 4);
            btntransportunit.Name = "btntransportunit";
            btntransportunit.Size = new Size(222, 72);
            btntransportunit.TabIndex = 6;
            btntransportunit.Text = "Transport Units";
            btntransportunit.UseVisualStyleBackColor = true;
            btntransportunit.Click += btntransportunit_Click;
            // 
            // btnjobstatus
            // 
            btnjobstatus.Dock = DockStyle.Top;
            btnjobstatus.FlatAppearance.BorderSize = 0;
            btnjobstatus.FlatStyle = FlatStyle.Flat;
            btnjobstatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnjobstatus.ForeColor = Color.White;
            btnjobstatus.Location = new Point(0, 317);
            btnjobstatus.Margin = new Padding(3, 4, 3, 4);
            btnjobstatus.Name = "btnjobstatus";
            btnjobstatus.Size = new Size(222, 72);
            btnjobstatus.TabIndex = 5;
            btnjobstatus.Text = "Reports";
            btnjobstatus.UseVisualStyleBackColor = true;
            btnjobstatus.Click += btnjobstatus_Click;
            // 
            // btnjobrequests
            // 
            btnjobrequests.Dock = DockStyle.Top;
            btnjobrequests.FlatAppearance.BorderSize = 0;
            btnjobrequests.FlatStyle = FlatStyle.Flat;
            btnjobrequests.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnjobrequests.ForeColor = Color.White;
            btnjobrequests.Location = new Point(0, 245);
            btnjobrequests.Margin = new Padding(3, 4, 3, 4);
            btnjobrequests.Name = "btnjobrequests";
            btnjobrequests.Size = new Size(222, 72);
            btnjobrequests.TabIndex = 4;
            btnjobrequests.Text = "Job Requests";
            btnjobrequests.UseVisualStyleBackColor = true;
            btnjobrequests.Click += btnjobrequests_Click;
            // 
            // btnregcustomers
            // 
            btnregcustomers.Dock = DockStyle.Top;
            btnregcustomers.FlatAppearance.BorderSize = 0;
            btnregcustomers.FlatStyle = FlatStyle.Flat;
            btnregcustomers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnregcustomers.ForeColor = Color.White;
            btnregcustomers.Location = new Point(0, 173);
            btnregcustomers.Margin = new Padding(3, 4, 3, 4);
            btnregcustomers.Name = "btnregcustomers";
            btnregcustomers.Size = new Size(222, 72);
            btnregcustomers.TabIndex = 3;
            btnregcustomers.Text = "Registered Customers";
            btnregcustomers.UseVisualStyleBackColor = true;
            btnregcustomers.Click += btnregcustomers_Click;
            // 
            // btnpersonalinfo
            // 
            btnpersonalinfo.Dock = DockStyle.Top;
            btnpersonalinfo.FlatAppearance.BorderSize = 0;
            btnpersonalinfo.FlatStyle = FlatStyle.Flat;
            btnpersonalinfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnpersonalinfo.ForeColor = Color.White;
            btnpersonalinfo.Location = new Point(0, 101);
            btnpersonalinfo.Margin = new Padding(3, 4, 3, 4);
            btnpersonalinfo.Name = "btnpersonalinfo";
            btnpersonalinfo.Size = new Size(222, 72);
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
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 101);
            panel2.TabIndex = 1;
            // 
            // pcblogo
            // 
            pcblogo.Location = new Point(15, 19);
            pcblogo.Margin = new Padding(3, 4, 3, 4);
            pcblogo.Name = "pcblogo";
            pcblogo.Size = new Size(61, 65);
            pcblogo.TabIndex = 2;
            pcblogo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(82, 40);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 1;
            label2.Text = "E-shift Shifting";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(222, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(997, 101);
            panel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(418, 27);
            label1.Name = "label1";
            label1.Size = new Size(190, 37);
            label1.TabIndex = 0;
            label1.Text = "Admin - Page";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // paneldesktop
            // 
            paneldesktop.BackColor = SystemColors.ActiveCaption;
            paneldesktop.Dock = DockStyle.Fill;
            paneldesktop.Location = new Point(222, 101);
            paneldesktop.Margin = new Padding(3, 4, 3, 4);
            paneldesktop.Name = "paneldesktop";
            paneldesktop.Size = new Size(997, 807);
            paneldesktop.TabIndex = 4;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 908);
            Controls.Add(paneldesktop);
            Controls.Add(panel3);
            Controls.Add(panelnavigation);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
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
        private Button btntransportunit;
        private Button btnjobstatus;
        private Button btnjobrequests;
        private Button btnregcustomers;
        private Button btnpersonalinfo;
        private Panel panel2;
        private PictureBox pcblogo;
        private Label label2;
        private Panel panel3;
        private Label label1;
        private Panel paneldesktop;
        private Button btnlogout;
        private Button btnassignedloads;
    }
}