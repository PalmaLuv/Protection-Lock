using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProtectionLock.MWM.ViewModel
{
    public class ButtonViewModel
    {
        public string Content { get; set; }
        public int Row        { get; set; }
        public int Column     { get; set; }

        public ICommand Command { get; set; }

        public ButtonViewModel(string Content, int Row = 0, int Column = 0, ICommand Command = null)
        {
            this.Content = Content;
            this.Row = Row;
            this.Column = Column;
            this.Command = Command;
        }
    }
}
