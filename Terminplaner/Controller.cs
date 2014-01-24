using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminplaner
{
    class Controller
    {
        Repository model = new Repository();

        public List<Termin> getTerminList()
        {
            return model.getAllTermine();
        }

        public List<Urlaub> getUrlaub()
        {
            return model.getUrlaubList();

        }

        public List<Meeting> getMeetings()
        {
            return model.getMeetingList();
        }

        public List<Schulung> getSchulungen()
        {
            return model.getSchulungList();
        }



    }
}
