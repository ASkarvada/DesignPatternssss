using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Validators
{
    class NameValidator : IStringValidator
    {
        public bool IsValid(string s) { return s.Length > 1; }
    }
}
