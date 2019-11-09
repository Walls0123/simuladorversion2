namespace Sistema_Bancario.Plataforma
{
    partial class UCprestamos
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
            this.datosPersona1 = new Sistema_Bancario.Controles.DatosPersona();
            this.groupPrestamo = new System.Windows.Forms.GroupBox();
            this.cmbSeguro = new System.Windows.Forms.ComboBox();
            this.cmbCuenta = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textInteres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tipoMoneda1 = new Sistema_Bancario.Controles.TipoMoneda();
            this.textMonto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerarCronograma = new System.Windows.Forms.Button();
            this.groupPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(6, 522);
            this.proceder1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.proceder1.Size = new System.Drawing.Size(402, 40);
            // 
            // datosPersona1
            // 

            this.datosPersona1.Location = new System.Drawing.Point(14, 22);
            this.datosPersona1.Margin = new System.Windows.Forms.Padding(4);
            this.datosPersona1.Name = "datosPersona1";
            this.datosPersona1.Size = new System.Drawing.Size(388, 243);
            this.datosPersona1.TabIndex = 15;
            // 
            // groupPrestamo
            // 
            this.groupPrestamo.Controls.Add(this.btnGenerarCronograma);
            this.groupPrestamo.Controls.Add(this.cmbSeguro);
            this.groupPrestamo.Controls.Add(this.cmbCuenta);
            this.groupPrestamo.Controls.Add(this.textBox2);
            this.groupPrestamo.Controls.Add(this.textInteres);
            this.groupPrestamo.Controls.Add(this.label7);
            this.groupPrestamo.Controls.Add(this.label6);
            this.groupPrestamo.Controls.Add(this.label5);
            this.groupPrestamo.Controls.Add(this.numericUpDown1);
            this.groupPrestamo.Controls.Add(this.label4);
            this.groupPrestamo.Controls.Add(this.tipoMoneda1);
            this.groupPrestamo.Controls.Add(this.textMonto);
            this.groupPrestamo.Controls.Add(this.label3);
            this.groupPrestamo.Controls.Add(this.label2);
            this.groupPrestamo.Location = new System.Drawing.Point(16, 236);
            this.groupPrestamo.Name = "groupPrestamo";
            this.groupPrestamo.Size = new System.Drawing.Size(357, 281);
            this.groupPrestamo.TabIndex = 16;
            this.groupPrestamo.TabStop = false;
            this.groupPrestamo.Text = "Préstamo";
            // 
            // cmbSeguro
            // 
            this.cmbSeguro.FormattingEnabled = true;
            this.cmbSeguro.Location = new System.Drawing.Point(78, 179);
            this.cmbSeguro.Name = "cmbSeguro";
            this.cmbSeguro.Size = new System.Drawing.Size(207, 21);
            this.cmbSeguro.TabIndex = 29;
            // 
            // cmbCuenta
            // 
            this.cmbCuenta.FormattingEnabled = true;
            this.cmbCuenta.Location = new System.Drawing.Point(78, 34);
            this.cmbCuenta.Name = "cmbCuenta";
            this.cmbCuenta.Size = new System.Drawing.Size(207, 21);
            this.cmbCuenta.TabIndex = 28;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 211);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 26;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textInteres
            // 
            this.textInteres.Location = new System.Drawing.Point(135, 150);
            this.textInteres.Name = "textInteres";
            this.textInteres.Size = new System.Drawing.Size(150, 20);
            this.textInteres.TabIndex = 26;
            this.textInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Porcentaje de moratorios";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Seguro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Porcentaje de interés";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(109, 118);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(78, 20);
            this.numericUpDown1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Plazo en meses";
            // 
            // tipoMoneda1
            // 
            this.tipoMoneda1.Location = new System.Drawing.Point(20, 58);
            this.tipoMoneda1.Margin = new System.Windows.Forms.Padding(2);
            this.tipoMoneda1.Name = "tipoMoneda1";
            this.tipoMoneda1.Size = new System.Drawing.Size(182, 24);
            this.tipoMoneda1.TabIndex = 21;
            // 
            // textMonto
            // 
            this.textMonto.Location = new System.Drawing.Point(78, 89);
            this.textMonto.Name = "textMonto";
            this.textMonto.Size = new System.Drawing.Size(109, 20);
            this.textMonto.TabIndex = 20;
            this.textMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Monto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cuenta";
            // 
            // btnGenerarCronograma
            // 
            this.btnGenerarCronograma.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGenerarCronograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarCronograma.ForeColor = System.Drawing.Color.White;
            this.btnGenerarCronograma.Location = new System.Drawing.Point(109, 246);
            this.btnGenerarCronograma.Name = "btnGenerarCronograma";
            this.btnGenerarCronograma.Size = new System.Drawing.Size(131, 23);
            this.btnGenerarCronograma.TabIndex = 35;
            this.btnGenerarCronograma.Text = "Generar Cronograma";
            this.btnGenerarCronograma.UseVisualStyleBackColor = false;
            // 
            // UCPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupPrestamo);
            this.Controls.Add(this.datosPersona1);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "UCPrestamos";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(874, 618);
            this.Load += new System.EventHandler(this.UCPrestamos_Load);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.Controls.SetChildIndex(this.datosPersona1, 0);
            this.Controls.SetChildIndex(this.groupPrestamo, 0);
            this.groupPrestamo.ResumeLayout(false);
            this.groupPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Controles.DatosPersona datosPersona1;
        private System.Windows.Forms.GroupBox groupPrestamo;
        private System.Windows.Forms.TextBox textMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Controles.TipoMoneda tipoMoneda1;
        private System.Windows.Forms.TextBox textInteres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSeguro;
        private System.Windows.Forms.ComboBox cmbCuenta;
        private System.Windows.Forms.Button btnGenerarCronograma;
    }
}
