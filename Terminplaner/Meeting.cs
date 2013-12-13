using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminplaner
{
    class Meeting : Termin
    {

        List<Teilnehmer> teilnehmerListe;

        public String getDetails()
        {
            StringBuilder s = new StringBuilder();

            foreach (Teilnehmer teilnehmer in teilnehmerListe)
            {
                s.Append(teilnehmer.getInfos());
                s.Append(Environment.NewLine);
            }
            return s.ToString();
        }
    }
}
