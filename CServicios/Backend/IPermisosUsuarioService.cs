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
    interface IPermisosUsuarioService
    {
        [OperationContract]
        bool PermisosUsuario_Crear(PermisosUsuarioModel aPermisosUsuario, int id_user);

        [OperationContract]
        bool PermisosUsuario_Editar(PermisosUsuarioModel aPermisosUsuario, int id_user);

        [OperationContract]
        bool PermisosUsuario_Eliminar(int aID_PermisosUsuario);

        [OperationContract]
        PermisosUsuarioModel PermisosUsuario_ObtenerUno(int aID_PermisosUsuario);

        [OperationContract]
        List<PermisosUsuarioModel> PermisosUsuario_ObtenerTodos(int IdUsuario);

        [OperationContract]
        List<PermisosUsuarioModel> PermisosUsuarioXusuario(int IdUsuario);
    }
}
