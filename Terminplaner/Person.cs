using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminplaner
{
    class Person
    {

        int uID;
        string name;
        string vorname;




        public String getDetails()
        {
            
            StringBuilder s = new StringBuilder();
            s.Append(name)
                .Append(Environment.NewLine)
                .Append(vorname);

            return s.ToString();
        }

        public String getName()
        {
            return this.vorname + " " + name;
        }
    }
}
