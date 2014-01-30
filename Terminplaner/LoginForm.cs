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
    public partial class LoginForm : Form
    {
        Repository repo = new Repository();
        Hauptform mForm;

        public LoginForm(Hauptform newMform)
        {
            mForm = newMform;
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Person mrx = repo.getPersonByName(name_tb.Text);
            if (mrx is Person)
            {
                if (mrx.Passwort == pw_tb.Text)
                {
                    mForm.User = mrx;
                    mForm.user_name.Text = mrx.Name;
                    mForm.Show();
                    mForm.WindowState = FormWindowState.Normal;
                    mForm.Enabled = true;
                    this.Close();
                }
            }
            else
                MessageBox.Show("Error!");
        }
    }
}
