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

namespace Tut_Darel_Martinez_Caballero
{
    //Darel Martínez Caballero

    public partial class Form1 : Form
    {
        private String nombreArchivo;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            writeFile(this.richTextDocumentos.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtRutaExaminar.Text = Directory.GetCurrentDirectory();
            txtRutaDestino.Text = Directory.GetCurrentDirectory();
            txtRutaDestino.Text = Directory.GetCurrentDirectory();
            actualizar_lista(txtRutaExaminar.Text);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            System.IO.FileInfo thisFile = new FileInfo(this.cbEnviar.SelectedItem.ToString());
            String NewPath = " NewPath holds the path the user has entered.";
            NewPath = txtRutaExaminar.Text;

            string texto = "Los atributos del fichero " + this.cbEnviar.SelectedItem.ToString() + " son : ";
            if (this.chkLongitud.Checked)
            {
                texto = texto + "La longitud del fichero es: " + thisFile.Length.ToString();
            }

            if (this.chkUltimoAcceso.Checked)
            {
                texto = texto + " última modificación fue: " + thisFile.LastAccessTime.ToString();
            }

            if (this.chkGuardar.Checked)
            {
                writeFile(texto);
            }

            MessageBox.Show(texto);
            
        }

        private void rdBtnCarpeta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            String NewPath = " NewPath holds the path the user has entered.";
            String ErrorMessage = null;
            NewPath = this.txtRutaExaminar.Text;
            lbElementos.Items.Clear();
            lbElementos.Refresh();
            // Change the location to NewPath.
            try
            {
                Directory.SetCurrentDirectory(NewPath);
                String sourceDirectory = NewPath;
                this.cbEnviar.Items.Clear();
                this.cbEnviar.Refresh();
                var txtFiles = Directory.EnumerateFiles(sourceDirectory);
                foreach (String currentFile in txtFiles)
                {
                    String fileName = currentFile.Substring(sourceDirectory.Length + 1);
                    this.cbEnviar.Items.Add(fileName);
                }


                //Listar archivos y carpetas
                String rutaDirectorio = String.Empty;

                FolderBrowserDialog fbd = new FolderBrowserDialog();

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    rutaDirectorio = fbd.SelectedPath;
                }

                this.txtRutaExaminar.Text = rutaDirectorio;

