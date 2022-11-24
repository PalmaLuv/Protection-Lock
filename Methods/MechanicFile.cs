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
using System.Reflection;
using static ProtectionLock.MVVM.View.MainPage;

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

        public ObservableCollection<ButtonViewModel> Buttons { get; set; } = new ObservableCollection<ButtonViewModel>();

        //Location of [Auto Fill] Buttons.
        private int row     =   0;
        private int column  =   0;

        //Recording to list button parameter.
        public void addItemList(string content, ICommand command, string path = null)
        {
            if (column == 6)
            {
                column = 0;
                row++;
            }
            ButtonList newItem = new ButtonList(new ButtonViewModel(content, row, column, command, path));
            newItem.prev = bl;
            newItem.next = null;
            if (bl != null) bl.next = newItem;
            bl = newItem;
            column++;
        }

        //Button update.
        public void GetButtonList(ButtonList buttonlist)
        {
            Buttons.Clear();
            while (buttonlist != null)
            {
                Buttons.Add(buttonlist.buttons);
                buttonlist = buttonlist.prev;
            }
        }
    }

    public static class MechanicFile
    {
        //todo : Create a form close check.
        //todo : Create update buttons when closing the form "ok button".
        //todo : working method with SQLite.
    }
}
