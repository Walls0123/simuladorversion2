using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Backend
{
    public class PermisosUsuarioMethods
    {
        private PermisosUsuarioManager ADPermisosUsuarioManager;

        public PermisosUsuarioMethods()
        {
            ADPermisosUsuarioManager = new PermisosUsuarioManager();
        }

        /// <summary>
        /// Saves a record to the permisos usuario table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>	
        public bool Crear(PermisosUsuarioModel aPermisosUsuario, int id_user)
        {
            return ADPermisosUsuarioManager.Insert(aPermisosUsuario, id_user);
        }

        /// <summary>
        /// Updates a record to the permisos usuario table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Editar(PermisosUsuarioModel aPermisosUsuario, int id_user)
        {
            return ADPermisosUsuarioManager.Update(aPermisosUsuario, id_user);
        }

        public bool Eliminar(int aID_PermisosUsuario)
        {
            return ADPermisosUsuarioManager.Delete(aID_PermisosUsuario);
        }

        public PermisosUsuarioModel ObtenerUno(int aID_PermisosUsuario)
        {
            return ADPermisosUsuarioManager.GetPermisosUsuarioModel(aID_PermisosUsuario);
        }

        public List<PermisosUsuarioModel> ObtenerTodos()
        {
            return ADPermisosUsuarioManager.PermisosUsuarioModelSelectAll();
        }
        public List<PermisosUsuarioModel> ObtenerPermisosXUsaurio(int IdUsuario)
        {
            return ADPermisosUsuarioManager.PermisosUsuarioXUsuario(IdUsuario);
        }
    }
}
