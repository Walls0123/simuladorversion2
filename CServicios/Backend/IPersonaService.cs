using Modelos.Modelos;
using System.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ServiciosBancarios.Backend
{
    [ServiceContract]
    interface IPersonaService
    {
        [OperationContract]
        bool Persona_Crear(PersonaModel aPersona);

        [OperationContract]
        bool Persona_Editar(PersonaModel aPersona);

        [OperationContract]
        bool ActualizarEstado(int admin, int idusuario, bool estado);

        [OperationContract]
        bool Persona_Eliminar(int aID_Persona);

        [OperationContract]
        PersonaModel Persona_ObtenerUno(int aID_Persona);

        [OperationContract]
        List<PersonaModel> Persona_ObtenerTodos();

        [OperationContract]
        PersonaModel Persona_ValidarUsuario(string aUsuario, string aContraseña);

        [OperationContract]
        bool Persona_CambiarContraseña(string aUsuario, string aPassword, string aNewPassword);

        [OperationContract]
        SucursalModel Persona_ObtenerSucursal(int idUsuario);

        [OperationContract]
        List<ComponenteModel> Persona_GetComponentes(int idUsuario);

        [OperationContract]
        List<RolesModel> Persona_GetRolesUsuario(string aUsuario);

        [OperationContract]
        DataTable GetPersonasPorRol(int idRol);

        [OperationContract]
        List<PersonaModel> Persona_GetPersonaNombreApellidos(string nombre, string apellido);

        [OperationContract]
        bool Persona_CrearNuevoUsuario(int idPersona, string Usuario, string Contraseña, bool Estado);

        [OperationContract]
        List<PersonaModel> Persona_UsuarioSelectAll();

        [OperationContract]
        List<PersonaModel> PersonaSelectbyNroDocumento(string aValue);

        [OperationContract]
        List<PersonaModel> PersonaSelectbyNombres(string aValue);

        [OperationContract]
        List<PersonaModel> PersonaSelectbyApellidos(string aValue);

        [OperationContract]
        List<PersonaModel> PersonaSelectbyId(string aValue);

        [OperationContract]
        List<PersonaModel> ObtenerUsuariosSinCredenciales();
    }
}