using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class TurnoUsuarioModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Id value.
        /// </summary>
        public int Id
        { get; set; }


        /// <summary>
        /// Gets or sets the Id_usuario value.
        /// </summary>
        public int Id_usuario
        { get; set; }

        /// <summary>
        /// Gets or sets the Id_ventanilla value.
        /// </summary>
        public int Id_ventanilla
        { get; set; }

        /// <summary>
        /// Gets or sets the Id_turnos value.
        /// </summary>
        public int? Id_turno
        { get; set; }

        #endregion
    }

}