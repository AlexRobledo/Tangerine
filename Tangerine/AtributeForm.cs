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
    public partial class AtributeForm : Form
    {
        DataGridView adgv = new DataGridView();
        List<string> tipoColumna = new List<string>();
        Dominios dominios = new Dominios();
        string ruta = "";

        //.data
        List<string> informacionData;
        public AtributeForm(DataGridView dgv, List<string> tc, Dominios d, string r,List<string> infoD)
        {
            adgv = dgv;
            tipoColumna = tc;
            dominios = d;
            ruta = r;
            informacionData = infoD;
            InitializeComponent();
            LlenarDataGrid();
            ColumnaNameLabel.Text = AtributoDataGridView.Rows[0].Cells[0].Value.ToString();
            IniciarGrid();
        }

        public DataGridView GetDGV()
        {
            return adgv;
        }
        public List<string> GetTipoColumnas()
        {
            return tipoColumna;
        }
        public Dominios GetDominios()
        {
            return dominios;
        }
        public void LlenarDataGrid()
        {
            for(int i = 0; i < adgv.ColumnCount; i++)
            {
                AtributoDataGridView.Rows.Add(adgv.Columns[i].Name, tipoColumna[i], dominios[i]);
            }
        }
        public void IniciarGrid()
        {
            double[] vF = ValoresFaltantes();
            ValoresFaltantesLabel.Text = vF[0].ToString();
            PorcentajeLlabel.Text = "%" + vF[1].ToString("###.####");
            CountRowLabel.Text = vF[2].ToString();
        }
        public double[] ValoresFaltantes()
        {
            double[] valoresFaltantes = { 0, 0, 0 };
            for (int i = 0; i < adgv.ColumnCount; i++)
            {
                if (adgv.Columns[i].Name == ColumnaNameLabel.Text)
                {
                    for (int j = 0; j < adgv.RowCount; j++)
                    {
                        if (adgv[i, j].Value != null)
                        {
                            if (adgv[i, j].Value.ToString() == "" || adgv[i, j].Value.ToString() == "?")
                            {
                                valoresFaltantes[0]++;
                            }
                        }
                        else
                        {
                            valoresFaltantes[0]++;
                        }
                    }
                }
            }
            valoresFaltantes[1] = (valoresFaltantes[0] / adgv.RowCount)* 100;
            valoresFaltantes[2] = adgv.RowCount;
            return valoresFaltantes;
        }
        public void SaveCSV()
        {
            if (adgv.RowCount > 0)
            {
                string value = "";
                DataGridViewRow dr = new DataGridViewRow();
                StreamWriter swOut = new StreamWriter(ruta);
                //write header rows to csv
                for (int i = 0; i <= adgv.Columns.Count - 1; i++)
                {
                    if (i > 0)
                        swOut.Write(",");
                    swOut.Write(adgv.Columns[i].HeaderText);
                }
                swOut.WriteLine();
                //write DataGridView rows to csv
                for (int j = 0; j <= adgv.Rows.Count - 1; j++)
                {
                    if (j > 0)
                        swOut.WriteLine();
                    dr = adgv.Rows[j];
                    for (int i = 0; i <= adgv.Columns.Count - 1; i++)
                    {
                        if (i > 0)
                            swOut.Write(",");
                        if (dr.Cells[i].Value == null)
                            dr.Cells[i].Value = "?";
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
        public void SaveData()
        {
            

            StreamWriter swOut = new StreamWriter(ruta);

            string auxCadena = "";

            //Escribimos cadena de informacion del dataset
            auxCadena = "%% " + informacionData[0];
            swOut.Write(auxCadena);
            swOut.WriteLine();

            //Escribimos @
            //@relation

            auxCadena = "@relation " + informacionData[1];
            swOut.Write(auxCadena);
            swOut.WriteLine();

            //@attribute
            for (int i = 0; i < AtributoDataGridView.RowCount; i++)
            {
                auxCadena = "@attribute " + AtributoDataGridView.Rows[i].Cells[0].Value.ToString() + " ";
                auxCadena += AtributoDataGridView.Rows[i].Cells[1].Value.ToString() + " ";
                auxCadena += AtributoDataGridView.Rows[i].Cells[2].Value.ToString();

                swOut.Write(auxCadena);
                swOut.WriteLine();
            }

            //@missingValue

            auxCadena = "@missingValue " + informacionData[2];

            swOut.Write(auxCadena);
            swOut.WriteLine();

            //@data

            swOut.Write("@data");
            swOut.WriteLine();

            for (int i = 0; i < adgv.RowCount; i++)
            {
                auxCadena = "";

                for (int j = 0; j < adgv.ColumnCount; j++)
                {
                    if (j > 0)
                        auxCadena += ',';

                    auxCadena += adgv.Rows[i].Cells[j].Value.ToString();
                }

                swOut.Write(auxCadena);
                swOut.WriteLine();
            }

            swOut.Close();
        }

        private void AtributoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ColumnaNameLabel.Text = AtributoDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            IniciarGrid();
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < adgv.ColumnCount; i++)
            {
                foreach(DataGridViewRow instancia in AtributoDataGridView.Rows)
                {
                    if(adgv.Columns[i].Index == instancia.Index)
                    {
                        adgv.Columns[i].Name = instancia.Cells[0].Value.ToString();
                        adgv.Columns[i].HeaderText = adgv.Columns[i].Name;
                        tipoColumna[i] = instancia.Cells[1].Value.ToString();
                        if (instancia.Cells[2].Value != null)
                            dominios[i] = instancia.Cells[2].Value.ToString();
                        else
                            dominios[i] = " ";
                    }
                }
            }
            //Guardamos los cambios en el archivo
            if (ruta.Contains(".csv"))
                SaveCSV();
            else if (ruta.Contains(".data"))
                SaveData();
            //Guardamos los dominios
            string[] filePath = ruta.Split('\\', '.');
            string domainFileName = "Dominio_" + filePath[filePath.Length - 2] + ".bin";
            File.Delete(domainFileName);
            using (Stream s = File.Create(domainFileName))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                formatter.Serialize(s, dominios);
                s.Close();
            }
            //Guardamos los tipos de datos
            string typeFileName = "Tipos_" + filePath[filePath.Length - 2] + ".bin";
            File.Delete(typeFileName);
            using (Stream s = File.Create(typeFileName))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                formatter.Serialize(s, tipoColumna);
                s.Close();
            }

            MessageBox.Show("Se han guardado los cambios.");
        }

        private void AtributoDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                if(tipoColumna[e.RowIndex] == "Numérico")
                {
                    AtributoDataGridView[e.ColumnIndex, e.RowIndex].Value = "Numeric";
                }
                if(AtributoDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString() == "Numérico")
                {
                    if (AtributoDataGridView.Columns["Tipo"].Index == e.ColumnIndex)
                        AtributoDataGridView[e.ColumnIndex + 1, e.RowIndex].Value = "Numeric";
                }
            }
        }
    }
}
