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
    public partial class LimpiezaForm : Form
    {
        DataGridView lgdv = new DataGridView();
        List<string> tipoColumna = new List<string>();
        Dominios dominios = new Dominios();
        string ruta;

        //.data
        List<string> informacionData;
        public LimpiezaForm(DataGridView dgv, List<string> tc, Dominios d, string r, List<string> infoD)
        {
            lgdv = dgv;
            tipoColumna = tc;
            dominios = d;
            ruta = r;
            informacionData = infoD;
            InitializeComponent();
            LlenarComboBox();
        }
        public void LlenarDataGrid(int index)
        {
            CleanDataGridView.Rows.Clear();
            CleanDataGridView.Columns[0].Name = lgdv.Columns[index].Name;
            CleanDataGridView.Columns[0].HeaderText = lgdv.Columns[index].HeaderText;
            for (int i = 0; i < lgdv.RowCount; i++)
            {
                CleanDataGridView.Rows.Add(lgdv[index, i].Value.ToString());
                CleanDataGridView[0, i].Style.BackColor = lgdv[index, i].Style.BackColor;
            }
        }
        public void LlenarComboBox()
        {
            for (int i = 0; i < lgdv.ColumnCount; i++)
            {
                AtributoComboBox1.Items.Add(lgdv.Columns[i].Name);
                AtributoComboBox2.Items.Add(lgdv.Columns[i].Name);
                AtributoComboBox3.Items.Add(lgdv.Columns[i].Name);
                AtributoComboBox4.Items.Add(lgdv.Columns[i].Name);

                //if(tipoColumna[i] == "Numérico")
                    normalizacionComboBox.Items.Add(lgdv.Columns[i].Name);
            }

            //Inicializamos datos
            numeroInstanciasLabel.Text = lgdv.Rows.Count.ToString();
        }
        public void ColorearOutliers()
        {
            List<double> datos = new List<double>();
            for (int i = 0; i < CleanDataGridView.RowCount; i++)
            {
                if (CleanDataGridView.Rows[i].Cells[AtributoComboBox2.SelectedItem.ToString()].Value != null)
                    if (CleanDataGridView.Rows[i].Cells[AtributoComboBox2.SelectedItem.ToString()].Value.ToString() != "?")
                        datos.Add(double.Parse(CleanDataGridView.Rows[i].Cells[AtributoComboBox2.SelectedItem.ToString()].Value.ToString()));
            }
            datos.Sort();
            double pos1 = datos.Count * .25f;
            double pos2 = datos.Count * .75f;
            int q1 = (int)(pos1);
            int q3 = (int)(pos2);
            double IQR = datos[q3] - datos[q1];
            double promedio = 0;
            for (int j = 0; j < datos.Count; j++)
            {
                promedio += datos[j];
            }
            promedio = promedio / datos.Count;
            ValueLabel.Text = promedio.ToString("#.####");
            IQRLabel.Text = IQR.ToString("#.####");
            for (int j = 0; j < CleanDataGridView.RowCount; j++)
            {
                if (CleanDataGridView[0, j].Value != null)
                {
                    string celda = CleanDataGridView[0, j].Value.ToString();
                    double valor = 0;
                    if (celda != "?" && celda != "")
                    {
                        valor = double.Parse(celda);
                    }
                    if (CleanDataGridView[0, j].Value.ToString() == "" || CleanDataGridView[0, j].Value.ToString() == "?")
                    {
                        CleanDataGridView[0, j].Value = "?";
                        CleanDataGridView[0, j].Style.BackColor = Color.Red;
                    }
                    else if (valor < (datos[q1] - (1.5 * IQR)) || valor > (datos[q3] + (1.5 * IQR)) )
                        CleanDataGridView[0, j].Style.BackColor = Color.SkyBlue;
                    else if (valor < (datos[q1] - (3 * IQR)) || valor > (datos[q3] + (3 * IQR)))
                        CleanDataGridView[0, j].Style.BackColor = Color.Blue;
                    else
                        CleanDataGridView[0, j].Style.BackColor = Color.White;
                }
                else
                {
                    CleanDataGridView[0, j].Value = "?";
                    CleanDataGridView[0, j].Style.BackColor = Color.Red;
                }
            }
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
        public int searchColumn(string columna)
        {
            for (int i = 0; i < lgdv.ColumnCount; i++)
            {
                if (lgdv.Columns[i].Name == columna)
                    return i;
            }
            return -1;
        }

        public int DistanciaLevenshtain(string cadena1, string cadena2)
        {
            int distancia = 0;
            int[,] matriz = new int[cadena2.Length, cadena1.Length];
		    //Se inicializa la primer fila de la matriz con la secuencia 0,1,2,...,x
            for(int i = 0; i < cadena1.Length; i++){
                matriz[0, i] = i;
            }
		    //Se inicializa la primer columna de la matriz con la secuencia 0,1,2,...,Y
            for(int j = 0;j < cadena2.Length; j++){
                matriz[j, 0] = j;
            }
		    //Si h1(j) es igual a h2(i) el costo de la celda es 0.
		    //Si h1(j) es diferente a h2(i) el costo de la celda es 1.
            for(int i = 1; i < cadena2.Length; i++){
                for(int j = 1; j < cadena1.Length; j++){
                    if(cadena1[j] == cadena2[i]){
                        matriz[i, j] = 0;
                    }
                    else{
                        matriz[i, j] = 1;
                    }
                }
            }
		    /* El valor de la celda d(i,j) es el mínimo de:
		     * 	- Valor de la celda (i-1,j) + 1. (eliminación)
		     * 	- Valor de la celda (i,j-1) + 1. (inserción)
		     * 	- Valor de la celda (i-1,j-1) + costo de la celda (i,j). (substitución)
		     */
            int min = 0;
            for(int i = 1; i < cadena2.Length; i++){
                for(int j = 1; j < cadena1.Length; j++){
                    min = minimo(matriz[i - 1, j] + 1, matriz[i, j - 1] + 1);
                    matriz[i, j] = minimo(matriz[i - 1, j - 1] + matriz[i, j], min);
                }
            }
		    distancia = matriz[cadena2.Length - 1, cadena1.Length - 1];
            return distancia;
        }
        public int minimo(int a, int b)
        {
            return a < b ? a : b;
        }
        public string[] GetDominio(int i)
        {
            return dominios[i].Split(',');
        }
        public void SaveCSV()
        {
            int index = searchColumn(CleanDataGridView.Columns[0].Name);
            for (int j = 0; j < CleanDataGridView.RowCount; j++)
            {
                lgdv[index, j].Value = CleanDataGridView[0, j].Value;
            }
            string value = "";
            DataGridViewRow dr = new DataGridViewRow();
            StreamWriter swOut = new StreamWriter(ruta);
            //write header rows to csv
            for (int i = 0; i <= lgdv.Columns.Count - 1; i++)
            {
                if (i > 0)
                    swOut.Write(",");
                swOut.Write(lgdv.Columns[i].HeaderText);
            }
            swOut.WriteLine();
            //write DataGridView rows to csv
            for (int j = 0; j <= lgdv.Rows.Count - 1; j++)
            {
                if (j > 0)
                    swOut.WriteLine();
                dr = lgdv.Rows[j];
                for (int i = 0; i <= lgdv.Columns.Count - 1; i++)
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
        public void SaveData()
        {
            int index = searchColumn(CleanDataGridView.Columns[0].Name);
            for (int j = 0; j < CleanDataGridView.RowCount; j++)
            {
                lgdv[index, j].Value = CleanDataGridView[0, j].Value;
            }


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
            for (int i = 0; i < lgdv.ColumnCount; i++)
            {
                auxCadena = "@attribute " + lgdv.Columns[i].Name + " ";
                auxCadena += tipoColumna[i] + " ";
                auxCadena += dominios[i];

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

            for (int i = 0; i < lgdv.RowCount; i++)
            {
                auxCadena = "";

                for (int j = 0; j < lgdv.ColumnCount; j++)
                {
                    if (j > 0)
                        auxCadena += ',';

                    auxCadena += lgdv.Rows[i].Cells[j].Value.ToString();
                }

                swOut.Write(auxCadena);
                swOut.WriteLine();
            }

            swOut.Close();
        }
        private void LimpiezaButton_Click(object sender, EventArgs e)
        {
            if (tipoColumna[AtributoComboBox1.SelectedIndex] == "Numérico")
            {
                double valor = 0;
                List<double> datos = new List<double>();
                for (int i = 0; i < CleanDataGridView.RowCount; i++)
                {
                    if (CleanDataGridView.Rows[i].Cells[AtributoComboBox1.SelectedItem.ToString()].Value != null)
                        if (CleanDataGridView.Rows[i].Cells[AtributoComboBox1.SelectedItem.ToString()].Value.ToString() != "?")
                            datos.Add(double.Parse(CleanDataGridView.Rows[i].Cells[AtributoComboBox1.SelectedItem.ToString()].Value.ToString()));
                }
                if (MediaRadioButton.Checked)
                {
                    double promedio = 0;
                    for (int j = 0; j < datos.Count; j++)
                    {
                        promedio += datos[j];
                    }
                    promedio = promedio / datos.Count;
                    for (int i = 0; i < CleanDataGridView.RowCount; i++)
                    {
                        if (CleanDataGridView[0, i].Value.ToString() == "?")
                        {
                            CleanDataGridView[0, i].Value = promedio.ToString("#.####");
                            CleanDataGridView[0, i].Style.BackColor = Color.White;
                        }
                    }
                    valor = promedio;
                }
                else if (ModaRadioButton.Checked)
                {
                    /*Dictionary<double, int> frecuencias = new Dictionary<double, int>();
                    foreach (double item in datos)
                    {
                        if (frecuencias.ContainsKey(item))
                            frecuencias[item]++;//aumento las ocurrencias
                        else
                            frecuencias.Add(item, 1);//1 porque es la primera ocurrencia
                    }*/
                    for (int i = 0; i < CleanDataGridView.RowCount; i++)
                    {
                        if (CleanDataGridView[0, i].Value.ToString() == "?")
                        {
                            CleanDataGridView[0, i].Value = datos.Average().ToString("#.####");
                            CleanDataGridView[0, i].Style.BackColor = Color.White;
                        }
                    }
                    valor = datos.Average();
                }
                else
                {
                    datos.Sort();
                    int index = datos.Count / 2;
                    for (int i = 0; i < CleanDataGridView.RowCount; i++)
                    {
                        if (CleanDataGridView[0, i].Value.ToString() == "?")
                        {
                            CleanDataGridView[0, i].Value = datos[index];
                            CleanDataGridView[0, i].Style.BackColor = Color.White;
                        }
                    }
                    valor = datos[index];
                }
                MessageBox.Show("Los valores faltantes fueron llenados con: " + valor);
            }
            else if (tipoColumna[AtributoComboBox1.SelectedIndex] != "Target")
            {
                MessageBox.Show("Se utilizó la moda para llenar los datos faltantes debido a no ser un atributo de tipo numérico.");
                List<string> datos = new List<string>();
                for (int i = 0; i < CleanDataGridView.RowCount; i++)
                {
                    if (CleanDataGridView.Rows[i].Cells[AtributoComboBox1.SelectedItem.ToString()].Value != null)
                        if (CleanDataGridView.Rows[i].Cells[AtributoComboBox1.SelectedItem.ToString()].Value.ToString() != "?")
                            datos.Add(CleanDataGridView.Rows[i].Cells[AtributoComboBox1.SelectedItem.ToString()].Value.ToString());
                }
                Dictionary<string, int> frecuencias = new Dictionary<string, int>();
                foreach (string item in datos)
                {
                    if (frecuencias.ContainsKey(item))
                        frecuencias[item]++;//aumento las ocurrencias
                    else
                        frecuencias.Add(item, 1);//1 porque es la primera ocurrencia
                }
                int valor = frecuencias.Values.Max();
                string llave = frecuencias.Where(p => p.Value == valor).FirstOrDefault().Key;
                for (int i = 0; i < CleanDataGridView.RowCount; i++)
                {
                    if (CleanDataGridView[0, i].Value.ToString() == "?")
                    {
                        CleanDataGridView[0, i].Value = llave;
                        CleanDataGridView[0, i].Style.BackColor = Color.White;
                    }
                }
                MessageBox.Show("Los valores faltantes fueron llenados con: " + llave);
            }
            else
                MessageBox.Show("No es posible llenar los datos de un atributo tipo Target.");
        }

        private void AtributoComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiezaButton.Enabled = true;
            LlenarDataGrid(AtributoComboBox1.SelectedIndex);
        }

        private void AtributoComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarDataGrid(AtributoComboBox2.SelectedIndex);
            if (tipoColumna[AtributoComboBox2.SelectedIndex] == "Numérico")
            {
                ColorearOutliers();
                CorregirOutliersButton.Enabled = true;
            }
            else
            {
                CorregirOutliersButton.Enabled = false;
                ValueLabel.Text = "0";
                IQRLabel.Text = "0";
            }
        }

        private void CorregirOutliersButton_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("El valor sugerido es " + ValueLabel.Text + " .¿Desea reemplazar los outliers?",
                                            "Outliers",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                for (int i = 0; i < CleanDataGridView.RowCount; i++)
                {
                    if (CleanDataGridView[0, i].Style.BackColor == Color.SkyBlue)
                    {
                        CleanDataGridView[0, i].Value = ValueLabel.Text;
                        CleanDataGridView[0, i].Style.BackColor = Color.White;
                    }
                }
            }
        }

        private void AtributoComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarDataGrid(AtributoComboBox3.SelectedIndex);
            ReemplazarButton.Enabled = true;
        }

        private void ReemplazarButton_Click(object sender, EventArgs e)
        {
            string reemplazo = "";
            string buscar = BuscarTextBox.Text;
            if (ReemplazarTextBox.Text == "")
                reemplazo = "?";
            else
                reemplazo = ReemplazarTextBox.Text;
            int encontro = 0;
            var resultado = MessageBox.Show("¿Está seguro que desea cambiar todos los valores '" + buscar + "' por '" + reemplazo + "' ?",
                                            "Reemplazar",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                for (int i = 0; i < CleanDataGridView.RowCount; i++)
                {
                    string valor = CleanDataGridView[0, i].Value.ToString();
                    //if (buscar == valor) reemplaza si encontró la cadena buscada
                    if (valor.Contains(buscar)) //reemplaza si encontró la cadena buscada EN el valor
                    {
                        encontro++;
                        CleanDataGridView[0, i].Value = reemplazo;
                        int index = searchColumn(CleanDataGridView.Columns[0].Name);
                        if (reemplazo == "?")
                            CleanDataGridView[0, i].Style.BackColor = Color.Red;
                        else if (!correspondeDominio(reemplazo, index))
                            CleanDataGridView[0, i].Style.BackColor = Color.OrangeRed;
                        else
                            CleanDataGridView[0, i].Style.BackColor = Color.White;
                    }
                }
                MessageBox.Show("Se encontraron y reemplazaron " + encontro + " resultados");
            }
        }

        private void AtributoComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarDataGrid(AtributoComboBox4.SelectedIndex);
            SugeridoLabel.Text = "";
        }

        private void ReemplazarSugeridoButton_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea utilizar el valor sugerido '" + SugeridoLabel.Text + "' como reemplazo?",
                                            "Reemplazar",
                                            MessageBoxButtons.YesNoCancel,
                                            MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                if (SugeridoLabel.Text == "")
                {
                    MessageBox.Show("No hay valor sugerido.");
                    return;
                }
                int i = CleanDataGridView.SelectedCells[0].RowIndex;
                CleanDataGridView[0, i].Value = SugeridoLabel.Text;
                int index = searchColumn(CleanDataGridView.Columns[0].Name);
                if (CleanDataGridView[0, i].Value.ToString() == "?")
                    CleanDataGridView[0, i].Style.BackColor = Color.Red;
                else if (!correspondeDominio(SugeridoLabel.Text, index))
                    CleanDataGridView[0, i].Style.BackColor = Color.OrangeRed;
                else
                    CleanDataGridView[0, i].Style.BackColor = Color.White;
            }
            else if (resultado == DialogResult.No)
            {
                if (UsuarioValorTextBox.Text != "")
                {
                    int i = CleanDataGridView.SelectedCells[0].RowIndex;
                    CleanDataGridView[0, i].Value = UsuarioValorTextBox.Text;
                    int index = searchColumn(CleanDataGridView.Columns[0].Name);
                    if (CleanDataGridView[0, i].Value.ToString() == "?")
                        CleanDataGridView[0, i].Style.BackColor = Color.Red;
                    else if (!correspondeDominio(UsuarioValorTextBox.Text, index))
                        CleanDataGridView[0, i].Style.BackColor = Color.OrangeRed;
                    else 
                        CleanDataGridView[0, i].Style.BackColor = Color.White;
                }
                else
                    MessageBox.Show("Debe escribir un valor para su reemplazo.");
            }
        }

        private void CleanDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CalcularDistanciaButton.Enabled = true;
            ReemplazarSugeridoButton.Enabled = true;
        }

        private void CalcularDistanciaButton_Click(object sender, EventArgs e)
        {
            int i = CleanDataGridView.SelectedCells[0].RowIndex;
            if (CleanDataGridView[0, i].Style.BackColor == Color.OrangeRed)
            {
                string cadena1 = CleanDataGridView[0, i].Value.ToString();
                int index = searchColumn(CleanDataGridView.Columns[0].Name);
                string[] dominio = GetDominio(index);
                int similar = -1;
                int min = 0;
                for (int j = 0; j < dominio.Count(); j++)
                {
                    int distanciaJ = DistanciaLevenshtain(cadena1, dominio[j]);
                    if (j == 0)
                        min = distanciaJ;
                    if (min >= distanciaJ)
                    {
                        min = distanciaJ;
                        similar = j;
                    }
                }
                SugeridoLabel.Text = dominio[similar];
            }
            CalcularDistanciaButton.Enabled = false;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (ruta.Contains(".csv"))
                SaveCSV();
            else if (ruta.Contains(".data"))
                SaveData();
            MessageBox.Show("Se han aplicado los cambios.");
        }

        private void normalizacionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarDataGrid(normalizacionComboBox.SelectedIndex);
        }
        public double desviacionAbsoluta(List<double> datos,double promedio)
        {
            double desviacionEstandarAbs = 0;

            for (int i = 0; i < datos.Count(); i++)
            {
                desviacionEstandarAbs += Math.Abs(datos[i] - promedio);

            }

            return desviacionEstandarAbs = desviacionEstandarAbs / datos.Count();
        }
        private void zScore()
        {
            List<double> datos = new List<double>();
            //List<double> datosNormalizados = new List<double>();
            EstadisticForm estadisticas = new EstadisticForm(lgdv,tipoColumna);//Ventana para sacar las formulas
            
           for(int i = 0; i < CleanDataGridView.Rows.Count; i++)
            {
                
                datos.Add(double.Parse(CleanDataGridView.Rows[i].Cells[normalizacionComboBox.SelectedItem.ToString()].Value.ToString()));

            }

            double promedio = estadisticas.Promedio(datos);
            double desviacionEstandar = estadisticas.DesviacionEstandar(datos);

            CleanDataGridView.Rows.Clear();
            foreach(double d in datos)
            {
                double normalizado = (d + promedio) / desviacionEstandar;
                CleanDataGridView.Rows.Add(normalizado.ToString("#.####"));

            }
        }

        private void zScoreAbs()
        {
            List<double> datos = new List<double>();
            //List<double> datosNormalizados = new List<double>();
            EstadisticForm estadisticas = new EstadisticForm(lgdv, tipoColumna);//Ventana para sacar las formulas

            for (int i = 0; i < CleanDataGridView.Rows.Count; i++)
            {

                datos.Add(double.Parse(CleanDataGridView.Rows[i].Cells[normalizacionComboBox.SelectedItem.ToString()].Value.ToString()));

            }

            double promedio = estadisticas.Promedio(datos);
            double desviacionEstandar = desviacionAbsoluta(datos,promedio);

            

            CleanDataGridView.Rows.Clear();
            foreach (double d in datos)
            {
                double normalizado = (d + promedio) / desviacionEstandar;
                CleanDataGridView.Rows.Add(normalizado.ToString("#.####"));

            }
        }

        private void minMax()
        {
            List<double> datos = new List<double>();
            //List<double> datosNormalizados = new List<double>();
            //EstadisticForm estadisticas = new EstadisticForm(lgdv, tipoColumna);//Ventana para sacar las formulas

            for (int i = 0; i < CleanDataGridView.Rows.Count; i++)
            {

                //datos.Add(double.Parse(CleanDataGridView.Rows[i].Cells[normalizacionComboBox.SelectedIndex].Value.ToString()));
                if(CleanDataGridView[0, i].Value.ToString() != "?")
                    datos.Add(double.Parse(CleanDataGridView[0, i].Value.ToString()));
            }

            double minNuevo = double.Parse(minTextBox.Text);
            double maxNuevo = double.Parse(maxTextBox.Text);
            double minViejo = datos.Min();
            double maxViejo = datos.Max();


            CleanDataGridView.Rows.Clear();
            foreach (double d in datos)
            {
                double normalizacion = (d - minViejo) / (maxViejo - minViejo);
                normalizacion = normalizacion * (maxNuevo - minNuevo) + minNuevo;
                if (normalizacion == 0)
                    CleanDataGridView.Rows.Add("0");
                else 
                    CleanDataGridView.Rows.Add(normalizacion.ToString("#.####"));

            }

        }
        private void normalizarButton_Click(object sender, EventArgs e)
        {
            LlenarDataGrid(normalizacionComboBox.SelectedIndex);

            if (minMaxRadioButton.Checked)
            {
                minMax();
            }else if (zScoreRadioButton.Checked)
            {
                zScore();
            }else if (zScoreAbsRadioButton.Checked)
            {
                zScoreAbs();
            }
        }

        private void minMaxRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            minTextBox.Enabled = true;
            maxTextBox.Enabled = true;

        }

        private void zScoreRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            minTextBox.Enabled = false;
            maxTextBox.Enabled = false;
        }

        private void zScoreAbsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            minTextBox.Enabled = false;
            maxTextBox.Enabled = false;
        }

        private void generarMuestreoButton_Click(object sender, EventArgs e)
        {
            if (muestreoConRemplazoRadioButton.Checked)
            {
                muestreoConRemplazo();
            }else if (muestreoSinRemplazoRadioButton.Checked)
            {
                muestreoSinRemplazo();
            }
        }

        private void guardarMuestreo(List<int> indexDatos)
        {
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.Filter = "csv files (*.csv)|*.csv|data files (*.data)|*.data";
            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                string value = "";
                DataGridViewRow dr = new DataGridViewRow();
                StreamWriter swOut = new StreamWriter(guardarArchivo.FileName);
                //write header rows to csv
                for (int i = 0; i < lgdv.ColumnCount; i++)
                {
                    if (i > 0)
                        swOut.Write(",");

                    swOut.Write(lgdv.Columns[i].HeaderText);//Tronó
                    

                }
                swOut.WriteLine();

                //write DataGridView rows to csv
                for (int j = 0; j <= indexDatos.Count - 1; j++)
                {
                    if (j > 0)
                        swOut.WriteLine();
                    dr = lgdv.Rows[indexDatos[j]];

                    for (int i = 0; i <= lgdv.Columns.Count - 1; i++)
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

            MessageBox.Show("Muestreo Generado con éxito", "Generar Muestreo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    
        private void muestreoSinRemplazo()
        {
            //Sin repetir
            double cantidad = lgdv.Rows.Count * 0.25;
            List<int> indices = new List<int>();
            Random r = new Random();           


            for (int i = 0; i < cantidad; i++)
            {
                int indexAux = r.Next(0, lgdv.Rows.Count);

                if (indices.Contains(indexAux))
                {
                    //El index ya existe
                    i--;
                }
                else
                {
                    //El index no existe
                    indices.Add(indexAux);
                }              
            }

            //Ordenamos la lista pa que no se pinches tarde
            indices.Sort();

            guardarMuestreo(indices);

        }

        private void muestreoConRemplazo()
        {
            //Repetiendo
            double cantidad = lgdv.Rows.Count * 0.25;
            List<int> indices = new List<int>();
            Random r = new Random();


            for (int i = 0; i < cantidad; i++)
            {
                int indexAux = r.Next(0, lgdv.Rows.Count);

                indices.Add(indexAux);
                
            }

            //Ordenamos la lista pa que no se pinches tarde
            indices.Sort();

            guardarMuestreo(indices);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < CleanDataGridView.RowCount; i++)
            {
                double valor = double.Parse(CleanDataGridView[0, i].Value.ToString());
                if (valor < 0.25)
                    CleanDataGridView[0, i].Value = "impopular";
                else if (0.25 <= valor && valor < 0.75)
                    CleanDataGridView[0, i].Value = "popular";
                else if (valor >= 0.75)
                    CleanDataGridView[0, i].Value = "viral";
            }
        }
    }
}
