using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancario.Clases
{
    public class Denominaciones
    {
        private static Denominaciones instance = null;
        public static Denominaciones Instance
        {
            get
            {
                if (instance == null)
                    instance = new Denominaciones();
                return instance;
            }
        }

        public List<string> dolares = new List<string>();

        public List<string> soles = new List<string>();
        private Denominaciones()
        {
            dolares.Add("1 dolar");
            dolares.Add("2 dolares");
            dolares.Add("5 dolares");
            dolares.Add("10 dolares");
            dolares.Add("20 dolares");
            dolares.Add("50 dolares");
            dolares.Add("100 dolares");

            soles.Add("10 soles");
            soles.Add("20 soles");
            soles.Add("50 soles");
            soles.Add("100 soles");
            soles.Add("200 soles");
        }
    }
}
