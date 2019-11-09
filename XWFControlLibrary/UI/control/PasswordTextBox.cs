using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XWFControlLibrary.UI.control
{
   public class PasswordTextBox : TextBox
   {
      private bool isPassword = false;
      public PasswordTextBox() : base()
      {
         Button _btnViewPassword = new Button();
         _btnViewPassword.Size = new System.Drawing.Size(25, this.ClientSize.Height + 2);
         _btnViewPassword.Location = new System.Drawing.Point(this.ClientSize.Width - _btnViewPassword.Width, -1);
         _btnViewPassword.Cursor = Cursors.Default;
         _btnViewPassword.Anchor = AnchorStyles.Right;
         _btnViewPassword.Image = Properties.Resources.view;
         _btnViewPassword.Click += _btnViewPassword_Click;
         this.KeyPress += NumberTextBox_KeyPress;
         this.PasswordChar = '*';
         this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Controls.Add(_btnViewPassword);

         SendMessage(this.Handle, 0xd3, (IntPtr)2, (IntPtr)(_btnViewPassword.Width << 48));
      }

      private void _btnViewPassword_Click(object sender, EventArgs e)
      {
         if (isPassword)
            this.PasswordChar = '*';
         else
            this.PasswordChar = default(char);

         isPassword = !isPassword;
      }

      private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
         {
            e.Handled = true;
         }
      }

      [System.Runtime.InteropServices.DllImport("user32.dll")]
      private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
   }
}
