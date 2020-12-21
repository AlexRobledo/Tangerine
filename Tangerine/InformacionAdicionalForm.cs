using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tangerine
{
    public partial class InformacionAdicionalForm : Form
    {
        
        public InformacionAdicionalForm(string informacion, string relacion, char caracter)
        {
            InitializeComponent();
            inicializar(informacion, relacion, caracter);
        }

        private void inicializar(string i, string r, char c)
        {
            informacionTextBox.Text = i;
            relacionTextBox.Text = r;
            caracterTextBox.Text = c.ToString();

            informacionTextBox.Enabled = false;
            relacionTextBox.Enabled = false;
            caracterTextBox.Enabled = false;
        }
    }
}
