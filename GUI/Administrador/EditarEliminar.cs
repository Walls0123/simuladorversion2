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

namespace Sistema_Bancario.Administrador
{
    public partial class EditarEliminar : Form
    {
        public EditarEliminar()
        {
            InitializeComponent();
            cargarDGV();
        }

        public int idRol;

        public List<RolesModel> roles;

        private void cargarDGV()
        {
            try
            {
                using (WsSistemaBancario.RolesServiceClient rol = new WsSistemaBancario.RolesServiceClient())
                {
                    roles = rol.Roles_ObtenerTodos().ToList();
                    cmbRolesEditar.DataSource = roles;
                    cmbRolesEditar.DisplayMember = "Descripcion";
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                using (WsSistemaBancario.RolUsuarioServiceClient rol = new WsSistemaBancario.RolUsuarioServiceClient())
                {
                    RolUsuarioModel ru = new RolUsuarioModel();
                    ru.Id = Convert.ToInt16(idRolUsuario.Text);
                    ru.Id_persona = Convert.ToInt16(txtIdUsuario.Text);
                    ru.Id_persona = Convert.ToInt16(txtIdUsuario.Text);
                    ru.Id_rol = idRol;
                    ru.Usuario_creador = "Ad";
                    ru.Activo = chbActivo.Checked;
                    rol.RolUsuario_Editar(ru,1);
                }
            }
            catch (Exception)
            {
            }
        }

        private void cmbRolesEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            RolesModel rm = cmbRolesEditar.SelectedValue as RolesModel;
            idRol = rm.Id;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                using (WsSistemaBancario.RolUsuarioServiceClient rol = new WsSistemaBancario.RolUsuarioServiceClient())
                {
                    rol.RolUsuario_Eliminar(Convert.ToInt16(idRolUsuario.Text));
                }

                this.Close();
            }
            catch (Exception)
            {
            }
        }

        private void txtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
