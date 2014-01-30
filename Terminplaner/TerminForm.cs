using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Terminplaner
{
    public partial class TerminForm : Form
    {
        Controller c = Controller.Instance;
        Hauptform parent;
        Person user;

        public TerminForm(Hauptform pForm, Person pUser)
        {
            InitializeComponent();
            user = pUser;

        }

        private void TerminForm_Load(object sender, EventArgs e)
        {
            ComboBox terminBox = this.termintype;
            terminBox.DataSource = c.getTermintypes();
            terminBox.DisplayMember = "Title";
            terminBox.ValueMember = "Uid";

        }

        private void save_bt_Click(object sender, EventArgs e)
        {
            

            Termin termin = Termin.create((Termintyp)termintype.SelectedItem, title_tb.Text, ort_tb.Text, start_dt.Value, ende_dt.Value);
            c.erstelleTermin(termin, user);
            
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
