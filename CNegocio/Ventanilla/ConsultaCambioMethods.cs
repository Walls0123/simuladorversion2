using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Ventanilla
{
   public class ConsultaCambioMethods
    {
        ConsultaCambioManager consultaCambio = new ConsultaCambioManager();
        public ConsultaCambio TipodeCambio() {
          return consultaCambio.GetConsultaCambio();
        }       
    }
}
