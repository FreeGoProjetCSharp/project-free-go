using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetFreeGoWindows
{
    public partial class frm_addAlim : Form
    {
        public frm_addAlim()
        {
            InitializeComponent();
        }

        private void frm_addAlim_Load(object sender, EventArgs e)
        {
            txtPathFile.Hide();
        }

        /// <summary>
        /// cmdUploadFile_Click: File Dialog to upload a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdUploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if(open.ShowDialog() == DialogResult.OK)
            {
                txtPathFile.Text = open.FileName;
                pcbImage.Image = new Bitmap(open.FileName);
            }      
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAddAliment_Click(object sender, EventArgs e)
        {
            // Create a new Images folder
            string path = Path.GetDirectoryName(Application.ExecutablePath)+"\\Images\\";
            Directory.CreateDirectory(path);

            // Copy the image file in the image folder
            File.Copy(txtPathFile.Text, Path.Combine(path, Path.GetFileName(txtPathFile.Text)));
            
        }
    }
}
