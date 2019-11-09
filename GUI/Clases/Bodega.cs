using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancario.Clases
{
    public class Bodega
    {
        private static Bodega instance = null;
        public static Bodega Instance
        {
            get
            {
                if (instance == null)
                    instance = new Bodega();
                return instance;
            }
        }
        public List<string> bodegueros;
        private Bodega()
        {
            bodegueros = new List<string>();
            bodegueros.Add("bodeguero 1");
            bodegueros.Add("bodeguero 2");
        }
    }
}
