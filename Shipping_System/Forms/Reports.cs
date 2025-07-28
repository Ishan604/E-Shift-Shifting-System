using Shipping_System.PDF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Shipping_System.Forms.AdminLogin;

namespace Shipping_System.Forms
{
    public partial class Reports : Form
    {
        private AdminDashboard adminDashboard;
        public Reports(AdminDashboard adminDashboard)
        {
            InitializeComponent();
            this.adminDashboard = adminDashboard;
        }
        private void LoadImage() // Method to load the image into the PictureBox
        {
            string imagepath = @"Images\userprofile.png";
            pcbuserlogo.Image = Image.FromFile(imagepath);
            pcbuserlogo.SizeMode = PictureBoxSizeMode.StretchImage;

            string imagepath2 = @"Images\customer2.png";
            pcbcustomer.Image = Image.FromFile(imagepath2);
            pcbcustomer.SizeMode = PictureBoxSizeMode.StretchImage;

            string imagepath3 = @"Images\job.png";
            pcbjob.Image = Image.FromFile(imagepath3);
            pcbjob.SizeMode = PictureBoxSizeMode.StretchImage;

            string imagepath4 = @"Images\lorry2.png";
            pcbunit.Image = Image.FromFile(imagepath4);
            pcbunit.SizeMode = PictureBoxSizeMode.StretchImage;

            string imagepath5 = @"Images\load.png";
            pcbload.Image = Image.FromFile(imagepath5);
            pcbload.SizeMode = PictureBoxSizeMode.StretchImage;

            string imagepath6 = @"Images\assignedjob.png";
            pcbassignedjob.Image = Image.FromFile(imagepath6);
            pcbassignedjob.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private void Reports_Load(object sender, EventArgs e)
        {
            lbladminname.Text = Session.email;
            LoadImage();
        }

        private void pnlgetcustomerdetails_Click(object sender, EventArgs e)
        {
            string connectionstring = "Server=LAPTOP-59PVKG7G; Database=Eshift; Integrated Security=SSPI; Trusted_Connection=True; TrustServerCertificate=True;";
            string outpath = @"D:\Reports\CustomerReport.pdf";
            string directory = Path.GetDirectoryName(outpath);

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory); // Create the directory if it doesn't exist
            }

            try
            {
                CustomerDetailsPdf pdfGenerator = new CustomerDetailsPdf(connectionstring);
                pdfGenerator.GenerateCustomerPdf(outpath);
                MessageBox.Show("Customer details PDF generated successfully at ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating customer details PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlgettransportunitdetails_Click(object sender, EventArgs e)
        {
            string connectionstring = "Server=LAPTOP-59PVKG7G; Database=Eshift; Integrated Security=SSPI; Trusted_Connection=True; TrustServerCertificate=True;";
            string outpath = @"D:\Reports\TransportUnitReport.pdf";
            string directory = Path.GetDirectoryName(outpath);

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory); // Create the directory if it doesn't exist
            }

            try
            {
                TransportUnitPdf pdfGenerator = new TransportUnitPdf(connectionstring);
                pdfGenerator.GenerateTransportUnitPdf(outpath);
                MessageBox.Show("Transport Unit PDF generated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating transport unit details PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
