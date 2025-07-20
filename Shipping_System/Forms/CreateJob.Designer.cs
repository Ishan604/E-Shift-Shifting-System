namespace Shipping_System.Forms
{
    partial class CreateJob
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
            lblcustomername = new Label();
            pcbuserlogo = new PictureBox();
            label1 = new Label();
            lblid = new Label();
            label9 = new Label();
            label2 = new Label();
            txtstartloc = new TextBox();
            label3 = new Label();
            txtdestination = new TextBox();
            label4 = new Label();
            txtemail = new TextBox();
            label5 = new Label();
            txtconno = new TextBox();
            label6 = new Label();
            txtitems = new TextBox();
            label7 = new Label();
            txtname = new TextBox();
            btnsave = new Button();
            btnclear = new Button();
            btnback = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbuserlogo).BeginInit();
            SuspendLayout();
            // 
            // lblcustomername
            // 
            lblcustomername.AutoSize = true;
            lblcustomername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcustomername.Location = new Point(610, 27);
            lblcustomername.Name = "lblcustomername";
            lblcustomername.Size = new Size(0, 21);
            lblcustomername.TabIndex = 16;
            // 
            // pcbuserlogo
            // 
            pcbuserlogo.Location = new Point(538, 12);
            pcbuserlogo.Name = "pcbuserlogo";
            pcbuserlogo.Size = new Size(53, 52);
            pcbuserlogo.TabIndex = 15;
            pcbuserlogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(146, 32);
            label1.TabIndex = 14;
            label1.Text = "Create Jobs";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblid.ForeColor = Color.DarkRed;
            lblid.Location = new Point(160, 85);
            lblid.Name = "lblid";
            lblid.Size = new Size(0, 21);
            lblid.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(25, 85);
            label9.Name = "label9";
            label9.Size = new Size(104, 21);
            label9.TabIndex = 18;
            label9.Text = "Customer ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 184);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 18;
            label2.Text = "Start Location";
            // 
            // txtstartloc
            // 
            txtstartloc.Location = new Point(160, 182);
            txtstartloc.Multiline = true;
            txtstartloc.Name = "txtstartloc";
            txtstartloc.Size = new Size(270, 29);
            txtstartloc.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 230);
            label3.Name = "label3";
            label3.Size = new Size(99, 21);
            label3.TabIndex = 18;
            label3.Text = "Destination";
            // 
            // txtdestination
            // 
            txtdestination.Location = new Point(160, 228);
            txtdestination.Multiline = true;
            txtdestination.Name = "txtdestination";
            txtdestination.Size = new Size(270, 29);
            txtdestination.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 275);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 18;
            label4.Text = "Email";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(160, 273);
            txtemail.Multiline = true;
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(270, 29);
            txtemail.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 321);
            label5.Name = "label5";
            label5.Size = new Size(126, 21);
            label5.TabIndex = 18;
            label5.Text = "Phone Number";
            // 
            // txtconno
            // 
            txtconno.Location = new Point(160, 319);
            txtconno.Multiline = true;
            txtconno.Name = "txtconno";
            txtconno.Size = new Size(270, 29);
            txtconno.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(477, 135);
            label6.Name = "label6";
            label6.Size = new Size(185, 21);
            label6.TabIndex = 18;
            label6.Text = "Items you need to shift";
            // 
            // txtitems
            // 
            txtitems.Location = new Point(477, 179);
            txtitems.Multiline = true;
            txtitems.Name = "txtitems";
            txtitems.Size = new Size(322, 257);
            txtitems.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 139);
            label7.Name = "label7";
            label7.Size = new Size(85, 21);
            label7.TabIndex = 18;
            label7.Text = "Full name";
            // 
            // txtname
            // 
            txtname.Location = new Point(160, 137);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.Size = new Size(270, 29);
            txtname.TabIndex = 19;
            // 
            // btnsave
            // 
            btnsave.BackColor = SystemColors.Highlight;
            btnsave.FlatStyle = FlatStyle.Popup;
            btnsave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnsave.ForeColor = SystemColors.ActiveCaptionText;
            btnsave.Location = new Point(61, 398);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(87, 38);
            btnsave.TabIndex = 28;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = SystemColors.Highlight;
            btnclear.FlatStyle = FlatStyle.Popup;
            btnclear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnclear.ForeColor = SystemColors.ActiveCaptionText;
            btnclear.Location = new Point(182, 398);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(87, 38);
            btnclear.TabIndex = 28;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btnback
            // 
            btnback.BackColor = SystemColors.Highlight;
            btnback.FlatStyle = FlatStyle.Popup;
            btnback.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnback.ForeColor = SystemColors.ActiveCaptionText;
            btnback.Location = new Point(303, 398);
            btnback.Name = "btnback";
            btnback.Size = new Size(87, 38);
            btnback.TabIndex = 28;
            btnback.Text = "<<Back";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // CreateJob
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(847, 498);
            Controls.Add(btnback);
            Controls.Add(btnclear);
            Controls.Add(btnsave);
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
            Controls.Add(label7);
            Controls.Add(lblid);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(lblcustomername);
            Controls.Add(pcbuserlogo);
            Controls.Add(label1);
            Name = "CreateJob";
            Text = "CreateJob";
            Load += CreateJob_Load;
            ((System.ComponentModel.ISupportInitialize)pcbuserlogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcustomername;
        private PictureBox pcbuserlogo;
        private Label label1;
        private Label lblid;
        private Label label9;
        private Label label2;
        private TextBox txtstartloc;
        private Label label3;
        private TextBox txtdestination;
        private Label label4;
        private TextBox txtemail;
        private Label label5;
        private TextBox txtconno;
        private Label label6;
        private TextBox txtitems;
        private Label label7;
        private TextBox txtname;
        private Button btnsave;
        private Button btnclear;
        private Button btnback;
    }
}