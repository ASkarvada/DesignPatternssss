using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public sealed class Singleton
    {
        public Dictionary<string, ValidationDI> people;

        private static Singleton _instance = null;
        private static readonly object padlock = new object();

        private Singleton()
        {
            people = new Dictionary<string, ValidationDI>();
            //people.Add("010213/0812", new Osoba("Marek", "Jarouš", "010213/0812", new DateTime(2001, 2, 13)));
            //people.Add("010213/0812", new Osoba("Marek", "Jarouš", "010213/0812", new DateTime(2001, 2, 13)));
            //people.Add("010213/0812", new Osoba("Marek", "Jarouš", "010213/0812", new DateTime(2001, 2, 13)));
            //people.Add("010213/0812", new Osoba("Marek", "Jarouš", "010213/0812", new DateTime(2001, 2, 13)));
        }

        public static Singleton Database
        {
            get
            {
                lock (padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                    return _instance;
                }
            }
        }
    }
}
