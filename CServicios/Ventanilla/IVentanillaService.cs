using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Ventanilla
{
    [ServiceContract]
    public interface IVentanillaService
    {
        [OperationContract]
        bool Ventanilla_Crear(VentanillaModel aVentanilla, int id_user);

        [OperationContract]
        bool Ventanilla_Editar(VentanillaModel aVentanilla, int id_user);

        [OperationContract]
        bool Ventanilla_Eliminar(int aID_VentanillaModel);

        [OperationContract]
        VentanillaModel Ventanilla_ObtenerUno(int aID_VentanillaModel);

        [OperationContract]
        VentanillaModel Ventanilla_ObtenerUnoXusuario(int Id_Usuario);

        [OperationContract]
        List<VentanillaModel> Ventanilla_ObtenerTodos();

        [OperationContract]
        List<VentanillaModel> GetVentanillasXSucursal(int Idsucursal,int Idturno);
    }
}
