using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Modelos;
using Modelos.Session;
using Sistema_Bancario.Clases;

namespace Sistema_Bancario.Administrador
{
    public partial class AgregarNuevoUsuario : Form
    {
        public static int idRol;
        public static int idPersona;
        public static string NombrePersona;
        public ISession session;

        public AgregarNuevoUsuario(ISession sesion)
        {
            
            InitializeComponent();
            this.session = sesion;
            
        }

        
        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            using (BuscarPersona frmBuscarPersona = new BuscarPersona())
            {
                frmBuscarPersona.ShowDialog();
                if (frmBuscarPersona.resultado == DialogResult.OK)
                {
                    idPersona = frmBuscarPersona.id;
                    NombrePersona = frmBuscarPersona.nombre;
                    txtUsuarioBuscado.Text = NombrePersona;
                }
            }
        }

        bool confirmarCreacion;

        private void btnInsertarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string passEncrypt = Encrypt.GetSHA256(txtContraseña.Text);
                using (WsSistemaBancario.PersonaServiceClient CrearUsuario = new WsSistemaBancario.PersonaServiceClient())
                {
                    confirmarCreacion = CrearUsuario.Persona_CrearNuevoUsuario(idPersona, txtUsuario.Text, passEncrypt, chbEstado.Checked);
                    txtUsuarioBuscado.Text = "";
                    txtContraseña.Text = "";
                    txtUsuario.Text = "";
                    using (WsSistemaBancario.RolUsuarioServiceClient CrearRolUsuario = new WsSistemaBancario.RolUsuarioServiceClient())
                    {
                        RolUsuarioModel rum = new RolUsuarioModel();
                        rum.Id_persona = idPersona;
                        rum.Id_rol = idRol;
                        rum.Activo = true;
                        rum.Fecha_creacion = DateTime.Now;
                        rum.Usuario_creador = "Administrador";

                        CrearRolUsuario.RolUsuario_Crear(rum,1);
                    }
                    //llenarDGVUsuarios();
                    pnlAgregarUsuario.SendToBack();

                   // pnlSecundario.BringToFront();
                }
                MessageBox.Show("Usuario agregado correctamente!","Correcto",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
