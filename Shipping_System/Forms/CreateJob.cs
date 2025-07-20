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
using static Shipping_System.Forms.CustomerLogin;

namespace Shipping_System.Forms
{
    public partial class CreateJob : Form
    {
        private CustomerDashboard _dashboard; // Reference to the CustomerDashboard to open child forms
        public CreateJob(CustomerDashboard dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;
        }
        private void LoadImage() // Method to load the user profile image into the PictureBox
        {
            string imagepath = @"Images\userprofile.png";
            pcbuserlogo.Image = Image.FromFile(imagepath);
            pcbuserlogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void CreateJob_Load(object sender, EventArgs e)
        {
            LoadImage();
            lblcustomername.Text = Session.email; // Display the logged-in customer's email

            ICustomerRepository customerRepository = new CustomerRepository();
            int customerid = customerRepository.GetCustomerIdByEmail(Session.email);
            lblid.Text = customerid.ToString(); // Display the customer ID
        }

        private void ClearFields() // Method to clear all input fields
        {
            txtname.Clear();
            txtstartloc.Clear();
            txtdestination.Clear();
            txtemail.Clear();
            txtconno.Clear();
            txtitems.Clear();
            lblid.Text = string.Empty;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            JobsModel jobs = new JobsModel();
            jobs.fullName = txtname.Text;
            jobs.startLocation = txtstartloc.Text;
            jobs.destination = txtdestination.Text;
            jobs.email = txtemail.Text;
            jobs.phoneNumber = txtconno.Text;
            jobs.itemDescription = txtitems.Text;

            var validator = new JobsModelValidator();
            var validationResult = validator.Validate(jobs);

            if (validationResult.IsValid)
            {
                IJobsRepository jobsRepository = new JobsRepository();
                try
                {
                    jobsRepository.AddJob(jobs);
                    MessageBox.Show("Job created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while adding the data!" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage); // Collect all error messages
                string errorMessage = string.Join(Environment.NewLine, errorMessages); // Join them into a single string
                MessageBox.Show("Validation failed:\n" + errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            _dashboard.OpenChildFormInPanel(new Jobs(_dashboard)); // Open the Jobs form in the dashboard panel
        }
    }
}
