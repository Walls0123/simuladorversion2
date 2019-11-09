using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Backend
{
    public class SucursalMethods
    {
        private SucursalManager ADSucursalManager;

        public SucursalMethods()
        {
            ADSucursalManager = new SucursalManager();
        }

        /// <summary>
        /// Saves a record to the sucursal table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>	
        public bool Crear(SucursalModel aSucursal, int id_user)
        {
            return ADSucursalManager.Insert(aSucursal, id_user);
        }

        /// <summary>
        /// Updates a record to the sucursal table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Editar(SucursalModel aSucursal, int id_user)
        {
            return ADSucursalManager.Update(aSucursal, id_user);
        }

        public bool Eliminar(int aID_Sucursal)
        {
            return ADSucursalManager.Delete(aID_Sucursal);
        }

        public SucursalModel ObtenerUno(int aID_Sucursal)
        {
            return ADSucursalManager.GetSucursalModel(aID_Sucursal);
        }

        public List<SucursalModel> ObtenerTodos()
        {
            return ADSucursalManager.SucursalModelSelectAll();
        }
    }
}
