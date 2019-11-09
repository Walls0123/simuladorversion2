using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos.Manager;
using Modelos.Modelos;

namespace CNegocio.Plataforma
{
    public class BLCuenta
    {
        CuentaManager managerCuenta = new CuentaManager();

        #region Methods
        /// <summary>
        /// Saves a record to the cuenta table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(CuentasModel acuenta)
        {
            return this.managerCuenta.Insert(acuenta);
        }


        /// <summary>
        /// Updates a record to the cuenta table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(CuentasModel acuenta)
        {
            return this.managerCuenta.Update(acuenta);
        }


        /// <summary>
        /// Deletes record to the cuenta table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Delete(string aNroCuenta)
        {
            return this.managerCuenta.Delete(aNroCuenta);
        }


        /// <summary>
        /// Selects the Single object of cuenta table.
        /// </summary>
        public CuentasModel Getcuenta(string aNroCuenta)
        {
            return this.managerCuenta.Getcuenta(aNroCuenta);
        }


        /// <summary>
        /// Selects all the objects of cuenta table.
        /// </summary>
        public List<CuentasModel> cuentaSelectAll()
        {
            return this.managerCuenta.cuentaSelectAll();
        }

        public List<CuentasModel> cuentaSelectbyId_cliente(int id_cliente)
        {
            return this.managerCuenta.cuentaSelectbyId_cliente(id_cliente);
        }

        public List<CuentasModel> cuentaSelectbyNroCuenta(string numero_cuenta)
        {
            return this.managerCuenta.cuentaSelectbyNroCuenta(numero_cuenta);
        }

        public List<CuentasModel> cuentaSelectbyNroCuentaPrestamo(string numero_cuenta)
        {
            return this.managerCuenta.cuentaSelectbyNroCuentaPrestamo(numero_cuenta);
        }

        #endregion

    }
}
