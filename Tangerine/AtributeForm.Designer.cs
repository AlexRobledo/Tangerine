namespace Tangerine
{
    partial class AtributeForm
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
            this.AtributoDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CountRowLabel = new System.Windows.Forms.Label();
            this.RowLabel = new System.Windows.Forms.Label();
            this.PorcentajeLlabel = new System.Windows.Forms.Label();
            this.ColumnaNameLabel = new System.Windows.Forms.Label();
            this.ValoresFaltantesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Dominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AtributoDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AtributoDataGridView
            // 
            this.AtributoDataGridView.AllowUserToAddRows = false;
            this.AtributoDataGridView.AllowUserToDeleteRows = false;
            this.AtributoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AtributoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Tipo,
            this.Dominio});
            this.AtributoDataGridView.Location = new System.Drawing.Point(277, 13);
            this.AtributoDataGridView.Name = "AtributoDataGridView";
            this.AtributoDataGridView.RowHeadersWidth = 25;
            this.AtributoDataGridView.RowTemplate.Height = 28;
            this.AtributoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AtributoDataGridView.Size = new System.Drawing.Size(1189, 420);
            this.AtributoDataGridView.TabIndex = 0;
            this.AtributoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AtributoDataGridView_CellClick);
            this.AtributoDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.AtributoDataGridView_CellValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CountRowLabel);
            this.groupBox1.Controls.Add(this.RowLabel);
            this.groupBox1.Controls.Add(this.PorcentajeLlabel);
            this.groupBox1.Controls.Add(this.ColumnaNameLabel);
            this.groupBox1.Controls.Add(this.ValoresFaltantesLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // CountRowLabel
            // 
            this.CountRowLabel.AutoSize = true;
            this.CountRowLabel.Location = new System.Drawing.Point(151, 49);
            this.CountRowLabel.Name = "CountRowLabel";
            this.CountRowLabel.Size = new System.Drawing.Size(18, 20);
            this.CountRowLabel.TabIndex = 0;
            this.CountRowLabel.Text = "0";
            // 
            // RowLabel
            // 
            this.RowLabel.AutoSize = true;
            this.RowLabel.Location = new System.Drawing.Point(7, 49);
            this.RowLabel.Name = "RowLabel";
            this.RowLabel.Size = new System.Drawing.Size(82, 20);
            this.RowLabel.TabIndex = 3;
            this.RowLabel.Text = "Instancias";
            // 
            // PorcentajeLlabel
            // 
            this.PorcentajeLlabel.AutoSize = true;
            this.PorcentajeLlabel.Location = new System.Drawing.Point(121, 92);
            this.PorcentajeLlabel.Name = "PorcentajeLlabel";
            this.PorcentajeLlabel.Size = new System.Drawing.Size(23, 20);
            this.PorcentajeLlabel.TabIndex = 0;
            this.PorcentajeLlabel.Text = "%";
            // 
            // ColumnaNameLabel
            // 
            this.ColumnaNameLabel.AutoSize = true;
            this.ColumnaNameLabel.Location = new System.Drawing.Point(7, 26);
            this.ColumnaNameLabel.Name = "ColumnaNameLabel";
            this.ColumnaNameLabel.Size = new System.Drawing.Size(123, 20);
            this.ColumnaNameLabel.TabIndex = 2;
            this.ColumnaNameLabel.Text = "Nombre atributo";
            // 
            // ValoresFaltantesLabel
            // 
            this.ValoresFaltantesLabel.AutoSize = true;
            this.ValoresFaltantesLabel.Location = new System.Drawing.Point(151, 72);
            this.ValoresFaltantesLabel.Name = "ValoresFaltantesLabel";
            this.ValoresFaltantesLabel.Size = new System.Drawing.Size(18, 20);
            this.ValoresFaltantesLabel.TabIndex = 1;
            this.ValoresFaltantesLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valores faltantes: ";
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(13, 399);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(258, 33);
            this.SaveChangesButton.TabIndex = 1;
            this.SaveChangesButton.Text = "Aplicar cambios";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Items.AddRange(new object[] {
            "Numérico",
            "Booleano",
            "Nominal",
            "Categórico",
            "Target"});
            this.Tipo.Name = "Tipo";
            // 
            // Dominio
            // 
            this.Dominio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dominio.HeaderText = "Dominio";
            this.Dominio.Name = "Dominio";
            this.Dominio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AtributeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 444);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AtributoDataGridView);
            this.MaximumSize = new System.Drawing.Size(1500, 500);
            this.MinimumSize = new System.Drawing.Size(1500, 500);
            this.Name = "AtributeForm";
            this.Text = "Modificar columnas";
            ((System.ComponentModel.ISupportInitialize)(this.AtributoDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AtributoDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label PorcentajeLlabel;
        private System.Windows.Forms.Label ColumnaNameLabel;
        private System.Windows.Forms.Label ValoresFaltantesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Label CountRowLabel;
        private System.Windows.Forms.Label RowLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dominio;
    }
}