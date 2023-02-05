using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor.Controller
{
    internal class form1Controller
    {
        private String _ArchivoNombre;


        public String abrir() 
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            //filtro para la extencion del archivo
            OpenFile.Filter = "texto | *.txt";
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                this._ArchivoNombre = OpenFile.FileName;
            }
            return this._ArchivoNombre;
        }

        public void guardar(String datos) 
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            //filtro para la extencion del archivo
            SaveFile.Filter = "texto | *.txt";

            if (this._ArchivoNombre != null)
            {
                using (StreamWriter sw = new StreamWriter(this._ArchivoNombre))
                {
                    sw.Write(datos);
                }
            }
            else 
            {
                if (SaveFile.ShowDialog() == DialogResult.OK) 
                {
                    using (StreamWriter sw = new StreamWriter(SaveFile.FileName))
                    {
                        sw.Write(datos);
                    }
                }
            }
        }

        //nuevo archivo
        public String nuevo() 
        {
            this._ArchivoNombre = null;
            return "";
        }

        //cerrar el programa 
        public void cerra(String datos) 
        {
            Environment.Exit(0);
        }       
    }
}
