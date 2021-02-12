using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Validators
{
    
    class DateBirthValidator : IDateTimeValidator
    {
        public bool IsValid(DateTime d)
        {
            if (d.Year < 2050) return true;
            else return false;
        }

    }
    
}
