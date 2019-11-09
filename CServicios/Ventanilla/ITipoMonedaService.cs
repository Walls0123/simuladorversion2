using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Modelos.Modelos;

namespace ServiciosBancarios.Ventanilla
{
    [ServiceContract]
    public interface ITipoMonedaService
    {
        [OperationContract]
        bool Moneda_Crear(TipoMonedaModel aTipoMonedaModel);

        [OperationContract]
        bool Moneda_Editar(TipoMonedaModel aTipoMonedaModel);

        [OperationContract]
        bool Moneda_Eliminar(int aID_TipoMonedaModel);

        [OperationContract]
        TipoMonedaModel Moneda_ObtenerUno(int aID_TipoMonedaModel);

        [OperationContract]
        List<TipoMonedaModel> Moneda_ObtenerTodos();
    }
}
