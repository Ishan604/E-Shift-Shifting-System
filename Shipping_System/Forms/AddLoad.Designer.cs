namespace Shipping_System.Forms
{
    partial class AddLoad
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
            lbladminname = new Label();
            pcbuserlogo = new PictureBox();
            label1 = new Label();
            lbljobid = new Label();
            label8 = new Label();
            lblcustomerid = new Label();
            label9 = new Label();
            label2 = new Label();
            lblstartlocation = new Label();
            label4 = new Label();
            lbldestination = new Label();
            label3 = new Label();
            txtitems = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtloaditems = new TextBox();
            txtweight = new TextBox();
            dgvjobdetails = new DataGridView();
            dgvcontainerdetails = new DataGridView();
            btnassign = new Button();
            label7 = new Label();
            lblcontainerid = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbuserlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvjobdetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvcontainerdetails).BeginInit();
            SuspendLayout();
            // 
            // lbladminname
            // 
            lbladminname.AutoSize = true;
            lbladminname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbladminname.Location = new Point(553, 31);
            lbladminname.Name = "lbladminname";
            lbladminname.Size = new Size(0, 21);
            lbladminname.TabIndex = 36;
            // 
            // pcbuserlogo
            // 
            pcbuserlogo.Location = new Point(481, 16);
            pcbuserlogo.Name = "pcbuserlogo";
            pcbuserlogo.Size = new Size(53, 52);
            pcbuserlogo.TabIndex = 35;
            pcbuserlogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 24);
            label1.Name = "label1";
            label1.Size = new Size(285, 32);
            label1.TabIndex = 34;
            label1.Text = "Add Loads For The Jobs";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbljobid
            // 
            lbljobid.AutoSize = true;
            lbljobid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbljobid.ForeColor = Color.DarkRed;
            lbljobid.Location = new Point(166, 135);
            lbljobid.Name = "lbljobid";
            lbljobid.Size = new Size(0, 21);
            lbljobid.TabIndex = 64;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(31, 137);
            label8.Name = "label8";
            label8.Size = new Size(58, 21);
            label8.TabIndex = 63;
            label8.Text = "Job ID";
            // 
            // lblcustomerid
            // 
            lblcustomerid.AutoSize = true;
            lblcustomerid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcustomerid.ForeColor = Color.DarkRed;
            lblcustomerid.Location = new Point(166, 99);
            lblcustomerid.Name = "lblcustomerid";
            lblcustomerid.Size = new Size(0, 21);
            lblcustomerid.TabIndex = 61;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(31, 99);
            label9.Name = "label9";
            label9.Size = new Size(104, 21);
            label9.TabIndex = 62;
            label9.Text = "Customer ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 173);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 63;
            label2.Text = "Start Loaction";
            // 
            // lblstartlocation
            // 
            lblstartlocation.AutoSize = true;
            lblstartlocation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblstartlocation.ForeColor = Color.DarkRed;
            lblstartlocation.Location = new Point(167, 171);
            lblstartlocation.Name = "lblstartlocation";
            lblstartlocation.Size = new Size(0, 21);
            lblstartlocation.TabIndex = 64;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 211);
            label4.Name = "label4";
            label4.Size = new Size(99, 21);
            label4.TabIndex = 63;
            label4.Text = "Destination";
            // 
            // lbldestination
            // 
            lbldestination.AutoSize = true;
            lbldestination.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldestination.ForeColor = Color.DarkRed;
            lbldestination.Location = new Point(167, 209);
            lbldestination.Name = "lbldestination";
            lbldestination.Size = new Size(0, 21);
            lbldestination.TabIndex = 64;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 248);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 63;
            label3.Text = "Items";
            // 
            // txtitems
            // 
            txtitems.Location = new Point(31, 283);
            txtitems.Multiline = true;
            txtitems.Name = "txtitems";
            txtitems.ScrollBars = ScrollBars.Vertical;
            txtitems.Size = new Size(272, 217);
            txtitems.TabIndex = 70;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(344, 99);
            label5.Name = "label5";
            label5.Size = new Size(139, 21);
            label5.TabIndex = 62;
            label5.Text = "Load Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(340, 263);
            label6.Name = "label6";
            label6.Size = new Size(66, 21);
            label6.TabIndex = 63;
            label6.Text = "Weight";
            // 
            // txtloaditems
            // 
            txtloaditems.Location = new Point(344, 135);
            txtloaditems.Multiline = true;
            txtloaditems.Name = "txtloaditems";
            txtloaditems.ScrollBars = ScrollBars.Vertical;
            txtloaditems.Size = new Size(491, 108);
            txtloaditems.TabIndex = 70;
            // 
            // txtweight
            // 
            txtweight.Location = new Point(422, 260);
            txtweight.Multiline = true;
            txtweight.Name = "txtweight";
            txtweight.Size = new Size(152, 29);
            txtweight.TabIndex = 71;
            // 
            // dgvjobdetails
            // 
            dgvjobdetails.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvjobdetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvjobdetails.Location = new Point(336, 317);
            dgvjobdetails.Name = "dgvjobdetails";
            dgvjobdetails.Size = new Size(499, 108);
            dgvjobdetails.TabIndex = 72;
            dgvjobdetails.CellClick += dgvjobdetails_CellClick;
            // 
            // dgvcontainerdetails
            // 
            dgvcontainerdetails.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvcontainerdetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcontainerdetails.Location = new Point(336, 457);
            dgvcontainerdetails.Name = "dgvcontainerdetails";
            dgvcontainerdetails.Size = new Size(499, 108);
            dgvcontainerdetails.TabIndex = 72;
            dgvcontainerdetails.CellClick += dgvcontainerdetails_CellClick;
            // 
            // btnassign
            // 
            btnassign.BackColor = SystemColors.Highlight;
            btnassign.FlatStyle = FlatStyle.Popup;
            btnassign.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnassign.ForeColor = SystemColors.ActiveCaptionText;
            btnassign.Location = new Point(108, 527);
            btnassign.Name = "btnassign";
            btnassign.Size = new Size(87, 38);
            btnassign.TabIndex = 73;
            btnassign.Text = "Assign";
            btnassign.UseVisualStyleBackColor = false;
            btnassign.Click += btnassign_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(608, 263);
            label7.Name = "label7";
            label7.Size = new Size(106, 21);
            label7.TabIndex = 63;
            label7.Text = "Container ID";
            // 
            // lblcontainerid
            // 
            lblcontainerid.AutoSize = true;
            lblcontainerid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcontainerid.ForeColor = Color.DarkRed;
            lblcontainerid.Location = new Point(728, 263);
            lblcontainerid.Name = "lblcontainerid";
            lblcontainerid.Size = new Size(0, 21);
            lblcontainerid.TabIndex = 63;
            // 
            // AddLoad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(847, 588);
            Controls.Add(btnassign);
            Controls.Add(dgvcontainerdetails);
            Controls.Add(dgvjobdetails);
            Controls.Add(txtweight);
            Controls.Add(txtloaditems);
            Controls.Add(txtitems);
            Controls.Add(lbldestination);
            Controls.Add(lblstartlocation);
            Controls.Add(lbljobid);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(lblcontainerid);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(lblcustomerid);
            Controls.Add(label9);
            Controls.Add(lbladminname);
            Controls.Add(pcbuserlogo);
            Controls.Add(label1);
            Name = "AddLoad";
            Text = "AddLoad";
            Load += AddLoad_Load;
            ((System.ComponentModel.ISupportInitialize)pcbuserlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvjobdetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvcontainerdetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbladminname;
        private PictureBox pcbuserlogo;
        private Label label1;
        private Label lbljobid;
        private Label label8;
        private Label lblcustomerid;
        private Label label9;
        private Label label2;
        private Label lblstartlocation;
        private Label label4;
        private Label lbldestination;
        private Label label3;
        private TextBox txtitems;
        private Label label5;
        private Label label6;
        private TextBox txtloaditems;
        private TextBox txtweight;
        private DataGridView dgvjobdetails;
        private DataGridView dgvcontainerdetails;
        private Button btnassign;
        private Label label7;
        private Label lblcontainerid;
    }
}