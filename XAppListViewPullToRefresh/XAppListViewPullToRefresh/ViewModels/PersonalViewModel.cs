using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAppListViewPullToRefresh.Models;

namespace XAppListViewPullToRefresh.ViewModels
{
    public class PersonalViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Personal> _personals = new ObservableCollection<Personal>();
        public ObservableCollection<Personal> Personals
        {
            get
            {
                return _personals;
            }
            set
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Personals"));
            }
        }

        public PersonalViewModel()
        {
           GetData();
        }
        void GetData()
        {
            _personals.Add(new Personal()
            {
                No = 1,
                Name = "Ian"
            });
        }
    }
}
