using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Modelos.Modelos;

namespace CDatos.Manager
{
    public class TurnoUsuarioManager
    {
        #region Methods
        /// <summary>
        /// Saves a record to the TurnoUsuarioModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(TurnoUsuarioModel aTurnoUsuarioModel, int ID_user)
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
                    command.Parameters.AddWithValue("@ID_Usuario", aTurnoUsuarioModel.Id_usuario);
                    command.Parameters.AddWithValue("@ID_Ventanilla", aTurnoUsuarioModel.Id_ventanilla);
                    command.Parameters.AddWithValue("@ID_Turno", aTurnoUsuarioModel.Id_turno == null ? (object)DBNull.Value : aTurnoUsuarioModel.Id_turno);

                    SqlParameter paramId = new SqlParameter("@IDENTITY", SqlDbType.Int);
                    paramId.Direction = ParameterDirection.Output;
                    command.Parameters.Add(paramId);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tTurnoUsuario";

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
        /// Updates a record to the TurnoUsuarioModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(TurnoUsuarioModel aTurnoUsuarioModel, int ID_user)
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
                    command.Parameters.AddWithValue("@ID", aTurnoUsuarioModel.Id);
                    command.Parameters.AddWithValue("@ID_Usuario", aTurnoUsuarioModel.Id_usuario);
                    command.Parameters.AddWithValue("@ID_Ventanilla", aTurnoUsuarioModel.Id_ventanilla);
                    command.Parameters.AddWithValue("@ID_Turno", aTurnoUsuarioModel.Id_turno == null ? (object)DBNull.Value : aTurnoUsuarioModel.Id_turno);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tTurnoUsuario";

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
        /// Deletes record to the TurnoUsuarioModel table.
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
                    command.CommandText = "sp_tTurnoUsuario";
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
        /// Selects the Single object of TurnoUsuarioModel table.
        /// </summary>
        public TurnoUsuarioModel GetTurnoUsuarioModel(int aID)
        {
            TurnoUsuarioModel TurnoUsuarioModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 2);
                    command.Parameters.AddWithValue("@ID", aID);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_tTurnoUsuario";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            int ID_Usuario = (int)(reader["ID_Usuario"]);
                            int ID_Ventanilla = (int)(reader["ID_Ventanilla"]);
                            int? ID_Turno = reader["ID_Turno"] as int?;

                            TurnoUsuarioModel = new TurnoUsuarioModel
                            {
                                Id = ID,
                                Id_usuario = ID_Usuario,
                                Id_ventanilla = ID_Ventanilla,
                                Id_turno = ID_Turno,

                            };
                        }
                    }
                }

                return TurnoUsuarioModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of TurnoUsuarioModel table.
        /// </summary>
        public List<TurnoUsuarioModel> TurnoUsuarioModelSelectAll()
        {

            List<TurnoUsuarioModel> TurnoUsuarioModellist = new List<TurnoUsuarioModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 1);
                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_tTurnoUsuario";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            int ID_Usuario = (int)(reader["ID_Usuario"]);
                            int ID_Ventanilla = (int)(reader["ID_Ventanilla"]);
                            int? ID_Turno = reader["ID_Turno"] as int?;

                            TurnoUsuarioModellist.Add(new TurnoUsuarioModel
                            {
                                Id = ID,
                                Id_usuario = ID_Usuario,
                                Id_ventanilla = ID_Ventanilla,
                                Id_turno = ID_Turno,

                            });
                        }
                    }
                }

                return TurnoUsuarioModellist;
            }
            catch (Exception)
            {
                return TurnoUsuarioModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of TurnoUsuarioModel table by a given criteria.
        /// </summary>
        public List<TurnoUsuarioModel> TurnoUsuarioModelSelectbyUNKNOW(string aValue)
        {

            List<TurnoUsuarioModel> TurnoUsuarioModellist = new List<TurnoUsuarioModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "TurnoUsuarioModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            DateTime Fecha = (DateTime)(reader["Fecha"]);
                            TimeSpan HoraInicio = (TimeSpan)(reader["HoraInicio"]);
                            TimeSpan HoraFin = (TimeSpan)(reader["HoraFin"]);
                            int ID_Usuario = (int)(reader["ID_Usuario"]);
                            int ID_Ventanilla = (int)(reader["ID_Ventanilla"]);
                            int ID_Horarios_Atencion = (int)(reader["ID_Horarios_Atencion"]);
                            int? ID_Turnos = reader["ID_Turnos"] as int?;

                            TurnoUsuarioModellist.Add(new TurnoUsuarioModel
                            {
                                Id = ID,
                                Id_usuario = ID_Usuario,
                                Id_ventanilla = ID_Ventanilla,
                                // Id_turnos = ID_Turnos,

                            });
                        }
                    }
                }

                return TurnoUsuarioModellist;
            }
            catch (Exception)
            {
                return TurnoUsuarioModellist;
            }
        }
        #endregion

    }

}
