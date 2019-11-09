using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Ventanilla
{
    public class TransferenciasMethods
    {
        private TransferenciasManager ADTransferenciasManager;

        public TransferenciasMethods()
        {
            ADTransferenciasManager = new TransferenciasManager();
        }

        public string RealizarTransferencia(CuentasTarjetasModel cuentasTarjetasModel)
        {
           return ADTransferenciasManager.TransferenciaBancaria(cuentasTarjetasModel);
        }
    }
}
