namespace Shipping_System.Forms
{
    partial class ViewJob
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
            btnback = new Button();
            btndelete = new Button();
            btnedit = new Button();
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
            label7 = new Label();
            lblcustomerid = new Label();
            label2 = new Label();
            label9 = new Label();
            lblcustomername = new Label();
            pcbuserlogo = new PictureBox();
            label1 = new Label();
            dgvjobdetails = new DataGridView();
            label8 = new Label();
            lbljobid = new Label();
            lblwarn = new Label();
            lblstatus = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbuserlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvjobdetails).BeginInit();
            SuspendLayout();
            // 
            // btnback
            // 
            btnback.BackColor = SystemColors.Highlight;
            btnback.FlatStyle = FlatStyle.Popup;
            btnback.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnback.ForeColor = SystemColors.ActiveCaptionText;
            btnback.Location = new Point(834, 629);
            btnback.Margin = new Padding(3, 4, 3, 4);
            btnback.Name = "btnback";
            btnback.Size = new Size(99, 51);
            btnback.TabIndex = 48;
            btnback.Text = "<<Back";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = SystemColors.Highlight;
            btndelete.FlatStyle = FlatStyle.Popup;
            btndelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btndelete.ForeColor = SystemColors.ActiveCaptionText;
            btndelete.Location = new Point(696, 629);
            btndelete.Margin = new Padding(3, 4, 3, 4);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(99, 51);
            btndelete.TabIndex = 47;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            // 
            // btnedit
            // 
            btnedit.BackColor = SystemColors.Highlight;
            btnedit.FlatStyle = FlatStyle.Popup;
            btnedit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnedit.ForeColor = SystemColors.ActiveCaptionText;
            btnedit.Location = new Point(558, 629);
            btnedit.Margin = new Padding(3, 4, 3, 4);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(99, 51);
            btnedit.TabIndex = 46;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = false;
            btnedit.Click += btnedit_Click;
            // 
            // txtitems
            // 
            txtitems.Location = new Point(566, 179);
            txtitems.Margin = new Padding(3, 4, 3, 4);
            txtitems.Multiline = true;
            txtitems.Name = "txtitems";
            txtitems.Size = new Size(367, 347);
            txtitems.TabIndex = 44;
            // 
            // txtconno
            // 
            txtconno.Location = new Point(203, 479);
            txtconno.Margin = new Padding(3, 4, 3, 4);
            txtconno.Multiline = true;
            txtconno.Name = "txtconno";
            txtconno.Size = new Size(308, 37);
            txtconno.TabIndex = 43;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(203, 417);
            txtemail.Margin = new Padding(3, 4, 3, 4);
            txtemail.Multiline = true;
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(308, 37);
            txtemail.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(566, 120);
            label6.Name = "label6";
            label6.Size = new Size(244, 28);
            label6.TabIndex = 39;
            label6.Text = "Items you added to shift";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(49, 481);
            label5.Name = "label5";
            label5.Size = new Size(154, 28);
            label5.TabIndex = 38;
            label5.Text = "Phone Number";
            // 
            // txtdestination
            // 
            txtdestination.Location = new Point(203, 357);
            txtdestination.Margin = new Padding(3, 4, 3, 4);
            txtdestination.Multiline = true;
            txtdestination.Name = "txtdestination";
            txtdestination.Size = new Size(308, 37);
            txtdestination.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 420);
            label4.Name = "label4";
            label4.Size = new Size(64, 28);
            label4.TabIndex = 37;
            label4.Text = "Email";
            // 
            // txtname
            // 
            txtname.Location = new Point(203, 236);
            txtname.Margin = new Padding(3, 4, 3, 4);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.Size = new Size(308, 37);
            txtname.TabIndex = 40;
            // 
            // txtstartloc
            // 
            txtstartloc.Location = new Point(203, 296);
            txtstartloc.Margin = new Padding(3, 4, 3, 4);
            txtstartloc.Multiline = true;
            txtstartloc.Name = "txtstartloc";
            txtstartloc.Size = new Size(308, 37);
            txtstartloc.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 360);
            label3.Name = "label3";
            label3.Size = new Size(122, 28);
            label3.TabIndex = 36;
            label3.Text = "Destination";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(49, 239);
            label7.Name = "label7";
            label7.Size = new Size(104, 28);
            label7.TabIndex = 35;
            label7.Text = "Full name";
            // 
            // lblcustomerid
            // 
            lblcustomerid.AutoSize = true;
            lblcustomerid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcustomerid.ForeColor = Color.DarkRed;
            lblcustomerid.Location = new Point(203, 119);
            lblcustomerid.Name = "lblcustomerid";
            lblcustomerid.Size = new Size(0, 28);
            lblcustomerid.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 299);
            label2.Name = "label2";
            label2.Size = new Size(146, 28);
            label2.TabIndex = 34;
            label2.Text = "Start Location";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(49, 119);
            label9.Name = "label9";
            label9.Size = new Size(129, 28);
            label9.TabIndex = 33;
            label9.Text = "Customer ID";
            // 
            // lblcustomername
            // 
            lblcustomername.AutoSize = true;
            lblcustomername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcustomername.Location = new Point(662, 41);
            lblcustomername.Name = "lblcustomername";
            lblcustomername.Size = new Size(0, 28);
            lblcustomername.TabIndex = 31;
            // 
            // pcbuserlogo
            // 
            pcbuserlogo.Location = new Point(579, 21);
            pcbuserlogo.Margin = new Padding(3, 4, 3, 4);
            pcbuserlogo.Name = "pcbuserlogo";
            pcbuserlogo.Size = new Size(61, 69);
            pcbuserlogo.TabIndex = 30;
            pcbuserlogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 32);
            label1.Name = "label1";
            label1.Size = new Size(342, 41);
            label1.TabIndex = 29;
            label1.Text = "View Your Job's Details";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvjobdetails
            // 
            dgvjobdetails.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvjobdetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvjobdetails.Location = new Point(49, 553);
            dgvjobdetails.Margin = new Padding(3, 4, 3, 4);
            dgvjobdetails.Name = "dgvjobdetails";
            dgvjobdetails.RowHeadersWidth = 51;
            dgvjobdetails.Size = new Size(463, 152);
            dgvjobdetails.TabIndex = 49;
            dgvjobdetails.CellClick += dgvjobdetails_CellClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(49, 169);
            label8.Name = "label8";
            label8.Size = new Size(72, 28);
            label8.TabIndex = 35;
            label8.Text = "Job ID";
            // 
            // lbljobid
            // 
            lbljobid.AutoSize = true;
            lbljobid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbljobid.ForeColor = Color.DarkRed;
            lbljobid.Location = new Point(203, 167);
            lbljobid.Name = "lbljobid";
            lbljobid.Size = new Size(0, 28);
            lbljobid.TabIndex = 35;
            // 
            // lblwarn
            // 
            lblwarn.AutoSize = true;
            lblwarn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblwarn.ForeColor = Color.DarkRed;
            lblwarn.Location = new Point(558, 553);
            lblwarn.Name = "lblwarn";
            lblwarn.Size = new Size(335, 40);
            lblwarn.TabIndex = 50;
            lblwarn.Text = "*You can edit your details by pressing the\r\ndetails of the details box and press Edit button";
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = true;
            lblstatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblstatus.Location = new Point(261, 167);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(0, 28);
            lblstatus.TabIndex = 33;
            // 
            // ViewJob
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(968, 721);
            Controls.Add(lblwarn);
            Controls.Add(dgvjobdetails);
            Controls.Add(btnback);
            Controls.Add(btndelete);
            Controls.Add(btnedit);
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
            Name = "ViewJob";
            Text = "ViewJob";
            Load += ViewJob_Load;
            ((System.ComponentModel.ISupportInitialize)pcbuserlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvjobdetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnback;
        private Button btndelete;
        private Button btnedit;
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
        private Label label7;
        private Label lblcustomerid;
        private Label label2;
        private Label label9;
        private Label lblcustomername;
        private PictureBox pcbuserlogo;
        private Label label1;
        private DataGridView dgvjobdetails;
        private Label label8;
        private Label lbljobid;
        private Label lblwarn;
        private Label lblstatus;
    }
}