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
    public partial class Form1 : Form
    {
        Repository repo = new Repository();
        
        public Form1()
        {
            repo.getAllTermine();
            InitializeComponent();
        }
    }
}
