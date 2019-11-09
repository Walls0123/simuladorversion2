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
using CNegocio.Plataforma;
using Modelos.Session;
using System.Globalization;

namespace Sistema_Bancario.plataforma_controles
{
    public partial class NuevoPrestamoUserControl : UserControl
    {

        #region Variables

        private CuentasModel gCuenta;
        private string gUsuario;
        private PrestamosModel gPrestamo;
        private string modo;

        WsSistemaBancario.PrestamoServiceClient BLPrestamo = new WsSistemaBancario.PrestamoServiceClient();
        WsSistemaBancario.CuentaServiceClient BLCuenta = new WsSistemaBancario.CuentaServiceClient();
        WsSistemaBancario.TipoMonedaServiceClient BLTipoMoneda = new WsSistemaBancario.TipoMonedaServiceClient();
        WsSistemaBancario.PersonaServiceClient BLPersona = new WsSistemaBancario.PersonaServiceClient();

        #endregion

        #region Constructor

        public NuevoPrestamoUserControl(ISession session)
        {
            InitializeComponent();
            
            this.gUsuario = session.UserName;

            this.poblarCboMonedas();

            this.clearForm();
            this.modoInicial();
        }

        #endregion

        #region Metodos

        private void ConfigurarParametros()
        {
            //Por razones del simulador, la fecha del prestamo es variable, en un entorno real no deberia ser así

            this.nudPlazoMeses.Minimum = 1;
            this.nudPlazoMeses.Maximum = 60;
            this.nudPorcentajeInteres.Minimum = 0;
            this.nudPorcentajeInteres.Maximum = 80;

            this.nudDiaPago.Minimum = 1;
            this.nudDiaPago.Maximum = 31;
        }

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

