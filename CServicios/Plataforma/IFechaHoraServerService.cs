using Modelos.Modelos;
using System.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Plataforma
{
    [ServiceContract]
    interface IFechaHoraServerService
    {
        [OperationContract]
        DateTime? ObtenerFechaHoraActual();
    }
}