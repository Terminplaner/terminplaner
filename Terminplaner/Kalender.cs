using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminplaner
{
    class Kalender
    {
        List<Termin> terminList = new List<Termin>();


        public List<Termin> getTerminList()
        {
            return this.terminList;
        }
    }
}
