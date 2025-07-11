namespace Shipping_System.Forms
{
    partial class CustomerDetails
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
            label1 = new Label();
            pcbuserlogo = new PictureBox();
            txtfirstname = new TextBox();
            label3 = new Label();
            txtlastname = new TextBox();
            label2 = new Label();
            txtaddress = new TextBox();
            label4 = new Label();
            txtconno = new TextBox();
            label6 = new Label();
            txtemail = new TextBox();
            label5 = new Label();
            txtpassword = new TextBox();
            label7 = new Label();
            label9 = new Label();
            lblid = new Label();
            dgvcustomerdetails = new DataGridView();
            btnedit = new Button();
            btnclear = new Button();
            lblwarn = new Label();
            lblcustomername = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbuserlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvcustomerdetails).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(257, 32);
            label1.TabIndex = 3;
            label1.Text = "Personal Information";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pcbuserlogo
            // 
            pcbuserlogo.Location = new Point(538, 17);
            pcbuserlogo.Name = "pcbuserlogo";
            pcbuserlogo.Size = new Size(53, 52);
            pcbuserlogo.TabIndex = 4;
            pcbuserlogo.TabStop = false;
            // 
            // txtfirstname
            // 
            txtfirstname.Location = new Point(131, 145);
            txtfirstname.Multiline = true;
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(270, 29);
            txtfirstname.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 145);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 13;
            label3.Text = "First Name";
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(538, 145);
            txtlastname.Multiline = true;
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(270, 29);
            txtlastname.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(442, 145);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 15;
            label2.Text = "Last Name";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(131, 208);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(270, 81);
            txtaddress.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 206);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 17;
            label4.Text = "Address";
            // 
            // txtconno
            // 
            txtconno.Location = new Point(538, 208);
            txtconno.Multiline = true;
            txtconno.Name = "txtconno";
            txtconno.Size = new Size(270, 29);
            txtconno.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(442, 208);
            label6.Name = "label6";
            label6.Size = new Size(73, 42);
            label6.TabIndex = 20;
            label6.Text = "Phone \r\nNumber";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(538, 270);
            txtemail.Multiline = true;
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(270, 29);
            txtemail.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(442, 268);
            label5.Name = "label5";
            label5.Size = new Size(59, 21);
            label5.TabIndex = 21;
            label5.Text = "E-mail";
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(131, 316);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(270, 29);
            txtpassword.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(33, 314);
            label7.Name = "label7";
            label7.Size = new Size(82, 21);
            label7.TabIndex = 25;
            label7.Text = "Password";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(33, 93);
            label9.Name = "label9";
            label9.Size = new Size(104, 21);
            label9.TabIndex = 13;
            label9.Text = "Customer ID";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblid.ForeColor = Color.DarkRed;
            lblid.Location = new Point(168, 93);
            lblid.Name = "lblid";
            lblid.Size = new Size(0, 21);
            lblid.TabIndex = 13;
            // 
            // dgvcustomerdetails
            // 
            dgvcustomerdetails.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvcustomerdetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcustomerdetails.Location = new Point(33, 378);
            dgvcustomerdetails.Name = "dgvcustomerdetails";
            dgvcustomerdetails.Size = new Size(499, 108);
            dgvcustomerdetails.TabIndex = 26;
            dgvcustomerdetails.CellClick += dgvcustomerdetails_CellClick;
            // 
            // btnedit
            // 
            btnedit.BackColor = SystemColors.Highlight;
            btnedit.FlatStyle = FlatStyle.Popup;
            btnedit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnedit.ForeColor = SystemColors.ActiveCaptionText;
            btnedit.Location = new Point(587, 448);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(87, 38);
            btnedit.TabIndex = 27;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = false;
            btnedit.Click += btnedit_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = SystemColors.Highlight;
            btnclear.FlatStyle = FlatStyle.Popup;
            btnclear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnclear.ForeColor = SystemColors.ActiveCaptionText;
            btnclear.Location = new Point(712, 448);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(87, 38);
            btnclear.TabIndex = 27;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // lblwarn
            // 
            lblwarn.AutoSize = true;
            lblwarn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblwarn.ForeColor = Color.DarkRed;
            lblwarn.Location = new Point(558, 388);
            lblwarn.Name = "lblwarn";
            lblwarn.Size = new Size(263, 30);
            lblwarn.TabIndex = 13;
            lblwarn.Text = "*You can edit your details by pressing the\r\ndetails of the details box and press Edit button";
            // 
            // lblcustomername
            // 
            lblcustomername.AutoSize = true;
            lblcustomername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcustomername.Location = new Point(610, 32);
            lblcustomername.Name = "lblcustomername";
            lblcustomername.Size = new Size(0, 21);
            lblcustomername.TabIndex = 13;
            // 
            // CustomerDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(847, 498);
            Controls.Add(btnclear);
            Controls.Add(btnedit);
            Controls.Add(dgvcustomerdetails);
            Controls.Add(txtpassword);
            Controls.Add(label7);
            Controls.Add(txtconno);
            Controls.Add(label6);
            Controls.Add(txtemail);
            Controls.Add(label5);
            Controls.Add(txtaddress);
            Controls.Add(label4);
            Controls.Add(txtlastname);
            Controls.Add(label2);
            Controls.Add(lblid);
            Controls.Add(lblwarn);
            Controls.Add(lblcustomername);
            Controls.Add(label9);
            Controls.Add(txtfirstname);
            Controls.Add(label3);
            Controls.Add(pcbuserlogo);
            Controls.Add(label1);
            Name = "CustomerDetails";
            Text = "CustomerDetails";
            Load += CustomerDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pcbuserlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvcustomerdetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pcbuserlogo;
        private TextBox txtfirstname;
        private Label label3;
        private TextBox txtlastname;
        private Label label2;
        private TextBox txtaddress;
        private Label label4;
        private TextBox txtconno;
        private Label label6;
        private TextBox txtemail;
        private Label label5;
        private TextBox txtpassword;
        private Label label7;
        private Label label9;
        private Label lblid;
        private DataGridView dgvcustomerdetails;
        private Button btnedit;
        private Button btnclear;
        private Label lblwarn;
        private Label lblcustomername;
    }
}