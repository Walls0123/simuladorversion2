using CNegocio.Ventanilla;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bancario.Ventanilla
{
    public partial class Recibo : Form
    {
        public Recibo()
        {
            InitializeComponent();
        }

        private void Recibo_Load(object sender, EventArgs e)
        {
            try
            {
                VentanillaMethods ventanilla = new VentanillaMethods();
                richTextBox1.Lines = ventanilla.GenerarDocumento().ToArray();
            }
            catch (Exception)
            {
                this.Close();
            }
            
        }
    }
}
