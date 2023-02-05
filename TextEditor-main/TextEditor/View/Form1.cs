using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEditor.Controller;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        form1Controller c1 = new form1Controller();
       

        public Form1()
        {
            InitializeComponent();
        }

        //abrir un archivo ya existente
        private void Abrir_Click(object sender, EventArgs e)
        {
            string arch = c1.abrir();
            if (arch!=null) 
            {
                using (StreamReader sr = new StreamReader(arch))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                }
            }
        }
        //para guardar un archivo
        private void Guardar_Click(object sender, EventArgs e)
        {
            c1.guardar(richTextBox1.Text);
        }
        //para un nuevo archivo 
        private void nuevo_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = c1.nuevo();
        }
        //para cerrar
        private void Cerrar_Click(object sender, EventArgs e)
        {
            c1.cerra(richTextBox1.Text);
        }
        //para retroceder
        private void Atras_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }
        //adelantar 
        private void Adelantar_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }
        //copiar
        private void Copiar_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        //cortar
        private void Cortar_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        //pegar
        private void Pegar_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        //seleccionar todo
        private void seleccionarTodo_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
        //eliminar todo
        private void eliminarTodo_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        //color
        private void color_Click(object sender, EventArgs e)
        {
            var cl = colorDialog1.ShowDialog();
            if (cl == DialogResult.OK) 
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }
        //formato 
        private void formato_Click(object sender, EventArgs e)
        {
            var fm = fontDialog1.ShowDialog();
            if (fm == DialogResult.OK) 
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }
    }
}
