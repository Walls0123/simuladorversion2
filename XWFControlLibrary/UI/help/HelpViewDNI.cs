using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XWFControlLibrary.UI.help
{
   public partial class HelpViewDNI : Form
   {
      public string row = null;
      public HelpViewDNI()
      {
         InitializeComponent();
      }

      public void SetView(List<PersonaModel> list)
      {
         foreach (var item in list)
         {
            dgvItems.Rows.Add(item.Nrodocumento, item.Apellidos, item.Nombres);
         }
         dgvItems.Columns[0].DefaultCellStyle.BackColor = Color.LightGreen;
      }

      private void BtnExit_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void DgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
      {
         if (e.RowIndex > -1)
         {
            row = dgvItems.Rows[e.RowIndex].Cells[0].Value.ToString();
            DialogResult =  DialogResult.OK;
            this.Close();
         }
      }
   }
}
