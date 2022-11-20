using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DEINT_Formulario_BlocNotas
{
    public partial class Form1 : Form
    {

        private String filePath = string.Empty;
        private Boolean buscado = false;

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
                openFileDialog.Filter = "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf";
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

            txtNotas.Visible = true;

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

                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf";
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

        private void cortar() {
            txtNotas.Select();
            txtNotas.Cut();
        }

        private void copiar() {
            txtNotas.Select();
            txtNotas.Copy();
        }

        private void pegar() {
            txtNotas.Paste();
        }

        private void buscar() {
            if (!buscado) 
            {
                string input = Interaction.InputBox("Buscar palabras", "Buscar", "", 10, 10);
                if (!input.Equals(String.Empty))
                {

                    string[] words = input.Split(',');
                    foreach (string word in words)
                    {
                        int startindex = 0;
                        while (startindex < txtNotas.TextLength)
                        {
                            int wordstartIndex = txtNotas.Find(word, startindex, RichTextBoxFinds.None);
                            if (wordstartIndex != -1)
                            {
                                txtNotas.SelectionStart = wordstartIndex;
                                txtNotas.SelectionLength = word.Length;
                                txtNotas.SelectionBackColor = Color.Yellow;
                            }
                            else
                                break;
                            startindex += wordstartIndex + word.Length;
                        }
                    }

                }
                buscado = true;
            }
            else 
            {
                txtNotas.SelectionStart = 0;
                txtNotas.SelectAll();
                txtNotas.BackColor = Color.White;
                buscado = false;
            }
            
        }

        private void fuente() {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = txtNotas.Font;
            fontDialog1.Color = txtNotas.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                txtNotas.Font = fontDialog1.Font;
                txtNotas.ForeColor = fontDialog1.Color;
            }
        }

        private void color() {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = txtNotas.ForeColor;

            if (MyDialog.ShowDialog() == DialogResult.OK) { 
                txtNotas.ForeColor = MyDialog.Color;
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

        private void menuEdicionCortar_Click(object sender, EventArgs e)
        {
            cortar();
        }

        private void menuImgCortar_Click(object sender, EventArgs e)
        {
            cortar();
        }

        private void menuEdicionCopiar_Click(object sender, EventArgs e)
        {
            copiar();
        }

        private void menuImgCopiar_Click(object sender, EventArgs e)
        {
            copiar();
        }

        private void menuEdicionPegar_Click(object sender, EventArgs e)
        {
            pegar();
        }

        private void menuImgPegar_Click(object sender, EventArgs e)
        {
            pegar();
        }

        private void menuEdicionBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void menuImgBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void menuEdicionFuente_Click(object sender, EventArgs e)
        {
            fuente();
        }

        private void menuImgFuente_Click(object sender, EventArgs e)
        {
            fuente();
        }

        private void menuEdicionColor_Click(object sender, EventArgs e)
        {
            color();
        }

        private void menuImgColor_Click(object sender, EventArgs e)
        {
            color();
        }

        private void txtNotas_TextChanged(object sender, EventArgs e)
        {
            int posi = txtNotas.SelectionStart;

            int linea = txtNotas.GetLineFromCharIndex(posi);

            int columna = posi - txtNotas.GetFirstCharIndexOfCurrentLine();

            tsLblFila.Text = $"Fila: {linea}";
            tsLblColumna.Text = $"Columna: {columna}";
 
        }
    }
}
