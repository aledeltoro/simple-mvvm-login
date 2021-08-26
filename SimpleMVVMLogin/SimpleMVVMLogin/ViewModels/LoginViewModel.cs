using SimpleMVVMLogin.Models;
using SimpleMVVMLogin.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimpleMVVMLogin.ViewModels
{
    class LoginViewModel: INotifyPropertyChanged
    {
        public User User { get; set; } = new User();

        public ICommand LogUserCommand { get; set; }
        public ICommand NavigateRegisterPageCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public LoginViewModel()
        {
            LogUserCommand = new Command<User>(LogUser);
            NavigateRegisterPageCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
            });
        }

        private async void LogUser(User user)
        {
            bool isEmailEmpty = string.IsNullOrEmpty(user.Email);
            bool isPasswordEmpty = string.IsNullOrEmpty(user.Password);
            bool areFieldsFull = !isEmailEmpty && !isPasswordEmpty;

            if (areFieldsFull)
            {
                await App.Current.MainPage.DisplayAlert("Welcome", $"Hey {user.Email}", "Ok");
                return;
            }

            if (isEmailEmpty)
            {
                await App.Current.MainPage.DisplayAlert("Error", $"Email cannot be empty", "Ok");
            }

            if (isPasswordEmpty)
            {
                await App.Current.MainPage.DisplayAlert("Error", $"Password cannot be empty", "Ok");
            }
        }

        private void OnPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
