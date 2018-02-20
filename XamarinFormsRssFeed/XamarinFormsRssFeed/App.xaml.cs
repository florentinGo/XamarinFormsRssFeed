using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XamarinFormsRssFeed.Services;
using XamarinFormsRssFeed.Views;

namespace XamarinFormsRssFeed
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var nav = new NavigationService();
            nav.Configure(Locator.MainPage, typeof(MainPage));
            var firstPage = new NavigationPage(new MainPage());
            SimpleIoc.Default.Register<INavigationService>(() => nav);
            nav.Initialize(firstPage);
            MainPage = firstPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
