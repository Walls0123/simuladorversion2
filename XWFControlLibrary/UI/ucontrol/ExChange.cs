using System;
using System.Windows.Forms;
using XWFControlLibrary.JsonEntities;
using XWFControlLibrary.Consumible;

namespace XWFControlLibrary.UI.ucontrol
{
   public partial class ExChange : UserControl
   {
      private Usd usd = null;

      public ExChange()
      {
         InitializeComponent();
         SetExchange();
      }

      private void SetExchange()
      {
         MoneyCons consumible = new MoneyCons();
         usd = consumible.money.usd;
         txtCodeUSD.Text = usd.code;
         txtNombreUSD.Text = usd.name;
         txtTarifaUSD.Text = Math.Round(usd.inverseRate, 2).ToString();
         txtInversoUSD.Text = Math.Round(usd.rate, 2).ToString();
      }
   }
}
