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
using Sistema_Bancario.Clases;

namespace Sistema_Bancario.Administrador
{
    public partial class BuscarPersona : Form
    {
        public BuscarPersona()
        {
            InitializeComponent();
            llenarBusquedaUsuariosDGV();
        }
        public List<PersonaModel> usuariosFiltrados;

        public int id;
        public string nombre;

        private void llenarBusquedaUsuariosDGV()
        {
            try
            {
                using (WsSistemaBancario.PersonaServiceClient busc = new WsSistemaBancario.PersonaServiceClient())
                {
                    usuariosFiltrados = busc.Persona_ObtenerTodos().ToList();
                    foreach (var u in usuariosFiltrados)
                    {
                        dgvBusquedaUsuarios.Rows.Add(u.Id,u.Nombres,u.Apellidos,u.Tipodocumento,u.Nrodocumento);
                    }
                }
            }
            catch (Exception)
            {
            }

        }

        private void dgvBusquedaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id = Convert.ToInt16(dgvBusquedaUsuarios.Rows[e.RowIndex].Cells["IdPersona"].Value);
                nombre= dgvBusquedaUsuarios.Rows[e.RowIndex].Cells["NombresPersona"].Value.ToString();
            }
        }

        PersonaModel persona = new PersonaModel();
        public DialogResult resultado;
        private void btnAceptarBusqueda_Click(object sender, EventArgs e)
        {
            resultado = DialogResult.OK;
            this.Close();
        }

        private void btnCancelarBusqueda_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
