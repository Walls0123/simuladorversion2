using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using CNegocio.Backend;
using System.Windows.Forms;
using Modelos.Modelos;
using Modelos.Session;
using CNegocio.Plataforma;
using System.Text.RegularExpressions;

namespace Sistema_Bancario.plataforma_controles
{
    public partial class RegistroPersonaUserControl : UserControl
    {

        #region Variables

        WsSistemaBancario.PersonaServiceClient BLPersona = new WsSistemaBancario.PersonaServiceClient();
        WsSistemaBancario.TipoDocumentoServiceClient BLTipo_documento = new WsSistemaBancario.TipoDocumentoServiceClient();
        WsSistemaBancario.FechaHoraServerServiceClient BLFechaHoraServer = new WsSistemaBancario.FechaHoraServerServiceClient();
        private PersonaModel gPerona;
        public string gusuario { get; set; }

        #endregion

        #region Constructor

        public RegistroPersonaUserControl(ISession sesion)
        {
            InitializeComponent();
            this.ConfigurarFechaNacimiento();
            this.gusuario = sesion.UserName;

            this.poblarCboTiposDocumento();
            this.poblarCboTipoPersona();
            this.modoInicial();
        }

        #endregion

        #region Metodos

        private void poblarCboTiposDocumento()
        {
            var datos = this.BLTipo_documento.TipoDocumento_ObtenerTodos();
            if (datos == null)
                return;

            this.cboTipo_documento.DataSource = this.BLTipo_documento.TipoDocumento_ObtenerTodos();
            this.cboTipo_documento.ValueMember = "Id_documento";
            this.cboTipo_documento.DisplayMember = "Descripcion";
        }

        private void poblarCboTipoPersona()
        {
            SortedDictionary<string, string> userCache = new SortedDictionary<string, string>
                {
                  {"CLI", "CLIENTE"},
                  {"TRA", "TRABAJADOR"}
                };

            this.cboTipoPersona.DataSource = new BindingSource(userCache, null);
            this.cboTipoPersona.ValueMember = "Key";
            this.cboTipoPersona.DisplayMember = "Value";
        }

        private Boolean Email_correcto(String email)
        {
            String expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            return Regex.IsMatch(email, expresion) ? (Regex.Replace(email, expresion, String.Empty).Length == 0 ? true : false) : false;
        }

