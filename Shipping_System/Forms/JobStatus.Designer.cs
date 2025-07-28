namespace Shipping_System.Forms
{
    partial class JobStatus
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
            label8 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblassignedid = new Label();
            lbljobid = new Label();
            lblunitid = new Label();
            lblloadid = new Label();
            lblcontainerid = new Label();
            label6 = new Label();
            txtitems = new TextBox();
            label7 = new Label();
            lblweight = new Label();
            dgvassignedjobdetails = new DataGridView();
            btnclear = new Button();
            btnback = new Button();
            lbldate = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbuserlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvassignedjobdetails).BeginInit();
            SuspendLayout();
            // 
            // lblcustomername
            // 
            lblcustomername.AutoSize = true;
            lblcustomername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcustomername.Location = new Point(633, 49);
            lblcustomername.Name = "lblcustomername";
            lblcustomername.Size = new Size(0, 28);
            lblcustomername.TabIndex = 42;
            // 
            // pcbuserlogo
            // 
            pcbuserlogo.Location = new Point(551, 29);
            pcbuserlogo.Margin = new Padding(3, 4, 3, 4);
            pcbuserlogo.Name = "pcbuserlogo";
            pcbuserlogo.Size = new Size(61, 69);
            pcbuserlogo.TabIndex = 41;
            pcbuserlogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 40);
            label1.Name = "label1";
            label1.Size = new Size(379, 41);
            label1.TabIndex = 40;
            label1.Text = "View Your Completed Job";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(44, 143);
            label8.Name = "label8";
            label8.Size = new Size(124, 28);
            label8.TabIndex = 43;
            label8.Text = "Assigned ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 194);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 43;
            label2.Text = "Job ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 243);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 43;
            label3.Text = "Unit ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 292);
            label4.Name = "label4";
            label4.Size = new Size(84, 28);
            label4.TabIndex = 43;
            label4.Text = "Load ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 341);
            label5.Name = "label5";
            label5.Size = new Size(131, 28);
            label5.TabIndex = 43;
            label5.Text = "Container ID";
            // 
            // lblassignedid
            // 
            lblassignedid.AutoSize = true;
            lblassignedid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblassignedid.ForeColor = Color.DarkRed;
            lblassignedid.Location = new Point(218, 143);
            lblassignedid.Name = "lblassignedid";
            lblassignedid.Size = new Size(0, 28);
            lblassignedid.TabIndex = 43;
            // 
            // lbljobid
            // 
            lbljobid.AutoSize = true;
            lbljobid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbljobid.ForeColor = Color.DarkRed;
            lbljobid.Location = new Point(218, 194);
            lbljobid.Name = "lbljobid";
            lbljobid.Size = new Size(0, 28);
            lbljobid.TabIndex = 43;
            // 
            // lblunitid
            // 
            lblunitid.AutoSize = true;
            lblunitid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblunitid.ForeColor = Color.DarkRed;
            lblunitid.Location = new Point(218, 243);
            lblunitid.Name = "lblunitid";
            lblunitid.Size = new Size(0, 28);
            lblunitid.TabIndex = 43;
            // 
            // lblloadid
            // 
            lblloadid.AutoSize = true;
            lblloadid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblloadid.ForeColor = Color.DarkRed;
            lblloadid.Location = new Point(218, 292);
            lblloadid.Name = "lblloadid";
            lblloadid.Size = new Size(0, 28);
            lblloadid.TabIndex = 43;
            // 
            // lblcontainerid
            // 
            lblcontainerid.AutoSize = true;
            lblcontainerid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcontainerid.ForeColor = Color.DarkRed;
            lblcontainerid.Location = new Point(218, 341);
            lblcontainerid.Name = "lblcontainerid";
            lblcontainerid.Size = new Size(0, 28);
            lblcontainerid.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(429, 143);
            label6.Name = "label6";
            label6.Size = new Size(172, 28);
            label6.TabIndex = 43;
            label6.Text = "Load Description";
            // 
            // txtitems
            // 
            txtitems.Location = new Point(429, 185);
            txtitems.Margin = new Padding(3, 4, 3, 4);
            txtitems.Multiline = true;
            txtitems.Name = "txtitems";
            txtitems.Size = new Size(497, 249);
            txtitems.TabIndex = 45;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(44, 391);
            label7.Name = "label7";
            label7.Size = new Size(80, 28);
            label7.TabIndex = 43;
            label7.Text = "Weight";
            // 
            // lblweight
            // 
            lblweight.AutoSize = true;
            lblweight.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblweight.ForeColor = Color.DarkRed;
            lblweight.Location = new Point(218, 391);
            lblweight.Name = "lblweight";
            lblweight.Size = new Size(0, 28);
            lblweight.TabIndex = 43;
            // 
            // dgvassignedjobdetails
            // 
            dgvassignedjobdetails.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvassignedjobdetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvassignedjobdetails.Location = new Point(46, 479);
            dgvassignedjobdetails.Margin = new Padding(3, 4, 3, 4);
            dgvassignedjobdetails.Name = "dgvassignedjobdetails";
            dgvassignedjobdetails.RowHeadersWidth = 51;
            dgvassignedjobdetails.Size = new Size(623, 214);
            dgvassignedjobdetails.TabIndex = 76;
            dgvassignedjobdetails.CellClick += dgvassignedjobdetails_CellClick;
            // 
            // btnclear
            // 
            btnclear.BackColor = SystemColors.Highlight;
            btnclear.FlatStyle = FlatStyle.Popup;
            btnclear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnclear.ForeColor = SystemColors.ActiveCaptionText;
            btnclear.Location = new Point(745, 517);
            btnclear.Margin = new Padding(3, 4, 3, 4);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(119, 51);
            btnclear.TabIndex = 77;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            // 
            // btnback
            // 
            btnback.BackColor = SystemColors.Highlight;
            btnback.FlatStyle = FlatStyle.Popup;
            btnback.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnback.ForeColor = SystemColors.ActiveCaptionText;
            btnback.Location = new Point(745, 594);
            btnback.Margin = new Padding(3, 4, 3, 4);
            btnback.Name = "btnback";
            btnback.Size = new Size(119, 51);
            btnback.TabIndex = 77;
            btnback.Text = "<<Back";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // lbldate
            // 
            lbldate.AutoSize = true;
            lbldate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldate.ForeColor = Color.DarkRed;
            lbldate.Location = new Point(684, 143);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(72, 28);
            lbldate.TabIndex = 43;
            lbldate.Text = "Job ID";
            // 
            // JobStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(968, 721);
            Controls.Add(btnback);
            Controls.Add(btnclear);
            Controls.Add(dgvassignedjobdetails);
            Controls.Add(txtitems);
            Controls.Add(lbldate);
            Controls.Add(lblweight);
            Controls.Add(lblcontainerid);
            Controls.Add(lblloadid);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(lblunitid);
            Controls.Add(label4);
            Controls.Add(lbljobid);
            Controls.Add(label3);
            Controls.Add(lblassignedid);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(lblcustomername);
            Controls.Add(pcbuserlogo);
            Controls.Add(label1);
            Name = "JobStatus";
            Text = "JobStatus";
            Load += JobStatus_Load;
            ((System.ComponentModel.ISupportInitialize)pcbuserlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvassignedjobdetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcustomername;
        private PictureBox pcbuserlogo;
        private Label label1;
        private Label label8;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblassignedid;
        private Label lbljobid;
        private Label lblunitid;
        private Label lblloadid;
        private Label lblcontainerid;
        private Label label6;
        private TextBox txtitems;
        private Label label7;
        private Label lblweight;
        private DataGridView dgvassignedjobdetails;
        private Button btnclear;
        private Button btnback;
        private Label lbldate;
    }
}