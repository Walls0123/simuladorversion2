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
    public class CajaChicaManager
    {
        #region Methods
        /// <summary>
        /// Saves a record to the Caja_ChicaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public int Insert(CajaChicaModel aCaja_ChicaModel,int id_user)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 4);
                    command.Parameters.AddWithValue("@ID_user", id_user);
                    command.Parameters.AddWithValue("@ID", aCaja_ChicaModel.Id);
                    command.Parameters.AddWithValue("@Tipo_Accion", aCaja_ChicaModel.Tipo_Accion);
                    command.Parameters.AddWithValue("@Id_TurnoUsuario1", aCaja_ChicaModel.Id_TurnoUsuario1);
                    command.Parameters.AddWithValue("@Id_TurnoUsuario2", aCaja_ChicaModel.Id_TurnoUsuario2);
                    //command.Parameters.AddWithValue("@IDENTITY",SqlDbType.Int,ParameterDirection.Output);
                    SqlParameter paramId = new SqlParameter("@IDENTITY", SqlDbType.Int);
                    paramId.Direction = ParameterDirection.Output;
                    command.Parameters.Add(paramId);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tCajaChica";

                    int afectados = 0;
                    afectados= (int)command.ExecuteNonQuery();

                    //devuelve el identity creado
                    int identity = Convert.ToInt32(command.Parameters["@IDENTITY"].Value.ToString());

                    connection.Close();
                    connection.Dispose();

                    if (afectados > 0)
                        return identity;
                    else
                        return 0;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }


        /// <summary>
        /// Updates a record to the Caja_ChicaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(CajaChicaModel aCaja_ChicaModel, int id_user)
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
                    command.Parameters.AddWithValue("@ID", aCaja_ChicaModel.Id);
                    command.Parameters.AddWithValue("@Tipo_Accion", aCaja_ChicaModel.Tipo_Accion);
                    command.Parameters.AddWithValue("@Id_TurnoUsuario1", aCaja_ChicaModel.Id_TurnoUsuario1);
                    command.Parameters.AddWithValue("@Id_TurnoUsuario2", aCaja_ChicaModel.Id_TurnoUsuario2);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tCajaChica";

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
                    command.CommandText = "sp_tCajaChica";
                    int afectados = command.ExecuteNonQuery();

                    // Commit the transaction
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
        /// Deletes record to the Caja_ChicaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>

        /// <summary>
        /// Selects the Single object of Caja_ChicaModel table.
        /// </summary>

        /// <summary>
        /// Selects all the objects of Caja_ChicaModel table.
        /// </summary>
        ///
        public CajaChicaModel GetCajaChicaModel(int aID)
        {
            CajaChicaModel GetCajaChicaModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 2);
                    command.Parameters.AddWithValue("@ID", aID);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_tCajaChica";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            string Tipo_Accion = (string)(reader["Tipo_Accion"]);
                            int Id_TurnoUsuario1 = (int)(reader["Id_TurnoUsuario1"]);
                            int Id_TurnoUsuario2 = (int)(reader["Id_TurnoUsuario2"]);

                            GetCajaChicaModel = new CajaChicaModel
                            {
                                Id = ID,
                                Tipo_Accion = Tipo_Accion,
                                Id_TurnoUsuario1 = Id_TurnoUsuario1,
                                Id_TurnoUsuario2 = Id_TurnoUsuario2,

                            };
                        }
                    }
                }

                return GetCajaChicaModel;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<CajaChicaModel> Caja_ChicaModelSelectAll()
        {

            List<CajaChicaModel> Caja_ChicaModellist = new List<CajaChicaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@pMode", 1);

                    command.CommandText = "sp_tCajaChica";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            string Tipo_Accion = (string)(reader["Tipo_Accion"]);
                            int Id_TurnoUsuario1 = (int)(reader["Id_TurnoUsuario1"]);
                            int Id_TurnoUsuario2 = (int)(reader["Id_TurnoUsuario2"]);

                            Caja_ChicaModellist.Add(new CajaChicaModel
                            {
                                Id = ID,
                                Tipo_Accion = Tipo_Accion,
                                Id_TurnoUsuario1 = Id_TurnoUsuario1,
                                Id_TurnoUsuario2 = Id_TurnoUsuario2,

                            });
                        }
                    }
                }

                return Caja_ChicaModellist;
            }
            catch (Exception)
            {
                return Caja_ChicaModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of Caja_ChicaModel table by a given criteria.
        /// </summary>
        public List<CajaChicaModel> Caja_ChicaModelSelectbyUNKNOW(string aValue)
        {

            List<CajaChicaModel> Caja_ChicaModellist = new List<CajaChicaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "Caja_ChicaModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            string Tipo = (string)(reader["Tipo"]);
                            int ID_Persona = (int)(reader["ID_Persona"]);
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;

                            Caja_ChicaModellist.Add(new CajaChicaModel
                            {
                                Id = ID,
                                Tipo_Accion = Tipo,
                                Id_TurnoUsuario1 = ID_Persona,

                            });
                        }
                    }
                }

                return Caja_ChicaModellist;
            }
            catch (Exception)
            {
                return Caja_ChicaModellist;
            }
        }
        #endregion

    }
}
