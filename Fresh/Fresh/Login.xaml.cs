using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fresh
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public NavigationPage navigationPage;

        public Login()
        {
            InitializeComponent();

        }
        private void btn_Clicked(object sender, EventArgs e)
        {
            //App.Current.MainPage.Navigation.PushAsync(new ShellHome());

            App.Current.MainPage.Navigation.PushModalAsync(new ShellHome());
        }
    }
}