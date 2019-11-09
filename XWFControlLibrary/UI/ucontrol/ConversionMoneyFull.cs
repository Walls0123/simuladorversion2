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
   public partial class ConversionMoneyFull : UserControl
   {
      private Usd usd = null;

      public ConversionMoneyFull()
      {
         InitializeComponent();
         Init();
         txtMonto.btnViewMoney.TextChanged += BtnViewMoney_TextChanged;
         txtValue.btnViewMoney.TextChanged += BtnViewMoney_TextChanged;
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
         string _value = txtValue.btnViewMoney.Text;
         string _monto = txtMonto.btnViewMoney.Text;

         if (_value == "PEN" && _monto == "USD")
            txtMonto.Text = Math.Round(value * usd.rate, 2).ToString();
         else if (_value == "USD" && _monto == "PEN")
            txtMonto.Text = Math.Round(value * usd.inverseRate, 2).ToString();
         else
            txtMonto.Text = Math.Round(value, 2).ToString();
      }

   }
}
