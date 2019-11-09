using CNegocio.Ventanilla;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XWFControlLibrary.UI.help;

namespace XWFControlLibrary.UI.control
{
   public class DNITextBox : TextBox
   {
      private _PersonaMethods methods = null;
      public DNITextBox() : base()
      {
         methods = new _PersonaMethods();
         Button _btnSearch = new Button();
         _btnSearch.Size = new System.Drawing.Size(25, this.ClientSize.Height + 2);
         _btnSearch.Location = new System.Drawing.Point(this.ClientSize.Width - _btnSearch.Width, -1);
         _btnSearch.Cursor = Cursors.Default;
         _btnSearch.Anchor = AnchorStyles.Right;
         _btnSearch.Image = Properties.Resources.search;
         _btnSearch.Click += _btnViewPassword_Click;
         this.KeyPress += NumberTextBox_KeyPress;
         this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Controls.Add(_btnSearch);

         SendMessage(this.Handle, 0xd3, (IntPtr)2, (IntPtr)(_btnSearch.Width << 48));
      }

      private void _btnViewPassword_Click(object sender, EventArgs e)
      {
         List<PersonaModel> result = null;
         string value = this.Text;
         if (!string.IsNullOrEmpty(value))
         {
            if (methods.ObtenerPersonasPorDNI(Convert.ToInt64(value),ref result))
            {
               HelpViewDNI help = new HelpViewDNI();
               help.SetView(result);
               if (help.ShowDialog() == DialogResult.OK)
                  this.Text = help.row;
            }
         }
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
