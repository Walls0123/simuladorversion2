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
    public class ManagerTarjeta
    {
        #region Methods
        /// <summary>
        /// Saves a record to the tarjeta table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(TarjetaModel atarjeta)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    // command.Parameters.AddWithValue("@Numero", atarjeta.Numero);
                    command.Parameters.AddWithValue("@Password", atarjeta.Password == null ? (object)DBNull.Value : atarjeta.Password);
                    command.Parameters.AddWithValue("@CodControl", atarjeta.Codcontrol);
                    command.Parameters.AddWithValue("@FechaVencimiento", atarjeta.Fechavencimiento == null ? (object)DBNull.Value : atarjeta.Fechavencimiento);
                    command.Parameters.AddWithValue("@FechaVinculacion", atarjeta.Fechavinculacion == null ? (object)DBNull.Value : atarjeta.Fechavinculacion);
                    command.Parameters.AddWithValue("@Estado", atarjeta.Estado);
                    command.Parameters.AddWithValue("@id_cuenta", atarjeta.Id_cuenta);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", atarjeta.Fecha_modificacion == null ? (object)DBNull.Value : atarjeta.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", atarjeta.Usuario_creador);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", atarjeta.Usuario_modificador == null ? (object)DBNull.Value : atarjeta.Usuario_modificador);
                    command.Parameters.AddWithValue("@FECHA_CREACION", atarjeta.Fecha_creacion);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "tarjetasInsert";

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
        /// Updates a record to the tarjeta table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(TarjetaModel atarjeta)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@Numero", atarjeta.Numero);
                    command.Parameters.AddWithValue("@Password", atarjeta.Password == null ? (object)DBNull.Value : atarjeta.Password);
                    command.Parameters.AddWithValue("@CodControl", atarjeta.Codcontrol);
                    command.Parameters.AddWithValue("@FechaVencimiento", atarjeta.Fechavencimiento == null ? (object)DBNull.Value : atarjeta.Fechavencimiento);
                    command.Parameters.AddWithValue("@FechaVinculacion", atarjeta.Fechavinculacion == null ? (object)DBNull.Value : atarjeta.Fechavinculacion);
                    command.Parameters.AddWithValue("@Estado", atarjeta.Estado);
                    command.Parameters.AddWithValue("@id_cuenta", atarjeta.Id_cuenta);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", atarjeta.Fecha_modificacion == null ? (object)DBNull.Value : atarjeta.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", atarjeta.Usuario_creador);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", atarjeta.Usuario_modificador == null ? (object)DBNull.Value : atarjeta.Usuario_modificador);
                    command.Parameters.AddWithValue("@FECHA_CREACION", atarjeta.Fecha_creacion);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "tarjetasUpdate";

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
        /// Deletes record to the tarjeta table.
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
                    command.CommandText = "tarjetasDelete";
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
        /// Selects the Single object of tarjeta table.
        /// </summary>
        public TarjetaModel Gettarjeta(int aNumero)
        {
            TarjetaModel tarjeta = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Numero", aNumero);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "tarjetasSelect";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Numero = (int)(reader["Numero"]);
                            int? Password = reader["Password"] as int?;
                            int CodControl = (int)(reader["CodControl"]);
                            DateTime? FechaVencimiento = reader["FechaVencimiento"] as DateTime?;
                            DateTime? FechaVinculacion = reader["FechaVinculacion"] as DateTime?;
                            bool Estado = (bool)(reader["Estado"]);
                            string id_cuenta = (string)(reader["id_cuenta"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = reader["USUARIO_MODIFICADOR"] as string;
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);

                            tarjeta = new TarjetaModel
                            {
                                Numero = Numero,
                                Password = Password,
                                Codcontrol = CodControl,
                                Fechavencimiento = FechaVencimiento,
                                Fechavinculacion = FechaVinculacion,
                                Estado = Estado,
                                Id_cuenta = id_cuenta,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_creacion = FECHA_CREACION,

                            };
                        }
                    }
                }

                return tarjeta;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of tarjeta table.
        /// </summary>
        public List<TarjetaModel> tarjetaSelectAll()
        {

            List<TarjetaModel> tarjetalist = new List<TarjetaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "tarjetasSelectAll";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Numero = (int)(reader["Numero"]);
                            int? Password = reader["Password"] as int?;
                            int CodControl = (int)(reader["CodControl"]);
                            DateTime? FechaVencimiento = reader["FechaVencimiento"] as DateTime?;
                            DateTime FechaVinculacion = (DateTime)(reader["FechaVinculacion"]);
                            bool Estado = (bool)(reader["Estado"]);
                            string id_cuenta = (string)(reader["id_cuenta"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);

                            tarjetalist.Add(new TarjetaModel
                            {
                                Numero = Numero,
                                Password = Password,
                                Codcontrol = CodControl,
                                Fechavencimiento = FechaVencimiento,
                                Fechavinculacion = FechaVinculacion,
                                Estado = Estado,
                                Id_cuenta = id_cuenta,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_creacion = FECHA_CREACION,

                            });
                        }
                    }
                }

                return tarjetalist;
            }
            catch (Exception)
            {
                return tarjetalist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of tarjeta table by a given criteria.
        /// </summary>
        public List<TarjetaModel> tarjetaSelectbyId(string aValue)
        {

            List<TarjetaModel> tarjetalist = new List<TarjetaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@numero", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "TarjetasSelectbyId";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Numero = (int)(reader["Numero"]);
                            int? Password = reader["Password"] as int?;
                            int CodControl = (int)(reader["CodControl"]);
                            DateTime? FechaVencimiento = reader["FechaVencimiento"] as DateTime?;
                            DateTime? FechaVinculacion = reader["FechaVinculacion"] as DateTime?;
                            bool Estado = (bool)(reader["Estado"]);
                            string id_cuenta = (string)(reader["id_cuenta"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = reader["USUARIO_MODIFICADOR"] as string;
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);

                            tarjetalist.Add(new TarjetaModel
                            {
                                Numero = Numero,
                                Password = Password,
                                Codcontrol = CodControl,
                                Fechavencimiento = FechaVencimiento,
                                Fechavinculacion = FechaVinculacion,
                                Estado = Estado,
                                Id_cuenta = id_cuenta,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_creacion = FECHA_CREACION,

                            });
                        }
                    }
                }

                return tarjetalist;
            }
            catch (Exception)
            {
                //throw;
                return tarjetalist;
            }
        }
        #endregion

    }

}
