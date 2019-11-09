using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Modelos;

namespace Sistema_Bancario.Controles
{
    public partial class TipoCuenta : UserControl
    {
        public TipoCuenta()
        {
            InitializeComponent();
        }

        private void TipoCuenta_Load(object sender, EventArgs e)
        {
        }

        public string ObtenerTipoCuenta()
        {
            if (RBAhorros.Checked)
            {
                return "AHORROS";
            }
            else if (RBCredito.Checked)
            {
                return "CREDITO";
            }
            else if (RBCredito.Checked)
            {
                return "CORRIENTE";
            }
            else
            {
                return null;
            }
        }

        public TipoMonedaModel ObtenerMoneda()
        {
            return tipoMoneda1.ElegirMoneda();
        }
    }
}