        private PrestamosModel gui2prestamo()
        {
            try
            {
                var objcuenta = this.BLCuenta.Cuenta_ObtenerUno(this.gCuenta.Nrocuenta);
                
                DateTime fechaPrestamo = this.dtpFechaPrestamo.Value;
                decimal montoPrestamo = Convert.ToDecimal(this.txtMontoPrestamo.Text);
                int moneda = (int)this.cboMoneda.SelectedValue;
                int plazoMeses = Convert.ToInt32(this.nudPlazoMeses.Value);
                decimal porcentaje_Interes = Convert.ToInt32(this.nudPorcentajeInteres.Value);
                bool seguro = this.chkEstado.Checked;
                string cuenta = objcuenta.Nrocuenta;
                decimal? interes_Moratorio = Convert.ToDecimal(this.txtMontoMora.Text);
                int? DiaPago = Convert.ToInt32(this.nudDiaPago.Value);
                string USUARIO_CREADOR = this.gUsuario;
                DateTime FECHA_CREACION = (DateTime)BLFechaHoraServidor.Obtener();

                if (montoPrestamo < 100 || montoPrestamo > 400000)
                {
                    MessageBox.Show("Montos incorrectos, ingrese un monto entre 100 y 400 000");
                    return null;
                }

                return new PrestamosModel()
                {
                    Fechaprestamo = fechaPrestamo,
                    Montoprestamo = montoPrestamo,
                    Moneda = moneda,
                    Plazomeses = plazoMeses,
                    Porcentaje_interes = porcentaje_Interes,
                    Seguro = seguro,
                    Cuenta = cuenta,
                    Interes_moratorio = interes_Moratorio,
                    Usuario_creador = USUARIO_CREADOR,
                    Fecha_creacion = FECHA_CREACION,
                    Diapago = DiaPago,
                };
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void prestamo2gui(PrestamosModel aprestamo)
        {
            this.txtCodigo.Text = aprestamo.Id.ToString();
            this.txtCuenta.Text = aprestamo.Cuenta;
            this.txtMontoPrestamo.Text = aprestamo.Montoprestamo.ToString();
            this.txtMontoMora.Text = aprestamo.Interes_moratorio.ToString();
            this.dtpFechaPrestamo.Value = aprestamo.Fechaprestamo;
            this.cboMoneda.SelectedValue = aprestamo.Moneda;
            this.nudPlazoMeses.Value = aprestamo.Plazomeses;
            this.nudPorcentajeInteres.Value = aprestamo.Porcentaje_interes;
            this.nudDiaPago.Value = (decimal)aprestamo.Diapago;
            this.chkEstado.Checked = aprestamo.Seguro;
        }

        private void cuenta2gui(CuentasModel acuenta)
        {
            this.txtCuenta.Text = acuenta.Nrocuenta.ToUpper();
            this.cboMoneda.SelectedIndex = acuenta.Tipomoneda;
            this.cboMoneda.Enabled = false;
        }

        private void clearForm()
        {
            this.txtCodigo.Text = default(string);
            this.txtCuenta.Text = default(string);
            this.txtMontoPrestamo.Text = default(string);
            this.txtMontoMora.Text = default(string);
            this.dtpFechaPrestamo.Value = DateTime.Now;
            this.cboMoneda.SelectedValue = -1;
            this.nudPlazoMeses.Value = 1m;
            this.nudPorcentajeInteres.Value = 0m;
            this.nudDiaPago.Value = 1m;
            this.chkEstado.Checked = false;
            this.clearPersona();

            this.SlblUsuario_creador.Text = "*";
            this.SlblFecha_creacion.Text = "*";
            this.SlblUsuario_modificador.Text = "*";
            this.SlblFecha_modificacion.Text = "*";
        }

        private void clearPersona()
        {
            this.txtNombres.Text = default(string);
            this.txtApellidos.Text = default(string);
            this.txtNumero_documento.Text = default(string);
            this.cboTipo_documento.SelectedValue = -1;
        }

        private void modoNuevo()
        {
            this.modo = "modoNuevo";
            this.groupBox1.Enabled = false;
            this.buttonActualizar.Enabled = false;
            this.buttonEliminar.Enabled = false;
            this.buttonEditar.Visible = false;

            this.buttonNuevo.Enabled = false;
            this.buttonCrear.Enabled = true;
            this.buttonDeshacer.Enabled = true;

            this.btnCodigo.Enabled = false;
            this.btnCuenta.Enabled = true;

            this.txtCodigo.Enabled = false;
            this.txtCuenta.Enabled = true;
            this.txtMontoPrestamo.Enabled = true;
            this.txtMontoMora.Enabled = true;
            this.dtpFechaPrestamo.Enabled = true;
            this.cboMoneda.Enabled = true;
            this.nudPlazoMeses.Enabled = true;
            this.nudPorcentajeInteres.Enabled = true;
            this.nudDiaPago.Enabled = true;
            this.chkEstado.Enabled = true;
        }

        private void modoInicial()
        {
            this.modo = "modoInicial";

            this.buttonActualizar.Enabled = false;
            this.buttonEliminar.Enabled = false;
            this.buttonEditar.Visible = false;

            this.buttonNuevo.Enabled = true;
            this.buttonCrear.Enabled = false;
            this.buttonDeshacer.Enabled = false;

            this.btnCodigo.Enabled = true;
            this.btnCuenta.Enabled = true;

            this.groupBox1.Enabled = true;
            this.txtCodigo.Enabled = true;
            this.txtCuenta.Enabled = true;
            this.cboMoneda.Enabled = false;
            this.dtpFechaPrestamo.Enabled = false;
            this.txtMontoPrestamo.Enabled = false;
            this.txtMontoMora.Enabled = false;
            this.nudPlazoMeses.Enabled = false;
            this.nudPorcentajeInteres.Enabled = false;
            this.nudDiaPago.Enabled = false;
            this.chkEstado.Enabled = false;
        }

        private void modoEdicion()
        {
            this.modo = "modoEdicion";

            this.buttonCrear.Enabled = false;
            this.buttonActualizar.Enabled = false;
            this.buttonEliminar.Enabled = true;
            this.buttonEditar.Visible = true;

            this.cboMoneda.Enabled = false;
            this.txtCuenta.Enabled = false;
            this.btnCuenta.Enabled = false;

            this.dtpFechaPrestamo.Enabled = false;
            this.txtMontoPrestamo.Enabled = false;
            this.txtMontoMora.Enabled = false;
            this.nudPlazoMeses.Enabled = false;
            this.nudPorcentajeInteres.Enabled = false;
            this.nudDiaPago.Enabled = false;
            this.chkEstado.Enabled = false;
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
                        CuentasModel dato = formHelp1.getObject<CuentasModel>();
                        if (dato != null)
                        {
                            this.clearForm();
                            this.gCuenta = this.BLCuenta.Cuenta_ObtenerUno(dato.Nrocuenta);

                            if (this.modo == "modoInicial")
                            {
                                if (this.gCuenta == null)
                                    return;

                                List<PrestamosModel> Prestamos = this.BLPrestamo.Prestamo_SelecionarPorCuenta(this.gCuenta.Nrocuenta).ToList();
                                if (Prestamos == null || Prestamos.Count == 0)
                                {
                                    MessageBox.Show("No tiene prestamos asociados a esta cuenta");
                                    return;
                                }
                                this.buscarPrestamo(Prestamos);
                            }
                            else
                            {
                                if (gCuenta.Estado == true)
                                {
                                    this.clearForm();
                                    this.cuenta2gui(this.gCuenta);
                                }
                                else
                                {
                                    MessageBox.Show("No puede usar una cuenta inactiva para esta transacción");
                                }
                            }

                        }
                    }
                }
            }
        }

