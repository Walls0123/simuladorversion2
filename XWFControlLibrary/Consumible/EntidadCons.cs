using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XWFControlLibrary.Config;
using XWFControlLibrary.JsonEntities;

namespace XWFControlLibrary.Consumible
{
   public class EntidadCons
   {
      public readonly Entidad entidad = null; 
      public EntidadCons(string ruc)
      {
         entidad = JsonServices.GET_Entidad(ruc);
      }
   }
}
