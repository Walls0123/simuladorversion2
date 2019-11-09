namespace Sistema_Bancario.Controles
{
    partial class CambioMoneda
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConversion = new System.Windows.Forms.TextBox();
            this.tipoMoneda2 = new Sistema_Bancario.Controles.TipoMoneda();
            this.tipoMoneda1 = new Sistema_Bancario.Controles.TipoMoneda();
            this.monto1 = new Sistema_Bancario.Monto();
            this.precios1 = new Sistema_Bancario.Controles.Precios();
            this.Cambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Monto :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Conversión :";
            // 
            // txtConversion
            // 
            this.txtConversion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtConversion.Location = new System.Drawing.Point(120, 46);
            this.txtConversion.Name = "txtConversion";
            this.txtConversion.ReadOnly = true;
            this.txtConversion.Size = new System.Drawing.Size(133, 20);
            this.txtConversion.TabIndex = 40;
            // 
            // tipoMoneda2
            // 
            this.tipoMoneda2.Location = new System.Drawing.Point(327, 44);
            this.tipoMoneda2.Margin = new System.Windows.Forms.Padding(2);
            this.tipoMoneda2.Name = "tipoMoneda2";
            this.tipoMoneda2.Size = new System.Drawing.Size(133, 24);
            this.tipoMoneda2.TabIndex = 45;
            // 
            // tipoMoneda1
            // 
            this.tipoMoneda1.Location = new System.Drawing.Point(327, 15);
            this.tipoMoneda1.Margin = new System.Windows.Forms.Padding(2);
            this.tipoMoneda1.Name = "tipoMoneda1";
            this.tipoMoneda1.Size = new System.Drawing.Size(133, 24);
            this.tipoMoneda1.TabIndex = 44;
            // 
            // monto1
            // 
            this.monto1.Location = new System.Drawing.Point(120, 17);
            this.monto1.Margin = new System.Windows.Forms.Padding(2);
            this.monto1.Name = "monto1";
            this.monto1.Size = new System.Drawing.Size(203, 22);
            this.monto1.TabIndex = 42;
            // 
            // precios1
            // 
            this.precios1.BackColor = System.Drawing.Color.Transparent;
            this.precios1.Location = new System.Drawing.Point(464, 15);
            this.precios1.Margin = new System.Windows.Forms.Padding(2);
            this.precios1.Name = "precios1";
            this.precios1.Size = new System.Drawing.Size(177, 79);
            this.precios1.TabIndex = 39;
            // 
            // Cambiar
            // 
            this.Cambiar.BackColor = System.Drawing.Color.ForestGreen;
            this.Cambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cambiar.ForeColor = System.Drawing.SystemColors.Window;
            this.Cambiar.Location = new System.Drawing.Point(353, 78);
            this.Cambiar.Name = "Cambiar";
            this.Cambiar.Size = new System.Drawing.Size(106, 23);
            this.Cambiar.TabIndex = 46;
            this.Cambiar.Text = "Cambiar";
            this.Cambiar.UseVisualStyleBackColor = false;
            this.Cambiar.Click += new System.EventHandler(this.Cambiar_Click);
            // 
            // CambioMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Cambiar);
            this.Controls.Add(this.tipoMoneda2);
            this.Controls.Add(this.tipoMoneda1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monto1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConversion);
            this.Controls.Add(this.precios1);
            this.Name = "CambioMoneda";
            this.Size = new System.Drawing.Size(657, 111);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Monto monto1;
        private System.Windows.Forms.Label label1;
        private Precios precios1;
        public System.Windows.Forms.TextBox txtConversion;
        public TipoMoneda tipoMoneda2;
        public TipoMoneda tipoMoneda1;
        public System.Windows.Forms.Button Cambiar;
    }
}
