namespace Sistema_Bancario.Controles
{
    partial class TipoCuenta
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RBAhorros = new System.Windows.Forms.RadioButton();
            this.RBCredito = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBCorriente = new System.Windows.Forms.RadioButton();
            this.tipoMoneda1 = new Sistema_Bancario.Controles.TipoMoneda();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RBAhorros
            // 
            this.RBAhorros.AutoSize = true;
            this.RBAhorros.Location = new System.Drawing.Point(11, 22);
            this.RBAhorros.Margin = new System.Windows.Forms.Padding(2);
            this.RBAhorros.Name = "RBAhorros";
            this.RBAhorros.Size = new System.Drawing.Size(61, 17);
            this.RBAhorros.TabIndex = 0;
            this.RBAhorros.TabStop = true;
            this.RBAhorros.Text = "Ahorros";
            this.RBAhorros.UseVisualStyleBackColor = true;
            // 
            // RBCredito
            // 
            this.RBCredito.AutoSize = true;
            this.RBCredito.Location = new System.Drawing.Point(92, 22);
            this.RBCredito.Margin = new System.Windows.Forms.Padding(2);
            this.RBCredito.Name = "RBCredito";
            this.RBCredito.Size = new System.Drawing.Size(58, 17);
            this.RBCredito.TabIndex = 1;
            this.RBCredito.TabStop = true;
            this.RBCredito.Text = "Crédito";
            this.RBCredito.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBCorriente);
            this.groupBox1.Controls.Add(this.tipoMoneda1);
            this.groupBox1.Controls.Add(this.RBCredito);
            this.groupBox1.Controls.Add(this.RBAhorros);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(255, 78);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuenta";
            // 
            // RBCorriente
            // 
            this.RBCorriente.AutoSize = true;
            this.RBCorriente.Location = new System.Drawing.Point(165, 22);
            this.RBCorriente.Margin = new System.Windows.Forms.Padding(2);
            this.RBCorriente.Name = "RBCorriente";
            this.RBCorriente.Size = new System.Drawing.Size(67, 17);
            this.RBCorriente.TabIndex = 3;
            this.RBCorriente.TabStop = true;
            this.RBCorriente.Text = "Corriente";
            this.RBCorriente.UseVisualStyleBackColor = true;
            // 
            // tipoMoneda1
            // 
            this.tipoMoneda1.Location = new System.Drawing.Point(34, 43);
            this.tipoMoneda1.Margin = new System.Windows.Forms.Padding(2);
            this.tipoMoneda1.Name = "tipoMoneda1";
            this.tipoMoneda1.Size = new System.Drawing.Size(154, 24);
            this.tipoMoneda1.TabIndex = 2;
            // 
            // TipoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TipoCuenta";
            this.Size = new System.Drawing.Size(265, 84);
            this.Load += new System.EventHandler(this.TipoCuenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton RBAhorros;
        public System.Windows.Forms.RadioButton RBCredito;
        private TipoMoneda tipoMoneda1;
        public System.Windows.Forms.RadioButton RBCorriente;
    }
}
