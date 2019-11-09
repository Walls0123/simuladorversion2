using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bancario.Config
{
   public static class CloseApplication
   {

      private static ApplicationContext _appContext;

      public static void Run()
      {
         _appContext = new ApplicationContext();
         Application.Run(_appContext);
      }

      public static void Run(ApplicationContext context)
      {

         if (context == null) throw new ArgumentNullException(nameof(context));

         _appContext = context;

         if (context.MainForm != null)
            context.MainForm.Closed += ClosedEventHandler;

         Application.Run(context);
      }

      public static void Run(Form form)
      {
         if (form == null) throw new ArgumentNullException(nameof(form));

         form.Closed += ClosedEventHandler;
         _appContext = new ApplicationContext { MainForm = form };
         Application.Run(_appContext);
      }
      private static void ClosedEventHandler(object sender, EventArgs e)
      {
         if (sender == null) throw new ArgumentNullException(nameof(sender));
         if (e == null) throw new ArgumentNullException(nameof(e));

         if (_appContext.MainForm != sender || Application.OpenForms.Count == 0)
            return;

         foreach (Form form in Application.OpenForms)
         {

            if (form == sender) continue;

            _appContext.MainForm = form;
            _appContext.MainForm.Closed += ClosedEventHandler;
            return;
         }

      }
   }
}
