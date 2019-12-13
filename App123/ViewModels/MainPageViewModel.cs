using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App123.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private DelegateCommand _signup;
        public DelegateCommand SignUpCommand =>
            _signup ?? (_signup = new DelegateCommand(ExecuteSignUpCommand));
        private DelegateCommand _login;
        
        
        public DelegateCommand Login =>
            _login ?? (_login = new DelegateCommand(ExecuteLogin));

        async void ExecuteLogin()
        {
            await NavigationService.NavigateAsync("LoginPage");

        }

        async void ExecuteSignUpCommand()
        {
            await NavigationService.NavigateAsync("SignUp");


        }
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            
        }
    }
}
