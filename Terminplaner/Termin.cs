using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Terminplaner
{
    abstract class Termin
    {
        private string title, ort, tempTypeName, beschreibung;
        private int uid, type, person;
        private DateTime endDatum, startDatum;
        public enum TypePool
        { 
            Meeting = 2,
            Urlaub = 3,
            Schulung = 1,
            Aufgabe = 4
        };

        public static Termin create(Termintyp typ, string title, string ort, DateTime start, DateTime ende)
        {
            switch (typ.Uid)
            {
                case 1:
                    return new Schulung(1, title, ort, start, ende, typ.Title);

                case 2:
                    return new Meeting(2, title, ort, start, ende, typ.Title);

                case 3:
                    return new Urlaub(3, title, ort, start, ende, typ.Title);

                default:
                case 4:
                    return new Aufgabe(4, title, ort, start, ende, typ.Title);
            }
        }

        [Browsable(false)]
        public int Uid
        {
            get { return uid; }
            set { uid = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
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

        [Browsable(false)]
        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        [Browsable(false)]
        public int Person
        {
            get { return person; }
            set { person = value; }
        }

        public string TempTypeName
        {
            get { return tempTypeName; }
            set { tempTypeName = value; }
        }

        [Browsable(false)]
        public string Beschreibung
        {
            get { return beschreibung; }
            set { beschreibung = value; }
        }

        abstract public string getDetails();


    }
}
