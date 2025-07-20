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
    public partial class AdminDetails : Form
    {
        public AdminDetails(string email, int id)
        {
            InitializeComponent();
        }
        private void LoadImage() // Method to load the image into the PictureBox
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
            txtpassword.Clear();
            lblid.Text = string.Empty;
        }

        public void DisplayAdminDetails(int adminid)
        {
            IAdminRepository adminRepository = new AdminRepository();
            var adminDetails = adminRepository.GetAdminDetails(adminid);
            if (adminDetails != null && adminDetails.Count > 0)
            {
                dgvadmindetails.DataSource = adminDetails;
            }
            else
            {
                MessageBox.Show("No details found for the given Admin ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminDetails_Load(object sender, EventArgs e)
        {
            LoadImage();
            lbladminname.Text = Session.email; // Display the admin's email in the label
            DisplayAdminDetails(Session.id); // Load admin details based on the session ID

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvadmindetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvadmindetails.Rows[e.RowIndex];
                lblid.Text = row.Cells["Id"].Value.ToString();
                txtfirstname.Text = row.Cells["Firstname"].Value.ToString();
                txtlastname.Text = row.Cells["Lastname"].Value.ToString();
                txtemail.Text = row.Cells["Email"].Value.ToString();
                txtconno.Text = row.Cells["Phonenumber"].Value.ToString();
                txtpassword.Text = row.Cells["Password"].Value.ToString();
            }
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

                if(!string.IsNullOrWhiteSpace(txtfirstname.Text) &&
                   !string.IsNullOrWhiteSpace(txtlastname.Text) &&
                   !string.IsNullOrWhiteSpace(txtemail.Text) &&
                   !string.IsNullOrWhiteSpace(txtconno.Text) &&
                   !string.IsNullOrWhiteSpace(txtpassword.Text) && isValidEmail && isValidPhone)
                {
                    IAdminRepository adminRepository = new AdminRepository();
                    AdminModel admin = new AdminModel
                    {
                        Id = Convert.ToInt32(lblid.Text),
                        Firstname = txtfirstname.Text,
                        Lastname = txtlastname.Text,
                        Email = txtemail.Text,
                        Phonenumber = txtconno.Text,
                        Password = txtpassword.Text
                    };
                    adminRepository.UpdateAdminDetails(admin);
                    MessageBox.Show("Admin details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields(); 
                    DisplayAdminDetails(Session.id); 
                }
                else
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
