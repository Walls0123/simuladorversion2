using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Modelos.Modelos;

namespace CDatos.Manager
{
    public class RolesManager
    {
        #region Methods
        /// <summary>
        /// Saves a record to the RolesModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(RolesModel aRolesModel)
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
                    //command.Parameters.AddWithValue("@ID_user", ID_user);
                    command.Parameters.AddWithValue("@Usuario_creador", aRolesModel.Usuario_creador);
                    command.Parameters.AddWithValue("@Usuario_modificador", aRolesModel.Usuario_modificador == null ? (object)DBNull.Value : aRolesModel.Usuario_modificador);

                    command.Parameters.AddWithValue("@Descripcion", aRolesModel.Descripcion);

                    SqlParameter paramId = new SqlParameter("@IDENTITY", SqlDbType.Int);
                    paramId.Direction = ParameterDirection.Output;
                    command.Parameters.Add(paramId);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tRoles";

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
        /// Updates a record to the RolesModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(RolesModel aRolesModel)
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
                    //command.Parameters.AddWithValue("@ID_user", ID_user);
                    command.Parameters.AddWithValue("@Usuario_creador", aRolesModel.Usuario_creador);
                    command.Parameters.AddWithValue("@Usuario_modificador", aRolesModel.Usuario_modificador == null ? (object)DBNull.Value : aRolesModel.Usuario_modificador);

                    command.Parameters.AddWithValue("@Id", aRolesModel.Id);
                    command.Parameters.AddWithValue("@Descripcion", aRolesModel.Descripcion);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tRoles";

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
        /// Deletes record to the RolesModel table.
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
                    command.CommandText = "sp_tRoles";
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
        /// Selects the Single object of RolesModel table.
        /// </summary>
        public RolesModel GetRolesModel(int aId)
        {
            RolesModel RolesModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();
                    command.Parameters.AddWithValue("@pMode", 2);
                    command.Parameters.AddWithValue("@Id", aId);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_tRoles";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                           
                            RolesModel = new RolesModel
                            {
                                Id = Id,
                                Descripcion = Descripcion,
                                
                            };
                        }
                    }
                }

                return RolesModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of RolesModel table.
        /// </summary>
        public List<RolesModel> RolesModelSelectAll()
        {

            List<RolesModel> RolesModellist = new List<RolesModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 1);
                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_tRoles";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Descripcion = (string)(reader["Descripcion"]);

                            RolesModellist.Add(new RolesModel
                            {
                                Id = Id,
                                Descripcion = Descripcion,
                                Fecha_creacion = DateTime.Now,
                                Fecha_modificacion = DateTime.Now,
                                Usuario_creador = "",
                                Usuario_modificador = "",
                            });
                        }
                    }
                }

                return RolesModellist;
            }
            catch (Exception)
            {
                return RolesModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of RolesModel table by a given criteria.
        /// </summary>
        public List<RolesModel> RolesModelSelectbyUNKNOW(string aValue)
        {

            List<RolesModel> RolesModellist = new List<RolesModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "RolesModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            
                            RolesModellist.Add(new RolesModel
                            {
                                Id = Id,
                                Descripcion = Descripcion,
                            });
                        }
                    }
                }

                return RolesModellist;
            }
            catch (Exception)
            {
                return RolesModellist;
            }
        }

        public List<RolUsuarioModel> RolesPorPersona(int aID_Usuario)
        {

            List<RolUsuarioModel> RolesModellist = new List<RolUsuarioModel>();


            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@idusuario", aID_Usuario);
                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_ObtenerRolesPorPersona";


                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            bool estado= (bool)(reader["Activo"]);

                            RolesModellist.Add(new RolUsuarioModel
                            {
                                Id = Id,
                                Descripcion = Descripcion,
                                Activo = estado
                            });
                        }
                    }


                }
                

                return RolesModellist;
            }
            catch (Exception)
            {
                return null;
            }
        }








        #endregion

    }

}
