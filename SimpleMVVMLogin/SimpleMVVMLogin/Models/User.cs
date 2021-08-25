using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SimpleMVVMLogin.Models
{
    class User: INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
