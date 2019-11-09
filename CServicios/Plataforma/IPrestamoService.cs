using Modelos.Modelos;
using System.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Plataforma
{
    [ServiceContract]
    interface IPrestamoService
    {
        [OperationContract]
        bool Prestamo_Crear(PrestamosModel aPrestamo);

        [OperationContract]
        bool Prestamo_Editar(PrestamosModel aPrestamo);

        [OperationContract]
        bool Prestamo_Borrar(int aID_Prestamo);

        [OperationContract]
        PrestamosModel Prestamo_ObtenerUno(int aNro_Prestamo);

        [OperationContract]
        List<PrestamosModel> Prestamo_SelecionarPorCuenta(string aID_Cuenta);

        [OperationContract]
        List<PrestamosModel> Prestamo_SeleccionarPorId(string aID_Prestamo);

    }
}