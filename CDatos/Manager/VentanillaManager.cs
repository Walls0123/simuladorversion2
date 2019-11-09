using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Modelos.Modelos;

namespace CDatos.Manager
{
    public class VentanillaManager
    {
        #region Methods
        /// <summary>
        /// Saves a record to the VentanillaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(VentanillaModel aVentanillaModel, int ID_user)
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
                    command.Parameters.AddWithValue("@Descripcion", aVentanillaModel.Descripcion);
                    command.Parameters.AddWithValue("@IdSucursal", aVentanillaModel.Idsucursal);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tVentanilla";

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
        /// Updates a record to the VentanillaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(VentanillaModel aVentanillaModel, int ID_user)
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
                    command.Parameters.AddWithValue("@ID_Ventanilla", aVentanillaModel.Id_ventanilla);
                    command.Parameters.AddWithValue("@Descripcion", aVentanillaModel.Descripcion);
                    command.Parameters.AddWithValue("@IdSucursal", aVentanillaModel.Idsucursal);

                    SqlParameter paramId = new SqlParameter("@IDENTITY", SqlDbType.Int);
                    paramId.Direction = ParameterDirection.Output;
                    command.Parameters.Add(paramId);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tVentanilla";

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
        /// Deletes record to the VentanillaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Delete(int aID_VentanillaModel)
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
                    command.Parameters.AddWithValue("@ID_Ventanilla", aID_VentanillaModel);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tVentanilla";
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
        /// Selects the Single object of VentanillaModel table.
        /// </summary>
        public VentanillaModel GetVentanillaModel(int aID_VentanillaModel)
        {
            VentanillaModel VentanillaModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 2);
                    command.Parameters.AddWithValue("@ID_Ventanilla", aID_VentanillaModel);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_tVentanilla";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID_VentanillaModel = (int)(reader["ID_Ventanilla"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            int IdSucursal = (int)(reader["IdSucursal"]);

                            VentanillaModel = new VentanillaModel
                            {
                                Id_ventanilla = ID_VentanillaModel,
                                Descripcion = Descripcion,
                                Idsucursal = IdSucursal,

                            };
                        }
                    }
                }

                return VentanillaModel;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public VentanillaModel GetVentanillaModelxUsuario(int ID_Usuario)
        {
            VentanillaModel VentanillaModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();
                    command.Parameters.AddWithValue("@PId_Usuario", ID_Usuario);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "SelectVentanillaXUsuario";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID_VentanillaModel = (int)(reader["ID_Ventanilla"]);
                            string Descripcion = (string)(reader["Descripcion"]);

                            VentanillaModel = new VentanillaModel
                            {
                                Id_ventanilla = ID_VentanillaModel,
                                Descripcion = Descripcion

                            };
                        }
                    }
                }

                return VentanillaModel;
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// Selects all the objects of VentanillaModel table.
        /// </summary>
        public List<VentanillaModel> VentanillaModelSelectAll()
        {

            List<VentanillaModel> VentanillaModellist = new List<VentanillaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 1);
                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_tVentanilla";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID_VentanillaModel = (int)(reader["ID_Ventanilla"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            int IdSucursal = (int)(reader["IdSucursal"]);

                            VentanillaModellist.Add(new VentanillaModel
                            {
                                Id_ventanilla = ID_VentanillaModel,
                                Descripcion = Descripcion,
                                Idsucursal = IdSucursal,

                            });
                        }
                    }
                }

                return VentanillaModellist;
            }
            catch (Exception)
            {
                return VentanillaModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of VentanillaModel table by a given criteria.
        /// </summary>
        public List<VentanillaModel> VentanillaModelSelectbyUNKNOW(string aValue)
        {

            List<VentanillaModel> VentanillaModellist = new List<VentanillaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "VentanillaModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID_VentanillaModel = (int)(reader["ID_VentanillaModel"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            int IdSucursal = (int)(reader["IdSucursal"]);

                            VentanillaModellist.Add(new VentanillaModel
                            {
                                Id_ventanilla = ID_VentanillaModel,
                                Descripcion = Descripcion,
                                Idsucursal = IdSucursal,

                            });
                        }
                    }
                }

                return VentanillaModellist;
            }
            catch (Exception)
            {
                return VentanillaModellist;
            }
        }
        public List<VentanillaModel> GetVentanillasXSucursal(int sucursal,int turno)
        {
            List<VentanillaModel> VentanillaModellist = new List<VentanillaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@sucursal", sucursal);
                    command.Parameters.AddWithValue("@turno", turno);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "SelectVentanillasXSucursal";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID_VentanillaModel = (int)(reader["ID"]);
                            string Descripcion = (string)(reader["Descripcion"]);

                            VentanillaModellist.Add(new VentanillaModel
                            {
                                Id_ventanilla = ID_VentanillaModel,
                                Descripcion = Descripcion

                            });
                        }
                    }
                }

                return VentanillaModellist;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

    }

}
