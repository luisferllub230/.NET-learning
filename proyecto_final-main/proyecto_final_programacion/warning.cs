using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_programacion
{
    public partial class warning : Form
    {
        public warning()
        {
            InitializeComponent();
        }

        private void BTN_si_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
