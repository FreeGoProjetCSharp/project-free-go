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
        private connectionDB conn = new connectionDB();
        string[] informations = new string[2];
        bool imageupload = false;

        public frm_addAlim(string username)
        {
            InitializeComponent();
            this.informations = conn.GetUserInfo(username);
        }

        private void frm_addAlim_Load(object sender, EventArgs e)
        {
            txtPathFile.Hide();
            cldrExpiration.MaxSelectionCount = 1;
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
                imageupload = true;
            }      
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAddAliment_Click(object sender, EventArgs e)
        {
            DateTime date = cldrExpiration.SelectionRange.Start;
            DateTime actualdate = DateTime.Now;

            string datestring = date.ToString();
            

            // Check every field if it's empty
            if (txtName.Text != "" && numericQuantity.Value > 0 && numericUnit.Value > 0 && date >= actualdate && imageupload)
            {
                // Cast quantity and unit to integer
                int quantity = (int)numericQuantity.Value;
                int unit = (int)numericUnit.Value;

                // Create a new Images folder
                string username = informations[0];
                string path = Path.GetDirectoryName(Application.ExecutablePath) + "\\Images\\" + username + "\\";
                Directory.CreateDirectory(path);

                // Copy the image file in the image folder
                File.Copy(txtPathFile.Text, Path.Combine(path, Path.GetFileName(txtPathFile.Text)),true);

                // Add ingredient to the database
                conn.AddIngredient(txtName.Text,datestring,quantity,unit,path);
            }
            else
            {
                MessageBox.Show("Veuillez entrer tout les champs");
            } 
        }
    }
}
