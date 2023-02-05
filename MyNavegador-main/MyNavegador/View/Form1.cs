using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNavegador
{
    public partial class MyNavegador : Form
    {
        List<string> fav = new List<string>();

        public MyNavegador()
        {
            InitializeComponent();
        }

        private void rButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void aButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void recargarButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtUrl.Text);
        }

        private void favoritosButton_Click(object sender, EventArgs e)
        {
            fav.Add(webBrowser1.Url.ToString());
            addCombobox();
        }

        private void addCombobox() 
        {
            foreach (String i in fav) 
            {
                favoritosCB.Items.Add(i);
            }
        }

        private void favoritosCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(favoritosCB.SelectedItem.ToString());
        }
    }
}
