using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminplaner
{
    class Teilnehmer
    {

        string name;
        string vorname;

        public String getInfos()
        {
            StringBuilder s = new StringBuilder();
            s.Append(name)
                .Append(Environment.NewLine)
                .Append(vorname);

            return s.ToString();

        }
    }
}
