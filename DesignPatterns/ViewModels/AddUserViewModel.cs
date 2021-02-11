using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Models;
using System.ComponentModel;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using System.Diagnostics;
using OrderedDictionary;

namespace DesignPatterns.ViewModels
{
    class AddUserViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public AddUserViewModel()
        {
            if (Singleton.Database.people.Count == 0)
            {
                User = "";
            }
            else
            {
                User = Singleton.Database.people[people.Keys.Max()];
            }
        }

        private string user;
        public string User
        {
            get { return user; }
            set
            {
                user = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(User)));
            }
        }

        private static ICommand _sendCommand;

        public ICommand SendCommand
        {
            get
            {
                if (_sendCommand == null)
                {
                    // RelayCommand je definovaný v MVVMLight
                    _sendCommand = new RelayCommand(
                        () => {
                            // Tady je práce, která se má odmakat, když se spustí command
                            Debug.WriteLine(User);

                            // Uložení do modelu
                            Singleton.Database.people.Add(;
                        });
                }
                return _sendCommand;
            }
        }

    }
}
