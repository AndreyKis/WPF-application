using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class User
    {
        public string Name { get; private set; }
        public string Patron { get; private set; }
        public string Surname { get; private set; }
        public int AccessLvl { get; private set; }
        public int GroupNumber { get; private set; }
        public string FullName { get; private set; }

        public User()
        {
            
        }

        public User(string name, string patron, string surname, int accesslvl, int group)
        {
            Name = name;
            Patron = patron;
            Surname = surname;
            AccessLvl = accesslvl;
            GroupNumber = group;
            FullName = surname + " " + name + " " + patron;
        }
    }
}
