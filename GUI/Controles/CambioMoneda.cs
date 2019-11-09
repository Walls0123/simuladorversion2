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
using CNegocio.Ventanilla;
using Modelos;

namespace Sistema_Bancario.Controles
{
    public partial class CambioMoneda : UserControl
    {
        private TipoCambioModel m_tipocambio;
        int i;
        int i2;
        public CambioMoneda()
        {
            InitializeComponent();
            monto1.TBMonto.TextChanged += TBMonto_TextChanged;
            tipoMoneda1.CboMoneda.SelectedIndexChanged += CboMoneda_SelectedIndexChanged;
            tipoMoneda2.CboMoneda.SelectedIndexChanged += CboMoneda_SelectedIndexChanged1;
            i = tipoMoneda1.CboMoneda.SelectedIndex;
            i2 = tipoMoneda2.CboMoneda.SelectedIndex;
        }

        private void CboMoneda_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (tipoMoneda2.CboMoneda.SelectedIndex==0)
            {
                tipoMoneda1.CboMoneda.SelectedIndex = 1;
             //   MessageBox.Show("Mismo tipo de Conversion");
            }
            else if(tipoMoneda2.CboMoneda.SelectedIndex==1)
            {
                tipoMoneda1.CboMoneda.SelectedIndex = 0;
            }
        }

        private void CboMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipoMoneda1.CboMoneda.SelectedIndex == 0)
            {
                tipoMoneda2.CboMoneda.SelectedIndex = 1;
                //   MessageBox.Show("Mismo tipo de Conversion");
            }
            else if (tipoMoneda1.CboMoneda.SelectedIndex == 1)
            {
                tipoMoneda2.CboMoneda.SelectedIndex = 0;
            }
        }

        private bool setItem()
        {
            try
            {
                m_tipocambio = new TipoCambioModel();

                if (this.tipoMoneda1.CboMoneda.SelectedValue != null)
                { m_tipocambio.Monedaorigen = (int)this.tipoMoneda1.CboMoneda.SelectedValue; }
                else
                { return false; }

                if (this.tipoMoneda2.CboMoneda.SelectedValue != null)
                { m_tipocambio.Monedaorigen = (int)this.tipoMoneda2.CboMoneda.SelectedValue; }
                else
                { return false; }

                if (!string.IsNullOrEmpty(this.monto1.TBMonto.Text.Trim()))
                { m_tipocambio.Montocompra = Convert.ToDecimal(this.monto1.TBMonto.Text.Trim()); }
                else
                { return false; }

                if (!string.IsNullOrEmpty(this.txtConversion.Text.Trim()))
                { m_tipocambio.Montoventa = Convert.ToDecimal(this.txtConversion.Text.Trim()); }
                else
                { return false; }

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        private void TBMonto_TextChanged(object sender, EventArgs e)
        {
            if (tipoMoneda1.CboMoneda.Text.Equals("Soles") && tipoMoneda2.CboMoneda.Text.Equals("Dolares"))
            {
                Dividir(true);
            }
            else if (tipoMoneda1.CboMoneda.Text.Equals("Dolares") && tipoMoneda2.CboMoneda.Text.Equals("Soles"))
            {
                Multiplicar(true);
            }
            else if (tipoMoneda2.CboMoneda.Text.Equals("Euros"))
            {
                Multiplicar(true);
            }
        }
        public void Multiplicar(bool flag)
        {
            if (monto1.TBMonto.Text != "")
            {
                Decimal A = Convert.ToDecimal(precios1.LbCompraDolares.Text.ToString());
                Decimal B = Convert.ToDecimal(monto1.TBMonto.Text.ToString());
                Decimal D = Convert.ToDecimal(precios1.LbVentaDolares.Text.ToString());
                if (flag == true)
                {
                    Decimal C = A * B;
                    txtConversion.Text = Decimal.Round(C, 3).ToString();
                }
                else if (flag == false)
                {
                    Decimal C = D * B;
                
                    txtConversion.Text = Decimal.Round(C, 3).ToString();
                }
            }
            else
            {
                txtConversion.Text = "";
            }
        }
        public void Dividir(bool flag)
        {
            if (monto1.TBMonto.Text != "")
            {
                Decimal A = Convert.ToDecimal(precios1.LbCompraDolares.Text.ToString());
                Decimal B = Convert.ToDecimal(monto1.TBMonto.Text.ToString());
                Decimal D = Convert.ToDecimal(precios1.LbVentaDolares.Text.ToString());
                if (flag == true)
                {
                    Decimal C = B / A;
                    txtConversion.Text = Decimal.Round(C, 3).ToString();
                }
                else if (flag == false)
                {
                    Decimal C = D / B;
                    txtConversion.Text = Decimal.Round(C, 3).ToString();
                }
            }
            else
            {
                txtConversion.Text = "";
            }
        }

        private void Cambiar_Click(object sender, EventArgs e)
        {
            TipoMovimientoMethods movimiento = new TipoMovimientoMethods();
            TipodeCambioModel tipo = new TipodeCambioModel();
           // VentanaPrincipal ventana =new VentanaPrincipal;
            tipo.MonedaE = tipoMoneda1.CboMoneda.Text;
            tipo.MontoE = Convert.ToDecimal(monto1.TBMonto.Text);
            tipo.MontoS = Convert.ToDecimal(txtConversion.Text);
            tipo.MonedaS = tipoMoneda2.CboMoneda.Text;
            StatusStrip o = this.TopLevelControl.Controls.Find("stStatus", true).FirstOrDefault() as StatusStrip;//o.Items[1].Text;
            //Solucionar
            tipo.Usuario = o.Items[1].Text;
            if (movimiento.MovimientoTipoCambioInsert(tipo) > 0)
            {
                MessageBox.Show("Se realizo el Cambio");
            };
        }
    }
}
