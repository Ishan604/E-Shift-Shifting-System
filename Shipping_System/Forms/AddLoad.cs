using Shipping_System.Business.Interface;
using Shipping_System.Business.Service;
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
using System.Xml.Linq;
using static Shipping_System.Forms.AdminLogin;

namespace Shipping_System.Forms
{
    public partial class AddLoad : Form
    {
        public AddLoad()
        {
            InitializeComponent();
        }
        private void LoadImage() // Method to load the image into the PictureBox
        {
            string imagepath = @"Images\userprofile.png";
            pcbuserlogo.Image = Image.FromFile(imagepath);
            pcbuserlogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void LoadConfirmedJobs() // Method to load confirmed jobs into the DataGridView
        {
            IJobsRepository jobsRepository = new JobsRepository();
            List<JobsModel> confirmedJobs = jobsRepository.GetAllConfirmedJobs();
            if (confirmedJobs != null && confirmedJobs.Count > 0)
            {
                dgvjobdetails.DataSource = confirmedJobs;

            }
            else
            {
                MessageBox.Show("No confirmed jobs found.");
            }
        }
        private void LoadContainerDetails()
        {
            IContainerRepository containerRepository = new ContainerRepository();
            List<ContainerModel> containerModels = containerRepository.GetContainerDetails();
            if (containerModels != null && containerModels.Count > 0)
            {
                dgvcontainerdetails.DataSource = containerModels;

            }
            else
            {
                MessageBox.Show("No container details found.");
            }
        }

        private void AddLoad_Load(object sender, EventArgs e)
        {
            LoadImage();
            LoadConfirmedJobs(); // Load confirmed jobs when the form loads
            LoadContainerDetails(); // Load container details when the form loads
            lbladminname.Text = Session.email; // Display the admin's email in the label
        }

        private void dgvjobdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvjobdetails.Rows.Count)
            {
                DataGridViewRow row = dgvjobdetails.Rows[e.RowIndex];
                lbljobid.Text = row.Cells["jobId"].Value.ToString();
                lblcustomerid.Text = row.Cells["CustomerId"].Value.ToString();
                lblstartlocation.Text = row.Cells["startLocation"].Value.ToString();
                lbldestination.Text = row.Cells["destination"].Value.ToString();
                txtitems.Text = row.Cells["itemDescription"].Value.ToString();
            }
        }
        private void ClearFields() // Method to clear all input fields
        {
            lbljobid.Text = string.Empty;
            lblcustomerid.Text = string.Empty;
            lblstartlocation.Text = string.Empty;
            lbldestination.Text = string.Empty;
            txtitems.Clear();
            txtweight.Clear();
            txtloaditems.Clear();
            lblcontainerid.Text = string.Empty; 
        }

        private bool IsValidWeight(string weights) // Method to validate the weight input
        {
            return weights.All(char.IsDigit);
        }

        private void btnassign_Click(object sender, EventArgs e)
        {
            try
            {
                bool isvalidwight = IsValidWeight(txtweight.Text);

                if (string.IsNullOrWhiteSpace(lbljobid.Text) &&
                    string.IsNullOrWhiteSpace(lblcustomerid.Text) &&
                    string.IsNullOrWhiteSpace(lblstartlocation.Text) &&
                    string.IsNullOrWhiteSpace(lbldestination.Text) &&
                    string.IsNullOrWhiteSpace(txtitems.Text) &&
                    string.IsNullOrWhiteSpace(txtweight.Text) &&
                    string.IsNullOrWhiteSpace(txtloaditems.Text) && isvalidwight)
                {
                    MessageBox.Show("Please fill in all fields before assigning the load.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    var load = new LoadModel
                    {
                        jobId = int.Parse(lbljobid.Text),
                        containerId = int.Parse(lblcontainerid.Text),
                        loadDescription = txtloaditems.Text, 
                        loadWeight = txtweight.Text,
                        loadStatus = "Assigned" 
                    };

                    ILoadRepository loadRepository = new LoadRepository();
                    loadRepository.AddLoad(load);

                    MessageBox.Show("Load assigned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields(); // Clear all input fields after successful assignment
                    LoadConfirmedJobs(); // Refresh the confirmed jobs list
                    LoadContainerDetails(); // Refresh the container details list
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while assigning the load: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvcontainerdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvcontainerdetails.Rows[e.RowIndex];
                lblcontainerid.Text = row.Cells["ContainerId"].Value.ToString();
            }
        }
    }
}
