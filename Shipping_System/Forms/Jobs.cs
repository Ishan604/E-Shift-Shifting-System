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
using static Shipping_System.Forms.CustomerDashboard;

namespace Shipping_System.Forms
{
    public partial class Jobs : Form
    {
        private CustomerDashboard _dashboard; // Reference to the CustomerDashboard to open child forms
        public Jobs(CustomerDashboard dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;
        }
        private void LoadImage()
        {
            string imagepath = @"Images\userprofile.png";
            pcbuserlogo.Image = Image.FromFile(imagepath);
            pcbuserlogo.SizeMode = PictureBoxSizeMode.StretchImage;

            string imagepath2 = @"Images\lorry.png";
            pcbcreatejob.Image = Image.FromFile(imagepath2);
            pcbcreatejob.SizeMode = PictureBoxSizeMode.StretchImage;

            string imagepath3 = @"Images\status.png";
            pcbjobstatus.Image = Image.FromFile(imagepath3);
            pcbjobstatus.SizeMode = PictureBoxSizeMode.StretchImage;

            string imagepath4 = @"Images\viewjob.png";
            pcbviewjob.Image = Image.FromFile(imagepath4);
            pcbviewjob.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Jobs_Load(object sender, EventArgs e)
        {
            LoadImage();
            lblcustomername.Text = Session.email; // Display the logged-in customer's emailS
        }

        private void pnlcreatejob_Click(object sender, EventArgs e)
        {
            var createJobForm = new CreateJob(_dashboard); // Pass the current dashboard instance to CreateJob
            _dashboard.OpenChildFormInPanel(createJobForm); // Open CreateJob form in the dashboard panel
        }

        private void pnlviewjob_Click(object sender, EventArgs e)
        {
            var viewJob = new ViewJob(_dashboard); // Pass the current dashboard instance to viewjob
            _dashboard.OpenChildFormInPanel(viewJob); // Open viewjob form in the dashboard panel
        }
    }
}
