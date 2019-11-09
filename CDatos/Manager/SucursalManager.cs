using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Modelos.Modelos;

namespace CDatos.Manager
{
    public class SucursalManager
    {
        #region Methods
        /// <summary>
        /// Saves a record to the SucursalModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(SucursalModel aSucursalModel, int ID_user)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@pMode", 4);
                    command.Parameters.AddWithValue("@ID_user", ID_user);
                    command.Parameters.AddWithValue("@Nombre", aSucursalModel.Nombre);
                    command.Parameters.AddWithValue("@Ubicacion", aSucursalModel.Ubicacion);
                    command.Parameters.AddWithValue("@IdBanco", aSucursalModel.Idbanco);

                    SqlParameter paramId = new SqlParameter("@IDENTITY", SqlDbType.Int);
                    paramId.Direction = ParameterDirection.Output;
                    command.Parameters.Add(paramId);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tSucursal";

                    int afectados = command.ExecuteNonQuery();
                    int identity = Convert.ToInt32(command.Parameters["@IDENTITY"].Value.ToString());

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
        /// Updates a record to the SucursalModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(SucursalModel aSucursalModel, int ID_user)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@pMode", 5);
                    command.Parameters.AddWithValue("@ID_user", ID_user);
                    command.Parameters.AddWithValue("@Id", aSucursalModel.Id);
                    command.Parameters.AddWithValue("@Nombre", aSucursalModel.Nombre);
                    command.Parameters.AddWithValue("@Ubicacion", aSucursalModel.Ubicacion);
                    command.Parameters.AddWithValue("@IdBanco", aSucursalModel.Idbanco);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tSucursal";

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
        /// Deletes record to the SucursalModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Delete(int aId)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@pMode", 6);
                    command.Parameters.AddWithValue("@Id", aId);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tSucursal";
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
        /// Selects the Single object of SucursalModel table.
        /// </summary>
        public SucursalModel GetSucursalModel(int aId)
        {
            SucursalModel SucursalModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 2);
                    command.Parameters.AddWithValue("@Id", aId);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_tSucursal";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Nombre = (string)(reader["Nombre"]);
                            string Ubicacion = (string)(reader["Ubicacion"]);
                            int IdBanco = (int)(reader["IdBanco"]);

                            SucursalModel = new SucursalModel
                            {
                                Id = Id,
                                Nombre = Nombre,
                                Ubicacion = Ubicacion,
                                Idbanco = IdBanco,

                            };
                        }
                    }
                }

                return SucursalModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of SucursalModel table.
        /// </summary>
        public List<SucursalModel> SucursalModelSelectAll()
        {

            List<SucursalModel> SucursalModellist = new List<SucursalModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 1);
                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_tSucursal";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Nombre = (string)(reader["Nombre"]);
                            string Ubicacion = (string)(reader["Ubicacion"]);
                            int IdBanco = (int)(reader["IdBanco"]);

                            SucursalModellist.Add(new SucursalModel
                            {
                                Id = Id,
                                Nombre = Nombre,
                                Ubicacion = Ubicacion,
                                Idbanco = IdBanco,

                            });
                        }
                    }
                }

                return SucursalModellist;
            }
            catch (Exception)
            {
                return SucursalModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of SucursalModel table by a given criteria.
        /// </summary>
        public List<SucursalModel> SucursalModelSelectbyUNKNOW(string aValue)
        {

            List<SucursalModel> SucursalModellist = new List<SucursalModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "SucursalModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Nombre = (string)(reader["Nombre"]);
                            string Ubicacion = (string)(reader["Ubicacion"]);
                            int IdBanco = (int)(reader["IdBanco"]);

                            SucursalModellist.Add(new SucursalModel
                            {
                                Id = Id,
                                Nombre = Nombre,
                                Ubicacion = Ubicacion,
                                Idbanco = IdBanco,

                            });
                        }
                    }
                }

                return SucursalModellist;
            }
            catch (Exception)
            {
                return SucursalModellist;
            }
        }
        #endregion

    }

}
