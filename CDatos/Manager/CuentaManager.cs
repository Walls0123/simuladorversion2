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
    public class CuentaManager
    {
        #region Methods
        /// <summary>
        /// Saves a record to the cuenta table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(CuentasModel acuenta)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@NroCuenta", acuenta.Nrocuenta);
                    command.Parameters.AddWithValue("@Estado", acuenta.Estado);
                    command.Parameters.AddWithValue("@SaldoContable", acuenta.Saldocontable);
                    command.Parameters.AddWithValue("@SaldoDisponible", acuenta.Saldodisponible);
                    command.Parameters.AddWithValue("@SobreGiro", acuenta.Sobregiro == null ? (object)DBNull.Value : acuenta.Sobregiro);
                    command.Parameters.AddWithValue("@TipoCuenta", acuenta.Tipocuenta);
                    command.Parameters.AddWithValue("@TipoMoneda", acuenta.Tipomoneda);
                    command.Parameters.AddWithValue("@Id_Tarjeta", acuenta.Id_tarjeta == null ? (object)DBNull.Value : acuenta.Id_tarjeta);
                    command.Parameters.AddWithValue("@ContChequeRebote1", acuenta.Contchequerebote1 == null ? (object)DBNull.Value : acuenta.Contchequerebote1);
                    command.Parameters.AddWithValue("@ContChequeRebote2", acuenta.Contchequerebote2 == null ? (object)DBNull.Value : acuenta.Contchequerebote2);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", acuenta.Usuario_creador);
                    command.Parameters.AddWithValue("@Cliente", acuenta.Cliente);
                    command.Parameters.AddWithValue("@FECHA_CREACION", acuenta.Fecha_creacion);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", acuenta.Fecha_modificacion == null ? (object)DBNull.Value : acuenta.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", acuenta.Usuario_modificador == null ? (object)DBNull.Value : acuenta.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "CuentasInsert";

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
        /// Updates a record to the cuenta table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(CuentasModel acuenta)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@NroCuenta", acuenta.Nrocuenta);
                    command.Parameters.AddWithValue("@Estado", acuenta.Estado);
                    command.Parameters.AddWithValue("@SaldoContable", acuenta.Saldocontable);
                    command.Parameters.AddWithValue("@SaldoDisponible", acuenta.Saldodisponible);
                    command.Parameters.AddWithValue("@SobreGiro", acuenta.Sobregiro == null ? (object)DBNull.Value : acuenta.Sobregiro);
                    command.Parameters.AddWithValue("@TipoCuenta", acuenta.Tipocuenta);
                    command.Parameters.AddWithValue("@TipoMoneda", acuenta.Tipomoneda);
                    command.Parameters.AddWithValue("@Id_Tarjeta", acuenta.Id_tarjeta == null ? (object)DBNull.Value : acuenta.Id_tarjeta);
                    command.Parameters.AddWithValue("@ContChequeRebote1", acuenta.Contchequerebote1 == null ? (object)DBNull.Value : acuenta.Contchequerebote1);
                    command.Parameters.AddWithValue("@ContChequeRebote2", acuenta.Contchequerebote2 == null ? (object)DBNull.Value : acuenta.Contchequerebote2);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", acuenta.Usuario_creador);
                    command.Parameters.AddWithValue("@Cliente", acuenta.Cliente);
                    command.Parameters.AddWithValue("@FECHA_CREACION", acuenta.Fecha_creacion);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", acuenta.Fecha_modificacion == null ? (object)DBNull.Value : acuenta.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", acuenta.Usuario_modificador == null ? (object)DBNull.Value : acuenta.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "CuentasUpdate";

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
        /// Deletes record to the cuenta table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Delete(string aNroCuenta)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@NroCuenta", aNroCuenta);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "CuentasDelete";
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
        /// Selects the Single object of cuenta table.
        /// </summary>
        public CuentasModel Getcuenta(string aNroCuenta)
        {
            CuentasModel cuenta = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@NroCuenta", aNroCuenta);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "CuentasSelect";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            string NroCuenta = (string)(reader["NroCuenta"]);
                            bool Estado = (bool)(reader["Estado"]);
                            decimal SaldoContable = (decimal)(reader["SaldoContable"]);
                            decimal SaldoDisponible = (decimal)(reader["SaldoDisponible"]);
                            decimal? SobreGiro = reader["SobreGiro"] as decimal?;
                            string TipoCuenta = (string)(reader["TipoCuenta"]);
                            int TipoMoneda = (int)(reader["TipoMoneda"]);
                            int? Id_Tarjeta = reader["Id_Tarjeta"] as int?;
                            byte? ContChequeRebote1 = reader["ContChequeRebote1"] as byte?;
                            byte? ContChequeRebote2 = reader["ContChequeRebote2"] as byte?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            int Cliente = (int)(reader["Cliente"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_MODIFICADOR = reader["USUARIO_MODIFICADOR"] as string;

                            cuenta = new CuentasModel
                            {
                                Nrocuenta = NroCuenta,
                                Estado = Estado,
                                Saldocontable = SaldoContable,
                                Saldodisponible = SaldoDisponible,
                                Sobregiro = SobreGiro,
                                Tipocuenta = TipoCuenta,
                                Tipomoneda = TipoMoneda,
                                Id_tarjeta = Id_Tarjeta,
                                Contchequerebote1 = ContChequeRebote1,
                                Contchequerebote2 = ContChequeRebote2,
                                Usuario_creador = USUARIO_CREADOR,
                                Cliente = Cliente,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            };
                        }
                    }
                }

                return cuenta;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of cuenta table.
        /// </summary>
        public List<CuentasModel> cuentaSelectAll()
        {

            List<CuentasModel> cuentalist = new List<CuentasModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "CuentasSelectAll";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            string NroCuenta = (string)(reader["NroCuenta"]);
                            bool Estado = (bool)(reader["Estado"]);
                            decimal SaldoContable = (decimal)(reader["SaldoContable"]);
                            decimal SaldoDisponible = (decimal)(reader["SaldoDisponible"]);
                            decimal? SobreGiro = reader["SobreGiro"] as decimal?;
                            string TipoCuenta = (string)(reader["TipoCuenta"]);
                            short TipoMoneda = (short)(reader["TipoMoneda"]);
                            int? Id_Tarjeta = reader["Id_Tarjeta"] as int?;
                            byte? ContChequeRebote1 = reader["ContChequeRebote1"] as byte?;
                            byte? ContChequeRebote2 = reader["ContChequeRebote2"] as byte?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            int Cliente = (int)(reader["Cliente"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            cuentalist.Add(new CuentasModel
                            {
                                Nrocuenta = NroCuenta,
                                Estado = Estado,
                                Saldocontable = SaldoContable,
                                Saldodisponible = SaldoDisponible,
                                Sobregiro = SobreGiro,
                                Tipocuenta = TipoCuenta,
                                Tipomoneda = TipoMoneda,
                                Id_tarjeta = Id_Tarjeta,
                                Contchequerebote1 = ContChequeRebote1,
                                Contchequerebote2 = ContChequeRebote2,
                                Usuario_creador = USUARIO_CREADOR,
                                Cliente = Cliente,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return cuentalist;
            }
            catch (Exception)
            {
                return cuentalist;
            }
        }


        ///// <summary>
        ///// Selects the Multiple objects of cuenta table by a given criteria.
        ///// </summary>
        //public List<CuentasModel> cuentaSelectbyId_cliente(int id_cliente)
        //{

        //    List<CuentasModel> cuentalist = new List<CuentasModel>();

        //    try
        //    {
        //        using (var connection = Util.ConnectionFactory.conexion())
        //        {
        //            connection.Open();

        //            SqlCommand command = connection.CreateCommand();

        //            command.Parameters.AddWithValue("@Cliente", id_cliente);

        //            command.CommandType = CommandType.StoredProcedure;

        //            command.CommandText = "CuentasSelectAllByCliente";

        //            SqlDataReader reader = command.ExecuteReader();

        //            if (reader.HasRows)
        //            {
        //                while (reader.Read())
        //                {

        //                    string NroCuenta = (string)(reader["NroCuenta"]);
        //                    bool Estado = (bool)(reader["Estado"]);
        //                    decimal SaldoContable = (decimal)(reader["SaldoContable"]);
        //                    decimal SaldoDisponible = (decimal)(reader["SaldoDisponible"]);
        //                    decimal? SobreGiro = reader["SobreGiro"] as decimal?;
        //                    string TipoCuenta = (string)(reader["TipoCuenta"]);
        //                    int TipoMoneda = (int)(reader["TipoMoneda"]);
        //                    int? Id_Tarjeta = reader["Id_Tarjeta"] as int?;
        //                    byte? ContChequeRebote1 = reader["ContChequeRebote1"] as byte?;
        //                    byte? ContChequeRebote2 = reader["ContChequeRebote2"] as byte?;
        //                    string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
        //                    int Cliente = (int)(reader["Cliente"]);
        //                    DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
        //                    DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
        //                    string USUARIO_MODIFICADOR = reader["USUARIO_MODIFICADOR"] as string;

        //                    cuentalist.Add(new CuentasModel
        //                    {
        //                        Nrocuenta = NroCuenta,
        //                        Estado = Estado,
        //                        Saldocontable = SaldoContable,
        //                        Saldodisponible = SaldoDisponible,
        //                        Sobregiro = SobreGiro,
        //                        Tipocuenta = TipoCuenta,
        //                        Tipomoneda = TipoMoneda,
        //                        Id_tarjeta = Id_Tarjeta,
        //                        Contchequerebote1 = ContChequeRebote1,
        //                        Contchequerebote2 = ContChequeRebote2,
        //                        Usuario_creador = USUARIO_CREADOR,
        //                        Cliente = Cliente,
        //                        Fecha_creacion = FECHA_CREACION,
        //                        Fecha_modificacion = FECHA_MODIFICACION,
        //                        Usuario_modificador = USUARIO_MODIFICADOR,

        //                    });
        //                }
        //            }
        //        }

        //        return cuentalist;
        //    }
        //    catch (Exception)
        //    {
        //        return cuentalist;
        //    }
        //}

        /// <summary>
        /// Selects the Multiple objects of cuenta table by a given criteria.
        /// </summary>
        public List<CuentasModel> cuentaSelectbyNroCuenta(string numero_cuenta)
        {

            List<CuentasModel> cuentalist = new List<CuentasModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@NroCuenta", numero_cuenta);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "CuentasSelectAllByNroCuenta";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            string NroCuenta = (string)(reader["NroCuenta"]);
                            bool Estado = (bool)(reader["Estado"]);
                            decimal SaldoContable = (decimal)(reader["SaldoContable"]);
                            decimal SaldoDisponible = (decimal)(reader["SaldoDisponible"]);
                            decimal? SobreGiro = reader["SobreGiro"] as decimal?;
                            string TipoCuenta = (string)(reader["TipoCuenta"]);
                            int TipoMoneda = (int)(reader["TipoMoneda"]);
                            int? Id_Tarjeta = reader["Id_Tarjeta"] as int?;
                            byte? ContChequeRebote1 = reader["ContChequeRebote1"] as byte?;
                            byte? ContChequeRebote2 = reader["ContChequeRebote2"] as byte?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            int Cliente = (int)(reader["Cliente"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_MODIFICADOR = reader["USUARIO_MODIFICADOR"] as string;

                            cuentalist.Add(new CuentasModel
                            {
                                Nrocuenta = NroCuenta,
                                Estado = Estado,
                                Saldocontable = SaldoContable,
                                Saldodisponible = SaldoDisponible,
                                Sobregiro = SobreGiro,
                                Tipocuenta = TipoCuenta,
                                Tipomoneda = TipoMoneda,
                                Id_tarjeta = Id_Tarjeta,
                                Contchequerebote1 = ContChequeRebote1,
                                Contchequerebote2 = ContChequeRebote2,
                                Usuario_creador = USUARIO_CREADOR,
                                Cliente = Cliente,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return cuentalist;
            }
            catch (Exception)
            {
                //throw;
                return cuentalist;
            }
        }

        public List<CuentasModel> cuentaSelectbyNroCuentaPrestamo(string numero_cuenta)
        {

            List<CuentasModel> cuentalist = new List<CuentasModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@NroCuenta", numero_cuenta);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "CuentasSelectAllByNroCuentaPrestamo";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            string NroCuenta = (string)(reader["NroCuenta"]);
                            bool Estado = (bool)(reader["Estado"]);
                            decimal SaldoContable = (decimal)(reader["SaldoContable"]);
                            decimal SaldoDisponible = (decimal)(reader["SaldoDisponible"]);
                            decimal? SobreGiro = reader["SobreGiro"] as decimal?;
                            string TipoCuenta = (string)(reader["TipoCuenta"]);
                            int TipoMoneda = (int)(reader["TipoMoneda"]);
                            int? Id_Tarjeta = reader["Id_Tarjeta"] as int?;
                            byte? ContChequeRebote1 = reader["ContChequeRebote1"] as byte?;
                            byte? ContChequeRebote2 = reader["ContChequeRebote2"] as byte?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            int Cliente = (int)(reader["Cliente"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_MODIFICADOR = reader["USUARIO_MODIFICADOR"] as string;

                            cuentalist.Add(new CuentasModel
                            {
                                Nrocuenta = NroCuenta,
                                Estado = Estado,
                                Saldocontable = SaldoContable,
                                Saldodisponible = SaldoDisponible,
                                Sobregiro = SobreGiro,
                                Tipocuenta = TipoCuenta,
                                Tipomoneda = TipoMoneda,
                                Id_tarjeta = Id_Tarjeta,
                                Contchequerebote1 = ContChequeRebote1,
                                Contchequerebote2 = ContChequeRebote2,
                                Usuario_creador = USUARIO_CREADOR,
                                Cliente = Cliente,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return cuentalist;
            }
            catch (Exception)
            {
                //throw;
                return cuentalist;
            }
        }

        public CuentaPersonaMonedaModel ValidarCuenta(string aNroCuenta)
        {
            CuentaPersonaMonedaModel cuenta = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@NroCuenta", aNroCuenta);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "SelectValidarCuenta";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                          
                            cuenta = new CuentaPersonaMonedaModel
                            {
                                Cliente = (string)reader[0],
                                TipoCuenta = (string)reader[1],
                                Estado = (string)reader[2],
                                Moneda = (string)reader[3],
                                Version = (byte[])reader[4]
                            };
                        }
                    }
                }

                return cuenta;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool DepositarPrestamo(CuentasModel acuenta)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@NroCuenta", acuenta.Nrocuenta);
                    command.Parameters.AddWithValue("@SaldoContable", acuenta.Saldocontable);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", acuenta.Fecha_modificacion == null ? (object)DBNull.Value : acuenta.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", acuenta.Usuario_modificador == null ? (object)DBNull.Value : acuenta.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "CuentasDepositoCredito";

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

        public List<CuentasPersona> ListaCuentas(string DNI)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();
                    List<CuentasPersona> cuentas =new List<CuentasPersona>();
                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@DNI", DNI);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SelectCuentasbyDNI";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string NroCuenta = (string)reader[0];
                            string Estado = ((bool)reader[1]).ToString();
                            string TipoCuenta = (string)reader[2];

                            cuentas.Add(new CuentasPersona
                            {
                                NroCuenta = NroCuenta,
                                Estado = Estado,
                                TipoCuenta = TipoCuenta
                            });
                        }
                    }

                    // Commit the transaction.
                    //sqlTran.Commit();

                    connection.Close();
                    connection.Dispose();

                    return cuentas;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Selects the Multiple objects of cuenta table by a given criteria.
        /// </summary>
        public List<CuentasModel> cuentaSelectbyId_cliente(int id_cliente)
        {

            List<CuentasModel> cuentalist = new List<CuentasModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Cliente", id_cliente);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "CuentasSelectAllByCliente";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            string NroCuenta = (string)(reader["NroCuenta"]);
                            bool Estado = (bool)(reader["Estado"]);
                            decimal SaldoContable = (decimal)(reader["SaldoContable"]);
                            decimal SaldoDisponible = (decimal)(reader["SaldoDisponible"]);
                            decimal? SobreGiro = reader["SobreGiro"] as decimal?;
                            string TipoCuenta = (string)(reader["TipoCuenta"]);
                            int TipoMoneda = (int)(reader["TipoMoneda"]);
                            int? Id_Tarjeta = reader["Id_Tarjeta"] as int?;
                            byte? ContChequeRebote1 = reader["ContChequeRebote1"] as byte?;
                            byte? ContChequeRebote2 = reader["ContChequeRebote2"] as byte?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            int Cliente = (int)(reader["Cliente"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_MODIFICADOR = reader["USUARIO_MODIFICADOR"] as string;

                            cuentalist.Add(new CuentasModel
                            {
                                Nrocuenta = NroCuenta,
                                Estado = Estado,
                                Saldocontable = SaldoContable,
                                Saldodisponible = SaldoDisponible,
                                Sobregiro = SobreGiro,
                                Tipocuenta = TipoCuenta,
                                Tipomoneda = TipoMoneda,
                                Id_tarjeta = Id_Tarjeta,
                                Contchequerebote1 = ContChequeRebote1,
                                Contchequerebote2 = ContChequeRebote2,
                                Usuario_creador = USUARIO_CREADOR,
                                Cliente = Cliente,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return cuentalist;
            }
            catch (Exception)
            {
                return cuentalist;
            }
        }


        #endregion
    }
}
