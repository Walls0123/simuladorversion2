using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Backend
{
    public class ComponenteMethods
    {
        private ComponenteManager ADComponenteManager;

        public ComponenteMethods()
        {
            ADComponenteManager = new ComponenteManager();
        }

        /// <summary>
        /// Saves a record to the componente table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>	
        public bool Crear(ComponenteModel aComponente, int id_user)
        {
            return ADComponenteManager.Insert(aComponente, id_user);
        }

        /// <summary>
        /// Updates a record to the componente table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Editar(ComponenteModel aComponente, int id_user)
        {
            return ADComponenteManager.Update(aComponente, id_user);
        }

        public bool Eliminar(int aID_Componente)
        {
            return ADComponenteManager.Delete(aID_Componente);
        }

        public ComponenteModel ObtenerUno(int aID_Componente)
        {
            return ADComponenteManager.GetComponenteModel(aID_Componente);
        }

        public List<ComponenteModel> ObtenerTodos()
        {
            return ADComponenteManager.ComponenteModelSelectAll();
        }

        public List<ComponenteModel> ObtenerComponentesRol(int aRol)
        {
            return ADComponenteManager.GetComponentesRol(aRol);
        }

        public List<ComponenteModel> ObtenerTodosComponentes()
        {
            return ADComponenteManager.ObtenerTodosComponentes();
        }



    }
}
