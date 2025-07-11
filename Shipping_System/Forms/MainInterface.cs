using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shipping_System.Forms
{
    public partial class MainInterface : Form
    {
        public MainInterface()
        {
            InitializeComponent();
            string iconpath = Path.Combine(Application.StartupPath, "Images", "logo_icon.ico");
            this.Icon = new Icon(iconpath);
        }

        private void LoadPicture()
        {
            try
            {
                string imagepath1 = @"Images\user.png";
                string imagepath2 = @"Images\admin.png";
                pcbcutomer.Image = Image.FromFile(imagepath1);
                pcbadmin.Image = Image.FromFile(imagepath2);
                pcbcutomer.SizeMode = PictureBoxSizeMode.StretchImage;
                pcbadmin.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }

        private void MainInterface_Load(object sender, EventArgs e)
        {
            LoadPicture();
        }

        private void panelcustomer_Paint(object sender, PaintEventArgs e)
        {
            CustomerLogin customerLogin = new CustomerLogin();
            customerLogin.Show();
            this.Hide();
        }

        private void paneladmin_Paint(object sender, PaintEventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void panelcustomer_Click(object sender, EventArgs e)
        {
            CustomerLogin customerLogin = new CustomerLogin();
            customerLogin.Show();
            this.Hide();
        }

        private void paneladmin_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }
    }
}
