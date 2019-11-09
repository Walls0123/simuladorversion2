﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class PrestamosModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Id value.
        /// </summary>
        public int Id
        { get; set; }

        /// <summary>
        /// Gets or sets the Fechaprestamo value.
        /// </summary>
        public DateTime Fechaprestamo
        { get; set; }

        /// <summary>
        /// Gets or sets the Montoprestamo value.
        /// </summary>
        public decimal Montoprestamo
        { get; set; }

        /// <summary>
        /// Gets or sets the Moneda value.
        /// </summary>
        public int Moneda
        { get; set; }

        /// <summary>
        /// Gets or sets the Plazomeses value.
        /// </summary>
        public int Plazomeses
        { get; set; }

        /// <summary>
        /// Gets or sets the Porcentaje_interes value.
        /// </summary>
        public decimal Porcentaje_interes
        { get; set; }

        /// <summary>
        /// Gets or sets the Seguro value.
        /// </summary>
        public bool Seguro
        { get; set; }

        /// <summary>
        /// Gets or sets the Cuenta value.
        /// </summary>
        public string Cuenta
        { get; set; }

        /// <summary>
        /// Gets or sets the Interes_moratorio value.
        /// </summary>
        public decimal? Interes_moratorio
        { get; set; }

        /// <summary>
        /// Gets or sets the MontoMensual value.
        /// </summary>
        public decimal? Monto_mensual
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha_modificacion value.
        /// </summary>
        public DateTime? Fecha_modificacion
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha_modificacion value.
        /// </summary>
        public DateTime Fecha_creacion
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
        /// Gets or sets the Diaago value.
        /// </summary>
        public int? Diapago
        { get; set; }


        #endregion
    }

}
