namespace Sistema_Bancario.Controles
{
    partial class DNI
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
            this.TBDni = new System.Windows.Forms.TextBox();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TBDni
            // 
            this.TBDni.Location = new System.Drawing.Point(2, 27);
            this.TBDni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBDni.MaxLength = 8;
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(141, 20);
            this.TBDni.TabIndex = 0;
            this.TBDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBDni_KeyPress);
            // 
            // BtBuscar
            // 
            this.BtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(96)))), ((int)(((byte)(147)))));
            this.BtBuscar.FlatAppearance.BorderSize = 0;
            this.BtBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBuscar.ForeColor = System.Drawing.SystemColors.Window;
            this.BtBuscar.Location = new System.Drawing.Point(149, 4);
            this.BtBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(39, 23);
            this.BtBuscar.TabIndex = 1;
            this.BtBuscar.Text = "...";
            this.BtBuscar.UseVisualStyleBackColor = false;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(2, 4);
            this.TbNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(141, 20);
            this.TbNombre.TabIndex = 2;
            // 
            // DNI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.TBDni);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DNI";
            this.Size = new System.Drawing.Size(188, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TBDni;
        public System.Windows.Forms.TextBox TbNombre;
        public System.Windows.Forms.Button BtBuscar;
    }
}
