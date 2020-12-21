using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Security;

namespace Tangerine
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArchivo;
            abrirArchivo = new OpenFileDialog()
            {
                FileName = "Selecciona_un_archivo",
                Filter = "csv files (*.csv)|*.csv|data files (*.data)|*.data",
                Title = "Abrir archivo"
            };
            if (abrirArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = abrirArchivo.FileName;
                    string[] nombreArchivo = filePath.Split('\\');
                    var fileExtension = Path.GetExtension(filePath);
                    this.Hide();
                    GridViewForm gv = new GridViewForm(filePath,null);
                    gv.Text = nombreArchivo[nombreArchivo.Length-1];
                    gv.ShowDialog();
                    this.Show();
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            Stream myStream;
            guardarArchivo.Filter = "csv files (*.csv)|*.csv|data files (*.data)|*.data";
            guardarArchivo.FilterIndex = 1;
            guardarArchivo.RestoreDirectory = true;
            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = guardarArchivo.FileName;
                    if ((myStream = guardarArchivo.OpenFile()) != null)
                    {
                        myStream.Close();
                    }
                    MessageBox.Show("El archivo fue creado correctamente.");
                    this.Hide();
                    GridViewForm gv = new GridViewForm(filePath,null);
                    gv.ShowDialog();
                    this.Show();
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}
