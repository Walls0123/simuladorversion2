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
    public class ComponenteManager
    {
        #region Methods
        /// <summary>
        /// Saves a record to the ComponenteModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(ComponenteModel aComponenteModel, int id_user)
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
                    command.Parameters.AddWithValue("@ID_user", id_user);
                    command.Parameters.AddWithValue("@Nombre", aComponenteModel.Nombre);
                    command.Parameters.AddWithValue("@Descripcion", aComponenteModel.Descripcion);
                    command.Parameters.AddWithValue("@Id_aplicacion", aComponenteModel.Id_aplicacion == null ? (object)DBNull.Value : aComponenteModel.Id_aplicacion);
                    command.Parameters.AddWithValue("@Estado", aComponenteModel.Estado);
                    command.Parameters.AddWithValue("@Codigo", aComponenteModel.Codigo);
                    command.Parameters.AddWithValue("@IdPadre", aComponenteModel.IdPadre == null ? (object)DBNull.Value : aComponenteModel.IdPadre);

                    SqlParameter paramId = new SqlParameter("@IDENTITY", SqlDbType.Int);
                    paramId.Direction = ParameterDirection.Output;
                    command.Parameters.Add(paramId);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tComponente";

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
        /// Updates a record to the ComponenteModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(ComponenteModel aComponenteModel, int id_user)
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
                    command.Parameters.AddWithValue("@ID_user", id_user);
                    command.Parameters.AddWithValue("@Id", aComponenteModel.Id);
                    command.Parameters.AddWithValue("@Nombre", aComponenteModel.Nombre);
                    command.Parameters.AddWithValue("@Descripcion", aComponenteModel.Descripcion);
                    command.Parameters.AddWithValue("@Id_aplicacion", aComponenteModel.Id_aplicacion == null ? (object)DBNull.Value : aComponenteModel.Id_aplicacion);
                    command.Parameters.AddWithValue("@Estado", aComponenteModel.Estado);
                    command.Parameters.AddWithValue("@Codigo", aComponenteModel.Codigo);
                    command.Parameters.AddWithValue("@IdPadre", aComponenteModel.IdPadre == null ? (object)DBNull.Value : aComponenteModel.IdPadre);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tComponente";

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
        /// Deletes record to the ComponenteModel table.
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
                    command.CommandText = "sp_tComponente";
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
        /// Selects the Single object of ComponenteModel table.
        /// </summary>
        public ComponenteModel GetComponenteModel(int aId)
        {
            ComponenteModel ComponenteModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 2);
                    command.Parameters.AddWithValue("@Id", aId);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_tComponente";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Nombre = (string)(reader["Nombre"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            int? Id_aplicacion = reader["Id_aplicacion"] as int?;
                            bool Estado = (bool)(reader["Estado"]);
                            string Codigo = (string)(reader["Codigo"]);
                            int? IdPadre = reader["IdPadre"] as int?;

                            ComponenteModel = new ComponenteModel
                            {
                                Id = Id,
                                Nombre = Nombre,
                                Descripcion = Descripcion,
                                Id_aplicacion = Id_aplicacion,
                                Estado = Estado,
                                Codigo = Codigo,
                                IdPadre = IdPadre,

                            };
                        }
                    }
                }

                return ComponenteModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of ComponenteModel table.
        /// </summary>
        public List<ComponenteModel> ComponenteModelSelectAll()
        {

            List<ComponenteModel> ComponenteModellist = new List<ComponenteModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 1);
                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_tComponente";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Nombre = (string)(reader["Nombre"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            int? Id_aplicacion = reader["Id_aplicacion"] as int?;
                            bool Estado = (bool)(reader["Estado"]);
                            string Codigo = (string)(reader["Codigo"]);
                            int? IdPadre = reader["IdPadre"] as int?;

                            ComponenteModellist.Add(new ComponenteModel
                            {
                                Id = Id,
                                Nombre = Nombre,
                                Descripcion = Descripcion,
                                Id_aplicacion = Id_aplicacion,
                                Estado = Estado,
                                Codigo = Codigo,
                                IdPadre = IdPadre,

                            });
                        }
                    }
                }

                return ComponenteModellist;
            }
            catch (Exception)
            {
                return ComponenteModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of ComponenteModel table by a given criteria.
        /// </summary>
        public List<ComponenteModel> ComponenteModelSelectbyUNKNOW(string aValue)
        {

            List<ComponenteModel> ComponenteModellist = new List<ComponenteModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "ComponenteModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Nombre = (string)(reader["Nombre"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            int? Id_aplicacion = reader["Id_aplicacion"] as int?;
                            bool Estado = (bool)(reader["Estado"]);
                            string Codigo = (string)(reader["Codigo"]);
                            int? IdPadre = reader["IdPadre"] as int?;

                            ComponenteModellist.Add(new ComponenteModel
                            {
                                Id = Id,
                                Nombre = Nombre,
                                Descripcion = Descripcion,
                                Id_aplicacion = Id_aplicacion,
                                Estado = Estado,
                                Codigo = Codigo,
                                IdPadre = IdPadre,

                            });
                        }
                    }
                }

                return ComponenteModellist;
            }
            catch (Exception)
            {
                return ComponenteModellist;
            }
        }


        ///////////////////////




        public List<ComponenteModel> GetComponentesRol(int aRol)
        {

            List<ComponenteModel> ComponenteModellist = new List<ComponenteModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@rol", aRol);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_ObtenerPermisosRol";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int Id = (int)(reader["Id"]);
                            string Nombre = (string)(reader["Nombre"]);
                            bool Estado = (bool)(reader["Estado"]);


                            ComponenteModellist.Add(new ComponenteModel
                            {
                                Id = Id,
                                Nombre = Nombre,
                                Estado = Estado,

                            });
                        }
                    }
                }

                return ComponenteModellist;
            }
            catch (Exception)
            {
                return null;
            }
        }






        public List<ComponenteModel> ObtenerTodosComponentes()
        {

            List<ComponenteModel> ComponenteModellist = new List<ComponenteModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_ObtenerTodosComponentes";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Nombre = (string)(reader["Nombre"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            bool Estado = (bool)(reader["Estado"]);
                            string Codigo = (string)(reader["Codigo"]);


                            ComponenteModellist.Add(new ComponenteModel
                            {
                                Id = Id,
                                Nombre = Nombre,
                                Descripcion = Descripcion,

                                Estado = Estado,
                                Codigo = Codigo,

                            });
                        }
                    }
                }

                return ComponenteModellist;
            }
            catch (Exception)
            {
                return ComponenteModellist;
            }
        }



        #endregion

    }

}
