using ProtectionLock.Core;

namespace ProtectionLock.MVVM.ViewModel
{
    class MainWindowModel : ObservableObject
    {
        // Model switching commands.
        public RelayCommand MainCommand { get; set; }
        public RelayCommand SettingCommand { get; set; }

        // VM - View Model.
        public MainModel MainVM { get; set; }
        public SettingModel SettingVM { get; set; }

        private object _currecntView;
        public object CurrentView
        {
            get { return _currecntView; }
            set 
            {
                _currecntView = value;
                OnPropertyChanged();
            }
        }
        // Switching between models.
        public MainWindowModel()
        {
            MainVM = new MainModel();
            SettingVM = new SettingModel();
            CurrentView = MainVM;

            MainCommand = new RelayCommand(o => { CurrentView = MainVM; });
            SettingCommand = new RelayCommand(o => { CurrentView = SettingVM; });
        }
    }
}
