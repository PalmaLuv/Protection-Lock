using System.Windows.Input;

namespace ProtectionLock.MVVM.ViewModel
{
    public class ButtonViewModel
    {
        //Settings the button. 
        public string Content { get; set; }
        public int Row        { get; set; }
        public int Column     { get; set; }

        //Command to be executed by the button.
        public ICommand Command { get; set; }

        //Accepting settings.
        public ButtonViewModel(string Content, int Row = 0, int Column = 0, ICommand Command = null)
        {
            this.Content = Content;
            this.Row = Row;
            this.Column = Column;
            this.Command = Command;
        }
    }
}
