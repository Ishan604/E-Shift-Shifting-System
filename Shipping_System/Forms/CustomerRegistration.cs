using Shipping_System.Models;
using Shipping_System.Repository.Interface;
using Shipping_System.Repository.Service;
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
    public partial class CustomerRegistration : Form
    {
        public CustomerRegistration()
        {
            InitializeComponent();

            //set the icon from the image file into the form icon
            string iconpath = Path.Combine(Application.StartupPath, "Images", "logo_icon.ico");
            this.Icon = new Icon(iconpath);
        }

        private void ClearData() //Method for clear all the fields
        {
            txtaddress.Clear();
            txtpassword.Clear();
            txtconfpassword.Clear();
            txtconno.Clear();
            txtfirstname.Clear();
            txtlastname.Clear();
            txtemail.Clear();
        }

        private void LoadImage() //Method for load the image into the picture box
        {
            string imagepath = @"Images\customer.png";
            pcbcuser.Image = Image.FromFile(imagepath);
            pcbcuser.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void CustomerRegistration_Load(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            CustomerLogin customerLogin = new CustomerLogin();
            customerLogin.Show();
            this.Hide();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearData();
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
        }
        private bool IsValidPhoneNumber(string phoneNumber) // Method to validate phone number format
        {
            //check if the phone number is numeric and has 10 digits
            return phoneNumber.All(char.IsDigit) && phoneNumber.Length == 10;
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            try
            {

                TextBox[] textboxes = { txtfirstname, txtlastname, txtemail, txtconno, txtaddress, txtpassword, txtconfpassword };
                bool isAllOkay = ValidateTextBox(textboxes);

                bool isValidEmail = IsValidEmail(txtemail.Text); // Validate email format
                if(!isValidEmail)
                {
                    MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtemail.Clear(); 
                }

                bool isValidPhone = IsValidPhoneNumber(txtconno.Text); // Validate phone number format
                if (!isValidPhone)
                {
                    MessageBox.Show("Please enter a valid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtconno.Clear();
                }

                bool isPasswordMatch = txtpassword.Text == txtconfpassword.Text; // Check if password and confirm password match
                if (!isPasswordMatch)
                {
                    MessageBox.Show("Password and Confirm Password do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAllOkay && isPasswordMatch && isValidEmail && isValidPhone)
                {
                    var customer = new CustomerModel();
                    customer.Firstname = txtfirstname.Text;
                    customer.Lastname = txtlastname.Text;
                    customer.Email = txtemail.Text;
                    customer.Phonenumber = txtconno.Text;
                    customer.Address = txtaddress.Text;
                    customer.Password = txtconfpassword.Text;

                    ICustomerRepository customerRepository = new CustomerRepository(); 
                    customerRepository.AddCustomer(customer); 
                    MessageBox.Show("Customer registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData(); 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }  
    }
}
