namespace Sistema_Bancario.Plataforma
{
    partial class UCrefinanciar
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
         this.textInteres = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
         this.label4 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.cmbCuenta = new System.Windows.Forms.ComboBox();
         this.btnGenerarCronograma = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
         this.SuspendLayout();
         // 
         // proceder1
         // 
         this.proceder1.Location = new System.Drawing.Point(6, 572);
         this.proceder1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.proceder1.Size = new System.Drawing.Size(862, 40);
         // 
         // datosPersona1
         // 
         this.datosPersona1.Location = new System.Drawing.Point(15, 20);
         this.datosPersona1.Margin = new System.Windows.Forms.Padding(4);
         this.datosPersona1.Name = "datosPersona1";
         this.datosPersona1.Size = new System.Drawing.Size(388, 207);
         this.datosPersona1.TabIndex = 19;
         // 
         // textInteres
         // 
         this.textInteres.Location = new System.Drawing.Point(148, 305);
         this.textInteres.Name = "textInteres";
         this.textInteres.Size = new System.Drawing.Size(150, 20);
         this.textInteres.TabIndex = 32;
         this.textInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(35, 308);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(107, 13);
         this.label5.TabIndex = 31;
         this.label5.Text = "Porcentaje de interés";
         // 
         // numericUpDown1
         // 
         this.numericUpDown1.Location = new System.Drawing.Point(122, 273);
         this.numericUpDown1.Name = "numericUpDown1";
         this.numericUpDown1.Size = new System.Drawing.Size(78, 20);
         this.numericUpDown1.TabIndex = 30;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(35, 277);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(81, 13);
         this.label4.TabIndex = 29;
         this.label4.Text = "Plazo en meses";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(35, 248);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(41, 13);
         this.label2.TabIndex = 27;
         this.label2.Text = "Cuenta";
         // 
         // cmbCuenta
         // 
         this.cmbCuenta.FormattingEnabled = true;
         this.cmbCuenta.Location = new System.Drawing.Point(91, 244);
         this.cmbCuenta.Name = "cmbCuenta";
         this.cmbCuenta.Size = new System.Drawing.Size(207, 21);
         this.cmbCuenta.TabIndex = 33;
         // 
         // btnGenerarCronograma
         // 
         this.btnGenerarCronograma.BackColor = System.Drawing.Color.ForestGreen;
         this.btnGenerarCronograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnGenerarCronograma.ForeColor = System.Drawing.Color.White;
         this.btnGenerarCronograma.Location = new System.Drawing.Point(106, 345);
         this.btnGenerarCronograma.Name = "btnGenerarCronograma";
         this.btnGenerarCronograma.Size = new System.Drawing.Size(131, 23);
         this.btnGenerarCronograma.TabIndex = 34;
         this.btnGenerarCronograma.Text = "Generar Cronograma";
         this.btnGenerarCronograma.UseVisualStyleBackColor = false;
         // 
         // UCrefinanciar
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.Controls.Add(this.btnGenerarCronograma);
         this.Controls.Add(this.cmbCuenta);
         this.Controls.Add(this.textInteres);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.numericUpDown1);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.datosPersona1);
         this.Margin = new System.Windows.Forms.Padding(3);
         this.Name = "UCrefinanciar";
         this.Padding = new System.Windows.Forms.Padding(6);
         this.Size = new System.Drawing.Size(874, 618);
         this.Load += new System.EventHandler(this.UCrefinanciar_Load);
         this.Controls.SetChildIndex(this.proceder1, 0);
         this.Controls.SetChildIndex(this.datosPersona1, 0);
         this.Controls.SetChildIndex(this.label2, 0);
         this.Controls.SetChildIndex(this.label4, 0);
         this.Controls.SetChildIndex(this.numericUpDown1, 0);
         this.Controls.SetChildIndex(this.label5, 0);
         this.Controls.SetChildIndex(this.textInteres, 0);
         this.Controls.SetChildIndex(this.cmbCuenta, 0);
         this.Controls.SetChildIndex(this.btnGenerarCronograma, 0);
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private Controles.DatosPersona datosPersona1;
        private System.Windows.Forms.TextBox textInteres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCuenta;
        private System.Windows.Forms.Button btnGenerarCronograma;
    }
}
