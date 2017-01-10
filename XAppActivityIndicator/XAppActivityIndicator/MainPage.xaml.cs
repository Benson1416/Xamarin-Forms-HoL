using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XAppActivityIndicator.ViewModels;

namespace XAppActivityIndicator
{
    public partial class MainPage : ContentPage
    {
        private ActivityIndicatorViewModel ViewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            ViewModel = new ActivityIndicatorViewModel();
            BindingContext = ViewModel;

            this.BtnGetData.Clicked += async (sender, args) => await GetDataTaskAsync();
        }

        private async Task GetDataTaskAsync()
        {
            ViewModel.IsBusy = true;
            await Task.Delay(3000);
            ViewModel.IsBusy = false;
        }
    }
}
