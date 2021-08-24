using System.Threading.Tasks;

namespace Fresh
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashScreen : ContentPage
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
    }
}
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



