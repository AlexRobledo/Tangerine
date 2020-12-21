namespace Tangerine
{
    partial class EstadisticForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.AnalisisUniGroupBox = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.desviacionLabel = new System.Windows.Forms.Label();
            this.modaLabel = new System.Windows.Forms.Label();
            this.medianaLabel = new System.Windows.Forms.Label();
            this.mediaLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AtributoComboBox = new System.Windows.Forms.ComboBox();
            this.AnalisisBiGroupBox = new System.Windows.Forms.GroupBox();
            this.Atributo2ComboBox = new System.Windows.Forms.ComboBox();
            this.Atributo1ComboBox = new System.Windows.Forms.ComboBox();
            this.ResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.conclusionLabel = new System.Windows.Forms.Label();
            this.ResultadoLabel = new System.Windows.Forms.Label();
            this.CalcularBiButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StatChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.atributosListView = new System.Windows.Forms.ListView();
            this.atributoColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipoColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.falsoHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CalcularFalsosButton = new System.Windows.Forms.Button();
            this.AnalisisUniGroupBox.SuspendLayout();
            this.AnalisisBiGroupBox.SuspendLayout();
            this.ResultsGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatChart)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnalisisUniGroupBox
            // 
            this.AnalisisUniGroupBox.Controls.Add(this.progressBar1);
            this.AnalisisUniGroupBox.Controls.Add(this.desviacionLabel);
            this.AnalisisUniGroupBox.Controls.Add(this.modaLabel);
            this.AnalisisUniGroupBox.Controls.Add(this.medianaLabel);
            this.AnalisisUniGroupBox.Controls.Add(this.mediaLabel);
            this.AnalisisUniGroupBox.Controls.Add(this.label4);
            this.AnalisisUniGroupBox.Controls.Add(this.label3);
            this.AnalisisUniGroupBox.Controls.Add(this.label2);
            this.AnalisisUniGroupBox.Controls.Add(this.label1);
            this.AnalisisUniGroupBox.Controls.Add(this.AtributoComboBox);
            this.AnalisisUniGroupBox.Location = new System.Drawing.Point(9, 8);
            this.AnalisisUniGroupBox.Name = "AnalisisUniGroupBox";
            this.AnalisisUniGroupBox.Size = new System.Drawing.Size(644, 202);
            this.AnalisisUniGroupBox.TabIndex = 0;
            this.AnalisisUniGroupBox.TabStop = false;
            this.AnalisisUniGroupBox.Text = "Mediciones Estándar";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(394, 162);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(242, 25);
            this.progressBar1.TabIndex = 15;
            // 
            // desviacionLabel
            // 
            this.desviacionLabel.AutoSize = true;
            this.desviacionLabel.Location = new System.Drawing.Point(195, 162);
            this.desviacionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.desviacionLabel.Name = "desviacionLabel";
            this.desviacionLabel.Size = new System.Drawing.Size(13, 20);
            this.desviacionLabel.TabIndex = 14;
            this.desviacionLabel.Text = ".";
            // 
            // modaLabel
            // 
            this.modaLabel.AutoSize = true;
            this.modaLabel.Location = new System.Drawing.Point(195, 131);
            this.modaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modaLabel.Name = "modaLabel";
            this.modaLabel.Size = new System.Drawing.Size(13, 20);
            this.modaLabel.TabIndex = 13;
            this.modaLabel.Text = ".";
            // 
            // medianaLabel
            // 
            this.medianaLabel.AutoSize = true;
            this.medianaLabel.Location = new System.Drawing.Point(195, 100);
            this.medianaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.medianaLabel.Name = "medianaLabel";
            this.medianaLabel.Size = new System.Drawing.Size(13, 20);
            this.medianaLabel.TabIndex = 12;
            this.medianaLabel.Text = ".";
            // 
            // mediaLabel
            // 
            this.mediaLabel.AutoSize = true;
            this.mediaLabel.Location = new System.Drawing.Point(195, 68);
            this.mediaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mediaLabel.Name = "mediaLabel";
            this.mediaLabel.Size = new System.Drawing.Size(13, 20);
            this.mediaLabel.TabIndex = 11;
            this.mediaLabel.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Desviación Estándar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Moda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mediana:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Media:";
            // 
            // AtributoComboBox
            // 
            this.AtributoComboBox.FormattingEnabled = true;
            this.AtributoComboBox.Location = new System.Drawing.Point(8, 26);
            this.AtributoComboBox.Name = "AtributoComboBox";
            this.AtributoComboBox.Size = new System.Drawing.Size(192, 28);
            this.AtributoComboBox.TabIndex = 0;
            this.AtributoComboBox.Text = "Selecciona un atributo";
            this.AtributoComboBox.SelectedIndexChanged += new System.EventHandler(this.AtributoComboBox_SelectedIndexChanged);
            // 
            // AnalisisBiGroupBox
            // 
            this.AnalisisBiGroupBox.Controls.Add(this.Atributo2ComboBox);
            this.AnalisisBiGroupBox.Controls.Add(this.Atributo1ComboBox);
            this.AnalisisBiGroupBox.Controls.Add(this.ResultsGroupBox);
            this.AnalisisBiGroupBox.Controls.Add(this.CalcularBiButton);
            this.AnalisisBiGroupBox.Location = new System.Drawing.Point(8, 8);
            this.AnalisisBiGroupBox.Name = "AnalisisBiGroupBox";
            this.AnalisisBiGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AnalisisBiGroupBox.Size = new System.Drawing.Size(645, 248);
            this.AnalisisBiGroupBox.TabIndex = 1;
            this.AnalisisBiGroupBox.TabStop = false;
            this.AnalisisBiGroupBox.Text = "Relación de Atributos";
            // 
            // Atributo2ComboBox
            // 
            this.Atributo2ComboBox.FormattingEnabled = true;
            this.Atributo2ComboBox.Location = new System.Drawing.Point(226, 26);
            this.Atributo2ComboBox.Name = "Atributo2ComboBox";
            this.Atributo2ComboBox.Size = new System.Drawing.Size(193, 28);
            this.Atributo2ComboBox.TabIndex = 8;
            this.Atributo2ComboBox.Text = "Selecciona un atributo";
            this.Atributo2ComboBox.SelectedIndexChanged += new System.EventHandler(this.Atributo2ComboBox_SelectedIndexChanged);
            // 
            // Atributo1ComboBox
            // 
            this.Atributo1ComboBox.FormattingEnabled = true;
            this.Atributo1ComboBox.Location = new System.Drawing.Point(6, 26);
            this.Atributo1ComboBox.Name = "Atributo1ComboBox";
            this.Atributo1ComboBox.Size = new System.Drawing.Size(193, 28);
            this.Atributo1ComboBox.TabIndex = 7;
            this.Atributo1ComboBox.Text = "Selecciona un atributo";
            this.Atributo1ComboBox.SelectedIndexChanged += new System.EventHandler(this.Atributo1ComboBox_SelectedIndexChanged);
            // 
            // ResultsGroupBox
            // 
            this.ResultsGroupBox.Controls.Add(this.conclusionLabel);
            this.ResultsGroupBox.Controls.Add(this.ResultadoLabel);
            this.ResultsGroupBox.Location = new System.Drawing.Point(9, 71);
            this.ResultsGroupBox.Name = "ResultsGroupBox";
            this.ResultsGroupBox.Size = new System.Drawing.Size(627, 165);
            this.ResultsGroupBox.TabIndex = 2;
            this.ResultsGroupBox.TabStop = false;
            this.ResultsGroupBox.Text = "Resultados";
            // 
            // conclusionLabel
            // 
            this.conclusionLabel.AutoSize = true;
            this.conclusionLabel.Location = new System.Drawing.Point(8, 82);
            this.conclusionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conclusionLabel.Name = "conclusionLabel";
            this.conclusionLabel.Size = new System.Drawing.Size(87, 20);
            this.conclusionLabel.TabIndex = 2;
            this.conclusionLabel.Text = "Conclusion";
            // 
            // ResultadoLabel
            // 
            this.ResultadoLabel.AutoSize = true;
            this.ResultadoLabel.Location = new System.Drawing.Point(8, 37);
            this.ResultadoLabel.Name = "ResultadoLabel";
            this.ResultadoLabel.Size = new System.Drawing.Size(82, 20);
            this.ResultadoLabel.TabIndex = 0;
            this.ResultadoLabel.Text = "Resultado";
            // 
            // CalcularBiButton
            // 
            this.CalcularBiButton.Enabled = false;
            this.CalcularBiButton.Location = new System.Drawing.Point(564, 26);
            this.CalcularBiButton.Name = "CalcularBiButton";
            this.CalcularBiButton.Size = new System.Drawing.Size(75, 38);
            this.CalcularBiButton.TabIndex = 6;
            this.CalcularBiButton.Text = "Calcular";
            this.CalcularBiButton.UseVisualStyleBackColor = true;
            this.CalcularBiButton.Click += new System.EventHandler(this.CalcularBiButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(18, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(674, 628);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AnalisisUniGroupBox);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(666, 595);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Análisis Univariable";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StatChart);
            this.groupBox1.Location = new System.Drawing.Point(9, 217);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(644, 362);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Box Plot";
            // 
            // StatChart
            // 
            chartArea2.Name = "ChartArea1";
            this.StatChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.StatChart.Legends.Add(legend2);
            this.StatChart.Location = new System.Drawing.Point(12, 28);
            this.StatChart.Name = "StatChart";
            this.StatChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.StatChart.Size = new System.Drawing.Size(626, 335);
            this.StatChart.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.AnalisisBiGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(666, 595);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Análisis Bivariable";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CalcularFalsosButton);
            this.groupBox2.Controls.Add(this.atributosListView);
            this.groupBox2.Location = new System.Drawing.Point(8, 263);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(645, 315);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Falsos Predictores";
            // 
            // atributosListView
            // 
            this.atributosListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.atributoColumnHeader,
            this.tipoColumnHeader,
            this.falsoHeader});
            this.atributosListView.Location = new System.Drawing.Point(6, 57);
            this.atributosListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.atributosListView.Name = "atributosListView";
            this.atributosListView.Size = new System.Drawing.Size(625, 258);
            this.atributosListView.TabIndex = 0;
            this.atributosListView.UseCompatibleStateImageBehavior = false;
            this.atributosListView.View = System.Windows.Forms.View.Details;
            // 
            // atributoColumnHeader
            // 
            this.atributoColumnHeader.Text = "Atributo";
            this.atributoColumnHeader.Width = 80;
            // 
            // tipoColumnHeader
            // 
            this.tipoColumnHeader.Text = "Tipo";
            this.tipoColumnHeader.Width = 150;
            // 
            // falsoHeader
            // 
            this.falsoHeader.Text = "Falso Predictor";
            this.falsoHeader.Width = 150;
            // 
            // CalcularFalsosButton
            // 
            this.CalcularFalsosButton.Location = new System.Drawing.Point(556, 13);
            this.CalcularFalsosButton.Name = "CalcularFalsosButton";
            this.CalcularFalsosButton.Size = new System.Drawing.Size(75, 38);
            this.CalcularFalsosButton.TabIndex = 7;
            this.CalcularFalsosButton.Text = "Calcular";
            this.CalcularFalsosButton.UseVisualStyleBackColor = true;
            this.CalcularFalsosButton.Click += new System.EventHandler(this.CalcularFalsosButton_Click);
            // 
            // EstadisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 648);
            this.Controls.Add(this.tabControl1);
            this.Name = "EstadisticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Análisis estadístico";
            this.AnalisisUniGroupBox.ResumeLayout(false);
            this.AnalisisUniGroupBox.PerformLayout();
            this.AnalisisBiGroupBox.ResumeLayout(false);
            this.ResultsGroupBox.ResumeLayout(false);
            this.ResultsGroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StatChart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AnalisisUniGroupBox;
        private System.Windows.Forms.ComboBox AtributoComboBox;
        private System.Windows.Forms.GroupBox AnalisisBiGroupBox;
        private System.Windows.Forms.ComboBox Atributo2ComboBox;
        private System.Windows.Forms.ComboBox Atributo1ComboBox;
        private System.Windows.Forms.Button CalcularBiButton;
        private System.Windows.Forms.GroupBox ResultsGroupBox;
        private System.Windows.Forms.Label ResultadoLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label desviacionLabel;
        private System.Windows.Forms.Label modaLabel;
        private System.Windows.Forms.Label medianaLabel;
        private System.Windows.Forms.Label mediaLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView atributosListView;
        private System.Windows.Forms.ColumnHeader atributoColumnHeader;
        private System.Windows.Forms.ColumnHeader tipoColumnHeader;
        private System.Windows.Forms.DataVisualization.Charting.Chart StatChart;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label conclusionLabel;
        private System.Windows.Forms.ColumnHeader falsoHeader;
        private System.Windows.Forms.Button CalcularFalsosButton;
    }
}