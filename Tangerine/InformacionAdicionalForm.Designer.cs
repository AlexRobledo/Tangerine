namespace Tangerine
{
    partial class InformacionAdicionalForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.informacionTextBox = new System.Windows.Forms.TextBox();
            this.relacionTextBox = new System.Windows.Forms.TextBox();
            this.caracterTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción del Data Set";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Relación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Caractér Usado para Valores Faltantes";
            // 
            // informacionTextBox
            // 
            this.informacionTextBox.Location = new System.Drawing.Point(15, 25);
            this.informacionTextBox.Multiline = true;
            this.informacionTextBox.Name = "informacionTextBox";
            this.informacionTextBox.Size = new System.Drawing.Size(273, 41);
            this.informacionTextBox.TabIndex = 3;
            // 
            // relacionTextBox
            // 
            this.relacionTextBox.Location = new System.Drawing.Point(14, 85);
            this.relacionTextBox.Multiline = true;
            this.relacionTextBox.Name = "relacionTextBox";
            this.relacionTextBox.Size = new System.Drawing.Size(273, 41);
            this.relacionTextBox.TabIndex = 4;
            // 
            // caracterTextBox
            // 
            this.caracterTextBox.Location = new System.Drawing.Point(12, 147);
            this.caracterTextBox.Name = "caracterTextBox";
            this.caracterTextBox.Size = new System.Drawing.Size(49, 20);
            this.caracterTextBox.TabIndex = 5;
            // 
            // InformacionAdicionalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 190);
            this.Controls.Add(this.caracterTextBox);
            this.Controls.Add(this.relacionTextBox);
            this.Controls.Add(this.informacionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InformacionAdicionalForm";
            this.Text = "InformacionAdicionalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox informacionTextBox;
        private System.Windows.Forms.TextBox relacionTextBox;
        private System.Windows.Forms.TextBox caracterTextBox;
    }
}