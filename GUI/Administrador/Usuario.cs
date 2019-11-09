using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Modelos;
using Sistema_Bancario.Clases;
using Sistema_Bancario.Properties;
using Modelos.Session;

namespace Sistema_Bancario.Administrador
{
    public partial class Usuario : UserControl
    {
        ISession session = new Session();
        public Usuario(ISession sesion)
        {
            InitializeComponent();
            this.BackColor = Color.White;
            llenarDGVUsuarios();
            llenarComboBoxRoles();
            session = sesion;
        }
        public Usuario()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            llenarDGVUsuarios();
            llenarComboBoxRoles();
        }
        private static Usuario _instance;
        public static Usuario instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Usuario();
                }

                return _instance;
            }
        }

        public int id;
        public string nombre;

        public List<PersonaModel> Usuarios;

        private void llenarDGVUsuarios() {


            try
            {
                dgvUsuarios.Rows.Clear();
                using (WsSistemaBancario.PersonaServiceClient UsuariosLista = new WsSistemaBancario.PersonaServiceClient())
                {

                    Usuarios = UsuariosLista.Persona_UsuarioSelectAll().ToList();

                    foreach (var p in Usuarios)
                    {
                        dgvUsuarios.Rows.Add(p.Id,p.Nombres,p.Apellidos,p.Estado);
                    }
                }

            }

            catch (Exception)
            {

            }

        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id = Convert.ToInt16(dgvUsuarios.Rows[e.RowIndex].Cells["IdUsuario"].Value);
                nombre = dgvUsuarios.Rows[e.RowIndex].Cells["NombreUsuario"].Value.ToString();

            }
            pnlPrincipal.SendToBack();
            pnlSecundario.BringToFront();
            llenarDGVRolesUsuario();
            llenarDGVPeermisosUsuario();
        }

        public List<PermisosUsuarioModel> permUsuario;
        private void llenarDGVPeermisosUsuario()
        {
            try
            {
                using (WsSistemaBancario.PermisosUsuarioServiceClient per = new WsSistemaBancario.PermisosUsuarioServiceClient())
                {

                    permUsuario = per.PermisosUsuarioXusuario(id).ToList();

                    foreach (var r in rolesUsuario)
                    {
                        dgvPermisosUsuario.Rows.Add(r.Id, r.Descripcion, r.Activo);
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        public List<RolUsuarioModel> rolesUsuario;
        private void llenarDGVRolesUsuario()
        {
            try
            {
                using (WsSistemaBancario.RolesServiceClient RolUsuario = new WsSistemaBancario.RolesServiceClient())
                {

                     rolesUsuario = RolUsuario.Roles_RolesPorPersona(id).ToList();

                    foreach (var r in rolesUsuario)
                    {
                        dgvRolesUsuario.Rows.Add(r.Id,r.Descripcion,r.Activo);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {

            try
            {

                using (WsSistemaBancario.RolUsuarioServiceClient RolUsuario = new WsSistemaBancario.RolUsuarioServiceClient())
                {
                    RolUsuarioModel ru = new RolUsuarioModel();
                    ru.Id_persona = id;
                    ru.Id_rol = idRol;
                    ru.Activo = chbRolActivo.Checked;
                    ru.Fecha_creacion = DateTime.Now;
                    ru.Usuario_creador = "Saurom";

                    RolUsuario.RolUsuario_Crear(ru,1);
                    llenarDGVRolesUsuario();


                }

            }

            catch (Exception)
            {

            }



        }



        public List<RolesModel> roles;

        private void llenarComboBoxRoles()
        {

            try
            {

                using (WsSistemaBancario.RolesServiceClient rol = new WsSistemaBancario.RolesServiceClient())
                {

                    roles = rol.Roles_ObtenerTodos().ToList();


                    cmbRoles.DataSource = roles;

                    cmbRoles.DisplayMember = "Descripcion";
                    //cmbRoles.ValueMember = "Id";




                    //cmbRoles.Items.Add(r.Descripcion);

                }

            }

            catch (Exception)
            {

            }

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            pnlSecundario.SendToBack();
            pnlPrincipal.BringToFront();
        }

        public int idRol;

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            RolesModel rm = cmbRoles.SelectedValue as RolesModel;

            idRol = rm.Id;
        }

        private void dgvUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvUsuarios.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvUsuarios.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;
                Bitmap bm= Resources.icons8_editar_26;
                Image img = bm;
                e.Graphics.DrawImage(img, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvUsuarios.Rows[e.RowIndex].Height = img.Height + 10;
                this.dgvUsuarios.Columns[e.ColumnIndex].Width = img.Width + 10;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvUsuarios.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvUsuarios.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                Bitmap bm = Resources.icons8_eliminar_26;
                Image img = bm;
                e.Graphics.DrawImage(img, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvUsuarios.Rows[e.RowIndex].Height = img.Height + 10;
                this.dgvUsuarios.Columns[e.ColumnIndex].Width = img.Width + 10;

                e.Handled = true;
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex>=0) {
                if (this.dgvUsuarios.Columns[e.ColumnIndex].Name == "Editar")
                {

                    MessageBox.Show("Editar");
                }
                if (this.dgvUsuarios.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    using (WsSistemaBancario.PersonaServiceClient per = new WsSistemaBancario.PersonaServiceClient())
                    {
                        bool back = per.Persona_Eliminar(Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString()));
                        if (back)
                        {
                            MessageBox.Show("Usuario eliminado!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.llenarDGVUsuarios();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Eliminar!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                if (this.dgvUsuarios.Columns[e.ColumnIndex].Name == "EstadoUsuario")
                {
                    DataGridViewCheckBoxCell chk = this.dgvUsuarios.Rows[e.RowIndex].Cells["EstadoUsuario"] as DataGridViewCheckBoxCell;
                    if (chk.Value==chk.TrueValue)
                    {
                        //chk.Value = chk.FalseValue;
                        using (WsSistemaBancario.PersonaServiceClient per=new WsSistemaBancario.PersonaServiceClient())
                        {
                            bool back = per.ActualizarEstado(Convert.ToInt32(session.UserCodigo),Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString()),false);
                            if (back)
                            {
                                MessageBox.Show("Estado actualizado!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //chk.Value = chk.FalseValue;
                            }
                            else
                            {
                                MessageBox.Show("No se pudo actualizar!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                //chk.Value = chk.TrueValue;
                            }
                        }
                            
                    }
                    else
                    {
                        //chk.Value = chk.TrueValue;
                        using (WsSistemaBancario.PersonaServiceClient per = new WsSistemaBancario.PersonaServiceClient())
                        {
                            bool back = per.ActualizarEstado(Convert.ToInt32(session.UserCodigo), Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString()), true);
                            if (back)
                            {
                                MessageBox.Show("Estado actualizado!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                chk.Value = chk.TrueValue;
                            }
                            else
                            {
                                MessageBox.Show("No se pudo actualizar!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                chk.Value = chk.FalseValue;
                            }
                        }
                        //this.llenarDGVUsuarios();
                    }
                }
            }
        }

        private void dgvRolesUsuario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvRolesUsuario.Columns[e.ColumnIndex].Name == "EditarRol" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvRolesUsuario.Rows[e.RowIndex].Cells["EditarRol"] as DataGridViewButtonCell;
                Bitmap bm = Resources.icons8_editar_26;
                Image img = bm;
                e.Graphics.DrawImage(img, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvRolesUsuario.Rows[e.RowIndex].Height = img.Height + 10;
                this.dgvRolesUsuario.Columns[e.ColumnIndex].Width = img.Width + 10;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvRolesUsuario.Columns[e.ColumnIndex].Name == "EliminarRol" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvRolesUsuario.Rows[e.RowIndex].Cells["EliminarRol"] as DataGridViewButtonCell;
                Bitmap bm = Resources.icons8_eliminar_26;
                Image img = bm;
                e.Graphics.DrawImage(img, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvRolesUsuario.Rows[e.RowIndex].Height = img.Height + 10;
                this.dgvRolesUsuario.Columns[e.ColumnIndex].Width = img.Width + 10;

                e.Handled = true;
            }
        }

        private void dgvRolesUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (this.dgvRolesUsuario.Columns[e.ColumnIndex].Name == "EditarRol")
                {
                    MessageBox.Show("Editar");
                }
                if (this.dgvRolesUsuario.Columns[e.ColumnIndex].Name == "EliminarRol")
                {
                    MessageBox.Show("Eliminar");
                }
                if (this.dgvRolesUsuario.Columns[e.ColumnIndex].Name == "EstadoRol")
                {
                    DataGridViewCheckBoxCell chk = this.dgvRolesUsuario.Rows[e.RowIndex].Cells["EstadoRol"] as DataGridViewCheckBoxCell;
                    if (chk.Value == chk.TrueValue)
                    {
                        chk.Value = chk.FalseValue;
                        MessageBox.Show("Check");
                    }
                    else
                    {
                        chk.Value = chk.TrueValue;
                        MessageBox.Show("No check");
                    }
                }
            }
        }

        private void dgvPermisosUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (this.dgvPermisosUsuario.Columns[e.ColumnIndex].Name == "EditarPermiso")
                {
                    MessageBox.Show("Editar");
                }
                if (this.dgvPermisosUsuario.Columns[e.ColumnIndex].Name == "EliminarPermiso")
                {
                    MessageBox.Show("Eliminar");
                }
                if (this.dgvPermisosUsuario.Columns[e.ColumnIndex].Name == "EstadoPermiso")
                {
                    DataGridViewCheckBoxCell chk = this.dgvPermisosUsuario.Rows[e.RowIndex].Cells["EstadoPermiso"] as DataGridViewCheckBoxCell;
                    if (chk.Value == chk.TrueValue)
                    {
                        chk.Value = chk.FalseValue;
                        MessageBox.Show("Check");
                    }
                    else
                    {
                        chk.Value = chk.TrueValue;
                        MessageBox.Show("No check");
                    }
                }
            }
        }

        private void dgvPermisosUsuario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvPermisosUsuario.Columns[e.ColumnIndex].Name == "EditarPermiso" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvPermisosUsuario.Rows[e.RowIndex].Cells["EditarPermiso"] as DataGridViewButtonCell;
                Bitmap bm = Resources.icons8_editar_26;
                Image img = bm;
                e.Graphics.DrawImage(img, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvPermisosUsuario.Rows[e.RowIndex].Height = img.Height + 10;
                this.dgvPermisosUsuario.Columns[e.ColumnIndex].Width = img.Width + 10;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvPermisosUsuario.Columns[e.ColumnIndex].Name == "EliminarPermiso" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvPermisosUsuario.Rows[e.RowIndex].Cells["EliminarPermiso"] as DataGridViewButtonCell;
                Bitmap bm = Resources.icons8_eliminar_26;
                Image img = bm;
                e.Graphics.DrawImage(img, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvPermisosUsuario.Rows[e.RowIndex].Height = img.Height + 10;
                this.dgvPermisosUsuario.Columns[e.ColumnIndex].Width = img.Width + 10;

                e.Handled = true;
            }

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            using (AgregarNuevoUsuario frm=new AgregarNuevoUsuario(session))
            {
                frm.ShowDialog();
            }
            this.Usuarios.Clear();
            this.Usuarios = null;
            //this.dgvUsuarios.Refresh();
            this.llenarDGVUsuarios();
        }
    }
}
