using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Ventanilla
{
   public class _PersonaMethods
   {
      _PersonaManager manager = null;
      public _PersonaMethods()
      {
         manager = new _PersonaManager();
      }

      public bool ObtenerPersonasPorDNI(Int64 nroDNI, ref List<PersonaModel> result)
      {
         try
         {
            return manager.PERSSS_UnTodos(nroDNI, ref result);
         }
         catch (Exception)
         {

            throw;
         }
      }
   }
}
