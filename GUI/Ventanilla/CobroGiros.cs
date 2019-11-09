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

namespace Sistema_Bancario.Froms_opciones
{
    public partial class CobroGiros :Base
    {
        public CobroGiros()
        {
            InitializeComponent();
            proceder1.BTProceder.Click += BTProceder_Click;
        }

        private void BTProceder_Click(object sender, EventArgs e)
        {

         if (GVCobroGiros.Rows.Count > 0)
         {



            GirosMethods girosMethods = new GirosMethods();
            int i = GVCobroGiros.CurrentCell.RowIndex;
            GiroModel giroModel = new GiroModel();
            giroModel.Id = Convert.ToInt32(GVCobroGiros[0, i].Value);
            StatusStrip o = this.TopLevelControl.Controls.Find("stStatus", true).FirstOrDefault() as StatusStrip;
            giroModel.USUARIO_CREADOR = o.Items[1].Text;
            giroModel.RowVer =(byte[])GVCobroGiros[7,i].Value;               // giroModel.
            giroModel.Id_PersonaOrigen = Convert.ToInt32(dni2.TBDni.Text);
            int executado = girosMethods.CobrarGiro(giroModel);
            if (executado > 0)
            {
               MessageBox.Show("Giro cobrado");
               Recibo recibo = new Recibo();
               recibo.Show();
            }
         }
        }

        private static CobroGiros _instance;
        public static CobroGiros instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CobroGiros();
                }

                return _instance;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

         if (string.IsNullOrEmpty(dni2.TBDni.Text)) return; 
         if (string.IsNullOrEmpty(clave1.TBClave.Text)) return;
            GirosMethods girosMethods = new GirosMethods();          
            var bindingList = new BindingList<object>(girosMethods.SelectGirosbyDocClave(dni2.TBDni.Text, Convert.ToInt16(clave1.TBClave.Text)));
            var source = new BindingSource(bindingList, null);
            GVCobroGiros.DataSource = source;

        }
    }
}
