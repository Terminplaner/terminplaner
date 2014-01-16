using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminplaner
{
    class Urlaub : Termin
    {
        public override string getDetails()
        {
            throw new NotImplementedException();
        }





        public Urlaub(int uid, String ort, DateTime start, DateTime end)
       {
           this.Type = (int)TypePool.Urlaub;
           this.Uid = uid;
           this.Ort = ort;
           this.StartDatum = start;
           this.EndDatum = end;
       }
    }
}
