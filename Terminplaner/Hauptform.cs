using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminplaner
{
    public partial class Hauptform : Form
    {
        public static Hauptform sInstance;

        Controller c = Controller.Instance;
        LoginForm login;
        private Person user;



        public static Hauptform getInstance()
        {
            if (sInstance == null)
            {
                sInstance = new Hauptform();
            }
            return sInstance;
        }

        private Hauptform()
        {
            InitializeComponent();
            (login = new LoginForm(this)).Show();

            this.gridView.DataSource = c.Termine;

            this.terminBox.DataSource = c.getTermintypes();
            this.terminBox.DisplayMember = "Title";
            this.terminBox.ValueMember = "Uid";
        }

        private void new_bt_Click(object sender, EventArgs e)
        {
          
            c.openTerminErstellen(this, user);
        }

        private void Hauptform_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Hide();
        }

        public Person User
        {
            get { return user; }
            set
            {
                user = value;
                c.loadAllTermine(user.Uid);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var typ = this.terminBox.SelectedItem as Termintyp;

            if (typ != null)
            {
                var filtered = (from termin in c.Termine
                                where termin.Type == typ.Uid
                                select termin).ToList();

                gridView.DataSource = filtered;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gridView.DataSource = c.Termine;
        }
    }
}