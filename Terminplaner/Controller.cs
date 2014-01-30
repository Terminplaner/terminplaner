using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminplaner
{
    class Controller
    {
        private static Controller instance;
        Repository repo = new Repository();

        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }

        private Controller()
        {
            this.Termine = new BindingList<Termin>();
        }
        

        public void loadAllTermine(int puid)
        {
            var termine = repo.getAllTermine(puid);
            bool notify = this.Termine.RaiseListChangedEvents;

            try
            {
                this.Termine.RaiseListChangedEvents = false;

                foreach (var termin in termine)
                {
                    this.Termine.Add(termin);
                }
            }
            finally
            {
                this.Termine.RaiseListChangedEvents = notify;
                this.Termine.ResetBindings();
            }
        }

        public List<Termintyp> getTermintypes()
        {
            return repo.getAllTermintypes();
        }

        public void erstelleTermin(Termin termin, Person person)
        {
            repo.erstelleTermin(termin, person);
            this.Termine.Add(termin);
        }

        public void openTerminErstellen(Hauptform mForm, Person user)
        {
            TerminForm newForm = new TerminForm(mForm, user);
            newForm.Show();
        }

        public BindingList<Termin> Termine { get; private set; }
    }
}
