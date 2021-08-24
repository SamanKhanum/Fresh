using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Fresh
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(2000);
            ScaleTo(1, 200, easing: Easing.Linear);

        }

        private static void ScaleTo(int v1, int v2, Easing easing)
        {
            App.Current.MainPage = new NavigationPage(new Login());

        }
    }
}

    
    