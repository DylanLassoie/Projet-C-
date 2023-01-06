using Projet_c_.Core;
using System;

namespace Projet_c_.MVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public PlayerHomeViewModel PlayerHomeVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { 
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            PlayerHomeVM = new PlayerHomeViewModel();
            CurrentView = PlayerHomeVM;
        }
    }
}
