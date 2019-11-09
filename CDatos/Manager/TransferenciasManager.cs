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
   public class TransferenciasManager
    {

        public string TransferenciaBancaria(CuentasTarjetasModel cuentasTarjetasModel)
        {

            //   List<RecaudosModel> EmpresaModellist = new List<RecaudosModel>();
             string result="";
            try
            {          
                /*@Monto Decimal(12,4),
                @Clave int,
                @NroCuenta int,
                 @NroCuentaDestino int,
                 @doi int*/
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Monto", cuentasTarjetasModel.Monto);
                    command.Parameters.AddWithValue("@Clave", cuentasTarjetasModel.clave);
                    command.Parameters.AddWithValue("@NroCuenta", cuentasTarjetasModel.NroCuenta);
                    command.Parameters.AddWithValue("@NroCuentaDestino", cuentasTarjetasModel.NroCuentaDestino);
                    command.Parameters.AddWithValue("@doi", cuentasTarjetasModel.doi);
                    command.Parameters.AddWithValue("@Usuario", cuentasTarjetasModel.Usuario);
                    command.Parameters.AddWithValue("@NroTarjeta", cuentasTarjetasModel.NroTarjeta);
                    command.Parameters.AddWithValue("@ClaveTarjeta", cuentasTarjetasModel.ClaveTarjeta);
                    command.Parameters.AddWithValue("@RowVersion", cuentasTarjetasModel.RowVersion);
                    command.Parameters.AddWithValue("@RowVersionD", cuentasTarjetasModel.RowVersionD);
                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "TransferenciaInsert";

                  //  result = command.ExecuteScalar().ToString();
                    object a = command.ExecuteScalar();
                    if (a != null)
                        result = (string)a;
                    else
                        result = "Transferido";
                }

                return result;
            }
            catch (SqlException e)
            {
                result = e.Errors[0].Message.ToString();
                return result;
            }
        }

    }
}
