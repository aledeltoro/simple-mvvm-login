using SimpleMVVMLogin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimpleMVVMLogin.ViewModels
{
    class RegisterViewModel: INotifyPropertyChanged
    {
        public string ConfirmedPassword { get; set; }
        public User User { get; set; } = new User();

        public ICommand RegisterUserCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public RegisterViewModel()
        {
            RegisterUserCommand = new Command<User>(OnRegister);
        }

        private async void OnRegister(User user)
        {
            bool isNameEmpty = string.IsNullOrEmpty(user.Name);
            bool isEmailEmpty = string.IsNullOrEmpty(user.Email);
            bool isPasswordEmpty = string.IsNullOrEmpty(user.Password);

            bool areFieldsFull = !isEmailEmpty && !isPasswordEmpty;
            bool doPasswordsMatch = user.Password == ConfirmedPassword;

            if (areFieldsFull && doPasswordsMatch)
            {
                await App.Current.MainPage.DisplayAlert("Registration complete", $"Hey {user.Name}!", "Ok");
                await App.Current.MainPage.Navigation.PopAsync();
                return;
            }

            if (isNameEmpty)
            {
                await App.Current.MainPage.DisplayAlert("Error", $"Name cannot be empty", "Ok");
                return;
            }

            if (isEmailEmpty)
            {
                await App.Current.MainPage.DisplayAlert("Error", $"Email cannot be empty", "Ok");
                return;
            }

            if (isPasswordEmpty)
            {
                await App.Current.MainPage.DisplayAlert("Error", $"Password cannot be empty", "Ok");
                return;
            }

            if (!doPasswordsMatch)
            {
                await App.Current.MainPage.DisplayAlert("Error", $"Please make sure your passwords match", "Ok");
                return;
            }

        }

        private void OnPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
