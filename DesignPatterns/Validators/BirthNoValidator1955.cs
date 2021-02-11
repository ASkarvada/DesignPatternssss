using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Validators
{
    class BirthNoValidator1955 : IDateTimeValidator
    {
        public bool IsValid(DateTime d, out string rc)
        {
            rc = "000000/000";
            Random ran = new Random();

            if (d.Year > 1955)
            {
                rc = $"{d.ToString("yyMMdd")}/{ran.Next(10)}{ran.Next(10)}{ran.Next(10)}{ran.Next(10)}";
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
