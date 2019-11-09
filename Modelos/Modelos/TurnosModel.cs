using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class TurnosModel
    {
        #region Properties
        public int IdTurUsu
        { get; set; }
        /// <summary>
        /// Gets or sets the Id value.
        /// </summary>
        public int Id
        { get; set; }

        /// <summary>
        /// Gets or sets the Descripcion value.
        /// </summary>
        public string Descripcion
        { get; set; }

        /// <summary>
        /// Gets or sets the Hora_inicio value.
        /// </summary>
        public TimeSpan? Hora_inicio
        { get; set; }

        /// <summary>
        /// Gets or sets the Hora_fin value.
        /// </summary>
        public TimeSpan? Hora_fin
        { get; set; }

        #endregion
    }

}
