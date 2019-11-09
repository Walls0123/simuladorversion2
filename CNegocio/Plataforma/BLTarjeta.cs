using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos.Manager;
using Modelos.Modelos;

namespace CNegocio.Plataforma
{
    public class BLTarjeta
    {
        ManagerTarjeta managerTarjeta = new ManagerTarjeta();

        #region Methods
        /// <summary>
        /// Saves a record to the tarjeta table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(TarjetaModel atarjeta)
        {
            return this.managerTarjeta.Insert(atarjeta);
        }


        /// <summary>
        /// Updates a record to the tarjeta table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(TarjetaModel atarjeta)
        {
            return this.managerTarjeta.Update(atarjeta);
        }


        /// <summary>
        /// Deletes record to the tarjeta table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Delete(int aNumero)
        {
            return this.managerTarjeta.Delete(aNumero);
        }


        /// <summary>
        /// Selects the Single object of tarjeta table.
        /// </summary>
        public TarjetaModel Gettarjeta(int aNumero)
        {
            return this.managerTarjeta.Gettarjeta(aNumero);
        }


        public List<TarjetaModel> tarjetaSelectbyId(string aValue)
        {
            return this.managerTarjeta.tarjetaSelectbyId(aValue);
        }


        #endregion
    }
}
