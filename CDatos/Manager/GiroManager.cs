using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Manager
{
   public class GiroManager
    {
        #region Methods
        /// <summary>
        /// Saves a record to the GiroModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(GiroModel aGiroModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("Id", aGiroModel.Id);
                   command.Parameters.AddWithValue("Id_PersonaOrigen", aGiroModel.Id_PersonaOrigen);
                   command.Parameters.AddWithValue("Id_PersonaDestino", aGiroModel.Id_PersonaDestino);
                   command.Parameters.AddWithValue("Monto", aGiroModel.Monto);
                   command.Parameters.AddWithValue("Estado", aGiroModel.Estado);
                   command.Parameters.AddWithValue("Id_Movimiento", aGiroModel.Id_Movimiento);
                   command.Parameters.AddWithValue("FechaGiro", aGiroModel.FechaGiro);
                   command.Parameters.AddWithValue("FechaRetiro", aGiroModel.FechaRetiro);
                   command.Parameters.AddWithValue("USUARIO_CREADOR", aGiroModel.FECHA_CREACION);
                   command.Parameters.AddWithValue("FECHA_CREACION", aGiroModel.FECHA_CREACION);
                   command.Parameters.AddWithValue("Clave", aGiroModel.Clave);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "GiroModelInsert";

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
        /// Updates a record to the GiroModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(GiroModel aGiroModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("Id", aGiroModel.Id);
                    command.Parameters.AddWithValue("Id_PersonaOrigen", aGiroModel.Id_PersonaOrigen);
                    command.Parameters.AddWithValue("Id_PersonaDestino", aGiroModel.Id_PersonaDestino);
                    command.Parameters.AddWithValue("Monto", aGiroModel.Monto);
                    command.Parameters.AddWithValue("Estado", aGiroModel.Estado);
                    command.Parameters.AddWithValue("Id_Movimiento", aGiroModel.Id_Movimiento);
                    command.Parameters.AddWithValue("FechaGiro", aGiroModel.FechaGiro);
                    command.Parameters.AddWithValue("FechaRetiro", aGiroModel.FechaRetiro);
                    command.Parameters.AddWithValue("FECHA_MODIFICACION", aGiroModel.FECHA_MODIFICACION);
                    command.Parameters.AddWithValue("USUARIO_MODIFICADOR", aGiroModel.USUARIO_MODIFICADOR);
                    command.Parameters.AddWithValue("Clave", aGiroModel.Clave);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "GiroModelUpdate";

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
        /// Deletes record to the GiroModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Delete(int aID_GiroModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("Id", aID_GiroModel);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "GiroModelDelete";
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
        /// Selects the Single object of GiroModel table.
        /// </summary>
        public GiroModel GetGiroModel(int aID_GiroModel)
        {
            GiroModel GiroModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@ID_GiroModel", aID_GiroModel);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "GiroModelSelect";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID_GiroModel = (int)(reader["ID_GiroModel"]);
                            string Nombre_GiroModel = (string)(reader["Nombre_GiroModel"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            string Nro_Cuenta = (string)(reader["Nro_Cuenta"]);
                            decimal Comisiones = (decimal)(reader["Comisiones"]);
                            bool GiroModel_Asume_Comision = (bool)(reader["GiroModel_Asume_Comision"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            GiroModel = new GiroModel
                            {
                                Id = ID_GiroModel,
                                //Nombre_empresa = Nombre_GiroModel,
                                //Descripcion = Descripcion,
                                //Nro_cuenta = Nro_Cuenta,
                                //Comisiones = Comisiones,
                                //Empresa_asume_comision = GiroModel_Asume_Comision,
                                FECHA_CREACION = FECHA_CREACION,
                                FECHA_MODIFICACION = FECHA_MODIFICACION,
                                USUARIO_CREADOR = USUARIO_CREADOR,
                                USUARIO_MODIFICADOR = USUARIO_MODIFICADOR,

                            };
                        }
                    }
                }

                return GiroModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of GiroModel table.
        /// </summary>
        public List<GiroModel> GiroModelSelectAll()
        {

            List<GiroModel> GiroModellist = new List<GiroModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "GiroModelSelectAll";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID_GiroModel = (int)(reader["ID_GiroModel"]);
                            string Nombre_GiroModel = (string)(reader["Nombre_GiroModel"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            string Nro_Cuenta = (string)(reader["Nro_Cuenta"]);
                            decimal Comisiones = (decimal)(reader["Comisiones"]);
                            bool GiroModel_Asume_Comision = (bool)(reader["GiroModel_Asume_Comision"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            GiroModellist.Add(new GiroModel
                            {
                                Id = ID_GiroModel,
                                //Nombre_empresa = Nombre_GiroModel,
                                //Descripcion = Descripcion,
                                //Nro_cuenta = Nro_Cuenta,
                                //Comisiones = Comisiones,
                                //Empresa_asume_comision = GiroModel_Asume_Comision,
                                FECHA_CREACION = FECHA_CREACION,
                                FECHA_MODIFICACION = FECHA_MODIFICACION,
                                USUARIO_CREADOR = USUARIO_CREADOR,
                                USUARIO_MODIFICADOR = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return GiroModellist;
            }
            catch (Exception)
            {
                return GiroModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of GiroModel table by a given criteria.
        /// </summary>
        public List<GiroModel> GiroModelSelectbyUNKNOW(string aValue)
        {

            List<GiroModel> GiroModellist = new List<GiroModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "GiroModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID_GiroModel = (int)(reader["ID_GiroModel"]);
                            string Nombre_GiroModel = (string)(reader["Nombre_GiroModel"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            string Nro_Cuenta = (string)(reader["Nro_Cuenta"]);
                            decimal Comisiones = (decimal)(reader["Comisiones"]);
                            bool GiroModel_Asume_Comision = (bool)(reader["GiroModel_Asume_Comision"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            GiroModellist.Add(new GiroModel
                            {
                                Id = ID_GiroModel,
                                //Nombre_empresa = Nombre_GiroModel,
                                //Descripcion = Descripcion,
                                //Nro_cuenta = Nro_Cuenta,
                                //Comisiones = Comisiones,
                                //Empresa_asume_comision = GiroModel_Asume_Comision,
                                FECHA_CREACION = FECHA_CREACION,
                                FECHA_MODIFICACION = FECHA_MODIFICACION,
                                USUARIO_CREADOR = USUARIO_CREADOR,
                                USUARIO_MODIFICADOR = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return GiroModellist;
            }
            catch (Exception)
            {
                return GiroModellist;
            }
        }
        public List<object> SelectGirosbyDocClave(string aValue, Int16 clave)
        {

            List<object> Giros = new List<object>();

            using (var connection = Util.ConnectionFactory.conexion())
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();

                command.Parameters.AddWithValue("@NroDocumento", aValue);
                command.Parameters.AddWithValue("@Clave", clave);

                command.CommandType = CommandType.StoredProcedure;

                command.CommandText = "GiroPerosonaSelectByDocClave";

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Giros.Add(new
                        {
                            Codigo = reader[0],
                            Origen = reader[1],
                            Destino = reader[2],
                            Monto = reader[3],
                            FechaGiro = reader[4],
                            FechaRetiro = reader[5],
                            Estado = reader[6],
                            RowVer = reader[7]
                        });
                    }
                }
            }
            return Giros;
        }

        public bool EnviarGiro(GiroModel giro)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;
        
                    command.Parameters.AddWithValue("@monto", giro.Monto);              
                    command.Parameters.AddWithValue("@clave", giro.Clave);
                    command.Parameters.AddWithValue("@NroDocOrigen", giro.Id_PersonaOrigen);
                    command.Parameters.AddWithValue("@NroDocDestino", giro.Id_PersonaDestino);
                    command.Parameters.AddWithValue("@Usuario", giro.USUARIO_CREADOR);
                    command.Parameters.AddWithValue("@Moneda", giro.Moneda);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "GiroInsert";
                    
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
            catch (Exception e)
            {
               string qa=  e.Message.ToString();
                return false;
            }
        }
        //GiroUpdateById
        public int CobrarGiro(GiroModel giro)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@Codigo", giro.Id);
                    command.Parameters.AddWithValue("@Usuario", giro.USUARIO_CREADOR);
                    command.Parameters.AddWithValue("@doi", giro.Id_PersonaOrigen);
                    command.Parameters.AddWithValue("@RowVersion", giro.RowVer);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "GiroUpdateById";

                    int result = command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();
                    connection.Dispose();
                    return result;
                   
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }
        #endregion
    }
}
