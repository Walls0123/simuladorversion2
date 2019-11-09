using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using XWFControlLibrary.Config;
using XWFControlLibrary.JsonEntities;

namespace XWFControlLibrary.Consumible
{
   public class MoneyCons
   {
      public readonly Money money = null;
      public MoneyCons()
      {
         money = JsonServices.GET_Money();
      }
   }
}
