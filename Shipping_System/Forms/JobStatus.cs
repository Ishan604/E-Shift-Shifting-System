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
using static Shipping_System.Forms.ViewJob;

namespace Shipping_System.Forms
{
    public partial class JobStatus : Form
    {
        private CustomerDashboard _dashboard; // Reference to the CustomerDashboard to open child forms
        public JobStatus(CustomerDashboard dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;
        }
        private void LoadImage() // Method to load the user profile image into the PictureBox
        {
            string imagepath = @"Images\userprofile.png";
            pcbuserlogo.Image = Image.FromFile(imagepath);
            pcbuserlogo.SizeMode = PictureBoxSizeMode.StretchImage;
            ViewAsiignedJobsDetails(); // Call the method to view assigned job details
        }

        private void JobStatus_Load(object sender, EventArgs e)
        {
            LoadImage();
            lblcustomername.Text = Session.email; // Display the logged-in customer's email
        }
        private void ViewAsiignedJobsDetails() // Method to view assigned job details
        {
            IAssignedJobRepository assignedJobRepository = new AssignedJobRepository();
            int jobid = SessionForJob.jobid; // Get the job ID from the session
            List<AssignedJobModel> assignedJobs = assignedJobRepository.GetAssignedJobDetailsByJobId(jobid);
            if (assignedJobs.Count > 0)
            {
                dgvassignedjobdetails.DataSource = assignedJobs;
            }
            else
            {
                MessageBox.Show("No assigned job details found for this job.", "No Records Yet!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            _dashboard.OpenChildFormInPanel(new Jobs(_dashboard));
        }

        private void dgvassignedjobdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < dgvassignedjobdetails.Rows.Count)
            {
                DataGridViewRow row = dgvassignedjobdetails.Rows[e.RowIndex];
                lblassignedid.Text = row.Cells["Id"].Value.ToString();
                lbljobid.Text = row.Cells["JobId"].Value.ToString();
                lblloadid.Text = row.Cells["LoadId"].Value.ToString();
                lblcontainerid.Text = row.Cells["ContainerId"].Value.ToString();
                lblunitid.Text = row.Cells["UnitId"].Value.ToString();
                txtitems.Text = row.Cells["LoadItems"].Value.ToString();
                lblweight.Text = row.Cells["Weight"].Value.ToString();
                lbldate.Text = row.Cells["AssignedDate"].Value.ToString();
            }
        }
    }
}
