using CNegocio.Ventanilla;
using Modelos.Modelos;
using Modelos.Session;
using Sistema_Bancario.Controles;
using Sistema_Bancario.Ventanilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Bancario.Froms_opciones
{
    public partial class Retiros :Base
    {
      private RetirosMethods retirosMethods = null;
       
        CambioMoneda cambioMoneda;

      public  ISession Session = null;

        #region [Variables Globales]
         private decimal m_monto = default(decimal);
         private string m_nrocuenta = default(string);
         private int m_clave = default(int);
         private int m_doi = default(int);
      #endregion
      public Retiros()
        {
            InitializeComponent();
            proceder1.BTProceder.Click += BTProceder_Click;
            tipoMoneda1.CboMoneda.SelectedValueChanged += CboMoneda_SelectedValueChanged;
            nroCuenta1.BtValidar.Click += BtValidar_Click;
        }
        private void BtValidar_Click(object sender, EventArgs e)
        {
         string _moneda = nroCuenta1.Lbmoneda.Text.Trim();
         if (string.IsNullOrEmpty(_moneda))
            return;

            int index = tipoMoneda1.CboMoneda.FindString(_moneda);
            tipoMoneda1.CboMoneda.SelectedIndex = index;
        }

        private void CboMoneda_SelectedValueChanged(object sender, EventArgs e)
        {
         string _cbomoneda = tipoMoneda1.CboMoneda.Text.Trim();
         if (string.IsNullOrEmpty(_cbomoneda))
            return;

         if (!nroCuenta1.Lbmoneda.Text.Equals(_cbomoneda))
            {
                MessageBox.Show("Se ha cambiado el tipo de moneda." +
                    "Se hara la conversion del monto ingresado");
                CambiarMoneda();
            }
            else
            {
                if (panel1.Controls.Count == 1)
                {
                    panel1.Controls.RemoveAt(0);
                }
            }
        }
        public void CambiarMoneda()
        {

         string _moneda = nroCuenta1.Lbmoneda.Text.Trim();
         if (string.IsNullOrEmpty(_moneda))
            return;

            panel1.Height = 150;
            cambioMoneda = new CambioMoneda();
            cambioMoneda.txtConversion.TextChanged += TxtConversion_TextChanged;
            int index = cambioMoneda.tipoMoneda1.CboMoneda.FindString(nroCuenta1.Lbmoneda.Text);
            cambioMoneda.tipoMoneda1.CboMoneda.SelectedIndex = index;
            panel1.Controls.Add(cambioMoneda);
        }

        private void TxtConversion_TextChanged(object sender, EventArgs e)
        {
         string _conversion = cambioMoneda.txtConversion.Text.Trim();
         if (string.IsNullOrEmpty(_conversion))
            return;

            monto1.TBMonto.Text = Decimal.Round(Convert.ToDecimal(cambioMoneda.txtConversion.Text), 3).ToString();
        }

        private bool SetItem()
      {
         try
         {
            
            if (!string.IsNullOrEmpty(this.monto1.TBMonto.Text.Trim()))
            { m_monto = Convert.ToDecimal(this.monto1.TBMonto.Text.Trim()); }
            else
            { return false; }

            if (!string.IsNullOrEmpty(this.nroCuenta1.TBNroCuenta.Text.Trim()))
            { m_nrocuenta = Convert.ToString(this.nroCuenta1.TBNroCuenta.Text.Trim()); }
            else
            { return false; }

            if (!string.IsNullOrEmpty(this.txtClave.Text.Trim()))
            { m_clave = Convert.ToInt32(this.txtClave.Text.Trim()); }
            else
            { return false; }

            if (!string.IsNullOrEmpty(this.nroCuenta1.dni1.TBDni.Text.Trim()))
            { m_doi = Convert.ToInt32(this.nroCuenta1.dni1.TBDni.Text.Trim()); }
            else
            { return false; }

            return true;
         }
         catch (Exception)
         {
            return false;
         }
      }

        private void BTProceder_Click(object sender, EventArgs e)
        {
            if (SetItem())
            {
                retirosMethods = new RetirosMethods();
                StatusStrip o = this.TopLevelControl.Controls.Find("stStatus", true).FirstOrDefault() as StatusStrip;
                CuentasTarjetasModel cuentas = new CuentasTarjetasModel();
                cuentas.Monto = this.m_monto;
                cuentas.NroCuenta = this.m_nrocuenta;
                cuentas.clave = this.m_clave;
                cuentas.doi = this.m_doi;
                cuentas.Usuario = o.Items[1].Text;
                cuentas.RowVersion = nroCuenta1.VersionCuenta;
                var a = retirosMethods.InsertaRetiro(cuentas);
                if (a.Equals("Transferido"))
                {
                    MessageBox.Show("Retiro con exito");
                    Recibo recibo = new Recibo();
                    recibo.Show();
                }                  
                else
                    MessageBox.Show("No se pudo generar el retiro: "+a);
            }
            else
            {
                MessageBox.Show("Se encontró campos vacios");
            }
        }



      private static Retiros _instance;
      public static Retiros instance
      {
         get
         {
            if (_instance == null)
            {
               _instance = new Retiros();
            }

            return _instance;
         }
      }

   }
}
