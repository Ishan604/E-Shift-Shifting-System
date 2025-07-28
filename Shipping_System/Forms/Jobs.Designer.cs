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
            lblcustomername.Location = new Point(662, 36);
            lblcustomername.Name = "lblcustomername";
            lblcustomername.Size = new Size(0, 28);
            lblcustomername.TabIndex = 16;
            // 
            // pcbuserlogo
            // 
            pcbuserlogo.Location = new Point(579, 16);
            pcbuserlogo.Margin = new Padding(3, 4, 3, 4);
            pcbuserlogo.Name = "pcbuserlogo";
            pcbuserlogo.Size = new Size(61, 69);
            pcbuserlogo.TabIndex = 15;
            pcbuserlogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 27);
            label1.Name = "label1";
            label1.Size = new Size(177, 41);
            label1.TabIndex = 14;
            label1.Text = "About Jobs";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlcreatejob
            // 
            pnlcreatejob.BackColor = SystemColors.Highlight;
            pnlcreatejob.Controls.Add(pcbcreatejob);
            pnlcreatejob.Controls.Add(label2);
            pnlcreatejob.Location = new Point(71, 200);
            pnlcreatejob.Margin = new Padding(3, 4, 3, 4);
            pnlcreatejob.Name = "pnlcreatejob";
            pnlcreatejob.Size = new Size(261, 280);
            pnlcreatejob.TabIndex = 17;
            pnlcreatejob.Click += pnlcreatejob_Click;
            // 
            // pcbcreatejob
            // 
            pcbcreatejob.BackgroundImageLayout = ImageLayout.Center;
            pcbcreatejob.Location = new Point(74, 35);
            pcbcreatejob.Margin = new Padding(3, 4, 3, 4);
            pcbcreatejob.Name = "pcbcreatejob";
            pcbcreatejob.Size = new Size(110, 124);
            pcbcreatejob.TabIndex = 1;
            pcbcreatejob.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(49, 177);
            label2.Name = "label2";
            label2.Size = new Size(195, 74);
            label2.TabIndex = 0;
            label2.Text = "Create a New \r\n        Job";
            // 
            // pnlviewjob
            // 
            pnlviewjob.BackColor = SystemColors.Highlight;
            pnlviewjob.Controls.Add(pcbviewjob);
            pnlviewjob.Controls.Add(label3);
            pnlviewjob.Location = new Point(367, 200);
            pnlviewjob.Margin = new Padding(3, 4, 3, 4);
            pnlviewjob.Name = "pnlviewjob";
            pnlviewjob.Size = new Size(261, 280);
            pnlviewjob.TabIndex = 17;
            pnlviewjob.Click += pnlviewjob_Click;
            // 
            // pcbviewjob
            // 
            pcbviewjob.BackgroundImageLayout = ImageLayout.Center;
            pcbviewjob.Location = new Point(74, 35);
            pcbviewjob.Margin = new Padding(3, 4, 3, 4);
            pcbviewjob.Name = "pcbviewjob";
            pcbviewjob.Size = new Size(110, 124);
            pcbviewjob.TabIndex = 1;
            pcbviewjob.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(4, 177);
            label3.Name = "label3";
            label3.Size = new Size(265, 74);
            label3.TabIndex = 0;
            label3.Text = "View Your Ordered \r\n            Job";
            // 
            // pnljobstatus
            // 
            pnljobstatus.BackColor = SystemColors.Highlight;
            pnljobstatus.Controls.Add(pcbjobstatus);
            pnljobstatus.Controls.Add(label4);
            pnljobstatus.Location = new Point(661, 200);
            pnljobstatus.Margin = new Padding(3, 4, 3, 4);
            pnljobstatus.Name = "pnljobstatus";
            pnljobstatus.Size = new Size(261, 280);
            pnljobstatus.TabIndex = 17;
            pnljobstatus.Click += pnljobstatus_Click;
            // 
            // pcbjobstatus
            // 
            pcbjobstatus.BackgroundImageLayout = ImageLayout.Center;
            pcbjobstatus.Location = new Point(74, 35);
            pcbjobstatus.Margin = new Padding(3, 4, 3, 4);
            pcbjobstatus.Name = "pcbjobstatus";
            pcbjobstatus.Size = new Size(110, 124);
            pcbjobstatus.TabIndex = 1;
            pcbjobstatus.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(45, 177);
            label4.Name = "label4";
            label4.Size = new Size(205, 74);
            label4.TabIndex = 0;
            label4.Text = "View Your Job \r\n       Status";
            // 
            // Jobs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(968, 664);
            Controls.Add(pnljobstatus);
            Controls.Add(pnlviewjob);
            Controls.Add(pnlcreatejob);
            Controls.Add(lblcustomername);
            Controls.Add(pcbuserlogo);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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