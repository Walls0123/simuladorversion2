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
    public class PrestamoManager
    {
        #region Methods

        /// <summary>
        /// Saves a record to the prestamo table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(PrestamosModel aprestamo)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@FechaPrestamo", aprestamo.Fechaprestamo);
                    command.Parameters.AddWithValue("@MontoPrestamo", aprestamo.Montoprestamo);
                    command.Parameters.AddWithValue("@Moneda", aprestamo.Moneda);
                    command.Parameters.AddWithValue("@PlazoMeses", aprestamo.Plazomeses);
                    command.Parameters.AddWithValue("@Porcentaje_Interes", aprestamo.Porcentaje_interes);
                    command.Parameters.AddWithValue("@Seguro", aprestamo.Seguro);
                    command.Parameters.AddWithValue("@Cuenta", aprestamo.Cuenta);
                    command.Parameters.AddWithValue("@Interes_Moratorio", aprestamo.Interes_moratorio == null ? (object)DBNull.Value : aprestamo.Interes_moratorio);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aprestamo.Fecha_modificacion == null ? (object)DBNull.Value : aprestamo.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aprestamo.Usuario_creador == null ? (object)DBNull.Value : aprestamo.Usuario_creador);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aprestamo.Fecha_creacion == null ? (object)DBNull.Value : aprestamo.Fecha_creacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aprestamo.Usuario_modificador == null ? (object)DBNull.Value : aprestamo.Usuario_modificador);
                    command.Parameters.AddWithValue("@DiaPago", aprestamo.Diapago == null ? (object)DBNull.Value : aprestamo.Diapago);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "PrestamosInsert";

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
        /// Updates a record to the prestamo table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(PrestamosModel aprestamo)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@ID", aprestamo.Id);
                    command.Parameters.AddWithValue("@FechaPrestamo", aprestamo.Fechaprestamo);
                    command.Parameters.AddWithValue("@MontoPrestamo", aprestamo.Montoprestamo);
                    command.Parameters.AddWithValue("@Moneda", aprestamo.Moneda);
                    command.Parameters.AddWithValue("@PlazoMeses", aprestamo.Plazomeses);
                    command.Parameters.AddWithValue("@Porcentaje_Interes", aprestamo.Porcentaje_interes);
                    command.Parameters.AddWithValue("@Seguro", aprestamo.Seguro);
                    command.Parameters.AddWithValue("@Cuenta", aprestamo.Cuenta);
                    command.Parameters.AddWithValue("@Interes_Moratorio", aprestamo.Interes_moratorio == null ? (object)DBNull.Value : aprestamo.Interes_moratorio);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aprestamo.Fecha_modificacion == null ? (object)DBNull.Value : aprestamo.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aprestamo.Usuario_creador == null ? (object)DBNull.Value : aprestamo.Usuario_creador);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aprestamo.Usuario_modificador == null ? (object)DBNull.Value : aprestamo.Usuario_modificador);
                    command.Parameters.AddWithValue("@DiaPago", aprestamo.Diapago == null ? (object)DBNull.Value : aprestamo.Diapago);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "PrestamosUpdate";

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
        /// Deletes record to the prestamo table.
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
                    command.CommandText = "prestamosDelete";
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
        /// Selects the Single object of prestamo table.
        /// </summary>
        public PrestamosModel Getprestamo(int aID)
        {
            PrestamosModel prestamo = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@ID", aID);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "prestamosSelect";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int ID = (int)(reader["ID"]);
                            DateTime FechaPrestamo = (DateTime)(reader["FechaPrestamo"]);
                            decimal MontoPrestamo = (decimal)(reader["MontoPrestamo"]);
                            int Moneda = (int)(reader["Moneda"]);
                            int PlazoMeses = (int)(reader["PlazoMeses"]);
                            decimal Porcentaje_Interes = (decimal)(reader["Porcentaje_Interes"]);
                            bool Seguro = (bool)(reader["Seguro"]);
                            string Cuenta = (string)(reader["Cuenta"]);
                            decimal? Interes_Moratorio = reader["Interes_Moratorio"] as decimal?;
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = reader["USUARIO_MODIFICADOR"] as string;
                            int? DiaPago = reader["DiaPago"] as int?;
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);

                            prestamo = new PrestamosModel
                            {
                                Id = ID,
                                Fechaprestamo = FechaPrestamo,
                                Montoprestamo = MontoPrestamo,
                                Moneda = Moneda,
                                Plazomeses = PlazoMeses,
                                Porcentaje_interes = Porcentaje_Interes,
                                Seguro = Seguro,
                                Cuenta = Cuenta,
                                Interes_moratorio = Interes_Moratorio,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Diapago = DiaPago,
                                Fecha_creacion = FECHA_CREACION,

                            };
                        }
                    }
                }

                return prestamo;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of prestamo table.
        /// </summary>
        public List<PrestamosModel> prestamoSelectAll()
        {

            List<PrestamosModel> prestamolist = new List<PrestamosModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "prestamosSelectAll";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            DateTime FechaPrestamo = (DateTime)(reader["FechaPrestamo"]);
                            decimal MontoPrestamo = (decimal)(reader["MontoPrestamo"]);
                            int Moneda = (int)(reader["Moneda"]);
                            int PlazoMeses = (int)(reader["PlazoMeses"]);
                            decimal Porcentaje_Interes = (decimal)(reader["Porcentaje_Interes"]);
                            bool Seguro = (bool)(reader["Seguro"]);
                            string Cuenta = (string)(reader["Cuenta"]);
                            decimal? Interes_Moratorio = reader["Interes_Moratorio"] as decimal?;
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = reader["USUARIO_MODIFICADOR"] as string;
                            int? DiaPago = reader["DiaPago"] as int?;
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);

                            prestamolist.Add(new PrestamosModel
                            {
                                Id = ID,
                                Fechaprestamo = FechaPrestamo,
                                Montoprestamo = MontoPrestamo,
                                Moneda = Moneda,
                                Plazomeses = PlazoMeses,
                                Porcentaje_interes = Porcentaje_Interes,
                                Seguro = Seguro,
                                Cuenta = Cuenta,
                                Interes_moratorio = Interes_Moratorio,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Diapago = DiaPago,
                                Fecha_creacion = FECHA_CREACION,

                            });
                        }
                    }
                }

                return prestamolist;
            }
            catch (Exception)
            {
                return prestamolist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of prestamo table by a given criteria.
        /// </summary>
        public List<PrestamosModel> prestamoSelectbyID(string aId)
        {

            List<PrestamosModel> prestamolist = new List<PrestamosModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@ID", aId);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "prestamosSelectbyId";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            DateTime FechaPrestamo = (DateTime)(reader["FechaPrestamo"]);
                            decimal MontoPrestamo = (decimal)(reader["MontoPrestamo"]);
                            int Moneda = (int)(reader["Moneda"]);
                            int PlazoMeses = (int)(reader["PlazoMeses"]);
                            decimal Porcentaje_Interes = (decimal)(reader["Porcentaje_Interes"]);
                            bool Seguro = (bool)(reader["Seguro"]);
                            string Cuenta = (string)(reader["Cuenta"]);
                            decimal? Interes_Moratorio = reader["Interes_Moratorio"] as decimal?;
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            DateTime FECHA_CREACION = (DateTime)reader["FECHA_CREACION"];
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = reader["USUARIO_MODIFICADOR"] as string;
                            int? DiaPago = reader["DiaPago"] as int?;

                            prestamolist.Add(new PrestamosModel
                            {
                                Id = ID,
                                Fechaprestamo = FechaPrestamo,
                                Montoprestamo = MontoPrestamo,
                                Moneda = Moneda,
                                Plazomeses = PlazoMeses,
                                Porcentaje_interes = Porcentaje_Interes,
                                Seguro = Seguro,
                                Cuenta = Cuenta,
                                Interes_moratorio = Interes_Moratorio,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Diapago = DiaPago,
                                Fecha_creacion = FECHA_CREACION

                            });
                        }
                    }
                }

                return prestamolist;
            }
            catch (Exception)
            {
                //throw;
                return prestamolist;
            }
        }

        /// <summary>
        /// Selects the Multiple objects of prestamo table by a given criteria.
        /// </summary>
        public List<PrestamosModel> prestamoSelectbyNroCuenta(string aNumero_cuenta)
        {

            List<PrestamosModel> prestamolist = new List<PrestamosModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Cuenta", aNumero_cuenta);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "PrestamosSelectAllByCuenta";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            DateTime FechaPrestamo = (DateTime)(reader["FechaPrestamo"]);
                            decimal MontoPrestamo = (decimal)(reader["MontoPrestamo"]);
                            int Moneda = (int)(reader["Moneda"]);
                            int PlazoMeses = (int)(reader["PlazoMeses"]);
                            decimal Porcentaje_Interes = (decimal)(reader["Porcentaje_Interes"]);
                            bool Seguro = (bool)(reader["Seguro"]);
                            string Cuenta = (string)(reader["Cuenta"]);
                            decimal? Interes_Moratorio = reader["Interes_Moratorio"] as decimal?;
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = reader["USUARIO_MODIFICADOR"] as string;
                            int? DiaPago = reader["DiaPago"] as int?;
                            DateTime FECHA_CREACION = (DateTime)reader["FECHA_CREACION"];

                            prestamolist.Add(new PrestamosModel
                            {
                                Id = ID,
                                Fechaprestamo = FechaPrestamo,
                                Montoprestamo = MontoPrestamo,
                                Moneda = Moneda,
                                Plazomeses = PlazoMeses,
                                Porcentaje_interes = Porcentaje_Interes,
                                Seguro = Seguro,
                                Cuenta = Cuenta,
                                Interes_moratorio = Interes_Moratorio,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Diapago = DiaPago,
                                Fecha_creacion = FECHA_CREACION
                            });
                        }
                    }
                }

                return prestamolist;
            }
            catch (Exception)
            {
                //throw;
                return prestamolist;
            }
        }

        /// <summary>
        /// Selects the Multiple objects of CronogramaPagosModel table by a given criteria.
        /// </summary>
        public List<CronogramaPagosModel> CronogramaPagosModelSelectbyIdPrestamo(int id_prestamo)
        {

            List<CronogramaPagosModel> CronogramaPagosModellist = new List<CronogramaPagosModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@id_prestamo", id_prestamo);

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
                                case 0: estado_s = "POR PAGAR";
                                    break;
                                case 1: estado_s = "CANCELADO";
                                    break;
                                case 2: estado_s = "ANULADO";
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
                //throw;
                return CronogramaPagosModellist;
            }
        }

        #endregion

    }

}
