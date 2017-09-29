using ClientConvertisseurV2.Service;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConvertisseurV2.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        private WSService client;
        public MainViewModel()
        {
            ActionGetData();
        }

        private async void ActionGetData()
        {
            var result = await client.getAllDevisesAsync();
            ComboBoxDevises = new ObservableCollection<Devise>(result);
        }

        private ObservableCollection<Devise> _comboBoxDevises;
        public ObservableCollection<Devise> ComboBoxDevises
        {
            get { return _comboBoxDevises; }
            set
            {
                _comboBoxDevises = value;
                RaisePropertyChanged();// Pour notifier de la modification de ses données
            }
        }
    }
}
