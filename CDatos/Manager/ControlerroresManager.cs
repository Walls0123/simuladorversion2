using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.Modelos;

namespace CDatos.Manager
{
    public class ControlErroresManager
    {
        #region Methods
        /// <summary>
        /// Saves a record to the ControlErroresModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(ControlErroresModel aControlErroresModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@Usuario", aControlErroresModel.Usuario);
                    command.Parameters.AddWithValue("@Fecha", aControlErroresModel.Fecha);
                    command.Parameters.AddWithValue("@Componente", aControlErroresModel.Componente);
                    command.Parameters.AddWithValue("@Descripcion", aControlErroresModel.Descripcion == null ? (object)DBNull.Value : aControlErroresModel.Descripcion);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "RegistrarError";

                    int afectados = command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();
                    connection.Dispose();

                    if (afectados > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }


       
        #endregion

    }

}
