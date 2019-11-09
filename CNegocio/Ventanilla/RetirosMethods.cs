using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Ventanilla
{
   public class RetirosMethods
    {
        private RetirosManager retirosManager;

        public RetirosMethods()
        {
            retirosManager = new RetirosManager();
        }
        //RetiroInsert
        public string InsertaRetiro(CuentasTarjetasModel cuenta)
        {
            return retirosManager.RetiroInsert(cuenta);
        }
    }
}
