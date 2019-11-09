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
using Modelos.Session;

namespace Sistema_Bancario.plataforma_controles
{
    public partial class RegistrarChequera : UserControl
    {

        private BLCuenta BLCuenta = new BLCuenta();
        private BLChequeras BLChequeras = new BLChequeras();


        private string modo;
        private CuentasModel gCuenta;
        private ChequerasModel gChequera;
        private string gUsuario;


        public RegistrarChequera(ISession sesion)
        {
            InitializeComponent();

            this.gUsuario = sesion.UserName;
            this.poblarCboTipoCuenta();
            this.poblarCboEstado();


            this.clearForm();
            this.modoInicial();
        }

        private void cuenta2gui(CuentasModel acuenta)
        {
            this.txtCuenta.Text = acuenta.Nrocuenta.ToUpper();
        }

        private ChequerasModel gui2chequera()
        {
            try
            {
                return new ChequerasModel()
                {
                    Id_cuenta = this.gCuenta.Nrocuenta,
                    Fecharegistro = this.dtpFechaRegistro.Value,
                    Cantidad_cheques = (int)this.cboCantidadCheques.SelectedValue,
                    Estado = (string)this.cboEstado.SelectedValue,
                    Inicio = (int)this.nudChequeInicial.Value,
                    Usuario_creador = this.gUsuario,
                    Fecha_creacion = (DateTime)BLFechaHoraServidor.Obtener(),

                };
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void chequera2gui(ChequerasModel achequera)
        {
            this.gCuenta = this.BLCuenta.Getcuenta(achequera.Id_cuenta);
            if (gCuenta == null)
                return;

            this.txtCodigo.Text = achequera.Numero.ToString();
            this.txtCuenta.Text = this.gCuenta.Nrocuenta.ToString();
            this.dtpFechaRegistro.Value = (DateTime)achequera.Fecharegistro;
            this.cboCantidadCheques.SelectedValue = achequera.Cantidad_cheques;
            this.nudChequeInicial.Value = achequera.Inicio;
            this.cboEstado.SelectedValue = achequera.Estado;

            this.SlblUsuario_creador.Text = achequera.Usuario_creador;
            this.SlblFecha_creacion.Text = achequera.Fecha_creacion.ToLongDateString();
            this.SlblUsuario_modificador.Text = achequera.Usuario_modificador;
            this.SlblFecha_modificacion.Text = achequera.Fecha_modificacion.ToString();
        }

        private void poblarCboTipoCuenta()
        {
            SortedDictionary<int, string> userCache = new SortedDictionary<int, string>
                {
                  {50, "050 CHEQUES"},
                  {100, "100 CHUEQUES"},
                  {150, "150 CHEQUES"}
                };

            this.cboCantidadCheques.DataSource = new BindingSource(userCache, null);
            this.cboCantidadCheques.ValueMember = "Key";
            this.cboCantidadCheques.DisplayMember = "Value";
        }

        private void poblarCboEstado()
        {
            SortedDictionary<string, string> userCache = new SortedDictionary<string, string>
                {

                  {"EMITIDA", "EMITIDA"},
                  {"EN ESPERA", "EN ESPERA"},
                  {"SOLICITADA", "SOLICITADA"},
                };

            this.cboEstado.DataSource = new BindingSource(userCache, null);
            this.cboEstado.ValueMember = "Key";
            this.cboEstado.DisplayMember = "Value";
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            string cuenta = this.txtCuenta.Text;

            var objeto = this.BLCuenta.cuentaSelectbyNroCuenta(cuenta).Where(x => x.Tipocuenta == "CORRIENTE").ToList();

            if (objeto == null && objeto.Count <= 0) { return; }
            this.buscarCuenta(objeto);
        }

        private void buscarCuenta(List<CuentasModel> objetos)
        {
            string[][] orden = new string[4][];

            orden[0] = new string[] { "NroCuenta", "Numero Cuenta", "150" };
            orden[1] = new string[] { "TipoCuenta", "Tipo Cuenta", "100" };
            orden[2] = new string[] { "SaldoContable", "Saldo Contable", "90" };
            orden[3] = new string[] { "SaldoDisponible", "Saldo Disponible", "90" };

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

                            this.gCuenta = BLCuenta.Getcuenta(dato.Nrocuenta);

                            if (gCuenta == null)
                                return;
                            this.cuenta2gui(gCuenta);


                        }
                    }
                }
            }
        }

        private void clearForm()
        {
            this.txtCodigo.Text = default(string);
            this.txtCuenta.Text = default(string);
            this.dtpFechaRegistro.Value = DateTime.Now;
            this.cboCantidadCheques.SelectedValue = -1;
            this.cboEstado.SelectedValue = -1;
            this.nudChequeInicial.Value = 0m;

            this.SlblUsuario_creador.Text = "*";
            this.SlblFecha_creacion.Text = "*";
            this.SlblUsuario_modificador.Text = "*";
            this.SlblFecha_modificacion.Text = "*";
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
            this.btnCuenta.Enabled = false;

            this.txtCodigo.Enabled = true;
            this.txtCuenta.Enabled = false;
            this.dtpFechaRegistro.Enabled = false;
            this.cboEstado.Enabled = false;
            this.cboCantidadCheques.Enabled = false;
            this.nudChequeInicial.Enabled = false;
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
            this.btnCuenta.Enabled = true;

            this.txtCodigo.Enabled = false;
            this.txtCuenta.Enabled = true;
            this.dtpFechaRegistro.Enabled = true;
            this.cboEstado.Enabled = true;
            this.cboCantidadCheques.Enabled = true;
            this.nudChequeInicial.Enabled = true;
        }


        private void modoEdicion()
        {
            this.buttonCrear.Enabled = false;
            this.buttonActualizar.Enabled = true;
            this.buttonEliminar.Enabled = true;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            this.clearForm();
            this.modoNuevo();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            var objeto = this.gui2chequera();

            if (objeto == null)
            {
                MessageBox.Show("Problemas al instanciar el nuevo objeto, revise las propiedas");
                return;
            }
            if (this.BLChequeras.Insert(objeto))
            {
                this.clearForm();
                this.modoInicial();
                MessageBox.Show("El proceso ha sido correcto");
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            var objeto = this.gui2chequera();

            if (objeto == null)
            {
                MessageBox.Show("Problemas al instanciar el nuevo objeto, revise las propiedas");
                return;
            }

            objeto.Numero = this.gChequera.Numero;
            objeto.Cantidad_cheques = this.gChequera.Cantidad_cheques;
            objeto.Inicio = this.gChequera.Inicio;
            objeto.Usuario_creador = this.gChequera.Usuario_creador;
            objeto.Fecha_creacion = this.gChequera.Fecha_creacion;
            objeto.Usuario_modificador = this.gChequera.Usuario_modificador;
            objeto.Fecha_modificacion = BLFechaHoraServidor.Obtener();

            if (this.BLChequeras.Update(objeto))
            {
                MessageBox.Show("El proceso ha sido correcto");
                this.clearForm();
                this.modoInicial();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (this.gChequera == null)
            {
                MessageBox.Show("Problemas al obtener el objeto de base de datos");
                return;
            }
            if (this.BLChequeras.Delete(this.gChequera.Numero))
            {
                this.clearForm();
                this.modoInicial();

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

            var objeto = this.BLChequeras.ChequerasSelectbyId(codigo);

            if (objeto == null && objeto.Count <= 0) { return; }
            this.buscarChequeres(objeto);
        }

        private void buscarChequeres(List<ChequerasModel> objetos)
        {
            string[][] orden = new string[4][];

            orden[0] = new string[] { "Numero", "Numero de chequera", "100" };
            orden[1] = new string[] { "FechaRegistro", "Fecha Registro", "150" };
            orden[2] = new string[] { "Cantidad_cheques", "Cantidad de cheques", "150" };
            orden[3] = new string[] { "Estado", "Estado Chequera", "150" };

            if (objetos != null)
            {
                using (Ayuda.FormHelp2 formHelp1 = new Ayuda.FormHelp2())
                {
                    formHelp1.setList(objetos, orden);
                    formHelp1.ShowDialog();

                    if (formHelp1.EstaAceptado())
                    {
                        var dato = formHelp1.getObject<ChequerasModel>();
                        if (dato != null)
                        {
                            this.clearForm();
                            this.gChequera = this.BLChequeras.GetChequerasModel(dato.Numero);
                            this.chequera2gui(this.gChequera);
                            this.modoNuevo();
                            this.modoEdicion();
                        }
                    }
                }
            }
        }
    }
}
