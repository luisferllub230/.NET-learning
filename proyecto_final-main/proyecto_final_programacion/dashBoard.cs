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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            abrirFormulario(new Dashboard_hijo());
        }

        //para el movimiento del DashBoard
        int m, mx, my;
        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }
        private void panelSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }
        private void panelSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        //para minimizar, aumentar  y cerrar
        bool aumentar = true;
        private void BTN_aumentar_Click(object sender, EventArgs e)
        {
            if (aumentar == true)
            {
                this.WindowState = FormWindowState.Maximized;
                aumentar = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                aumentar = true;
            }
        }
        private void BTN_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BTN_cerrar_Click_1(object sender, EventArgs e)
        {
            new warning().Show();
        }

        //feha y hora
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToLongTimeString();//hora
            fecha.Text = DateTime.Now.ToLongDateString();//fecha
        }

        // para cambiar el color cuando se seleccione
        public void seleccionarButonesColor(int boton)
        {
            BTN_DashBoard.ForeColor = Color.FromArgb(15, 15, 15);
            BTN_clientes.ForeColor = Color.FromArgb(15, 15, 15);
            BTN_compras.ForeColor = Color.FromArgb(15, 15, 15);
            BTN_ganacias.ForeColor = Color.FromArgb(15, 15, 15);
            BTN_productos.ForeColor = Color.FromArgb(15, 15, 15);
            BTN_proveedores.ForeColor = Color.FromArgb(15, 15, 15);
            BTN_trabajadores.ForeColor = Color.FromArgb(15, 15, 15);
            BTN_venta.ForeColor = Color.FromArgb(15, 15, 15);

            switch (boton)
            {
                case 1: BTN_DashBoard.ForeColor = Color.FromArgb(87,35,100); break;
                case 2: BTN_clientes.ForeColor = Color.FromArgb(87, 35, 100); break;
                case 3: BTN_compras.ForeColor = Color.FromArgb(87, 35, 100); break;
                case 4: BTN_ganacias.ForeColor = Color.FromArgb(87, 35, 100); break;
                case 5: BTN_productos.ForeColor = Color.FromArgb(87, 35, 100); break;
                case 6: BTN_proveedores.ForeColor = Color.FromArgb(87, 35, 100); break;
                case 7: BTN_trabajadores.ForeColor = Color.FromArgb(87, 35, 100); break;
                case 8: BTN_venta.ForeColor = Color.FromArgb(87, 35, 100); break;
            }
        }
        private void BTN_productos_Click(object sender, EventArgs e)
        {
            seleccionarButonesColor(5);
            Freyja.Top = BTN_productos.Top;
        }
        private void BTN_venta_Click(object sender, EventArgs e)
        {
            seleccionarButonesColor(8);
            Freyja.Top = BTN_venta.Top;
            abrirFormulario(new Ventas_hijo());
        }
        public void BTN_DashBoard_Click(object sender, EventArgs e)
        {
            seleccionarButonesColor(1);
            Freyja.Top = BTN_DashBoard.Top;
            abrirFormulario(new Dashboard_hijo());
        }
        private void BTN_compras_Click(object sender, EventArgs e)
        {
            seleccionarButonesColor(3);
            Freyja.Top = BTN_compras.Top;
        }
        private void BTN_trabajadores_Click(object sender, EventArgs e)
        {
            seleccionarButonesColor(7);
            Freyja.Top = BTN_trabajadores.Top;
        }
        private void BTN_clientes_Click(object sender, EventArgs e)
        {
            seleccionarButonesColor(2);
            Freyja.Top = BTN_clientes.Top;
            abrirFormulario(new Cliente_hijo());
        }
        private void BTN_proveedores_Click(object sender, EventArgs e)
        {
            seleccionarButonesColor(6);
            Freyja.Top = BTN_proveedores.Top;
        }
        private void BTN_ganacias_Click(object sender, EventArgs e)
        {
            seleccionarButonesColor(4);
            Freyja.Top = BTN_ganacias.Top;
        }

        //para abrir un formulario dentro de otro
        private Form FormActivado = null;
        private void abrirFormulario(Form formHijo)
        {
            if(FormActivado != null)
            {
                FormActivado.Close();
            }
            FormActivado = formHijo;
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            panelCentral.Controls.Add(formHijo);
            panelCentral.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();

        }

        //salir con el f10
        private void DashBoard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                new warning().Show();
            }
        }

    }
}