        private void buscarPrestamo(List<PrestamosModel> objetos)
        {
            string[][] orden = new string[6][];

            orden[0] = new string[] { "Id", "Codigo", "60" };
            orden[1] = new string[] { "Cuenta", "Cuenta", "180" };
            orden[2] = new string[] { "Fechaprestamo", "Fecha de Prestamo", "150" };
            orden[3] = new string[] { "Montoprestamo", "Monto", "100" };
            orden[4] = new string[] { "Plazomeses", "Meses", "80" };
            orden[5] = new string[] { "Usuario_creador", "Aprobado por", "100" };

            if (objetos != null)
            {
                using (Ayuda.FormHelp2 formHelp1 = new Ayuda.FormHelp2())
                {
                    formHelp1.setList(objetos, orden);
                    formHelp1.ShowDialog();

                    if (formHelp1.EstaAceptado())
                    {
                        var dato = formHelp1.getObject<PrestamosModel>();
                        if (dato != null)
                        {
                            this.clearForm();
                            this.gPrestamo = this.BLPrestamo.Prestamo_ObtenerUno(dato.Id);
                            this.gCuenta = this.BLCuenta.Cuenta_ObtenerUno(dato.Cuenta);
                            this.prestamo2gui(this.gPrestamo);
                            this.modoNuevo();
                            this.modoEdicion();
                        }
                    }
                }
            }
        }

