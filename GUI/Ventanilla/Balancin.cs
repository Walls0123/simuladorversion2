using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Bancario.Clases;
using Modelos.Session;
using Modelos.Modelos;
using System.Drawing.Printing;

namespace Sistema_Bancario.Ventanilla
{
    public partial class Balancin : UserControl
    {

        public ISession session;
        private int IndiceDataGrid = 0;
        private int SumaTotal = 0;
        public Balancin(ISession sesion)
        {
            this.session = sesion;
            InitializeComponent();
            this.BackColor = Color.White;
            //this.CargarComboMoneda();
            //this.CargarComboRolesSujetos();
            this.CargarComboSujetos();
            this.CargarTipoMovimiento();
            this.CargarDgvSoles();
            this.CargarDgvDolares();
        }
        private Balancin()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            //this.CargarComboMoneda();
            //this.CargarComboRolesSujetos();
            this.CargarComboSujetos();
            this.CargarTipoMovimiento();
            this.CargarDgvSoles();
            this.CargarDgvDolares();

        }
        private static Balancin _instance;
        public static Balancin instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Balancin();
                }

                return _instance;
            }
        }
        private void CargarDgvSoles()
        {
            dgvSoles.Rows.Add("10 soles",0,0);
            dgvSoles.Rows.Add("20 soles", 0, 0);
            dgvSoles.Rows.Add("50 soles", 0, 0);
            dgvSoles.Rows.Add("100 soles", 0, 0);
            dgvSoles.Rows.Add("200 soles", 0, 0);
        }
        private void CargarDgvDolares()
        {
            dgvDolares.Rows.Add("1 dolares", 0, 0);
            dgvDolares.Rows.Add("2 dolares", 0, 0);
            dgvDolares.Rows.Add("5 dolares", 0, 0);
            dgvDolares.Rows.Add("10 dolares", 0, 0);
            dgvDolares.Rows.Add("20 dolares", 0, 0);
            dgvDolares.Rows.Add("50 dolares", 0, 0);
            dgvDolares.Rows.Add("100 dolares", 0, 0);
        }
        private void CargarComboSujetos()
        {
            try
            {
                using (WsSistemaBancario.VentanillaServiceClient ventanilla = new WsSistemaBancario.VentanillaServiceClient())
                {
                    this.cmbVentanillas.DataSource = ventanilla.GetVentanillasXSucursal(Convert.ToInt32(this.session.SucursalCodigo), Convert.ToInt32(this.session.Turno.Id));
                    this.cmbVentanillas.ValueMember = "Id_ventanilla";
                    this.cmbVentanillas.DisplayMember = "Descripcion";
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al cargar ventanillas en el combo");
               
            }
            
        }
        private void CargarTipoMovimiento()
        {
            this.cmbTipoMov.DataSource =TipoMovimiento.Instance.Movimientos;
        }

        //private void btnAgregar_Click(object sender, EventArgs e)
        //{
        //    this.SumaTotal = 0;
        //    int n = dgvDenominaciones.Rows.Add();
        //    this.dgvDenominaciones.Rows[n].Cells[0].Value = this.CmbDenominaciones.SelectedValue;
        //    this.dgvDenominaciones.Rows[n].Cells[1].Value = this.nudNroBilletes.Value;
        //    this.dgvDenominaciones.Rows[n].Cells[2].Value = this.CalcularImporte((string)this.CmbDenominaciones.SelectedValue, (int)this.nudNroBilletes.Value);

        //    //calcular el total

        //    foreach (DataGridViewRow r in dgvDenominaciones.Rows)
        //    {
        //        SumaTotal = SumaTotal+(int)r.Cells[2].Value;
        //    }
        //    this.txtTotal.Text = this.SumaTotal.ToString();
        //}
        /// <summary>
        /// calcula el monto de importe segun la denominacion de moneda y la cantidad
        /// </summary>
        /// <param name="deno">denominacion del billete</param>
        /// <param name="cant">cantidad de billetes</param>
        /// <returns>importe=deno*cant</returns>
        private int CalcularImporte(string deno,int cant)
        {
            switch (deno)
            {
                case "1 dolar":
                    return 1 * cant;
                case "2 dolares":
                    return 2 * cant;   
                case "5 dolares":
                    return 5 * cant;
                case "10 dolares":
                    return 10 * cant;
                case "20 dolares":
                    return 20 * cant;
                case "50 dolares":
                    return 50 * cant;
                case "100 dolares":
                    return 100 * cant;
                case "10 soles":
                    return 10 * cant;
                case "20 soles":
                    return 20 * cant;
                case "50 soles":
                    return 50 * cant;
                case "100 soles":
                    return 100 * cant;
                case "200 soles":
                    return 200 * cant;
            }
            return cant;
        }

        private void dgvDenominaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndiceDataGrid = e.RowIndex;
            if (e.RowIndex != -1)
            {
                IndiceDataGrid = e.RowIndex;
            }

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            this.SumaTotal = 0;
            if (this.dgvSoles.Rows.Count-1>=IndiceDataGrid & IndiceDataGrid!=-1)
            {
                this.dgvSoles.Rows.RemoveAt(IndiceDataGrid);
            }
            foreach (DataGridViewRow r in dgvSoles.Rows)
            {
                SumaTotal = SumaTotal + (int)r.Cells[2].Value;
            }
            this.txtTotalSoles.Text = this.SumaTotal.ToString();
        }

        private void btnRegistrarMov_Click(object sender, EventArgs e)
        {
            //using (WsSistemaBancario. ventanilla = new WsSistemaBancario.VentanillaServiceClient())
            //{

            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void dgvSoles_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                try
                {
                    int result = Convert.ToInt32(e.FormattedValue);
                    dgvSoles.Rows[e.RowIndex].ErrorText = String.Empty;
                    result = this.CalcularImporte(dgvSoles.Rows[e.RowIndex].Cells[0].Value.ToString(),result);
                    dgvSoles.Rows[e.RowIndex].Cells[2].Value = result;
                    int importe=0;
                    foreach (DataGridViewRow r in dgvSoles.Rows)
                    {
                        importe += (int)r.Cells[2].Value;
                    }
                    this.txtTotalSoles.Text = importe.ToString();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Las celdas solo permiten números!","Dato incorrecto",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    dgvSoles.Rows[e.RowIndex].ErrorText = "El dato introducido no es de tipo numero";
                    e.Cancel = true;
                }
            }
        }

        private void dgvDolares_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                try
                {
                    int result = Convert.ToInt32(e.FormattedValue);
                    dgvDolares.Rows[e.RowIndex].ErrorText = String.Empty;
                    result = this.CalcularImporte(dgvDolares.Rows[e.RowIndex].Cells[0].Value.ToString(), result);
                    dgvDolares.Rows[e.RowIndex].Cells[2].Value = result;
                    int importe = 0;
                    foreach (DataGridViewRow r in dgvDolares.Rows)
                    {
                        importe += (int)r.Cells[2].Value;
                    }
                    this.txtTotalDolares.Text = importe.ToString();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Las celdas solo permiten números!", "Dato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvDolares.Rows[e.RowIndex].ErrorText = "El dato introducido no es de tipo numero";
                    e.Cancel = true;
                }
            }
        }

        private void btnRegistrarMov_Click_1(object sender, EventArgs e)
        {
            int identity;
            using (WsSistemaBancario.CajaChicaServiceClient caja = new WsSistemaBancario.CajaChicaServiceClient())
            {
                Modelos.Modelos.CajaChicaModel cc = new CajaChicaModel();
                cc.Id_TurnoUsuario1 = Convert.ToInt32(session.Turno.IdTurUsu);
                cc.Id_TurnoUsuario2 = Convert.ToInt32(this.cmbVentanillas.SelectedValue);
                string tipo = cmbTipoMov.SelectedValue.ToString();
                cc.Tipo_Accion = (tipo.Equals("Cargo") ? "C" : "A");

                identity = caja.Crear(cc, Convert.ToInt32(session.UserCodigo));
                if (identity == 0)
                {
                    MessageBox.Show("No se pudo registrar la cabecera!");
                    return;
                }
            }
            using (WsSistemaBancario.DetalleCajaChicaServiceClient de_cc = new WsSistemaBancario.DetalleCajaChicaServiceClient())
            {
                bool exito = false;
                foreach (DataGridViewRow r in dgvSoles.Rows)
                {
                    int col = Convert.ToInt32(r.Cells[1].Value);
                    if (col != 0)
                    {
                        Modelos.Modelos.DetalleCajaChicaModel det = new DetalleCajaChicaModel();
                        det.Id_CajaChica = identity;
                        det.Denominacion = this.DevuelveDenominacionNumero(r.Cells[0].Value.ToString());
                        det.Cantidad = Convert.ToInt32(r.Cells[1].Value.ToString());
                        det.Moneda = "S";
                        exito = de_cc.DetalleCajaChica_Crear(det, Convert.ToInt32(session.UserCodigo));
                    }
                }
                foreach (DataGridViewRow r in dgvDolares.Rows)
                {
                    int col = Convert.ToInt32(r.Cells[1].Value);
                    if (col != 0)
                    {
                        Modelos.Modelos.DetalleCajaChicaModel det = new DetalleCajaChicaModel();
                        det.Id_CajaChica = identity;
                        det.Denominacion = this.DevuelveDenominacionNumero(r.Cells[0].Value.ToString());
                        det.Cantidad = Convert.ToInt32(r.Cells[1].Value.ToString());
                        det.Moneda = "D";
                        exito = de_cc.DetalleCajaChica_Crear(det, Convert.ToInt32(session.UserCodigo));
                    }
                }
                if (!exito)
                {
                    MessageBox.Show("No se registró correctamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Se registró correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private int DevuelveDenominacionNumero(string deno)
        {
            switch (deno)
            {
                case "1 dolar":
                    return 1;
                case "2 dolares":
                    return 2;
                case "5 dolares":
                    return 5;
                case "10 dolares":
                    return 10;
                case "20 dolares":
                    return 20;
                case "50 dolares":
                    return 50;
                case "100 dolares":
                    return 100;
                case "10 soles":
                    return 10;
                case "20 soles":
                    return 20;
                case "50 soles":
                    return 50;
                case "100 soles":
                    return 100;
                case "200 soles":
                    return 200;
            }
            return 0;
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printTicket = new System.Drawing.Printing.PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printTicket.PrinterSettings = ps;
            printTicket.PrintPage += PrintTicket_PrintPage;
            printTicket.Print();
        }

        private void PrintTicket_PrintPage(object sender, PrintPageEventArgs e)
        {
            Point ini = new Point(100,50);
            e.Graphics.DrawString("BALANCÍN",new Font("Arial",10,FontStyle.Bold),Brushes.Black,ini.X+35,ini.Y);
            e.Graphics.DrawString("__________________", new Font("Arial", 10, FontStyle.Bold), Brushes.Black,ini.X,ini.Y);
            e.Graphics.DrawString("Tipo Movimiento:", new Font("Arial", 5, FontStyle.Bold), Brushes.Black, ini.X, ini.Y+=20);
            e.Graphics.DrawString(cmbTipoMov.SelectedValue.ToString(), new Font("Arial", 5, FontStyle.Regular), Brushes.Black, ini.X+70, ini.Y);
            e.Graphics.DrawString("De:", new Font("Arial", 5, FontStyle.Bold), Brushes.Black, ini.X, ini.Y+=20);
            e.Graphics.DrawString(session.VentanillaDescripcion, new Font("Arial", 5, FontStyle.Regular), Brushes.Black, ini.X + 70, ini.Y);
            e.Graphics.DrawString("Para:", new Font("Arial", 5, FontStyle.Bold), Brushes.Black, ini.X, ini.Y+=20);
            e.Graphics.DrawString(cmbVentanillas.Text.ToString(), new Font("Arial", 5, FontStyle.Regular), Brushes.Black, ini.X + 70, ini.Y);
            e.Graphics.DrawString("__________________", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, ini.X, ini.Y);
            e.Graphics.DrawString("Soles:", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, ini.X,ini.Y+=20);
            //cabecera de denominacion de soles
            e.Graphics.DrawString("Denominación", new Font("Arial", 5, FontStyle.Regular), Brushes.Black, ini.X, ini.Y+=20);
            e.Graphics.DrawString("Cantidad", new Font("Arial", 5, FontStyle.Regular), Brushes.Black, ini.X+60, ini.Y);
            e.Graphics.DrawString("Subtotal", new Font("Arial", 5, FontStyle.Regular), Brushes.Black, ini.X+120, ini.Y);
            e.Graphics.DrawString("--------------------------------------------------------------", new Font("Arial", 5, FontStyle.Regular), Brushes.Black, ini.X, ini.Y+=7);
            foreach (DataGridViewRow r in dgvSoles.Rows)
            {
                int col = Convert.ToInt32(r.Cells[1].Value);
                if (col != 0)
                {
                    e.Graphics.DrawString(r.Cells[0].Value.ToString(), new Font("Arial", 5, FontStyle.Regular), Brushes.Black, ini.X,ini.Y+=20);
                    e.Graphics.DrawString(r.Cells[1].Value.ToString(), new Font("Arial", 5, FontStyle.Regular), Brushes.Black, ini.X+60, ini.Y );
                    e.Graphics.DrawString(r.Cells[2].Value.ToString(), new Font("Arial", 5, FontStyle.Regular), Brushes.Black, ini.X+120, ini.Y );
                }
            }
            e.Graphics.DrawString("--------------------------------------------------------------", new Font("Arial", 5, FontStyle.Regular), Brushes.Black, ini.X, ini.Y += 7);
            //subtotal de soles
            e.Graphics.DrawString("Total soles:", new Font("Arial", 5, FontStyle.Regular), Brushes.Black, ini.X + 60, ini.Y+=20);
            e.Graphics.DrawString(txtTotalSoles.Text, new Font("Arial", 5, FontStyle.Regular), Brushes.Black, ini.X + 120, ini.Y);
            //------------------
            e.Graphics.DrawString("Dólares:", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, ini.X, ini.Y += 20);
            //cabecera de denominacion de soles
            e.Graphics.DrawString("Denominación", new Font("Arial", 5, FontStyle.Regular), Brushes.Black, ini.X, ini.Y += 20);
            e.Graphics.DrawString("Cantidad", new Font("Arial", 5, FontStyle.Regular), Brushes.Black, ini.X + 60, ini.Y);
            e.Graphics.DrawString("Subtotal", new Font("Arial", 5, FontStyle.Regular), Brushes.Black, ini.X + 120, ini.Y);
            e.Graphics.DrawString("--------------------------------------------------------------", new Font("Arial", 5, FontStyle.Regular), Brushes.Black, ini.X, ini.Y += 7);
            foreach (DataGridViewRow r in dgvDolares.Rows)
            {
                int col = Convert.ToInt32(r.Cells[1].Value);
                if (col != 0)
                {
                    e.Graphics.DrawString(r.Cells[0].Value.ToString(), new Font("Arial", 5, FontStyle.Regular), Brushes.Black, ini.X, ini.Y += 20);
                    e.Graphics.DrawString(r.Cells[1].Value.ToString(), new Font("Arial", 5, FontStyle.Regular), Brushes.Black, ini.X + 60, ini.Y);
                    e.Graphics.DrawString(r.Cells[2].Value.ToString(), new Font("Arial", 5, FontStyle.Regular), Brushes.Black, ini.X + 120, ini.Y);
                }
            }
            e.Graphics.DrawString("--------------------------------------------------------------", new Font("Arial", 5, FontStyle.Regular), Brushes.Black, ini.X, ini.Y += 7);
            //subtotal de soles
            e.Graphics.DrawString("Total dólares:", new Font("Arial", 5, FontStyle.Regular), Brushes.Black, ini.X + 60, ini.Y += 20);
            e.Graphics.DrawString(txtTotalDolares.Text, new Font("Arial", 5, FontStyle.Regular), Brushes.Black, ini.X + 120, ini.Y);
            //------------------
        }
    }
}
