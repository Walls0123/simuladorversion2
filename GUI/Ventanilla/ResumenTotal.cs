using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bancario.Ventanilla
{
    public partial class ResumenTotal : UserControl
    {
        public ResumenTotal()
        {
            InitializeComponent();
            this.BackColor = Color.White;
        }
        private static ResumenTotal _instance;
        public static ResumenTotal instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ResumenTotal();
                }

                return _instance;
            }
        }
    }
}
