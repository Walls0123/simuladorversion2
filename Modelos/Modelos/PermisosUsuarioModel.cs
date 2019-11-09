using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class PermisosUsuarioModel
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
        public int? Id_usuario
        { get; set; }
        public string Descripcion { get; set; }
        /// <summary>
        /// Gets or sets the Id_rol value.
        /// </summary>
        public int? Id_rol
        { get; set; }

        /// <summary>
        /// Gets or sets the Id_componente value.
        /// </summary>
        public int? Id_componente
        { get; set; }

        /// <summary>
        /// Gets or sets the Estado value.
        /// </summary>
        public bool Estado
        { get; set; }

        #endregion
    }

}
