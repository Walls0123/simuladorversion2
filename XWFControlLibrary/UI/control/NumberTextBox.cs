using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XWFControlLibrary.UI.control
{
   public class NumberTextBox : TextBox
   {
      public NumberTextBox()
      {
         this.KeyPress += NumberTextBox_KeyPress;
         this.MaxLength = 25;
         this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      }

      private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
         {
            e.Handled = true;
         }
      }
   }
}
