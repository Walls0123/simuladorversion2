using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bancario.Backend
{
    public partial class Resumen_caja_chica : Base
    {
        public Resumen_caja_chica()
        {
            InitializeComponent();
        }
        private static Resumen_caja_chica _instance;
        public static Resumen_caja_chica instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Resumen_caja_chica();
                }

                return _instance;
            }
        }
    }
}
