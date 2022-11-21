using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using ProtectionLock.MVVM.ViewModel;
using ProtectionLock.MVVM.View;
using System.Windows.Input;

namespace ProtectionLock.Methods
{
    //List management.
    public class ControlList
    {
        /// <summary>
        /// Bilateral list.
        /// next / prev - list navigation.
        /// </summary>
        public class ButtonList
        {
            public ButtonList next { get; set; }
            public ButtonList prev { get; set; }

            public ButtonViewModel buttons { get; set; }

            public ButtonList(ButtonViewModel buttons)
            {
                this.buttons = buttons;     
            }
        }

        public ButtonList bl;
        public MainPage mp;

        //Recording to list button parameter.
        public void addItemList(string content, int row, int column, ICommand command, string path = null)
        {
            ButtonList newItem = new ButtonList(new ButtonViewModel(content, row, column, command, path));
            newItem.prev = bl;
            newItem.next = null;
            if (bl != null) bl.next = newItem;
            bl = newItem;
        }

    }

    public class MechanicFile
    {
        //todo : working method with SQLite.
    }
}
