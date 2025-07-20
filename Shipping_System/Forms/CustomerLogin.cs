using Shipping_System.Models;
using Shipping_System.Repository.Interface;
using Shipping_System.Repository.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shipping_System.Forms
{
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
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

        private void CustomerLogin_Load(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void linksignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerRegistration customerRegistration = new CustomerRegistration();
            customerRegistration.Show();
            this.Hide();
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

        public static class Session
        {
            public static string email { get; set; } // Static property to hold the email in session
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox[] textboxes = { txtcusmail, txtcuspassword }; // Array of textboxes to validate
                bool isValid = ValidateTextBox(textboxes); // Validate textboxes

                bool isValidEmail = IsValidEmail(txtcusmail.Text); // Validate email format
                if (!isValidEmail)
                {
                    MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isValid && isValidEmail) // Proceed only if all validations are successful
                {
                    var customer = new CustomerModel(); // Create a new customer model
                    customer.Email = txtcusmail.Text;
                    customer.Password = txtcuspassword.Text;

                    ICustomerRepository customerRepository = new CustomerRepository(); // Create an instance of the customer repository
                    customerRepository.LoginCustomer(customer);

                    Session.email = txtcusmail.Text; // Store the email in session

                    CustomerDashboard customerDashboard = new CustomerDashboard(); 
                    CustomerDetails customerDetails = new CustomerDetails(Session.email); // Load customer details using the email from session
                    customerDashboard.Show(); 
                    this.Hide(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtcuspassword.Clear();
            txtcusmail.Clear(); 
            txtcusmail.BackColor = SystemColors.Window; 
            txtcuspassword.BackColor = SystemColors.Window;
        }
    }
}
