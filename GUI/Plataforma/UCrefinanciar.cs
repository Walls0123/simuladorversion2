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
    public partial class UCrefinanciar : Base
    {
        public UCrefinanciar()
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

        private void UCrefinanciar_Load(object sender, EventArgs e)
        {

        }
        private static UCrefinanciar _instance;
        public static  UCrefinanciar  instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UCrefinanciar();
                }

                return _instance;
            }
        }
    }
}