        private PersonaModel gui2persona()
        {
            try
            {
                if (!Email_correcto(txtCorreo.Text))
                {
                    MessageBox.Show("El email no es correcto");
                    return null;
                }

                string nombres = this.txtNombres.Text;
                string apellidos = this.txtApellidos.Text;
                DateTime fecha_nacimiento = this.dtpFecha_nacimiento.Value;
                int id_tipo_documento = (int)this.cboTipo_documento.SelectedValue;
                string numero_documento = this.txtNumero_documento.Text;
                string correo_electronico = this.txtCorreo.Text;
                bool estado = this.chkEstado.Checked;
                string rol_persona = (string)this.cboTipoPersona.SelectedValue;
                string telefono = this.txtTelefono.Text;

                return new PersonaModel()
                {
                    Nombres = nombres,
                    Apellidos = apellidos,
                    Tipodocumento = id_tipo_documento,
                    Correo = correo_electronico,
                    Estado = estado,
                    Fechanacimiento = fecha_nacimiento,
                    Nrodocumento = numero_documento,
                    Usuario_creador = this.gusuario,
                    Fecha_creacion = (DateTime)BLFechaHoraServidor.Obtener(),
                    Tipo_persona = rol_persona,
                    Telefono = telefono

                };
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void persona2gui(PersonaModel apersona)
        {
            this.txtCodigo.Text = apersona.Id.ToString();
            this.txtNombres.Text = apersona.Nombres;
            this.txtApellidos.Text = apersona.Apellidos;
            this.txtNumero_documento.Text = apersona.Nrodocumento;
            this.txtCorreo.Text = apersona.Correo;
            this.txtTelefono.Text = apersona.Telefono;
            this.cboTipo_documento.SelectedValue = apersona.Tipodocumento;
            this.dtpFecha_nacimiento.Value = apersona.Fechanacimiento;
            this.cboTipoPersona.SelectedValue = apersona.Tipo_persona;
            this.chkEstado.Checked = apersona.Estado;

            this.SlblUsuario_creador.Text = apersona.Usuario_creador;
            this.SlblFecha_creacion.Text = apersona.Fecha_creacion.ToString();
            this.SlblUsuario_modificador.Text = apersona.Usuario_modificador;
            this.SlblFecha_modificacion.Text = apersona.Fecha_modificacion.ToString();
        }

        private void clearForm()
        {
            gPerona = null;

            this.txtCodigo.Text = default(string);
            this.txtNombres.Text = default(string);
            this.txtApellidos.Text = default(string);
            this.txtNumero_documento.Text = default(string);
            this.txtCorreo.Text = default(string);
            this.txtTelefono.Text = default(string);
            this.cboTipo_documento.SelectedValue = -1;
            this.cboTipoPersona.SelectedValue = -1;
            this.dtpFecha_nacimiento.Value = new DateTime(2000, 01, 01);
            this.chkEstado.Checked = false;

            this.SlblUsuario_creador.Text = "*";
            this.SlblFecha_creacion.Text = "*";
            this.SlblUsuario_modificador.Text = "*";
            this.SlblFecha_modificacion.Text = "*";
        }

        private void modoNuevo()
        {

            this.buttonActualizar.Enabled = false;
            this.buttonEliminar.Enabled = false;

            this.buttonNuevo.Enabled = false;
            this.buttonCrear.Enabled = true;
            this.buttonDeshacer.Enabled = true;

            this.btnCodigo.Enabled = false;
            this.btnNombres.Enabled = false;
            this.btnApellidos.Enabled = false;
            this.btnDocumento.Enabled = false;

            this.txtCodigo.Enabled = false;
            this.txtNombres.Enabled = true;
            this.txtApellidos.Enabled = true;
            this.txtNumero_documento.Enabled = true;
            this.txtCorreo.Enabled = true;
            this.txtTelefono.Enabled = true;
            this.chkEstado.Enabled = true;
            this.cboTipo_documento.Enabled = true;
            this.cboTipo_documento.SelectedIndex = 0;
            this.cboTipoPersona.SelectedIndex = 0;
            this.cboTipoPersona.Enabled = true;
            this.dtpFecha_nacimiento.Enabled = true;

        }

        private void modoInicial()
        {
            this.buttonActualizar.Enabled = false;
            this.buttonEliminar.Enabled = false;

            this.buttonNuevo.Enabled = true;
            this.buttonCrear.Enabled = false;
            this.buttonDeshacer.Enabled = false;

            this.btnCodigo.Enabled = true;
            this.btnNombres.Enabled = true;
            this.btnApellidos.Enabled = true;
            this.btnDocumento.Enabled = true;

            this.txtCodigo.Enabled = true;
            this.txtNombres.Enabled = true;
            this.txtApellidos.Enabled = true;
            this.txtNumero_documento.Enabled = true;
            this.txtCorreo.Enabled = false;
            this.txtTelefono.Enabled = false;
            this.chkEstado.Enabled = false;

            this.cboTipo_documento.Enabled = false;
            this.cboTipoPersona.Enabled = false;
            this.dtpFecha_nacimiento.Enabled = false;
        }

        private void modoEdicion()
        {
            this.buttonCrear.Enabled = false;
            this.buttonActualizar.Enabled = true;
            this.buttonEliminar.Enabled = true;
        }

        private void buscarObjeto(List<PersonaModel> objetos)
        {
            string[][] orden = new string[4][];

            orden[0] = new string[] { "Id", "Codigo", "70" };
            orden[1] = new string[] { "NroDocumento", "Documento", "150" };
            orden[2] = new string[] { "Nombres", "Nombres", "200" };
            orden[3] = new string[] { "Apellidos", "Apellidos", "250" };

            if (objetos != null)
            {
                using (Ayuda.FormHelp2 formHelp1 = new Ayuda.FormHelp2())
                {
                    formHelp1.setList(objetos, orden);
                    formHelp1.ShowDialog();

                    if (formHelp1.EstaAceptado())
                    {
                        var dato = formHelp1.getObject<PersonaModel>();
                        if (dato != null)
                        {
                            this.clearForm();
                            this.gPerona = this.BLPersona.Persona_ObtenerUno(dato.Id);
                            this.persona2gui(this.gPerona);
                            this.modoNuevo();
                            this.modoEdicion();
                        }
                    }
                }
            }
        }

        private void ConfigurarFechaNacimiento()
        {
            DateTime? fechaActual = BLFechaHoraServer.ObtenerFechaHoraActual();
            DateTime fechaMinima = new DateTime(fechaActual.Value.Year - 100, fechaActual.Value.Month, fechaActual.Value.Day);
            DateTime fechaMaxima = new DateTime(fechaActual.Value.Year - 18, fechaActual.Value.Month, fechaActual.Value.Day);
            this.dtpFecha_nacimiento.MinDate = fechaMinima;
            this.dtpFecha_nacimiento.MaxDate = fechaMaxima;
        }

        #endregion

        #region Eventos

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            this.clearForm();
            this.modoNuevo();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            var objeto = this.gui2persona();

            if (objeto == null)
            {
                MessageBox.Show("Algunos datos no coinciden, por favor revísalos");
                return;
            }
            if (BLPersona.Persona_Crear(objeto))
            {
                this.clearForm();
                this.modoInicial();
                MessageBox.Show("La persona fue creada con éxito");
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            var objeto = this.gui2persona();

            if (objeto == null)
            {
                MessageBox.Show("Problemas al instanciar el nuevo objeto, revise las propiedas");
                return;
            }

            objeto.Id = this.gPerona.Id;
            objeto.Usuario_creador = this.gPerona.Usuario_creador;
            objeto.Fecha_creacion = this.gPerona.Fecha_creacion;
            objeto.Usuario_modificador = this.gusuario;
            objeto.Fecha_modificacion = BLFechaHoraServidor.Obtener();

            if (this.BLPersona.Persona_Editar(objeto))
            {
                MessageBox.Show("El proceso ha sido correcto");
                this.clearForm();
                this.modoInicial();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (this.gPerona == null)
            {
                MessageBox.Show("Problemas al obtener el la persona desde la base de datos");
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro que quiere eliminar la persona seleccionada? Este proceso no se puede deshacer", "Advertencia", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (this.BLPersona.Persona_Eliminar(this.gPerona.Id))
                {
                    this.clearForm();
                    this.modoInicial();
                    MessageBox.Show("El proceso ha sido correcto");
                }
                else
                {
                    MessageBox.Show("La persona no puede ser eliminada debido a que tiene cuentas asociadas");
                }
            }
        }

        private void buttonDeshacer_Click(object sender, EventArgs e)
        {

            this.clearForm();
            this.modoInicial();
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            string codigo = this.txtCodigo.Text;

            var objeto = this.BLPersona.PersonaSelectbyId(codigo).ToList();

            if (objeto == null || objeto.Count <= 0)
            {
                MessageBox.Show("No se han encontrado resultados");
                return;
            }
            this.buscarObjeto(objeto);
        }

        private void btnNombres_Click(object sender, EventArgs e)
        {
            string nombres = this.txtNombres.Text;

            var objeto = this.BLPersona.PersonaSelectbyNombres(nombres).ToList();

            if (objeto == null || objeto.Count <= 0)
            {
                MessageBox.Show("No se han encontrado resultados");
                return;
            }
            this.buscarObjeto(objeto);
        }

        private void btnApellidos_Click(object sender, EventArgs e)
        {
            string apellidos = this.txtApellidos.Text;

            var objeto = this.BLPersona.PersonaSelectbyApellidos(apellidos).ToList();

            if (objeto == null || objeto.Count <= 0)
            {
                MessageBox.Show("No se han encontrado resultados");
                return;
            }
            this.buscarObjeto(objeto);

        }

        private void btnDocumento_Click(object sender, EventArgs e)
        {
            string numero_documento = this.txtNumero_documento.Text;

            var objeto = this.BLPersona.PersonaSelectbyNroDocumento(numero_documento).ToList();

            if (objeto == null || objeto.Count <= 0)
            {
                MessageBox.Show("No se han encontrado resultados");
                return;
            }
            this.buscarObjeto(objeto);
        }

        private void TxtMontoPrestamo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtNumero_documento_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        #endregion

        private void cboTipo_documento_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cboTipo_documento.SelectedIndex)
            {
                case 0:
                    this.lblNombre.Text = "Nombres:";
                    this.lblNombre.Location = new Point(61, 102);
                    this.lblApellido.Visible = true;
                    this.lblFechaNac.Visible = true;
                    this.txtApellidos.Visible = true;
                    this.dtpFecha_nacimiento.Visible = true;
                    this.btnApellidos.Visible = true;
                    break;
                case 1:
                    this.lblNombre.Text = "Razón Social:";
                    this.lblNombre.Location=new Point(40, 102);
                    this.lblApellido.Visible = false;
                    this.lblFechaNac.Visible = false;
                    this.btnApellidos.Visible = false;
                    this.txtApellidos.Text = null;
                    this.txtApellidos.Visible = false;
                    this.dtpFecha_nacimiento.Visible = false;
                    //fecha null faltaa

                    break;
            }
        }

        private void txtNumero_documento_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}