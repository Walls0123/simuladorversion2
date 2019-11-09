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
   public class _PersonaManager
   {
      public bool PERSSS_UnTodos(Int64 NroDNI, ref List<PersonaModel> result)
      {
         bool exito = false;
         try
         {
            using (var connection = Util.ConnectionFactory.conexion())
            {
               connection.Open();

               SqlCommand command = connection.CreateCommand();

               command.Parameters.AddWithValue("@NRO_DOCUMENTO", NroDNI);
               command.CommandType = CommandType.StoredProcedure;
               command.CommandText = "PERSSS_UnTodos";

               SqlDataReader reader = command.ExecuteReader();
               result = new List<PersonaModel>();
               if (reader.HasRows)
               {
                  while (reader.Read())
                  {

                     string _nroDocumento = (string)(reader["NroDocumento"]);
                     string _apellidos = (string)(reader["Apellidos"]);
                     string _nombres = (string)(reader["Nombres"]);

                     result.Add(new PersonaModel {
                        Nrodocumento = _nroDocumento,
                        Nombres = _nombres,
                        Apellidos = _apellidos
                     });

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
