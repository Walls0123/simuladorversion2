using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class CronogramaPagosModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Id value.
        /// </summary>
        public int Id
        { get; set; }

        /// <summary>
        /// Gets or sets the Prestamo value.
        /// </summary>
        public int Prestamo
        { get; set; }

        /// <summary>
        /// Gets or sets the Fechapago value.
        /// </summary>
        public DateTime? DiaPago
        { get; set; }

        /// <summary>
        /// Gets or sets the Monto value.
        /// </summary>
        public decimal Monto
        { get; set; }

        /// <summary>
        /// Gets or sets the Amortizacion value.
        /// </summary>
        public decimal Amortizacion
        { get; set; }

        /// <summary>
        /// Gets or sets the Interes value.
        /// </summary>
        public decimal Interes
        { get; set; }

        /// <summary>
        /// Gets or sets the Seguro value.
        /// </summary>
        public decimal Seguro
        { get; set; }

        /// <summary>
        /// Gets or sets the Saldo value.
        /// </summary>
        public decimal Saldo
        { get; set; }

        /// <summary>
        /// Gets or sets the Diapago value.
        /// </summary>
        public DateTime? FechaCancelado
        { get; set; }

        /// <summary>
        /// Gets or sets the Estado value.
        /// </summary>
        public int Estado
        { get; set; }

        public string EstadoString
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha_creacion value.
        /// </summary>
        public DateTime Fecha_creacion
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
        public byte[] RowVer { get; set; }

        #endregion
    }

}
