using App123.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App123.ViewModels
{
    public class SignUpViewModel : ViewModelBase
    {
        private DelegateCommand _MainPage;
        public DelegateCommand MainPage =>
            _MainPage ?? (_MainPage = new DelegateCommand(ExecuteMainPage));

        private string _usernameErrorMessage;
        public string UsernameErrorMessage
        {
            get { return _usernameErrorMessage; }
            set { SetProperty(ref _usernameErrorMessage, value); }
        }

        private string _emailErrorMessage;
        public string EmailErrorMessage
        {
            get { return _usernameErrorMessage; }
            set { SetProperty(ref _usernameErrorMessage, value); }
        }

        private string _passwordErrorMessage;
        public string PasswordErrorMessage
        {
            get { return _passwordErrorMessage; }
            set { SetProperty(ref _passwordErrorMessage, value); }
        }


        private Users _latestUser;
        public Users LatestUser
        {
            get { return _latestUser; }
            set { SetProperty(ref _latestUser, value); }
        }

        async void ExecuteMainPage()
        {
            await NavigationService.NavigateAsync("MainPage");
        }

        private DelegateCommand _SignUp;
        public DelegateCommand SignUp =>
            _SignUp ?? (_SignUp = new DelegateCommand(ExecuteSignUp));

        public SignUpViewModel(INavigationService navigationService) : base(navigationService)
        {
            var userstuff = new Users();
        }
        void ExecuteSignUp()
        {
            if (LatestUser.Name == null)
            {
                UsernameErrorMessage = "Username field cannot be empty";
            }
            if (LatestUser.Email == null)
            {
                EmailErrorMessage = "Email field cannot be empty";
            }
            if (LatestUser.Password == null)
            {
                PasswordErrorMessage = "Password field cannot be empty";
            }
            if (LatestUser.Name != null && LatestUser.Email != null && LatestUser.Password != null)
            {
              /*  var conn = new SQLInteractivity();
                await conn.SaveItemAsync(UserDetails);
                
                await NavigationService.NavigateAsync("MasterDetailMenu/NavigationPage/HomePage", useModalNavigation: true);
                */
            }

        }
    }
}