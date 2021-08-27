using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleMVVMLogin.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardButton : ContentView
    {
        public static readonly BindableProperty ButtonTitleProperty = BindableProperty.Create(nameof(ButtonTitle), typeof(string), typeof(DashboardButton), string.Empty);
        public static readonly BindableProperty ButtonSubtitleProperty = BindableProperty.Create(nameof(ButtonSubtitle), typeof(string), typeof(DashboardButton), string.Empty);
        public static readonly BindableProperty IconImageSourceProperty = BindableProperty.Create(nameof(IconImageSource), typeof(ImageSource), typeof(DashboardButton), default(ImageSource));
        
        public string ButtonTitle
        {
            get => (string)GetValue(ButtonTitleProperty);
            set => SetValue(ButtonTitleProperty, value);
        }

        public string ButtonSubtitle
        {
            get => (string)GetValue(ButtonSubtitleProperty);
            set => SetValue(ButtonSubtitleProperty, value);
        }

        public ImageSource IconImageSource
        {
            get => (ImageSource)GetValue(IconImageSourceProperty);
            set => SetValue(IconImageSourceProperty, value);
        }

        public DashboardButton()
        {
            InitializeComponent();
        }
    }
}