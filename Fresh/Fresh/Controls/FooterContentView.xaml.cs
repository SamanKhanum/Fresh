using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fresh.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FooterContentView : ContentView
    {
        public FooterContentView()
        {
            InitializeComponent();
        }

        private void logout_clicked(object sender, EventArgs e)
        {
             App.Current.MainPage = new NavigationPage(new Login());
        }
    }
}