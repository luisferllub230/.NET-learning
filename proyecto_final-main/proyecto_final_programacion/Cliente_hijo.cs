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
    public partial class Cliente_hijo : Form
    {

        public Cliente_hijo()
        {
            InitializeComponent();
        }

        /*------------------------------------------------------------------------------*/
        /*-----------------------aqui todo lo que tiene que ver con db------------------*/
        /*------------------------------------------------------------------------------*/
        string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;

        //para guardar en la base de datos 
        public void conectarDB()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cnn);
                string radioButtonn = "";
                if (radioButton_femenino.Checked)
                {
                    radioButtonn = "FEMENINO";
                }
                else
                {
                    radioButtonn = "MASCULINO";
                }

                conexion.Open();
                string query = "INSERT INTO TBL_CLIENTE VALUES ('" + textBox_cedula.Text + "'," +
                    "'" + textBox_telefono.Text + "','" + textBox_celular.Text + "'," +
                    "'" + textBox_edad.Text + "','" + textBox_direccion.Text + "'," +
                    "'" + comboBoxTcliente.Text + "','" + textBox_nombre.Text + "'," +
                    "'" + textBox_apellido.Text + "','" + radioButtonn + "','" + horaActual.Text + "')";
                SqlCommand insertar = new SqlCommand(query, conexion);
                int comprobador = insertar.ExecuteNonQuery();
                if (comprobador == 1)
                {
                    MessageBox.Show("exito");
                }
                else
                {
                    MessageBox.Show("ERROR :: no se ha podido guardar");
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\n POSIBLEMENTE LA CEDULA YA ESTE REGISTRADA", "ERROR");
            }

        }
        private void BTN_guardar_Click_1(object sender, EventArgs e)
        {
            if (textBox_cedula.Text == "" || textBox_nombre.Text == "" ||
                textBox_apellido.Text == "" || textBox_telefono.Text == ""
                || textBox_edad.Text == "" || textBox_celular.Text == "" || textBox_direccion.Text == ""
                || comboBoxTcliente.Text == "Frecuente/Casual/Nuevo")
            {
                MessageBox.Show("ERROR: DIGITE LOS CAMPOS ");
            }
            else
            {
                conectarDB();
                llenarTabla();
            }
        }

        //moatrar la base de datos 
        public void llenarTabla()
        {
            string consulta = "SELECT * FROM TBL_CLIENTE";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, cnn);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
        }
        private void Cliente_hijo_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }

        //editar
        private void BTN_editar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(cnn);
            string radioButtonn;
            if (radioButton_femenino.Checked)
            {
                radioButtonn = "FEMENINO";
            }
            else
            {
                radioButtonn = "MASCULINO";
            }
            conexion.Open();
            string actualizar = "UPDATE TBL_cliente SET CEDULA='" + textBox_cedula.Text + "'," +
                "telefono='" + textBox_telefono.Text + "',celular='" + textBox_celular.Text + "'," +
                "edad='" + textBox_edad.Text + "',direcciion='" + textBox_direccion.Text + "'," +
                "TipoCliente='" + comboBoxTcliente.Text + "',NOMBRE='" + textBox_nombre.Text + "'," +
                "APELLIDO='" + textBox_apellido.Text + "',sexo='" + radioButtonn + "' " +
                "WHERE CEDULA ='" + textBox_cedula.Text + "'";
            SqlCommand actualizarQ = new SqlCommand(actualizar, conexion);
            if (actualizarQ.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("DATOS ACTUALIZADOS EXICTOSAMENTE");
            }
            else
            {
                MessageBox.Show("ERROR AL ACTUALIZAR LOS DATOS");
            }
            conexion.Close();
            llenarTabla();
        }

        //borrar
        private void BTN_eliminar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(cnn);
            conexion.Open();
            string borrar = "DELETE FROM TBL_cliente WHERE cedula = '" + textBox_cedula.Text + "'";
            SqlCommand borrarQ = new SqlCommand(borrar, conexion);
            if (borrarQ.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("SE HA BORRADO");
            }
            else
            {
                MessageBox.Show("ERROR:: NO se ha podido borrar");
            }
            conexion.Close();

            llenarTabla();
        }

        //buscar datos con el BTN buscar
        private void BTN_buscar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM TBL_cliente WHERE CEDULA LIKE '%" + textBox_buscar.Text + "%' " +
               "OR NOMBRE LIKE '%" + textBox_buscar.Text + "%' OR APELLIDO LIKE '%" + textBox_buscar.Text + "%'" +
               "OR APELLIDO LIKE '%" + textBox_buscar.Text + "%'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, cnn);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "TBL_cliente");
            this.dataGridView1.DataSource = dataSet.Tables[0];
        }

        //buascar datos directamente
        private void textBox_buscar_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM TBL_cliente WHERE CEDULA LIKE '%" + textBox_buscar.Text + "%' " +
                "OR NOMBRE LIKE '%" + textBox_buscar.Text + "%' OR APELLIDO LIKE '%" + textBox_buscar.Text + "%'" +
                "OR APELLIDO LIKE '%" + textBox_buscar.Text + "%'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, cnn);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "TBL_cliente");
            this.dataGridView1.DataSource = dataSet.Tables[0];
        }


        /*------------------------------------------------------------------------------*/
        /*-------------------------todos las funciones basicas--------------------------*/
        /*------------------------------------------------------------------------------*/
        //para cerrar solo este formulario
        private void BTN_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        //para vaciar el formulario
        private void BTN_nuevo_Click(object sender, EventArgs e)
        {
            textBox_nombre.Clear();
            textBox_apellido.Clear();
            textBox_telefono.Clear();
            textBox_edad.Clear();
            textBox_direccion.Clear();
            textBox_celular.Clear();
            textBox_cedula.Clear();
            textBox_buscar.Clear();
            if (comboBoxTcliente.Text != "Frecuente/Casual/Nuevo") { comboBoxTcliente.Text = "Frecuente/Casual/Nuevo"; }
            if (radioButton_masculino.Checked != false) { radioButton_masculino.Checked = false; }
            if (radioButton_femenino.Checked != false) { radioButton_femenino.Checked = false; }
            BTN_guardar.Enabled = false;
        }

        //para guardar la fecha 
        private void timer1_Tick(object sender, EventArgs e)
        {
            horaActual.Text = DateTime.Now.ToLongDateString();
        }

        //keyDown cliente hijo 
        private void Cliente_hijo_KeyDown(object sender, KeyEventArgs e)
        {
            //para no salir con el alt f4
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                e.Handled = true;
            }

            //para salir con el f10
            if (e.KeyCode == Keys.F10)
            {
                new warning().Show();
            }
        }

        //LOAD cliente hijo 
        private void Cliente_hijo_Load_1(object sender, EventArgs e)
        {
            //desactivar el boton busca
            BTN_guardar.Enabled = false;
        }
        private void textBox_cedula_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (textBox_cedula.MaskCompleted)
            {
                BTN_guardar.Enabled = true;
            }
        }

        //avilita el btn guardar


        //para solo aceptar letras
        private void textBox_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) //Al pulsar una letra.            
            {
                e.Handled = true;
            }
        }
        private void textBox_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //para solo aceptar numeros
        private void textBox_edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //para cerrar luego de un tiempo si no se mueve el mouse
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 100;

            int tp;

            tp = Convert.ToInt32(label_timer.Text);
            tp += 1;
            label_timer.Text = tp.ToString();

            if (tp == 500)
            {
                MessageBox.Show("Tiempo de Espera Agotado");
                Application.Exit();

            }
        }
        private void Cliente_hijo_MouseMove(object sender, MouseEventArgs e)
        {
            label_timer.Text = "0";
        }//hay un bug >:,v

    }
}
