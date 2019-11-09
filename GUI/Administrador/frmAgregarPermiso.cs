using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bancario.Administrador
{
    public partial class frmAgregarPermiso : Form
    {
        private ComponenteModel _componente;
        private bool _editar;
        public frmAgregarPermiso(bool editar, ComponenteModel componente = null)
        {
            InitializeComponent();
            llenarCombo();
            if (editar)
            {
                lblTitulo.Text = "Editar Permiso";
                btnAgregar.Text = "Actualizar";
                this._componente = componente;
                this._editar= editar;
                txtNombe.Text = componente.Nombre;
                txtDescripcion.Text = componente.Descripcion;
                txtCodigo.Text = componente.Codigo;
                txtNombe.Text = componente.Nombre;
                checkEstado.Checked = componente.Estado;
                if (componente.IdPadre == null)
                {
                    checkPadre.Checked = true;
                    cmbPadre.SelectedIndex = 1;
                } else
                {
                    checkPadre.Checked = false;
                    cmbPadre.SelectedIndex = (int)componente.IdPadre;
                }
            }
            else
            {
                lblTitulo.Text = "Agregar Permiso";
                btnAgregar.Text = "Agregar +";
            }
        }

        public void Actualizar()
        {
            try
            {
                using (WsSistemaBancario.ComponenteServiceClient componente = new WsSistemaBancario.ComponenteServiceClient())
                {
                    _componente.Nombre = txtNombe.Text;
                    _componente.Descripcion = txtDescripcion.Text;
                    _componente.Id_aplicacion = 1;
                    _componente.Estado = (checkEstado.Checked) ? true : false;
                    if (checkPadre.Checked)
                    {
                        _componente.IdPadre = null;
                    }
                    else
                    {
                        _componente.IdPadre = (int)cmbPadre.SelectedIndex;
                    }

                    if (!(componente.Componente_Editar(_componente, 8)))
                    {
                        MessageBox.Show("Error al actualizar Dato");
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public void Agregar()
        {
            try
            {
                using (WsSistemaBancario.ComponenteServiceClient componente = new WsSistemaBancario.ComponenteServiceClient())
                {
                   ComponenteModel nuevoComponente = new ComponenteModel
                   {
                       Nombre = txtNombe.Text,
                       Codigo = txtCodigo.Text,
                       Descripcion = txtDescripcion.Text,
                       Id_aplicacion = 1,
                       Estado = (checkEstado.Checked) ? true : false,
                   };
                    if (checkPadre.Checked)
                    {
                        nuevoComponente.IdPadre = null;
                    }
                    else
                    {
                        nuevoComponente.IdPadre = (int)cmbPadre.SelectedIndex;
                    }

                    if (!(componente.Componente_Crear(nuevoComponente, 8)))
                   {
                       MessageBox.Show("Error al registrar Dato");
                   }
                }
            }
            catch (Exception)
            {
            }
        }

        public void llenarCombo()
        {
            try
            {
                using (WsSistemaBancario.ComponenteServiceClient componente = new WsSistemaBancario.ComponenteServiceClient())
                {

                    cmbPadre.DataSource = componente.Componente_ObtenerTodos().ToList();
                    cmbPadre.ValueMember = "Id";
                    cmbPadre.DisplayMember = "Nombre";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar componentes", "Componentes");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (_editar)
            {
                Actualizar();
            }
            else
            {
                Agregar();
            }
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkPadre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPadre.Checked) 
            {
                cmbPadre.Enabled = false;
            }
            else
            {
                cmbPadre.Enabled = true;
            }
        }
    }
}
