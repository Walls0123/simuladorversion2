using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bancario.Config
{
   public static class UIForm
   {
      [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
      private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
          int nHeightEllipse
      );

      public static void SetRound(Form form, int round)
      {
         form.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width, form.Height, round, round));
      }
   }
}
