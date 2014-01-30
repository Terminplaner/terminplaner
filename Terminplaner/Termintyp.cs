using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Terminplaner
{
    class Termintyp
    {
        int uid;
        string title;

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

        public Termintyp(int uid, String title)
        {
            this.Uid = uid;
            this.Title = title;
        }
    }
}
