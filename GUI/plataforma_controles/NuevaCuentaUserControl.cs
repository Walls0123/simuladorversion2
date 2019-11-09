using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocio.Plataforma;
using Modelos.Modelos;
using CNegocio.Backend;
using Modelos.Session;

namespace Sistema_Bancario.plataforma_controles
{
    public partial class NuevaCuentaUserControl : UserControl
    {

        #region Variables

        WsSistemaBancario.CuentaServiceClient BLCuenta = new WsSistemaBancario.CuentaServiceClient();
        WsSistemaBancario.TipoMonedaServiceClient BLTipoMoneda = new WsSistemaBancario.TipoMonedaServiceClient();
        WsSistemaBancario.PersonaServiceClient BLPersona = new WsSistemaBancario.PersonaServiceClient();
        WsSistemaBancario.TipoDocumentoServiceClient BLTipo_documento = new WsSistemaBancario.TipoDocumentoServiceClient();
        WsSistemaBancario.FechaHoraServerServiceClient BLFechaHoraServer = new WsSistemaBancario.FechaHoraServerServiceClient();

        private string gUsuario;
        private string gSucursal;
        private PersonaModel gPersona;
        private CuentasModel gCuenta;
        private string modo = "";

        #endregion

        #region Constructor

        public NuevaCuentaUserControl(ISession isesion)
        {
            InitializeComponent();

            this.gUsuario = isesion.UserName;
            this.gSucursal = isesion.SucursalCodigo;

            this.poblarCboMonedas();
            this.poblarCboTipoCuenta();
            this.poblarCboTiposDocumento();

            this.clearForm();
            this.modoInicial();
        }

        #endregion

        #region Metodos

        private void poblarCboMonedas()
        {
            var objetos = this.BLTipoMoneda.Moneda_ObtenerTodos();

            if (objetos == null)
            {
                return;
            }

            this.cboMoneda.DataSource = objetos;
            this.cboMoneda.DisplayMember = "Nombre";
            this.cboMoneda.ValueMember = "Id";
        }

        private void poblarCboTipoCuenta()
        {
            SortedDictionary<string, string> userCache = new SortedDictionary<string, string>
                {
                  {"CORRIENTE", "CORRIENTE"},
                  {"CREDITO", "CREDITO"},
                  {"AHORROS", "AHORROS"}
                };

            this.cboTipoCuenta.DataSource = new BindingSource(userCache, null);
            this.cboTipoCuenta.ValueMember = "Key";
            this.cboTipoCuenta.DisplayMember = "Value";
        }

        private void poblarCboTiposDocumento()
        {
            var datos = this.BLTipo_documento.TipoDocumento_ObtenerTodos();
            if (datos == null)
                return;

            this.cboTipo_documento.DataSource = this.BLTipo_documento.TipoDocumento_ObtenerTodos();
            this.cboTipo_documento.ValueMember = "Id_documento";
            this.cboTipo_documento.DisplayMember = "Descripcion";
        }

