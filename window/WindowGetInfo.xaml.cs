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
    }
}
