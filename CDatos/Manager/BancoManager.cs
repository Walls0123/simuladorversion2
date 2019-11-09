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
    public class BancoManager
    {
        #region Methods
        /// <summary>
        /// Saves a record to the BancoModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(BancoModel aBancoModel,int ID_user)
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
                    command.Parameters.AddWithValue("@Nombre", aBancoModel.Nombre);
                    command.Parameters.AddWithValue("@Ubicacion", aBancoModel.Ubicacion);

                    SqlParameter paramId = new SqlParameter("@IDENTITY", SqlDbType.Int);
                    paramId.Direction = ParameterDirection.Output;
                    command.Parameters.Add(paramId);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_pBanco";

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
        /// Updates a record to the BancoModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(BancoModel aBancoModel, int ID_user)
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
                    command.Parameters.AddWithValue("@ID", aBancoModel.Id);
                    command.Parameters.AddWithValue("@Nombre", aBancoModel.Nombre);
                    command.Parameters.AddWithValue("@Ubicacion", aBancoModel.Ubicacion);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_pBanco";

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
        /// Deletes record to the BancoModel table.
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

                    command.Parameters.AddWithValue("@pMode", 6);
                    command.Parameters.AddWithValue("@ID", aID);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_pBanco";
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
        /// Selects the Single object of BancoModel table.
        /// </summary>
        public BancoModel GetBancoModel(int aID)
        {
            BancoModel BancoModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 2);
                    command.Parameters.AddWithValue("@ID", aID);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_pBanco";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            string Nombre = (string)(reader["Nombre"]);
                            string Ubicacion = (string)(reader["Ubicacion"]);

                            BancoModel = new BancoModel
                            {
                                Id = ID,
                                Nombre = Nombre,
                                Ubicacion = Ubicacion,
                            };
                        }
                    }
                }

                return BancoModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of BancoModel table.
        /// </summary>
        public List<BancoModel> BancoModelSelectAll()
        {

            List<BancoModel> BancoModellist = new List<BancoModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 1);
                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_pBanco";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            string Nombre = (string)(reader["Nombre"]);
                            string Ubicacion = (string)(reader["Ubicacion"]);

                            BancoModellist.Add(new BancoModel
                            {
                                Id = ID,
                                Nombre = Nombre,
                                Ubicacion = Ubicacion,

                            });
                        }
                    }
                }

                return BancoModellist;
            }
            catch (Exception)
            {
                return BancoModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of BancoModel table by a given criteria.
        /// </summary>
        public List<BancoModel> BancoModelSelectbyUNKNOW(string aValue)
        {

            List<BancoModel> BancoModellist = new List<BancoModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "BancoModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            string Nombre = (string)(reader["Nombre"]);
                            string Ubicacion = (string)(reader["Ubicacion"]);

                            BancoModellist.Add(new BancoModel
                            {
                                Id = ID,
                                Nombre = Nombre,
                                Ubicacion = Ubicacion,

                            });
                        }
                    }
                }

                return BancoModellist;
            }
            catch (Exception)
            {
                return BancoModellist;
            }
        }
        #endregion
    }

}
