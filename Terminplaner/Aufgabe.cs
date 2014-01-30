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

        public Aufgabe(int uid, String title, String ort, DateTime start, DateTime end, string tempTypeName)
       {
           this.Type = (int)TypePool.Aufgabe;
           this.Title = title;
           this.Uid = uid;
           this.Ort = ort;
           this.StartDatum = start;
           this.EndDatum = end;
           this.TempTypeName = tempTypeName;
       }
    }
}
