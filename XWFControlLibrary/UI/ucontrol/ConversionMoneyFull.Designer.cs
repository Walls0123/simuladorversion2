namespace XWFControlLibrary.UI.ucontrol
{
   partial class ConversionMoneyFull
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
         this.txtMonto = new XWFControlLibrary.UI.control.MoneyTextBox();
         this.txtValue = new XWFControlLibrary.UI.control.MoneyTextBox();
         this.SuspendLayout();
         // 
         // txtMonto
         // 
         this.txtMonto.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtMonto.Location = new System.Drawing.Point(0, 35);
         this.txtMonto.MaxLength = 25;
         this.txtMonto.Name = "txtMonto";
         this.txtMonto.ReadOnly = true;
         this.txtMonto.Size = new System.Drawing.Size(200, 22);
         this.txtMonto.TabIndex = 33;
         // 
         // txtValue
         // 
         this.txtValue.Dock = System.Windows.Forms.DockStyle.Top;
         this.txtValue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtValue.Location = new System.Drawing.Point(0, 0);
         this.txtValue.MaxLength = 25;
         this.txtValue.Name = "txtValue";
         this.txtValue.Size = new System.Drawing.Size(200, 22);
         this.txtValue.TabIndex = 34;
         this.txtValue.TextChanged += new System.EventHandler(this.TxtValue_TextChanged);
         // 
         // ConversionMoneyFull
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.txtValue);
         this.Controls.Add(this.txtMonto);
         this.Name = "ConversionMoneyFull";
         this.Size = new System.Drawing.Size(200, 57);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      public control.MoneyTextBox txtMonto;
      public control.MoneyTextBox txtValue;
   }
}
