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

namespace Tangerine
{
    public partial class GridViewForm : Form
    {
        string ruta;
        public GridViewForm(string r)
        {
            ruta = r;
            InitializeComponent();
            LlenarListView(ruta);
        }
        public void LlenarListView(string ruta)
        {
            string[] lineas = File.ReadAllLines(ruta);
            bool banderaLlenarColumnas = false;
            double numeroInstancias = 0;
            foreach (var linea in lineas)
            {
                var valores = linea.Split(',');
                if (banderaLlenarColumnas == false)
                {
                    banderaLlenarColumnas = true;
                    for (int i = 0; i < valores.Length; i++)
                    {
                        dataGridView.Columns.Add(valores[i], valores[i]);
                    }
                    ColumnasLabel.Text = valores.Length.ToString();
                }
                else
                {
                    dataGridView.Rows.Add(valores);
                    numeroInstancias++;
                    InstanciasLabel.Text = numeroInstancias.ToString();
                }
            }
            ColorearRows();
        }
        public void ColorearRows()
        {
            for(int i = 0; i < dataGridView.ColumnCount; i++)
            {
                for(int j = 0; j < dataGridView.RowCount; j++)
                {
                    if (dataGridView.Columns[i].Name == "Class" || dataGridView.Columns[i].Name == "CLASS" || dataGridView.Columns[i].Name == "class")
                        dataGridView[i, j].Style.BackColor = Color.GreenYellow;
                    if (dataGridView[i, j].Value == "" || dataGridView[i, j].Value == "?")
                    {
                        dataGridView[i, j].Value = "?";
                        dataGridView[i, j].Style.BackColor = Color.Red;
                    }
                }
            }
        }

        private void AddColumnButton_Click(object sender, EventArgs e)
        {
            dataGridView.Columns.Add(("columna" + (dataGridView.ColumnCount + 1)).ToString(), ("columna" + (dataGridView.ColumnCount + 1)).ToString());
            ColumnasLabel.Text = (double.Parse(ColumnasLabel.Text) + 1).ToString();
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            if (ColumnasLabel.Text != "0")
            {
                dataGridView.Rows.Add();
                InstanciasLabel.Text = (double.Parse(InstanciasLabel.Text) + 1).ToString();
            }
            else
                MessageBox.Show("No es posible añadir instancias si no hay columnas.");
        }

        public void Save(string r)
        {
            //test to see if the DataGridView has any rows
            if (dataGridView.RowCount > 0)
            {
                string value = "";
                DataGridViewRow dr = new DataGridViewRow();
                StreamWriter swOut = new StreamWriter(r);
                //write header rows to csv
                for (int i = 0; i <= dataGridView.Columns.Count - 1; i++)
                {
                    if (i > 0)
                        swOut.Write(",");
                    swOut.Write(dataGridView.Columns[i].HeaderText);
                }
                swOut.WriteLine();
                //write DataGridView rows to csv
                for (int j = 0; j <= dataGridView.Rows.Count - 1; j++)
                {
                    if (j > 0)
                        swOut.WriteLine();
                    dr = dataGridView.Rows[j];
                    for (int i = 0; i <= dataGridView.Columns.Count - 1; i++)
                    {
                        if (i > 0)
                            swOut.Write(",");
                        value = dr.Cells[i].Value.ToString();
                        //replace comma's with spaces
                        value = value.Replace(',', ' ');
                        //replace embedded newlines with spaces
                        value = value.Replace(Environment.NewLine, " ");
                        swOut.Write(value);
                    }
                }
                swOut.Close();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save(ruta);
            MessageBox.Show("El archivo fue guardado con éxito.");
        }

        private void SaveAsButton_Click(object sender, EventArgs e)
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
                    Save(filePath);
                    MessageBox.Show("El archivo fue guardado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DropRowButton.Enabled = true;
        }

        private void DropColumnButton_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Está seguro que desea borrar la columna seleccionada?",
                                            "Borrar columna",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                dataGridView.Columns.RemoveAt(dataGridView.SelectedCells[0].ColumnIndex);
                DropColumnButton.Enabled = false;
                ColumnasLabel.Text = (double.Parse(ColumnasLabel.Text) - 1).ToString();
            }
        }

        private void DropRowButton_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Está seguro que desea borrar la instancia seleccionada?",
                                            "Borrar instancia",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                dataGridView.Rows.Remove(dataGridView.SelectedRows[0]);
                DropRowButton.Enabled = false;
                InstanciasLabel.Text = (double.Parse(InstanciasLabel.Text) -1 ).ToString();
            }
        }

        private void dataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DropColumnButton.Enabled = true;
            for (int r = 0; r < dataGridView.RowCount; r++)
            {
                dataGridView[dataGridView.SelectedCells[0].ColumnIndex, r].Selected = true;
            }
        }

        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            DropColumnButton.Enabled = false;
            DropRowButton.Enabled = false;
        }

        private void GridViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea guardar el programa antes de salir?",
                                            "ATENCIÓN!",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                Save(ruta);
                MessageBox.Show("El archivo fue guardado con éxito.");
            }
        }
    }
}
