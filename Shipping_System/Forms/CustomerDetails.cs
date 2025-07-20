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
using static Shipping_System.Forms.CustomerLogin;

namespace Shipping_System.Forms
{
    public partial class CustomerDetails : Form
    {
        public CustomerDetails(string email)
        {
            InitializeComponent();
        }

        private void LoadImage()
        {
            string imagepath = @"Images\userprofile.png";
            pcbuserlogo.Image = Image.FromFile(imagepath);
            pcbuserlogo.SizeMode = PictureBoxSizeMode.StretchImage;
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

        private void ClearFields() // Method to clear all input fields
        {
            txtfirstname.Clear();
            txtlastname.Clear();
            txtemail.Clear();
            txtconno.Clear();
            txtaddress.Clear();
            txtpassword.Clear();
            lblid.Text = string.Empty;
        }

        private void LoadDetails() //Method to load customer details
        {
            ICustomerRepository repository = new CustomerRepository();
            List<CustomerModel> customerDetails = repository.GetLoggedInCustomerDetails(Session.email);
            if (customerDetails.Count > 0)
            {
                dgvcustomerdetails.DataSource = customerDetails;
            }
            else
            {
                MessageBox.Show("No customer details found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUpdatedCustomerDetails(int customerId) // Method to get updated customer's details
        {
            ICustomerRepository repository = new CustomerRepository();
            List<CustomerModel> customers = repository.GetUpdatedCustomerDetails(customerId);
            if(customers.Count > 0)
            {
                dgvcustomerdetails.DataSource = customers;
            }
            else
            {
                MessageBox.Show("No customer details found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            LoadImage();
            LoadDetails();
            lblcustomername.Text = Session.email; // Display the logged-in customer's email
        }

        private void dgvcustomerdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvcustomerdetails.Rows[e.RowIndex];
                lblid.Text = row.Cells["CustomerId"].Value.ToString();
                txtfirstname.Text = row.Cells["Firstname"].Value.ToString();
                txtlastname.Text = row.Cells["Lastname"].Value.ToString();
                txtemail.Text = row.Cells["Email"].Value.ToString();
                txtconno.Text = row.Cells["Phonenumber"].Value.ToString();
                txtaddress.Text = row.Cells["Address"].Value.ToString();
                txtpassword.Text = row.Cells["Password"].Value.ToString();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearFields();
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
                if(isValidEmail &&  isValidPhone &&
                    !string.IsNullOrWhiteSpace(txtemail.Text) &&
                    !string.IsNullOrWhiteSpace(txtaddress.Text) &&
                    !string.IsNullOrWhiteSpace(txtconno.Text) &&
                    !string.IsNullOrWhiteSpace(txtpassword.Text) &&
                    !string.IsNullOrWhiteSpace(txtfirstname.Text) &&
                    !string.IsNullOrWhiteSpace(txtlastname.Text))
                {
                    var customer = new CustomerModel();
                    customer.CustomerId = Convert.ToInt32(lblid.Text);
                    customer.Email = txtemail.Text;
                    customer.Address = txtaddress.Text;
                    customer.Phonenumber = txtconno.Text;
                    customer.Password = txtpassword.Text;
                    customer.Firstname = txtfirstname.Text;
                    customer.Lastname = txtlastname.Text;

                    ICustomerRepository customerRepository = new CustomerRepository();
                    customerRepository.UpdateCustomer(customer);
                    MessageBox.Show("Successfully updated the student", "Student!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Store the current customer ID before clearing fields
                    int customerId = Convert.ToInt32(lblid.Text);
                    ClearFields();
                    LoadUpdatedCustomerDetails(customerId);
                }
                else
                {
                    MessageBox.Show("Please fill in all fields with valid data.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
