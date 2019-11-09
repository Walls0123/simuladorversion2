namespace Sistema_Bancario.Administrador
{
    partial class BuscarPersona
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
            this.pnlBusquedaPersona = new System.Windows.Forms.Panel();
            this.btnCancelarBusqueda = new System.Windows.Forms.Button();
            this.btnAceptarBusqueda = new System.Windows.Forms.Button();
            this.lblBusquedaPersona = new System.Windows.Forms.Label();
            this.dgvBusquedaUsuarios = new System.Windows.Forms.DataGridView();
            this.IdPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidosPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBusquedaPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusquedaPersona
            // 
            this.pnlBusquedaPersona.Controls.Add(this.btnCancelarBusqueda);
            this.pnlBusquedaPersona.Controls.Add(this.btnAceptarBusqueda);
            this.pnlBusquedaPersona.Controls.Add(this.lblBusquedaPersona);
            this.pnlBusquedaPersona.Controls.Add(this.dgvBusquedaUsuarios);
            this.pnlBusquedaPersona.Location = new System.Drawing.Point(21, 28);
            this.pnlBusquedaPersona.Name = "pnlBusquedaPersona";
            this.pnlBusquedaPersona.Size = new System.Drawing.Size(640, 340);
            this.pnlBusquedaPersona.TabIndex = 8;
            // 
            // btnCancelarBusqueda
            // 
            this.btnCancelarBusqueda.Location = new System.Drawing.Point(344, 269);
            this.btnCancelarBusqueda.Name = "btnCancelarBusqueda";
            this.btnCancelarBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarBusqueda.TabIndex = 3;
            this.btnCancelarBusqueda.Text = "Cancelar";
            this.btnCancelarBusqueda.UseVisualStyleBackColor = true;
            this.btnCancelarBusqueda.Click += new System.EventHandler(this.btnCancelarBusqueda_Click);
            // 
            // btnAceptarBusqueda
            // 
            this.btnAceptarBusqueda.Location = new System.Drawing.Point(180, 269);
            this.btnAceptarBusqueda.Name = "btnAceptarBusqueda";
            this.btnAceptarBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarBusqueda.TabIndex = 2;
            this.btnAceptarBusqueda.Text = "Aceptar";
            this.btnAceptarBusqueda.UseVisualStyleBackColor = true;
            this.btnAceptarBusqueda.Click += new System.EventHandler(this.btnAceptarBusqueda_Click);
            // 
            // lblBusquedaPersona
            // 
            this.lblBusquedaPersona.AutoSize = true;
            this.lblBusquedaPersona.Location = new System.Drawing.Point(274, 20);
            this.lblBusquedaPersona.Name = "lblBusquedaPersona";
            this.lblBusquedaPersona.Size = new System.Drawing.Size(97, 13);
            this.lblBusquedaPersona.TabIndex = 1;
            this.lblBusquedaPersona.Text = "Busqueda Persona";
            // 
            // dgvBusquedaUsuarios
            // 
            this.dgvBusquedaUsuarios.AllowUserToAddRows = false;
            this.dgvBusquedaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusquedaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPersona,
            this.NombresPersona,
            this.ApellidosPersona,
            this.TipoDocPersona,
            this.NroDocPersona});
            this.dgvBusquedaUsuarios.Location = new System.Drawing.Point(3, 94);
            this.dgvBusquedaUsuarios.Name = "dgvBusquedaUsuarios";
            this.dgvBusquedaUsuarios.Size = new System.Drawing.Size(621, 141);
            this.dgvBusquedaUsuarios.TabIndex = 0;
            this.dgvBusquedaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusquedaUsuarios_CellClick);
            // 
            // IdPersona
            // 
            this.IdPersona.HeaderText = "Id";
            this.IdPersona.Name = "IdPersona";
            this.IdPersona.Visible = false;
            // 
            // NombresPersona
            // 
            this.NombresPersona.HeaderText = "Nombres";
            this.NombresPersona.Name = "NombresPersona";
            this.NombresPersona.ReadOnly = true;
            this.NombresPersona.Width = 200;
            // 
            // ApellidosPersona
            // 
            this.ApellidosPersona.HeaderText = "Apellidos";
            this.ApellidosPersona.Name = "ApellidosPersona";
            this.ApellidosPersona.ReadOnly = true;
            this.ApellidosPersona.Width = 200;
            // 
            // TipoDocPersona
            // 
            this.TipoDocPersona.HeaderText = "Tipo documento";
            this.TipoDocPersona.Name = "TipoDocPersona";
            this.TipoDocPersona.ReadOnly = true;
            // 
            // NroDocPersona
            // 
            this.NroDocPersona.HeaderText = "Nro documento";
            this.NroDocPersona.Name = "NroDocPersona";
            this.NroDocPersona.ReadOnly = true;
            // 
            // BuscarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 413);
            this.Controls.Add(this.pnlBusquedaPersona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarPersona";
            this.pnlBusquedaPersona.ResumeLayout(false);
            this.pnlBusquedaPersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBusquedaPersona;
        private System.Windows.Forms.Button btnCancelarBusqueda;
        private System.Windows.Forms.Button btnAceptarBusqueda;
        private System.Windows.Forms.Label lblBusquedaPersona;
        private System.Windows.Forms.DataGridView dgvBusquedaUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidosPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocPersona;
    }
}