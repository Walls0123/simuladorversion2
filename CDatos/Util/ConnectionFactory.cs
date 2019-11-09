using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Util
{
    public static class ConnectionFactory
    {
        private const string cadenaconexion = "Persist Security Info=False;User ID=DB_A48A9F_elviscaceres777_admin;Password=123456Abc;Data Source=SQL5036.site4now.net;";

        //private const string cadenaconexion = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DB_A48A9F_elviscaceres777";
        public static SqlConnection conexion()
        {
            try
            {
                return new SqlConnection(cadenaconexion);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
