using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAppActivityIndicator.ViewModels
{
    public class ActivityIndicatorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool _isBusy;
        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }
            set
            {                                                                   
                _isBusy = value;
                PropertyChanged(this,new PropertyChangedEventArgs("IsBusy"));
            }
        }
    }
}
