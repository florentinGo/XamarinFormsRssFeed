using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsRssFeed.ViewModels;

namespace XamarinFormsRssFeed.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public FeedsTable feedsTable { get; set; }
        public MainPage()
        {
            InitializeComponent();
            feedsTable = new FeedsTable();
        }

        private async void ValidateButton_Clicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            var x = await DisplayAlert("Navigation", "Je veux naviguer", "OK", "NON");
            
        }
    }
}