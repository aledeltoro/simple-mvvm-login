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
            BarAndHotelsOption.Place = "42 Place";
            //BarAndHotelsOption.Source = ImageSource.FromFile("@drawable/beer_mug");

            FineDiningOption.Title = "Fine Dining";
            FineDiningOption.Place = "15 Place";
            //FineDiningOption.Source = ImageSource.FromFile("@drawable/fine_dining");

            CafesOption.Title = "Cafes";
            CafesOption.Place = "28 Place";
            //CafesOption.Source = ImageSource.FromFile("@drawable/cafe_storefront");

            NearbyOption.Title = "Nearby";
            NearbyOption.Place = "34 Place";
            //NearbyOption.Source = ImageSource.FromFile("@drawable/location");

            FastFoodsOption.Title = "Fast Foods";
            FastFoodsOption.Place = "29 Place";
            //FastFoodsOption.Source = ImageSource.FromFile("@drawable/fastfood");

            FeaturedFoodsOption.Title = "Featured Foods";
            FeaturedFoodsOption.Place = "21 Place";
            //FeaturedFoodsOption.Source = ImageSource.FromFile("@drawable/pizza");
        }
    }
}
