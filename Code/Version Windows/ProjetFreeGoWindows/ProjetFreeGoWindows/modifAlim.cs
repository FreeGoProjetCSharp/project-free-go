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
    public partial class frmmodifAlim : Form
    {
        private connectionDB conn = new connectionDB();

        // Array of precious informations such Username, name of the ingredient
        string[] informations = new string[2];

        // Var for attribute of the ingredient
        string name;
        int quantity;
        int unit;
        DateTime expirationdate;
        string path;

        private List<Ingredients> IngredientsInfridge = new List<Ingredients>(); // List of ingredients

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="ingredient"></param>
        public frmmodifAlim(string username, string ingredient)
        {
            InitializeComponent();
            this.informations[0] = username;
            this.informations[1] = ingredient;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmmodifAlim_Load(object sender, EventArgs e)
        {
            cldrExpiration.MaxSelectionCount = 1;

            IngredientsInfridge = conn.GetIngredientsByUser(informations[0]);

            foreach(Ingredients ingredients in IngredientsInfridge)
            {
                if(ingredients.name == this.informations[1])
                {
                    name = ingredients.name;
                    quantity = ingredients.quantity;
                    unit = ingredients.unit;
                    expirationdate = ingredients.expirationdate;
                    path = ingredients.ImagePath;

                    lblName.Text = name;
                    txtName.Text = name;
                    numericQuantity.Value = quantity;
                    numericUnit.Value = unit;
                    cldrExpiration.SelectionRange.Start = expirationdate;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdModif_Click(object sender, EventArgs e)
        {
            DateTime date = cldrExpiration.SelectionRange.Start;
            DateTime actualdate = DateTime.Now;

            if (txtName.Text != "" && numericQuantity.Value > 0 && numericUnit.Value > 0 && date >= actualdate)
            {   
                if (name != lblName.Text || quantity != numericQuantity.Value || unit != numericQuantity.Value)
                {
                    string destpath = path.Replace(name, lblName.Text);
                    File.Move(path, destpath);

                    //UPDATE Ingredients SET Nom="Bananeee", Quantity=3, Unit=3 WHERE Nom='Banane'
                    string sql = "UPDATE Ingredients SET Nom=" + "'" + lblName.Text + "'" + " WHERE Nom=" + name;


                }
            }
        }
    }
}
