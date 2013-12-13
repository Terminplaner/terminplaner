using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminplaner
{
    class Aufgabe : Termin
    {
        String ansprechPartner;
        String beschreibung;


        public override String getDetails()
        {
            StringBuilder s = new StringBuilder();
            s.Append(ansprechPartner)
                .Append(beschreibung);

            return s.ToString();
        }
    }
}
