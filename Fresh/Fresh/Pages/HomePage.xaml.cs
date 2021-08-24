
using System;
using System.Collections.Generic;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fresh.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            this.BindingContext = this;

        }

        private Timer timer;



        public List<Banner> Banners { get => GetBanners(); }
        public List<Product> CollectionsList { get => GetCollections(); }
        public List<Product> TrendsList { get => GetTrends(); }

        private List<Banner> GetBanners()
        {
            var bannerList = new List<Banner>();
            bannerList.Add(new Banner { Image = "OffersTemplate1" });
            bannerList.Add(new Banner { Image = "OffersTemplate2" });
            bannerList.Add(new Banner { Image = "OffersTemplate3" });
            return bannerList;
        }

        private List<Product> GetCollections()
        {
            var trendList = new List<Product>();
            trendList.Add(new Product { Image = "chocolate", Name = "Chocolate", Price = "Rs.200" });
            trendList.Add(new Product { Image = "cookies", Name = "Cookies", Price = "Rs.120" });
            trendList.Add(new Product { Image = "snacks", Name = "Snacks", Price = "Rs.80" });
            trendList.Add(new Product { Image = "drinks", Name = "Drinks", Price = "Rs.100" });
            trendList.Add(new Product { Image = "utensils", Name = "Utensils", Price = "Rs.300" });
            trendList.Add(new Product { Image = "makeup", Name = "Makeup", Price = "Rs.250" });
            trendList.Add(new Product { Image = "stationary", Name = "Stationary", Price = "Rs.90" });
            trendList.Add(new Product { Image = "cereals", Name = "Cereals", Price = "Rs.160" });
            return trendList;
        }

        private List<Product> GetTrends()
        {
            var colList = new List<Product>();
            colList.Add(new Product { Image = "tops", Name = "Tops", Price = "Rs.160" });
            colList.Add(new Product { Image = "bottoms", Name = "Bottoms", Price = "Rs.200" });
            colList.Add(new Product { Image = "dresses", Name = "Dresses", Price = "Rs.230" });
            colList.Add(new Product { Image = "nightwear", Name = "Night Wear", Price = "Rs.170" });
            colList.Add(new Product { Image = "footwear", Name = "Footwear", Price = "Rs.300" });
            colList.Add(new Product { Image = "sports", Name = "SportsWear", Price = "Rs.320" });
            colList.Add(new Product { Image = "accessories", Name = "Accessories", Price = "Rs.99" });
            return colList;
        }

        protected override void OnAppearing()
        {
            timer = new Timer(TimeSpan.FromSeconds(4).TotalMilliseconds) { AutoReset = true, Enabled = true };
            timer.Elapsed += Timer_Elapsed;
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            timer?.Dispose();
            base.OnDisappearing();
        }

        protected void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {

                if (cvBanners.Position == 2)
                {
                    cvBanners.Position = 0;
                    return;
                }

                cvBanners.Position += 1;

            });

        }

        private void Cart_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new BasketPage());
        }
    }

    public class Banner
    {
        public string Image { get; set; }
    }

    public class Product
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }
}