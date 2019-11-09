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
    public class TipoMonedaManager
    {
        #region Methods
        /// <summary>
        /// Saves a record to the TipoCambioModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(TipoMonedaModel aTipoMonedaModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@Nombre", aTipoMonedaModel.Nombre);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aTipoMonedaModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aTipoMonedaModel.Fecha_modificacion == null ? (object)DBNull.Value : aTipoMonedaModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aTipoMonedaModel.Usuario_creador);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aTipoMonedaModel.Usuario_modificador == null ? (object)DBNull.Value : aTipoMonedaModel.Usuario_modificador);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "TipoMonedaInsert";

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
        /// Updates a record to the TipoCambioModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(TipoMonedaModel aTipoMonedaModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@ID", aTipoMonedaModel.Id);
                    command.Parameters.AddWithValue("@Nombre", aTipoMonedaModel.Nombre);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aTipoMonedaModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aTipoMonedaModel.Fecha_modificacion == null ? (object)DBNull.Value : aTipoMonedaModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aTipoMonedaModel.Usuario_creador);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aTipoMonedaModel.Usuario_modificador == null ? (object)DBNull.Value : aTipoMonedaModel.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "TipoMonedaUpdate";

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
        /// Deletes record to the TipoCambioModel table.
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
                    command.CommandText = "TipoMonedaDelete";
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
        /// Selects the Single object of TipoCambioModel table.
        /// </summary>
        public TipoMonedaModel GetTipoMonedaModel(int aID)
        {
            TipoMonedaModel TipoMonedaModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@ID", aID);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "TipoMonedaSelect";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            string Nombre = (string)(reader["Nombre"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = (reader["FECHA_MODIFICACION"] == (object)DBNull.Value ? null : (DateTime?)(reader["FECHA_MODIFICACION"]));
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (reader["USUARIO_MODIFICADOR"]) == (object)DBNull.Value ? null : (string)(reader["USUARIO_MODIFICADOR"]);

                            TipoMonedaModel = new TipoMonedaModel
                            {
                                Id = ID,
                                Nombre = Nombre,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            };
                        }
                    }
                }

                return TipoMonedaModel;
            }
            catch (Exception)
            {
                //throw;
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of TipoCambioModel table.
        /// </summary>
        public List<TipoMonedaModel> TipoMonedaModelSelectAll()
        {

            List<TipoMonedaModel> TipoMonedaModellist = new List<TipoMonedaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "TipoMonedaSelectAll";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            string Nombre = (string)(reader["Nombre"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (reader["USUARIO_MODIFICADOR"]) == DBNull.Value ? null : (string)(reader["USUARIO_MODIFICADOR"]);

                            TipoMonedaModellist.Add(new TipoMonedaModel
                            {
                                Id = ID,
                                Nombre = Nombre,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return TipoMonedaModellist;
            }
            catch (Exception)
            {
                return TipoMonedaModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of TipoCambioModel table by a given criteria.
        /// </summary>
        public List<TipoMonedaModel> TipoMonedaModelSelectbyId(string aValue)
        {

            List<TipoMonedaModel> TipoMonedaModellist = new List<TipoMonedaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@ID", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "TipoMonedaSelectbyId";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            string Nombre = (string)(reader["Nombre"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (reader["USUARIO_MODIFICADOR"]) == DBNull.Value ? null : (string)(reader["USUARIO_MODIFICADOR"]);

                            TipoMonedaModellist.Add(new TipoMonedaModel
                            {
                                Id = ID,
                                Nombre = Nombre,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return TipoMonedaModellist;
            }
            catch (Exception)
            {
                return TipoMonedaModellist;
            }
        }

        /// <summary>
        /// Selects the Multiple objects of TipoCambioModel table by a given criteria.
        /// </summary>
        public List<TipoMonedaModel> TipoMonedaModelSelectbyDescripcion(string aValue)
        {

            List<TipoMonedaModel> TipoMonedaModellist = new List<TipoMonedaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Nombre", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "TipoMonedaSelectbyNombre";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            string Nombre = (string)(reader["Nombre"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (reader["USUARIO_MODIFICADOR"]) == DBNull.Value ? null : (string)(reader["USUARIO_MODIFICADOR"]);

                            TipoMonedaModellist.Add(new TipoMonedaModel
                            {
                                Id = ID,
                                Nombre = Nombre,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return TipoMonedaModellist;
            }
            catch (Exception)
            {
                return TipoMonedaModellist;
            }
        }
        #endregion

    }

}
