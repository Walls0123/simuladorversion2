namespace Sistema_Bancario.Froms_opciones
{
    partial class Transferencias
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nroCuenta1 = new Sistema_Bancario.Controles.NroCuenta();
            this.tipoMoneda1 = new Sistema_Bancario.Controles.TipoMoneda();
            this.clave1 = new Sistema_Bancario.Controles.Clave();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nroCuenta2 = new Sistema_Bancario.Controles.NroCuenta();
            this.monto1 = new Sistema_Bancario.Monto();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(6, 383);
            this.proceder1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.proceder1.Size = new System.Drawing.Size(703, 40);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Monto";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.monto1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nroCuenta1);
            this.groupBox1.Controls.Add(this.tipoMoneda1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.clave1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(20, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(687, 165);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Persona Origen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Clave";
            // 
            // nroCuenta1
            // 
            this.nroCuenta1.EstadoCuenta = null;
            this.nroCuenta1.Location = new System.Drawing.Point(12, 17);
            this.nroCuenta1.Margin = new System.Windows.Forms.Padding(2);
            this.nroCuenta1.Name = "nroCuenta1";
            this.nroCuenta1.Size = new System.Drawing.Size(671, 90);
            this.nroCuenta1.TabIndex = 40;
            this.nroCuenta1.VersionCuenta = null;
            // 
            // tipoMoneda1
            // 
            this.tipoMoneda1.Location = new System.Drawing.Point(274, 107);
            this.tipoMoneda1.Margin = new System.Windows.Forms.Padding(2);
            this.tipoMoneda1.Name = "tipoMoneda1";
            this.tipoMoneda1.Size = new System.Drawing.Size(133, 25);
            this.tipoMoneda1.TabIndex = 37;
            // 
            // clave1
            // 
            this.clave1.Location = new System.Drawing.Point(73, 137);
            this.clave1.Margin = new System.Windows.Forms.Padding(2);
            this.clave1.Name = "clave1";
            this.clave1.Size = new System.Drawing.Size(159, 20);
            this.clave1.TabIndex = 35;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.nroCuenta2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox2.Location = new System.Drawing.Point(22, 191);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(687, 118);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Persona Destino";
            // 
            // nroCuenta2
            // 
            this.nroCuenta2.EstadoCuenta = null;
            this.nroCuenta2.Location = new System.Drawing.Point(12, 17);
            this.nroCuenta2.Margin = new System.Windows.Forms.Padding(2);
            this.nroCuenta2.Name = "nroCuenta2";
            this.nroCuenta2.Size = new System.Drawing.Size(671, 89);
            this.nroCuenta2.TabIndex = 35;
            this.nroCuenta2.VersionCuenta = null;
            // 
            // monto1
            // 
            this.monto1.Location = new System.Drawing.Point(73, 113);
            this.monto1.Margin = new System.Windows.Forms.Padding(2);
            this.monto1.Name = "monto1";
            this.monto1.Size = new System.Drawing.Size(193, 20);
            this.monto1.TabIndex = 42;
            // 
            // Transferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Transferencias";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(715, 429);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

      #endregion
      private System.Windows.Forms.Label label3;
        private Controles.Clave clave1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Controles.TipoMoneda tipoMoneda1;
        private Controles.NroCuenta nroCuenta1;
        private Controles.NroCuenta nroCuenta2;
        private System.Windows.Forms.Label label1;
        private Monto monto1;
    }
}