        private void buscarObjeto(List<PersonaModel> objetos)
        {
            string[][] orden = new string[3][];

            orden[0] = new string[] { "Id", "Codigo", "100" };
            orden[1] = new string[] { "Nombres", "Nombres", "200" };
            orden[2] = new string[] { "Apellidos", "Apellidos", "200" };

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
                            this.persona2gui(dato);

                            var cuentas_anexadas = this.BLCuenta.cuentaSelectbyId_cliente(dato.Id).ToList();
                            this.buscarCuenta(cuentas_anexadas);
                        }
                    }
                }
            }
        }

        private void persona2gui(PersonaModel apersona)
        {
            this.txtNombres.Text = apersona.Nombres;
            this.txtApellidos.Text = apersona.Apellidos;
            this.txtNumero_documento.Text = apersona.Nrodocumento;
            this.cboTipo_documento.SelectedValue = apersona.Tipodocumento;
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
            var objeto = this.gui2prestamo();

            if (objeto == null)
            {
                MessageBox.Show("Problemas al instanciar el nuevo objeto, revise las propiedas");
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea realizar un préstamo? Esta operacion no se puede deshacer facilmente", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (this.BLPrestamo.Prestamo_Crear(objeto))
                {
                    this.clearForm();
                    this.modoInicial();
                    MessageBox.Show("Se ha realizado el préstamo correctamente, el monto fue depositado en la cuenta asignada");
                }
            }
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            string cuenta = this.txtCuenta.Text;

            var objeto = this.BLCuenta.Cuenta_SeleccionarPorNumeroPrestamo(cuenta).ToList();

            if (objeto == null || objeto.Count <= 0)
            {
                MessageBox.Show("No se han encontrado resultados");
                return;
            }
            this.buscarCuenta(objeto);
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            var objeto = this.gui2prestamo();

            if (objeto == null)
            {
                MessageBox.Show("Problemas al extraer desde la base de datos");
                return;
            }

            objeto.Id = this.gPrestamo.Id;
            objeto.Usuario_creador = this.gPrestamo.Usuario_creador;
            objeto.Fecha_creacion = this.gPrestamo.Fecha_creacion;
            objeto.Usuario_modificador = this.gUsuario;
            objeto.Fecha_modificacion = BLFechaHoraServidor.Obtener();

            if (MessageBox.Show("Se va a proceder a refinanciar la deuda, Esto no se puede revertir, ¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (this.BLPrestamo.Prestamo_Editar(objeto))
                {
                    MessageBox.Show("La deuda ha sido refinanciada correctamente");
                    this.clearForm();
                    this.modoInicial();
                }
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta a punto de refinanciar una deuda, ¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.buttonEditar.Visible = false;
                this.buttonActualizar.Enabled = true;
                this.buttonEliminar.Enabled = false;

                this.buttonNuevo.Enabled = false;
                this.buttonCrear.Enabled = false;
                this.buttonDeshacer.Enabled = true;

                this.btnCodigo.Enabled = false;
                this.btnCuenta.Enabled = false;

                this.txtCodigo.Enabled = false;
                this.txtCuenta.Enabled = false;
                this.cboMoneda.Enabled = false;
                this.dtpFechaPrestamo.Enabled = true;
                this.txtMontoPrestamo.Enabled = true;
                this.txtMontoMora.Enabled = true;
                this.nudPlazoMeses.Enabled = true;
                this.nudPorcentajeInteres.Enabled = true;
                this.nudDiaPago.Enabled = true;
                this.chkEstado.Enabled = true;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (this.gPrestamo == null)
            {
                MessageBox.Show("Problemas al extraer desde la base de datos");
                return;
            }
            if (MessageBox.Show("¿Está que quiere eliminar el préstamo? Este proceso no podrá ser revertido", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (this.BLPrestamo.Prestamo_Borrar(this.gPrestamo.Id))
                {
                    this.clearForm();
                    this.modoInicial();
                    MessageBox.Show("Se ha eliminado correctamente");
                }
            }
            else
            {
                MessageBox.Show("No se pudo eliminar debido a que tiene cronogramas asociados");
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

            var objeto = this.BLPrestamo.Prestamo_SeleccionarPorId(codigo).ToList();

            if (objeto == null || objeto.Count <= 0)
            {
                MessageBox.Show("No se han encontrado resultados");
                return;
            }
            this.buscarPrestamo(objeto);
        }

        private void TxtMontoMora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') e.Handled = true;
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1) e.Handled = true;
        }

        private void TxtMontoPrestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') e.Handled = true;
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1) e.Handled = true;
        }

        private void NudDiaPago_ValueChanged(object sender, System.EventArgs e)
        {
            int numero = (int)nudDiaPago.Value;
            if(numero < 1)
            {
                nudDiaPago.Value = 1;
            }
            else if (numero > 31)
            {
                nudDiaPago.Value = 31;
            }
        }

        private void NudPorcentajeInteres_ValueChanged(object sender, System.EventArgs e)
        {
            decimal numero = nudPorcentajeInteres.Value;
            if (numero < 0)
            {
                nudPorcentajeInteres.Value = 0;
            }
            else if (numero > 80)
            {
                nudPorcentajeInteres.Value = 80;
            }
        }

        private void NudPlazoMeses_ValueChanged(object sender, System.EventArgs e)
        {
            int numero = (int)nudPlazoMeses.Value;
            if (numero < 1)
            {
                nudPlazoMeses.Value = 1;
            }
            else if (numero > 60)
            {
                nudPlazoMeses.Value = 60;
            }
        }

        private void btnNombres_Click(object sender, EventArgs e)
        {
            string nombres = this.txtNombres.Text;

            var objeto = this.BLPersona.PersonaSelectbyNombres(nombres).ToList();

            if (objeto == null && objeto.Count <= 0) { return; }
            this.buscarObjeto(objeto);
        }

        private void btnApellidos_Click(object sender, EventArgs e)
        {
            string apellidos = this.txtApellidos.Text;

            var objeto = this.BLPersona.PersonaSelectbyApellidos(apellidos).ToList();

            if (objeto == null && objeto.Count <= 0) { return; }
            this.buscarObjeto(objeto);
        }

        private void btnDocumento_Click(object sender, EventArgs e)
        {
            string numero_documento = this.txtNumero_documento.Text;

            var objeto = this.BLPersona.PersonaSelectbyNroDocumento(numero_documento).ToList();

            if (objeto == null && objeto.Count <= 0) { return; }
            this.buscarObjeto(objeto);
        }

        #endregion

    }
}
