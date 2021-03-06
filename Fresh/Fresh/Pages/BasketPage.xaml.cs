using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fresh.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasketPage : ContentPage
    {
        public BasketPage()
        {
            InitializeComponent();
        }

        private void Basket_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new ExplorePage());
        }
    }
}