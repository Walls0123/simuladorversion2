using Sistema_Bancario.Controles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancario.Ventanilla
{
    public class Utilitarios : TipoMoneda
    {
        public event EventHandler OnTextChanged;

        private void RaisecheckTextChanged()
        {
            var handler = OnTextChanged;
            if (handler == null)
                return;

            handler(this, EventArgs.Empty);
        }

        public void TxtConversion_TextChanged(object sender, EventArgs e)
        {
            RaisecheckTextChanged();
        }
    }
}
