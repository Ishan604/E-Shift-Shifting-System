using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Shipping_System.Forms.CustomerLogin;

namespace Shipping_System.Forms
{
    public partial class CustomerDashboard : Form
    {
        private Form activeform;
        public CustomerDashboard()
        {
            InitializeComponent();

            //set the icon from the image file into the form icon
            string iconpath = Path.Combine(Application.StartupPath, "Images", "logo_icon.ico");
            this.Icon = new Icon(iconpath);
        }

        private void LoadImage()
        {
            string imagepath = @"Images\logo.png";
            pcblogo.Image = Image.FromFile(imagepath);
            pcblogo.SizeMode = PictureBoxSizeMode.StretchImage;
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
        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void btnjobs_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnjobs);
            Jobs jobsForm = new Jobs(this); // Pass the current dashboard instance to Jobs
            OpenChildForm(jobsForm, btnjobs);
        }

        private void btnpersonalinfo_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnpersonalinfo);
            OpenChildForm(new CustomerDetails(Session.email), btnpersonalinfo);
        }

        private void btnstatus_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnstatus);
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnsettings);
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnlogout);
        }

        private void paneldesktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
