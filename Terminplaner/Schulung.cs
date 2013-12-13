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

            StringBuilder s = new StringBuilder();

            s.Append(thema);
            s.Append(schulungsleiter.getName());
            if (fullDay)
            {
                s.Append("Schulung überdauert den ganzen Tag");
            }
            return s.ToString();
            
        }
    }
}
