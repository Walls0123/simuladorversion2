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
    public class CronogramaPagoManager
    {
        #region Methods

        /// <summary>
        /// Saves a record to the CronogramaPagosModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(CronogramaPagosModel aCronogramaPagosModel, string cuenta)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@CuentaPrestamo", cuenta);
                    command.Parameters.AddWithValue("@FechaPago", aCronogramaPagosModel.FechaCancelado == null ? (object)DBNull.Value : aCronogramaPagosModel.FechaCancelado);
                    command.Parameters.AddWithValue("@Monto", aCronogramaPagosModel.Monto);
                    command.Parameters.AddWithValue("@DiaPago", aCronogramaPagosModel.DiaPago);
                    command.Parameters.AddWithValue("@Estado", aCronogramaPagosModel.Estado);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aCronogramaPagosModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aCronogramaPagosModel.Fecha_modificacion == null ? (object)DBNull.Value : aCronogramaPagosModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aCronogramaPagosModel.Usuario_creador);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aCronogramaPagosModel.Usuario_modificador == null ? (object)DBNull.Value : aCronogramaPagosModel.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "CronogramaPagosInsert";

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
                //throw;
                return false;
            }
        }


        /// <summary>
        /// Updates a record to the CronogramaPagosModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(CronogramaPagosModel aCronogramaPagosModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@ID", aCronogramaPagosModel.Id);
                    command.Parameters.AddWithValue("@Prestamo", aCronogramaPagosModel.Prestamo);
                    command.Parameters.AddWithValue("@FechaPago", aCronogramaPagosModel.FechaCancelado);
                    command.Parameters.AddWithValue("@Monto", aCronogramaPagosModel.Monto);
                    command.Parameters.AddWithValue("@DiaPago", aCronogramaPagosModel.DiaPago);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aCronogramaPagosModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aCronogramaPagosModel.Fecha_modificacion == null ? (object)DBNull.Value : aCronogramaPagosModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aCronogramaPagosModel.Usuario_creador);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aCronogramaPagosModel.Usuario_modificador == null ? (object)DBNull.Value : aCronogramaPagosModel.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "CronogramaPagosModelUpdate";

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


        /// <summary>
        /// Deletes record to the CronogramaPagosModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Delete(int aID)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@ID", aID);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "CronogramaPagosModelDelete";
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


        /// <summary>
        /// Selects the Single object of CronogramaPagosModel table.
        /// </summary>
        public CronogramaPagosModel GetCronogramaPagosModel(int aID)
        {
            CronogramaPagosModel CronogramaPagosModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@ID", aID);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "CronogramaPagosModelSelect";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            int Prestamo = (int)(reader["Prestamo"]);
                            DateTime? DiaPago = (reader["DiaPago"]) as DateTime?;
                            decimal Monto = (decimal)(reader["Monto"]);
                            decimal Amortizacion = (decimal)(reader["Amortizacion"]);
                            decimal Interes = (decimal)(reader["Interes"]);
                            decimal Seguro = (decimal)(reader["Seguro"]);
                            decimal Saldo = (decimal)(reader["Saldo"]);
                            DateTime? FechaCancelado = (reader["FechaCancelado"]) as DateTime?;
                            int estado = (int)(reader["Estado"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = reader["USUARIO_MODIFICADOR"] as string;
                            string estado_s = "POR PAGAR";
                            switch (estado)
                            {
                                case 0:
                                    estado_s = "POR PAGAR";
                                    break;
                                case 1:
                                    estado_s = "CANCELADO";
                                    break;
                                case 2:
                                    estado_s = "ANULADO";
                                    break;
                            }

                            CronogramaPagosModel = new CronogramaPagosModel
                            {
                                Id = ID,
                                Prestamo = Prestamo,
                                DiaPago = DiaPago,
                                Monto = Monto,
                                Amortizacion = Amortizacion,
                                Interes = Interes,
                                Seguro = Seguro,
                                Saldo = Saldo,
                                FechaCancelado = FechaCancelado,
                                Estado = estado,
                                EstadoString = estado_s,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                            };
                        }
                    }
                }

                return CronogramaPagosModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of CronogramaPagosModel table.
        /// </summary>
        public List<CronogramaPagosModel> CronogramaPagosModelSelectAll()
        {

            List<CronogramaPagosModel> CronogramaPagosModellist = new List<CronogramaPagosModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "CronogramaPagosModelSelectAll";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            int Prestamo = (int)(reader["Prestamo"]);
                            DateTime? DiaPago = (reader["DiaPago"]) as DateTime?;
                            decimal Monto = (decimal)(reader["Monto"]);
                            decimal Amortizacion = (decimal)(reader["Amortizacion"]);
                            decimal Interes = (decimal)(reader["Interes"]);
                            decimal Seguro = (decimal)(reader["Seguro"]);
                            decimal Saldo = (decimal)(reader["Saldo"]);
                            DateTime? FechaCancelado = (reader["FechaCancelado"]) as DateTime?;
                            int estado = (int)(reader["Estado"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = reader["USUARIO_MODIFICADOR"] as string;
                            string estado_s = "POR PAGAR";
                            switch (estado)
                            {
                                case 0:
                                    estado_s = "POR PAGAR";
                                    break;
                                case 1:
                                    estado_s = "CANCELADO";
                                    break;
                                case 2:
                                    estado_s = "ANULADO";
                                    break;
                            }

                            CronogramaPagosModellist.Add(new CronogramaPagosModel
                            {
                                Id = ID,
                                Prestamo = Prestamo,
                                DiaPago = DiaPago,
                                Monto = Monto,
                                Amortizacion = Amortizacion,
                                Interes = Interes,
                                Seguro = Seguro,
                                Saldo = Saldo,
                                FechaCancelado = FechaCancelado,
                                Estado = estado,
                                EstadoString = estado_s,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                            });
                        }
                    }
                }

                return CronogramaPagosModellist;
            }
            catch (Exception)
            {
                return CronogramaPagosModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of CronogramaPagosModel table by a given criteria.
        /// </summary>
        public List<CronogramaPagosModel> CronogramaPagosModelSelectbyId(string aValue)
        {

            List<CronogramaPagosModel> CronogramaPagosModellist = new List<CronogramaPagosModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@id_prestamo", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "CronogramaSelectbyId";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            int Prestamo = (int)(reader["Prestamo"]);
                            DateTime? DiaPago = (reader["DiaPago"]) as DateTime?;
                            decimal Monto = (decimal)(reader["Monto"]);
                            decimal Amortizacion = (decimal)(reader["Amortizacion"]);
                            decimal Interes = (decimal)(reader["Interes"]);
                            decimal Seguro = (decimal)(reader["Seguro"]);
                            decimal Saldo = (decimal)(reader["Saldo"]);
                            DateTime? FechaCancelado = (reader["FechaCancelado"]) as DateTime?;
                            int estado = (int)(reader["Estado"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = reader["USUARIO_MODIFICADOR"] as string;
                            string estado_s = "POR PAGAR";
                            switch (estado)
                            {
                                case 0:
                                    estado_s = "POR PAGAR";
                                    break;
                                case 1:
                                    estado_s = "CANCELADO";
                                    break;
                                case 2:
                                    estado_s = "ANULADO";
                                    break;
                            }

                            CronogramaPagosModellist.Add(new CronogramaPagosModel
                            {
                                Id = ID,
                                Prestamo = Prestamo,
                                DiaPago = DiaPago,
                                Monto = Monto,
                                Amortizacion = Amortizacion,
                                Interes = Interes,
                                Seguro = Seguro,
                                Saldo = Saldo,
                                FechaCancelado = FechaCancelado,
                                Estado = estado,
                                EstadoString = estado_s,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                            });
                        }
                    }
                }

                return CronogramaPagosModellist;
            }
            catch (Exception)
            {
                return CronogramaPagosModellist;
            }
        }
        #endregion

    }

}
