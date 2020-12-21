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
 
        List<string> tipoColumna;//Lista donde se almacenarán los tipos de datos de cada columna
        Dominios dominios;//Lista donde se almacenará el dominio de cada columna

        //Variables de los .data
        string informacionDataSet;
        string relacion;
        char caracterValorFaltante;
        List<string> informacionData;//Lista con todos los atributos
        public GridViewForm(string r,List<string> infoD)
        {
            ruta = r;
            tipoColumna = new List<string>();
            dominios = new Dominios();
            informacionDataSet = "";
            relacion = "";
            informacionData = infoD;
            InitializeComponent();
            inicializar();
            cargarTipoColumna();
        }
        private void inicializar()
        {
            LlenarListView(ruta);

            if (tipoColumna.Count > 0)
                tipoDatoLabel.Text = tipoColumna[0];

            if(informacionData != null)
            {
                informacionDataSet = informacionData[0];
                relacion = informacionData[1];
                caracterValorFaltante = informacionData[2][0];
            }
        }
        private void detectarTipoColumna()
        {
            //Iteramos para cada columna del gridView
            for(int i = 0; i <  dataGridView.Columns.Count; i++)
            {
                List<string> auxFilas = new List<string>();//Lista auxiliar para comparar

                int vecesIterar;
                if(dataGridView.Rows.Count < 100)
                {
                    //Si el data set tiene menos de 100 filas
                    vecesIterar = dataGridView.Rows.Count;
                }
                else
                {
                    //Si el data set tiene más de 100 filas
                    vecesIterar = Convert.ToInt32(dataGridView.Rows.Count * .10);
                }

                for (int k = 0; k < vecesIterar; k++)//Sacamos el 10% de los datos para el muestreo
                    for (int j = 0; j < dataGridView.Rows[i].Cells.Count; j++)
                    {
                        auxFilas.Add(dataGridView.Rows[j].Cells[i].Value.ToString());
                    }
                //Validamos los tipos de datos

                //Validamos si contiene solamente numeros
                if (esNumerico(auxFilas))
                {
                    //Validamos si son solamente unos o ceros (booleanos)
                    if (esBooleano(auxFilas,'1'))
                    {
                        //La columna es booleana con unos y ceros
                        tipoColumna.Add("Booleano");
                    }
                    else
                    {
                        //La columna no solamente contiene unos y ceros
                        tipoColumna.Add("Numérico");
                    }
                }
                else
                {
                    //La columna no contiene solamente números

                    //Validamos si es booleano
                    if (esBooleano(auxFilas, '2'))
                    {
                        //Solamente contiene booleanos de texto
                        tipoColumna.Add("Booleano");
                    }
                    else
                    {
                        //La columna solamente tiene cadenas de texto
                        tipoColumna.Add("Categórico");
                    }
                }
                
                
            }

            /*foreach (string s in tipoColumna)
                MessageBox.Show(s);*/
        }

        private bool esNumerico(List<string> listaStrings)
        {
            foreach (string s in listaStrings)
            {
                if (s != "?")//Validamos que no sea dato vacio
                {
                    int auxInt = 0;
                    if (!(int.TryParse(s, out auxInt)))
                    {
                        //MessageBox.Show(s + " no es entero");
                        //Si no es entero
                        double auxDouble = 0.0;
                        if (!(double.TryParse(s, out auxDouble)))
                        {
                            //Si no es decimal
                            //MessageBox.Show(s + " no es decimal");
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private bool esBooleano(List<string> listaStrings, char op)
        {
            foreach (string s in listaStrings)
            {
                if (s != "?")//Validamos que no sea dato vacio
                {                
                    if(op == '1')
                    {
                        //Validamos booleanos numericos (0 y 1)
                        if (double.Parse(s) != 1 && double.Parse(s) != 0)
                        {
                            //Si alguno de los datos no es uno o cero
                            //MessageBox.Show(s + " no es booleano numerico");
                            return false;
                        }
                    }
                    else
                    {
                        //Validamos booleanos con texto
                        if(s.ToLower() != "true" && s.ToLower() != "false")
                        {
                            //Si el dato no corresponde a la cadena true o false
                           // MessageBox.Show(s + " no es booleano de texto");
                            return false;
                        }
                    }
                }
            }


            return true;
        }
        private void abrirArchivoData(string ruta)
        {
            string[] lineas = File.ReadAllLines(ruta);


            double numeroInstancias = 0;

            bool obtuvoInformacion = false;
            bool obtuvoAtributos = false;

            string aux;
            foreach (var linea in lineas)
            {
                if (!obtuvoInformacion)
                {

                    //Buscamos la información del dataset dentro del string
                    aux = linea[0].ToString() + linea[1].ToString();

                    if (aux == "%%")
                    {
                        string valor = "";
                        for (int i = 2; i < linea.Length; i++)
                        {

                            valor += linea[i];
                        }

                        informacionDataSet += valor;
                    }
                    else
                        obtuvoInformacion = true;

                }

                if (obtuvoInformacion && !obtuvoAtributos)
                {
                    //Buscamos la información de los atributos

                    if (linea.Contains("@relation"))
                    {
                        //Es la especificación de la relación
                        string[] auxRelacion = linea.Split(' ');
                        relacion = auxRelacion[1];

                    }
                    else if (linea.Contains("@attribute"))
                    {
                        string cadena = "";

                        for (int i = 11; i < linea.Length; i++)
                        {
                            cadena += linea[i];
                        }

                        string[] cadenaSplit = cadena.Split(' ');

                        dataGridView.Columns.Add(cadenaSplit[0], cadenaSplit[0]);
                        tipoColumna.Add(cadenaSplit[1]);
                        dominios.Add(cadenaSplit[2]);


                    }
                    else if (linea.Contains("@missingValue"))
                    {
                        //Ver que hacer con los valores perdidos
                        string[] auxMissinValue = linea.Split(' ');
                        caracterValorFaltante = auxMissinValue[1][0];
                    }
                    else
                    {
                        obtuvoAtributos = true;
                    }
                }
                else if (obtuvoAtributos && obtuvoInformacion)
                {
                    //Si ya encontró la información del dataset y de los atributos

                    if (!linea.Contains("@data"))
                    {
                        string[] fila = linea.Split(',');

                        dataGridView.Rows.Add(fila);
                        numeroInstancias++;
                    }
                }



            }

            InstanciasLabel.Text = numeroInstancias.ToString();
            //ColorearRows();
        }

        private void abrirArchivoCsv(string ruta)
        {
            string[] lineas = File.ReadAllLines(ruta);
            bool banderaLlenarColumnas = false;
            double numeroInstancias = 0;

            //Archivos .csv
            foreach (var linea in lineas)
            {
                var valores = linea.Split(',');
                if (!banderaLlenarColumnas)
                {
                    banderaLlenarColumnas = true;
                    for (int i = 0; i < valores.Length; i++)
                    {
                        dataGridView.Columns.Add(valores[i], valores[i]);
                    }
                    ColumnasLabel.Text = valores.Length.ToString();
                    //MessageBox.Show("Agregó Columnas");
                }
                else
                {
                    dataGridView.Rows.Add(valores);
                    numeroInstancias++;
                }
            }
            InstanciasLabel.Text = numeroInstancias.ToString();
            detectarTipoColumna();
            detectarDominio(true);
            ColorearRows();
        }

        public void LlenarListView(string ruta)
        {
            if (ruta.Contains(".csv"))
            {
                abrirArchivoCsv(ruta);
                informacionAdicionalButton.Enabled = false;
            }                
            else
            {
                abrirArchivoData(ruta);
                informacionAdicionalButton.Enabled = true;

            }
                
        }
        public void detectarDominio(bool cargar)//carga dominio o crea uno nuevo
        {
            string[] filePath = ruta.Split('\\', '.');
            string fileName = "Dominio_" + filePath[filePath.Length - 2] + ".bin";
            if(File.Exists(fileName) && cargar)
            {
                using (Stream SP = File.Open(fileName, FileMode.Open))
                {
                    var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    dominios = (Dominios)formatter.Deserialize(SP);
                    SP.Close();
                }
            }
            else
            {
                dominios = new Dominios();
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    List<string> aux = new List<string>();
                    string dominio = "";
                    for (int j = 0; j < dataGridView.RowCount; j++)
                    {
                        if (dataGridView[i, j].Value == null)
                            dataGridView[i, j].Value = "?";
                        if (dataGridView[i, j].Value.ToString() != "?")
                        {
                            if (!aux.Contains(dataGridView[i, j].Value.ToString()))
                            {
                                aux.Add(dataGridView[i, j].Value.ToString());
                                if (j > 0)
                                    dominio += ",";
                                dominio += dataGridView[i, j].Value.ToString();
                            }
                        }
                    }
                    if (tipoColumna[i] != "Numérico")
                        dominios.Add(dominio);
                    else
                        dominios.Add("Numeric");
                }
            }
        }
        public void actualizarDominio(int i)
        {
            List<string> aux = new List<string>();
            string dominio = "";
            for (int j = 0; j < dataGridView.RowCount; j++)
            {
                if (dataGridView[i, j].Value.ToString() != "?")
                {
                    if (!aux.Contains(dataGridView[i, j].Value.ToString()))
                    {
                        aux.Add(dataGridView[i, j].Value.ToString());
                        if (j > 0)
                            dominio += ",";
                        dominio += dataGridView[i, j].Value.ToString();
                    }
                }
            }
            if (tipoColumna[i] != "Numérico")
                dominios[i] = dominio;
            else
                dominios[i] = "Numeric";
        }
        public void cargarTipoColumna()
        {
            string[] filePath = ruta.Split('\\', '.');
            string fileName = "Tipos_" + filePath[filePath.Length - 2] + ".bin";
            if (File.Exists(fileName))
            {
                using (Stream SP = File.Open(fileName, FileMode.Open))
                {
                    var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    tipoColumna = (List<string>)formatter.Deserialize(SP);
                    SP.Close();
                }
            }
        }
        public void ColorearCelda(int i, int j, bool principal)
        {
            if (!principal)
                return;
            double valoresFaltantes = double.Parse(ValoresFaltantesLabel.Text);

            if (dataGridView.Columns[i].Name.ToUpper() == "CLASS")
            {
                dataGridView[i, j].Style.BackColor = Color.GreenYellow;
            }
            if (dataGridView[i, j].Value != null)
            {
                if (dataGridView[i, j].Value.ToString() == "" || dataGridView[i, j].Value.ToString() == "?")
                {
                    dataGridView[i, j].Value = "?";
                    dataGridView[i, j].Style.BackColor = Color.Red;
                    valoresFaltantes++;
                }
                else if (!correspondeDominio(dataGridView[i, j].Value.ToString(), i))
                {
                    if (dataGridView[i, j].Style.BackColor == Color.Red)
                        valoresFaltantes--;
                    dataGridView[i, j].Style.BackColor = Color.OrangeRed;
                }
                else if (dataGridView.Columns[i].Name.ToUpper() != "CLASS")
                {
                    if (dataGridView[i, j].Style.BackColor == Color.Red)
                        valoresFaltantes--;
                    dataGridView[i, j].Style.BackColor = Color.White;
                }
            }
            else
            {
                dataGridView[i, j].Value = "?";
                dataGridView[i, j].Style.BackColor = Color.Red;
                valoresFaltantes++;
            }
            ValoresFaltantesLabel.Text = valoresFaltantes.ToString();
            float colXrow = dataGridView.ColumnCount * dataGridView.RowCount;
            ValoresFaltatesPerLabel.Text = "% " + ((valoresFaltantes / colXrow) * 100).ToString("###.####");
        }
        public void ColorearRows()
        {
            int valoresFaltantes = 0;
            for(int i = 0; i < dataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView.RowCount; j++)
                {
                    if (dataGridView.Columns[i].Name.ToUpper() == "CLASS")
                    {
                        dataGridView[i, j].Style.BackColor = Color.GreenYellow;
                    }
                    if (dataGridView[i, j].Value != null)
                    {
                        if (dataGridView[i, j].Value.ToString() == "" || dataGridView[i, j].Value.ToString() == "?")
                        {
                            dataGridView[i, j].Value = "?";
                            dataGridView[i, j].Style.BackColor = Color.Red;
                            valoresFaltantes++;
                        }
                        else if (!correspondeDominio(dataGridView[i, j].Value.ToString(), i))
                        {
                            dataGridView[i, j].Style.BackColor = Color.OrangeRed;
                        }
                        else if (dataGridView.Columns[i].Name.ToUpper() != "CLASS")
                            dataGridView[i, j].Style.BackColor = Color.White;
                    }
                    else
                    {
                        dataGridView[i, j].Value = "?";
                        dataGridView[i, j].Style.BackColor = Color.Red;
                        valoresFaltantes++;
                    }
                }
            }
            ValoresFaltantesLabel.Text = valoresFaltantes.ToString();
            float colXrow = dataGridView.ColumnCount * dataGridView.RowCount;
            ValoresFaltatesPerLabel.Text ="% " + ((valoresFaltantes / colXrow)*100).ToString("###.####");
        }
        public bool correspondeDominio(string valor, int index)
        {
            if (tipoColumna[index] == "Numérico")
                return true;
            string[] compara = dominios[index].Split(',');
            if (compara.Contains(valor))
                return true;
            return false;
        }

        private void AddColumnButton_Click(object sender, EventArgs e)
        {
            dataGridView.Columns.Add(("columna" + (dataGridView.ColumnCount + 1)).ToString(), ("columna" + (dataGridView.ColumnCount + 1)).ToString());
            ColumnasLabel.Text = (double.Parse(ColumnasLabel.Text) + 1).ToString();
            tipoColumna.Add("Categórico");
            dominios.Add("");
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

        public void SaveCSV(string r)
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
        public void SaveData(string r)
        {
            StreamWriter swOut = new StreamWriter(r);

            string auxCadena = "";

            //Escribimos cadena de informacion del dataset
            auxCadena = "%% " + informacionDataSet;
            swOut.Write(auxCadena);
            swOut.WriteLine();

            //Escribimos @
            //@relation

            auxCadena = "@relation " + relacion;
            swOut.Write(auxCadena);
            swOut.WriteLine();

            //@attribute
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                auxCadena = "@attribute " + dataGridView.Columns[i].Name + " ";
                auxCadena += tipoColumna[i] + " ";
                auxCadena += dominios[i];

                swOut.Write(auxCadena);
                swOut.WriteLine();
            }

            //@missingValue

            auxCadena = "@missingValue " + caracterValorFaltante.ToString();

            swOut.Write(auxCadena);
            swOut.WriteLine();

            //@data

            swOut.Write("@data");
            swOut.WriteLine();

            for(int i = 0; i < dataGridView.RowCount; i++)
            {
                auxCadena = "";

                for(int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    if (j > 0)
                        auxCadena += ',';

                    auxCadena += dataGridView.Rows[i].Cells[j].Value.ToString();
                }

                swOut.Write(auxCadena);
                swOut.WriteLine();
            }

            swOut.Close();
            //MessageBox.Show("");
        }
        public void SaveDominiosTipos()
        {
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
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ruta.Contains(".csv"))
                SaveCSV(ruta);
            else if(ruta.Contains(".data"))
                SaveData(ruta);
            SaveDominiosTipos();
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
                    if (filePath.Contains(".csv"))
                        SaveCSV(filePath);
                    else if (filePath.Contains(".data"))
                        SaveData(filePath);
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
                tipoColumna.RemoveAt(int.Parse(columnIndexLabel.Text)-1);
                dominios.RemoveAt(int.Parse(columnIndexLabel.Text)-1);
                dataGridView.Columns.RemoveAt(int.Parse(columnIndexLabel.Text)-1);
                DropColumnButton.Enabled = false;
                ColumnasLabel.Text = (double.Parse(ColumnasLabel.Text) - 1).ToString();
            }
        }

        private void ModificarColumnButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.ColumnCount > 0)
            {
                informacionData = new List<string>();

                informacionData.Add(informacionDataSet);
                informacionData.Add(relacion);
                informacionData.Add(caracterValorFaltante.ToString());

                AtributeForm af = new AtributeForm(dataGridView, tipoColumna, dominios, ruta, informacionData);
                af.ShowDialog();
            }
            else
                MessageBox.Show("No es posible modificar columnas si no hay.");
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
            DropRowButton.Enabled = false;        }

        private void GridViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea guardar el programa antes de salir?",
                                            "ATENCIÓN!",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                if (ruta.Contains(".csv"))
                    SaveCSV(ruta);
                else if (ruta.Contains(".data"))
                    SaveData(ruta);
                MessageBox.Show("El archivo fue guardado con éxito.");
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cuando se da click en cualquier parte de la celda
            columnIndexLabel.Text = (e.ColumnIndex + 1).ToString();
            rowIndexLabel.Text = (e.RowIndex + 1).ToString();

            if(e.ColumnIndex == -1 || e.RowIndex == -1)
            {
                //Si se dio click en el column header -1
                tipoDatoLabel.Visible = false;
            }
                
            else
            {
                tipoDatoLabel.Visible = true;
                tipoDatoLabel.Text = tipoColumna[e.ColumnIndex].ToString();
                if (dominios[e.ColumnIndex] == "Numeric")
                    DomainLabel.Text = "Numeric";
                else
                    DomainLabel.Text = dominios[e.ColumnIndex];
            }

        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //ColorearRows();
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                ColorearCelda(e.ColumnIndex, e.RowIndex, true);
            else
                ColorearCelda(e.ColumnIndex, e.RowIndex, false);
            //En caso de que sea posible modificar el dominio desde la pantalla principal
            //if (tipoColumna[e.ColumnIndex] != "Numérico")
            //actualizarDominio(e.ColumnIndex);
        }

        private void AnalisisButton_Click(object sender, EventArgs e)
        {
            EstadisticForm analisisForm = new EstadisticForm(dataGridView, tipoColumna);
            analisisForm.Show();
        }

        private void LimpiezaButton_Click(object sender, EventArgs e)
        {
            informacionData = new List<string>();
            
            informacionData.Add(informacionDataSet);
            informacionData.Add(relacion);
            informacionData.Add(caracterValorFaltante.ToString());

            LimpiezaForm limpiezaForm = new LimpiezaForm(dataGridView, tipoColumna, dominios, ruta, informacionData);
            limpiezaForm.ShowDialog();
        }

        private void informacionAdicionalButton_Click(object sender, EventArgs e)
        {
            InformacionAdicionalForm ventana = new InformacionAdicionalForm(informacionDataSet, relacion, caracterValorFaltante);

            ventana.Show();
        }
    }
    [Serializable]
    public class Dominios : List<string>
    {

    }
}
