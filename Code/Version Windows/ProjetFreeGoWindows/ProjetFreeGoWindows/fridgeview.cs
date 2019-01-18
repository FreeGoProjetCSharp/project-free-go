using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFreeGoWindows
{
    public partial class frm_fridgeview : Form
    {
        private connectionDB conn = new connectionDB();
        string[] informations = new string[2];

        private List<Ingredients> IngredientsInfridge = new List<Ingredients>();


        public frm_fridgeview(string username)
        {
            InitializeComponent();
            lblName.Text = username;
            lblUsrName.Text = username;
            this.informations = conn.GetUserInfo(username);
        }

        private void frm_fridgeview_Load(object sender, EventArgs e)
        {
            IngredientsInfridge = conn.GetIngredientsByUser(informations[0]);
            int i = 0;

            foreach(Ingredients ingredients in IngredientsInfridge)
            {
                PictureBox pcb = new PictureBox();

                string path = ingredients.ImagePath;

                pcb.Image = new Bitmap(path);
                pcb.SizeMode = PictureBoxSizeMode.StretchImage;
                pcb.Width = 140;
                pcb.Height = 140;
                pcb.Tag = ingredients.name;

                pcb.Click += ClickOnIngredient;

                flp.Controls.Add(pcb);
            }
        }

        private void cmdAddAlim_Click(object sender, EventArgs e)
        {
            frm_addAlim frm_AddAlim = new frm_addAlim(informations[0]);
            frm_AddAlim.Show();
            this.Hide();
        }

        private void ClickOnIngredient(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            foreach (Ingredients ingredients in IngredientsInfridge)
            {
                if(ingredients.name == (string)pictureBox.Tag)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    string text = "Nom de l'ingrédient: " + ingredients.name + "\n" + "Quantité: " + ingredients.quantity + "\n" + "Date d'expiration: " + ingredients.expirationdate + "\n" + "Unité: " + ingredients.unit + "\n \n Voulez-vous modifier le produit?";

                    result = MessageBox.Show(text,ingredients.name,buttons);

                    if(result == DialogResult.Yes)
                    {
                        frmmodifAlim frmmodifAlim = new frmmodifAlim(informations[0], ingredients.name);
                        frmmodifAlim.Show();
                        this.Hide();
                    }
                    else
                    {

                    }

                }
            }
            
        }

        private void cmdRemoveAlim_Click(object sender, EventArgs e)
        {

        }
    }
}
