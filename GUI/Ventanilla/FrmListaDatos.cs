using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bancario.Ventanilla
{
    public partial class FrmListaDatos : Form
    {
        public string val1 { get; set; }
        public string val2 { get; set; }
        public string val3 { get; set; }
        public string val4 { get; set; }
        public string val5 { get; private set; }

        public DataTable GetData { get; set; }

        public FrmListaDatos()
        {
            InitializeComponent();           
        }
        public FrmListaDatos(string text)
        {
            InitializeComponent();
            textBox1.Text = text;        
        }
        public class ListtoDataTable
        {
            public DataTable ToDataTable<T>(List<T> items)
            {
                DataTable dataTable = new DataTable(typeof(T).Name);
                //Get all the properties by using reflection   
                PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (PropertyInfo prop in Props)
                {
                    //Setting column names as Property names  
                    dataTable.Columns.Add(prop.Name);
                }
                foreach (T item in items)
                {
                    var values = new object[Props.Length];
                    for (int i = 0; i < Props.Length; i++)
                    {

                        values[i] = Props[i].GetValue(item, null);
                    }
                    dataTable.Rows.Add(values);
                }

                return dataTable;
            }
        }

        public void CrearLista<T>(List<T> ListaDatos)
        {
            if (ListaDatos != null)
            {
                ListtoDataTable lsttodt = new ListtoDataTable();
                GetData = lsttodt.ToDataTable(ListaDatos);

                var bindingList = new BindingList<T>(ListaDatos);
                var source = new BindingSource(bindingList, null);
                DGVlistaDatos.DataSource = source;               
                DGVlistaDatos.Refresh();
                DGVlistaDatos.Update();
            }           
        }

        private void DGVlistaDatos_SelectionChanged(object sender, EventArgs e)
        {
           // ataGridViewRow row = this.DGVlistaDatos.Rows[e.];
          //  Doc = row.Cells["NroDocumento"].Value.ToString();
        }

        private void DGVlistaDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          //  DataGridViewRow row = this.DGVlistaDatos.Rows[e.RowIndex];
          //  Doc = row.Cells["NroDocumento"].Value.ToString();
        }

        private void BTAceptar_Click(object sender, EventArgs e)
        {         
            if (DGVlistaDatos.CurrentCell != null)
            {
                int i = DGVlistaDatos.CurrentCell.RowIndex;
                try
                {
                    val1 = DGVlistaDatos[0, i].Value.ToString();
                    val2 = DGVlistaDatos[1, i].Value.ToString();
                    val3 = DGVlistaDatos[2, i].Value.ToString();
                    // val1 = DGVlistaDatos["NroDocumento", i].Value.ToString();
                    //  val2 = DGVlistaDatos["Nombres", i].Value.ToString() + " " + DGVlistaDatos["Apellidos", i].Value.ToString();
                }
                catch (Exception)
                {
                    
                }        
               
                this.Close();
            }      
        }

        private void FrmListaDatos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void BTCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListaDatos_Load(object sender, EventArgs e)
        {
            this.textBox1.Focus();
            this.ActiveControl = textBox1;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
          //  GetData.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "Cliente", textBox1.Text);
           
        }
    }
}
