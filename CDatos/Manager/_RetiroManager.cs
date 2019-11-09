using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Manager
{
   public class _RetiroManager
   {

      public bool RETISS_UnReg(Int64 NroCuenta,ref string[] result)
      {
         bool exito = false;
         try
         {
            using (var connection = Util.ConnectionFactory.conexion())
            {
               connection.Open();

               SqlCommand command = connection.CreateCommand();

               command.Parameters.AddWithValue("@NRO_CUENTA", NroCuenta);
               command.CommandType = CommandType.StoredProcedure;
               command.CommandText = "RETISS_UnReg";

               SqlDataReader reader = command.ExecuteReader();

               if (reader.HasRows)
               {
                  while (reader.Read())
                  {

                     string _nombres = (string)(reader["Nombres"]);
                     string _apellidos = (string)(reader["Apellidos"]);
                     string _nroDocumento = (string)(reader["NroDocumento"]);
                     string _nroCuenta = (string)(reader["NroCuenta"]);

                     result = new string[4];
                     result[0] = _nombres;
                     result[1] = _apellidos;
                     result[2] = _nroDocumento;
                     result[3] = _nroCuenta;

                     exito = true;
                  }
               }
            }

            return exito;
         }
         catch (Exception)
         {
            return exito;
         }
      }

   }
}
