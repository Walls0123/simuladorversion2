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
    //el combo tiene que buscar en la bd el tipo de moneda
    public partial class TipoMoneda : UserControl
    {
        public TipoMoneda()
        {
            InitializeComponent();
            PoblarCboMoneda();
        }

        private void TipoMoneda_Load(object sender, EventArgs e)
        {

        }

        public TipoMonedaModel ElegirMoneda()
        {
            return (TipoMonedaModel)CboMoneda.SelectedItem;
        }

        private void PoblarCboMoneda()
        {
            try
            {
                using (WsSistemaBancario.TipoMonedaServiceClient tipoMoneda = new WsSistemaBancario.TipoMonedaServiceClient())
                {
                    List<TipoMonedaModel> monedas = new List<TipoMonedaModel>();
                    monedas = tipoMoneda.Moneda_ObtenerTodos().ToList();

                    this.CboMoneda.DataSource = monedas;
                    this.CboMoneda.DisplayMember = "Nombre";
                    this.CboMoneda.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {           
               // MessageBox.Show("Error al llamar al servicio");
                List<string> monedas = new List<string>();
                monedas.Add("Soles");
                monedas.Add("Dolares");
                this.CboMoneda.DataSource = monedas;
            }
           
        }

    }
}
