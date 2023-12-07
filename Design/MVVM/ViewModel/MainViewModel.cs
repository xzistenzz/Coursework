using Design.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand AdditionalViewCommand { get; set; }
        public RelayCommand AdminViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public AdditionalViewModel AdditionalVM { get; set; }
        public AdminViewModel AdminVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel() 
        {
            HomeVM = new HomeViewModel();
            AdditionalVM = new AdditionalViewModel();
            AdminVM = new AdminViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            AdditionalViewCommand = new RelayCommand(o =>
            {
                CurrentView = AdditionalVM;
            });

            AdminViewCommand = new RelayCommand(o =>
            {
                CurrentView = AdminVM;
            });
        }
    }
}
