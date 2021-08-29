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
        public ICommand NavigateToRegisterCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public LoginViewModel()
        {
            LogUserCommand = new Command<User>(OnLogin);
            NavigateToRegisterCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
            });
        }

        private async void OnLogin(User user)
        {
            bool isEmailEmpty = string.IsNullOrEmpty(user.Email);
            bool isPasswordEmpty = string.IsNullOrEmpty(user.Password);
            bool areFieldsFull = !isEmailEmpty && !isPasswordEmpty;

            if (areFieldsFull)
            {
                await App.Current.MainPage.DisplayAlert("Welcome", $"Hey {user.Email}", "Ok");
                await App.Current.MainPage.Navigation.PushAsync(new ContainerTabbedPage());
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
        }

        private void OnPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
