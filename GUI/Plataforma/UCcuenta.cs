using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Session;
using Modelos.Modelos;

namespace Sistema_Bancario.Plataforma
{
    public partial class UCcuenta : Base
    {
        public ISession Session; 
        private PersonaModel cliente;
        private TipoMonedaModel moneda;
        private string tipoCuenta;

        public UCcuenta()
        {
            InitializeComponent();
            //se crea el evento click del boton proceder
            proceder1.BTProceder.Click += BTProceder_Click;
        }

        private void BTProceder_Click(object sender, EventArgs e)
        {
            //Evento Click del boton proceder
            //Comprobaciones
            if (Session == null) { MessageBox.Show("La sesión ha expirado"); this.Dispose(); }

            cliente = datosPersona1.ObtenerPersona();
            moneda = tipoCuenta1.ObtenerMoneda();
            tipoCuenta = tipoCuenta1.ObtenerTipoCuenta();
            int t_cuenta = 0;

            switch (tipoCuenta)
            {
                case ("AHORROS"): t_cuenta = 1;
                    break;
                case ("CORRIENTE"): t_cuenta = 2;
                    break;
                case ("CREDITO"): t_cuenta = 3;
                    break;
            }


            if (cliente == null) { MessageBox.Show("Selecciona un cliente"); return; }
            if (moneda == null) { MessageBox.Show("Selecciona una moneda"); return; }
            if (string.IsNullOrEmpty(tipoCuenta)) { MessageBox.Show("Selecciona un tipo de cuenta"); return; }
            Random rd = new Random();
            string NumeroCuenta = string.Concat("00451", Session.SucursalCodigo, rd.Next(100000, 999999), moneda.Id, t_cuenta);
            CuentasModel cuenta_nueva = new CuentasModel()
            {
                Cliente = cliente.Id,
                Estado = true,
                Nrocuenta = NumeroCuenta,
                Tipocuenta = tipoCuenta,
                Saldocontable = 0,
                Saldodisponible = 0,
                Sobregiro = 0,
                Tipomoneda = moneda.Id,
                Usuario_creador = Session.UserCodigo
            };

            using (WsSistemaBancario.CuentaServiceClient _Cuenta = new WsSistemaBancario.CuentaServiceClient())
            {
                bool result = _Cuenta.Cuenta_Crear(cuenta_nueva);

                if (result)
                {
                    MessageBox.Show("Cuenta Creada Correctamente");
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }

        }

        private static UCcuenta _instance;
        public static UCcuenta instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UCcuenta();
                }

                return _instance;
            }
        }
            
        private void UCcuenta_Load(object sender, EventArgs e)
        {
            //pruebalo aver, espera te muestro donde se implementa 
        }
    }
}
