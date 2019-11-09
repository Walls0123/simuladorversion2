using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XWFControlLibrary.Config;
using XWFControlLibrary.Consumible;
using XWFControlLibrary.JsonEntities;

namespace XWFControlLibrary.UI.ucontrol
{
   public partial class ConversionMoney : UserControl
   {
      private Usd usd = null;

      public ConversionMoney()
      {
         InitializeComponent();
         Init();
         txtMonto.btnViewMoney.TextChanged += BtnViewMoney_TextChanged;
      }

      private void Init()
      {
         MoneyCons consumible = new MoneyCons();
         usd = consumible.money.usd;
      }


      private void BtnViewMoney_TextChanged(object sender, EventArgs e)
      {
        ExChange();
      }
      private void TxtValue_TextChanged(object sender, EventArgs e)
      {
        ExChange();
      }

      private void ExChange()
      {
         if (string.IsNullOrEmpty(txtValue.Text))
         {
            txtMonto.Text = string.Empty;
            return;
         }

         decimal value = Convert.ToDecimal(txtValue.Text);

         switch (txtMonto.btnViewMoney.Text)
         {
            case "PEN":
               txtMonto.Text = value.ToString();
               break;
            case "USD":
               txtMonto.Text = Math.Round((value * usd.inverseRate), 2).ToString();
               break;
         }
      }

   }
}
