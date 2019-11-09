using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Backend
{
    public class BancoMethods
    {
        private BancoManager ADBancoManager;

        public BancoMethods()
        {
            ADBancoManager = new BancoManager();
        }

        /// <summary>
        /// Saves a record to the banco table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>	
        public bool Crear(BancoModel aBanco, int id_user)
        {
            return ADBancoManager.Insert(aBanco, id_user);
        }

        /// <summary>
        /// Updates a record to the banco table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>

        public bool Editar(BancoModel aBanco, int id_user)
        {
            return ADBancoManager.Update(aBanco, id_user);
        }

        public bool Eliminar(int aID_Banco)
        {
            return ADBancoManager.Delete(aID_Banco);
        }

        public BancoModel ObtenerUno(int aID_Banco)
        {
            return ADBancoManager.GetBancoModel(aID_Banco);
        }

        public List<BancoModel> ObtenerTodos()
        {
            return ADBancoManager.BancoModelSelectAll();
        }
    }
}

