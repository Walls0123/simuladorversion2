namespace Sistema_Bancario.Froms_opciones
{
    partial class Envio_Giros
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClave = new Sistema_Bancario.Controles.TextBoxViewPassword();
            this.tipoMoneda1 = new Sistema_Bancario.Controles.TipoMoneda();
            this.dni1 = new Sistema_Bancario.Controles.DNI();
            this.dni2 = new Sistema_Bancario.Controles.DNI();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.monto1 = new Sistema_Bancario.Monto();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(6, 470);
            this.proceder1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.proceder1.Size = new System.Drawing.Size(731, 40);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "DNI (Destino) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "DNI (Origen) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Clave :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Monto :";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(142, 119);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(201, 20);
            this.txtClave.TabIndex = 35;
            // 
            // tipoMoneda1
            // 
            this.tipoMoneda1.Location = new System.Drawing.Point(357, 91);
            this.tipoMoneda1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tipoMoneda1.Name = "tipoMoneda1";
            this.tipoMoneda1.Size = new System.Drawing.Size(135, 25);
            this.tipoMoneda1.TabIndex = 36;
            // 
            // dni1
            // 
            this.dni1.Location = new System.Drawing.Point(142, 40);
            this.dni1.Margin = new System.Windows.Forms.Padding(2);
            this.dni1.Name = "dni1";
            this.dni1.Size = new System.Drawing.Size(188, 47);
            this.dni1.TabIndex = 37;
            // 
            // dni2
            // 
            this.dni2.Location = new System.Drawing.Point(142, 140);
            this.dni2.Margin = new System.Windows.Forms.Padding(2);
            this.dni2.Name = "dni2";
            this.dni2.Size = new System.Drawing.Size(188, 47);
            this.dni2.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Nombre";
            // 
            // monto1
            // 
            this.monto1.Location = new System.Drawing.Point(142, 94);
            this.monto1.Margin = new System.Windows.Forms.Padding(2);
            this.monto1.Name = "monto1";
            this.monto1.Size = new System.Drawing.Size(193, 20);
            this.monto1.TabIndex = 41;
            // 
            // Envio_Giros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.monto1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dni2);
            this.Controls.Add(this.dni1);
            this.Controls.Add(this.tipoMoneda1);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "Envio_Giros";
            this.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Size = new System.Drawing.Size(743, 516);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtClave, 0);
            this.Controls.SetChildIndex(this.tipoMoneda1, 0);
            this.Controls.SetChildIndex(this.dni1, 0);
            this.Controls.SetChildIndex(this.dni2, 0);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.monto1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      #endregion
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private Controles.TextBoxViewPassword txtClave;
        private Controles.TipoMoneda tipoMoneda1;
        private Controles.DNI dni1;
        private Controles.DNI dni2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Monto monto1;
    }
}
