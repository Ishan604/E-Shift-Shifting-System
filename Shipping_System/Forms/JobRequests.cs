using Shipping_System.Repository.Interface;
using Shipping_System.Repository.Service;
using Shipping_System.Models;
using Shipping_System.Emails;
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
    public partial class JobRequests : Form
    {
        private AdminDashboard _adminDashboard; // Field to hold the reference to AdminDashboard
        public JobRequests(AdminDashboard adminDashboard)
        {
            InitializeComponent();
            _adminDashboard = adminDashboard;
        }
        private void LoadImage() // Method to load the image into the PictureBox
        {
            string imagepath = @"Images\userprofile.png";
            pcbuserlogo.Image = Image.FromFile(imagepath);
            pcbuserlogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void LoadJobRequests() // Method to load job requests into the DataGridView
        {
            IJobsRepository jobsRepository = new JobsRepository();
            List<JobsModel> jobRequests = jobsRepository.GetAllPendingJobs();
            if (jobRequests != null && jobRequests.Count > 0)
            {
                dgvjobdetails.DataSource = jobRequests;
            }
            else
            {
                MessageBox.Show("No job requests found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ClearFields() // Method to clear all input fields
        {
            lbljobid.Text = string.Empty;
            lblcustomerid.Text = string.Empty;
            txtname.Clear();
            txtstartloc.Clear();
            txtdestination.Clear();
            lblstatus.Text = string.Empty;
            txtemail.Clear();
            txtconno.Clear();
            txtitems.Clear();
        }

        private void JobRequests_Load(object sender, EventArgs e)
        {
            LoadImage();
            lblcustomername.Text = Session.email; // Display the logged-in customer's email
            LoadJobRequests(); // Load job requests into the DataGridView
        }

        private void dgvjobdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvjobdetails.Rows[e.RowIndex];
                lbljobid.Text = row.Cells["jobId"].Value.ToString();
                lblcustomerid.Text = row.Cells["CustomerId"].Value.ToString();
                txtname.Text = row.Cells["fullName"].Value.ToString();
                txtstartloc.Text = row.Cells["startLocation"].Value.ToString();
                txtdestination.Text = row.Cells["destination"].Value.ToString();
                lblstatus.Text = row.Cells["jobstatus"].Value.ToString();
                txtemail.Text = row.Cells["email"].Value.ToString();
                txtconno.Text = row.Cells["phoneNumber"].Value.ToString();
                txtitems.Text = row.Cells["itemDescription"].Value.ToString();
            }
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var jobmodel = new JobsModel
                {
                    jobId = int.Parse(lbljobid.Text),
                    customerId = int.Parse(lblcustomerid.Text),
                    fullName = txtname.Text,
                    startLocation = txtstartloc.Text,
                    destination = txtdestination.Text,
                    email = txtemail.Text,
                    phoneNumber = txtconno.Text,
                    itemDescription = txtitems.Text,
                    jobstatus = "Confirmed" // Set the job status to Confirmed
                };
                IJobsRepository jobsRepository = new JobsRepository();
                jobsRepository.UpdatePendingJobs(jobmodel);

                string email = txtemail.Text;
                ConfirmationEmail.SendConfirmationEmail(email); // Send confirmation email to the customer
                MessageBox.Show("Job request confirmed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadJobRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating customer details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            try
            {
                var jobmodel = new JobsModel
                {
                    jobId = int.Parse(lbljobid.Text),
                    customerId = int.Parse(lblcustomerid.Text),
                    fullName = txtname.Text,
                    startLocation = txtstartloc.Text,
                    destination = txtdestination.Text,
                    email = txtemail.Text,
                    phoneNumber = txtconno.Text,
                    itemDescription = txtitems.Text,
                    jobstatus = "Cancelled" // Set the job status to Confirmed
                };
                IJobsRepository jobsRepository = new JobsRepository();
                jobsRepository.UpdatePendingJobs(jobmodel);

                string email = txtemail.Text;
                CancelationEmail.SendCancelationEmail(email); // Send cancellation email to the customer
                MessageBox.Show("Job request cancelled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadJobRequests(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating customer details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
