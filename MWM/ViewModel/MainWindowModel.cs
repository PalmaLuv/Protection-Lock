using ProtectionLock.Core;

namespace ProtectionLock.MWM.ViewModel
{
    class MainWindowModel : ObservableObject
    {
        public RelayCommand MainCommand { get; set; }
        public RelayCommand SettingCommand { get; set; }

        // VM - View Model.
        public MainModel MainVM { get; set; }
        public SettingModel SettingVM { get; set; }

        private object _currecntView;
        public object CurrecntView
        {
            get { return _currecntView; }
            set 
            {
                _currecntView = value;
                OnPropertyChanged();
            }
        }

        public MainWindowModel()
        {
            MainVM = new MainModel();
            SettingVM = new SettingModel();
            CurrecntView = MainVM;

            MainCommand = new RelayCommand(o => { CurrecntView = MainVM; });
            SettingCommand = new RelayCommand(o => { CurrecntView = SettingVM; });
        }
    }
}
