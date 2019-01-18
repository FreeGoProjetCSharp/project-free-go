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
using Microsoft.VisualBasic;

namespace ProjetFreeGoWindows
{
    public partial class frm_addAlim : Form
    {
        private connectionDB conn = new connectionDB(); // Connection to BDD
        string[] informations = new string[2]; // Array with user information
        bool imageupload = false; // For knowing if the image was upload correctly

        /// <summary>
        /// frm_addAlim: Constructor
        /// </summary>
        /// <param name="username"></param>
        public frm_addAlim(string username)
        {
            InitializeComponent();
            this.informations = conn.GetUserInfo(username);
        }

        /// <summary>
        /// frm_addAlim_Load: Load Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.PNG;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.PNG;";
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
                string extension = Path.GetExtension(txtPathFile.Text);
                path = Path.Combine(path, txtName.Text + extension);

                File.Copy(txtPathFile.Text, path,true);

                // Add ingredient to the database
                if (conn.AddIngredient(username,txtName.Text,datestring,quantity,unit,path) == true)
                {
                    this.Hide();
                    frm_fridgeview frm_Fridgeview = new frm_fridgeview(username);
                    frm_Fridgeview.Show();
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer tout les champs");
            } 
        }
    }
}
