namespace Sistema_Bancario.Ventanilla
{
    partial class Balancin
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistrarMov = new System.Windows.Forms.Button();
            this.dgvSoles = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.cmbVentanillas = new System.Windows.Forms.ComboBox();
            this.txtTotalDolares = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoMov = new System.Windows.Forms.ComboBox();
            this.txtTotalSoles = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDolares = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.printTicket = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDolares)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarMov
            // 
            this.btnRegistrarMov.Location = new System.Drawing.Point(600, 520);
            this.btnRegistrarMov.Name = "btnRegistrarMov";
            this.btnRegistrarMov.Size = new System.Drawing.Size(158, 38);
            this.btnRegistrarMov.TabIndex = 15;
            this.btnRegistrarMov.Text = "Registrar movimiento";
            this.btnRegistrarMov.UseVisualStyleBackColor = true;
            this.btnRegistrarMov.Click += new System.EventHandler(this.btnRegistrarMov_Click_1);
            // 
            // dgvSoles
            // 
            this.dgvSoles.AllowUserToAddRows = false;
            this.dgvSoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvSoles.Location = new System.Drawing.Point(29, 196);
            this.dgvSoles.Name = "dgvSoles";
            this.dgvSoles.RowTemplate.Height = 24;
            this.dgvSoles.Size = new System.Drawing.Size(531, 247);
            this.dgvSoles.TabIndex = 17;
            this.dgvSoles.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvSoles_CellValidating);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Soles";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Cant";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Importe";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(395, 520);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(155, 38);
            this.btnImprimir.TabIndex = 16;
            this.btnImprimir.Text = "Imprimir ticket";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // cmbVentanillas
            // 
            this.cmbVentanillas.FormattingEnabled = true;
            this.cmbVentanillas.Location = new System.Drawing.Point(531, 135);
            this.cmbVentanillas.Name = "cmbVentanillas";
            this.cmbVentanillas.Size = new System.Drawing.Size(227, 24);
            this.cmbVentanillas.TabIndex = 10;
            // 
            // txtTotalDolares
            // 
            this.txtTotalDolares.Location = new System.Drawing.Point(976, 454);
            this.txtTotalDolares.Name = "txtTotalDolares";
            this.txtTotalDolares.ReadOnly = true;
            this.txtTotalDolares.Size = new System.Drawing.Size(138, 22);
            this.txtTotalDolares.TabIndex = 13;
            this.txtTotalDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sujeto";
            // 
            // cmbTipoMov
            // 
            this.cmbTipoMov.FormattingEnabled = true;
            this.cmbTipoMov.Location = new System.Drawing.Point(531, 85);
            this.cmbTipoMov.Name = "cmbTipoMov";
            this.cmbTipoMov.Size = new System.Drawing.Size(227, 24);
            this.cmbTipoMov.TabIndex = 11;
            // 
            // txtTotalSoles
            // 
            this.txtTotalSoles.Location = new System.Drawing.Point(422, 454);
            this.txtTotalSoles.Name = "txtTotalSoles";
            this.txtTotalSoles.ReadOnly = true;
            this.txtTotalSoles.Size = new System.Drawing.Size(138, 22);
            this.txtTotalSoles.TabIndex = 14;
            this.txtTotalSoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipo de movimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(818, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total dólares";
            // 
            // dgvDolares
            // 
            this.dgvDolares.AllowUserToAddRows = false;
            this.dgvDolares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDolares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvDolares.Location = new System.Drawing.Point(566, 196);
            this.dgvDolares.Name = "dgvDolares";
            this.dgvDolares.RowTemplate.Height = 24;
            this.dgvDolares.Size = new System.Drawing.Size(548, 247);
            this.dgvDolares.TabIndex = 12;
            this.dgvDolares.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvDolares_CellValidating);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Dolares";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Cant";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Importe";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total soles";
            // 
            // Balancin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRegistrarMov);
            this.Controls.Add(this.dgvSoles);
            this.Controls.Add(this.dgvDolares);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbVentanillas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalDolares);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalSoles);
            this.Controls.Add(this.cmbTipoMov);
            this.Name = "Balancin";
            this.Size = new System.Drawing.Size(1145, 657);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDolares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarMov;
        private System.Windows.Forms.DataGridView dgvSoles;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ComboBox cmbVentanillas;
        private System.Windows.Forms.TextBox txtTotalDolares;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoMov;
        private System.Windows.Forms.TextBox txtTotalSoles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDolares;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Drawing.Printing.PrintDocument printTicket;
    }
}
