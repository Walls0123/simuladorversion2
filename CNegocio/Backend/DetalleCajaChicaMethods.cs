using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Backend
{
    public class DetalleCajaChicaMethods
    {


        private DetalleCajaChicaManager ADDetalleCajaChicaManager;

        public DetalleCajaChicaMethods()
        {
            ADDetalleCajaChicaManager = new DetalleCajaChicaManager();
        }
        /// <summary>
        /// Saves a record to the detalle caja chica table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>	
        public bool Crear(DetalleCajaChicaModel aCajaChica, int id_user)
        {
            return ADDetalleCajaChicaManager.Insert(aCajaChica, id_user);
        }

        /// <summary>
        /// Updates a record to the detalle caja chica table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Editar(DetalleCajaChicaModel aCajaChica, int id_user)
        {
            return ADDetalleCajaChicaManager.Update(aCajaChica, id_user);
        }

        public bool Eliminar(int aID_CajaChica)
        {
            return ADDetalleCajaChicaManager.Delete(aID_CajaChica);
        }

        public DetalleCajaChicaModel ObtenerUno(int aID_CajaChica)
        {
            return ADDetalleCajaChicaManager.GetDetalleCajaChicaModel(aID_CajaChica);
        }

        public List<DetalleCajaChicaModel> ObtenerTodos()
        {
            return ADDetalleCajaChicaManager.Caja_ChicaModelSelectAll();
        }


    }
}
