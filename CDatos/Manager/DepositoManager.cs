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
    public class DepositoManager
    {
        public string Insert(Deposito Dep)
        {
            string afectados;
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                   
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@NroCuenta", Dep.NroCuenta);
                    command.Parameters.AddWithValue("@Monto", Dep.Monto);
                    command.Parameters.AddWithValue("@doi", Dep.Doi);
                    command.Parameters.AddWithValue("@Usuario", Dep.Usuario);
                    command.Parameters.AddWithValue("@RowVer", Dep.RowVer);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "DepositosInsert";

                    object a = command.ExecuteScalar();

                    if (a != null)
                        afectados = (string)a;
                    else
                        afectados = "Transferido";

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();
                    connection.Dispose();

                    //if (afectados > 0)
                    return afectados;
                    //else
                    //    return false;
                }
            }
            catch (SqlException e)
            {
                afectados = e.Errors[0].Message.ToString();
                return afectados;
            }
               
           
        }
    }
}
