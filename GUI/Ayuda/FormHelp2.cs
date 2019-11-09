using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bancario.Ayuda
{
    public partial class FormHelp2 : Form
    {
        private bool aceptado;
        private object currentObject;

        public FormHelp2()
        {
            InitializeComponent();
        }

        public void setList<T>(List<T> listData, string[][] columns)
        {
            this.dgvLista.DataSource = null;

            if (listData.Count > 0)
            {
                this.dgvLista.DataSource = listData;

                for (int i = 0; i < this.dgvLista.Columns.Count; i++)
                {
                    this.dgvLista.Columns[i].Visible = false;
                }

                this.dgvLista.AutoGenerateColumns = false;

                for (int x = 0; x < columns.Length; x++)
                {
                    this.dgvLista.Columns[columns[x][0]].HeaderText = columns[x][1];
                    this.dgvLista.Columns[columns[x][0]].Visible = true;
                    this.dgvLista.Columns[columns[x][0]].DisplayIndex = x;
                    this.dgvLista.Columns[columns[x][0]].Width = Convert.ToInt32(columns[x][2]);
                }
                this.dgvLista.Refresh();
            }
        }

        public bool EstaAceptado()
        {
            return aceptado;
        }

        public T getObject<T>()
        {
            return (T)this.currentObject;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.aceptado = true;
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.aceptado = false;
            this.Close();
        }

        private void dgvLista_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLista.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvLista.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvLista.Rows[selectedrowindex];

                this.currentObject = (object)dgvLista.CurrentRow.DataBoundItem;
            }
        }

        private void Datagridview_Keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.aceptado = true;
                this.Close();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                this.aceptado = false;
                this.Close();
            }
        }

        private void Form_Keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.aceptado = false;
                this.Close();
            }
        }
    }
}
