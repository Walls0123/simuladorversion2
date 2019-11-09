namespace Sistema_Bancario.Froms_opciones
{
    partial class Tipo_de_Cambio
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
            this.precios1 = new Sistema_Bancario.Controles.Precios();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnCompra = new System.Windows.Forms.RadioButton();
            this.rbtnVenta = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConversion = new System.Windows.Forms.TextBox();
            this.monto1 = new Sistema_Bancario.Monto();
            this.tipoMoneda1 = new Sistema_Bancario.Controles.TipoMoneda();
            this.tipoMoneda2 = new Sistema_Bancario.Controles.TipoMoneda();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(8, 705);
            this.proceder1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.proceder1.Size = new System.Drawing.Size(1149, 49);
            // 
            // precios1
            // 
            this.precios1.BackColor = System.Drawing.Color.Transparent;
            this.precios1.Location = new System.Drawing.Point(733, 57);
            this.precios1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.precios1.Name = "precios1";
            this.precios1.Size = new System.Drawing.Size(232, 101);
            this.precios1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnCompra);
            this.groupBox1.Controls.Add(this.rbtnVenta);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(217, 62);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PROCESO";
            // 
            // rbtnCompra
            // 
            this.rbtnCompra.AutoSize = true;
            this.rbtnCompra.Checked = true;
            this.rbtnCompra.Location = new System.Drawing.Point(21, 23);
            this.rbtnCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnCompra.Name = "rbtnCompra";
            this.rbtnCompra.Size = new System.Drawing.Size(84, 21);
            this.rbtnCompra.TabIndex = 3;
            this.rbtnCompra.TabStop = true;
            this.rbtnCompra.Text = "Compra";
            this.rbtnCompra.UseVisualStyleBackColor = true;
            this.rbtnCompra.CheckedChanged += new System.EventHandler(this.RbtnCompra_CheckedChanged);
            // 
            // rbtnVenta
            // 
            this.rbtnVenta.AutoSize = true;
            this.rbtnVenta.Location = new System.Drawing.Point(133, 25);
            this.rbtnVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnVenta.Name = "rbtnVenta";
            this.rbtnVenta.Size = new System.Drawing.Size(69, 21);
            this.rbtnVenta.TabIndex = 2;
            this.rbtnVenta.Text = "Venta";
            this.rbtnVenta.UseVisualStyleBackColor = true;
            this.rbtnVenta.CheckedChanged += new System.EventHandler(this.RbtnVenta_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Conversión :";
            // 
            // txtConversion
            // 
            this.txtConversion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtConversion.Location = new System.Drawing.Point(203, 129);
            this.txtConversion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConversion.Name = "txtConversion";
            this.txtConversion.ReadOnly = true;
            this.txtConversion.Size = new System.Drawing.Size(267, 22);
            this.txtConversion.TabIndex = 29;
            // 
            // monto1
            // 
            this.monto1.Location = new System.Drawing.Point(203, 96);
            this.monto1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monto1.Name = "monto1";
            this.monto1.Size = new System.Drawing.Size(271, 27);
            this.monto1.TabIndex = 35;
            // 
            // tipoMoneda1
            // 
            this.tipoMoneda1.Location = new System.Drawing.Point(479, 94);
            this.tipoMoneda1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipoMoneda1.Name = "tipoMoneda1";
            this.tipoMoneda1.Size = new System.Drawing.Size(188, 30);
            this.tipoMoneda1.TabIndex = 36;
            // 
            // tipoMoneda2
            // 
            this.tipoMoneda2.Location = new System.Drawing.Point(477, 128);
            this.tipoMoneda2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipoMoneda2.Name = "tipoMoneda2";
            this.tipoMoneda2.Size = new System.Drawing.Size(189, 30);
            this.tipoMoneda2.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Monto :";
            // 
            // Tipo_de_Cambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tipoMoneda2);
            this.Controls.Add(this.tipoMoneda1);
            this.Controls.Add(this.monto1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConversion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.precios1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tipo_de_Cambio";
            this.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Controls.SetChildIndex(this.precios1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtConversion, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.monto1, 0);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.Controls.SetChildIndex(this.tipoMoneda1, 0);
            this.Controls.SetChildIndex(this.tipoMoneda2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controles.Precios precios1;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.RadioButton rbtnCompra;
      private System.Windows.Forms.RadioButton rbtnVenta;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtConversion;
        private Monto monto1;
        private Controles.TipoMoneda tipoMoneda1;
        private Controles.TipoMoneda tipoMoneda2;
        private System.Windows.Forms.Label label2;
    }
}
