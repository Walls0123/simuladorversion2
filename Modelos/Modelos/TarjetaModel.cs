using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class TarjetaModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Numero value.
        /// </summary>
        public int Numero
        { get; set; }

        /// <summary>
        /// Gets or sets the Password value.
        /// </summary>
        public int? Password
        { get; set; }

        /// <summary>
        /// Gets or sets the Codcontrol value.
        /// </summary>
        public int Codcontrol
        { get; set; }

        /// <summary>
        /// Gets or sets the Fechavencimiento value.
        /// </summary>
        public DateTime? Fechavencimiento
        { get; set; }

        /// <summary>
        /// Gets or sets the Fechavinculacion value.
        /// </summary>
        public DateTime? Fechavinculacion
        { get; set; }

        /// <summary>
        /// Gets or sets the Fechavinculacion value.
        /// </summary>
        public string Id_cuenta
        { get; set; }

        /// <summary>
        /// Gets or sets the Estado value.
        /// </summary>
        public bool Estado
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha_modificacion value.
        /// </summary>
        public DateTime? Fecha_modificacion
        { get; set; }

        /// <summary>
        /// Gets or sets the Usuario_creador value.
        /// </summary>
        public string Usuario_creador
        { get; set; }

        /// <summary>
        /// Gets or sets the Usuario_modificador value.
        /// </summary>
        public string Usuario_modificador
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha_creacion value.
        /// </summary>
        public DateTime Fecha_creacion
        { get; set; }


        #endregion
    }


}
