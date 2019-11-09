using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using XWFControlLibrary.JsonEntities;

namespace XWFControlLibrary.Config
{
   public static class JsonServices
   {
      public static Money GET_Money()
      {
         using (WebClient webClient = new WebClient())
         {
            string uri = "http://www.floatrates.com/daily/pen.json";
            String json = webClient.DownloadString(uri);
            return JsonConvert.DeserializeObject<Money>(json);
         }
      }

      public static Entidad GET_Entidad(string ruc)
      {
         using (WebClient webClient = new WebClient())
         {
            string uri = string.Concat("https://api.sunat.cloud/ruc/", ruc);
            String json = webClient.DownloadString(uri);
            return JsonConvert.DeserializeObject<Entidad>(json);
         }
      }
   }
}
