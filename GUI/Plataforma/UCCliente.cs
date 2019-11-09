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
using CNegocio.Backend;
using Modelos.Modelos;

namespace Sistema_Bancario.Plataforma
{
    public partial class UCcliente : Base
    {
        private PersonaMethods BLPersonas = new PersonaMethods();

        public UCcliente()
        {
            InitializeComponent();
            proceder1.BTProceder.Click += BTProceder_Click;
        }

        private void UCCliente_Load(object sender, EventArgs e)
        {

        }

        private void BTProceder_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            MessageBox.Show(UCPersona.ApPaterno);
        }

        private void Nuevo()
        {
            txtTelefono.Text = "";
            txtEmail.Text = "";
            dtFechaNac.Value = System.DateTime.Now;
        }

        private static UCcliente _instance;
        public static UCcliente instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UCcliente();
                }

                return _instance;
            }
        }
    }
}
