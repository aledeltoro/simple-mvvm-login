using SimpleMVVMLogin.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SimpleMVVMLogin.ViewModels
{
    class HomeViewModel
    {
        public MenuOption BarAndHotelsOption { get; set; } = new MenuOption();
        public MenuOption FineDiningOption { get; set; } = new MenuOption();
        public MenuOption CafesOption { get; set; } = new MenuOption();
        public MenuOption NearbyOption { get; set; } = new MenuOption();
        public MenuOption FastFoodsOption { get; set; } = new MenuOption();
        public MenuOption FeaturedFoodsOption { get; set; } = new MenuOption();

        public HomeViewModel()
        {
            BarAndHotelsOption.Title = "Bar and Hotels";
            BarAndHotelsOption.Place = "42 Places";
            BarAndHotelsOption.Source = "outline_sports_bar_black_48.png";

            FineDiningOption.Title = "Fine Dining";
            FineDiningOption.Place = "15 Places";
            FineDiningOption.Source = "outline_restaurant_black_48.png";

            CafesOption.Title = "Cafes";
            CafesOption.Place = "28 Places";
            CafesOption.Source = "outline_storefront_black_48.png";

            NearbyOption.Title = "Nearby";
            NearbyOption.Place = "34 Places";
            NearbyOption.Source = "outline_place_black_48.png";

            FastFoodsOption.Title = "Fast Foods";
            FastFoodsOption.Place = "29 Places";
            FastFoodsOption.Source = "outline_fastfood_black_48.png";

            FeaturedFoodsOption.Title = "Featured Foods";
            FeaturedFoodsOption.Place = "21 Places";
            FeaturedFoodsOption.Source = "outline_local_pizza_black_48.png";
        }
    }
}
