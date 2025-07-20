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
    public partial class ViewJob : Form
    {
        private CustomerDashboard _dashboard; // Reference to the CustomerDashboard to open child forms
        public ViewJob(CustomerDashboard dashboard)
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

        private void ViewJob_Load(object sender, EventArgs e)
        {
            LoadImage();
            lblcustomername.Text = Session.email; // Display the logged-in customer's email

            ICustomerRepository customerRepository = new CustomerRepository();
            int customerid = customerRepository.GetCustomerIdByEmail(Session.email);
            lblcustomerid.Text = customerid.ToString(); // Display the customer ID

            LoadJobDetails(customerid); // Load job details into the DataGridView

            LoadJobStatus(); // Load job status into the label
        }

        private void LoadJobStatus()
        {
            ICustomerRepository customerRepository = new CustomerRepository();
            int customerid = customerRepository.GetCustomerIdByEmail(Session.email);

            IJobsRepository jobsRepository = new JobsRepository();
            string jobStatus = jobsRepository.GetJobStatusByCustomerId(customerid);

            lblstatus.Text = "(" + jobStatus + ")"; // Display the job status in the label

            if (jobStatus.Equals("Pending", StringComparison.OrdinalIgnoreCase))
            {
                lblstatus.ForeColor = Color.Red;
            }
            else if (jobStatus.Equals("Confirmed", StringComparison.OrdinalIgnoreCase))
            {
                lblstatus.ForeColor = Color.Green;
                btnedit.Enabled = false; // Disable the edit button if the job is confirmed
                btndelete.Enabled = false; // Disable the delete button if the job is confirmed
            }
            else if (jobStatus.Equals("Cancelled", StringComparison.OrdinalIgnoreCase))
            {
                lblstatus.ForeColor = Color.Red;
                btnedit.Enabled = false; 
                btndelete.Enabled = false;
            }


        }

        private void LoadJobDetails(int customerId) // Method to load job details into the DataGridView
        {
            
            IJobsRepository jobsRepository = new JobsRepository();
            List<JobsModel> jobDetails = jobsRepository.GetJobDetails(customerId);
            if (jobDetails.Count > 0)
            {
                dgvjobdetails.DataSource = jobDetails;
            }
            else
            {
                MessageBox.Show("No job details found for this customer.", "No Records Yet!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            _dashboard.OpenChildFormInPanel(new Jobs(_dashboard));
        }

        private void dgvjobdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvjobdetails.Rows[e.RowIndex];
                if (row != null)
                {
                    lblcustomerid.Text = row.Cells["customerID"].Value.ToString();
                    lbljobid.Text = row.Cells["jobId"].Value.ToString();
                    txtname.Text = row.Cells["fullName"].Value.ToString();
                    txtstartloc.Text = row.Cells["startLocation"].Value.ToString();
                    txtdestination.Text = row.Cells["destination"].Value.ToString();
                    txtemail.Text = row.Cells["email"].Value.ToString();
                    txtconno.Text = row.Cells["phoneNumber"].Value.ToString();
                    txtitems.Text = row.Cells["itemDescription"].Value.ToString();
                }

            }
        }

        private void ClearFields() // Method to clear all input fields
        {
            txtname.Clear();
            txtstartloc.Clear();
            txtdestination.Clear();
            txtemail.Clear();
            txtconno.Clear();
            txtitems.Clear();
            lblcustomerid.Text = string.Empty;
            lbljobid.Text = string.Empty;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                IJobsRepository jobsRepository = new JobsRepository();
                var job = new JobsModel
                {
                    jobId = int.Parse(lbljobid.Text),
                    customerId = int.Parse(lblcustomerid.Text),
                    fullName = txtname.Text,
                    startLocation = txtstartloc.Text,
                    destination = txtdestination.Text,
                    jobstatus = lblstatus.Text.Trim('(', ')'), // Remove parentheses from status
                    email = txtemail.Text,
                    phoneNumber = txtconno.Text,
                    itemDescription = txtitems.Text
                };
                jobsRepository.UpdateJob(job);
                MessageBox.Show("Job details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                int customerId = int.Parse(lblcustomerid.Text);
                ClearFields(); // Clear input fields after update
                LoadJobDetails(customerId); // Reload job details after update


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating job details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
