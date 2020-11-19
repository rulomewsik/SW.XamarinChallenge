using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace GoogleBooksChallenge.Core.ViewModels
{
    public abstract class BaseViewModel<TParameter> : BaseViewModel, IMvxViewModel<TParameter>
        where TParameter : notnull
    {
        public BaseViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
        }

        public abstract void Prepare(TParameter parameter);
    }
}
