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
            App.Current.MainPage.Navigation.PushModalAsync(new HomePage());
        }
    }
}

