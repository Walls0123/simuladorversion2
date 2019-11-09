using CNegocio.Ventanilla;
using Modelos.Modelos;
using Sistema_Bancario.Ventanilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Bancario
{
    public partial class Cuotas : Base
    {
        private CuotasMethods GetCuotasMethods;
        private List<CronogramaPagosModel> CuotasModel;
        public Cuotas()
        {
            InitializeComponent();
           
            proceder1.BTProceder.Click += BTProceder_Click;
            //nro_Documento1.LblNombreControl.Text = "Nro Documento "+"\n"+"/ Nro Cuenta";
            
        }

        private void BTProceder_Click(object sender, EventArgs e)
        {
           if (GridCuotas.Rows.Count > 0 && nroCuenta1.ValidarEstadoCuenta() == true)
        {
            GetCuotasMethods = new CuotasMethods();
            int i = GridCuotas.CurrentCell.RowIndex;
            //   int i = GridCuotas.CurrentRow.Cells[0].Value;
            //  Convert.ToInt32(GridCuotas[i, 0].Value);
            StatusStrip o = this.TopLevelControl.Controls.Find("stStatus", true).FirstOrDefault() as StatusStrip;
                CuotasModel cuotas = new CuotasModel();
                cuotas.CuotaID = Convert.ToInt32(GridCuotas[0, i].Value);
                cuotas.Usuario = o.Items[1].Text;               
                cuotas.RowVer = CuotasModel[i].RowVer;
              //nroCuenta1.VersionCuenta
                var a=  GetCuotasMethods.CuotasInsert(cuotas);
                if (a.Equals("Transferido"))
                {
                    MessageBox.Show("Pago Realizado");
                    Recibo recibo = new Recibo();
                    recibo.Show();
                }
                else
                {
                    MessageBox.Show("No se realizo el pago: " + a);
                }
         }
        }

        private static Cuotas _instance;

        public static Cuotas getinstance()
        {
            if (_instance == null)
            {
                _instance = new Cuotas();
            }

            return _instance;
        }

        private void BTBuscarCuota_Click(object sender, EventArgs e)
        {

            GetCuotasMethods = new CuotasMethods();
            
       //     MessageBox.Show(GetCuotasMethods.ObtenerPrestamos(nroCuenta1.TBNroCuenta.Text).ToString());
            var bindingList = new BindingList<object>(GetCuotasMethods.ObtenerPrestamos(nroCuenta1.TBNroCuenta.Text));
            var source = new BindingSource(bindingList, null);
            GridPrestamos.DataSource = source;
           // this.GridPrestamos.DataSource = GetCuotasMethods.ObtenerPrestamos(nroCuenta1.TBNroCuenta.Text);
            //   this.GridPrestamos.DataSource = new BindingSource(GetCuotasMethods.ObtenerPrestamos(nroCuenta1.TBNroCuenta.Text));
        }

        private void GridPrestamos_SelectionChanged(object sender, EventArgs e)
        {
         //   DataGridViewRow selectedRow = GridPrestamos.Rows[e.];
          //  GridPrestamos.SelectedRows.
        }

        private void GridPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow selectedRow = GridPrestamos.Rows[i];
            int ID = (int)selectedRow.Cells[0].Value;
            //CuotasSelect          
            List<object> QuitarColumnas = new List<object>();
            CuotasModel = GetCuotasMethods.CuotasSelect(ID);
            for (i = 0; i < CuotasModel.Count(); i++)
            {
                var AnonymousType = new
                {
                    CuotasModel[i].Id,
                    CuotasModel[i].FechaCancelado,
                    CuotasModel[i].Monto,
                    CuotasModel[i].EstadoString
                };
                QuitarColumnas.Add(AnonymousType);
            }
            var bindingList = new BindingList<object>(QuitarColumnas);
            var source = new BindingSource(bindingList, null);
            GridCuotas.DataSource = source;
        }
    }
}
