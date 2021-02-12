using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Validators
{
    class BirthNoValidator1954 : IStringValidator
    {
        public bool IsValid(string s)
        {
            char[] c = s.ToCharArray();

            for (int i = 0; i < 6; i++)
            {
                bool b = false;
                for (int j = 0; j < 9; j++)
                {
                    if (c[i].ToString() == j.ToString())
                    { b = true; }
                }
                if (!b) return false;
            }

            if (c[6] != '/') return false;

            for (int i = 7; i < 10; i++)
            {
                bool b = false;
                for (int j = 0; j < 9; j++)
                {
                    if (c[i].ToString() == j.ToString())
                    { b = true; }
                }
                if (!b) return false;
            }
            return true;
            
            
        }
    }
}
