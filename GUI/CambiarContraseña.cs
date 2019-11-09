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

    public partial class CambiarContraseña : Form
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
        private string m_newpassword = null;
        private bool usuarioCambiarContraseña;

        public CambiarContraseña()
        {
            InitializeComponent();
            
        }

        private void SetLogin()
        {
            if (!string.IsNullOrEmpty(this.txtUsuario.Text.Trim()))
            {
                this.m_username = this.txtUsuario.Text.Trim();
            }
            else
            {
                MessageBox.Show("No se permite espacios vacios");
                return;
            }

            if (!string.IsNullOrEmpty(this.txtPass.Text.Trim()))
            {
                this.m_password = this.txtPass.Text.Trim();
            }
            else
            {
                MessageBox.Show("No se permite espacios vacios");
                return;
            }

            if (!string.IsNullOrEmpty(this.txtNewPass.Text.Trim()))
            {
                this.m_newpassword = this.txtNewPass.Text.Trim();
            }
            else
            {
                MessageBox.Show("No se permite espacios vacios");
                return;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pbxClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            SetLogin();
            if (ChangePassword())
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
            else MessageBox.Show("Error en las credenciales");
        }

        private bool ChangePassword()
        {
            try
            {

                using (WsSistemaBancario.PersonaServiceClient user = new WsSistemaBancario.PersonaServiceClient())
                {
                    string newPassEncrypt = Encrypt.GetSHA256(this.m_newpassword);
                    string m_actualPassword = Encrypt.GetSHA256(this.m_password);

                    usuarioCambiarContraseña = user.Persona_CambiarContraseña(this.m_username, m_actualPassword, newPassEncrypt);


                    if (usuarioCambiarContraseña)
                    {
                        return true;
                    }

                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
