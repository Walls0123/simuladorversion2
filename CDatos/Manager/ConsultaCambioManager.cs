using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Manager
{
   public class ConsultaCambioManager
    {
        public ConsultaCambio GetConsultaCambio()
        {
            ConsultaCambio consultaCambio = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "ColsultaCambioSelectbyDate";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            decimal compra = (decimal)(reader[0]);
                            decimal venta = (decimal)(reader[1]);


                            consultaCambio = new ConsultaCambio
                            {
                               Compra = compra,
                               Venta = venta

                            };
                        }
                    }
                }

                return consultaCambio;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
