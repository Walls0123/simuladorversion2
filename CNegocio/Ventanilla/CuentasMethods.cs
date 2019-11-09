using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Ventanilla
{
   public class CuentasMethods
    {
        public CuentaPersonaMonedaModel ValidarCuenta(string nrocuenta)
        {
            CuentaManager cuentaPersonaMonedaModel = new CuentaManager();
           return cuentaPersonaMonedaModel.ValidarCuenta(nrocuenta);
        }
        public List<CuentasPersona> ListaCuentas(string DNI)
        {
            CuentaManager cuentaPersonaMonedaModel = new CuentaManager();
            return cuentaPersonaMonedaModel.ListaCuentas(DNI);
        }
    }
}
