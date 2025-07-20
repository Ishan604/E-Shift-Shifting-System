namespace Shipping_System.Forms
{
    partial class MainInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInterface));
            label1 = new Label();
            panelcustomer = new Panel();
            pcbcutomer = new PictureBox();
            label2 = new Label();
            paneladmin = new Panel();
            pcbadmin = new PictureBox();
            label3 = new Label();
            panelcustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbcutomer).BeginInit();
            paneladmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbadmin).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 23);
            label1.Name = "label1";
            label1.Size = new Size(330, 80);
            label1.TabIndex = 0;
            label1.Text = "      Welcome to the \r\nE-Shift Shifting System";
            // 
            // panelcustomer
            // 
            panelcustomer.BackColor = SystemColors.Highlight;
            panelcustomer.Controls.Add(pcbcutomer);
            panelcustomer.Controls.Add(label2);
            panelcustomer.Location = new Point(134, 152);
            panelcustomer.Name = "panelcustomer";
            panelcustomer.Size = new Size(228, 210);
            panelcustomer.TabIndex = 1;
            panelcustomer.Click += panelcustomer_Click;
            // 
            // pcbcutomer
            // 
            pcbcutomer.BackgroundImageLayout = ImageLayout.Center;
            pcbcutomer.Location = new Point(65, 26);
            pcbcutomer.Name = "pcbcutomer";
            pcbcutomer.Size = new Size(96, 93);
            pcbcutomer.TabIndex = 1;
            pcbcutomer.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(22, 133);
            label2.Name = "label2";
            label2.Size = new Size(183, 60);
            label2.TabIndex = 0;
            label2.Text = "For the Customer\r\n         Login";
            // 
            // paneladmin
            // 
            paneladmin.BackColor = SystemColors.Highlight;
            paneladmin.Controls.Add(pcbadmin);
            paneladmin.Controls.Add(label3);
            paneladmin.Location = new Point(438, 152);
            paneladmin.Name = "paneladmin";
            paneladmin.Size = new Size(228, 210);
            paneladmin.TabIndex = 1;
            paneladmin.Click += paneladmin_Click;
            // 
            // pcbadmin
            // 
            pcbadmin.BackgroundImageLayout = ImageLayout.Center;
            pcbadmin.Location = new Point(68, 26);
            pcbadmin.Name = "pcbadmin";
            pcbadmin.Size = new Size(96, 93);
            pcbadmin.TabIndex = 1;
            pcbadmin.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(39, 133);
            label3.Name = "label3";
            label3.Size = new Size(155, 60);
            label3.TabIndex = 0;
            label3.Text = "For the Admin\r\n       Login";
            // 
            // MainInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(paneladmin);
            Controls.Add(panelcustomer);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainInterface";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome!";
            Load += MainInterface_Load;
            panelcustomer.ResumeLayout(false);
            panelcustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbcutomer).EndInit();
            paneladmin.ResumeLayout(false);
            paneladmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbadmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panelcustomer;
        private Label label2;
        private PictureBox pcbcutomer;
        private Panel paneladmin;
        private PictureBox pcbadmin;
        private Label label3;
    }
}