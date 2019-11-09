using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Modelos.Modelos
{
    public class RecaudosModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Nro_contrato value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Nro_contrato")]
        public int Nro_contrato
        { get; set; }

        /// <summary>
        /// Gets or sets the Monto value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Monto")]
        public decimal Monto
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha_vencimiento value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Fecha_vencimiento")]
        public DateTime Fecha_vencimiento
        { get; set; }

        /// <summary>
        /// Gets or sets the Estado_recaudo value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Estado_recaudo")]
        public string Estado_recaudo
        { get; set; }
        public byte[] RowVersion { get; set; }
        #endregion
    }

}
