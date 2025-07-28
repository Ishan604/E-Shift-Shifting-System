using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Shipping_System.Forms.AdminLogin;

namespace Shipping_System.Forms
{
    public partial class AdminDashboard : Form
    {
        private Form activeform;
        public AdminDashboard()
        {
            InitializeComponent();

            //set the icon from the image file into the form icon
            string iconpath = Path.Combine(Application.StartupPath, "Images", "logo_icon.ico");
            this.Icon = new Icon(iconpath);
        }
        public void SetActiveButton(Button activebutton) //method to highlight an active button 
        {
            // Reset all buttons to default style
            foreach (Control control in panelnavigation.Controls)
            {
                if (control is Button button)
                {
                    button.FlatStyle = FlatStyle.Flat;
                    button.BackColor = Color.FromArgb(64, 64, 64);
                    button.FlatAppearance.BorderSize = 0;
                }
            }
            activebutton.BackColor = Color.Teal;
        }
        private void OpenChildForm(Form childform, Button button) // Method to open a child form in the panel
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            SetActiveButton(button);
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.paneldesktop.Controls.Add(childform);
            this.paneldesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        public void OpenChildFormInPanel(Form childForm) // Method to open a child form in the paneldesktop
        {
            paneldesktop.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            paneldesktop.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void LoadImage() // Method to load the image into the PictureBox
        {
            string imagepath = @"Images\logo.png";
            pcblogo.Image = Image.FromFile(imagepath);
            pcblogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void btnpersonalinfo_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnpersonalinfo);
            OpenChildForm(new AdminDetails(Session.email, Session.id), btnpersonalinfo);
        }

        private void btnregcustomers_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnregcustomers);
            OpenChildForm(new RegisteredCustomers(), btnregcustomers);
        }

        private void btnjobrequests_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnjobrequests);
            OpenChildForm(new JobRequests(this), btnjobrequests);
        }

        private void btnjobstatus_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnjobstatus);
            OpenChildForm(new Reports(this), btnjobstatus);
        }

        private void btntransportunit_Click(object sender, EventArgs e)
        {
            SetActiveButton(btntransportunit);
            OpenChildForm(new AssignTransportUnit(), btntransportunit);
        }

        private void btnassignedloads_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnassignedloads);
            OpenChildForm(new AddLoad(), btnassignedloads);
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnlogout);
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close(); // Close the current form
                MainInterface mainInterface = new MainInterface();
                mainInterface.Show();
            }
        }
    }
}
