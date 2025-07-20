namespace Shipping_System.Forms
{
    partial class Jobs
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
            pnlcreatejob = new Panel();
            pcbcreatejob = new PictureBox();
            label2 = new Label();
            pnlviewjob = new Panel();
            pcbviewjob = new PictureBox();
            label3 = new Label();
            pnljobstatus = new Panel();
            pcbjobstatus = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbuserlogo).BeginInit();
            pnlcreatejob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbcreatejob).BeginInit();
            pnlviewjob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbviewjob).BeginInit();
            pnljobstatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbjobstatus).BeginInit();
            SuspendLayout();
            // 
            // lblcustomername
            // 
            lblcustomername.AutoSize = true;
            lblcustomername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcustomername.Location = new Point(621, 27);
            lblcustomername.Name = "lblcustomername";
            lblcustomername.Size = new Size(0, 21);
            lblcustomername.TabIndex = 16;
            // 
            // pcbuserlogo
            // 
            pcbuserlogo.Location = new Point(549, 12);
            pcbuserlogo.Name = "pcbuserlogo";
            pcbuserlogo.Size = new Size(53, 52);
            pcbuserlogo.TabIndex = 15;
            pcbuserlogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 14;
            label1.Text = "About Jobs";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlcreatejob
            // 
            pnlcreatejob.BackColor = SystemColors.Highlight;
            pnlcreatejob.Controls.Add(pcbcreatejob);
            pnlcreatejob.Controls.Add(label2);
            pnlcreatejob.Location = new Point(62, 150);
            pnlcreatejob.Name = "pnlcreatejob";
            pnlcreatejob.Size = new Size(228, 210);
            pnlcreatejob.TabIndex = 17;
            pnlcreatejob.Click += pnlcreatejob_Click;
            // 
            // pcbcreatejob
            // 
            pcbcreatejob.BackgroundImageLayout = ImageLayout.Center;
            pcbcreatejob.Location = new Point(65, 26);
            pcbcreatejob.Name = "pcbcreatejob";
            pcbcreatejob.Size = new Size(96, 93);
            pcbcreatejob.TabIndex = 1;
            pcbcreatejob.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(43, 133);
            label2.Name = "label2";
            label2.Size = new Size(149, 60);
            label2.TabIndex = 0;
            label2.Text = "Create a New \r\n        Job";
            // 
            // pnlviewjob
            // 
            pnlviewjob.BackColor = SystemColors.Highlight;
            pnlviewjob.Controls.Add(pcbviewjob);
            pnlviewjob.Controls.Add(label3);
            pnlviewjob.Location = new Point(321, 150);
            pnlviewjob.Name = "pnlviewjob";
            pnlviewjob.Size = new Size(228, 210);
            pnlviewjob.TabIndex = 17;
            pnlviewjob.Click += pnlviewjob_Click;
            // 
            // pcbviewjob
            // 
            pcbviewjob.BackgroundImageLayout = ImageLayout.Center;
            pcbviewjob.Location = new Point(65, 26);
            pcbviewjob.Name = "pcbviewjob";
            pcbviewjob.Size = new Size(96, 93);
            pcbviewjob.TabIndex = 1;
            pcbviewjob.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(13, 133);
            label3.Name = "label3";
            label3.Size = new Size(204, 60);
            label3.TabIndex = 0;
            label3.Text = "View Your Ordered \r\n            Job";
            // 
            // pnljobstatus
            // 
            pnljobstatus.BackColor = SystemColors.Highlight;
            pnljobstatus.Controls.Add(pcbjobstatus);
            pnljobstatus.Controls.Add(label4);
            pnljobstatus.Location = new Point(578, 150);
            pnljobstatus.Name = "pnljobstatus";
            pnljobstatus.Size = new Size(228, 210);
            pnljobstatus.TabIndex = 17;
            // 
            // pcbjobstatus
            // 
            pcbjobstatus.BackgroundImageLayout = ImageLayout.Center;
            pcbjobstatus.Location = new Point(65, 26);
            pcbjobstatus.Name = "pcbjobstatus";
            pcbjobstatus.Size = new Size(96, 93);
            pcbjobstatus.TabIndex = 1;
            pcbjobstatus.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(39, 133);
            label4.Name = "label4";
            label4.Size = new Size(159, 60);
            label4.TabIndex = 0;
            label4.Text = "View Your Job \r\n       Status";
            // 
            // Jobs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(847, 498);
            Controls.Add(pnljobstatus);
            Controls.Add(pnlviewjob);
            Controls.Add(pnlcreatejob);
            Controls.Add(lblcustomername);
            Controls.Add(pcbuserlogo);
            Controls.Add(label1);
            Name = "Jobs";
            Text = "Jobs";
            Load += Jobs_Load;
            ((System.ComponentModel.ISupportInitialize)pcbuserlogo).EndInit();
            pnlcreatejob.ResumeLayout(false);
            pnlcreatejob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbcreatejob).EndInit();
            pnlviewjob.ResumeLayout(false);
            pnlviewjob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbviewjob).EndInit();
            pnljobstatus.ResumeLayout(false);
            pnljobstatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbjobstatus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcustomername;
        private PictureBox pcbuserlogo;
        private Label label1;
        private Panel pnlcreatejob;
        private PictureBox pcbcreatejob;
        private Label label2;
        private Panel pnlviewjob;
        private PictureBox pcbviewjob;
        private Label label3;
        private Panel pnljobstatus;
        private PictureBox pcbjobstatus;
        private Label label4;
    }
}