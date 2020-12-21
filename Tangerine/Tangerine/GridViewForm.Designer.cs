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
            this.SaveAsButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.AddColumnButton = new System.Windows.Forms.Button();
            this.InstanciasLabel = new System.Windows.Forms.Label();
            this.ColumnasLabel = new System.Windows.Forms.Label();
            this.InstanciasLabelTag = new System.Windows.Forms.Label();
            this.ColumnasLabelTag = new System.Windows.Forms.Label();
            this.InformacionLabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.DropColumnButton = new System.Windows.Forms.Button();
            this.DropRowButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSplitContainer)).BeginInit();
            this.MenuSplitContainer.Panel1.SuspendLayout();
            this.MenuSplitContainer.Panel2.SuspendLayout();
            this.MenuSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuSplitContainer
            // 
            this.MenuSplitContainer.Location = new System.Drawing.Point(12, 12);
            this.MenuSplitContainer.Name = "MenuSplitContainer";
            // 
            // MenuSplitContainer.Panel1
            // 
            this.MenuSplitContainer.Panel1.Controls.Add(this.DropRowButton);
            this.MenuSplitContainer.Panel1.Controls.Add(this.DropColumnButton);
            this.MenuSplitContainer.Panel1.Controls.Add(this.SaveAsButton);
            this.MenuSplitContainer.Panel1.Controls.Add(this.SaveButton);
            this.MenuSplitContainer.Panel1.Controls.Add(this.AddRowButton);
            this.MenuSplitContainer.Panel1.Controls.Add(this.AddColumnButton);
            this.MenuSplitContainer.Panel1.Controls.Add(this.InstanciasLabel);
            this.MenuSplitContainer.Panel1.Controls.Add(this.ColumnasLabel);
            this.MenuSplitContainer.Panel1.Controls.Add(this.InstanciasLabelTag);
            this.MenuSplitContainer.Panel1.Controls.Add(this.ColumnasLabelTag);
            this.MenuSplitContainer.Panel1.Controls.Add(this.InformacionLabel);
            // 
            // MenuSplitContainer.Panel2
            // 
            this.MenuSplitContainer.Panel2.Controls.Add(this.dataGridView);
            this.MenuSplitContainer.Size = new System.Drawing.Size(1014, 720);
            this.MenuSplitContainer.SplitterDistance = 266;
            this.MenuSplitContainer.TabIndex = 1;
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.Location = new System.Drawing.Point(111, 655);
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.Size = new System.Drawing.Size(93, 52);
            this.SaveAsButton.TabIndex = 4;
            this.SaveAsButton.Text = "Guardar Como";
            this.SaveAsButton.UseVisualStyleBackColor = true;
            this.SaveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 655);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(93, 52);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Guardar";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(12, 139);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(148, 40);
            this.AddRowButton.TabIndex = 2;
            this.AddRowButton.Text = "Agregar instancia";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // AddColumnButton
            // 
            this.AddColumnButton.Location = new System.Drawing.Point(12, 93);
            this.AddColumnButton.Name = "AddColumnButton";
            this.AddColumnButton.Size = new System.Drawing.Size(148, 40);
            this.AddColumnButton.TabIndex = 1;
            this.AddColumnButton.Text = "Agregar columna";
            this.AddColumnButton.UseVisualStyleBackColor = true;
            this.AddColumnButton.Click += new System.EventHandler(this.AddColumnButton_Click);
            // 
            // InstanciasLabel
            // 
            this.InstanciasLabel.AutoSize = true;
            this.InstanciasLabel.Location = new System.Drawing.Point(172, 52);
            this.InstanciasLabel.Name = "InstanciasLabel";
            this.InstanciasLabel.Size = new System.Drawing.Size(18, 20);
            this.InstanciasLabel.TabIndex = 0;
            this.InstanciasLabel.Text = "0";
            // 
            // ColumnasLabel
            // 
            this.ColumnasLabel.AutoSize = true;
            this.ColumnasLabel.Location = new System.Drawing.Point(168, 28);
            this.ColumnasLabel.Name = "ColumnasLabel";
            this.ColumnasLabel.Size = new System.Drawing.Size(18, 20);
            this.ColumnasLabel.TabIndex = 0;
            this.ColumnasLabel.Text = "0";
            // 
            // InstanciasLabelTag
            // 
            this.InstanciasLabelTag.AutoSize = true;
            this.InstanciasLabelTag.Location = new System.Drawing.Point(8, 52);
            this.InstanciasLabelTag.Name = "InstanciasLabelTag";
            this.InstanciasLabelTag.Size = new System.Drawing.Size(170, 20);
            this.InstanciasLabelTag.TabIndex = 0;
            this.InstanciasLabelTag.Text = "Número de instancias: ";
            // 
            // ColumnasLabelTag
            // 
            this.ColumnasLabelTag.AutoSize = true;
            this.ColumnasLabelTag.Location = new System.Drawing.Point(8, 28);
            this.ColumnasLabelTag.Name = "ColumnasLabelTag";
            this.ColumnasLabelTag.Size = new System.Drawing.Size(167, 20);
            this.ColumnasLabelTag.TabIndex = 0;
            this.ColumnasLabelTag.Text = "Número de columnas: ";
            // 
            // InformacionLabel
            // 
            this.InformacionLabel.AutoSize = true;
            this.InformacionLabel.Location = new System.Drawing.Point(4, 4);
            this.InformacionLabel.Name = "InformacionLabel";
            this.InformacionLabel.Size = new System.Drawing.Size(101, 20);
            this.InformacionLabel.TabIndex = 0;
            this.InformacionLabel.Text = "Información: ";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(744, 720);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_ColumnHeaderMouseClick);
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RowHeaderMouseClick);
            this.dataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseClick);
            // 
            // DropColumnButton
            // 
            this.DropColumnButton.Enabled = false;
            this.DropColumnButton.Location = new System.Drawing.Point(11, 185);
            this.DropColumnButton.Name = "DropColumnButton";
            this.DropColumnButton.Size = new System.Drawing.Size(149, 40);
            this.DropColumnButton.TabIndex = 0;
            this.DropColumnButton.Text = "Borrar columna";
            this.DropColumnButton.UseVisualStyleBackColor = true;
            this.DropColumnButton.Click += new System.EventHandler(this.DropColumnButton_Click);
            // 
            // DropRowButton
            // 
            this.DropRowButton.Enabled = false;
            this.DropRowButton.Location = new System.Drawing.Point(12, 231);
            this.DropRowButton.Name = "DropRowButton";
            this.DropRowButton.Size = new System.Drawing.Size(148, 40);
            this.DropRowButton.TabIndex = 0;
            this.DropRowButton.Text = "Borrar instancia";
            this.DropRowButton.UseVisualStyleBackColor = true;
            this.DropRowButton.Click += new System.EventHandler(this.DropRowButton_Click);
            // 
            // GridViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 744);
            this.Controls.Add(this.MenuSplitContainer);
            this.MaximumSize = new System.Drawing.Size(1060, 800);
            this.MinimumSize = new System.Drawing.Size(1060, 800);
            this.Name = "GridViewForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GridView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GridViewForm_FormClosing);
            this.MenuSplitContainer.Panel1.ResumeLayout(false);
            this.MenuSplitContainer.Panel1.PerformLayout();
            this.MenuSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuSplitContainer)).EndInit();
            this.MenuSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer MenuSplitContainer;
        private System.Windows.Forms.Label InformacionLabel;
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
    }
}