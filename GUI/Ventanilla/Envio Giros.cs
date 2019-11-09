using CNegocio.Ventanilla;
using Modelos.Modelos;
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
    public partial class Envio_Giros : Sistema_Bancario.Base
    {
      private GirosMethods girosMethods;

      #region [ Variables Globales ]
      private int DNIorigen = default(int);
      private int DNIdestino = default(int);
      private decimal monto = default(decimal);
      private byte clave = default(byte);
      #endregion
      public Envio_Giros()
        {
            InitializeComponent();
            proceder1.BTProceder.Click += BTProceder_Click;
        }

      private bool SetItem()
      {
         try
         {
            if (!string.IsNullOrEmpty(this.monto1.TBMonto.Text.Trim()))
            { monto = Convert.ToDecimal(this.monto1.TBMonto.Text.Trim()); }
            else
            { return false; }

            if (!string.IsNullOrEmpty(this.txtClave.Text.Trim()))
            { clave = Convert.ToByte(this.txtClave.Text.Trim()); }
            else
            { return false; }

            if (!string.IsNullOrEmpty(this.dni1.TBDni.Text.Trim()))
            { DNIorigen= Convert.ToInt32(this.dni1.TBDni.Text.Trim()); }
            else
            { return false; }

            if (!string.IsNullOrEmpty(this.dni2.TBDni.Text.Trim()))
            { DNIdestino = Convert.ToInt32(this.dni2.TBDni.Text.Trim()); }
            else
            { return false; }

            return true;
         }
         catch (Exception e)
         {
              MessageBox.Show(e.Message.ToString());
            return false;
         }
      }

      private void BTProceder_Click(object sender, EventArgs e)
        {
         if (SetItem())
         {
            girosMethods = new GirosMethods();
                GiroModel giro = new GiroModel();
                StatusStrip o = this.TopLevelControl.Controls.Find("stStatus", true).FirstOrDefault() as StatusStrip;//o.Items[1].Text;               
                giro.Monto = monto;
                giro.Clave = clave;
                giro.Id_PersonaOrigen =Convert.ToInt32(dni1.TBDni.Text);
                giro.Id_PersonaDestino = Convert.ToInt32(dni2.TBDni.Text);
                giro.USUARIO_CREADOR = o.Items[1].Text;
                giro.Moneda = tipoMoneda1.CboMoneda.Text;

                if (girosMethods.EnviarGiro(giro)) {
                    MessageBox.Show("Giro Enviado");
                    Recibo recibo = new Recibo();
                    recibo.Show();
                }             
            else
               MessageBox.Show("No se pudo realizar giros");
         }
        }

        private static Envio_Giros _instance;
        public static Envio_Giros instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Envio_Giros();
                }

                return _instance;
            }
        }
    }
}
