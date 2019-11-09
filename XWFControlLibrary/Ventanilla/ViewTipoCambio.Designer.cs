namespace XWFControlLibrary.Ventanilla
{
   partial class ViewTipoCambio
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
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbVenta = new System.Windows.Forms.RadioButton();
            this.rbCompra = new System.Windows.Forms.RadioButton();
            this.exChange1 = new XWFControlLibrary.UI.ucontrol.ExChange();
            this.conversionMoneyFull1 = new XWFControlLibrary.UI.ucontrol.ConversionMoneyFull();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonProceder
            // 
            this.buttonProceder.FlatAppearance.BorderSize = 0;
            this.buttonProceder.Location = new System.Drawing.Point(476, 0);
            this.buttonProceder.Click += new System.EventHandler(this.ButtonProceder_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(67, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Monto :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Conversión :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbVenta);
            this.groupBox1.Controls.Add(this.rbCompra);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(340, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 64);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de movimiento";
            // 
            // rbVenta
            // 
            this.rbVenta.AutoSize = true;
            this.rbVenta.Location = new System.Drawing.Point(28, 42);
            this.rbVenta.Name = "rbVenta";
            this.rbVenta.Size = new System.Drawing.Size(54, 17);
            this.rbVenta.TabIndex = 37;
            this.rbVenta.Tag = "false";
            this.rbVenta.Text = "Venta";
            this.rbVenta.UseVisualStyleBackColor = true;
            // 
            // rbCompra
            // 
            this.rbCompra.AutoSize = true;
            this.rbCompra.Checked = true;
            this.rbCompra.Location = new System.Drawing.Point(28, 19);
            this.rbCompra.Name = "rbCompra";
            this.rbCompra.Size = new System.Drawing.Size(65, 17);
            this.rbCompra.TabIndex = 38;
            this.rbCompra.TabStop = true;
            this.rbCompra.Tag = "true";
            this.rbCompra.Text = "Compra";
            this.rbCompra.UseVisualStyleBackColor = true;
            // 
            // exChange1
            // 
            this.exChange1.Location = new System.Drawing.Point(491, 23);
            this.exChange1.Name = "exChange1";
            this.exChange1.Size = new System.Drawing.Size(161, 99);
            this.exChange1.TabIndex = 37;
            // 
            // conversionMoneyFull1
            // 
            this.conversionMoneyFull1.Location = new System.Drawing.Point(121, 30);
            this.conversionMoneyFull1.Name = "conversionMoneyFull1";
            this.conversionMoneyFull1.Size = new System.Drawing.Size(200, 57);
            this.conversionMoneyFull1.TabIndex = 38;
            // 
            // ViewTipoCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.conversionMoneyFull1);
            this.Controls.Add(this.exChange1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label6);
            this.Name = "ViewTipoCambio";
            this.Size = new System.Drawing.Size(660, 618);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.exChange1, 0);
            this.Controls.SetChildIndex(this.conversionMoneyFull1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Label label15;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.RadioButton rbVenta;
      private System.Windows.Forms.RadioButton rbCompra;
      private UI.ucontrol.ExChange exChange1;
      private UI.ucontrol.ConversionMoneyFull conversionMoneyFull1;
   }
}
