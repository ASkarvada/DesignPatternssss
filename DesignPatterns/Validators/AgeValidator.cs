using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Validators
{
    
    class AgeValidator : IIntValidator
    {
        public bool IsValid(string s, out int retVal)
        {
            retVal = int.MinValue;

            if (int.TryParse(s, out int i) == false) // protože formát
            {
                return false;
            }

            if (i > 0 && i < 120) // protože rozsah
            {
                retVal = i;
                return true;
            }

            return false;
        }
    }
    
}
