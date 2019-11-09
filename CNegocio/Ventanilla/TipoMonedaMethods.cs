using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Ventanilla
{
    public  class TipoMonedaMethods
    {
        private TipoMonedaManager ADTipoMonedaManager;

        public TipoMonedaMethods()
        {
            ADTipoMonedaManager = new TipoMonedaManager();
        }

        public bool Crear(TipoMonedaModel aTipoMoneda)
        {
            return ADTipoMonedaManager.Insert(aTipoMoneda);
        }

        public bool Editar(TipoMonedaModel aTipoMoneda)
        {
            return ADTipoMonedaManager.Update(aTipoMoneda);
        }

        public bool Eliminar(int aID_Moneda)
        {
            return ADTipoMonedaManager.Delete(aID_Moneda);
        }

        public TipoMonedaModel ObtenerUno(int aID_Moneda)
        {
            return ADTipoMonedaManager.GetTipoMonedaModel(aID_Moneda);
        }

        public List<TipoMonedaModel> ObtenerTodos()
        {
            return ADTipoMonedaManager.TipoMonedaModelSelectAll();
        }
    }
}
