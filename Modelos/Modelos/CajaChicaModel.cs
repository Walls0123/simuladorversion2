using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class CajaChicaModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Id value.
        /// </summary>
        public int Id
        { get; set; }

        /// <summary>
        /// Gets or sets the Tipo value.
        /// </summary>
        public string Tipo_Accion
        { get; set; }

        /// <summary>
        /// Gets or sets the Id_persona value.
        /// </summary>
        public int Id_TurnoUsuario1
        { get; set; }

        /// <summary>
        /// Gets or sets the Id_persona value.
        /// </summary>
        public int Id_TurnoUsuario2
        { get; set; }


        #endregion
    }

}
