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
using static Shipping_System.Forms.AdminLogin;

namespace Shipping_System.Forms
{
    public partial class RegisteredCustomers : Form
    {
        public RegisteredCustomers()
        {
            InitializeComponent();
        }
        private void LoadImage() // Method to load the image into the PictureBox
        {
            string imagepath = @"Images\userprofile.png";
            pcbuserlogo.Image = Image.FromFile(imagepath);
            pcbuserlogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void LoadCustomerData() // Method to load customer data into the DataGridView
        {
            ICustomerRepository customerRepository = new CustomerRepository();
            List<CustomerModel> customers = customerRepository.GetAllCustomers();
            if (customers != null && customers.Count > 0)
            {
                dgvcustomerdetails.DataSource = customers;

            }
            else
            {
                MessageBox.Show("No registered customers found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearFields() // Method to clear all input fields
        {
            txtfirstname.Clear();
            txtlastname.Clear();
            txtemail.Clear();
            txtaddress.Clear();
            txtconno.Clear();
            txtpassword.Clear();
            lblid.Text = string.Empty;
        }

        private void RegisteredCustomers_Load(object sender, EventArgs e)
        {
            LoadImage();
            LoadCustomerData();
            lblcustomername.Text = Session.email;
        }

        private void dgvcustomerdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvcustomerdetails.Rows[e.RowIndex];
                lblid.Text = row.Cells["CustomerId"].Value.ToString();
                txtfirstname.Text = row.Cells["FirstName"].Value.ToString();
                txtlastname.Text = row.Cells["LastName"].Value.ToString();
                txtemail.Text = row.Cells["Email"].Value.ToString();
                txtaddress.Text = row.Cells["Address"].Value.ToString();
                txtconno.Text = row.Cells["Phonenumber"].Value.ToString();
                txtpassword.Text = row.Cells["Password"].Value.ToString();
            }
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

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValidEmail = IsValidEmail(txtemail.Text); // Validate email format
                if (!isValidEmail)
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
                if (!string.IsNullOrWhiteSpace(txtfirstname.Text) &&
                   !string.IsNullOrWhiteSpace(txtlastname.Text) &&
                   !string.IsNullOrWhiteSpace(txtemail.Text) &&
                   !string.IsNullOrWhiteSpace(txtaddress.Text) &&
                   !string.IsNullOrWhiteSpace(txtconno.Text) &&
                   !string.IsNullOrWhiteSpace(txtpassword.Text) && isValidEmail && isValidPhone)
                {
                    var customer = new CustomerModel
                    {
                        CustomerId = Convert.ToInt32(lblid.Text),
                        Firstname = txtfirstname.Text,
                        Lastname = txtlastname.Text,
                        Email = txtemail.Text,
                        Address = txtaddress.Text,
                        Phonenumber = txtconno.Text,
                        Password = txtpassword.Text
                    };
                    ICustomerRepository customerRepository = new CustomerRepository();
                    customerRepository.UpdateCustomer(customer);
                    MessageBox.Show("Customer details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadCustomerData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating customer details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
