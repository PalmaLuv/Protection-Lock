using ProtectionLock.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace ProtectionLock.MVVM.View
{
    public partial class MainPage : UserControl
    {
        public ObservableCollection<ButtonViewModel> Buttons { get; set; } = new ObservableCollection<ButtonViewModel>();

        public MainPage()
        {
            InitializeComponent();
            //DataContext = this;
            //Buttons.Add(new ButtonViewModel("test button", 0, 0));
        }
    }
}
