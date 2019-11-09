using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CNegocio.Ventanilla;
using Modelos.Modelos;
using Sistema_Bancario.Ventanilla;

namespace Sistema_Bancario.Froms_opciones
{
    public partial class Servicios : Sistema_Bancario.Base
    {
        //private PagoServiciosModel gPagomodels;
        //private EmpresaModel gEmpresaModel;
        List<RecaudosModel> recaudosModels;
        public Servicios()
        {
            InitializeComponent();
            proceder1.BTProceder.Click += BTProceder_Click;
            dni1.TBDni.TextChanged += TBDni_TextChanged;
        }

        private void TBDni_TextChanged(object sender, EventArgs e)
        {         
            EmpresaMethods empresaMethods = new EmpresaMethods();
            recaudosModels = empresaMethods.RecaudosbyNroDocumento(dni1.TBDni.Text);

            List<object> QuitarColumnas = new List<object>();
            for (int i = 0; i < recaudosModels.Count(); i++)
            {
                var AnonymousType = new
                {
                    recaudosModels[i].Nro_contrato,
                    recaudosModels[i].Monto,
                    recaudosModels[i].Fecha_vencimiento,
                    recaudosModels[i].Estado_recaudo
                };
                QuitarColumnas.Add(AnonymousType);
            }

            var source = new BindingSource(QuitarColumnas, null);
            GNroContrato.DataSource = source;           
        }

        private void BTProceder_Click(object sender, EventArgs e)
        {
         if (GNroContrato.Rows.Count > 0)
         {
            PagoServicioMethods pagoServicioMethods = new PagoServicioMethods();
            int i = GNroContrato.CurrentCell.RowIndex;
            StatusStrip o = this.TopLevelControl.Controls.Find("stStatus", true).FirstOrDefault() as StatusStrip;//o.Items[1].Text;
                RecaudosModel recaudos = new RecaudosModel();
                recaudos.Nro_contrato = Convert.ToInt32(nroContrato1.TBNroContrato.Text);
                recaudos.RowVersion = recaudosModels[i].RowVersion;
                var a = pagoServicioMethods.InsertPagoServicio(recaudos, o.Items[1].Text);
                if (a.Equals("Cobrado"))
                {
                    MessageBox.Show("Se realizo el pago correctamente");
                    Recibo recibo = new Recibo();
                    recibo.Show();
                }
                else
                {
                    MessageBox.Show("Erro: "+a);
                }
         }
        }

        private static Servicios _instance;
        public static Servicios instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Servicios();
                }

                return _instance;
            }
        }

        private void BTBuscarEmpresa_Click(object sender, EventArgs e)
        {
            EmpresaMethods empresaMethods = new EmpresaMethods();
          
            GEmpresas.DataSource = empresaMethods.BuscarEmpresa(empresa1.TBEmpresa.Text);

        }
        private void BTNroContrato_Click(object sender, EventArgs e)
        {
            if (GEmpresas.Rows.Count > 0)
            {
                if (string.IsNullOrEmpty(nroContrato1.TBNroContrato.Text)) { return; }


                EmpresaMethods empresaMethods = new EmpresaMethods();

                int i = GEmpresas.CurrentCell.RowIndex;
                List<object> QuitarColumnas = new List<object>();
                recaudosModels = empresaMethods.PagoServicioEmpresa(Convert.ToInt32(GEmpresas[0, i].Value), Convert.ToInt32(nroContrato1.TBNroContrato.Text));
                for (i = 0; i < recaudosModels.Count(); i++)
                {
                    var AnonymousType = new
                    {
                        recaudosModels[i].Nro_contrato,
                        recaudosModels[i].Monto,
                        recaudosModels[i].Fecha_vencimiento,
                        recaudosModels[i].Estado_recaudo
                    };
                    QuitarColumnas.Add(AnonymousType);
                }

                var source = new BindingSource(QuitarColumnas, null);
                GNroContrato.DataSource = source;
            }
            else
            {
                MessageBox.Show("Haga busqueda de una empresa");
            }
        }
        private void GNroContrato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = GNroContrato.CurrentCell.RowIndex;
                nroContrato1.TBNroContrato.Text = recaudosModels[0].Nro_contrato.ToString();

            }
            catch (Exception)
            {

            }
        }
    }
}
