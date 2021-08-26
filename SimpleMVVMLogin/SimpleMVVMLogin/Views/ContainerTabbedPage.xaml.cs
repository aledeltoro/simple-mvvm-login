using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleMVVMLogin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContainerTabbedPage : TabbedPage
    {
        public ContainerTabbedPage()
        {
            InitializeComponent();
        }
    }
}