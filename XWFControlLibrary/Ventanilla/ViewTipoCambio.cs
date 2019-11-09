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
using Modelos;
using Modelos.Session;

namespace XWFControlLibrary.Ventanilla
{
   public partial class ViewTipoCambio : Base
   {
      private TipoMovimientoMethods movimiento = null;
      private TipodeCambioModel tipo = null;
      public ISession session = null;
      public ViewTipoCambio()
      {
         InitializeComponent();
      }

      private bool SetItem()
      {
         tipo = new TipodeCambioModel();
         string _monto = this.conversionMoneyFull1.txtValue.Text;
         if (!string.IsNullOrEmpty(_monto) && decimal.TryParse(_monto, out decimal result))
            tipo.MontoE = result;

         string _conversion = this.conversionMoneyFull1.txtMonto.Text;
         if (!string.IsNullOrEmpty(_conversion) && decimal.TryParse(_conversion, out decimal results))
            tipo.MontoS = results;

         tipo.MonedaE = conversionMoneyFull1.txtValue.btnViewMoney.Text;
         tipo.MonedaS = conversionMoneyFull1.txtMonto.btnViewMoney.Text;
         tipo.Usuario = session.UserName;
         return true;
      }

      private void ButtonProceder_Click(object sender, EventArgs e)
      {
         if (SetItem())
         {
            movimiento = new TipoMovimientoMethods();
            if (movimiento.MovimientoTipoCambioInsert(tipo) > 0)
            {
               MessageBox.Show("Proceso satisfactorio!");
            }
            else
               MessageBox.Show("No se pudo realizar el proceso!");
         }
      }

      private static ViewTipoCambio _instance;
      public static ViewTipoCambio instance
      {
         get
         {
            if (_instance == null)
            {
               _instance = new ViewTipoCambio();
            }

            return _instance;
         }
      }
   }
}
