using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fresh.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoriesPage : ContentPage
    {

        public CategoriesPage()
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
            trendList.Add(new Product { Image = "AppIcon", Name = "Chocolate", Price = "Rs.200" });
            trendList.Add(new Product { Image = "AppIcon", Name = "Cookies", Price = "Rs.120" });
            trendList.Add(new Product { Image = "AppIcon", Name = "Snacks", Price = "Rs.80" });
            trendList.Add(new Product { Image = "AppIcon", Name = "Sanitary", Price = "Rs.100" });
            trendList.Add(new Product { Image = "AppIcon", Name = "Utensils", Price = "Rs.300" });
            trendList.Add(new Product { Image = "AppIcon", Name = "Makeup", Price = "Rs.250" });
            trendList.Add(new Product { Image = "AppIcon", Name = "Stationary", Price = "Rs.90" });
            trendList.Add(new Product { Image = "AppIcon", Name = "Kitchen", Price = "Rs.160" });
            return trendList;
        }

        private List<Product> GetTrends()
        {
            var colList = new List<Product>();
            colList.Add(new Product { Image = "JustAPotato", Name = "Beige Heeled Shoe", Price = "$109.99" });
            colList.Add(new Product { Image = "WomenShopping", Name = "Shoe + Addons", Price = "$225.99" });
            colList.Add(new Product { Image = "JustAPotato", Name = "Shoe + Addons", Price = "$225.99" });
            colList.Add(new Product { Image = "WomenShopping", Name = "Shoe + Addons", Price = "$225.99" });
            colList.Add(new Product { Image = "JustAPotato", Name = "Shoe + Addons", Price = "$225.99" });
            colList.Add(new Product { Image = "WomenShopping", Name = "Shoe + Addons", Price = "$225.99" });
            colList.Add(new Product { Image = "JustAPotato", Name = "Shoe + Addons", Price = "$225.99" });
            colList.Add(new Product { Image = "WomenShopping", Name = "Shoe + Addons", Price = "$225.99" });
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

       
    }

    public class Banner
    {
        public string Image { get; set; }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
    }
}