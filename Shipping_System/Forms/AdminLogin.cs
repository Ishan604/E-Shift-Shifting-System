using Shipping_System.Models;
using Shipping_System.Repository.Interface;
using Shipping_System.Repository.Service;
using Shipping_System.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shipping_System.Forms
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();

            //set the icon from the image file into the form icon
            string iconpath = Path.Combine(Application.StartupPath, "Images", "logo_icon.ico");
            this.Icon = new Icon(iconpath);
        }
        private void LoadImage()
        {
            try
            {
                string imagepath = @"Images\logo.png";
                pcblogo.Image = Image.FromFile(imagepath);
                pcblogo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }
        private void AdminLogin_Load(object sender, EventArgs e)
        {
            LoadImage();
        }

        private bool ValidateTextBox(TextBox[] textboxes) // Method to validate textboxes
        {
            bool isValid = true; // Flag to check if all textboxes are valid
            foreach (var textbox in textboxes)
            {
                if (string.IsNullOrWhiteSpace(textbox.Text))
                {
                    isValid = false;
                    textbox.BackColor = Color.Red; // Highlight empty fields
                }
                else
                {
                    textbox.BackColor = SystemColors.Window; // Reset background color
                }
            }
            if (!isValid)
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return isValid; // Return true if all textboxes are filled
        }

        private bool IsValidEmail(string email) // Method to validate email format
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return mailAddress.Address == email;
            }
            catch
            {
                return false;
            }
            if (false)
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static class Session // Static class to hold session data
        {
            public static string email { get; set; } // Static property to hold the email in session
            public static int id { get; set; } // Static property to hold the admin ID in session
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            AdminModel admin = new AdminModel();
            admin.Email = txtadminmail.Text;
            admin.Password = txtadminpassword.Text;
            admin.Id = Convert.ToInt32(txtadminid.Text);

            TextBox[] textboxes = { txtadminmail, txtadminpassword, txtadminid }; // Array of textboxes to validate
            bool isValid = ValidateTextBox(textboxes); // Validate textboxes
            bool isValidEmail = IsValidEmail(txtadminmail.Text); // Validate email format
            if(!isValidEmail && isValid)
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtadminmail.Clear();
            }
            else
            {
                IAdminRepository adminRepository = new AdminRepository();
                adminRepository.LoginAdmin(admin);

                Session.email = admin.Email; // Store the email in session
                Session.id = admin.Id; // Store the admin ID in session

                AdminDashboard adminDashboard = new AdminDashboard();
                AdminDetails adminDetails = new AdminDetails(Session.email, Session.id);
                adminDashboard.Show();
                this.Hide(); 

            }
        }
    }
}
