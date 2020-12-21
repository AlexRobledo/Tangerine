namespace Tangerine
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.TangerineLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.TangerineLabel = new System.Windows.Forms.Label();
            this.LoadButton = new System.Windows.Forms.Button();
            this.LoadDataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TangerineLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TangerineLogoPictureBox
            // 
            this.TangerineLogoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TangerineLogoPictureBox.BackgroundImage")));
            this.TangerineLogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TangerineLogoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.TangerineLogoPictureBox.Name = "TangerineLogoPictureBox";
            this.TangerineLogoPictureBox.Size = new System.Drawing.Size(135, 110);
            this.TangerineLogoPictureBox.TabIndex = 0;
            this.TangerineLogoPictureBox.TabStop = false;
            // 
            // TangerineLabel
            // 
            this.TangerineLabel.AutoSize = true;
            this.TangerineLabel.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TangerineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TangerineLabel.Location = new System.Drawing.Point(148, 30);
            this.TangerineLabel.Name = "TangerineLabel";
            this.TangerineLabel.Size = new System.Drawing.Size(355, 57);
            this.TangerineLabel.TabIndex = 0;
            this.TangerineLabel.Text = "Tangerine Software";
            this.TangerineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadButton
            // 
            this.LoadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoadButton.BackgroundImage")));
            this.LoadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoadButton.Location = new System.Drawing.Point(308, 188);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(128, 137);
            this.LoadButton.TabIndex = 2;
            this.LoadButton.Text = "Abrir";
            this.LoadButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.BackColor = System.Drawing.SystemColors.Window;
            this.LoadDataButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoadDataButton.BackgroundImage")));
            this.LoadDataButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoadDataButton.Location = new System.Drawing.Point(80, 188);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(128, 141);
            this.LoadDataButton.TabIndex = 1;
            this.LoadDataButton.Text = "Nuevo";
            this.LoadDataButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LoadDataButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoadDataButton.UseVisualStyleBackColor = false;
            this.LoadDataButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(513, 444);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.LoadDataButton);
            this.Controls.Add(this.TangerineLabel);
            this.Controls.Add(this.TangerineLogoPictureBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(535, 500);
            this.MinimumSize = new System.Drawing.Size(535, 500);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tangerine";
            ((System.ComponentModel.ISupportInitialize)(this.TangerineLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TangerineLogoPictureBox;
        private System.Windows.Forms.Label TangerineLabel;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button LoadDataButton;
    }
}

