using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Bancario.Ventanilla;
using CNegocio.Backend;
using Modelos.Modelos;

namespace Sistema_Bancario.Controles
{
    public partial class DNI : UserControl
    {
        FrmListaDatos frmLista;
        public DNI()
        {
            InitializeComponent();
        }

        private void TBDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            PersonaMethods persona = new PersonaMethods();
            frmLista = new FrmListaDatos();
           // persona.personaSelectbyNombres(TbNombre.Text);
            frmLista.CrearLista<PersonaU>(persona.personaSelectbyNombresApellidos(TbNombre.Text));
            if (frmLista.ShowDialog() == DialogResult.OK)
            {
                TBDni.Text = frmLista.val2;
                TbNombre.Text = frmLista.val1;
            };         
        }       
    }
}
