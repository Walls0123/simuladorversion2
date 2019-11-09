using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Modelos.Modelos;

namespace CDatos.Manager
{
    public class TurnosManager
    {
        #region Methods
        /// <summary>
        /// Saves a record to the TurnosModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(TurnosModel aTurnosModel, int ID_user)
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
                    command.Parameters.AddWithValue("@Descripcion", aTurnosModel.Descripcion);
                    command.Parameters.AddWithValue("@Hora_Inicio", aTurnosModel.Hora_inicio == null ? (object)DBNull.Value : aTurnosModel.Hora_inicio);
                    command.Parameters.AddWithValue("@Hora_Fin", aTurnosModel.Hora_fin == null ? (object)DBNull.Value : aTurnosModel.Hora_fin);

                    SqlParameter paramId = new SqlParameter("@IDENTITY", SqlDbType.Int);
                    paramId.Direction = ParameterDirection.Output;
                    command.Parameters.Add(paramId);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tTurnos";

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
        /// Updates a record to the TurnosModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(TurnosModel aTurnosModel, int ID_user)
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
                    command.Parameters.AddWithValue("@Id", aTurnosModel.Id);
                    command.Parameters.AddWithValue("@Descripcion", aTurnosModel.Descripcion);
                    command.Parameters.AddWithValue("@Hora_Inicio", aTurnosModel.Hora_inicio == null ? (object)DBNull.Value : aTurnosModel.Hora_inicio);
                    command.Parameters.AddWithValue("@Hora_Fin", aTurnosModel.Hora_fin == null ? (object)DBNull.Value : aTurnosModel.Hora_fin);

                    SqlParameter paramId = new SqlParameter("@IDENTITY", SqlDbType.Int);
                    paramId.Direction = ParameterDirection.Output;
                    command.Parameters.Add(paramId);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tTurnos";

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
        /// Deletes record to the TurnosModel table.
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
                    command.CommandText = "sp_tTurnos";
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
        /// Selects the Single object of TurnosModel table.
        /// </summary>
        public TurnosModel GetTurnosModel(int aId)
        {
            TurnosModel TurnosModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 2);
                    command.Parameters.AddWithValue("@Id", aId);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_tTurnos";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            TimeSpan? Hora_Inicio = reader["Hora_Inicio"] as TimeSpan?;
                            TimeSpan? Hora_Fin = reader["Hora_Fin"] as TimeSpan?;

                            TurnosModel = new TurnosModel
                            {
                                Id = Id,
                                Descripcion = Descripcion,
                                Hora_inicio = Hora_Inicio,
                                Hora_fin = Hora_Fin,

                            };
                        }
                    }
                }

                return TurnosModel;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public TurnosModel GetTurnosModelxUsuario(int Id_usuario)
        {
            TurnosModel TurnosModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@PId_Usuario", Id_usuario);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "SelectTurnoXUsuario";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int turusu = (int)(reader["TurUsu"]);
                            int turno = (int)(reader["Turno"]);
                            string Descripcion = (string)(reader["Descripcion"]);

                            TurnosModel = new TurnosModel
                            {
                                IdTurUsu=turusu,
                                Id = turno,
                                Descripcion = Descripcion,

                            };
                        }
                    }
                }

                return TurnosModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of TurnosModel table.
        /// </summary>
        public List<TurnosModel> TurnosModelSelectAll()
        {

            List<TurnosModel> TurnosModellist = new List<TurnosModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 1);
                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_tTurnos";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            TimeSpan? Hora_Inicio = reader["Hora_Inicio"] as TimeSpan?;
                            TimeSpan? Hora_Fin = reader["Hora_Fin"] as TimeSpan?;

                            TurnosModellist.Add(new TurnosModel
                            {
                                Id = Id,
                                Descripcion = Descripcion,
                                Hora_inicio = Hora_Inicio,
                                Hora_fin = Hora_Fin,

                            });
                        }
                    }
                }

                return TurnosModellist;
            }
            catch (Exception)
            {
                return TurnosModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of TurnosModel table by a given criteria.
        /// </summary>
        public List<TurnosModel> TurnosModelSelectbyUNKNOW(string aValue)
        {

            List<TurnosModel> TurnosModellist = new List<TurnosModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "TurnosModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            TimeSpan? Hora_Inicio = reader["Hora_Inicio"] as TimeSpan?;
                            TimeSpan? Hora_Fin = reader["Hora_Fin"] as TimeSpan?;

                            TurnosModellist.Add(new TurnosModel
                            {
                                Id = Id,
                                Descripcion = Descripcion,
                                Hora_inicio = Hora_Inicio,
                                Hora_fin = Hora_Fin,

                            });
                        }
                    }
                }

                return TurnosModellist;
            }
            catch (Exception)
            {
                return TurnosModellist;
            }
        }
        #endregion

    }

}
