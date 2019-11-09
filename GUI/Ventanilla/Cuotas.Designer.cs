namespace Sistema_Bancario
{
    partial class Cuotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTBuscarCuota = new System.Windows.Forms.Button();
            this.GridPrestamos = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridCuotas = new System.Windows.Forms.DataGridView();
            this.BTFiltrarCuotas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nroCuenta1 = new Sistema_Bancario.Controles.NroCuenta();
            ((System.ComponentModel.ISupportInitialize)(this.GridPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(6, 533);
            this.proceder1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.proceder1.Size = new System.Drawing.Size(862, 40);
            // 
            // BTBuscarCuota
            // 
            this.BTBuscarCuota.BackColor = System.Drawing.Color.ForestGreen;
            this.BTBuscarCuota.FlatAppearance.BorderSize = 0;
            this.BTBuscarCuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTBuscarCuota.ForeColor = System.Drawing.Color.White;
            this.BTBuscarCuota.Location = new System.Drawing.Point(221, 51);
            this.BTBuscarCuota.Margin = new System.Windows.Forms.Padding(2);
            this.BTBuscarCuota.Name = "BTBuscarCuota";
            this.BTBuscarCuota.Size = new System.Drawing.Size(56, 26);
            this.BTBuscarCuota.TabIndex = 4;
            this.BTBuscarCuota.Text = "Buscar";
            this.BTBuscarCuota.UseVisualStyleBackColor = false;
            this.BTBuscarCuota.Click += new System.EventHandler(this.BTBuscarCuota_Click);
            // 
            // GridPrestamos
            // 
            this.GridPrestamos.AllowUserToAddRows = false;
            this.GridPrestamos.AllowUserToDeleteRows = false;
            this.GridPrestamos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPrestamos.Location = new System.Drawing.Point(8, 108);
            this.GridPrestamos.Margin = new System.Windows.Forms.Padding(2);
            this.GridPrestamos.Name = "GridPrestamos";
            this.GridPrestamos.ReadOnly = true;
            this.GridPrestamos.RowTemplate.Height = 24;
            this.GridPrestamos.Size = new System.Drawing.Size(639, 172);
            this.GridPrestamos.TabIndex = 5;
            this.GridPrestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPrestamos_CellClick);
            this.GridPrestamos.SelectionChanged += new System.EventHandler(this.GridPrestamos_SelectionChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cod Prestamo";
            // 
            // GridCuotas
            // 
            this.GridCuotas.AllowUserToAddRows = false;
            this.GridCuotas.AllowUserToDeleteRows = false;
            this.GridCuotas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.GridCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCuotas.Location = new System.Drawing.Point(9, 310);
            this.GridCuotas.Name = "GridCuotas";
            this.GridCuotas.ReadOnly = true;
            this.GridCuotas.Size = new System.Drawing.Size(639, 214);
            this.GridCuotas.TabIndex = 8;
            // 
            // BTFiltrarCuotas
            // 
            this.BTFiltrarCuotas.BackColor = System.Drawing.Color.ForestGreen;
            this.BTFiltrarCuotas.FlatAppearance.BorderSize = 0;
            this.BTFiltrarCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTFiltrarCuotas.ForeColor = System.Drawing.Color.White;
            this.BTFiltrarCuotas.Location = new System.Drawing.Point(221, 82);
            this.BTFiltrarCuotas.Margin = new System.Windows.Forms.Padding(2);
            this.BTFiltrarCuotas.Name = "BTFiltrarCuotas";
            this.BTFiltrarCuotas.Size = new System.Drawing.Size(56, 22);
            this.BTFiltrarCuotas.TabIndex = 9;
            this.BTFiltrarCuotas.Text = "Filtrar";
            this.BTFiltrarCuotas.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(8, 282);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cuotas";
            // 
            // nroCuenta1
            // 
            this.nroCuenta1.Location = new System.Drawing.Point(8, 0);
            this.nroCuenta1.Margin = new System.Windows.Forms.Padding(2);
            this.nroCuenta1.Name = "nroCuenta1";
            this.nroCuenta1.Size = new System.Drawing.Size(639, 77);
            this.nroCuenta1.TabIndex = 13;
            // 
            // Cuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.BTBuscarCuota);
            this.Controls.Add(this.nroCuenta1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTFiltrarCuotas);
            this.Controls.Add(this.GridCuotas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GridPrestamos);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "Cuotas";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(874, 579);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.GridPrestamos, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.GridCuotas, 0);
            this.Controls.SetChildIndex(this.BTFiltrarCuotas, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.Controls.SetChildIndex(this.nroCuenta1, 0);
            this.Controls.SetChildIndex(this.BTBuscarCuota, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GridPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTBuscarCuota;
        private System.Windows.Forms.DataGridView GridPrestamos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridCuotas;
        private System.Windows.Forms.Button BTFiltrarCuotas;
        private System.Windows.Forms.Label label2;
        private Controles.NroCuenta nroCuenta1;
    }
}
