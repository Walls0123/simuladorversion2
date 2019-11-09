using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Ventanilla
{
   public class DepositoMethods
    {
        //Insert
        private DepositoManager depositoManager;

        public DepositoMethods()
        {
            depositoManager = new DepositoManager();
         //   

        }
        public string insert(Deposito dep)
        {
          return depositoManager.Insert(dep);
        }
    }
}
