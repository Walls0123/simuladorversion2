using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocio.Ventanilla;
using Sistema_Bancario.Ventanilla;
using Modelos.Modelos;

namespace Sistema_Bancario.Controles
{
    public partial class NroCuenta : UserControl
    {
        public CuentasMethods validar;
        public byte[] VersionCuenta { get; set; }
        public string EstadoCuenta { get; set; }
        FrmListaDatos frm;
        CuentasMethods cuentas;
        public NroCuenta()
        {
            InitializeComponent();
            dni1.TBDni.TextChanged += TBDni_TextChanged;
            dni1.TBDni.Click += TBDni_Click; ;
        }

        private void TBDni_Click(object sender, EventArgs e)
        {
            LlamadaVentana();
        }
        private void TBDni_TextChanged(object sender, EventArgs e)
        {
            LlamadaVentana();
        }
        private void TBNroCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void LlamadaVentana()
        {
            frm = new FrmListaDatos(dni1.TBDni.Text);
            frm.textBox1.TextChanged += TextBox1_TextChanged;
            cuentas = new CuentasMethods();
            var Lista = cuentas.ListaCuentas(dni1.TBDni.Text);
            frm.CrearLista<CuentasPersona>(cuentas.ListaCuentas(dni1.TBDni.Text));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                TBNroCuenta.Text = frm.val1;
                Lbestado.Text = frm.val2;
                try
                {
                    validar = new CuentasMethods();
                    var Cuenta = validar.ValidarCuenta(TBNroCuenta.Text);

                    //     LbPersona.Text = "Cliente: " + Cuenta.Cliente;                   
                    Lbestado.Text = Cuenta.Estado;
                    Lbmoneda.Text = Cuenta.Moneda;
                    VersionCuenta = Cuenta.Version;
                    EstadoCuenta = Cuenta.Estado;                   

                    groupBox1.Enabled = true;
                    if (Cuenta.TipoCuenta == "CORRIENTE")
                    {
                        rbtnCorriente.Checked = true;
                    }
                    else
                    {
                        rbtnAhorros.Checked = true;
                    }
                    //   LbPersona.Visible = true;
                    groupBox1.Enabled = false;
                    Lbestado.Visible = true;
                    Lbmoneda.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        public bool ValidarEstadoCuenta()
        {
            if (EstadoCuenta.Equals("No Habilitada"))
            {
                MessageBox.Show("Cuenta:" + EstadoCuenta);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            frm.CrearLista<CuentasPersona>(cuentas.ListaCuentas(dni1.TBDni.Text));
            
        }

        public void LimpiarControles()
        {
            TBNroCuenta.Clear();
           // groupBox1.Refresh();
         //   LbPersona.Visible = false;
            Lbestado.Visible = false;
            Lbmoneda.Visible = false;
        }

        private void BtValidar_Click(object sender, EventArgs e)
        {
                   
        }
    }
}
