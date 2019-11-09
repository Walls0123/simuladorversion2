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
using Sistema_Bancario.Properties;

namespace Sistema_Bancario.Administrador
{
    public partial class Permisos : UserControl
    {
        public Permisos()
        {
            InitializeComponent();
            this.pnlPrincipal.Location = new Point(70, 30);
            this.pnlSecundario.Location = new Point(70, 30);
            this.pnlAgregar.Location = new Point(70, 30);
           // this.pnlAgregarPermisos.Location = new Point(70, 30);
            this.pnlAgregarRoles.Location = new Point(200, 80);
            this.pnlAgregarUsuarios.Location = new Point(200, 80);
            this.BackColor = Color.White;
            Listar_Componentes();
            pnlPrincipal.BringToFront();
            pnlSecundario.SendToBack();
            pnlAgregar.SendToBack();
           // pnlAgregarPermisos.SendToBack();
            //pnlAgregarUsuario.SendToBack();                                          
            //cmbRoles.SelectedItem = null;                                            
            //llenarComboBox();                                                        
            //llenarDGVPermisos();  
        }

        private static Permisos _instance;
        public static Permisos instance
        {

            get
            {
                if (_instance == null)
                {
                    _instance = new Permisos();
                }

                return _instance;

            }
        }

        public List<RolesModel> roles_list;
        public List<ComponenteModel> componentes_list;
        public List<PersonaModel> personas_list;
        public int idRol;
        public int idComponente_selected;


