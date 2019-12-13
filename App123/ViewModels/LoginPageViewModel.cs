using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App123.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {


        public LoginPageViewModel(INavigationService navigationService) : base(navigationService)
        { }



        private DelegateCommand _NavigateMapsViewCommand;
        public DelegateCommand NavigateMapsViewCommand =>
            _NavigateMapsViewCommand ?? (_NavigateMapsViewCommand = new DelegateCommand(ExecuteNavigateMapsViewCommand));

        async void ExecuteNavigateMapsViewCommand()
        {
            await NavigationService.NavigateAsync("MapsView");
        }
        
        }
    } 
    

