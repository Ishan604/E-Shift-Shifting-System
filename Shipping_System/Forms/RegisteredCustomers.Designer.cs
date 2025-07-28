namespace Shipping_System.Forms
{
    partial class RegisteredCustomers
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
            dgvcustomerdetails = new DataGridView();
            txtpassword = new TextBox();
            label7 = new Label();
            txtconno = new TextBox();
            label6 = new Label();
            txtemail = new TextBox();
            label5 = new Label();
            txtaddress = new TextBox();
            label4 = new Label();
            txtlastname = new TextBox();
            label2 = new Label();
            lblid = new Label();
            lblcustomername = new Label();
            label9 = new Label();
            txtfirstname = new TextBox();
            label3 = new Label();
            pcbuserlogo = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvcustomerdetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbuserlogo).BeginInit();
            SuspendLayout();
            // 
            // btnclear
            // 
            btnclear.BackColor = SystemColors.Highlight;
            btnclear.FlatStyle = FlatStyle.Popup;
            btnclear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnclear.ForeColor = SystemColors.ActiveCaptionText;
            btnclear.Location = new Point(647, 449);
            btnclear.Margin = new Padding(3, 4, 3, 4);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(99, 51);
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
            btnedit.Location = new Point(805, 449);
            btnedit.Margin = new Padding(3, 4, 3, 4);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(99, 51);
            btnedit.TabIndex = 47;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = false;
            btnedit.Click += btnedit_Click;
            // 
            // dgvcustomerdetails
            // 
            dgvcustomerdetails.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvcustomerdetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcustomerdetails.Location = new Point(46, 536);
            dgvcustomerdetails.Margin = new Padding(3, 4, 3, 4);
            dgvcustomerdetails.Name = "dgvcustomerdetails";
            dgvcustomerdetails.RowHeadersWidth = 51;
            dgvcustomerdetails.Size = new Size(886, 144);
            dgvcustomerdetails.TabIndex = 46;
            dgvcustomerdetails.CellClick += dgvcustomerdetails_CellClick;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(158, 419);
            txtpassword.Margin = new Padding(3, 4, 3, 4);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(308, 37);
            txtpassword.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(46, 416);
            label7.Name = "label7";
            label7.Size = new Size(101, 28);
            label7.TabIndex = 45;
            label7.Text = "Password";
            // 
            // txtconno
            // 
            txtconno.Location = new Point(623, 275);
            txtconno.Margin = new Padding(3, 4, 3, 4);
            txtconno.Multiline = true;
            txtconno.Name = "txtconno";
            txtconno.Size = new Size(308, 37);
            txtconno.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(513, 275);
            label6.Name = "label6";
            label6.Size = new Size(89, 56);
            label6.TabIndex = 42;
            label6.Text = "Phone \r\nNumber";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(623, 357);
            txtemail.Margin = new Padding(3, 4, 3, 4);
            txtemail.Multiline = true;
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(308, 37);
            txtemail.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(513, 355);
            label5.Name = "label5";
            label5.Size = new Size(72, 28);
            label5.TabIndex = 43;
            label5.Text = "E-mail";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(158, 275);
            txtaddress.Margin = new Padding(3, 4, 3, 4);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(308, 107);
            txtaddress.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 272);
            label4.Name = "label4";
            label4.Size = new Size(87, 28);
            label4.TabIndex = 39;
            label4.Text = "Address";
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(623, 191);
            txtlastname.Margin = new Padding(3, 4, 3, 4);
            txtlastname.Multiline = true;
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(308, 37);
            txtlastname.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(513, 191);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 37;
            label2.Text = "Last Name";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblid.ForeColor = Color.DarkRed;
            lblid.Location = new Point(200, 121);
            lblid.Name = "lblid";
            lblid.Size = new Size(0, 28);
            lblid.TabIndex = 35;
            // 
            // lblcustomername
            // 
            lblcustomername.AutoSize = true;
            lblcustomername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcustomername.Location = new Point(639, 40);
            lblcustomername.Name = "lblcustomername";
            lblcustomername.Size = new Size(0, 28);
            lblcustomername.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(46, 121);
            label9.Name = "label9";
            label9.Size = new Size(129, 28);
            label9.TabIndex = 32;
            label9.Text = "Customer ID";
            // 
            // txtfirstname
            // 
            txtfirstname.Location = new Point(158, 191);
            txtfirstname.Margin = new Padding(3, 4, 3, 4);
            txtfirstname.Multiline = true;
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(308, 37);
            txtfirstname.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 191);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 31;
            label3.Text = "First Name";
            // 
            // pcbuserlogo
            // 
            pcbuserlogo.Location = new Point(557, 20);
            pcbuserlogo.Margin = new Padding(3, 4, 3, 4);
            pcbuserlogo.Name = "pcbuserlogo";
            pcbuserlogo.Size = new Size(61, 69);
            pcbuserlogo.TabIndex = 29;
            pcbuserlogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 31);
            label1.Name = "label1";
            label1.Size = new Size(315, 41);
            label1.TabIndex = 28;
            label1.Text = "Personal Information";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // RegisteredCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(968, 711);
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
            Controls.Add(lblcustomername);
            Controls.Add(label9);
            Controls.Add(txtfirstname);
            Controls.Add(label3);
            Controls.Add(pcbuserlogo);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegisteredCustomers";
            Text = "RegisteredCustomers";
            Load += RegisteredCustomers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvcustomerdetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbuserlogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnclear;
        private Button btnedit;
        private DataGridView dgvcustomerdetails;
        private TextBox txtpassword;
        private Label label7;
        private TextBox txtconno;
        private Label label6;
        private TextBox txtemail;
        private Label label5;
        private TextBox txtaddress;
        private Label label4;
        private TextBox txtlastname;
        private Label label2;
        private Label lblid;
        private Label lblcustomername;
        private Label label9;
        private TextBox txtfirstname;
        private Label label3;
        private PictureBox pcbuserlogo;
        private Label label1;
    }
}