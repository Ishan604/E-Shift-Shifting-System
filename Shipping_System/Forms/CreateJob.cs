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
    public partial class CreateJob : Form
    {
        public CreateJob()
        {
            InitializeComponent();
        }
        private void LoadImage()
        {
            string imagepath = @"Images\userprofile.png";
            pcbuserlogo.Image = Image.FromFile(imagepath);
            pcbuserlogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void CreateJob_Load(object sender, EventArgs e)
        {
            LoadImage();
        }
    }
}
