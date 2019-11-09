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
using CNegocio.Plataforma;
using Modelos.Session;

namespace Sistema_Bancario.plataforma_controles
{
    public partial class NuevaMoneda : UserControl
    {
        #region Variables

        private string gUsuario;
        private BLTipoMoneda BLMoneda = new BLTipoMoneda();
        private TipoMonedaModel gMoneda;

        #endregion

        #region Constructor

        public NuevaMoneda(ISession sesion)
        {
            InitializeComponent();
            gUsuario = sesion.UserName;
            this.clearForm();
            this.modoInicial();
        }

        #endregion

        #region Metodos

        private void buscarObjeto(List<TipoMonedaModel> objetos)
        {
            string[][] orden = new string[2][];

            orden[0] = new string[] { "ID", "Codigo", "100" };
            orden[1] = new string[] { "Nombre", "Descripcion", "400" };

            if (objetos != null)
            {
                using (Ayuda.FormHelp2 formHelp1 = new Ayuda.FormHelp2())
                {
                    formHelp1.setList(objetos, orden);
                    formHelp1.ShowDialog();

                    if (formHelp1.EstaAceptado())
                    {
                        var dato = formHelp1.getObject<TipoMonedaModel>();
                        if (dato != null)
                        {
                            this.clearForm();
                            this.gMoneda = this.BLMoneda.GetTipoMonedaModel(dato.Id);
                            this.moneda2gui(this.gMoneda);
                            this.modoNuevo();
                            this.modoEdicion();
                        }
                    }
                }
            }
        }

        private TipoMonedaModel gui2moneda()
        {
            try
            {
                string descripcion = this.txtDescripcion.Text;

                return new TipoMonedaModel()
                {
                    Nombre = descripcion,
                    Usuario_creador = this.gUsuario,
                    Fecha_creacion = (DateTime)BLFechaHoraServidor.Obtener(),
                };
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void moneda2gui(TipoMonedaModel amoneda)
        {
            this.txtCodigo.Text = amoneda.Id.ToString();
            this.txtDescripcion.Text = amoneda.Nombre.ToString();

            this.SlblUsuario_creador.Text = amoneda.Usuario_creador;
            this.SlblFecha_creacion.Text = amoneda.Fecha_creacion.ToString();
            this.SlblUsuario_modificador.Text = amoneda.Usuario_modificador;
            this.SlblFecha_modificacion.Text = amoneda.Fecha_modificacion.ToString();
        }

        private void clearForm()
        {
            this.txtCodigo.Text = default(string);
            this.txtDescripcion.Text = default(string);

            this.SlblUsuario_creador.Text = "*";
            this.SlblFecha_creacion.Text = "*";
            this.SlblUsuario_modificador.Text = "*";
            this.SlblFecha_modificacion.Text = "*";
        }

        private void modoNuevo()
        {

            this.buttonActualizar.Enabled = false;
            this.buttonEliminar.Enabled = false;

            this.buttonNuevo.Enabled = false;
            this.buttonCrear.Enabled = true;
            this.buttonDeshacer.Enabled = true;

            this.btnCodigo.Enabled = false;
            this.btnDescripcion.Enabled = false;

            this.txtCodigo.Enabled = false;
            this.txtDescripcion.Enabled = true;
        }

        private void modoInicial()
        {
            this.buttonActualizar.Enabled = false;
            this.buttonEliminar.Enabled = false;

            this.buttonNuevo.Enabled = true;
            this.buttonCrear.Enabled = false;
            this.buttonDeshacer.Enabled = false;

            this.btnCodigo.Enabled = true;
            this.btnDescripcion.Enabled = true;


            this.txtCodigo.Enabled = true;
            this.txtDescripcion.Enabled = true;
        }

        private void modoEdicion()
        {
            this.buttonCrear.Enabled = false;
            this.buttonActualizar.Enabled = true;
            this.buttonEliminar.Enabled = true;
        }

        #endregion

        #region Eventos

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            this.clearForm();
            this.modoNuevo();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            var objeto = this.gui2moneda();

            if (objeto == null)
            {
                MessageBox.Show("Hay algunas incoherencias, por favor ingrese los datos correctos");
                return;
            }
            DialogResult result = MessageBox.Show("¿Está seguro que desea crear la moneda? No se podrá eliminar tan facilmemte", "Advertencia", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (this.BLMoneda.Insert(objeto))
                {
                    this.clearForm();
                    this.modoInicial();
                    MessageBox.Show("El proceso ha sido correcto");
                }
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            var objeto = this.gui2moneda();

            if (objeto == null)
            {
                MessageBox.Show("Se detectan algunas incoherencias, por favor ingresa valores correctos");
                return;
            }

            objeto.Id = this.gMoneda.Id;
            objeto.Usuario_creador = this.gMoneda.Usuario_creador;
            objeto.Fecha_creacion = this.gMoneda.Fecha_creacion;
            objeto.Usuario_modificador = this.gUsuario;
            objeto.Fecha_modificacion = BLFechaHoraServidor.Obtener();

            DialogResult result = MessageBox.Show("¿Está seguro que quiere cambiar los valores? Puede afectar las futuras transacciones", "Advertencia", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (this.BLMoneda.Update(objeto))
                {
                    MessageBox.Show("El proceso ha sido correcto");
                    this.clearForm();
                    this.modoInicial();
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (this.gMoneda == null)
            {
                MessageBox.Show("No se pudo obtener la moneda desde base de datos");
                return;
            }
            DialogResult result = MessageBox.Show("¿Está seguro que quiere eliminar esta moneda? Puede afectar las transacciones", "Advertencia", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (this.BLMoneda.Delete(this.gMoneda.Id))
                {
                    this.clearForm();
                    this.modoInicial();
                    MessageBox.Show("El proceso ha sido correcto");
                }
                else
                {
                    MessageBox.Show("La moneda esta siendo usada en transacciones, no puede ser eliminada");
                }
            }
        }

        private void buttonDeshacer_Click(object sender, EventArgs e)
        {
            this.clearForm();
            this.modoInicial();
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            string codigo = this.txtCodigo.Text;

            var objeto = this.BLMoneda.TipoMonedaModelSelectbyId(codigo);

            if (objeto == null || objeto.Count <= 0)
            {
                MessageBox.Show("No se han encontrado resultados");
                return;
            }
            this.buscarObjeto(objeto);
        }

        private void btnDescripcion_Click(object sender, EventArgs e)
        {
            string desc = this.txtCodigo.Text;

            var objeto = this.BLMoneda.TipoMonedaModelSelectbyDescripcion(desc);

            if (objeto == null || objeto.Count <= 0)
            {
                MessageBox.Show("No se han encontrado resultados");
                return;
            }
            this.buscarObjeto(objeto);
        }

        #endregion
    
    }
}
