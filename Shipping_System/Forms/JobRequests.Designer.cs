namespace Shipping_System.Forms
{
    partial class JobRequests
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
            dgvjobdetails = new DataGridView();
            btncancel = new Button();
            btnconfirm = new Button();
            txtitems = new TextBox();
            txtconno = new TextBox();
            txtemail = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtdestination = new TextBox();
            label4 = new Label();
            txtname = new TextBox();
            txtstartloc = new TextBox();
            label3 = new Label();
            lbljobid = new Label();
            label8 = new Label();
            label7 = new Label();
            lblcustomerid = new Label();
            label2 = new Label();
            lblstatus = new Label();
            label9 = new Label();
            lblcustomername = new Label();
            pcbuserlogo = new PictureBox();
            label1 = new Label();
            btncheck = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvjobdetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbuserlogo).BeginInit();
            SuspendLayout();
            // 
            // dgvjobdetails
            // 
            dgvjobdetails.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvjobdetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvjobdetails.Location = new Point(571, 167);
            dgvjobdetails.Margin = new Padding(3, 4, 3, 4);
            dgvjobdetails.Name = "dgvjobdetails";
            dgvjobdetails.RowHeadersWidth = 51;
            dgvjobdetails.Size = new Size(362, 420);
            dgvjobdetails.TabIndex = 74;
            dgvjobdetails.CellClick += dgvjobdetails_CellClick;
            // 
            // btncancel
            // 
            btncancel.BackColor = Color.Tomato;
            btncancel.FlatStyle = FlatStyle.Popup;
            btncancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btncancel.ForeColor = SystemColors.ActiveCaptionText;
            btncancel.Location = new Point(697, 629);
            btncancel.Margin = new Padding(3, 4, 3, 4);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(111, 51);
            btncancel.TabIndex = 72;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = false;
            btncancel.Click += btncancel_Click;
            // 
            // btnconfirm
            // 
            btnconfirm.BackColor = Color.LimeGreen;
            btnconfirm.FlatStyle = FlatStyle.Popup;
            btnconfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnconfirm.ForeColor = SystemColors.ActiveCaptionText;
            btnconfirm.Location = new Point(549, 629);
            btnconfirm.Margin = new Padding(3, 4, 3, 4);
            btnconfirm.Name = "btnconfirm";
            btnconfirm.Size = new Size(113, 51);
            btnconfirm.TabIndex = 71;
            btnconfirm.Text = "Confirm";
            btnconfirm.UseVisualStyleBackColor = false;
            btnconfirm.Click += btnconfirm_Click;
            // 
            // txtitems
            // 
            txtitems.Location = new Point(49, 596);
            txtitems.Margin = new Padding(3, 4, 3, 4);
            txtitems.Multiline = true;
            txtitems.Name = "txtitems";
            txtitems.Size = new Size(462, 108);
            txtitems.TabIndex = 69;
            // 
            // txtconno
            // 
            txtconno.Location = new Point(203, 476);
            txtconno.Margin = new Padding(3, 4, 3, 4);
            txtconno.Multiline = true;
            txtconno.Name = "txtconno";
            txtconno.Size = new Size(308, 37);
            txtconno.TabIndex = 68;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(203, 415);
            txtemail.Margin = new Padding(3, 4, 3, 4);
            txtemail.Multiline = true;
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(308, 37);
            txtemail.TabIndex = 67;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(49, 537);
            label6.Name = "label6";
            label6.Size = new Size(244, 28);
            label6.TabIndex = 64;
            label6.Text = "Items you added to shift";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(49, 479);
            label5.Name = "label5";
            label5.Size = new Size(154, 28);
            label5.TabIndex = 63;
            label5.Text = "Phone Number";
            // 
            // txtdestination
            // 
            txtdestination.Location = new Point(203, 355);
            txtdestination.Margin = new Padding(3, 4, 3, 4);
            txtdestination.Multiline = true;
            txtdestination.Name = "txtdestination";
            txtdestination.Size = new Size(308, 37);
            txtdestination.TabIndex = 70;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 417);
            label4.Name = "label4";
            label4.Size = new Size(64, 28);
            label4.TabIndex = 62;
            label4.Text = "Email";
            // 
            // txtname
            // 
            txtname.Location = new Point(203, 233);
            txtname.Margin = new Padding(3, 4, 3, 4);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.Size = new Size(308, 37);
            txtname.TabIndex = 65;
            // 
            // txtstartloc
            // 
            txtstartloc.Location = new Point(203, 293);
            txtstartloc.Margin = new Padding(3, 4, 3, 4);
            txtstartloc.Multiline = true;
            txtstartloc.Name = "txtstartloc";
            txtstartloc.Size = new Size(308, 37);
            txtstartloc.TabIndex = 66;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 357);
            label3.Name = "label3";
            label3.Size = new Size(122, 28);
            label3.TabIndex = 61;
            label3.Text = "Destination";
            // 
            // lbljobid
            // 
            lbljobid.AutoSize = true;
            lbljobid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbljobid.ForeColor = Color.DarkRed;
            lbljobid.Location = new Point(203, 164);
            lbljobid.Name = "lbljobid";
            lbljobid.Size = new Size(0, 28);
            lbljobid.TabIndex = 60;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(49, 167);
            label8.Name = "label8";
            label8.Size = new Size(72, 28);
            label8.TabIndex = 59;
            label8.Text = "Job ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(49, 236);
            label7.Name = "label7";
            label7.Size = new Size(104, 28);
            label7.TabIndex = 58;
            label7.Text = "Full name";
            // 
            // lblcustomerid
            // 
            lblcustomerid.AutoSize = true;
            lblcustomerid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcustomerid.ForeColor = Color.DarkRed;
            lblcustomerid.Location = new Point(203, 116);
            lblcustomerid.Name = "lblcustomerid";
            lblcustomerid.Size = new Size(0, 28);
            lblcustomerid.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 296);
            label2.Name = "label2";
            label2.Size = new Size(146, 28);
            label2.TabIndex = 57;
            label2.Text = "Start Location";
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = true;
            lblstatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblstatus.Location = new Point(261, 164);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(0, 28);
            lblstatus.TabIndex = 56;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(49, 116);
            label9.Name = "label9";
            label9.Size = new Size(129, 28);
            label9.TabIndex = 55;
            label9.Text = "Customer ID";
            // 
            // lblcustomername
            // 
            lblcustomername.AutoSize = true;
            lblcustomername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcustomername.Location = new Point(644, 39);
            lblcustomername.Name = "lblcustomername";
            lblcustomername.Size = new Size(0, 28);
            lblcustomername.TabIndex = 53;
            // 
            // pcbuserlogo
            // 
            pcbuserlogo.Location = new Point(561, 19);
            pcbuserlogo.Margin = new Padding(3, 4, 3, 4);
            pcbuserlogo.Name = "pcbuserlogo";
            pcbuserlogo.Size = new Size(61, 69);
            pcbuserlogo.TabIndex = 52;
            pcbuserlogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 29);
            label1.Name = "label1";
            label1.Size = new Size(318, 41);
            label1.TabIndex = 51;
            label1.Text = "View All Job's Details";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btncheck
            // 
            btncheck.BackColor = SystemColors.Highlight;
            btncheck.FlatStyle = FlatStyle.Popup;
            btncheck.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btncheck.ForeColor = SystemColors.ActiveCaptionText;
            btncheck.Location = new Point(846, 629);
            btncheck.Margin = new Padding(3, 4, 3, 4);
            btncheck.Name = "btncheck";
            btncheck.Size = new Size(109, 51);
            btncheck.TabIndex = 75;
            btncheck.Text = "Check";
            btncheck.UseVisualStyleBackColor = false;
            // 
            // JobRequests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(968, 721);
            Controls.Add(btncheck);
            Controls.Add(dgvjobdetails);
            Controls.Add(btncancel);
            Controls.Add(btnconfirm);
            Controls.Add(txtitems);
            Controls.Add(txtconno);
            Controls.Add(txtemail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtdestination);
            Controls.Add(label4);
            Controls.Add(txtname);
            Controls.Add(txtstartloc);
            Controls.Add(label3);
            Controls.Add(lbljobid);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblcustomerid);
            Controls.Add(label2);
            Controls.Add(lblstatus);
            Controls.Add(label9);
            Controls.Add(lblcustomername);
            Controls.Add(pcbuserlogo);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "JobRequests";
            Text = "JobRequests";
            Load += JobRequests_Load;
            ((System.ComponentModel.ISupportInitialize)dgvjobdetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbuserlogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvjobdetails;
        private Button btncancel;
        private Button btnconfirm;
        private TextBox txtitems;
        private TextBox txtconno;
        private TextBox txtemail;
        private Label label6;
        private Label label5;
        private TextBox txtdestination;
        private Label label4;
        private TextBox txtname;
        private TextBox txtstartloc;
        private Label label3;
        private Label lbljobid;
        private Label label8;
        private Label label7;
        private Label lblcustomerid;
        private Label label2;
        private Label lblstatus;
        private Label label9;
        private Label lblcustomername;
        private PictureBox pcbuserlogo;
        private Label label1;
        private Button btncheck;
    }
}