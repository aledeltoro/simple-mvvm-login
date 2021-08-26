using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace SimpleMVVMLogin.Models
{
    class MenuOption: INotifyPropertyChanged
    {
        public string Title { get; set; }
        public ImageSource Source { get; set; }
        public string Place { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
