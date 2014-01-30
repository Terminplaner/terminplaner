using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminplaner
{
    class Schulung : Termin
    {
        Person schulungsleiter;
        string thema;
        bool fullDay;
        List<Teilnehmer> teilnehmerList;




        public override string getDetails()
        {
            return "WASD";
        }


        public Schulung(int uid, String title, String ort, DateTime start, DateTime end, string tempTypeName)
       {
           this.Type = (int)TypePool.Schulung;

           this.Uid = uid;
           this.Ort = ort;
           this.Title = title;
           this.StartDatum = start;
           this.EndDatum = end;
           this.TempTypeName = tempTypeName;
       }
    }
}
