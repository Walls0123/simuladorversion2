using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Modelos;
using Sistema_Bancario.Clases;
using System.ServiceModel.Channels;
using Modelos.Session;

namespace Sistema_Bancario.Administrador
{
    public partial class Roles : UserControl
    {
        Modelos.Session.ISession session = new Session();
        public Roles()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            cargarDGV();
        }

        private static Roles _instance;
        public static Roles instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Roles();
                }
                return _instance;
            }
        }

        public List<RolesModel> roles;

        private void cargarDGV()
        {
            try
            {
                using (WsSistemaBancario.RolesServiceClient rol = new WsSistemaBancario.RolesServiceClient())
                {
                    roles = rol.Roles_ObtenerTodos().ToList();
                    
                    dgvRoles.DataSource = roles;

                    dgvRoles.Columns["Fecha_creacion"].Visible = false;
                    dgvRoles.Columns["Fecha_modificacion"].Visible = false;
                    dgvRoles.Columns["Usuario_creador"].Visible = false;
                    dgvRoles.Columns["Usuario_modificador"].Visible = false;
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtRol.Text)) {
                    using (WsSistemaBancario.RolesServiceClient rol = new WsSistemaBancario.RolesServiceClient())
                    {
                        RolesModel objectmodelo = new RolesModel();

                        objectmodelo.Descripcion = txtRol.Text;
                        objectmodelo.Fecha_creacion = DateTime.Now;
                        objectmodelo.Usuario_creador = "Miau";
                        objectmodelo.Fecha_modificacion = DateTime.Now;

                        objectmodelo.Usuario_modificador = "";

                        rol.Roles_Crear(objectmodelo, 1);
                        
                        cargarDGV();
                        
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public static string nombreRol;
        public static int idRol;

        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtRol.Text = dgvRoles.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();

                nombreRol = dgvRoles.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                idRol = Convert.ToInt16(dgvRoles.Rows[e.RowIndex].Cells["Id"].Value);
            }
            llenarDGVPermisosRol();
        }
        
        public DataTable usuarios;
        public List<RolUsuarioModel> listausuarios;
        public bool generarbotones;

        private void llenarDGVUsuarios()
        {
            try
            {
                using (WsSistemaBancario.PersonaServiceClient UsuariosRol = new WsSistemaBancario.PersonaServiceClient())
                {
                    usuarios = UsuariosRol.GetPersonasPorRol(idRol);
                    dgvUsuarios.DataSource = usuarios;
                    dgvUsuarios.CurrentCell = null;
                    dgvUsuarios.Columns["Id"].DataPropertyName = "Id";
                    dgvUsuarios.Columns["IDPersona"].DataPropertyName = "IDPersona";
                    dgvUsuarios.Columns["Nombres"].DataPropertyName = "Nombres";
                    dgvUsuarios.Columns["Nombreusuario"].DataPropertyName = "Nombreusuario";
                    dgvUsuarios.Columns["Estado"].DataPropertyName = "Estado";
                    dgvUsuarios.Columns["Id"].Visible = false;
                    dgvUsuarios.Columns["IDPersona"].Visible = false;
                    dgvUsuarios.Columns["Correo"].Visible = false;
                    dgvUsuarios.Columns["NroDocumento"].Visible = false;
                    dgvUsuarios.Columns["Pass"].Visible = false;
                    dgvUsuarios.Columns["Apellidos"].Visible = false;
                    dgvUsuarios.Columns["Fechanacimiento"].Visible = false;
                    dgvUsuarios.Columns["Telefono"].Visible = false;
                    dgvUsuarios.Columns["Tipodocumento"].Visible = false;
                    dgvUsuarios.Columns["Fecha_creacion"].Visible = false;
                    dgvUsuarios.Columns["Fecha_modificacion"].Visible = false;
                    dgvUsuarios.Columns["Usuario_creador"].Visible = false;
                    dgvUsuarios.Columns["Usuario_modificador"].Visible = false;
                    dgvUsuarios.Columns["Tipo_persona"].Visible = false;
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnEditarRol_Click(object sender, EventArgs e)
        {
            try
            {
                using (WsSistemaBancario.RolesServiceClient rol = new WsSistemaBancario.RolesServiceClient())
                {
                    RolesModel objectmodelo = new RolesModel();
                    objectmodelo.Id = idRol;
                    objectmodelo.Descripcion = txtRol.Text;
                    objectmodelo.Fecha_modificacion = DateTime.Now;
                    objectmodelo.Usuario_modificador = "";
                    rol.Roles_Editar(objectmodelo, 1);

                    cargarDGV();
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            try
            {
                using (WsSistemaBancario.RolesServiceClient rol = new WsSistemaBancario.RolesServiceClient())
                {
                    rol.Roles_Eliminar(idRol);
                    cargarDGV();
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
        }


        private void dgvRoles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlPrincipal.SendToBack();
            pnlAgregarUsuario.SendToBack();
            pnlSecundario.BringToFront();

            llenarDGVUsuarios();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            pnlPrincipal.SendToBack();
            pnlSecundario.SendToBack();
            pnlAgregarUsuario.BringToFront();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlAgregarUsuario.SendToBack();
            pnlSecundario.BringToFront();
        }


        public static string NombrePersona;

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            using (BuscarPersona frmBuscarPersona = new BuscarPersona())
            {
                frmBuscarPersona.ShowDialog();
                if (frmBuscarPersona.resultado == DialogResult.OK)
                {
                    idPersona = frmBuscarPersona.id;
                    txtNombrePersona.Text = usuarioPersona;
                    NombrePersona = frmBuscarPersona.nombre;
                    txtUsuarioBuscado.Text = NombrePersona;
                }
            }
        }

        public List<PersonaModel> usuariosFiltrados;

        private void btnCancelarBusqueda_Click(object sender, EventArgs e)
        {
            pnlAgregarUsuario.BringToFront();
            pnlPrincipal.SendToBack();
            pnlSecundario.SendToBack();
        }

        private static int idPersona;
        private static string usuarioPersona;
        
        PersonaModel persona = new PersonaModel();

        private void btnAceptarBusqueda_Click(object sender, EventArgs e)
        {
            pnlAgregarUsuario.BringToFront();
            try
            {
                using (WsSistemaBancario.PersonaServiceClient ObtenerPersona = new WsSistemaBancario.PersonaServiceClient())
                {
                    persona = ObtenerPersona.Persona_ObtenerUno(idPersona);
                    txtUsuarioBuscado.Text = persona.Nombres;
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnInsertarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                using (WsSistemaBancario.RolUsuarioServiceClient CrearRolUsuario = new WsSistemaBancario.RolUsuarioServiceClient())
                {
                    RolUsuarioModel rum = new RolUsuarioModel();
                    rum.Id_persona = idPersona;
                    rum.Id_rol = idRol;
                    rum.Activo = chbEstado.Checked;
                    rum.Usuario_creador = "Administrador";

                    CrearRolUsuario.RolUsuario_Crear(rum, 1);
                }
                llenarDGVUsuarios();
                pnlAgregarUsuario.SendToBack();
                pnlSecundario.BringToFront();
            }
            catch (Exception)
            {
            }
        }

        public List<ComponenteModel> componentesRol;

        private void llenarDGVPermisosRol()
        {
            try
            {
                using (WsSistemaBancario.ComponenteServiceClient PermisosPorRol = new WsSistemaBancario.ComponenteServiceClient())
                {
                    componentesRol = PermisosPorRol.Componente_ObtenerComponentesRol(idRol).ToList();
                    dgvPermisosRol.DataSource = componentesRol;
                    dgvPermisosRol.Columns["Descripcion"].Visible = false;
                    dgvPermisosRol.Columns["Codigo"].Visible = false;
                    dgvPermisosRol.Columns["Id_aplicacion"].Visible = false;
                    dgvPermisosRol.Columns["IdPadre"].Visible = false;
                }
            }
            catch (Exception)
            {
            }
        }

        public int idUsuario;
        public int idRolUsuario;
        public string nombreusuario;

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                idRolUsuario = (int)(dgvUsuarios.Rows[e.RowIndex].Cells["Id"].Value);
                idUsuario = Convert.ToInt16(dgvUsuarios.Rows[e.RowIndex].Cells["IdPersona"].Value);
                nombreusuario = dgvUsuarios.Rows[e.RowIndex].Cells["NombreUsuario"].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                EditarEliminar frmeditar = new EditarEliminar();
                frmeditar.Text = "Eliminar";
                frmeditar.cmbRolesEditar.Visible = false;
                frmeditar.txtUsuarioEditar.Text = nombreusuario;
                frmeditar.txtIdUsuario.Text = idUsuario.ToString();
                frmeditar.idRolUsuario.Text = idRolUsuario.ToString();
                frmeditar.btnEliminar.Visible = true;
                frmeditar.Show();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                EditarEliminar frmeditar = new EditarEliminar();
                frmeditar.Text = "Editar";
                frmeditar.txtUsuarioEditar.Text = nombreusuario;
                frmeditar.txtIdUsuario.Text = idUsuario.ToString();
                frmeditar.idRolUsuario.Text = idRolUsuario.ToString();
                frmeditar.btnEditar.Visible = true;
                frmeditar.Show();
            }
        }



        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            pnlSecundario.SendToBack();
            pnlPrincipal.BringToFront();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public List<ComponenteModel> componentes;

        private void llenardgvComponentes()
        {
            try
            {
                using (WsSistemaBancario.ComponenteServiceClient ComponentesParaRol = new WsSistemaBancario.ComponenteServiceClient())
                {
                    componentes = ComponentesParaRol.ObtenerTodosComponentes().ToList();
                    dgvCrearComponentesRol.DataSource = componentes;
                    dgvCrearComponentesRol.Columns["IdPadre"].Visible = false;
                    dgvCrearComponentesRol.Columns["Id_aplicacion"].Visible = false;
                }
            }
            catch (Exception)
            {
            }
        }

        public int idComponente;
        public bool estado;
        List<PermisosUsuarioModel> Componentesrol = new List<PermisosUsuarioModel>();

        private void dgvCrearComponentesRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idRolUsuario = idRol;
            idComponente = (int)(dgvCrearComponentesRol.Rows[e.RowIndex].Cells["Id"].Value);
            estado = (bool)(dgvCrearComponentesRol.Rows[e.RowIndex].Cells["Estado"].Value);

            PermisosUsuarioModel permisos = new PermisosUsuarioModel();
            permisos.Id_rol = idRol;
            permisos.Id_componente = idComponente;
            permisos.Estado = estado;
            
            Componentesrol.Add(permisos);
        }

        private void btnCrearRolAtras_Click(object sender, EventArgs e)
        {
            pnlComponentesParaRol.SendToBack();
            pnlPrincipal.BringToFront();
        }

        private void btnAgregarComponentesRol_Click(object sender, EventArgs e)
        {
            try
            {
                using (WsSistemaBancario.PermisosUsuarioServiceClient ComponentesParaRol = new WsSistemaBancario.PermisosUsuarioServiceClient())
                {
                    foreach (PermisosUsuarioModel c in Componentesrol)
                    {
                        PermisosUsuarioModel pu = new PermisosUsuarioModel();
                        pu.Id_rol = idRol;
                        pu.Id_componente = c.Id_componente;
                        pu.Estado = c.Estado;
                        ComponentesParaRol.PermisosUsuario_Crear(pu,6);
                    }
                }
                componentesRol = null;
            }
            catch (Exception)
            {
            }
        }

        private void btnAgregarPermisosRol_Click(object sender, EventArgs e)
        {
            if (idRol != 0)
            {
                pnlPrincipal.SendToBack();
                pnlComponentesParaRol.BringToFront();
                llenardgvComponentes();
            }
        }

        private void tbpUsuarios_Click(object sender, EventArgs e)
        {
        }
    }
}
