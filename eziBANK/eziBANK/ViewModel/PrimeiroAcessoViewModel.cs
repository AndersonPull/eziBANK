﻿using System;
using System.Windows.Input;
using eziBANK.Services.Navigation;
using Xamarin.Forms;

namespace eziBANK.ViewModel
{
     class PrimeiroAcessoViewModel : BaseVM
    {
        INavigationService _serviceNavigation;
        public PrimeiroAcessoViewModel(INavigationService serviceNavigation)
        {
            _serviceNavigation = serviceNavigation;
        }
        /// <summary>
        /// Gets the proximo command.
        /// </summary>
        /// <value>The proximo command.</value>
        /// 
        public ICommand Login
        {
            get
            {
                return new Command(() =>
                {
                        _serviceNavigation.NavigateToAsync<LoginViewModel>();
                });
            }
        }
    }
}
