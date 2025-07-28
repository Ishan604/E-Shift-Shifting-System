namespace Shipping_System.Forms
{
    partial class CustomerLogin
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
            pcblogo = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtcusmail = new TextBox();
            txtcuspassword = new TextBox();
            linkforgotpw = new LinkLabel();
            btnclear = new Button();
            btnlogin = new Button();
            label5 = new Label();
            linksignup = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pcblogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(319, 40);
            label1.Name = "label1";
            label1.Size = new Size(297, 50);
            label1.TabIndex = 1;
            label1.Text = "Customer Login";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pcblogo
            // 
            pcblogo.Location = new Point(63, 140);
            pcblogo.Margin = new Padding(3, 4, 3, 4);
            pcblogo.Name = "pcblogo";
            pcblogo.Size = new Size(347, 400);
            pcblogo.TabIndex = 2;
            pcblogo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(615, 143);
            label2.Name = "label2";
            label2.Size = new Size(120, 50);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(449, 241);
            label3.Name = "label3";
            label3.Size = new Size(86, 32);
            label3.TabIndex = 1;
            label3.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(449, 319);
            label4.Name = "label4";
            label4.Size = new Size(122, 32);
            label4.TabIndex = 1;
            label4.Text = "Password";
            // 
            // txtcusmail
            // 
            txtcusmail.Location = new Point(584, 241);
            txtcusmail.Margin = new Padding(3, 4, 3, 4);
            txtcusmail.Multiline = true;
            txtcusmail.Name = "txtcusmail";
            txtcusmail.Size = new Size(308, 37);
            txtcusmail.TabIndex = 1;
            // 
            // txtcuspassword
            // 
            txtcuspassword.Location = new Point(584, 320);
            txtcuspassword.Margin = new Padding(3, 4, 3, 4);
            txtcuspassword.Multiline = true;
            txtcuspassword.Name = "txtcuspassword";
            txtcuspassword.PasswordChar = '*';
            txtcuspassword.Size = new Size(308, 37);
            txtcuspassword.TabIndex = 2;
            // 
            // linkforgotpw
            // 
            linkforgotpw.AutoSize = true;
            linkforgotpw.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkforgotpw.ForeColor = Color.Black;
            linkforgotpw.LinkColor = Color.Black;
            linkforgotpw.Location = new Point(741, 377);
            linkforgotpw.Name = "linkforgotpw";
            linkforgotpw.Size = new Size(171, 25);
            linkforgotpw.TabIndex = 4;
            linkforgotpw.TabStop = true;
            linkforgotpw.Text = "Forgot Password?";
            // 
            // btnclear
            // 
            btnclear.BackColor = SystemColors.Highlight;
            btnclear.FlatStyle = FlatStyle.Flat;
            btnclear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnclear.Location = new Point(506, 435);
            btnclear.Margin = new Padding(3, 4, 3, 4);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(115, 56);
            btnclear.TabIndex = 5;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = SystemColors.Highlight;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnlogin.Location = new Point(696, 435);
            btnlogin.Margin = new Padding(3, 4, 3, 4);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(115, 56);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(476, 531);
            label5.Name = "label5";
            label5.Size = new Size(264, 25);
            label5.TabIndex = 6;
            label5.Text = "If you don't have an account ?";
            // 
            // linksignup
            // 
            linksignup.AutoSize = true;
            linksignup.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linksignup.ForeColor = Color.Black;
            linksignup.LinkColor = Color.Black;
            linksignup.Location = new Point(740, 531);
            linksignup.Name = "linksignup";
            linksignup.Size = new Size(83, 25);
            linksignup.TabIndex = 4;
            linksignup.TabStop = true;
            linksignup.Text = "Sign Up";
            linksignup.LinkClicked += linksignup_LinkClicked;
            // 
            // CustomerLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 600);
            Controls.Add(label5);
            Controls.Add(btnlogin);
            Controls.Add(btnclear);
            Controls.Add(linksignup);
            Controls.Add(linkforgotpw);
            Controls.Add(txtcuspassword);
            Controls.Add(txtcusmail);
            Controls.Add(pcblogo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Login";
            Load += CustomerLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pcblogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pcblogo;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtcusmail;
        private TextBox txtcuspassword;
        private LinkLabel linkforgotpw;
        private Button btnclear;
        private Button btnlogin;
        private Label label5;
        private LinkLabel linksignup;
    }
}