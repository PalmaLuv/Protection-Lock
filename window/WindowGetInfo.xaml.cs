using ProtectionLock.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static ProtectionLock.MVVM.View.MainPage;

namespace ProtectionLock.window
{
    public partial class WindowGetInfo : Window
    {
        public WindowGetInfo()
        {
            InitializeComponent();
        }

        private void ButtonExit(object sender, RoutedEventArgs e) => this.Close();
        private void MouseHeader(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();
        }

        private void ProgramOpening(object sender, RoutedEventArgs e)
        {
            string path = ""; 

            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "Text documents (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.FilterIndex = 2;

            Nullable<bool> result = dialog.ShowDialog();

            if (result == true)
            {
                path = dialog.FileName;
            }
            LocationTextBox.Text = path;
        }

        private void AddApplication(object sender, RoutedEventArgs e)
        {
            ControlList dll = new ControlList();
            CommandButton cb = new CommandButton();

            dll.addItemList(ProgramsName.Text, cb.CommandEditApplication);
            dll.GetButtonList(dll.bl);
            this.Close();
        }
    }
}
