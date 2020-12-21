namespace Tangerine
{
    partial class GridViewForm
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
            this.MenuSplitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LimpiezaButton = new System.Windows.Forms.Button();
            this.ModificarColumnButton = new System.Windows.Forms.Button();
            this.AnalisisButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AddColumnButton = new System.Windows.Forms.Button();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveAsButton = new System.Windows.Forms.Button();
            this.DropRowButton = new System.Windows.Forms.Button();
            this.DropColumnButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.informacionAdicionalButton = new System.Windows.Forms.Button();
            this.ValoresFaltatesPerLabel = new System.Windows.Forms.Label();
            this.ValoresFaltantesLabel = new System.Windows.Forms.Label();
            this.ValoresFaltantesLabelTag = new System.Windows.Forms.Label();
            this.InstanciasLabelTag = new System.Windows.Forms.Label();
            this.ColumnasLabelTag = new System.Windows.Forms.Label();
            this.ColumnasLabel = new System.Windows.Forms.Label();
            this.InstanciasLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DomainLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.columnIndexLabel = new System.Windows.Forms.Label();
            this.tipoDatoLabel = new System.Windows.Forms.Label();
            this.rowIndexLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSplitContainer)).BeginInit();
            this.MenuSplitContainer.Panel1.SuspendLayout();
            this.MenuSplitContainer.Panel2.SuspendLayout();
            this.MenuSplitContainer.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuSplitContainer
            // 
            this.MenuSplitContainer.Location = new System.Drawing.Point(8, 8);
            this.MenuSplitContainer.Margin = new System.Windows.Forms.Padding(2);
            this.MenuSplitContainer.Name = "MenuSplitContainer";
            // 
            // MenuSplitContainer.Panel1
            // 
            this.MenuSplitContainer.Panel1.BackColor = System.Drawing.Color.White;
            this.MenuSplitContainer.Panel1.Controls.Add(this.groupBox3);
            this.MenuSplitContainer.Panel1.Controls.Add(this.groupBox2);
            this.MenuSplitContainer.Panel1.Controls.Add(this.groupBox1);
            // 
            // MenuSplitContainer.Panel2
            // 
            this.MenuSplitContainer.Panel2.Controls.Add(this.dataGridView);
            this.MenuSplitContainer.Size = new System.Drawing.Size(676, 533);
            this.MenuSplitContainer.SplitterDistance = 176;
            this.MenuSplitContainer.SplitterWidth = 3;
            this.MenuSplitContainer.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.LimpiezaButton);
            this.groupBox3.Controls.Add(this.ModificarColumnButton);
            this.groupBox3.Controls.Add(this.AnalisisButton);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.AddColumnButton);
            this.groupBox3.Controls.Add(this.AddRowButton);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.SaveButton);
            this.groupBox3.Controls.Add(this.SaveAsButton);
            this.groupBox3.Controls.Add(this.DropRowButton);
            this.groupBox3.Controls.Add(this.DropColumnButton);
            this.groupBox3.Location = new System.Drawing.Point(7, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 313);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones";
            // 
            // LimpiezaButton
            // 
            this.LimpiezaButton.Location = new System.Drawing.Point(10, 224);
            this.LimpiezaButton.Margin = new System.Windows.Forms.Padding(2);
            this.LimpiezaButton.Name = "LimpiezaButton";
            this.LimpiezaButton.Size = new System.Drawing.Size(131, 38);
            this.LimpiezaButton.TabIndex = 14;
            this.LimpiezaButton.Text = "Limpieza de datos";
            this.LimpiezaButton.UseVisualStyleBackColor = true;
            this.LimpiezaButton.Click += new System.EventHandler(this.LimpiezaButton_Click);
            // 
            // ModificarColumnButton
            // 
            this.ModificarColumnButton.Location = new System.Drawing.Point(11, 87);
            this.ModificarColumnButton.Margin = new System.Windows.Forms.Padding(2);
            this.ModificarColumnButton.Name = "ModificarColumnButton";
            this.ModificarColumnButton.Size = new System.Drawing.Size(129, 26);
            this.ModificarColumnButton.TabIndex = 0;
            this.ModificarColumnButton.Text = "Modificar columna";
            this.ModificarColumnButton.UseVisualStyleBackColor = true;
            this.ModificarColumnButton.Click += new System.EventHandler(this.ModificarColumnButton_Click);
            // 
            // AnalisisButton
            // 
            this.AnalisisButton.Location = new System.Drawing.Point(10, 182);
            this.AnalisisButton.Margin = new System.Windows.Forms.Padding(2);
            this.AnalisisButton.Name = "AnalisisButton";
            this.AnalisisButton.Size = new System.Drawing.Size(131, 38);
            this.AnalisisButton.TabIndex = 13;
            this.AnalisisButton.Text = "Análisis Estadístico";
            this.AnalisisButton.UseVisualStyleBackColor = true;
            this.AnalisisButton.Click += new System.EventHandler(this.AnalisisButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Columna";
            // 
            // AddColumnButton
            // 
            this.AddColumnButton.Location = new System.Drawing.Point(11, 50);
            this.AddColumnButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddColumnButton.Name = "AddColumnButton";
            this.AddColumnButton.Size = new System.Drawing.Size(64, 26);
            this.AddColumnButton.TabIndex = 1;
            this.AddColumnButton.Text = "Agregar";
            this.AddColumnButton.UseVisualStyleBackColor = true;
            this.AddColumnButton.Click += new System.EventHandler(this.AddColumnButton_Click);
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(11, 141);
            this.AddRowButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(64, 26);
            this.AddRowButton.TabIndex = 2;
            this.AddRowButton.Text = "Agregar";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fila";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(11, 276);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(62, 34);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Guardar";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.Location = new System.Drawing.Point(79, 276);
            this.SaveAsButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.Size = new System.Drawing.Size(62, 34);
            this.SaveAsButton.TabIndex = 4;
            this.SaveAsButton.Text = "Guardar Como";
            this.SaveAsButton.UseVisualStyleBackColor = true;
            this.SaveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // DropRowButton
            // 
            this.DropRowButton.Enabled = false;
            this.DropRowButton.Location = new System.Drawing.Point(79, 141);
            this.DropRowButton.Margin = new System.Windows.Forms.Padding(2);
            this.DropRowButton.Name = "DropRowButton";
            this.DropRowButton.Size = new System.Drawing.Size(62, 26);
            this.DropRowButton.TabIndex = 0;
            this.DropRowButton.Text = "Borrar";
            this.DropRowButton.UseVisualStyleBackColor = true;
            this.DropRowButton.Click += new System.EventHandler(this.DropRowButton_Click);
            // 
            // DropColumnButton
            // 
            this.DropColumnButton.Enabled = false;
            this.DropColumnButton.Location = new System.Drawing.Point(79, 50);
            this.DropColumnButton.Margin = new System.Windows.Forms.Padding(2);
            this.DropColumnButton.Name = "DropColumnButton";
            this.DropColumnButton.Size = new System.Drawing.Size(62, 26);
            this.DropColumnButton.TabIndex = 0;
            this.DropColumnButton.Text = "Borrar";
            this.DropColumnButton.UseVisualStyleBackColor = true;
            this.DropColumnButton.Click += new System.EventHandler(this.DropColumnButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.informacionAdicionalButton);
            this.groupBox2.Controls.Add(this.ValoresFaltatesPerLabel);
            this.groupBox2.Controls.Add(this.ValoresFaltantesLabel);
            this.groupBox2.Controls.Add(this.ValoresFaltantesLabelTag);
            this.groupBox2.Controls.Add(this.InstanciasLabelTag);
            this.groupBox2.Controls.Add(this.ColumnasLabelTag);
            this.groupBox2.Controls.Add(this.ColumnasLabel);
            this.groupBox2.Controls.Add(this.InstanciasLabel);
            this.groupBox2.Location = new System.Drawing.Point(8, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del Data Set";
            // 
            // informacionAdicionalButton
            // 
            this.informacionAdicionalButton.Location = new System.Drawing.Point(7, 81);
            this.informacionAdicionalButton.Name = "informacionAdicionalButton";
            this.informacionAdicionalButton.Size = new System.Drawing.Size(153, 23);
            this.informacionAdicionalButton.TabIndex = 1;
            this.informacionAdicionalButton.Text = "Información Adicional";
            this.informacionAdicionalButton.UseVisualStyleBackColor = true;
            this.informacionAdicionalButton.Click += new System.EventHandler(this.informacionAdicionalButton_Click);
            // 
            // ValoresFaltatesPerLabel
            // 
            this.ValoresFaltatesPerLabel.AutoSize = true;
            this.ValoresFaltatesPerLabel.Location = new System.Drawing.Point(91, 64);
            this.ValoresFaltatesPerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValoresFaltatesPerLabel.Name = "ValoresFaltatesPerLabel";
            this.ValoresFaltatesPerLabel.Size = new System.Drawing.Size(15, 13);
            this.ValoresFaltatesPerLabel.TabIndex = 0;
            this.ValoresFaltatesPerLabel.Text = "%";
            // 
            // ValoresFaltantesLabel
            // 
            this.ValoresFaltantesLabel.AutoSize = true;
            this.ValoresFaltantesLabel.Location = new System.Drawing.Point(126, 51);
            this.ValoresFaltantesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValoresFaltantesLabel.Name = "ValoresFaltantesLabel";
            this.ValoresFaltantesLabel.Size = new System.Drawing.Size(13, 13);
            this.ValoresFaltantesLabel.TabIndex = 0;
            this.ValoresFaltantesLabel.Text = "0";
            // 
            // ValoresFaltantesLabelTag
            // 
            this.ValoresFaltantesLabelTag.AutoSize = true;
            this.ValoresFaltantesLabelTag.Location = new System.Drawing.Point(7, 51);
            this.ValoresFaltantesLabelTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValoresFaltantesLabelTag.Name = "ValoresFaltantesLabelTag";
            this.ValoresFaltantesLabelTag.Size = new System.Drawing.Size(88, 13);
            this.ValoresFaltantesLabelTag.TabIndex = 0;
            this.ValoresFaltantesLabelTag.Text = "Valores faltantes:";
            // 
            // InstanciasLabelTag
            // 
            this.InstanciasLabelTag.AutoSize = true;
            this.InstanciasLabelTag.Location = new System.Drawing.Point(7, 34);
            this.InstanciasLabelTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InstanciasLabelTag.Name = "InstanciasLabelTag";
            this.InstanciasLabelTag.Size = new System.Drawing.Size(115, 13);
            this.InstanciasLabelTag.TabIndex = 0;
            this.InstanciasLabelTag.Text = "Número de instancias: ";
            // 
            // ColumnasLabelTag
            // 
            this.ColumnasLabelTag.AutoSize = true;
            this.ColumnasLabelTag.Location = new System.Drawing.Point(7, 18);
            this.ColumnasLabelTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColumnasLabelTag.Name = "ColumnasLabelTag";
            this.ColumnasLabelTag.Size = new System.Drawing.Size(113, 13);
            this.ColumnasLabelTag.TabIndex = 0;
            this.ColumnasLabelTag.Text = "Número de columnas: ";
            // 
            // ColumnasLabel
            // 
            this.ColumnasLabel.AutoSize = true;
            this.ColumnasLabel.Location = new System.Drawing.Point(126, 18);
            this.ColumnasLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColumnasLabel.Name = "ColumnasLabel";
            this.ColumnasLabel.Size = new System.Drawing.Size(13, 13);
            this.ColumnasLabel.TabIndex = 0;
            this.ColumnasLabel.Text = "0";
            // 
            // InstanciasLabel
            // 
            this.InstanciasLabel.AutoSize = true;
            this.InstanciasLabel.Location = new System.Drawing.Point(126, 34);
            this.InstanciasLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InstanciasLabel.Name = "InstanciasLabel";
            this.InstanciasLabel.Size = new System.Drawing.Size(13, 13);
            this.InstanciasLabel.TabIndex = 0;
            this.InstanciasLabel.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.DomainLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.columnIndexLabel);
            this.groupBox1.Controls.Add(this.tipoDatoLabel);
            this.groupBox1.Controls.Add(this.rowIndexLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(4, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 91);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Celda Seleccionada";
            // 
            // DomainLabel
            // 
            this.DomainLabel.AutoSize = true;
            this.DomainLabel.Location = new System.Drawing.Point(6, 39);
            this.DomainLabel.Name = "DomainLabel";
            this.DomainLabel.Size = new System.Drawing.Size(45, 13);
            this.DomainLabel.TabIndex = 11;
            this.DomainLabel.Text = "Dominio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Index Fila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Index Columna";
            // 
            // columnIndexLabel
            // 
            this.columnIndexLabel.AutoSize = true;
            this.columnIndexLabel.Location = new System.Drawing.Point(108, 50);
            this.columnIndexLabel.Name = "columnIndexLabel";
            this.columnIndexLabel.Size = new System.Drawing.Size(13, 13);
            this.columnIndexLabel.TabIndex = 7;
            this.columnIndexLabel.Text = "0";
            // 
            // tipoDatoLabel
            // 
            this.tipoDatoLabel.AutoSize = true;
            this.tipoDatoLabel.Location = new System.Drawing.Point(108, 26);
            this.tipoDatoLabel.Name = "tipoDatoLabel";
            this.tipoDatoLabel.Size = new System.Drawing.Size(23, 13);
            this.tipoDatoLabel.TabIndex = 10;
            this.tipoDatoLabel.Text = "null";
            // 
            // rowIndexLabel
            // 
            this.rowIndexLabel.AutoSize = true;
            this.rowIndexLabel.Location = new System.Drawing.Point(108, 63);
            this.rowIndexLabel.Name = "rowIndexLabel";
            this.rowIndexLabel.Size = new System.Drawing.Size(13, 13);
            this.rowIndexLabel.TabIndex = 8;
            this.rowIndexLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo de dato:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(497, 533);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            this.dataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_ColumnHeaderMouseClick);
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RowHeaderMouseClick);
            this.dataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseClick);
            // 
            // GridViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 549);
            this.Controls.Add(this.MenuSplitContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(706, 593);
            this.MinimumSize = new System.Drawing.Size(706, 468);
            this.Name = "GridViewForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GridView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GridViewForm_FormClosing);
            this.MenuSplitContainer.Panel1.ResumeLayout(false);
            this.MenuSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuSplitContainer)).EndInit();
            this.MenuSplitContainer.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer MenuSplitContainer;
        private System.Windows.Forms.Label ColumnasLabelTag;
        private System.Windows.Forms.Label InstanciasLabelTag;
        private System.Windows.Forms.Label InstanciasLabel;
        private System.Windows.Forms.Label ColumnasLabel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button AddRowButton;
        private System.Windows.Forms.Button AddColumnButton;
        private System.Windows.Forms.Button SaveAsButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DropRowButton;
        private System.Windows.Forms.Button DropColumnButton;
        private System.Windows.Forms.Label rowIndexLabel;
        private System.Windows.Forms.Label columnIndexLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tipoDatoLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ValoresFaltantesLabel;
        private System.Windows.Forms.Label ValoresFaltantesLabelTag;
        private System.Windows.Forms.Label ValoresFaltatesPerLabel;
        private System.Windows.Forms.Button AnalisisButton;
        private System.Windows.Forms.Button ModificarColumnButton;
        private System.Windows.Forms.Label DomainLabel;
        private System.Windows.Forms.Button LimpiezaButton;
        private System.Windows.Forms.Button informacionAdicionalButton;
    }
}