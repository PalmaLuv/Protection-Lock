using ProtectionLock.Core;
using ProtectionLock.Methods;
using ProtectionLock.MVVM.ViewModel;
using ProtectionLock.window;
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

using static ProtectionLock.Methods.ControlList;

namespace ProtectionLock.MVVM.View
{
    public partial class MainPage : UserControl
    {
        public ObservableCollection<ButtonViewModel> Buttons { get; set; } = new ObservableCollection<ButtonViewModel>();

        public void GetButtonList(ButtonList buttonlist)
        {
            while(buttonlist != null)
            {
                Buttons.Add(buttonlist.buttons);
                buttonlist = buttonlist.prev;
            }
        }

        public MainPage()
        {
            InitializeComponent();
            DataContext = this;

            ControlList dll = new ControlList();
            CommandButton cb = new CommandButton(); 

            dll.addItemList("Add Application", 0, 0, cb.CommandNewButton, "pack://application:,,,/img/plus.png");
            dll.addItemList("new button1", 0, 1, cb.CommandEditApplication);

            GetButtonList(dll.bl);
        }


        /// <summary>
        /// Commands for buttons that are created by the command.
        /// </summary>
        public class CommandButton
        {
            private ICommand _command;

            //Command to call the function of creating a new button.
            public ICommand CommandNewButton
            {
                get
                {
                    _command = null; 
                    if (_command == null)
                        _command = new RelayCommand (param => this.OpenNewWindow());
                    return _command;
                }
            }
            
            public ICommand CommandEditApplication
            {
                get
                {
                    _command = null;
                    if (_command == null)
                        _command = new RelayCommand (param => this.EditApplication());
                    return _command;
                }
            }

            private void OpenNewWindow() 
            {
                new WindowGetInfo().ShowDialog();
            }
            
            private void EditApplication()
            {
                MessageBox.Show("It's empty for now");
            }
        }
    }
}
