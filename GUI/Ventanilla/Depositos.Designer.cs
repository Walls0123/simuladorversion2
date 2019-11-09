namespace Sistema_Bancario.Ventanilla
{
   partial class Depositos
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
            this.tipoMoneda2 = new Sistema_Bancario.Controles.TipoMoneda();
            this.label3 = new System.Windows.Forms.Label();
            this.nroCuenta1 = new Sistema_Bancario.Controles.NroCuenta();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monto1 = new Sistema_Bancario.Monto();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(11, 357);
            this.proceder1.Size = new System.Drawing.Size(718, 40);
            // 
            // tipoMoneda2
            // 
            this.tipoMoneda2.Location = new System.Drawing.Point(281, 88);
            this.tipoMoneda2.Margin = new System.Windows.Forms.Padding(2);
            this.tipoMoneda2.Name = "tipoMoneda2";
            this.tipoMoneda2.Size = new System.Drawing.Size(136, 25);
            this.tipoMoneda2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Monto";
            // 
            // nroCuenta1
            // 
            this.nroCuenta1.EstadoCuenta = null;
            this.nroCuenta1.Location = new System.Drawing.Point(13, 12);
            this.nroCuenta1.Margin = new System.Windows.Forms.Padding(2);
            this.nroCuenta1.Name = "nroCuenta1";
            this.nroCuenta1.Size = new System.Drawing.Size(767, 77);
            this.nroCuenta1.TabIndex = 27;
            this.nroCuenta1.VersionCuenta = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(20, 126);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 35, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.panel1.Size = new System.Drawing.Size(679, 0);
            this.panel1.TabIndex = 28;
            // 
            // monto1
            // 
            this.monto1.Location = new System.Drawing.Point(80, 90);
            this.monto1.Margin = new System.Windows.Forms.Padding(2);
            this.monto1.Name = "monto1";
            this.monto1.Size = new System.Drawing.Size(193, 20);
            this.monto1.TabIndex = 29;
            // 
            // Depositos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.monto1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tipoMoneda2);
            this.Controls.Add(this.nroCuenta1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Depositos";
            this.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Size = new System.Drawing.Size(740, 407);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.nroCuenta1, 0);
            this.Controls.SetChildIndex(this.tipoMoneda2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.Controls.SetChildIndex(this.monto1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Label label3;
        private Controles.TipoMoneda tipoMoneda2;
        private Controles.NroCuenta nroCuenta1;
        private System.Windows.Forms.Panel panel1;
        private Monto monto1;
    }
}
