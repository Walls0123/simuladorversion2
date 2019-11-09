using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CNegocio.Backend
{
    public class PersonaMethods
    {
        private PersonaManager ADPersonaManager = new PersonaManager();

        /// <summary>
        /// Saves a record to the persona table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>	
        public bool Crear(PersonaModel aPersona)
        {
            return ADPersonaManager.Insert(aPersona);
        }

        /// <summary>
        /// Updates a record to the persona table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Editar(PersonaModel aPersona)
        {
            return ADPersonaManager.Update(aPersona);
        }

        /// <summary>
        /// Actualiza el estado de una persona
        /// </summary>
        /// <param name="admin">Administrador si/no</param>
        /// <param name="idusuario">Id del usuario</param>
        /// <param name="estado">Estado activo?</param>
        /// <returns>retorna el exito de la operación</returns>
        public bool ActualizarEstado(int admin, int idusuario, bool estado)
        {
            return ADPersonaManager.ActualizarEstado(admin, idusuario, estado);
        }

        /// <summary>
        /// Deletes record to the persona table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Eliminar(int aID_Persona)
        {
            return ADPersonaManager.Delete(aID_Persona);
        }

        /// <summary>
        /// Selects the Single object of persona table.
        /// </summary>
        public PersonaModel ObtenerUno(int aID_Persona)
        {
            return ADPersonaManager.GetPersonaModel(aID_Persona);
        }

        /// <summary>
        /// Selects all the objects of persona table.
        /// </summary>
        public List<PersonaModel> ObtenerTodos()
        {
            return ADPersonaManager.PersonaModelSelectAll();
        }

        /// <summary>
        /// Selects the Multiple objects of persona table by a given criteria.
        /// </summary>
        public List<PersonaModel> personaSelectbyID(string aValue)
        {
            return ADPersonaManager.personaSelectbyID(aValue);
        }

        /// <summary>
        /// Selects the Multiple objects of persona table by a given criteria.
        /// </summary>
        public List<PersonaModel> personaSelectbyNombres(string aValue)
        {
            return ADPersonaManager.personaSelectbyNombres(aValue);
        }

        /// <summary>
        /// Selects the Multiple objects of persona table by a given criteria.
        /// </summary>
        public List<PersonaModel> personaSelectbyApellidos(string aValue)
        {
            return ADPersonaManager.personaSelectbyApellidos(aValue);
        }
        public List<PersonaU> personaSelectbyNombresApellidos(string aValue)
        {
            return ADPersonaManager.personaSelectbyNombresApellidos(aValue);
        }

        //personaSelectbyNombresApellidos

        /// <summary>
        /// Selects the Multiple objects of persona table by a given criteria.
        /// </summary>
        public List<PersonaModel> personaSelectbyNroDocumento(string aValue)
        {
            return ADPersonaManager.personaSelectbyNroDocumento(aValue);
        }

        /// <summary>
        /// Comprueba si el usuario existe en base de datos o si las credenciales son incorrectas
        /// </summary>
        /// <param name="aUsuario">NickName</param>
        /// <param name="aContraseña">Contraseña</param>
        /// <returns>Existe SI/NO</returns>
        public PersonaModel ValidarUsuario(string aUsuario, string aContraseña)
        {
            return ADPersonaManager.ValidarUsuario(aUsuario, aContraseña);
        }

        /// <summary>
        /// Cambia la contraseña de un usuario
        /// </summary>
        /// <param name="aUsuario">NickName</param>
        /// <param name="aContraseña">Contraseña antigua</param>
        /// <param name="aNuevaContraseña">Contraseña nueva</param>
        /// <returns>Retorna el exito de la operacion</returns>
        public bool CambiarContraseña(string aUsuario, string aContraseña, string aNuevaContraseña)
        {

            return ADPersonaManager.CambiarContraseña(aUsuario, aContraseña, aNuevaContraseña);
        }

        /// <summary>
        /// Obtiene la sucursal sobre el inicio de sesion
        /// </summary>
        /// <param name="idUsuario">Id Usuario</param>
        /// <returns></returns>
        public SucursalModel ObtenerSucursal(int idUsuario)
        {
            return ADPersonaManager.ObtenerSucursal(idUsuario);
        }

        /// <summary>
        /// Extrae los componentes asociados a un usuario
        /// </summary>
        /// <param name="idUsuario">Id usuario</param>
        /// <returns>Retorna los componentes que el usuario posee</returns>
        public List<ComponenteModel> GetComponentes(int idUsuario)
        {
            return ADPersonaManager.GetComponentes(idUsuario);
        }

        /// <summary>
        /// Extrae los roles que el usuario posee
        /// </summary>
        /// <param name="aUsuario">Id usuario</param>
        /// <returns>Retorna una lista de roles pertenecientes al usuario</returns>
        public List<RolesModel> GetRolesUsuario(string aUsuario)
        {
            return ADPersonaManager.GetRolesUsuario(aUsuario);
        }

        /// <summary>
        /// Extrae las personas de acuerdo a un rol
        /// </summary>
        /// <param name="idRol">Id del rol</param>
        /// <returns>Retorna un DataTable con los roles</returns>
        public DataTable GetPersonasPorRol(int idRol)
        {
            return ADPersonaManager.GetPersonasPorRol(idRol);
        }

        /// <summary>
        /// Extrae las personas de acuerdo a la busqueda realizada por nombres o apellidos
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <returns>Retorna una lista de personas con las coincidencias</returns>
        public List<PersonaModel> GetPersonaNombreApellidos(string nombre, string apellido)
        {
            return ADPersonaManager.GetPersonaNombreApellidos(nombre, apellido);
        }

        /// <summary>
        /// Crea un nuevo usuario para usar el sistema
        /// </summary>
        /// <param name="idPersona">Id de persona existente</param>
        /// <param name="Usuario">Nuevo NickName de usuario</param>
        /// <param name="Contraseña">Nueva Contraseña</param>
        /// <param name="Estado">Estado Activo si/no</param>
        /// <returns>Retorna el exito de la operacion</returns>
        public bool CrearNuevoUsuario(int idPersona, string Usuario, string Contraseña, bool Estado)
        {
            return ADPersonaManager.CrearNuevoUsuario(idPersona,Usuario,Contraseña,Estado);
        }

        /// <summary>
        /// Extrae todas las personas catalogadas como usuarios
        /// </summary>
        /// <returns>Retorna una lista de personas designadas como usuarios</returns>
        public List<PersonaModel> UsuarioSelectAll()
        {
            return ADPersonaManager.UsuarioSelectAll();
        }

        /// <summary>
        /// Obtiene todas las personas que no tienen credenciales asignadas
        /// </summary>
        /// <returns>retorna una lista con todos las personas sin credenciales</returns>
        public List<PersonaModel> ObtenerUsuariosSinCredenciales()
        {
            return ADPersonaManager.ObtenerUsuariosSinCredenciales();
        }

        /// <summary>
        /// Actualiza el estado de Rol-Usuario
        /// </summary>
        /// <param name="admin">SI/NO</param>
        /// <param name="idusuario">Id de usuario</param>
        /// <param name="estado">Activo Inactivo</param>
        /// <returns>Retorna el exito de la operacion</returns>
        public bool ActualizarEstadoRolUsuario(int admin, int idusuario, bool estado)
        {
            return ADPersonaManager.ActualizarEstadoRolUsuario(admin,idusuario,estado);
        }

    }
}
