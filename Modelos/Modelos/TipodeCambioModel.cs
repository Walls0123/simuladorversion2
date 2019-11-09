using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
   public class TipodeCambioModel
    {

        public decimal MontoE { get; set; }
        public string MonedaE { get; set; }
        public decimal MontoS { get; set; }
        public string MonedaS { get; set; }
        public string Usuario { get; set; }

        /*
         * @MontoE decimal(12,4),
@MonedaE varchar(50),
@MontoS decimal(12,4),
@MonedaS varchar(50),
@ID_TurnoUsuario int,
@Usuario_Creador varchar(50)
         */
    }
}
