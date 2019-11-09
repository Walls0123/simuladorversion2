using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancario.Clases
{
    public class TipoMovimiento
    {
        private static TipoMovimiento instance=null;
        public static TipoMovimiento Instance
        {
            get
            {
                if (instance == null)
                    instance = new TipoMovimiento();
                return instance;
            }
        }
        public List<string> Movimientos;
        private TipoMovimiento()
        {
            Movimientos = new List<string>();
            Movimientos.Add("Cargo");
            Movimientos.Add("Abono");
        }
    }
}
