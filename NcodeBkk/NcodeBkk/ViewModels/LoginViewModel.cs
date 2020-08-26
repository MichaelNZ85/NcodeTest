using NcodeBkk.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace NcodeBkk.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public string Email { get; set; }
        public string Password { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            
        }
    }
}
