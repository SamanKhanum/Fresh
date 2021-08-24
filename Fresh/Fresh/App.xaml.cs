using Xamarin.Forms;

namespace Fresh
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
    class Fresh
    {
        protected void OnStart()
        {
        }

        protected void OnSleep()
        {
        }

        protected void OnResume()
        {
        }
    }

  
}
