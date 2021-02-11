using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Validators;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Models
{
    class ValidationDI
    {
        readonly IIntValidator vekValidator;
        readonly IStringValidator nameValidator;
        readonly IStringValidator surnameValidator;
        readonly IDateTimeValidator dateTimeValidator;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthNo { get; set; }
        public int Age { get; set; }
        public ValidationDI(IStringValidator sv, IStringValidator sv2, IIntValidator iv, IDateTimeValidator dv)
        {
            nameValidator = sv; vekValidator = iv; surnameValidator = sv2; dateTimeValidator = dv;
        }

        public ValidationDI() { vekValidator = null; surnameValidator = null; dateTimeValidator = null; }

        public void DBInput(string name, string surname, string age, DateTime date)
        {
            bool nameOK;
            bool ageOK;
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
                if (string.IsNullOrEmpty(age)) return;
                if (ageOK = vekValidator.IsValid(age, out int vek))
                {
                    this.Age = vek;
                }
            } while (ageOK == false);

            do
            {
                if (birthNoOK = dateTimeValidator.IsValid(date, out string rc))
                {
                    this.BirthNo = rc;
                }
            } while (birthNoOK == false);
        }

        public override string ToString()
        {
            return $"{Name}:{Surname}:{Age}:{BirthNo}";
        }

    }
}
