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
    public class ChequerasManager
    {
        #region Methods

        /// <summary>
        /// Saves a record to the chequera table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(ChequerasModel achequera)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    // command.Parameters.AddWithValue("@Numero", achequera.Numero);
                    command.Parameters.AddWithValue("@Estado", achequera.Estado);
                    command.Parameters.AddWithValue("@FechaRegistro", achequera.Fecharegistro == null ? (object)DBNull.Value : achequera.Fecharegistro);
                    command.Parameters.AddWithValue("@Cantidad_cheques", achequera.Cantidad_cheques);
                    command.Parameters.AddWithValue("@Inicio", achequera.Inicio);
                    command.Parameters.AddWithValue("@Fin", achequera.Fin);
                    command.Parameters.AddWithValue("@Id_Cuenta", achequera.Id_cuenta == null ? (object)DBNull.Value : achequera.Id_cuenta);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", achequera.Fecha_modificacion == null ? (object)DBNull.Value : achequera.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", achequera.Usuario_creador);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", achequera.Usuario_modificador == null ? (object)DBNull.Value : achequera.Usuario_modificador);
                    command.Parameters.AddWithValue("@FECHA_CREACION", achequera.Fecha_creacion);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "chequerasInsert";

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
                throw;
                return false;
            }
        }


        /// <summary>
        /// Updates a record to the chequera table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(ChequerasModel achequera)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@Numero", achequera.Numero);
                    command.Parameters.AddWithValue("@Estado", achequera.Estado);
                    command.Parameters.AddWithValue("@FechaRegistro", achequera.Fecharegistro == null ? (object)DBNull.Value : achequera.Fecharegistro);
                    command.Parameters.AddWithValue("@Cantidad_cheques", achequera.Cantidad_cheques);
                    command.Parameters.AddWithValue("@Inicio", achequera.Inicio);
                    command.Parameters.AddWithValue("@Fin", achequera.Fin);
                    command.Parameters.AddWithValue("@Id_Cuenta", achequera.Id_cuenta == null ? (object)DBNull.Value : achequera.Id_cuenta);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", achequera.Fecha_modificacion == null ? (object)DBNull.Value : achequera.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", achequera.Usuario_creador);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", achequera.Usuario_modificador == null ? (object)DBNull.Value : achequera.Usuario_modificador);
                    command.Parameters.AddWithValue("@FECHA_CREACION", achequera.Fecha_creacion);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "chequeraUpdate";

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
        /// Deletes record to the chequera table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Delete(int aNumero)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@Numero", aNumero);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "chequerasDelete";
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
        /// Selects the Single object of chequera table.
        /// </summary>
        public ChequerasModel Getchequera(int aNumero)
        {
            ChequerasModel chequera = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Numero", aNumero);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "chequerasSelect";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Numero = (int)(reader["Numero"]);
                            string Estado = (string)(reader["Estado"]);
                            DateTime? FechaRegistro = reader["FechaRegistro"] as DateTime?;
                            int Cantidad_cheques = (int)(reader["Cantidad_cheques"]);
                            int Inicio = (int)(reader["Inicio"]);
                            int Fin = (int)(reader["Fin"]);
                            string Id_Cuenta = (string)(reader["Id_Cuenta"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = reader["USUARIO_MODIFICADOR"] as string;
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);

                            chequera = new ChequerasModel
                            {
                                Numero = Numero,
                                Estado = Estado,
                                Fecharegistro = FechaRegistro,
                                Cantidad_cheques = Cantidad_cheques,
                                Inicio = Inicio,
                                Fin = Fin,
                                Id_cuenta = Id_Cuenta,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_creacion = FECHA_CREACION,

                            };
                        }
                    }
                }

                return chequera;
            }
            catch (Exception)
            {
                return null;
            }
        }



        /// <summary>
        /// Selects all the objects of chequera table.
        /// </summary>
        public List<ChequerasModel> chequeraSelectAll()
        {

            List<ChequerasModel> chequeralist = new List<ChequerasModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "chequeraSelectAll";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Numero = (int)(reader["Numero"]);
                            string Estado = (string)(reader["Estado"]);
                            DateTime? FechaRegistro = reader["FechaRegistro"] as DateTime?;
                            int Cantidad_cheques = (int)(reader["Cantidad_cheques"]);
                            int Inicio = (int)(reader["Inicio"]);
                            int Fin = (int)(reader["Fin"]);
                            string Id_Cuenta = (string)(reader["Id_Cuenta"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);

                            chequeralist.Add(new ChequerasModel
                            {
                                Numero = Numero,
                                Estado = Estado,
                                Fecharegistro = FechaRegistro,
                                Cantidad_cheques = Cantidad_cheques,
                                Inicio = Inicio,
                                Fin = Fin,
                                Id_cuenta = Id_Cuenta,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_creacion = FECHA_CREACION,

                            });
                        }
                    }
                }

                return chequeralist;
            }
            catch (Exception)
            {
                return chequeralist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of chequera table by a given criteria.
        /// </summary>
        public List<ChequerasModel> chequeraSelectbyCuenta(string aCuenta)
        {

            List<ChequerasModel> chequeralist = new List<ChequerasModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Id_Cuenta", aCuenta);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "ChequerasSelectAllById_Cuenta";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Numero = (int)(reader["Numero"]);
                            string Estado = (string)(reader["Estado"]);
                            DateTime? FechaRegistro = reader["FechaRegistro"] as DateTime?;
                            int Cantidad_cheques = (int)(reader["Cantidad_cheques"]);
                            int Inicio = (int)(reader["Inicio"]);
                            int Fin = (int)(reader["Fin"]);
                            string Id_Cuenta = (string)(reader["Id_Cuenta"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);

                            chequeralist.Add(new ChequerasModel
                            {
                                Numero = Numero,
                                Estado = Estado,
                                Fecharegistro = FechaRegistro,
                                Cantidad_cheques = Cantidad_cheques,
                                Inicio = Inicio,
                                Fin = Fin,
                                Id_cuenta = Id_Cuenta,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_creacion = FECHA_CREACION,

                            });
                        }
                    }
                }

                return chequeralist;
            }
            catch (Exception)
            {
                return chequeralist;
            }
        }



        /// <summary>
        /// Selects the Multiple objects of chequera table by a given criteria.
        /// </summary>
        public List<ChequerasModel> ChequerasSelectbyId(string aNumero)
        {

            List<ChequerasModel> chequeralist = new List<ChequerasModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Numero", aNumero);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "ChequerasSelectbyId";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Numero = (int)(reader["Numero"]);
                            string Estado = (string)(reader["Estado"]);
                            DateTime? FechaRegistro = reader["FechaRegistro"] as DateTime?;
                            int Cantidad_cheques = (int)(reader["Cantidad_cheques"]);
                            int Inicio = (int)(reader["Inicio"]);
                            int Fin = (int)(reader["Fin"]);
                            string Id_Cuenta = (string)(reader["Id_Cuenta"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = reader["USUARIO_MODIFICADOR"] as string;
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);

                            chequeralist.Add(new ChequerasModel
                            {
                                Numero = Numero,
                                Estado = Estado,
                                Fecharegistro = FechaRegistro,
                                Cantidad_cheques = Cantidad_cheques,
                                Inicio = Inicio,
                                Fin = Fin,
                                Id_cuenta = Id_Cuenta,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_creacion = FECHA_CREACION,

                            });
                        }
                    }
                }

                return chequeralist;
            }
            catch (Exception)
            {
                return chequeralist;
            }
        }

        public VersionesModel Versionchequera(int numero)
        {

            VersionesModel versiones = new VersionesModel();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Numero", numero);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "ChequesVersion";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            versiones.Version1 = (byte[])(reader["ChequeVersion"]);
                            versiones.Version2 = (byte[])(reader["ChequeraVersion"]);
                            versiones.Version3 = (byte[])(reader["CuentaVersion"]);
                        }
                    }
                }
                return versiones;
            }
            catch (Exception)
            {
                return versiones;
            }
        }

        #endregion

    }

}
