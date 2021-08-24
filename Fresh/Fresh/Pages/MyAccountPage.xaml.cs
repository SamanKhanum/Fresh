
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fresh.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyAccountPage : ContentPage
    {
        public MyAccountPage()
        {
            InitializeComponent();
        }

        private void Logout_Clicked(object sender, System.EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new Login());
        }
    }
}