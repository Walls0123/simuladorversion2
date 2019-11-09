using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XWFControlLibrary.UI.control
{
   public class MoneyTextBox : TextBox
   {
      private int money = default(int);
      private string[] value = {"PEN", "USD"};
      public Button btnViewMoney = null;
      public MoneyTextBox() : base()
      {
         btnViewMoney = new Button();
         btnViewMoney.Size = new System.Drawing.Size(30, this.ClientSize.Height + 2);
         btnViewMoney.Location = new System.Drawing.Point(this.ClientSize.Width - btnViewMoney.Width, -1);
         btnViewMoney.Cursor = Cursors.Default;
         btnViewMoney.Anchor = AnchorStyles.Right;
         btnViewMoney.Font = new System.Drawing.Font("Segoe UI", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         btnViewMoney.Text = "PEN";
         btnViewMoney.Click += _btnViewPassword_Click;
         this.KeyPress += NumberTextBox_KeyPress;
         this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Controls.Add(btnViewMoney);

         SendMessage(this.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnViewMoney.Width << 48));
      }

      private void _btnViewPassword_Click(object sender, EventArgs e)
      {
         money++;
         if (money == 2)
            money = default(int);

         btnViewMoney.Text = value[money];
      }

      private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
      {
         if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
         {
            e.Handled = true;
         }
      }

      [System.Runtime.InteropServices.DllImport("user32.dll")]
      private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
   }
}
