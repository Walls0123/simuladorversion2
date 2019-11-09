using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bancario.Ventanilla
{
    public partial class FrmListadeDatos : Form
    {
        public FrmListadeDatos()
        {                     
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void WriteMyItems<T>(T pAllMyItems)
        {
            if (pAllMyItems != null)
            {
             //   var bindingList = new B<T>(pAllMyItems);
                var source = new BindingSource(pAllMyItems, null);
                GVListaDatos.DataSource = source;
            }
        }
    }
}
