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
using DesignPatterns.Validators;

namespace DesignPatterns.ViewModels
{
    class AddUserViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public AddUserViewModel()
        {
            
        }

        
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        private string surname;
        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Surname)));
            }
        }

        private string birthNo;
        public string BirthNo
        {
            get { return birthNo; }
            set
            {
                birthNo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BirthNo)));
            }
        }

        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Date)));
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
                            ValidationDI u;

                            if(Date.Year < 1954)
                            {
                                u = new ValidationDI(new NameValidator(), new NameValidator(), new AgeValidator(), new BirthNoValidator1954());
                            }
                            else if(Date.Year > 1955)
                            {
                                u = new ValidationDI(new NameValidator(), new NameValidator(), new AgeValidator(), new BirthNoValidator1955());
                            }
                            else
                            {
                                u = new ValidationDI(new NameValidator(), new NameValidator(), new AgeValidator(), new BirthNoValidator1955());
                            }

                            // Uložení do modelu
                            u.DBInput(Name, Surname, BirthNo, Date);
                            Singleton.Database.people.Add(u.BirthNo, u);
                            Debug.WriteLine(u);
                        });
                }
                return _sendCommand;
            }
        }

    }
}
