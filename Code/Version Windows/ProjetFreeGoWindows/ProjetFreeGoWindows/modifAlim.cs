﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

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
        /// frmmodifAlim: Constructor of modifalim form
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
        /// frmmodifAlim_Load: Load Modification Ingredient form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmmodifAlim_Load(object sender, EventArgs e)
        {
            // Limit selection, choose only one day
            cldrExpiration.MaxSelectionCount = 1;

            // Get List of ingredients
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

                    txtName.Text = name;
                    numericQuantity.Value = quantity;
                    numericUnit.Value = unit;
                    cldrExpiration.SetDate(expirationdate);
                }
            }
        }

        /// <summary>
        /// cmdModif_Click: Modification Ingredients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdModif_Click(object sender, EventArgs e)
        {
            DateTime date = cldrExpiration.SelectionRange.Start;
            DateTime actualdate = DateTime.Now;

            if (txtName.Text != "" && numericQuantity.Value > 0 && numericUnit.Value > 0 && date >= actualdate)
            {
                if (name != txtName.Text || quantity != numericQuantity.Value || unit != numericQuantity.Value || date > expirationdate)
                {
                    // Rename Image File
                    string destpath = path.Replace(name, txtName.Text);
                    try
                    {
                        File.Move(path, destpath);
                    }
                    catch (Exception ex)
                    {

                    }

                    // Modify ingredients values in Database
                    conn.ModifIngredient(txtName.Text, (int)numericQuantity.Value, (int)numericUnit.Value, expirationdate, name);

                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    string text = "L'ingrédient à été correctement modifié";

                    result = MessageBox.Show(text, name, buttons);

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
                else { MessageBox.Show("Vous n'avez rien modifier"); }
            }
        }

        /// <summary>
        /// cmdCancel_Click: Return to the main form: fridgeview.cs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            frm_fridgeview frm_Fridgeview = new frm_fridgeview(informations[0]);
            frm_Fridgeview.Show();
            this.Hide();
        }
    }
}
