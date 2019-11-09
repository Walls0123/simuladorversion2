using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocio.Ventanilla;

namespace Sistema_Bancario.Controles
{
    public partial class Precios : UserControl
    {
        public Precios()
        {
            InitializeComponent();
            ConsultaCambioMethods GetConsultaCambio = new ConsultaCambioMethods();
            var Consulta = GetConsultaCambio.TipodeCambio();
            LbCompraDolares.Text = Consulta.Compra.ToString();
            LbVentaDolares.Text = Consulta.Venta.ToString();
        }
        
        
    }
}
