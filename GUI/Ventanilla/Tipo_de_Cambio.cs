using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CNegocio.Ventanilla;
using Modelos;
using Modelos.Modelos;

namespace Sistema_Bancario.Froms_opciones
{
   public partial class Tipo_de_Cambio : Base
   {
      private TipoCambioModel m_tipocambio;

      public Tipo_de_Cambio()
      {
         InitializeComponent();
         this.proceder1.BTProceder.Click += BTProceder_Click;
         monto1.TBMonto.TextChanged += TBMonto_TextChanged;
            tipoMoneda1.CboMoneda.Click += CboMoneda_Click1;
         tipoMoneda2.CboMoneda.Click += CboMoneda_Click;            
      }

        private void CboMoneda_Click1(object sender, EventArgs e)
        {
            if (tipoMoneda2.CboMoneda.SelectedIndex == 0)
            {
                tipoMoneda1.CboMoneda.SelectedIndex = 1;
                //   MessageBox.Show("Mismo tipo de Conversion");
            }
            else if (tipoMoneda2.CboMoneda.SelectedIndex == 1)
            {
                tipoMoneda1.CboMoneda.SelectedIndex = 0;
            }
        }

        private void CboMoneda_Click(object sender, EventArgs e)
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

      private static Tipo_de_Cambio _instance;
      public static Tipo_de_Cambio instance
      {
         get
         {
            if (_instance == null)
            {
               _instance = new Tipo_de_Cambio();
            }

            return _instance;
         }
      }


      private void BTProceder_Click(object sender, EventArgs e)
      {           
            if (setItem())
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

        private void TBMonto_TextChanged(object sender, EventArgs e)
        {
          //  Multiplicar(true);

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

        private void RbtnVenta_CheckedChanged(object sender, EventArgs e)
        {
            Multiplicar(false);
        }

        private void RbtnCompra_CheckedChanged(object sender, EventArgs e)
        {
            Multiplicar(true);
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
                    txtConversion.Text = Convert.ToString(C);
                }
                else if (flag == false)
                {
                    Decimal C = D / B;
                    txtConversion.Text = Convert.ToString(C);
                }
            }
            else
            {
                txtConversion.Text = "";
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
                    txtConversion.Text = Convert.ToString(C);
                }
                else if (flag == false)
                {
                    Decimal C = D * B;
                    txtConversion.Text = Convert.ToString(C);
                }
            }
            else
            {
                txtConversion.Text = "";
            }
        }
    }
}
