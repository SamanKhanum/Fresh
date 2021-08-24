using Fresh.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fresh
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShellHome : Shell
    {
        public ShellHome()
        {
            InitializeComponent();
        }

        private void HomePage_Tapped(object sender, System.EventArgs e)
        {
            App.Current.MainPage = new HomePage();
        }
        private void ExplorePage_Tapped(object sender, System.EventArgs e)
        {
            App.Current.MainPage = new ExplorePage();
        }
        private void CategoriesPage_Tapped(object sender, System.EventArgs e)
        {
            App.Current.MainPage = new CategoriesPage();
        }
        private void BasketPage_Tapped(object sender, System.EventArgs e)
        {
            App.Current.MainPage = new BasketPage();
        }
        private void MyAccountPage_Tapped(object sender, System.EventArgs e)
        {
            App.Current.MainPage = new MyAccountPage();
        }
    }
}

