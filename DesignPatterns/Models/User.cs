using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthNumber { get; set; }
        public DateTime BirthDate { get; set; }

        public User(string name, string surname, string birthNumber, DateTime birthDate)
        {
            Name = name;
            Surname = surname;
            BirthNumber = birthNumber;
            BirthDate = birthDate;
        }
    }
}
