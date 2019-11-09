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
    interface IRolUsuarioService
    {
        [OperationContract]
        bool RolUsuario_Crear(RolUsuarioModel aRolUsuario, int id_user);

        [OperationContract]
        bool RolUsuario_Editar(RolUsuarioModel aRolUsuario, int id_user);

        [OperationContract]
        bool RolUsuario_Eliminar(int aID_RolUsuario);

        [OperationContract]
        RolUsuarioModel RolUsuario_ObtenerUno(int aID_RolUsuario);

        [OperationContract]
        List<RolUsuarioModel> RolUsuario_ObtenerTodos();
    }
}
