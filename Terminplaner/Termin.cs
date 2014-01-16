using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminplaner
{
    abstract class Termin
    {
        private int uid, type;
        private DateTime endDatum;
        private string ort;
        private DateTime startDatum;
        public enum TypePool { Meeting, Urlaub, Schulung };

        public int Uid
        {
            get { return uid; }
            set { uid = value; }
        }

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Ort
        {
            get { return ort; }
            set { ort = value; }
        }

        public DateTime StartDatum
        {
            get { return startDatum; }
            set { startDatum = value; }
        }

        public DateTime EndDatum
        {
            get { return endDatum; }
            set { endDatum = value; }
        }


        abstract public string getDetails();


    }
}