        private void buscarPersona(List<PersonaModel> objetos)
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
                        PersonaModel dato = formHelp1.getObject<PersonaModel>();
                        if (dato != null)
                        {
                            this.gPersona = this.BLPersona.Persona_ObtenerUno(dato.Id);

                            if (this.modo == "modoInicial")
                            {
                                if (gPersona == null)
                                    return;

                                List<CuentasModel> Cuentas = this.BLCuenta.Cuenta_ObtenerTodos(this.gPersona.Id).ToList();
                                if (Cuentas == null || Cuentas.Count == 0)
                                {
                                    MessageBox.Show("La persona no tiene cuentas");
                                    return;
                                }
                                this.buscarCuenta(Cuentas);
                            }
                            else
                            {
                                this.clearForm();
                                this.persona2gui(this.gPersona);
                            }
                        }
                    }
                }
            }
        }

        private void buscarCuenta(List<CuentasModel> objetos)
        {
            string[][] orden = new string[7][];

            orden[0] = new string[] { "NroCuenta", "Numero Cuenta", "130" };
            orden[1] = new string[] { "TipoCuenta", "Tipo Cuenta", "100" };
            orden[2] = new string[] { "SaldoContable", "Saldo Contable", "100" };
            orden[3] = new string[] { "SaldoDisponible", "Saldo Disponible", "80" };
            orden[4] = new string[] { "FECHA_CREACION", "Creado", "120" };
            orden[5] = new string[] { "FECHA_MODIFICACION", "Modificado", "120" };
            orden[6] = new string[] { "Estado", "Activo", "60" };

            if (objetos != null)
            {
                using (Ayuda.FormHelp2 formHelp1 = new Ayuda.FormHelp2())
                {
                    formHelp1.setList(objetos, orden);
                    formHelp1.ShowDialog();

                    if (formHelp1.EstaAceptado())
                    {
                        var dato = formHelp1.getObject<CuentasModel>();
                        if (dato != null)
                        {
                            this.clearForm();
                            this.gCuenta = this.BLCuenta.Cuenta_ObtenerUno(dato.Nrocuenta);
                            this.cuenta2gui(this.gCuenta);
                            this.modoNuevo();
                            this.modoEdicion();
                        }
                    }
                }
            }
        }

        private void persona2gui(PersonaModel apersona)
        {
            this.txtNombres.Text = apersona.Nombres;
            this.txtNumero_documento.Text = apersona.Nrodocumento;
            this.cboTipo_documento.SelectedValue = apersona.Tipodocumento;
            this.cboTipo_documento.Enabled = false;
        }

        private void cuenta2gui(CuentasModel acuenta)
        {
            if (this.gCuenta == null)
                return;

            var persona = this.BLPersona.Persona_ObtenerUno(this.gCuenta.Cliente);
            if (persona == null)
                return;

            this.persona2gui(persona);

            this.txtCodigo.Text = acuenta.Nrocuenta;
            this.cboMoneda.SelectedValue = acuenta.Tipomoneda;
            this.cboTipoCuenta.SelectedValue = acuenta.Tipocuenta;
            this.chkEstado.Checked = acuenta.Estado;

            this.SlblUsuario_creador.Text = acuenta.Usuario_creador;
            this.SlblFecha_creacion.Text = acuenta.Fecha_creacion.ToString();
            this.SlblUsuario_modificador.Text = acuenta.Usuario_modificador;
            this.SlblFecha_modificacion.Text = acuenta.Fecha_modificacion.ToString();
        }

        private CuentasModel gui2cuenta()
        {
            try
            {
                string NroCuenta = this.gSucursal;
                bool Estado = chkEstado.Checked;
                decimal SaldoContable = 0m;
                decimal SaldoDisponible = 0m;
                decimal SobreGiro = 0m;
                int ConteoChequesRebote1 = 0;
                int ConteoChequesRebote2 = 0;
                string TipoCuenta = (string)this.cboTipoCuenta.SelectedValue;
                int TipoMoneda = (int)this.cboMoneda.SelectedValue;
                string USUARIO_CREADOR = this.gUsuario;
                int Cliente = this.gPersona.Id;
                DateTime FECHA_CREACION = (DateTime)BLFechaHoraServer.ObtenerFechaHoraActual();

                return new CuentasModel()
                {
                    Nrocuenta = NroCuenta,
                    Estado = Estado,
                    Saldocontable = SaldoContable,
                    Saldodisponible = SaldoDisponible,
                    Sobregiro = SobreGiro,
                    Contchequerebote1 = ConteoChequesRebote1,
                    Contchequerebote2 = ConteoChequesRebote2,
                    Tipocuenta = TipoCuenta,
                    Tipomoneda = TipoMoneda,
                    Usuario_creador = USUARIO_CREADOR,
                    Cliente = Cliente,
                    Fecha_creacion = FECHA_CREACION
                };
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void clearForm()
        {
            this.txtCodigo.Text = default(string);
            this.txtNombres.Text = default(string);
            this.txtNumero_documento.Text = default(string);
            this.cboTipo_documento.SelectedValue = -1;
            this.cboMoneda.SelectedValue = -1;
            this.cboTipoCuenta.SelectedValue = -1;
            this.chkEstado.Checked = false;

            this.SlblUsuario_creador.Text = "*";
            this.SlblFecha_creacion.Text = "*";
            this.SlblUsuario_modificador.Text = "*";
            this.SlblFecha_modificacion.Text = "*";
        }

        private void modoNuevo()
        {
            this.modo = "modoNuevo";

            this.buttonActualizar.Enabled = false;
            this.buttonEliminar.Enabled = false;

            this.buttonNuevo.Enabled = false;
            this.buttonCrear.Enabled = true;
            this.buttonDeshacer.Enabled = true;

            this.btnCodigo.Enabled = false;
            this.btnNombres.Enabled = true;
            this.btnDocumento.Enabled = true;

            this.txtCodigo.Enabled = false;
            this.txtNombres.Enabled = true;
            this.txtNumero_documento.Enabled = true;
            this.chkEstado.Enabled = true;
            this.cboTipo_documento.Enabled = true;
            this.cboTipoCuenta.SelectedIndex = 0;
            this.cboMoneda.SelectedIndex = 0;
            this.cboMoneda.Enabled = true;
            this.cboTipoCuenta.Enabled = true;
        }

        private void modoInicial()
        {
            this.modo = "modoInicial";

            this.buttonActualizar.Enabled = false;
            this.buttonEliminar.Enabled = false;

            this.buttonNuevo.Enabled = true;
            this.buttonCrear.Enabled = false;
            this.buttonDeshacer.Enabled = false;

            this.btnCodigo.Enabled = true;
            this.btnNombres.Enabled = true;
            this.btnDocumento.Enabled = true;

            this.txtCodigo.Enabled = true;
            this.txtNombres.Enabled = true;
            this.txtNumero_documento.Enabled = true;

            this.chkEstado.Enabled = false;
            this.chkEstado.Checked = false;

            this.cboTipo_documento.Enabled = false;
            this.cboTipoCuenta.Enabled = false;
            this.cboTipo_documento.Enabled = false;
            this.cboMoneda.Enabled = false;
        }

        private void modoEdicion()
        {
            this.buttonCrear.Enabled = false;
            this.buttonActualizar.Enabled = true;
            this.buttonEliminar.Enabled = true;

            this.cboTipo_documento.Enabled = false;
            this.btnNombres.Enabled = false;
            this.btnDocumento.Enabled = false;
            this.cboMoneda.Enabled = false;
            this.cboTipoCuenta.Enabled = false;
        }

        #endregion

        #region Eventos

        private void btnNombres_Click(object sender, EventArgs e)
        {
            string nombres = this.txtNombres.Text;

            var objeto = this.BLPersona.PersonaSelectbyNombres(nombres).ToList();

            if (objeto == null || objeto.Count <= 0)
            {
                MessageBox.Show("No se han encontrado resultados");
                return;
            }
            this.buscarPersona(objeto);
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
            this.buscarPersona(objeto);
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            this.clearForm();
            this.modoNuevo();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            var objeto = this.gui2cuenta();

            if (objeto == null)
            {
                MessageBox.Show("Se detectan incoherencias, por favor revisarlas");
                return;
            }
            if (objeto.Estado == false)
            {
                DialogResult result = MessageBox.Show("Está a punto de crear una cuenta inactiva, ¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) return;
            }
            if (this.BLCuenta.Cuenta_Crear(objeto))
            {
                this.clearForm();
                this.modoInicial();
                MessageBox.Show("La cuenta fue creada exitosamente");
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            var objeto = this.gui2cuenta();

            if (objeto == null)
            {
                MessageBox.Show("Problemas al instanciar el nuevo objeto, revise las propiedas");
                return;
            }

            objeto.Nrocuenta = this.gCuenta.Nrocuenta;
            objeto.Usuario_creador = this.gPersona.Usuario_creador;
            objeto.Fecha_creacion = this.gPersona.Fecha_creacion;
            objeto.Usuario_modificador = this.gUsuario;
            objeto.Fecha_modificacion = BLFechaHoraServer.ObtenerFechaHoraActual();

            if (objeto.Estado == false)
            {
                DialogResult result = MessageBox.Show("La cuenta está en estado inactivo, ¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) return;
            }
            if (this.BLCuenta.Cuenta_Editar(objeto))
            {
                MessageBox.Show("El proceso ha sido correcto");
                this.clearForm();
                this.modoInicial();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (this.gCuenta == null)
            {
                MessageBox.Show("Problemas al obtener el objeto de base de datos");
                return;
            }

            DialogResult result = MessageBox.Show("¿Estás seguro que quieres eliminar esta cuenta? Este proceso no se puede revertir", "Advertencia", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            if (this.BLCuenta.Cuenta_Borrar(this.gCuenta.Nrocuenta))
            {
                this.clearForm();
                this.modoInicial();
                MessageBox.Show("El proceso ha sido correcto");
            }
            else
            {
                MessageBox.Show("La cuenta está siendo usada, elimine las referencias y vuelva a intentarlo");
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

            List<CuentasModel> objeto = this.BLCuenta.Cuenta_SeleccionarPorNumero(codigo).ToList();

            if (objeto == null || objeto.Count <= 0)
            {
                MessageBox.Show("No se han encontrado resultados");
                return;
            }
            this.buscarCuenta(objeto);
        }

        private void NuevaCuentaUserControl_Load(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
