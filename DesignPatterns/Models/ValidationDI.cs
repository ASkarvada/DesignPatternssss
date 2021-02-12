using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Validators;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Models
{
    public class ValidationDI
    {
        readonly IDateTimeValidator dateTimeValidator;
        readonly IStringValidator nameValidator;
        readonly IStringValidator surnameValidator;
        readonly IStringValidator birthValidator;

        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthNo { get; set; }
        public DateTime Date { get; set; }
        public ValidationDI(IStringValidator iname, IStringValidator isurname, IStringValidator ibirthNo, IDateTimeValidator idate)
        {
            nameValidator = iname; birthValidator = ibirthNo; surnameValidator = isurname; dateTimeValidator = idate;
        }

        public ValidationDI() { birthValidator = null; nameValidator = null; surnameValidator = null; dateTimeValidator = null; }

        public void DBInput(string name, string surname, string birthNo, DateTime date)
        {
            bool nameOK;
            bool dateOK;
            bool birthNoOK;
            bool surnameOK;

            do
            {
                if (string.IsNullOrEmpty(name)) return;
                if (nameOK = nameValidator.IsValid(name))
                {
                    this.Name = name;
                }
            }
            while (nameOK == false);

            do
            {
                if (string.IsNullOrEmpty(surname)) return;
                if (surnameOK = surnameValidator.IsValid(surname))
                {
                    this.Surname = surname;
                }
            }
            while (surnameOK == false);

            do
            {
                if (string.IsNullOrEmpty(birthNo)) return;
                if (birthNoOK = birthValidator.IsValid(birthNo))
                {
                    this.BirthNo = birthNo;
                }
            } while (birthNoOK == false);

            do
            {
                if (dateOK = dateTimeValidator.IsValid(date))
                {
                    this.Date = date;
                }
            } while (dateOK == false);
        }

        public override string ToString()
        {
            return $"{Name}:{Surname}:{Date}:{BirthNo}";
        }

    }
}
