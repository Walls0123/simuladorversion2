using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XWFControlLibrary.UI.control
{
   public class DecimalTextBox : TextBox
   {
      public DecimalTextBox()
      {
         this.KeyPress += DecimalTextBox_KeyPress;
         this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      }

      private void DecimalTextBox_KeyPress(object sender, KeyPressEventArgs e)
      {
         if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
         {
            e.Handled = true;
         }
      }
   }
}
