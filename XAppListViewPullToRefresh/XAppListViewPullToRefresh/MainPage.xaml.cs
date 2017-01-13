using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XAppListViewPullToRefresh.ViewModels;

namespace XAppListViewPullToRefresh
{
    
    public partial class MainPage : ContentPage
    {
        PersonalViewModel _pvm = new PersonalViewModel();
        public MainPage()
        {
            InitializeComponent();

            this.DemoList.ItemsSource = _pvm.Personals;
            this.DemoList.IsPullToRefreshEnabled = true;
            this.DemoList.Refreshing += DemoList_Refreshing;
        }

        private void DemoList_Refreshing(object sender, EventArgs e)
        {
            _pvm.Personals.Add(new Models.Personal()
            {
                No = _pvm.Personals.Count + 1,
                Name = "Ian" + _pvm.Personals.Count + 1
            });
            this.DemoList.IsRefreshing = false;
        }
    }
}
