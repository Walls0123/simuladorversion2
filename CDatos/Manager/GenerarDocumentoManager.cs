using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Manager
{
   public class GenerarDocumentoManager
    {
        public List<string> GenerarDocumento()
        {
            List<string> Lista = new List<string>();
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "SelectGenerarDocumentoMovimiento";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {                                                
                           Lista.Add(reader[0].ToString());
                           Lista.Add(reader[1].ToString());
                           Lista.Add(reader[2].ToString());
                           Lista.Add(reader[3].ToString());
                           Lista.Add(reader[4].ToString());
                           Lista.Add(reader[5].ToString());
                           Lista.Add(reader[6].ToString());
                           Lista.Add(reader[7].ToString());
                           Lista.Add(reader[8].ToString());
                           Lista.Add(reader[9].ToString());
                           Lista.Add(reader[10].ToString());                           
                        }
                    }
                }

                return Lista;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
