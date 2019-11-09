using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Backend
{
    public class TurnoUsuarioMethods
    {
        private TurnoUsuarioManager ADTurnoUsuarioManager;

        public TurnoUsuarioMethods()
        {
            ADTurnoUsuarioManager = new TurnoUsuarioManager();
        }

        /// <summary>
        /// Saves a record to the turnos usuario table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>	
        public bool Crear(TurnoUsuarioModel aTurnoUsuario, int id_user)
        {
            return ADTurnoUsuarioManager.Insert(aTurnoUsuario, id_user);
        }

        /// <summary>
        /// Updates a record to the turno usuario table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Editar(TurnoUsuarioModel aTurnoUsuario, int id_user)
        {
            return ADTurnoUsuarioManager.Update(aTurnoUsuario, id_user);
        }

        public bool Eliminar(int aID_TurnoUsuario)
        {
            return ADTurnoUsuarioManager.Delete(aID_TurnoUsuario);
        }

        public TurnoUsuarioModel ObtenerUno(int aID_TurnoUsuario)
        {
            return ADTurnoUsuarioManager.GetTurnoUsuarioModel(aID_TurnoUsuario);
        }

        public List<TurnoUsuarioModel> ObtenerTodos()
        {
            return ADTurnoUsuarioManager.TurnoUsuarioModelSelectAll();
        }
    }
}