        private void Listar_Componentes()
        {
            try
            {

                using (WsSistemaBancario.ComponenteServiceClient componente = new WsSistemaBancario.ComponenteServiceClient())
                {

                    componentes_list = componente.Componente_ObtenerTodos().ToList();
                    foreach (var p in componentes_list)
                    {
                        dgvPermisos.Rows.Add(p.Nombre, p.Codigo, p.Estado);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar componentes", "Componentes");
            }
        }

        private void ListaRolesXIdComponente(int idComponente)
        {
            try
            {
                using (WsSistemaBancario.RolesServiceClient rol = new WsSistemaBancario.RolesServiceClient())
                {

                    roles_list = rol.Roles_ObtenerTodos().ToList();
                    foreach (var p in roles_list)
                    {
                        dgvRoles.Rows.Add(p.Descripcion);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar roles", "Roles");
            }
        }

        private void ListarUsuariosXIdComponente(int idComponente)
        {
            try
            {

                using (WsSistemaBancario.PersonaServiceClient persona = new WsSistemaBancario.PersonaServiceClient())
                {

                    personas_list = persona.Persona_ObtenerTodos().ToList();
                    foreach (var p in personas_list)
                    {
                        dgvUsuarios.Rows.Add(p.Nombreusuario + " " + p.Apellidos, p.Nrodocumento, p.Estado);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar Usuarios", "Usuarios");
            }
        }

        private void dgvComponentes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string nombreComponente = dgvPermisos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

                idComponente_selected = (from a in componentes_list
                                         where a.Nombre == nombreComponente
                                         select a.Id).FirstOrDefault();
                pnlPrincipal.SendToBack();
                pnlAgregar.SendToBack();
                pnlSecundario.BringToFront();
                ListarUsuariosXIdComponente(2);
                ListaRolesXIdComponente(2);
            }
        }

        private void dgvComponentes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvPermisos.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvPermisos.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;
                Bitmap bm = Resources.icons8_editar_26;
                Image img = bm;
                e.Graphics.DrawImage(img, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvPermisos.Rows[e.RowIndex].Height = img.Height + 10;
                this.dgvPermisos.Columns[e.ColumnIndex].Width = img.Width + 10;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvPermisos.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvPermisos.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                Bitmap bm = Resources.icons8_eliminar_26;
                Image img = bm;
                e.Graphics.DrawImage(img, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvPermisos.Rows[e.RowIndex].Height = img.Height + 10;
                this.dgvPermisos.Columns[e.ColumnIndex].Width = img.Width + 10;

                e.Handled = true;
            }
        }

        private void dgvUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvUsuarios.Columns[e.ColumnIndex].Name == "Editar3" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvUsuarios.Rows[e.RowIndex].Cells["Editar3"] as DataGridViewButtonCell;
                Bitmap bm = Resources.icons8_editar_26;
                Image img = bm;
                e.Graphics.DrawImage(img, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvUsuarios.Rows[e.RowIndex].Height = img.Height + 10;
                this.dgvUsuarios.Columns[e.ColumnIndex].Width = img.Width + 10;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvUsuarios.Columns[e.ColumnIndex].Name == "Eliminar3" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvUsuarios.Rows[e.RowIndex].Cells["Eliminar3"] as DataGridViewButtonCell;
                Bitmap bm = Resources.icons8_eliminar_26;
                Image img = bm;
                e.Graphics.DrawImage(img, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvUsuarios.Rows[e.RowIndex].Height = img.Height + 10;
                this.dgvUsuarios.Columns[e.ColumnIndex].Width = img.Width + 10;

                e.Handled = true;
            }
        }

        private void dgvRoles_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvRoles.Columns[e.ColumnIndex].Name == "Editar4" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvRoles.Rows[e.RowIndex].Cells["Editar4"] as DataGridViewButtonCell;
                Bitmap bm = Resources.icons8_editar_26;
                Image img = bm;
                e.Graphics.DrawImage(img, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvRoles.Rows[e.RowIndex].Height = img.Height + 10;
                this.dgvRoles.Columns[e.ColumnIndex].Width = img.Width + 10;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvRoles.Columns[e.ColumnIndex].Name == "Eliminar4" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvRoles.Rows[e.RowIndex].Cells["Eliminar4"] as DataGridViewButtonCell;
                Bitmap bm = Resources.icons8_eliminar_26;
                Image img = bm;
                e.Graphics.DrawImage(img, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvRoles.Rows[e.RowIndex].Height = img.Height + 10;
                this.dgvRoles.Columns[e.ColumnIndex].Width = img.Width + 10;

                e.Handled = true;
            }
        }

        private ComponenteModel componenteActualizar;

        private void dgvComponentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (this.dgvPermisos.Columns[e.ColumnIndex].Name == "Editar")
                {
                    string nombreComponente = dgvPermisos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

                    componenteActualizar = (from a in componentes_list
                                            where a.Nombre == nombreComponente
                                            select a).FirstOrDefault();
                    frmAgregarPermiso p = new frmAgregarPermiso(true,componenteActualizar);
                    p.ShowDialog();
                    Listar_Componentes();
                }
                if (this.dgvPermisos.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    MessageBox.Show("Eliminar");
                }
                if (this.dgvPermisos.Columns[e.ColumnIndex].Name == "Estado")
                {
                    DataGridViewCheckBoxCell chk = this.dgvPermisos.Rows[e.RowIndex].Cells["Estado"] as DataGridViewCheckBoxCell;
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

        public List<ComponenteModel> permisos;
        private void llenarDGVPermisos()

        {

            try
            {

                using (WsSistemaBancario.ComponenteServiceClient PermisosRol = new WsSistemaBancario.ComponenteServiceClient())
                {




                    permisos = PermisosRol.Componente_ObtenerComponentesRol(4).ToList();

                    dgvPermisos.DataSource = permisos;

                }

            }

            catch (Exception)
            {

            }



        }

        private void btnAgregarNuevoComponente_Click(object sender, EventArgs e)
        {
        }

        private void btnAgregarPermiso_Click(object sender, EventArgs e)
        {
            frmAgregarPermiso p = new frmAgregarPermiso(false);
            p.ShowDialog();
            Listar_Componentes();
        }
        private void MostrarActualizarPermiso()
        {
           // agregarPermisosNuevos();
           // btnAgregarNuevoComponente.Text = "Actualizar";
           // cNuevo = false;
        }

        private void agregarPermisosNuevos()
        {
          // txtCodigoAgregar.Text = "";
          // txtNombeAgregar.Text = "";
          // txtDescripcionAgregar.Text = "";
          // txtCodigoAgregar.Text = "";
          // pnlPrincipal.SendToBack();
          // pnlSecundario.SendToBack();
          // pnlAgregar.SendToBack();
          // pnlAgregarPermisos.BringToFront();
          // cmbComponentesPadreAgregar.DataSource = componentes_list;
          // cmbComponentesPadreAgregar.ValueMember = "Id";
          // cmbComponentesPadreAgregar.DisplayMember = "Nombre";
        }

        private void BtnCancelarAgregarComponente_Click(object sender, EventArgs e)
        {
           // pnlPrincipal.BringToFront();
           // pnlSecundario.SendToBack();
           // pnlAgregar.SendToBack();
           // pnlAgregarPermisos.SendToBack();

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            pnlPrincipal.BringToFront();
            pnlSecundario.SendToBack();
            pnlAgregar.SendToBack();
           // pnlAgregarPermisos.SendToBack();
        }

        private void btnAgregarRoles_Click(object sender, EventArgs e)
        {
            pnlPrincipal.SendToBack();
            pnlSecundario.SendToBack();
            pnlAgregar.BringToFront();
            pnlAgregarRoles.BringToFront();
            pnlAgregarUsuarios.SendToBack();
           // pnlAgregarPermisos.SendToBack();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnlPrincipal.SendToBack();
            pnlSecundario.BringToFront();
            pnlAgregar.SendToBack();
            pnlAgregarRoles.BringToFront();
            pnlAgregarUsuarios.SendToBack();
           // pnlAgregarPermisos.SendToBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlPrincipal.SendToBack();
            pnlSecundario.BringToFront();
            pnlAgregar.SendToBack();
            pnlAgregarRoles.BringToFront();
            pnlAgregarUsuarios.SendToBack();
           // pnlAgregarPermisos.SendToBack();
        }

        private void btnAgregarUsuarios_Click(object sender, EventArgs e)
        {
            pnlPrincipal.SendToBack();
            pnlSecundario.SendToBack();
            pnlAgregar.BringToFront();
            pnlAgregarRoles.SendToBack();
            pnlAgregarUsuarios.BringToFront();
           // pnlAgregarPermisos.SendToBack();
        }



    }
}