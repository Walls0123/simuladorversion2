using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos.Manager;
using Modelos.Modelos;

namespace CNegocio.Plataforma
{
    public class TipoMonedaMethods
    {
        private TipoMonedaManager tipoMonedaManager;

        public TipoMonedaMethods()
        {
            tipoMonedaManager = new TipoMonedaManager();
        }

        public bool Crear(TipoMonedaModel aTipoMoneda)
        {
            return this.tipoMonedaManager.Insert(aTipoMoneda);
        }

        public bool Editar(TipoMonedaModel aTipoMoneda)
        {
            return this.tipoMonedaManager.Update(aTipoMoneda);
        }

        public bool Eliminar(int aID_tipoMoneda)
        {
            return this.tipoMonedaManager.Delete(aID_tipoMoneda);
        }

        public TipoMonedaModel ObtenerUno(int aID_TipoMoneda)
        {
            return this.tipoMonedaManager.GetTipoMonedaModel(aID_TipoMoneda);
        }

        public List<TipoMonedaModel> ObtenerTodos()
        {
            return this.tipoMonedaManager.TipoMonedaModelSelectAll();
        }
    }
}
