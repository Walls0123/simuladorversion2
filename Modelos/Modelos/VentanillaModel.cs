using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Modelos.Modelos
{
    public class VentanillaModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Id_ventanilla value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Id_ventanilla")]
        public int Id_ventanilla
        { get; set; }

        /// <summary>
        /// Gets or sets the Descripcion value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Descripcion")]
        public string Descripcion
        { get; set; }

        /// <summary>
        /// Gets or sets the Idsucursal value.
        /// </summary>
        /// 
        [XmlElement(ElementName = "Idsucursal")]
        public int Idsucursal
        { get; set; }

        #endregion
    }

}