using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fresh.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExplorePage : ContentPage
    {
        public ExplorePage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        public List<Product> Explore { get => GetList(); }
        public List<Product> Trends { get =>  TrendsList(); }

        private List<Product> TrendsList()
        {
            var TrList = new List<Product>();
            TrList.Add(new Product { Image = "accessories", Name = "Accessories", Price = "Rs.200" });
            TrList.Add(new Product { Image = "dresses", Name = "Dresses", Price = "Rs.120" });
            TrList.Add(new Product { Image = "makeup", Name = "Makeup", Price = "Rs.80" });
            TrList.Add(new Product { Image = "footwear", Name = "FootWear", Price = "Rs.100" });
            TrList.Add(new Product { Image = "nightwear", Name = "NightWear", Price = "Rs.300" });
            TrList.Add(new Product { Image = "Pets", Name = "Pets", Price = "Rs.250" });
            TrList.Add(new Product { Image = "tops", Name = "Tops", Price = "Rs.90" });
            TrList.Add(new Product { Image = "utensils", Name = "Utensils", Price = "Rs.160" });
            return TrList;
        }

        private List<Product> GetList()
        {
            var ExList = new List<Product>();
            ExList.Add(new Product { Image = "Bakery", Name = "Bakery", Price = "Rs.200" });
            ExList.Add(new Product { Image = "Beauty", Name = "Beauty", Price = "Rs.120" });
            ExList.Add(new Product { Image = "Beverages", Name = "Beverages", Price = "Rs.80" });
            ExList.Add(new Product { Image = "Cleaning", Name = "Cleaning", Price = "Rs.100" });
            ExList.Add(new Product { Image = "Kitchen", Name = "Kitchen", Price = "Rs.300" });
            ExList.Add(new Product { Image = "Pets", Name = "Pets", Price = "Rs.250" });
            ExList.Add(new Product { Image = "Garden", Name = "Garden", Price = "Rs.90" });
            ExList.Add(new Product { Image = "Grains", Name = "Grains", Price = "Rs.160" });
            return ExList;
        }
    }
}