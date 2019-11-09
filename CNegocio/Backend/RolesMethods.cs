using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CNegocio.Backend
{
    public class RolesMethods
    {
        private RolesManager ADRolesManager;

        public RolesMethods()
        {
            ADRolesManager = new RolesManager();
        }

        /// <summary>
        /// Saves a record to the roles table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>	
        public bool Crear(RolesModel aRoles)
        {
            return ADRolesManager.Insert(aRoles);
        }

        /// <summary>
        /// Updates a record to the roles table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Editar(RolesModel aRoles)
        {
            return ADRolesManager.Update(aRoles);
        }

        public bool Eliminar(int aID_Roles)
        {
            return ADRolesManager.Delete(aID_Roles);
        }

        public RolesModel ObtenerUno(int aID_Roles)
        {
            return ADRolesManager.GetRolesModel(aID_Roles);
        }

        public List<RolesModel> ObtenerTodos()
        {
            return ADRolesManager.RolesModelSelectAll();
        }

        public List<RolUsuarioModel> RolesPorPersona(int aID_Usuario)
        {
            return ADRolesManager.RolesPorPersona(aID_Usuario);
        }
    }
}
