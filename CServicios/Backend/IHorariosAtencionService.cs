using Modelos.Modelos;
using System.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Backend
{
    [ServiceContract]
    interface IHorariosAtencionService
    {
        [OperationContract]
        bool HorariosAtencion_Crear(HorariosAtencionModel aHorariosAtencion);

        [OperationContract]
        bool HorariosAtencion_Editar(HorariosAtencionModel aHorariosAtencion);

        [OperationContract]
        bool HorariosAtencion_Eliminar(int aID_HorariosAtencion);

        [OperationContract]
        HorariosAtencionModel HorariosAtencion_ObtenerUno(int aID_HorariosAtencion);

        [OperationContract]
        List<HorariosAtencionModel> HorariosAtencion_ObtenerTodos();
    }
}
