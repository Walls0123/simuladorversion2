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
    interface ICajaChicaService
    {
        [OperationContract]
        int Crear(CajaChicaModel aCajaChica,int id_user);

        [OperationContract]
        bool Editar(CajaChicaModel aCajaChica, int id_user);

        [OperationContract]
        bool Eliminar(int aID_CajaChica);

        [OperationContract]
        CajaChicaModel ObtenerUno(int aID_CajaChica);

        [OperationContract]
        List<CajaChicaModel> ObtenerTodos();
    }
}
