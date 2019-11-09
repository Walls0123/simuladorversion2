using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Bancario.Froms_opciones;
using Sistema_Bancario.Plataforma;
using Sistema_Bancario.plataforma_controles;
using Modelos.Modelos;
using Sistema_Bancario.Ventanilla;
using Sistema_Bancario.Config;
using Sistema_Bancario.Administrador;
using Modelos.Session;
using Sistema_Bancario.Controles;
using XWFControlLibrary.Ventanilla;
//using Sistema_Bancario.Ventanilla;

namespace Sistema_Bancario
{
   public partial class VentanaPrincipal : Form
   {

      #region [ View Config ]
      private const int m_Shadow = 0x0020000;

      protected override CreateParams CreateParams
      {
         get
         {
            CreateParams _cp = base.CreateParams;
            _cp.ClassStyle |= m_Shadow;
            return _cp;
         }
      }

      #endregion

      private ISession Session = null;
      Button BtnSelecionado;
      List< Button> LBtn = new List<Button>();
      List<Type> LControls = new List<Type>();
        public VentanaPrincipal(ISession session)
        {
         try
         {
            Session = session;
            EvaluarUsuario();
            UIForm.SetRound(this, 7);

         }
         catch (Exception)
         { }
        }

        private void EvaluarUsuario()
        {
         if (Session != null)
         {
            InitializeComponent();

            if (Session.UserRol.Any(r => r.Descripcion == "Administrador"))
            {
                BTAdministrador.Visible = true;
            }
                Show();
            //if (Session.isAdmin)
            //{

            //}
            //else if (Session.User == 1)
            //{
            lblUsertType.Image = Properties.Resources.estudiante;
            //}

            SetSessionValues();
         }
         else
         {
            MessageBox.Show("Es necesario iniciar session");
         }
        }
        public VentanaPrincipal()
        {
            InitializeComponent();
        }
        private void SetSessionValues()
        {
         lblUserValueType.Text = Session.UserNombreCompleto;
         lblSucursal.Text = Session.SucursalNombre;
            lblVentanilla.Text = Session.VentanillaDescripcion;
            lblTurno.Text = Session.Turno.Descripcion;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
      {
            if (keyData == (Keys.F1))
            {
                BTGestion.BackColor = SystemColors.HotTrack;
                panel2.Controls.Clear();
                this.Componentes(3);
                return true;
            }
            else if (keyData == (Keys.F2))
            {
                BTGestion.BackColor = SystemColors.HotTrack;
                panel2.Controls.Clear();
                this.Componentes(2);
                return true;
            }
            else if (keyData == (Keys.F3))
            {
                BTGestion.BackColor = SystemColors.HotTrack;
                panel2.Controls.Clear();
                this.Componentes(1);
                return true;
            }
            else if (keyData == (Keys.F4))
            {

            }
            else if (keyData == Keys.Alt && keyData == Keys.NumPad1)
            {

            }
         return base.ProcessCmdKey(ref msg, keyData);
      }

        public void CrearBoton(Button NombreButton, string Text, int x)
      {
            //56; 96; 147
            NombreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
         NombreButton.FlatAppearance.BorderSize = 0;
         NombreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(96)))), ((int)(((byte)(147)))));
            NombreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(96)))), ((int)(((byte)(147)))));
            NombreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         NombreButton.Font = new Font("Verdana", 8, FontStyle.Bold);
         NombreButton.Padding = new Padding(20, 0, 0, 0);
         NombreButton.ForeColor = System.Drawing.SystemColors.Window;
         NombreButton.Margin = new System.Windows.Forms.Padding(2);
         NombreButton.Size = new System.Drawing.Size(200, 41);
         NombreButton.TabIndex = 6;
         NombreButton.Text = Text;
         NombreButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         NombreButton.UseVisualStyleBackColor = false;
         NombreButton.Location = new Point(0, x);
         NombreButton.Click += new EventHandler(Evento_Click);
            panel2.Controls.Add(NombreButton);

      }

        #region Utilitarios
        public void CrearControl<T>(UserControl parameter, Button btn)
        {
            if (!panel1.Controls.Contains(parameter))
            {
                panel1.Controls.Add(parameter);
                parameter.Dock = DockStyle.Fill;
                parameter.BringToFront();
                TituloText.Text = btn.Text;
            }
            else
            {
                TituloText.Text = btn.Text;
                parameter.BringToFront();
            }
        }
        public void OpcionSelecionada(Button btn)
        {
            if (BtnSelecionado != btn && BtnSelecionado != null)
            {
                BtnSelecionado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
                btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(96)))), ((int)(((byte)(147)))));
                BtnSelecionado = btn;

            }
            else
            {
                btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(96)))), ((int)(((byte)(147)))));
                BtnSelecionado = btn;
            }
        }
        private void Marcar(object boton)
        {
            Button BotonMenu;
            BotonMenu = boton as Button;
            BTOperaciones.BackColor = Color.Transparent;
            BTReportes.BackColor = Color.Transparent;
            BTGestion.BackColor = Color.Transparent;
            BTPlataforma.BackColor = Color.Transparent;
            BTOperaciones.ForeColor = Color.Black;
            BTReportes.ForeColor = Color.Black;
            BTGestion.ForeColor = Color.Black;
            BTPlataforma.ForeColor = Color.Black;
            BotonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(96)))), ((int)(((byte)(147)))));
            BotonMenu.ForeColor = Color.White;
        }
        #endregion

        #region Eventos
        private void Evento_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            TituloText.Visible = true;
            OpcionSelecionada(btn);

            #region Instancias_Controles
            LControls.Add(typeof(Retiros));

            if (btn.Text.Equals("Retiros"))
            {
                CrearControl<UserControl>(Retiros.instance, btn);
            }
            else if (btn.Text.Equals("Depósitos"))
            {
                CrearControl<UserControl>(Depositos.instance, btn);
            }
            else if (btn.Text.Equals("Transferencias"))
            {
                CrearControl<UserControl>(Transferencias.instance, btn);
            }
            else if (btn.Text.Equals("Envío Giros"))
            {
                CrearControl<UserControl>(Envio_Giros.instance, btn);
            }
            else if (btn.Text.Equals("Cobro Giros"))
            {
                CrearControl<UserControl>(CobroGiros.instance, btn);
            }
            else if (btn.Text.Equals("Pago tarjetas"))
            {
                CrearControl<UserControl>(Tarjetas.instance, btn);
            }
            else if (btn.Text.Equals("Pago Cuotas"))
            {
                CrearControl<UserControl>(Cuotas.getinstance(), btn);
            }
            else if (btn.Text.Equals("Tipo Cambio"))
            {
            ViewTipoCambio tipoCambio = ViewTipoCambio.instance;
            tipoCambio.session = Session;
                CrearControl<UserControl>(tipoCambio, btn);
            }
            else if (btn.Text.Equals("Pago Servicios"))
            {
                CrearControl<UserControl>(Servicios.instance, btn);
            }
            else if (btn.Text.Equals("Cuentas"))
            {
                NuevaCuentaUserControl cuenta;
                if (this.Session != null)
                {
                    cuenta = new NuevaCuentaUserControl(this.Session);
                    CrearControl<UserControl>(cuenta, btn);
                }
                else
                {
                    MessageBox.Show("La sesión ha caducado");
                }
            }
            else if (btn.Text.Equals("Gestionar Cuenta"))
            {
                CrearControl<UserControl>(UCactualizarCuenta.instance, btn);
            }
            else if (btn.Text.Equals("Préstamos"))
            {
                NuevoPrestamoUserControl prestamo;
                if (this.Session != null)
                {
                    prestamo = new NuevoPrestamoUserControl(this.Session);
                    CrearControl<UserControl>(prestamo, btn);
                }
                else
                {
                    MessageBox.Show("La sesión ha caducado");
                }
            }
            else if (btn.Text.Equals("Refinanciar"))
            {
                CrearControl<UserControl>(UCrefinanciar.instance, btn);
            }
            else if (btn.Text.Equals("Gestionar Tarjetas"))
            {
                //CrearControl<UserControl>(UCchequeras.instance, btn);
                NuevaTarjeta tarjeta;
                if (this.Session != null)
                {
                    tarjeta = new NuevaTarjeta(this.Session);
                    CrearControl<UserControl>(tarjeta, btn);
                }
                else
                {
                    MessageBox.Show("La sesión ha caducado");
                }
            }
            else if (btn.Text.Equals("Gestionar Chequera"))
            {
                //CrearControl<UserControl>(UCchequeras.instance, btn);
                RegistrarChequera chequera;
                if (this.Session != null)
                {
                    chequera = new RegistrarChequera(this.Session);
                    CrearControl<UserControl>(chequera, btn);
                }
                else
                {
                    MessageBox.Show("La sesión ha caducado");
                }
            }
            else if (btn.Text.Equals("Balancin Caja"))
            {
                Balancin balancin = new Balancin(Session);
                CrearControl<UserControl>(balancin, btn);
            }
            else if (btn.Text.Equals("Resumen total"))
            {
                CrearControl<UserControl>(ResumenTotal.instance, btn);
            }
            else if (btn.Text.Equals("Clientes"))
            {
                RegistroPersonaUserControl personas;
                if (this.Session != null)
                {
                    personas = new RegistroPersonaUserControl(this.Session);
                    CrearControl<UserControl>(personas, btn);
                }
                else
                {
                    MessageBox.Show("La sesión ha caducado");
                }
            }
            else if (btn.Text.Equals("Monedas"))
            {
                NuevaMoneda monedas;
                if (this.Session != null)
                {
                    monedas = new NuevaMoneda(this.Session);
                    CrearControl<UserControl>(monedas, btn);
                }
                else
                {
                    MessageBox.Show("La sesión ha caducado");
                }
            }
            else if (btn.Text.Equals("Cobro Cheques"))
            {
                CrearControl<UserControl>(Cheques.instance, btn);
            }
            else if (btn.Text.Equals("Personas"))
            {
                CrearControl<UserControl>(Usuario.instance, btn);
            }
            else if (btn.Text.Equals("Roles"))
            {
                CrearControl<UserControl>(Roles.instance, btn);
            }
            else if (btn.Text.Equals("Permisos"))
            {
                CrearControl<UserControl>(Permisos.instance, btn);
            }

            else if (btn.Text.Equals("Cronograma"))
            {
                ReporteCronograma cronograma;
                if (this.Session != null)
                {
                    cronograma = new ReporteCronograma(this.Session);
                    CrearControl<UserControl>(cronograma, btn);
                }
                else
                {
                    MessageBox.Show("La sesión ha caducado");
                }
            }
            #endregion
        }
        private void BTGestion_Click(object sender, EventArgs e)
        {
            Marcar(sender);
            panel2.Controls.Clear();
            this.Componentes(2);
        }

        private void BTPlataforma_Click(object sender, EventArgs e)
        {
            Marcar(sender);
            panel2.Controls.Clear();
            this.Componentes(1);
        }

        private void BTReportes_Click(object sender, EventArgs e)
        {
            Marcar(sender);
            panel2.Controls.Clear();
            this.Componentes(5);
        }

        private void BTOperaciones_Click(object sender, EventArgs e)
        {
            Marcar(sender);
            panel2.Controls.Clear();
            this.Componentes(3);
        }

        private void BTAdministrador_Click(object sender, EventArgs e)
        {
            Marcar(sender);
            panel2.Controls.Clear();
            this.Componentes(4);
        }
        private void Button11_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Close();
        }
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void Componentes(int x)
      {
         switch (x)
         {
            case 1:
                   
                    if (Session.Componentes.Any(c => c.Nombre == "Abrir Cuenta"))
                    {
                        Button AbrirCuenta = new Button();
                       
                        this.CrearBoton(AbrirCuenta, "Cuentas", 0);
                    }

                    //if (Session.Componentes.Any(c => c.Nombre == "Gestionar Cuenta"))
                    //{
                    //    Button GestionarCuenta = new Button();
                       
                    //    this.CrearBoton(GestionarCuenta, "Gestionar Cuenta", 50);
                    //}

                    if (Session.Componentes.Any(c => c.Nombre == "Realizar Préstamo"))
                    {
                        Button RealizarPrestamo = new Button();
                       
                        this.CrearBoton(RealizarPrestamo, "Préstamos", 50);
                    }

                    //if (Session.Componentes.Any(c => c.Nombre == "Refinanciar"))
                    //{
                    //    Button Refinanciar = new Button();
                        
                    //    this.CrearBoton(Refinanciar, "Refinanciar", 150);
                    //}

                    if (Session.Componentes.Any(c => c.Nombre == "Gestionar Tarjetas"))
                    {
                        Button GestionarTarjetas = new Button();

                        this.CrearBoton(GestionarTarjetas, "Gestionar Tarjetas", 200);
                    }

                    //if (Session.Componentes.Any(c => c.Nombre == "Gestionar Chequera"))
                    //{
                    //    Button GestionarChequera = new Button();

                    //    this.CrearBoton(GestionarChequera, "Gestionar Chequera", 250);
                    //}
                    break;
                case 2:
               Button Cliente = new Button();
               Button TipoCliente = new Button();
               Button Moneda = new Button();
               Button TipoCuenta = new Button();
               Button InteresesMoratorios = new Button();
               Button Aseguradora = new Button();
               Button Empleado = new Button();

               this.CrearBoton(Cliente, "Clientes", 0);
               this.CrearBoton(TipoCliente, "Monedas", 50);
               this.CrearBoton(TipoCuenta, "Gestionar Tarjetas", 100);
               this.CrearBoton(InteresesMoratorios, "Gestionar Chequera", 150);
               break;
            case 3:
              

                //    if (Session.Componentes.Any(c => c.Nombre == "Retiros"))
                //    {
                        Button Retiros = new Button();
                        this.CrearBoton(Retiros, "Retiros", 0);
                //    }

                 //   if (Session.Componentes.Any(c => c.Nombre == "Depósitos"))
                 //   {
                        Button Depositos = new Button();
                        this.CrearBoton(Depositos, "Depósitos", 50);
                 //   }

                 //   if (Session.Componentes.Any(c => c.Nombre == "Transferencias"))
                 //   {
                        Button Transferencias = new Button();
                        this.CrearBoton(Transferencias, "Transferencias", 100);
                 //   }

                 //   if (Session.Componentes.Any(c => c.Nombre == "Envío Giros"))
                 //   {
                        Button Envio_Giros = new Button();
                        this.CrearBoton(Envio_Giros, "Envío Giros", 150);
                //    }

                //    if (Session.Componentes.Any(c => c.Nombre == "Cobro Giros"))
                //    {
                        Button Cobro_Giros = new Button();
                        this.CrearBoton(Cobro_Giros, "Cobro Giros", 200);
                //    }

               //     if (Session.Componentes.Any(c => c.Nombre == "Cobro Giros"))
               //     {
                      //  Button Pago_tarjetas = new Button();
                     //   this.CrearBoton(Pago_tarjetas, "Pago tarjetas", 250);
                 //   }

                //    if (Session.Componentes.Any(c => c.Nombre == "Pago Cuotas"))
               //     {
                        Button Pago_Cuotas = new Button();
                        this.CrearBoton(Pago_Cuotas, "Pago Cuotas", 250);
                //    }

                //    if (Session.Componentes.Any(c => c.Nombre == "Tipo Cambio"))
                //    {
                        Button Tipo_Cambio = new Button();
                        this.CrearBoton(Tipo_Cambio, "Tipo Cambio", 300);
                //    }

                //    if (Session.Componentes.Any(c => c.Nombre == "Pago Servicios"))
                //    {
                        Button Pago_Servicios = new Button();
                        this.CrearBoton(Pago_Servicios, "Pago Servicios", 350);
                //    }

               //     if (Session.Componentes.Any(c => c.Nombre == "Cobro Cheques"))
               //     {
                        Button Cobro_Cheques = new Button();
                        this.CrearBoton(Cobro_Cheques, "Cobro Cheques", 400);
               //     }

                //    if (Session.Componentes.Any(c => c.Nombre == "Balancin Caja"))
                //    {
                   //     Button Balancin = new Button();
                   //     this.CrearBoton(Balancin, "Balancin Caja", 450);
                //    }

                  //  if (Session.Componentes.Any(c => c.Nombre == "Resumen Total"))
                   // {
                 //       Button Resumen_total = new Button();
                  //      this.CrearBoton(Resumen_total, "Resumen total", 500);
               //     }
               break;


             case 4:
               Button Personas = new Button();
               Button Roles = new Button();
               Button Permisos = new Button();

               this.CrearBoton(Personas, "Personas", 0);
               this.CrearBoton(Roles, "Roles", 50);
               this.CrearBoton(Permisos, "Permisos", 100);
               break;

            case 5:
                Button Cronograma = new Button();
                this.CrearBoton(Cronograma, "Cronograma", 0);
                break;
            }
      }

      
    }
}
