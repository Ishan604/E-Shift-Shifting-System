namespace Shipping_System.Forms
{
    partial class CustomerRegistration
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
            txtfirstname = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtlastname = new TextBox();
            label4 = new Label();
            txtaddress = new TextBox();
            label5 = new Label();
            txtemail = new TextBox();
            label6 = new Label();
            txtconno = new TextBox();
            label7 = new Label();
            txtpassword = new TextBox();
            label8 = new Label();
            txtconfpassword = new TextBox();
            btnclear = new Button();
            btnsignup = new Button();
            btnback = new Button();
            pcbcuser = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbcuser).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 21);
            label1.Name = "label1";
            label1.Size = new Size(270, 32);
            label1.TabIndex = 2;
            label1.Text = "Customer Registration";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtfirstname
            // 
            txtfirstname.Location = new Point(208, 87);
            txtfirstname.Multiline = true;
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(270, 29);
            txtfirstname.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 83);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 11;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 140);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 11;
            label2.Text = "Last Name";
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(208, 142);
            txtlastname.Multiline = true;
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(270, 29);
            txtlastname.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 195);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 11;
            label4.Text = "Address";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(208, 199);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(332, 110);
            txtaddress.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 381);
            label5.Name = "label5";
            label5.Size = new Size(59, 21);
            label5.TabIndex = 11;
            label5.Text = "E-mail";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(208, 383);
            txtemail.Multiline = true;
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(270, 29);
            txtemail.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(38, 332);
            label6.Name = "label6";
            label6.Size = new Size(126, 21);
            label6.TabIndex = 11;
            label6.Text = "Phone Number";
            // 
            // txtconno
            // 
            txtconno.Location = new Point(208, 334);
            txtconno.Multiline = true;
            txtconno.Name = "txtconno";
            txtconno.Size = new Size(270, 29);
            txtconno.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(40, 428);
            label7.Name = "label7";
            label7.Size = new Size(82, 21);
            label7.TabIndex = 11;
            label7.Text = "Password";
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(208, 430);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(270, 29);
            txtpassword.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(40, 475);
            label8.Name = "label8";
            label8.Size = new Size(148, 21);
            label8.TabIndex = 11;
            label8.Text = "Confirm Password";
            // 
            // txtconfpassword
            // 
            txtconfpassword.Location = new Point(208, 475);
            txtconfpassword.Multiline = true;
            txtconfpassword.Name = "txtconfpassword";
            txtconfpassword.PasswordChar = '*';
            txtconfpassword.Size = new Size(270, 29);
            txtconfpassword.TabIndex = 7;
            // 
            // btnclear
            // 
            btnclear.BackColor = SystemColors.Highlight;
            btnclear.FlatStyle = FlatStyle.Popup;
            btnclear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnclear.ForeColor = SystemColors.ActiveCaptionText;
            btnclear.Location = new Point(105, 538);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(87, 38);
            btnclear.TabIndex = 8;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btnsignup
            // 
            btnsignup.BackColor = SystemColors.Highlight;
            btnsignup.FlatStyle = FlatStyle.Popup;
            btnsignup.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnsignup.ForeColor = SystemColors.ActiveCaptionText;
            btnsignup.Location = new Point(262, 538);
            btnsignup.Name = "btnsignup";
            btnsignup.Size = new Size(87, 38);
            btnsignup.TabIndex = 9;
            btnsignup.Text = "Sign Up";
            btnsignup.UseVisualStyleBackColor = false;
            btnsignup.Click += btnsignup_Click;
            // 
            // btnback
            // 
            btnback.BackColor = SystemColors.Highlight;
            btnback.FlatStyle = FlatStyle.Popup;
            btnback.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnback.ForeColor = SystemColors.ActiveCaptionText;
            btnback.Location = new Point(416, 538);
            btnback.Name = "btnback";
            btnback.Size = new Size(87, 38);
            btnback.TabIndex = 10;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // pcbcuser
            // 
            pcbcuser.Location = new Point(120, 12);
            pcbcuser.Name = "pcbcuser";
            pcbcuser.Size = new Size(50, 50);
            pcbcuser.TabIndex = 12;
            pcbcuser.TabStop = false;
            // 
            // CustomerRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(598, 606);
            Controls.Add(pcbcuser);
            Controls.Add(btnback);
            Controls.Add(btnsignup);
            Controls.Add(btnclear);
            Controls.Add(txtlastname);
            Controls.Add(label2);
            Controls.Add(txtaddress);
            Controls.Add(label4);
            Controls.Add(txtconno);
            Controls.Add(label6);
            Controls.Add(txtconfpassword);
            Controls.Add(label8);
            Controls.Add(txtpassword);
            Controls.Add(label7);
            Controls.Add(txtemail);
            Controls.Add(label5);
            Controls.Add(txtfirstname);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "CustomerRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerRegistration";
            Load += CustomerRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)pcbcuser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtfirstname;
        private Label label3;
        private Label label2;
        private TextBox txtlastname;
        private Label label4;
        private TextBox txtaddress;
        private Label label5;
        private TextBox txtemail;
        private Label label6;
        private TextBox txtconno;
        private Label label7;
        private TextBox txtpassword;
        private Label label8;
        private TextBox txtconfpassword;
        private Button btnclear;
        private Button btnsignup;
        private Button btnback;
        private PictureBox pcbcuser;
    }
}