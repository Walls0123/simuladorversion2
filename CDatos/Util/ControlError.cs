using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.Modelos;

namespace CDatos.Util
{
    public static class ControlError
    {
        public static void SaveException(ControlErroresModel aControlErroresModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    //connection.Open();

                    //SqlTransaction sqlTran = connection.BeginTransaction();

                    //SqlCommand command = connection.CreateCommand();

                    //command.Transaction = sqlTran;

                    //command.Parameters.AddWithValue("@Usuario", aControlErroresModel.Usuario);
                    //command.Parameters.AddWithValue("@Fecha", aControlErroresModel.Fecha);
                    //command.Parameters.AddWithValue("@Componente", aControlErroresModel.Componente);
                    //command.Parameters.AddWithValue("@Descripcion", aControlErroresModel.Descripcion == null ? (object)DBNull.Value : aControlErroresModel.Descripcion);


                    //command.CommandType = CommandType.StoredProcedure;
                    //command.CommandText = "ControlErroresModelInsert";


                    //// Commit the transaction.
                    //sqlTran.Commit();

                    //connection.Close();
                    //connection.Dispose();

                }
            }
            catch (Exception)
            {

            }
        }

    }
}
