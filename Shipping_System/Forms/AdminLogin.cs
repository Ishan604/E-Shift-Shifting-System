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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        private void LoadImage()
        {
            try
            {
                string imagepath = @"Images\logo.png";
                pcblogo.Image = Image.FromFile(imagepath);
                pcblogo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }
        private void AdminLogin_Load(object sender, EventArgs e)
        {
            LoadImage();
        }
    }
}
