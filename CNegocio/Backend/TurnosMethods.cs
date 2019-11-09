using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Backend
{
    public class TurnosMethods
    {
        private TurnosManager ADTurnosManager;

        public TurnosMethods()
        {
            ADTurnosManager = new TurnosManager();
        }


        /// <summary>
        /// Saves a record to the turnos table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>	
        public bool Crear(TurnosModel aTurnos, int id_user)
        {
            return ADTurnosManager.Insert(aTurnos, id_user);
        }

        /// <summary>
        /// Updates a record to the turnos table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Editar(TurnosModel aTurnos, int id_user)
        {
            return ADTurnosManager.Update(aTurnos, id_user);
        }

        public bool Eliminar(int aID_Turnos)
        {
            return ADTurnosManager.Delete(aID_Turnos);
        }

        public TurnosModel ObtenerUno(int aID_Turnos)
        {
            return ADTurnosManager.GetTurnosModel(aID_Turnos);
        }
        public TurnosModel ObtenerUnoXUsuario(int Id_usuario)
        {
            return ADTurnosManager.GetTurnosModelxUsuario(Id_usuario);
        }

        public List<TurnosModel> ObtenerTodos()
        {
            return ADTurnosManager.TurnosModelSelectAll();
        }
    }
}