                actualizar_lista(rutaDirectorio);
            }
            catch (DirectoryNotFoundException f)
            {
                ErrorMessage = "You must enter a valid path. If trying to access a different drive, remember to include the drive letter.";
            }
            catch
            { //' This checks to make sure the path is not blank.
                ErrorMessage = "You must enter a path.";
            }
            finally
            {
                //' Display the error message only if one exists.
                if (ErrorMessage != null)
                    MessageBox.Show(ErrorMessage);
            }

        }

        private void lbElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.nombreArchivo = "";

            try
            {
                this.nombreArchivo = this.lbElementos.SelectedItem.ToString();
            }
            catch (Exception exception) { }
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            String posicionInicial = this.txtRutaExaminar.Text;
            String posicionFinal = this.txtRutaDestino.Text;

            if (File.Exists(posicionInicial + "\\" + this.nombreArchivo))
            {

                System.IO.File.Move(posicionInicial + "\\" + this.nombreArchivo, posicionFinal + "\\" + this.nombreArchivo);

            }
            else if (Directory.Exists(posicionInicial + "\\" + this.nombreArchivo))
            {

                System.IO.Directory.Move(posicionInicial + "\\" + this.nombreArchivo, posicionFinal + "\\" + this.nombreArchivo);

            }
            else
            {

                MessageBox.Show("No existe");

            }

            actualizar_lista(posicionInicial);

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            actualizar_lista(this.txtRutaExaminar.Text);
        }

        private void actualizar_lista(String directory) {
            this.lbElementos.Items.Clear();
            this.lbElementos.Refresh();
            try
            {
                if (directory.Trim() != String.Empty)
                {
                    DirectoryInfo di = new DirectoryInfo(directory);

                    foreach (var item in di.GetFiles())
                    {
                        this.lbElementos.Items.Add(item.Name);
                    }

                    foreach (var direcotory in di.GetDirectories())
                    {
                        this.lbElementos.Items.Add(direcotory.Name);
                    }
                }
            }
            catch (Exception ex) { }
        }
        public void writeFile(String result)
        {
            String contenido = result;

            

            StreamWriter sw = new StreamWriter(this.txtRutaExaminar.Text + "\\" + this.nombreArchivo);

            sw.WriteLine(contenido);
            sw.Close();

            this.richTextDocumentos.Clear();
            this.lbElementos.Refresh();
            MessageBox.Show("Fichero guardado");
        }

        public void readFile()
        {
            try
            {
                if (File.Exists(this.txtRutaExaminar.Text + "\\" + this.nombreArchivo))
                {
                    StreamReader sr = new StreamReader(this.txtRutaExaminar.Text + "\\" + this.nombreArchivo);

                    String lineas; ;

                    String contenido = "";
                    while ((lineas = sr.ReadLine()) != null)
                    {
                        contenido += lineas;
                    }

                    this.richTextDocumentos.Text = contenido;
                    sr.Close();
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("El archivo no se encuentra");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String nombreArchivo = this.lbElementos.SelectedItem.ToString();
            String rutaArchivo = this.txtRutaExaminar.Text + "\\" + nombreArchivo;

            if (Directory.Exists(rutaArchivo))
            {
                System.IO.DirectoryInfo di = new DirectoryInfo(@rutaArchivo);

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }

                di.Delete();
            }
            if (File.Exists(rutaArchivo))
            {
                File.Delete(rutaArchivo);
            }
            this.actualizar_lista(this.txtRutaExaminar.Text);
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            String rutaFinal = this.txtRutaExaminar.Text + "\\" + this.txtRenombrar.Text;
            try
            {
                if (rdBtnCarpeta.Checked)
                {
                    if (!Directory.Exists(rutaFinal))
                    {
                        MessageBox.Show(rutaFinal);
                    }
                }
                else
                {
                    if (!File.Exists(rutaFinal))
                    {
                        File.Create(rutaFinal);
                    }
                }
            }
            catch (DirectoryNotFoundException ex) { }
            actualizar_lista(this.txtRutaExaminar.Text);
        }

        private void btnRenombrar_Click(object sender, EventArgs e)
        {
            String directory = this.txtRutaExaminar.Text;
            String dirCopy = directory + "\\" + this.nombreArchivo;
            String newNamePath = directory + "\\" + this.txtRenombrar.Text;
            MessageBox.Show(newNamePath);

            string path = @"C:\";



            if (File.Exists(path))

            {
                System.IO.File.Move(dirCopy, newNamePath);
            }

            else if (Directory.Exists(path))

            {
                System.IO.Directory.Move(dirCopy, newNamePath);
            }

            else

            {

                MessageBox.Show("No existe");

            }

            actualizar_lista(directory);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            String rutaFinal = this.txtRutaExaminar.Text + "\\" + this.txtRenombrar.Text;
            try
            {
                if (rdBtnCarpeta.Checked)
                {
                    if (!Directory.Exists(rutaFinal))
                    {
                        MessageBox.Show(rutaFinal);
                        Directory.CreateDirectory(rutaFinal);

                    }
                }
                else
                {
                    if (!File.Exists(rutaFinal))
                    {
                        File.Create(rutaFinal);
                    }
                }
            }
            catch (DirectoryNotFoundException ex) { }
            actualizar_lista(this.txtRutaExaminar.Text);
        }

        private void doublClickSelectItem(object sender, EventArgs e)
        {
            String rutaActual = this.txtRutaExaminar.Text;
            if (File.Exists(rutaActual+"\\"+this.nombreArchivo))
            {
                MessageBox.Show("hola");
                readFile();
            }else if (Directory.Exists(rutaActual + "\\" + this.nombreArchivo))
            {
                this.actualizar_lista(rutaActual + "\\" + this.nombreArchivo);
                this.txtRutaExaminar.Text = rutaActual + "\\" + this.nombreArchivo;
            }
            
        }

        private void cbEnviar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

