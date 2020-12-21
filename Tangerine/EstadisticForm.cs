using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tangerine
{
    public partial class EstadisticForm : Form
    {
        DataGridView dataGrid = new DataGridView();
        List<string> tipoColumna = new List<string>();
        public EstadisticForm(DataGridView dgv, List<string> tc)
        {
            dataGrid = dgv;
            tipoColumna = tc;
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            LlenarComboBox();

        }
        private void llenarAtributosListView()
        {
            //List view para falsos predictores
            atributosListView.Items.Clear();

            string atributoClase = dataGrid.Columns[dataGrid.Columns.Count-1].Name;
            string tipoDatoClase = tipoColumna[tipoColumna.Count - 1];

            for(int i = 0; i < dataGrid.Columns.Count-1; i++)
            {
                ListViewItem auxItem = new ListViewItem(dataGrid.Columns[i].Name);
                auxItem.SubItems.Add(tipoColumna[i]);

                if (tipoDatoClase != "Numérico")
                {
                    if(tipoColumna[i] != "Numérico")
                    {
                        double coeficiente = coeficienteTschuprow(dataGrid.Columns[i].Name, atributoClase);

                        if ( coeficiente >= 0.8)
                        {
                            
                            auxItem.SubItems.Add("Si");
                        }
                        else
                        {
                            auxItem.SubItems.Add("No");
                        }
                    }
                    else
                    {
                        auxItem.SubItems.Add("N/A");
                    }

                }
                else
                {
                    if (tipoColumna[i] == "Numérico")
                    {
                        double coeficiente = correlacionDePearson(dataGrid.Columns[i].Name, atributoClase);

                        if (coeficiente >= 0.8)
                        {

                            auxItem.SubItems.Add("Si");
                        }
                        else
                        {
                            auxItem.SubItems.Add("No");
                        }
                    }
                    else
                    {
                        auxItem.SubItems.Add("N/A");
                    }
                }

                atributosListView.Items.Add(auxItem);
            }

            
        }
        public void LlenarComboBox()
        {
            for(int i = 0; i < dataGrid.ColumnCount; i++)
            {
                AtributoComboBox.Items.Add(dataGrid.Columns[i].Name);
                Atributo1ComboBox.Items.Add(dataGrid.Columns[i].Name);
                Atributo2ComboBox.Items.Add(dataGrid.Columns[i].Name);
            }
        }

        public double Promedio(List<double> datos)
        {
            double promedio = 0;
            for (int i = 0; i < datos.Count; i++)
            {
                promedio += datos[i];
            }
            promedio = promedio / datos.Count;
            return promedio;
        }

        private double mediana(List<double> datos)
        {
            datos.Sort();
            double mediana = datos[datos.Count / 2];
            
            return mediana;
        }

        private double calcularModa(List<double> datos)
        {
            int maxrep = 0;
            double moda = 0;
            for (int i = 0; i < datos.Count; i++)
            {
                int reps = 0;
                for (int j = 0; j < datos.Count; j++)
                {
                    if (datos[i] == datos[j])
                        reps++;
                    if (reps > maxrep)
                    {
                        moda = datos[i];
                        maxrep = reps;
                    }
                }

                
            }

            return moda;
        }
        public double DesviacionEstandar(List<double> datos)
        {
            double promedio = Promedio(datos);
            double desviacionEstandar = 0;

            for (int i = 0; i < datos.Count; i++)
            {
                desviacionEstandar += (datos[i] - promedio) * (datos[i] - promedio);
            }
            desviacionEstandar = desviacionEstandar / datos.Count();
            desviacionEstandar = Math.Sqrt(desviacionEstandar);
            return desviacionEstandar;
        }

        
        public double ChiCuadrada(List<double> frecuenciaEsperada, List<double> frecuenciaObservada)
        {
            double chiCuadrada = 0;
            for (int i = 0; i < frecuenciaEsperada.Count(); i++)
            {
                chiCuadrada += ((frecuenciaObservada[i] - frecuenciaEsperada[i]) * (frecuenciaObservada[i] - frecuenciaEsperada[i]))
                                            / frecuenciaEsperada[i];
            }
            return chiCuadrada;
        }

        private void AtributoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipoColumna[AtributoComboBox.SelectedIndex] == "Numérico")
            {
                List<double> datos = new List<double>();
                for (int i = 0; i < dataGrid.RowCount; i++)
                {
                    if (dataGrid.Rows[i].Cells[AtributoComboBox.SelectedItem.ToString()].Value != null)
                        if (dataGrid.Rows[i].Cells[AtributoComboBox.SelectedItem.ToString()].Value.ToString() != "?")
                            datos.Add(double.Parse(dataGrid.Rows[i].Cells[AtributoComboBox.SelectedItem.ToString()].Value.ToString()));
                }
                mediaLabel.Text = Promedio(datos).ToString("#.####");
                modaLabel.Text = calcularModa(datos).ToString();
                medianaLabel.Text = mediana(datos).ToString();
                desviacionLabel.Text = DesviacionEstandar(datos).ToString("####.####");
                //Gráfica
                //Si ya existe una gráfica, la borramos
                StatChart.Titles.Clear();
                StatChart.Series.Clear();
                StatChart.Titles.Add(AtributoComboBox.Text);
                //Añadir los datos diferentes en la grafica
                StatChart.Series.Add(AtributoComboBox.Text);
                datos.Sort();
                StatChart.Series[0].ChartType = SeriesChartType.BoxPlot;
                double pos1 = datos.Count * .25f;
                double pos2 = datos.Count * .75f;
                int q1 = (int)(pos1);
                int q3 = (int)(pos2);
                StatChart.Series[0].Points.AddXY(0, datos.Min(), datos.Max(), datos[q1], datos[q3]);
                StatChart.Series[0].Label = mediaLabel.Text;
            }
            else
            {
                mediaLabel.Text = "N/A";
                modaLabel.Text = "N/A";
                medianaLabel.Text = "N/A";
                desviacionLabel.Text = "N/A";
                List<string> datos = new List<string>();
                for (int i = 0; i < dataGrid.RowCount; i++)
                {
                    if (dataGrid.Rows[i].Cells[AtributoComboBox.SelectedItem.ToString()].Value != null)
                        if (dataGrid.Rows[i].Cells[AtributoComboBox.SelectedItem.ToString()].Value.ToString() != "?")
                            datos.Add(dataGrid.Rows[i].Cells[AtributoComboBox.SelectedItem.ToString()].Value.ToString());
                }
                //Gráfica
                //hacemos una lista de frecuencias
                Dictionary<string, int> frecuencias = new Dictionary<string, int>();
                foreach (string item in datos)
                {
                    if (frecuencias.ContainsKey(item))
                        frecuencias[item]++;//aumento las ocurrencias
                    else
                        frecuencias.Add(item, 1);//1 porque es la primera ocurrencia
                }
                //Si ya existe una gráfica, la borramos
                progressBar1.Value = 0;
                StatChart.Titles.Clear();
                StatChart.Series.Clear();
                StatChart.Titles.Add(AtributoComboBox.Text);
                //Añadir los datos diferentes en la grafica
                int iter = 0;
                foreach (KeyValuePair<string, int> item in frecuencias)
                {
                    Series serie = StatChart.Series.Add(item.Key.ToString());
                    StatChart.Series[item.Key.ToString()].ChartType = SeriesChartType.Column;
                    serie.Points.AddXY(0, item.Value);
                    progressBar1.Increment((iter / frecuencias.Count()) * 100);
                    serie.Label = item.Value.ToString();
                    iter++;
                }
            }
        }

        ///Análisis Univariable
        
        
        private void obtenerConclusion(double resultado,char opcion)
        {
            string conclusion;
            if (opcion == '1')
            {
                if (resultado == -1)
                {
                    conclusion = "Los atributos '" + Atributo1ComboBox.Text + "' y '" + Atributo2ComboBox.Text + "' tienen una\n" +
                        "correlación lineal negativa perfecta.";
                }
                else if (resultado == 1)
                {
                    conclusion = "Los atributos '" + Atributo1ComboBox.Text + "' y '" + Atributo2ComboBox.Text + "' tienen una\n" +
                        "correlación lineal positiva perfecta.";
                }
                else
                {
                   
                    conclusion = "Los atributos '" + Atributo1ComboBox.Text + "' y '" + Atributo2ComboBox.Text + "' no tienen correlación.";
                    
                }
            }
            else
            {
                if (resultado >= 0.8)
                {
                    conclusion = "Los atributos '" + Atributo1ComboBox.Text + "' y '" + Atributo2ComboBox.Text + "' tienen una completa dependencia.";
                }
                else
                {
                        conclusion = "Los atributos '" + Atributo1ComboBox.Text + "' y '" + Atributo2ComboBox.Text + "' tienen completa independencia";
                    
                }
            }
            

            
            //ConclusionButton.Enabled = true;
            conclusionLabel.Text = conclusion;
        }

        private double correlacionDePearson(string columna1, string columna2)
        {
            //Depositamos las dos columnas en una lista cada una
            List<double> datosA = new List<double>();
            List<double> datosB = new List<double>();
            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                if (dataGrid.Rows[i].Cells[columna1].Value != null)
                    if (dataGrid.Rows[i].Cells[columna1].Value.ToString() != "?")
                        datosA.Add(double.Parse(dataGrid.Rows[i].Cells[columna1].Value.ToString()));

                if (dataGrid.Rows[i].Cells[columna2].Value != null)
                    if (dataGrid.Rows[i].Cells[columna2].Value.ToString() != "?")
                        datosB.Add(double.Parse(dataGrid.Rows[i].Cells[columna2].Value.ToString()));
            }

            double sigma = 0;
            double promedioA = Promedio(datosA);
            double promedioB = Promedio(datosB);
            double desviacionA = DesviacionEstandar(datosA);
            double desviacionB = DesviacionEstandar(datosB);
            //Toma el menor arreglo para las iteraciones
            int datos = 0;
            if (datosA.Count > datosB.Count)
                datos = datosB.Count;
            else
                datos = datosA.Count;
            /*MessageBox.Show("Count A : " + datosA.Count.ToString() 
                + " | " + "Count B : " + datosB.Count.ToString());*/
            //atributosListView.Clear();
            for (int i = 0; i < datos; i++)
            {
                sigma += (datosA[i] - promedioA) * (datosB[i] - promedioB);
            }
            double correlacion = datos * desviacionA * desviacionB;
            //sumatoriaCorrelacionLabel.Text = correlacion.ToString();
            correlacion = sigma / correlacion;

            return correlacion;
            
        }

        private double coeficienteTschuprow(string atributo1, string atributo2)
        {
            //Buscamos los datos a comparar en cada una de las columnas elegidas
            List<string> columnaA = new List<string>();
            List<string> columnaB = new List<string>();

            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                string datoA = dataGrid.Rows[i].Cells[atributo1].Value.ToString();
                string datoB = dataGrid.Rows[i].Cells[atributo2].Value.ToString();

                if (dataGrid.Rows[i].Cells[atributo1].Value != null)
                    if (datoA != "?")
                        if (!buscarRepetidos(datoA, columnaA))
                            columnaA.Add(datoA);

                if (dataGrid.Rows[i].Cells[atributo2].Value != null)
                    if (datoB != "?")
                        if (!buscarRepetidos(datoB, columnaB))
                            columnaB.Add(dataGrid.Rows[i].Cells[atributo2].Value.ToString());
            }

            //Buscamos cuantas veces se repiten comparandose entre sí

            int[,] frecuencias = new int[columnaA.Count + 1, columnaB.Count + 1];
            //Inicializamos la lista de ints
            for (int i = 0; i < columnaA.Count; i++)
                for (int j = 0; j < columnaB.Count; j++)
                    frecuencias[i, j] = 0;
            for (int i = 0; i < columnaA.Count; i++)
            {
                for (int j = 0; j < columnaB.Count; j++)
                {
                    string a = columnaA[i] + columnaB[j];


                    for (int k = 0; k < dataGrid.RowCount; k++)
                    {
                        string b = dataGrid.Rows[k].Cells[atributo1].Value.ToString() +
                        dataGrid.Rows[k].Cells[atributo2].Value.ToString();
                        //Si las cadenas son iguales significa que los datos son iguales y que aparecen juntos
                        if (a == b)
                            frecuencias[i, j]++;
                    }
                    //MessageBox.Show("Frecuencia de " + a + " = " + frecuencias[i, j].ToString());
                }
            }

            int suma = 0;
            for (int i = 0; i < columnaA.Count + 1; i++)
            {
                for (int j = 0; j < columnaB.Count + 1; j++)
                {
                    suma += frecuencias[i, j];
                }

                frecuencias[i, columnaB.Count] = suma;
                //MessageBox.Show("Total = " + frecuencias[i, columnaB.Count].ToString());
                suma = 0;
            }

            suma = 0;
            for (int i = 0; i < columnaB.Count + 1; i++)
            {
                for (int j = 0; j < columnaA.Count + 1; j++)
                {
                    suma += frecuencias[j, i];
                }

                frecuencias[columnaA.Count, i] = suma;
                suma = 0;
            }

            //Creamos la lista de frecuencias observadas
            List<double> frecuenciaObservada = new List<double>();
            for (int i = 0; i < columnaA.Count; i++)
                for (int j = 0; j < columnaB.Count; j++)
                {
                    frecuenciaObservada.Add((double)frecuencias[i, j]);
                }
            //Creamos la lista de frecuencias esperadas
            List<double> frecuenciaEsperada = new List<double>();
            for (int i = 0; i < columnaA.Count; i++)
                for (int j = 0; j < columnaB.Count; j++)
                {
                    double operacion = ((double)frecuencias[i, columnaB.Count] * (double)frecuencias[columnaA.Count, j])
                    / (double)frecuencias[columnaA.Count, columnaB.Count];
                    frecuenciaEsperada.Add(operacion);
                }
            double correlacion = ChiCuadrada(frecuenciaEsperada, frecuenciaObservada);
            correlacion = Math.Sqrt(correlacion / ((frecuencias[columnaA.Count, columnaB.Count]) * (columnaA.Count - 1) * (columnaB.Count - 1)));

            return correlacion;
        }

        private void CalcularBiButton_Click(object sender, EventArgs e)
        {
            if (tipoColumna[Atributo1ComboBox.SelectedIndex] == "Numérico" && tipoColumna[Atributo2ComboBox.SelectedIndex] == "Numérico")
            {
                double correlacion = correlacionDePearson(Atributo1ComboBox.SelectedItem.ToString(), Atributo2ComboBox.SelectedItem.ToString());
                ResultadoLabel.Text = "Correlación: " + correlacion.ToString("#.####");

                obtenerConclusion(correlacion, '1');

            }
            else if(tipoColumna[Atributo1ComboBox.SelectedIndex] != "Numérico" && tipoColumna[Atributo2ComboBox.SelectedIndex] != "Numérico")
            {

                double correlacion = coeficienteTschuprow(Atributo1ComboBox.SelectedItem.ToString(), Atributo2ComboBox.SelectedItem.ToString());
                    ResultadoLabel.Text = "Correlación: " + correlacion.ToString("#.####");
                    
                    //ConclusionButton.Enabled = true;
                obtenerConclusion(correlacion,'2');
            }
            else
            {
                MessageBox.Show("Tipos de dato no compatibles","Error en Calculo de Correlación",MessageBoxButtons.OK,MessageBoxIcon.Error);
                ResultadoLabel.Text = "Correlación: N/A";
                conclusionLabel.Text = "Conclusión: N/A";
            }
        }

        private bool buscarRepetidos(string buscar, List<string> datos)
        {
            foreach(string s in datos)
            {
                if (s == buscar)
                    return true;
            }

            return false;
        }

        ///Parte del analisis bivariable
        private void Atributo1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Atributo2ComboBox.Text != "Selecciona un atributo")
            {
                //CorrelacionRadioButton.Enabled = true;
                //FalsosPredictoresRadioButton.Enabled = true;
                CalcularBiButton.Enabled = true;
            }
        }

        private void Atributo2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Atributo1ComboBox.Text != "Selecciona un atributo")
            {
                //CorrelacionRadioButton.Enabled = true;
                //FalsosPredictoresRadioButton.Enabled = true;
                CalcularBiButton.Enabled = true;
            }
        }

        private void ConclusionButton_Click(object sender, EventArgs e)
        {
            string conclusion = "";
            if (ResultadoLabel.Text == "Correlación: 0")
                conclusion = "No hay correlación lineal";
            else if (ResultadoLabel.Text == "Correlación: 1")
                conclusion = "Hay una correlación lineal positiva perfecta";
            else if (ResultadoLabel.Text == "Correlación: -1")
                conclusion = "Hay una correlación lineal negativa perfecta";
            if(conclusion != "")
                MessageBox.Show(conclusion);
        }

        private void CalcularFalsosButton_Click(object sender, EventArgs e)
        {
            llenarAtributosListView();
        }
    }
}
