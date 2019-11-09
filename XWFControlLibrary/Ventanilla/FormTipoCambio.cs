using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XWFControlLibrary.Ventanilla
{
   public partial class FormTipoCambio : Form
   {
      //private TipoMovimientoMethods movimiento = null;
      //private TipodeCambioModel tipo = null;
      public decimal Conversion { get; set; }
      public FormTipoCambio()
      {
         InitializeComponent();
      }

      private bool SetItem()
      {
         if (string.IsNullOrEmpty(conversionMoneyFull1.txtValue.Text))
            return false;
         if (string.IsNullOrEmpty(conversionMoneyFull1.txtMonto.Text))
            return false;

         return true;

      }

      private void BtnProceder_Click(object sender, EventArgs e)
      {
         if(SetItem())
         {
            if (decimal.TryParse(conversionMoneyFull1.txtMonto.Text, out decimal resut))
            {
               Conversion = resut;
               DialogResult =  DialogResult.OK;
               Close();
            }
              
         }
      }
   }
}
