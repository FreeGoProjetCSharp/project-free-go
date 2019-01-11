using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFreeGoWindows
{
    public class Ingredients
    {
        private connectionDB conn = new connectionDB(); // Connection to BDD
        string[] informations = new string[2]; // Array with user information

        private List<Ingredients> ingredients = new List<Ingredients>();

        private string name;
        private DateTime expirationdate;
        private int quantity;
        private int unit;
        private string ImagePath;

        public Ingredients(string name, DateTime expirationdate, int quantity, int unit, string ImagePath)
        {
            this.name = name;
            this.expirationdate = expirationdate;
            this.quantity = quantity;
            this.unit = unit;
            this.ImagePath = ImagePath;
        }


        public void IngredientsInFrigdeByUser(string username)
        {

        }


    }
}
