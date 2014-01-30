using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminplaner
{
    public class Person
    {
        int uid;
        string name, passwort;

        public int Uid
        {
            get { return uid; }
            set { uid = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Passwort
        {
            get { return passwort; }
            set { passwort = value; }
        }

        public Person(int uid, string name, string passwort)
        {
            this.Uid = uid;
            this.Name = name;
            this.Passwort = passwort;
        }

        public bool checkPasswort(string passwort)
        {
            bool ret = false;
            if (passwort == this.Passwort)
                ret = true;
            return ret;
        }

    }
}
