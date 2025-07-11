namespace Shipping_System.Forms
{
    partial class AdminLogin
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
            btnlogin = new Button();
            btnclear = new Button();
            linkforgotpw = new LinkLabel();
            txtadminid = new TextBox();
            txtadminmail = new TextBox();
            pcblogo = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            txtadminpassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcblogo).BeginInit();
            SuspendLayout();
            // 
            // btnlogin
            // 
            btnlogin.BackColor = SystemColors.Highlight;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnlogin.Location = new Point(620, 364);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(101, 42);
            btnlogin.TabIndex = 16;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            // 
            // btnclear
            // 
            btnclear.BackColor = SystemColors.Highlight;
            btnclear.FlatStyle = FlatStyle.Flat;
            btnclear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnclear.Location = new Point(454, 364);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(101, 42);
            btnclear.TabIndex = 17;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            // 
            // linkforgotpw
            // 
            linkforgotpw.AutoSize = true;
            linkforgotpw.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkforgotpw.ForeColor = Color.Black;
            linkforgotpw.LinkColor = Color.Black;
            linkforgotpw.Location = new Point(630, 312);
            linkforgotpw.Name = "linkforgotpw";
            linkforgotpw.Size = new Size(134, 20);
            linkforgotpw.TabIndex = 15;
            linkforgotpw.TabStop = true;
            linkforgotpw.Text = "Forgot Password?";
            // 
            // txtadminid
            // 
            txtadminid.Location = new Point(492, 227);
            txtadminid.Multiline = true;
            txtadminid.Name = "txtadminid";
            txtadminid.PasswordChar = '*';
            txtadminid.Size = new Size(270, 29);
            txtadminid.TabIndex = 12;
            // 
            // txtadminmail
            // 
            txtadminmail.Location = new Point(492, 180);
            txtadminmail.Multiline = true;
            txtadminmail.Name = "txtadminmail";
            txtadminmail.Size = new Size(270, 29);
            txtadminmail.TabIndex = 7;
            // 
            // pcblogo
            // 
            pcblogo.Location = new Point(37, 106);
            pcblogo.Name = "pcblogo";
            pcblogo.Size = new Size(304, 300);
            pcblogo.TabIndex = 13;
            pcblogo.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(374, 226);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 8;
            label4.Text = "Admin Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(374, 180);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 9;
            label3.Text = "E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(530, 108);
            label2.Name = "label2";
            label2.Size = new Size(94, 40);
            label2.TabIndex = 10;
            label2.Text = "Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 27);
            label1.Name = "label1";
            label1.Size = new Size(193, 40);
            label1.TabIndex = 11;
            label1.Text = "Admin Login";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(375, 270);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // txtadminpassword
            // 
            txtadminpassword.Location = new Point(493, 271);
            txtadminpassword.Multiline = true;
            txtadminpassword.Name = "txtadminpassword";
            txtadminpassword.PasswordChar = '*';
            txtadminpassword.Size = new Size(270, 29);
            txtadminpassword.TabIndex = 12;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlogin);
            Controls.Add(btnclear);
            Controls.Add(linkforgotpw);
            Controls.Add(txtadminpassword);
            Controls.Add(txtadminid);
            Controls.Add(txtadminmail);
            Controls.Add(label5);
            Controls.Add(pcblogo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Login";
            Load += AdminLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pcblogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlogin;
        private Button btnclear;
        private LinkLabel linkforgotpw;
        private TextBox txtadminid;
        private TextBox txtadminmail;
        private PictureBox pcblogo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox txtadminpassword;
    }
}