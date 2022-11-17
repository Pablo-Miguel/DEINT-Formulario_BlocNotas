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

namespace DEINT_Formulario_BlocNotas
{
    public partial class Form1 : Form
    {

        private String filePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void nuevo()
        {
            txtNotas.Visible = true;
        }

        private void abrir() 
        {
            var fileContent = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            txtNotas.Text = fileContent;

        }

        void guardar() 
        {
            if (!filePath.Equals(String.Empty))
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine(txtNotas.Text);
                }
            }
            else 
            {
                Stream myStream;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        filePath = saveFileDialog1.FileName;
                        myStream.Close();
                        guardar();
                    }
                }
            }
            
        }

        private void menuArchivoSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuArchivoNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void menuImgNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void menuArchivoAbrir_Click(object sender, EventArgs e)
        {
            abrir();
        }

        private void menuImgAbrir_Click(object sender, EventArgs e)
        {
            abrir();
        }

        private void menuArchivoGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void menuImgGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }
    }
}
