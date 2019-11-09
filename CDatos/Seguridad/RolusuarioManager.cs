using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Modelos.Modelos;

namespace CDatos.Manager
{
    public class RolUsuarioManager
    {
        #region Methods
        /// <summary>
        /// Saves a record to the RolUsuarioModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(RolUsuarioModel aRolUsuarioModel)
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
                    command.Parameters.AddWithValue("@Id_Persona", aRolUsuarioModel.Id_persona == null ? (object)DBNull.Value : aRolUsuarioModel.Id_persona);
                    command.Parameters.AddWithValue("@Id_rol", aRolUsuarioModel.Id_rol == null ? (object)DBNull.Value : aRolUsuarioModel.Id_rol);
                    command.Parameters.AddWithValue("@Activo", aRolUsuarioModel.Activo);
                    command.Parameters.AddWithValue("@Usuario_creador", aRolUsuarioModel.Usuario_creador);
                    command.Parameters.AddWithValue("@Usuario_modificador", aRolUsuarioModel.Usuario_modificador == null ? (object)DBNull.Value : aRolUsuarioModel.Usuario_modificador);

                    SqlParameter paramId = new SqlParameter("@IDENTITY", SqlDbType.Int);
                    paramId.Direction = ParameterDirection.Output;
                    command.Parameters.Add(paramId);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tRolUsuario";

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
        /// Updates a record to the RolUsuarioModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(RolUsuarioModel aRolUsuarioModel)
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
                    command.Parameters.AddWithValue("@Id", aRolUsuarioModel.Id);
                    command.Parameters.AddWithValue("@Id_Persona", aRolUsuarioModel.Id_persona == null ? (object)DBNull.Value : aRolUsuarioModel.Id_persona);
                    command.Parameters.AddWithValue("@Id_rol", aRolUsuarioModel.Id_rol == null ? (object)DBNull.Value : aRolUsuarioModel.Id_rol);
                    command.Parameters.AddWithValue("@Activo", aRolUsuarioModel.Activo);
                    command.Parameters.AddWithValue("@Usuario_creador", aRolUsuarioModel.Usuario_creador);
                    command.Parameters.AddWithValue("@Usuario_modificador", aRolUsuarioModel.Usuario_modificador == null ? (object)DBNull.Value : aRolUsuarioModel.Usuario_modificador);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tRolUsuario";

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
        /// Deletes record to the RolUsuarioModel table.
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
                    command.CommandText = "sp_tRolUsuario";
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
        /// Selects the Single object of RolUsuarioModel table.
        /// </summary>
        public RolUsuarioModel GetRolUsuarioModel(int aId)
        {
            RolUsuarioModel RolUsuarioModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 2);
                    command.Parameters.AddWithValue("@Id", aId);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_tRolUsuario";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            int? Id_Persona = reader["Id_Persona"] as int?;
                            int? Id_rol = reader["Id_rol"] as int?;
                            bool Activo = (bool)(reader["Activo"]);

                            RolUsuarioModel = new RolUsuarioModel
                            {
                                Id = Id,
                                Id_persona = Id_Persona,
                                Id_rol = Id_rol,
                                Activo = Activo,

                            };
                        }
                    }
                }

                return RolUsuarioModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of RolUsuarioModel table.
        /// </summary>
        public List<RolUsuarioModel> RolUsuarioModelSelectAll()
        {

            List<RolUsuarioModel> RolUsuarioModellist = new List<RolUsuarioModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 1);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_tRolUsuario";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            int? Id_Persona = reader["Id_Persona"] as int?;
                            int? Id_rol = reader["Id_rol"] as int?;
                            bool Activo = (bool)(reader["Activo"]);

                            RolUsuarioModellist.Add(new RolUsuarioModel
                            {
                                Id = Id,
                                Id_persona = Id_Persona,
                                Id_rol = Id_rol,
                                Activo = Activo,

                            });
                        }
                    }
                }

                return RolUsuarioModellist;
            }
            catch (Exception)
            {
                return RolUsuarioModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of RolUsuarioModel table by a given criteria.
        /// </summary>
        public List<RolUsuarioModel> RolUsuarioModelSelectbyUNKNOW(string aValue)
        {

            List<RolUsuarioModel> RolUsuarioModellist = new List<RolUsuarioModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "RolUsuarioModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //
                            // int Id = (int)(reader["Id"]);
                            // int? Id_Personas = reader["Id_Personas"] as int?;
                            // int? Id_roles = reader["Id_roles"] as int?;
                            // bool Activo = (bool)(reader["Activo"]);
                            // DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            // DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            // string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            // string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            //
                            // RolUsuarioModellist.Add(new RolUsuarioModel
                            // {
                            //     Id = Id,
                            //     Id_personas = Id_Personas,
                            //     Id_roles = Id_roles,
                            //     Activo = Activo,
                            //     Fecha_creacion = FECHA_CREACION,
                            //     Fecha_modificacion = FECHA_MODIFICACION,
                            //     Usuario_creador = USUARIO_CREADOR,
                            //     Usuario_modificador = USUARIO_MODIFICADOR,
                            //
                            // });
                        }  //
                    }
                }

                return RolUsuarioModellist;
            }
            catch (Exception)
            {
                return RolUsuarioModellist;
            }
        }
        #endregion

    }

}
