using CDatos.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Ventanilla
{
   public class _RetiroMethods
   {
      private _RetiroManager manager;
      public _RetiroMethods()
      {
         manager = new _RetiroManager();
      }

      public bool ConsultarClientePorNroCuenta(Int64 NroCuenta, ref string[] result)
      {
         try
         {
            return manager.RETISS_UnReg(NroCuenta,ref result);
         }
         catch (Exception)
         {

            throw;
         }
      }
   }
}
