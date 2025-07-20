namespace Shipping_System.Forms
{
    partial class AssignTransportUnit
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
            lblloadid = new Label();
            label9 = new Label();
            lblcontainerid = new Label();
            label7 = new Label();
            txtloaditems = new TextBox();
            label6 = new Label();
            label5 = new Label();
            lblweight = new Label();
            lblunitid = new Label();
            label3 = new Label();
            dgvloaddetails = new DataGridView();
            dgvunitdetails = new DataGridView();
            btnassign = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbuserlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvloaddetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvunitdetails).BeginInit();
            SuspendLayout();
            // 
            // lbladminname
            // 
            lbladminname.AutoSize = true;
            lbladminname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbladminname.Location = new Point(642, 49);
            lbladminname.Name = "lbladminname";
            lbladminname.Size = new Size(0, 28);
            lbladminname.TabIndex = 39;
            // 
            // pcbuserlogo
            // 
            pcbuserlogo.Location = new Point(560, 29);
            pcbuserlogo.Margin = new Padding(3, 4, 3, 4);
            pcbuserlogo.Name = "pcbuserlogo";
            pcbuserlogo.Size = new Size(61, 69);
            pcbuserlogo.TabIndex = 38;
            pcbuserlogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 40);
            label1.Name = "label1";
            label1.Size = new Size(362, 41);
            label1.TabIndex = 37;
            label1.Text = "Add Units For The Loads";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbljobid
            // 
            lbljobid.AutoSize = true;
            lbljobid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbljobid.ForeColor = Color.DarkRed;
            lbljobid.Location = new Point(199, 145);
            lbljobid.Name = "lbljobid";
            lbljobid.Size = new Size(0, 28);
            lbljobid.TabIndex = 68;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(45, 148);
            label8.Name = "label8";
            label8.Size = new Size(72, 28);
            label8.TabIndex = 67;
            label8.Text = "Job ID";
            // 
            // lblloadid
            // 
            lblloadid.AutoSize = true;
            lblloadid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblloadid.ForeColor = Color.DarkRed;
            lblloadid.Location = new Point(199, 203);
            lblloadid.Name = "lblloadid";
            lblloadid.Size = new Size(0, 28);
            lblloadid.TabIndex = 65;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(45, 203);
            label9.Name = "label9";
            label9.Size = new Size(84, 28);
            label9.TabIndex = 66;
            label9.Text = "Load ID";
            // 
            // lblcontainerid
            // 
            lblcontainerid.AutoSize = true;
            lblcontainerid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcontainerid.ForeColor = Color.DarkRed;
            lblcontainerid.Location = new Point(198, 259);
            lblcontainerid.Name = "lblcontainerid";
            lblcontainerid.Size = new Size(0, 28);
            lblcontainerid.TabIndex = 69;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(45, 259);
            label7.Name = "label7";
            label7.Size = new Size(131, 28);
            label7.TabIndex = 70;
            label7.Text = "Container ID";
            // 
            // txtloaditems
            // 
            txtloaditems.Location = new Point(313, 196);
            txtloaditems.Margin = new Padding(3, 4, 3, 4);
            txtloaditems.Multiline = true;
            txtloaditems.Name = "txtloaditems";
            txtloaditems.ScrollBars = ScrollBars.Vertical;
            txtloaditems.Size = new Size(561, 200);
            txtloaditems.TabIndex = 74;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(45, 315);
            label6.Name = "label6";
            label6.Size = new Size(80, 28);
            label6.TabIndex = 73;
            label6.Text = "Weight";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(313, 148);
            label5.Name = "label5";
            label5.Size = new Size(172, 28);
            label5.TabIndex = 72;
            label5.Text = "Load Description";
            // 
            // lblweight
            // 
            lblweight.AutoSize = true;
            lblweight.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblweight.ForeColor = Color.DarkRed;
            lblweight.Location = new Point(198, 315);
            lblweight.Name = "lblweight";
            lblweight.Size = new Size(0, 28);
            lblweight.TabIndex = 69;
            // 
            // lblunitid
            // 
            lblunitid.AutoSize = true;
            lblunitid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblunitid.ForeColor = Color.DarkRed;
            lblunitid.Location = new Point(198, 369);
            lblunitid.Name = "lblunitid";
            lblunitid.Size = new Size(0, 28);
            lblunitid.TabIndex = 69;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 369);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 73;
            label3.Text = "Unit ID";
            // 
            // dgvloaddetails
            // 
            dgvloaddetails.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvloaddetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvloaddetails.Location = new Point(45, 459);
            dgvloaddetails.Margin = new Padding(3, 4, 3, 4);
            dgvloaddetails.Name = "dgvloaddetails";
            dgvloaddetails.RowHeadersWidth = 51;
            dgvloaddetails.Size = new Size(355, 292);
            dgvloaddetails.TabIndex = 75;
            dgvloaddetails.CellClick += dgvloaddetails_CellClick;
            // 
            // dgvunitdetails
            // 
            dgvunitdetails.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvunitdetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvunitdetails.Location = new Point(446, 459);
            dgvunitdetails.Margin = new Padding(3, 4, 3, 4);
            dgvunitdetails.Name = "dgvunitdetails";
            dgvunitdetails.RowHeadersWidth = 51;
            dgvunitdetails.Size = new Size(373, 292);
            dgvunitdetails.TabIndex = 75;
            dgvunitdetails.CellClick += dgvunitdetails_CellClick;
            // 
            // btnassign
            // 
            btnassign.BackColor = SystemColors.Highlight;
            btnassign.FlatStyle = FlatStyle.Popup;
            btnassign.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnassign.ForeColor = SystemColors.ActiveCaptionText;
            btnassign.Location = new Point(856, 571);
            btnassign.Margin = new Padding(3, 4, 3, 4);
            btnassign.Name = "btnassign";
            btnassign.Size = new Size(99, 51);
            btnassign.TabIndex = 76;
            btnassign.Text = "Assign";
            btnassign.UseVisualStyleBackColor = false;
            btnassign.Click += btnassign_Click;
            // 
            // AssignTransportUnit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(968, 784);
            Controls.Add(btnassign);
            Controls.Add(dgvunitdetails);
            Controls.Add(dgvloaddetails);
            Controls.Add(txtloaditems);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(lblunitid);
            Controls.Add(label5);
            Controls.Add(lblweight);
            Controls.Add(lblcontainerid);
            Controls.Add(label7);
            Controls.Add(lbljobid);
            Controls.Add(label8);
            Controls.Add(lblloadid);
            Controls.Add(label9);
            Controls.Add(lbladminname);
            Controls.Add(pcbuserlogo);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AssignTransportUnit";
            Text = "AssignTransportUnit";
            Load += AssignTransportUnit_Load;
            ((System.ComponentModel.ISupportInitialize)pcbuserlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvloaddetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvunitdetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbladminname;
        private PictureBox pcbuserlogo;
        private Label label1;
        private Label lbljobid;
        private Label label8;
        private Label lblloadid;
        private Label label9;
        private Label lblcontainerid;
        private Label label7;
        private TextBox txtloaditems;
        private Label label6;
        private Label label5;
        private Label lblweight;
        private Label lblunitid;
        private Label label3;
        private DataGridView dgvloaddetails;
        private DataGridView dgvunitdetails;
        private Button btnassign;
    }
}