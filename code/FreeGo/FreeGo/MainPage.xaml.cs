using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FreeGo
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {   
            
            var image = new Image { Source = "User.png"};
            InitializeComponent();
        }
        private void Login_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}
