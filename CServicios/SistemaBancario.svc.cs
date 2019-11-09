using CNegocio.Ventanilla;
using CNegocio.Backend;
using CNegocio.Plataforma;
using Modelos.Modelos;
using ServiciosBancarios.Backend;
using ServiciosBancarios.Ventanilla;
using ServiciosBancarios.Plataforma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;

namespace ServiciosBancarios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
     public class SistemaBancario : ICobroChequeService, IEmpresaService, IPagoServicioService, IRecaudosService, ITipoMonedaService, ITipoMovimientoService, IVentanillaService, IBancoService, IComponenteService, IHorariosAtencionService, IPermisosUsuarioService, IPersonaService, IRolesService, IRolUsuarioService, ISucursalService, ITipoDocumentoService, ITurnosService, ITurnoUsuarioService, ICuentaService,ICajaChicaService,IDetalleCajaChicaService, IPrestamoService, IFechaHoraServerService
    {
        #region [ Varibles Globales ]

        #region [ Ventanilla Front ]
        private CobroChequeMethods BLCobroCheque;
        private EmpresaMethods BLEmpresa;
        private PagoServicioMethods BLPagoServicio;
        private RecaudoMethods BLRecaudos;
        private TipoMonedaMethods BLTipoMoneda;
        private TipoMovimientoMethods BLTipoMovimiento;
        private VentanillaMethods BLVentanila;
        #endregion

        #region [ Ventanilla Back ]
        private BancoMethods BLBanco;
        private CajaChicaMethods BLCajaChica;
        private DetalleCajaChicaMethods BLDetalleCajaChica;
        private ComponenteMethods BLComponente;
        private HorariosAtencionMethods BLHorariosAtencion;
        private PermisosUsuarioMethods BLPermisosUsuario;
        private PersonaMethods BLPersona;
        private RolesMethods BLRoles;
        private RolUsuarioMethods BLRolUsuario;
        private SucursalMethods BLSucursal;
        private TipoDocumentoMethods BLTipoDocumento;
        private TurnosMethods BLTurnos;
        private TurnoUsuarioMethods BLTurnoUsuario;
        #endregion

        #region [ Plataforma ]

        private BLCuenta BLCuenta;
        private BLPrestamo BLPrestamo;

        #endregion

        #endregion

        public SistemaBancario()
        {
            #region [ Ventanilla Front ]
            BLEmpresa = new EmpresaMethods();
            BLEmpresa = new EmpresaMethods();
            BLPagoServicio = new PagoServicioMethods();
            BLRecaudos = new RecaudoMethods();
            BLTipoMoneda = new TipoMonedaMethods();
            BLTipoMovimiento = new TipoMovimientoMethods();
            BLVentanila = new VentanillaMethods();
            BLCobroCheque = new CobroChequeMethods();
        #endregion

            #region [ Ventanilla Back ]
        BLBanco = new BancoMethods();
            BLCajaChica = new CajaChicaMethods();
            BLDetalleCajaChica = new DetalleCajaChicaMethods();
            BLComponente = new ComponenteMethods();
            BLHorariosAtencion = new HorariosAtencionMethods();
            BLPermisosUsuario = new PermisosUsuarioMethods();
            BLPersona = new PersonaMethods();
            BLRoles = new RolesMethods();
            BLRolUsuario = new RolUsuarioMethods();
            BLSucursal = new SucursalMethods();
            BLTipoDocumento = new TipoDocumentoMethods();
            BLTurnos = new TurnosMethods();
            BLTurnoUsuario = new TurnoUsuarioMethods();
            #endregion

            #region [ Plataforma ]

            BLCuenta = new BLCuenta();
            BLPrestamo = new BLPrestamo();

            #endregion
        }

        #region [ Ventanilla Front ]

        #region [ Cobro cheque ]

        bool ICobroChequeService.CobroCheque_Crear(CobroChequesModel aCobroCheque)
        {        
            return BLCobroCheque.Crear(aCobroCheque);
        }

        bool ICobroChequeService.CobroCheque_Editar(CobroChequesModel aCobroCheque)
        {        
            return BLCobroCheque.Editar(aCobroCheque);
        }

        bool ICobroChequeService.CobroCheque_Eliminar(int aID_Cheque, int aID_Movimiento)
        {      
            return BLCobroCheque.Eliminar(aID_Cheque, aID_Movimiento);
        }

        List<CobroChequesModel> ICobroChequeService.CobroCheque_ObtenerTodos()
        {        
            return BLCobroCheque.ObtenerTodos();
        }

        CobroChequesModel ICobroChequeService.CobroCheque_ObtenerUno(int aID_Cheque, int aID_Movimiento)
        {         
            return BLCobroCheque.ObtenerUno(aID_Cheque, aID_Movimiento);
        }
        #endregion

        #region [ Empresa ]
        bool IEmpresaService.Empresa_Crear(EmpresaModel aEmpresaModel)
        {
            return BLEmpresa.Crear(aEmpresaModel);
        }

        bool IEmpresaService.Empresa_Editar(EmpresaModel aEmpresaModel)
        {
            return BLEmpresa.Editar(aEmpresaModel);
        }

        bool IEmpresaService.Empresa_Eliminar(int aID_EmpresaModel)
        {
            return BLEmpresa.Eliminar(aID_EmpresaModel);
        }

        List<EmpresaModel> IEmpresaService.Empresa_ObtenerTodos()
        {
            return BLEmpresa.ObtenerTodos();
        }

        EmpresaModel IEmpresaService.Empresa_ObtenerUno(int aID_EmpresaModel)
        {
            return BLEmpresa.ObtenerUno(aID_EmpresaModel);
        }
        #endregion

        #region [ Pago Servicio ]
        bool IPagoServicioService.PagoServicio_Crear(PagoServiciosModel aPagoServicios)
        {
            return BLPagoServicio.Crear(aPagoServicios);
        }

        bool IPagoServicioService.PagoServicio_Editar(PagoServiciosModel aPagoServicios)
        {
            return BLPagoServicio.Editar(aPagoServicios);
        }

        bool IPagoServicioService.PagoServicio_Eliminar(int aNro_Contrato, int aID_Movimiento)
        {
            return BLPagoServicio.Eliminar(aNro_Contrato, aID_Movimiento);
        }

        List<PagoServiciosModel> IPagoServicioService.PagoServicio_ObtenerTodos()
        {
            return BLPagoServicio.ObtenerTodos();
        }

        PagoServiciosModel IPagoServicioService.PagoServicio_ObtenerUno(int aNro_Contrato, int aID_Movimiento)
        {
            return BLPagoServicio.ObtenerUno(aNro_Contrato, aID_Movimiento);
        }

        #endregion

        #region [ Recaudos ]
        bool IRecaudosService.Recaudos_Crear(RecaudosModel aRecaudos)
        {
            return BLRecaudos.Crear(aRecaudos);
        }

        bool IRecaudosService.Recaudos_Editar(RecaudosModel aRecaudos)
        {
            return BLRecaudos.Editar(aRecaudos);
        }

        bool IRecaudosService.Recaudos_Eliminar(int aNro_Contrato)
        {
            return BLRecaudos.Eliminar(aNro_Contrato);
        }

        List<RecaudosModel> IRecaudosService.Recaudos_ObtenerTodos()
        {
            return BLRecaudos.ObtenerTodos();
        }

        RecaudosModel IRecaudosService.Recaudos_ObtenerUno(int aNro_Contrato)
        {
            return BLRecaudos.ObtenerUno(aNro_Contrato);
        }

        #endregion

        #region [ Tipo Moneda ]

        public bool Moneda_Crear(TipoMonedaModel aTipoMonedaModel)
        {
            return BLTipoMoneda.Crear(aTipoMonedaModel);
        }

        public bool Moneda_Editar(TipoMonedaModel aTipoMonedaModel)
        {
            return BLTipoMoneda.Editar(aTipoMonedaModel);
        }

        public bool Moneda_Eliminar(int aID_TipoMonedaModel)
        {
            return BLTipoMoneda.Eliminar(aID_TipoMonedaModel);
        }

        public TipoMonedaModel Moneda_ObtenerUno(int aID_TipoMonedaModel)
        {
            return BLTipoMoneda.ObtenerUno(aID_TipoMonedaModel);
        }

        public List<TipoMonedaModel> Moneda_ObtenerTodos()
        {
            return BLTipoMoneda.ObtenerTodos();
        }

        #endregion

        #region [ Tipo Movimiento ]

        bool ITipoMovimientoService.TipoMovimiento_Crear(MovimientosVentanillaModel aMovimientoVentanilla)
        {
            return BLTipoMovimiento.Crear(aMovimientoVentanilla);
        }

        bool ITipoMovimientoService.TipoMovimiento_Editar(MovimientosVentanillaModel aMovimientoVentanilla)
        {
            return BLTipoMovimiento.Editar(aMovimientoVentanilla);
        }

        bool ITipoMovimientoService.TipoMovimiento_Eliminar(int aID_Movimiento)
        {
            return BLTipoMovimiento.Eliminar(aID_Movimiento);
        }

        List<MovimientosVentanillaModel> ITipoMovimientoService.TipoMovimiento_ObtenerTodos()
        {
            return BLTipoMovimiento.ObtenerTodos();
        }

        MovimientosVentanillaModel ITipoMovimientoService.TipoMovimiento_ObtenerUno(int aID_Movimiento)
        {
            return BLTipoMovimiento.ObtenerUno(aID_Movimiento);
        }
        #endregion

        #region [ Ventanilla ]

        bool IVentanillaService.Ventanilla_Crear(VentanillaModel aVentanilla, int id_user)
        {
            return BLVentanila.Crear(aVentanilla, id_user);
        }

        bool IVentanillaService.Ventanilla_Editar(VentanillaModel aVentanilla, int id_user)
        {
            return BLVentanila.Editar(aVentanilla, id_user);
        }

        bool IVentanillaService.Ventanilla_Eliminar(int aID_VentanillaModel)
        {
            return BLVentanila.Eliminar(aID_VentanillaModel);
        }

        List<VentanillaModel> IVentanillaService.Ventanilla_ObtenerTodos()
        {
            return BLVentanila.ObtenerTodos();
        }

        VentanillaModel IVentanillaService.Ventanilla_ObtenerUno(int aID_VentanillaModel)
        {
            return BLVentanila.ObtenerUno(aID_VentanillaModel);
        }
        VentanillaModel IVentanillaService.Ventanilla_ObtenerUnoXusuario(int Id_Usuario)
        {
            return BLVentanila.ObtenerUnoXUsuario(Id_Usuario);
        }
        List<VentanillaModel> IVentanillaService.GetVentanillasXSucursal(int sucursal,int turno)
        {
            return BLVentanila.ObtenerVentanillasXSucursal(sucursal,turno);
        }
        #endregion

        #endregion

        #region [ Ventanilla Back ]

        #region [ Banco ]
        public bool Banco_Crear(BancoModel aBanco, int id_user)
        {
            return BLBanco.Crear(aBanco, id_user);
        }

        public bool Banco_Editar(BancoModel aBanco, int id_user)
        {
            return BLBanco.Editar(aBanco, id_user);
        }

        public bool Banco_Eliminar(int aID_Banco)
        {
            return BLBanco.Eliminar(aID_Banco);
        }

        public List<BancoModel> Banco_ObtenerTodos()
        {
            return BLBanco.ObtenerTodos();
        }

        public BancoModel Banco_ObtenerUno(int aID_Banco)
        {
            return BLBanco.ObtenerUno(aID_Banco);
        }
        #endregion

    

        


        #region [ Componente ]

        public bool Componente_Crear(ComponenteModel aComponente, int id_user)
        {
            return BLComponente.Crear(aComponente, id_user);
        }

        public bool Componente_Editar(ComponenteModel aComponente, int id_user)
        {
            return BLComponente.Editar(aComponente, id_user);
        }

        public bool Componente_Eliminar(int aID_Componente)
        {
            return BLComponente.Eliminar(aID_Componente);
        }

        public ComponenteModel Componente_ObtenerUno(int aID_Componente)
        {
            return BLComponente.ObtenerUno(aID_Componente);
        }

        public List<ComponenteModel> Componente_ObtenerTodos()
        {
            return BLComponente.ObtenerTodos();
        }

        public List<ComponenteModel> Componente_ObtenerComponentesRol(int aID_Rol)
        {
            return BLComponente.ObtenerComponentesRol(aID_Rol);
        }

        public List<ComponenteModel> ObtenerTodosComponentes()
        {
            return BLComponente.ObtenerTodosComponentes();
        }


        #endregion

        #region [ Horarios Atencion ]
        public bool HorariosAtencion_Crear(HorariosAtencionModel aHorariosAtencion)
        {
            return BLHorariosAtencion.Crear(aHorariosAtencion);
        }

        public bool HorariosAtencion_Editar(HorariosAtencionModel aHorariosAtencion)
        {
            return BLHorariosAtencion.Editar(aHorariosAtencion);
        }

        public bool HorariosAtencion_Eliminar(int aID_HorariosAtencion)
        {
            return BLHorariosAtencion.Eliminar(aID_HorariosAtencion);
        }

        public HorariosAtencionModel HorariosAtencion_ObtenerUno(int aID_HorariosAtencion)
        {
            return BLHorariosAtencion.ObtenerUno(aID_HorariosAtencion);
        }

        public List<HorariosAtencionModel> HorariosAtencion_ObtenerTodos()
        {
            return BLHorariosAtencion.ObtenerTodos();
        }


        #endregion

        #region [ Permisos Usuario ]
        public bool PermisosUsuario_Crear(PermisosUsuarioModel aPermisosUsuario, int id_user)
        {
            return BLPermisosUsuario.Crear(aPermisosUsuario, id_user);
        }

        public bool PermisosUsuario_Editar(PermisosUsuarioModel aPermisosUsuario, int id_user)
        {
            return BLPermisosUsuario.Editar(aPermisosUsuario, id_user);
        }

        public bool PermisosUsuario_Eliminar(int aID_PermisosUsuario)
        {
            return BLPermisosUsuario.Eliminar(aID_PermisosUsuario);
        }

        public PermisosUsuarioModel PermisosUsuario_ObtenerUno(int aID_PermisosUsuario)
        {
            return BLPermisosUsuario.ObtenerUno(aID_PermisosUsuario);
        }

        public List<PermisosUsuarioModel> PermisosUsuario_ObtenerTodos()
        {
            return BLPermisosUsuario.ObtenerTodos();
        }
        public List<PermisosUsuarioModel> PermisosUsuarioXusuario(int IdUsuario )
        {
            return BLPermisosUsuario.ObtenerPermisosXUsaurio(IdUsuario);
        }

        #endregion

        #region [ Persona ]
        public bool Persona_Crear(PersonaModel aPersona)
        {
            return BLPersona.Crear(aPersona);
        }

        public bool Persona_Editar(PersonaModel aPersona)
        {
            return BLPersona.Editar(aPersona);
        }

        public bool ActualizarEstado(int admin, int idusuario, bool estado)
        {
            return BLPersona.ActualizarEstado(admin, idusuario, estado);
        }

        public bool Persona_Eliminar(int aID_Persona)
        {
            return BLPersona.Eliminar(aID_Persona);
        }

        public PersonaModel Persona_ObtenerUno(int aID_Persona)
        {
            return BLPersona.ObtenerUno(aID_Persona);
        }

        public List<PersonaModel> Persona_ObtenerTodos()
        {
            return BLPersona.ObtenerTodos();
        }

        public List<PersonaModel> PersonaSelectbyNroDocumento(string aValue)
        {
            return BLPersona.personaSelectbyNroDocumento(aValue);
        }

        public PersonaModel Persona_ValidarUsuario(string aUsuario, string aContraseña)
        {
            return BLPersona.ValidarUsuario(aUsuario, aContraseña);
        }

        public bool Persona_CambiarContraseña(string aUsuario, string aContraseña, string aNuevaContraseña)
        {
            return BLPersona.CambiarContraseña(aUsuario, aContraseña, aNuevaContraseña);
        }

        public SucursalModel Persona_ObtenerSucursal(int idUsuario)
        {
            return BLPersona.ObtenerSucursal(idUsuario);
        }

        public List<ComponenteModel> Persona_GetComponentes(int idUsuario)
        {
            return BLPersona.GetComponentes(idUsuario);
        }

        public List<RolesModel> Persona_GetRolesUsuario(string aUsuario)
        {
            return BLPersona.GetRolesUsuario(aUsuario);
        }

        public DataTable GetPersonasPorRol(int idRol)
        {
            return BLPersona.GetPersonasPorRol(idRol);
        }

        public List<PersonaModel> Persona_GetPersonaNombreApellidos(string nombre, string apellido)
        {
            return BLPersona.GetPersonaNombreApellidos(nombre,apellido);
        }

        public List<PersonaModel> PersonaSelectbyNombres(string nombres)
        {
            return BLPersona.personaSelectbyNombres(nombres);
        }

        public List<PersonaModel> PersonaSelectbyApellidos(string apellidos)
        {
            return BLPersona.personaSelectbyApellidos(apellidos);
        }

        public bool Persona_CrearNuevoUsuario(int idPersona, string Usuario, string Contraseña, bool Estado)
        {
            return BLPersona.CrearNuevoUsuario(idPersona,Usuario,Contraseña,Estado);
        }

        public List<PersonaModel> Persona_UsuarioSelectAll()
        {
            return BLPersona.UsuarioSelectAll();
        }

        public List<PersonaModel> PersonaSelectbyId(string aValue)
        {
            return BLPersona.personaSelectbyID(aValue);
        }

        public List<PersonaModel> ObtenerUsuariosSinCredenciales()
        {
            return BLPersona.ObtenerUsuariosSinCredenciales();
        }

        public bool ActualizarEstadoRolUsuario(int admin, int idusuario, bool estado)
        {
            return BLPersona.ActualizarEstadoRolUsuario(admin,idusuario,estado);
        }


        #endregion

        #region [ Roles ]

        public bool Roles_Crear(RolesModel aRoles, int id_user)
        {
            return BLRoles.Crear(aRoles);
        }

        public bool Roles_Editar(RolesModel aRoles, int id_user)
        {
            return BLRoles.Editar(aRoles);
        }

        public bool Roles_Eliminar(int aID_Roles)
        {
            return BLRoles.Eliminar(aID_Roles);
        }

        public RolesModel Roles_ObtenerUno(int aID_Roles)
        {
            return BLRoles.ObtenerUno(aID_Roles);
        }

        public List<RolesModel> Roles_ObtenerTodos()
        {
            return BLRoles.ObtenerTodos();
        }

        public List<RolUsuarioModel> Roles_RolesPorPersona(int aID_Usuario)
        {
            return BLRoles.RolesPorPersona(aID_Usuario);
        }

        #endregion

        #region [ Rol Usuario ]

        public bool RolUsuario_Crear(RolUsuarioModel aRolUsuario, int id_user)
        {
            return BLRolUsuario.Crear(aRolUsuario);
        }

        public bool RolUsuario_Editar(RolUsuarioModel aRolUsuario, int id_user)
        {
            return BLRolUsuario.Editar(aRolUsuario);
        }

        public bool RolUsuario_Eliminar(int aID_RolUsuario)
        {
            return BLRolUsuario.Eliminar(aID_RolUsuario);
        }

        public RolUsuarioModel RolUsuario_ObtenerUno(int aID_RolUsuario)
        {
            return BLRolUsuario.ObtenerUno(aID_RolUsuario);
        }

        public List<RolUsuarioModel> RolUsuario_ObtenerTodos()
        {
            return BLRolUsuario.ObtenerTodos();
        }


        #endregion

        #region [ Sucursal ]

        public bool Sucursal_Crear(SucursalModel aSucursal, int id_user)
        {
            return BLSucursal.Crear(aSucursal, id_user);
        }

        public bool Sucursal_Editar(SucursalModel aSucursal, int id_user)
        {
            return BLSucursal.Editar(aSucursal, id_user);
        }

        public bool Sucursal_Eliminar(int aID_Sucursal)
        {
            return BLSucursal.Eliminar(aID_Sucursal);
        }

        public SucursalModel Sucursal_ObtenerUno(int aID_Sucursal)
        {
            return BLSucursal.ObtenerUno(aID_Sucursal);
        }

        public List<SucursalModel> Sucursal_ObtenerTodos()
        {
            return BLSucursal.ObtenerTodos();
        }


        #endregion

        #region [ Tipo Documento ]

        public bool TipoDocumento_Crear(TipoDocumentoModel aTipoDocumento)
        {
            return BLTipoDocumento.Crear(aTipoDocumento);
        }

        public bool TipoDocumento_Editar(TipoDocumentoModel aTipoDocumento)
        {
            return BLTipoDocumento.Editar(aTipoDocumento);
        }

        public bool TipoDocumento_Eliminar(int aID_TipoDocumento)
        {
            return BLTipoDocumento.Eliminar(aID_TipoDocumento);
        }

        public TipoDocumentoModel TipoDocumento_ObtenerUno(int aID_TipoDocumento)
        {
            return BLTipoDocumento.ObtenerUno(aID_TipoDocumento); ;
        }

        public List<TipoDocumentoModel> TipoDocumento_ObtenerTodos()
        {
            return BLTipoDocumento.ObtenerTodos();
        }

        #endregion

        #region [ Turnos ]

        public bool Turnos_Crear(TurnosModel aTurnos, int id_user)
        {
            return BLTurnos.Crear(aTurnos, id_user);
        }

        public bool Turnos_Editar(TurnosModel aTurnos, int id_user)
        {
            return BLTurnos.Editar(aTurnos, id_user);
        }

        public bool Turnos_Eliminar(int aID_Turnos)
        {
            return BLTurnos.Eliminar(aID_Turnos);
        }

        public TurnosModel Turnos_ObtenerUno(int aID_Turnos)
        {
            return BLTurnos.ObtenerUno(aID_Turnos);
        }
        public TurnosModel Turnos_ObtenerUnoXUsuario(int Id_usuario)
        {
            return BLTurnos.ObtenerUnoXUsuario(Id_usuario);
        }

        public List<TurnosModel> Turnos_ObtenerTodos()
        {
            return BLTurnos.ObtenerTodos();
        }




        #endregion

        #region [ Turno Usuario ]

        public bool TurnoUsuario_Crear(TurnoUsuarioModel aTurnoUsuario, int id_user)
        {
            return BLTurnoUsuario.Crear(aTurnoUsuario, id_user);
        }

        public bool TurnoUsuario_Editar(TurnoUsuarioModel aTurnoUsuario, int id_user)
        {
            return BLTurnoUsuario.Editar(aTurnoUsuario, id_user);
        }

        public bool TurnoUsuario_Eliminar(int aID_TurnoUsuario)
        {
            return BLTurnoUsuario.Eliminar(aID_TurnoUsuario);
        }

        public TurnoUsuarioModel TurnoUsuario_ObtenerUno(int aID_TurnoUsuario)
        {
            return BLTurnoUsuario.ObtenerUno(aID_TurnoUsuario);
        }

        public List<TurnoUsuarioModel> TurnoUsuario_ObtenerTodos()
        {
            return BLTurnoUsuario.ObtenerTodos();
        }

        #endregion

        #endregion

        #region [ Plataforma ]

        #region [ Cuentas ]

        public bool Cuenta_Crear(CuentasModel aCuenta)
        {
            return BLCuenta.Insert(aCuenta);
        }

        public bool Cuenta_Editar(CuentasModel aCuenta)
        {
            return BLCuenta.Update(aCuenta);
        }

        public CuentasModel Cuenta_ObtenerUno(string aNro_Cuenta)
        {
            return BLCuenta.Getcuenta(aNro_Cuenta);
        }

        public List<CuentasModel> Cuenta_ObtenerTodos(int aID_Persona)
        {
            return BLCuenta.cuentaSelectbyId_cliente(aID_Persona);
        }

        public bool Cuenta_Borrar(string aID_Cuenta)
        {
            return BLCuenta.Delete(aID_Cuenta);
        }

        public List<CuentasModel> Cuenta_SeleccionarPorNumero(string aID_Cuenta)
        {
            return BLCuenta.cuentaSelectbyNroCuenta(aID_Cuenta);
        }

        public List<CuentasModel> Cuenta_SeleccionarPorNumeroPrestamo(string aID_Cuenta)
        {
            return BLCuenta.cuentaSelectbyNroCuentaPrestamo(aID_Cuenta);
        }

        public List<CuentasModel> cuentaSelectbyId_cliente(int id_cliente)
        {
            return BLCuenta.cuentaSelectbyId_cliente(id_cliente);
        }

        #endregion

        #region [ Prestamos ]

        public bool Prestamo_Crear(PrestamosModel aPrestamo)
        {
            return BLPrestamo.Insert(aPrestamo);
        }

        public bool Prestamo_Editar(PrestamosModel aPrestamo)
        {
            return BLPrestamo.Update(aPrestamo);
        }

        public bool Prestamo_Borrar(int aID_Prestamo)
        {
            return BLPrestamo.Delete(aID_Prestamo);
        }

        public PrestamosModel Prestamo_ObtenerUno(int aNro_Prestamo)
        {
            return BLPrestamo.Getprestamo(aNro_Prestamo);
        }

        public List<PrestamosModel> Prestamo_SelecionarPorCuenta(string aID_Cuenta)
        {
            return BLPrestamo.prestamoSelectbyNroCuenta(aID_Cuenta);
        }

        public List<PrestamosModel> Prestamo_SeleccionarPorId(string aID_Prestamo)
        {
            return BLPrestamo.prestamoSelectbyID(aID_Prestamo);
        }

        #endregion

        #region [ Fecha Server ]

        public DateTime? ObtenerFechaHoraActual()
        {
            return BLFechaHoraServidor.Obtener();
        }

        #endregion

        #region [ Caja Chica ]

        public int Crear(CajaChicaModel aCajaChica,int id_user)
        {
            return BLCajaChica.Crear(aCajaChica,id_user);
        }

        public bool Editar(CajaChicaModel aCajaChica, int id_user)
        {
            return BLCajaChica.Editar(aCajaChica, id_user);
        }

        public bool Eliminar(int aID_CajaChica)
        {
            return BLCajaChica.Eliminar(aID_CajaChica);
        }

        public CajaChicaModel ObtenerUno(int aID_CajaChica)
        {
            return BLCajaChica.ObtenerUno(aID_CajaChica);
        }

        public List<CajaChicaModel> ObtenerTodos()
        {
            return BLCajaChica.ObtenerTodos();
        }

        public List<VentanillaModel> GetVentanillasXSucursal(int Idsucursal)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region [ Detalle caja Chica ]

        public bool DetalleCajaChica_Crear(DetalleCajaChicaModel aDetalleCajaChica, int id_user)
        {
            return BLDetalleCajaChica.Crear(aDetalleCajaChica, id_user);
        }
        public bool DetalleCajaChica_Editar(DetalleCajaChicaModel aDetalleCajaChica, int id_user)
        {
            return BLDetalleCajaChica.Editar(aDetalleCajaChica, id_user);
        }

        public bool DetalleCajaChica_Eliminar(int aID_DetalleCajaChica)
        {
            return BLDetalleCajaChica.Eliminar(aID_DetalleCajaChica);
        }

        public DetalleCajaChicaModel DetalleCajaChica_ObtenerUno(int aID_DetalleCajaChica)
        {
            return BLDetalleCajaChica.ObtenerUno(aID_DetalleCajaChica);
        }

        public List<DetalleCajaChicaModel> DetalleCajaChica_ObtenerTodos()
        {
            return BLDetalleCajaChica.ObtenerTodos();
        }

        public List<PermisosUsuarioModel> PermisosUsuario_ObtenerTodos(int IdUsuario)
        {
            throw new NotImplementedException();
        }


        #endregion

        #endregion
    }
}
