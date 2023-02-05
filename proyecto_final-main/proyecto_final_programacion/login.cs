using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace proyecto_final_programacion
{

    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        //valida los datos y conexion sql 
        public void logins()
        {
            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            SqlConnection conexion = new SqlConnection(cnn);
            conexion.Open();
            string query = "SELECT UNOMBRE, UCLAVE FROM TBL_USUARIO WHERE UNOMBRE='" + TBL_usuario.Text + "' " +
                "AND UCLAVE='" + TBX_password.Text + "'";

            SqlCommand validar = new SqlCommand(query, conexion);
            SqlDataReader dr = validar.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login exitoso.");
                /*if () { }        futura validacion de admin*/
                new DashBoard().Show();
                this.Hide();//para ocultar no cerrar el login xd
            }
            else
            {
                MessageBox.Show("datos incorrectos.");
            }
            conexion.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            logins();
            //para contar intentos y si llega al maximo se cierra
            int contador = Convert.ToInt32(label1.Text);
            if (contador >= 0)
            {
                contador = contador + 1;
                label1.Text = contador.ToString();
                if (contador == 3)
                {
                    MessageBox.Show("Cantidad de intento agotado");
                    label1.Text = "0";
                    Application.Exit();
                }
            }
        }

        //para que se borre el texto  
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (TBL_usuario.Text == "USUARIO")
            {
                TBL_usuario.Text = "";
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (TBX_password.Text == "PASSWORD")
            {
                TBX_password.Text = "";
                TBX_password.UseSystemPasswordChar = true;//para el password
            }
        }

        //para recuperar el texto borrado
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (TBL_usuario.Text == "")
            {
                TBL_usuario.Text = "USUARIO";
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (TBX_password.Text == "")
            {
                TBX_password.Text = "PASSWORD";
                TBX_password.UseSystemPasswordChar = false;//para el password
            }
        }

        //para cancelar 
        private void BTN_cancelar_Click(object sender, EventArgs e)
        {
            if (TBL_usuario.Text != "USUARIO" || TBX_password.Text != "PASSWORD")
            {
                TBL_usuario.Text = "USUARIO";
                TBX_password.Text = "PASSWORD";
                TBX_password.UseSystemPasswordChar = false;
            }
        }

        //boton cerrar y minimizar
        private void BTN_cerrar_login_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BTN_minimizar_login_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //para el movimiento
        int m, mx, my;
        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }
        private void login_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }
        private void login_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
