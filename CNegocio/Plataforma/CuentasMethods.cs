using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos.Manager;
using Modelos.Modelos;

namespace CNegocio.Plataforma
{
    public class CuentaMethods
    {
        CuentaManager cuentaManager = new CuentaManager();

        #region Methods

        public bool Ingresar(CuentaModel aCuentaModel)
        {
            return this.cuentaManager.Insert(aCuentaModel);
        }


        public bool Actualizar(CuentaModel aCuentaModel)
        {
            return this.cuentaManager.Update(aCuentaModel);
        }



        public bool Eliminar(string aNumero)
        {
            //return this.cuentaManager.Delete(aNumero);
            return false;
        }

        public bool Bloquear(CuentaModel aCuentaModel)
        {
            aCuentaModel.Estado = false;
            return this.cuentaManager.Update(aCuentaModel);
        }

        public CuentaModel obtenerCuenta(string aNumero)
        {
            return this.cuentaManager.GetCuentaModel(aNumero);
        }


        /// <summary>
        /// Selects all the objects of CuentasModel table.
        /// </summary>
        public List<CuentaModel> obtenerTodosCuentas()
        {
            return this.cuentaManager.CuentasModelSelectAll();
        }

        public List<CuentaModel> obtenerCuentasUsuario(int ID_Persona)
        {
            return this.cuentaManager.CuentasModelSelectByUser(ID_Persona);
        }

        //public List<CuentasModel> CuentasModelSelectbyUNKNOW(string aValue)
        //{

        //    List<CuentasModel> CuentasModellist = new List<CuentasModel>();

        //    try
        //    {
        //        using (var connection = Util.ConnectionFactory.conexion())
        //        {
        //            connection.Open();

        //            SqlCommand command = connection.CreateCommand();

        //            command.Parameters.AddWithValue("@UNKNOW", aValue);

        //            command.CommandType = CommandType.StoredProcedure;

        //            command.CommandText = "CuentasModelSelectbyUNKNOW";

        //            SqlDataReader reader = command.ExecuteReader();

        //            if (reader.HasRows)
        //            {
        //                while (reader.Read())
        //                {

        //                    int Numero = (int)(reader["Numero"]);
        //                    DateTime FechaEmision = (DateTime)(reader["FechaEmision"]);
        //                    DateTime? FechaCobro = reader["FechaCobro"] as DateTime?;
        //                    string Destinatario = (string)(reader["Destinatario"]);
        //                    decimal Monto = (decimal)(reader["Monto"]);
        //                    int IDCuentasModelra = (int)(reader["IDCuentasModelra"]);
        //                    string Estado = (string)(reader["Estado"]);
        //                    DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
        //                    DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
        //                    string USUARIO_CREACION = (string)(reader["USUARIO_CREACION"]);
        //                    string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

        //                    CuentasModellist.Add(new CuentasModel
        //                    {
        //                        Numero = Numero,
        //                        Fechaemision = FechaEmision,
        //                        Fechacobro = FechaCobro,
        //                        Destinatario = Destinatario,
        //                        Monto = Monto,
        //                        //IdCuentasModelra = IDCuentasModelra,
        //                        Estado = Estado,
        //                        Fecha_creacion = FECHA_CREACION,
        //                        Fecha_modificacion = FECHA_MODIFICACION,
        //                        Usuario_creacion = USUARIO_CREACION,
        //                        Usuario_modificador = USUARIO_MODIFICADOR,

        //                    });
        //                }
        //            }
        //        }

        //        return CuentasModellist;
        //    }
        //    catch (Exception)
        //    {
        //        return CuentasModellist;
        //    }
        //}
        #endregion



    }
}
