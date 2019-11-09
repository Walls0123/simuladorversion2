using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bancario.Plataforma
{
     //           Se hereda del control base  vvvv  donde se encuentra el boton proceder 
    public partial class UCactualizarCuenta : Base
    {
        public UCactualizarCuenta()
        {
            InitializeComponent();
            //se crea el evento click del boton proceder
            proceder1.BTProceder.Click += BTProceder_Click;
        }

        private void BTProceder_Click(object sender, EventArgs e)
        {
            //Evento Click del boton proceder
            throw new NotImplementedException();
        }

        private void UCactualizarCuenta_Load(object sender, EventArgs e)
        {

        }

        private static UCactualizarCuenta _instance;
        public static UCactualizarCuenta instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UCactualizarCuenta();
                }

                return _instance;
            }
        }
    }
}
