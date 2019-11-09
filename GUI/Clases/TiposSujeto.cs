using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancario.Clases
{
    public class TiposSujeto
    {
        private static TiposSujeto instance = null;
        public static TiposSujeto Instance
        {
            get
            {
                if (instance == null)
                    instance = new TiposSujeto();
                return instance;
            }
        }
        public List<string> Sujetos;
        private TiposSujeto()
        {
            Sujetos = new List<string>();
            Sujetos.Add("Ventanilla");
            Sujetos.Add("Bodega");
        }
    }
}
