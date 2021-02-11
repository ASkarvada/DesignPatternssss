using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Validators
{
    class BirthNoValidator1955
    {
        public bool isValid(DateTime d, out string rc)
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
