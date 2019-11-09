using Modelos.Session;
using Sistema_Bancario.Clases;
using Sistema_Bancario.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bancario
{
   public partial class Login : Form
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

      private string m_username = null;
      private string m_password = null;
      public Login()
      {
         InitializeComponent();
       //  UIButton.SetRound(btnIniciarSesion, 15);
            UIButton.SetRound(Estado, 15);
      //   UIForm.SetRound(this, 7);
      }
      //Variables globales
      private Modelos.Modelos.PersonaModel usuarioLogin;
      private Modelos.Modelos.SucursalModel SucursalUsuario;
        private Modelos.Modelos.VentanillaModel ventanilla;
        private Modelos.Modelos.TurnosModel turno;
      private List<Modelos.Modelos.ComponenteModel> listaComponentes;
      private List<Modelos.Modelos.RolesModel> listaRoles;

      private ISession Session;

      private void SetLogin()
      {
            if (!string.IsNullOrEmpty(this.txtUsuario.Text.Trim()))
                {
                    this.m_username = this.txtUsuario.Text.Trim();
                }
            else
                {
                    MessageBox.Show("No se permite estacios vacios");
                    return;
                }

            if (!string.IsNullOrEmpty(this.txtPass.Text.Trim()))
                {
                    this.m_password = this.txtPass.Text.Trim();
                }
            else
                {
                    MessageBox.Show("No se permite estacios vacios");
                    return;
                }
      }

      private void ClearLogin()
      {
         this.txtUsuario.Text = null;
         this.txtPass.Text = null;
      }

      private bool StartLogin()
      {
         bool back = false;
         try
         {
                using (WsSistemaBancario.PersonaServiceClient user = new WsSistemaBancario.PersonaServiceClient())
                {
                    string passEncrypt = Encrypt.GetSHA256(this.m_password);
                    usuarioLogin = user.Persona_ValidarUsuario(this.m_username, passEncrypt);
                    SucursalUsuario = user.Persona_ObtenerSucursal(usuarioLogin.Id);
                    if (SucursalUsuario is null)
                    {
                        SucursalUsuario = new Modelos.Modelos.SucursalModel();
                        SucursalUsuario.Id = 0;
                        SucursalUsuario.Nombre = "Sin sucursal";
                    }
                    listaComponentes = user.Persona_GetComponentes(usuarioLogin.Id).ToList();

                    listaRoles = user.Persona_GetRolesUsuario(usuarioLogin.Nombreusuario).ToList();
                    back = true;
                }
                using (WsSistemaBancario.VentanillaServiceClient venta = new WsSistemaBancario.VentanillaServiceClient())
                {
                    
                    ventanilla = venta.Ventanilla_ObtenerUnoXusuario(usuarioLogin.Id);
                    if (ventanilla is null)
                    {
                        ventanilla = new Modelos.Modelos.VentanillaModel();
                        ventanilla.Id_ventanilla = 0;
                        ventanilla.Descripcion = "Sin ventanilla";
                    }
                }
                using (WsSistemaBancario.TurnosServiceClient turn = new WsSistemaBancario.TurnosServiceClient())
                {
                    turno = turn.Turnos_ObtenerUnoXUsuario(usuarioLogin.Id);
                    if (turno is null)
                    {
                        turno = new Modelos.Modelos.TurnosModel();
                        turno.Id = 0;
                        turno.Descripcion = "Sin turno";
                    }
                }
                if (usuarioLogin != null && SucursalUsuario != null)
                {
                    Session = new Session();
                    Session.UserCodigo = usuarioLogin.Id.ToString();
                    Session.UserName = usuarioLogin.Nombreusuario;
                    Session.UserNombreCompleto = usuarioLogin.Nombres + " " + usuarioLogin.Apellidos;

                    //Session.SucursalCodigo = SucursalUsuario.Id.ToString();
                    Session.SucursalCodigo = string.Format("{0:000}", SucursalUsuario.Id);
                    Session.SucursalNombre = SucursalUsuario.Nombre;
                    //agregar aqui ventanilla ID y descripcion, turno ID y descripcion
                    Session.VentanillaCodigo = ventanilla.Id_ventanilla.ToString();
                    Session.VentanillaDescripcion = ventanilla.Descripcion;
                    Session.Turno = turno;
                    Session.SucursalUbicacion = SucursalUsuario.Ubicacion;
                    Session.SucursalCodigoBanco = SucursalUsuario.Idbanco.ToString();
                    Session.Componentes = listaComponentes;
                    Session.UserRol = listaRoles;
                    back = true;
                }
                return back;
         }
         catch (Exception)
         {
            return back;
         }
      }
      private void button1_Click(object sender, EventArgs e)
      {          
            SetLogin();
            Cursor.Current = Cursors.WaitCursor;
            if (StartLogin())
            {
                VentanaPrincipal ventanaPrincipal = new VentanaPrincipal(Session);
                ClearLogin();
                Cursor.Current = Cursors.Arrow;
                Close();
            }
            else
            {
                MessageBox.Show("Error en las credenciales");
            }               
      }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CambiarContraseña cambiarContraseña = new CambiarContraseña();
            cambiarContraseña.Show();
            this.Close();
            
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BTClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
