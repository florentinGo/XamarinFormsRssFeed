using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using XamarinFormsRssFeed.Views;

namespace XamarinFormsRssFeed.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly INavigationService _navigationService;
        public List<string> items { get; set; }

        public MainPageViewModel(INavigationService navigationService)
        {
            if (navigationService == null) throw new ArgumentNullException("navigationService");
            _navigationService = navigationService;

            AddButtonCommand = new RelayCommand(() => { _navigationService.NavigateTo(Locator.AddRssUrlPage); });

        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand AddButtonCommand { private set; get; }

    }
}
