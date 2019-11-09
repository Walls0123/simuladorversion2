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
   public class RetirosManager
    {
        public string RetiroInsert(CuentasTarjetasModel cuentas)
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


                    command.Parameters.AddWithValue("@Monto",cuentas.Monto);
                    command.Parameters.AddWithValue("@NroCuenta", cuentas.NroCuenta);
                    command.Parameters.AddWithValue("@Clave",cuentas.clave);
                    command.Parameters.AddWithValue("@doi", cuentas.doi);
                    command.Parameters.AddWithValue("@Usuario", cuentas.Usuario);
                    command.Parameters.AddWithValue("@RowVer", cuentas.RowVersion);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "RetirosInsert";

                    object a = command.ExecuteScalar();

                    if (a != null)
                        afectados = (string)a;
                    else
                        afectados = "Transferido";

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();
                    connection.Dispose();
                    return afectados;
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
