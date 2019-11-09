using CDatos.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Plataforma
{
    public static class BLFechaHoraServidor
    {
        public static DateTime? Obtener()
        {
            return HoraFechaServidorManager.ObtenerFechaHora();
        }
    }
}
