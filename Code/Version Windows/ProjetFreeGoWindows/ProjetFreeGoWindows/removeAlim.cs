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
    public partial class frmremoveAlim : Form
    {
        private connectionDB conn = new connectionDB();

        List<Ingredients> ingredients = new List<Ingredients>();

        // Array of precious informations such Username, name of the ingredient
        string[] informations = new string[2];

        public frmremoveAlim(string username)
        {
            InitializeComponent();
            this.informations[0] = username;
        }

        private void frmremoveAlim_Load(object sender, EventArgs e)
        {
            ingredients = conn.GetIngredientsByUser(this.informations[0]);

            foreach(Ingredients ing in ingredients)
            {
                cmbAlim.Items.Add(ing.name);
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            frm_fridgeview frm_Fridgeview = new frm_fridgeview(informations[0]);
            frm_Fridgeview.Show();
            this.Hide();
        }

        private void cmdRetire_Click(object sender, EventArgs e)
        {
            string IngName = cmbAlim.SelectedItem.ToString();

            conn.RemoveIngredient(IngName);

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            string text = "L'ingrédient à été correctement retiré";

            result = MessageBox.Show(text, IngName, buttons);

            if (result == DialogResult.OK)
            {
                frm_fridgeview frm_Fridgeview = new frm_fridgeview(informations[0]);
                frm_Fridgeview.Show();
                this.Hide();
            }
            else
            {

            }
        }
    }
}
