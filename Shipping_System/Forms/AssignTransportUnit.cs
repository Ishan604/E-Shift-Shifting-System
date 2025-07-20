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
    public partial class AssignTransportUnit : Form
    {
        public AssignTransportUnit()
        {
            InitializeComponent();
        }
        private void LoadImage() // Method to load the image into the PictureBox
        {
            string imagepath = @"Images\userprofile.png";
            pcbuserlogo.Image = Image.FromFile(imagepath);
            pcbuserlogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void LoadAllLoadsDetails() // Method to load all loads details into the DataGridView
        {
            ILoadRepository loadRepository = new LoadRepository();
            List<LoadModel> loads = loadRepository.GetAllLoads();
            if (loads != null && loads.Count > 0)
            {
                dgvloaddetails.DataSource = loads;
            }
            else
            {
                MessageBox.Show("No loads found.");
            }
        }
        private void ClearFields() // Method to clear all input fields
        {
            lblloadid.Text = string.Empty;
            lbljobid.Text = string.Empty;
            lblcontainerid.Text = string.Empty;
            txtloaditems.Clear();
            lblweight.Text = string.Empty;
        }
        private void GetTransportUnitDetails() // Method to get transport unit details
        {
            ITransportUnitRepository transportUnitRepository = new TransportUnitRepository();
            int containerId = int.Parse(lblcontainerid.Text);
            List<TransportUnitModel> transportUnits = transportUnitRepository.GetAllTransportUnits(containerId);
            if (transportUnits != null && transportUnits.Count > 0)
            {
                dgvunitdetails.DataSource = transportUnits;
            }
            else
            {
                MessageBox.Show("No transport units found.");
            }
        }

        private void AssignTransportUnit_Load(object sender, EventArgs e)
        {
            LoadImage();
            LoadAllLoadsDetails(); // Load all loads details when the form loads
            lbladminname.Text = Session.email; // Display the admin's email in the label
        }

        private void dgvloaddetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvloaddetails.Rows.Count)
            {
                DataGridViewRow row = dgvloaddetails.Rows[e.RowIndex];
                lblloadid.Text = row.Cells["loadId"].Value.ToString();
                lbljobid.Text = row.Cells["jobId"].Value.ToString();
                lblcontainerid.Text = row.Cells["containerId"].Value.ToString();
                txtloaditems.Text = row.Cells["loadDescription"].Value.ToString();
                lblweight.Text = row.Cells["loadWeight"].Value.ToString();

                // Load transport unit details based on the selected load
                GetTransportUnitDetails();
                lblunitid.Text = string.Empty; // Clear the unit ID label
            }
        }

        private void dgvunitdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvunitdetails.Rows.Count)
            {
                DataGridViewRow row = dgvunitdetails.Rows[e.RowIndex];
                lblunitid.Text = row.Cells["transportunitId"].Value.ToString();
            }
        }

        private void btnassign_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(lblloadid.Text) ||
                    string.IsNullOrWhiteSpace(lbljobid.Text) ||
                    string.IsNullOrWhiteSpace(lblcontainerid.Text) ||
                    string.IsNullOrWhiteSpace(lblunitid.Text) ||
                    string.IsNullOrWhiteSpace(txtloaditems.Text) ||
                    string.IsNullOrWhiteSpace(lblweight.Text))
                {
                    MessageBox.Show("Please select a load, a transport unit, and ensure all fields are filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Parse and validate numeric fields
                if (!decimal.TryParse(lblweight.Text, out decimal weight))
                {
                    MessageBox.Show("Invalid numeric values in one or more fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                AssignedJobModel jobModel = new AssignedJobModel
                {
                    JobId = int.Parse(lbljobid.Text),
                    LoadId = int.Parse(lblloadid.Text),
                    ContainerId = int.Parse(lblcontainerid.Text),
                    UnitId = int.Parse(lblunitid.Text),
                    LoadItems = txtloaditems.Text.Trim(),
                    Weight = lblweight.Text,
                    AssignedDate = DateTime.Now
                };

                IAssignedJobRepository assignedJobRepository = new AssignedJobRepository();
                assignedJobRepository.AddAssignedJobDetails(jobModel);

                MessageBox.Show("Assigned job details added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding the data! " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
