using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Manager
{
    public static class HoraFechaServidorManager
    {
        /// <summary>
        /// Selects the Single object of ChequesModel table.
        /// </summary>
        public static DateTime? ObtenerFechaHora()
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();


                    command.CommandType = CommandType.Text;

                    command.CommandText = "select GETDATE()";

                    SqlDataReader reader = command.ExecuteReader();
                    DateTime? fecha = null;

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            fecha = (DateTime)reader[0];
                        }
                    }

                    return fecha;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}

