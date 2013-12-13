using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminplaner
{
    abstract class Termin
    {
        private int uID;
        private string ort;
        private DateTime startDatum;
        private DateTime endDatum;


        abstract string getDetails();

    }
}
