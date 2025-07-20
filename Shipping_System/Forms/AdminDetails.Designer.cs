namespace Shipping_System.Forms
{
    partial class AdminDetails
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
            btnclear = new Button();
            btnedit = new Button();
            dgvadmindetails = new DataGridView();
            txtpassword = new TextBox();
            label7 = new Label();
            txtconno = new TextBox();
            label6 = new Label();
            txtemail = new TextBox();
            label5 = new Label();
            txtlastname = new TextBox();
            label2 = new Label();
            lblid = new Label();
            lblwarn = new Label();
            lbladminname = new Label();
            label9 = new Label();
            txtfirstname = new TextBox();
            label3 = new Label();
            pcbuserlogo = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvadmindetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbuserlogo).BeginInit();
            SuspendLayout();
            // 
            // btnclear
            // 
            btnclear.BackColor = SystemColors.Highlight;
            btnclear.FlatStyle = FlatStyle.Popup;
            btnclear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnclear.ForeColor = SystemColors.ActiveCaptionText;
            btnclear.Location = new Point(719, 346);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(87, 38);
            btnclear.TabIndex = 48;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btnedit
            // 
            btnedit.BackColor = SystemColors.Highlight;
            btnedit.FlatStyle = FlatStyle.Popup;
            btnedit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnedit.ForeColor = SystemColors.ActiveCaptionText;
            btnedit.Location = new Point(594, 346);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(87, 38);
            btnedit.TabIndex = 47;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = false;
            btnedit.Click += btnedit_Click;
            // 
            // dgvadmindetails
            // 
            dgvadmindetails.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvadmindetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvadmindetails.Location = new Point(40, 346);
            dgvadmindetails.Name = "dgvadmindetails";
            dgvadmindetails.Size = new Size(499, 108);
            dgvadmindetails.TabIndex = 46;
            dgvadmindetails.CellClick += dgvadmindetails_CellClick;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(138, 268);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(270, 29);
            txtpassword.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(40, 266);
            label7.Name = "label7";
            label7.Size = new Size(82, 21);
            label7.TabIndex = 45;
            label7.Text = "Password";
            // 
            // txtconno
            // 
            txtconno.Location = new Point(536, 144);
            txtconno.Multiline = true;
            txtconno.Name = "txtconno";
            txtconno.Size = new Size(270, 29);
            txtconno.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(440, 144);
            label6.Name = "label6";
            label6.Size = new Size(73, 42);
            label6.TabIndex = 42;
            label6.Text = "Phone \r\nNumber";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(536, 206);
            txtemail.Multiline = true;
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(270, 29);
            txtemail.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(440, 204);
            label5.Name = "label5";
            label5.Size = new Size(59, 21);
            label5.TabIndex = 43;
            label5.Text = "E-mail";
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(138, 206);
            txtlastname.Multiline = true;
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(270, 29);
            txtlastname.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 206);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 37;
            label2.Text = "Last Name";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblid.ForeColor = Color.DarkRed;
            lblid.Location = new Point(175, 91);
            lblid.Name = "lblid";
            lblid.Size = new Size(0, 21);
            lblid.TabIndex = 35;
            // 
            // lblwarn
            // 
            lblwarn.AutoSize = true;
            lblwarn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblwarn.ForeColor = Color.DarkRed;
            lblwarn.Location = new Point(565, 286);
            lblwarn.Name = "lblwarn";
            lblwarn.Size = new Size(263, 30);
            lblwarn.TabIndex = 34;
            lblwarn.Text = "*You can edit your details by pressing the\r\ndetails of the details box and press Edit button";
            // 
            // lbladminname
            // 
            lbladminname.AutoSize = true;
            lbladminname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbladminname.Location = new Point(617, 30);
            lbladminname.Name = "lbladminname";
            lbladminname.Size = new Size(0, 21);
            lbladminname.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(40, 91);
            label9.Name = "label9";
            label9.Size = new Size(82, 21);
            label9.TabIndex = 32;
            label9.Text = "Admin ID";
            // 
            // txtfirstname
            // 
            txtfirstname.Location = new Point(138, 143);
            txtfirstname.Multiline = true;
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(270, 29);
            txtfirstname.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 143);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 31;
            label3.Text = "First Name";
            // 
            // pcbuserlogo
            // 
            pcbuserlogo.Location = new Point(545, 15);
            pcbuserlogo.Name = "pcbuserlogo";
            pcbuserlogo.Size = new Size(53, 52);
            pcbuserlogo.TabIndex = 29;
            pcbuserlogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(257, 32);
            label1.TabIndex = 28;
            label1.Text = "Personal Information";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // AdminDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(847, 498);
            Controls.Add(btnclear);
            Controls.Add(btnedit);
            Controls.Add(dgvadmindetails);
            Controls.Add(txtpassword);
            Controls.Add(label7);
            Controls.Add(txtconno);
            Controls.Add(label6);
            Controls.Add(txtemail);
            Controls.Add(label5);
            Controls.Add(txtlastname);
            Controls.Add(label2);
            Controls.Add(lblid);
            Controls.Add(lblwarn);
            Controls.Add(lbladminname);
            Controls.Add(label9);
            Controls.Add(txtfirstname);
            Controls.Add(label3);
            Controls.Add(pcbuserlogo);
            Controls.Add(label1);
            Name = "AdminDetails";
            Text = "AdminDetails";
            Load += AdminDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgvadmindetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbuserlogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnclear;
        private Button btnedit;
        private DataGridView dgvadmindetails;
        private TextBox txtpassword;
        private Label label7;
        private TextBox txtconno;
        private Label label6;
        private TextBox txtemail;
        private Label label5;
        private TextBox txtlastname;
        private Label label2;
        private Label lblid;
        private Label lblwarn;
        private Label lbladminname;
        private Label label9;
        private TextBox txtfirstname;
        private Label label3;
        private PictureBox pcbuserlogo;
        private Label label1;
    }
}