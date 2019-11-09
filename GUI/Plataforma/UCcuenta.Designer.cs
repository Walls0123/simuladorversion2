namespace Sistema_Bancario.Plataforma
{
    partial class UCcuenta
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
            this.tipoCuenta1 = new Sistema_Bancario.Controles.TipoCuenta();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(6, 572);
            this.proceder1.Size = new System.Drawing.Size(862, 40);
            // 
            // datosPersona1
            // 
            this.datosPersona1.Location = new System.Drawing.Point(20, 16);
            this.datosPersona1.Margin = new System.Windows.Forms.Padding(4);
            this.datosPersona1.Name = "datosPersona1";
            this.datosPersona1.Size = new System.Drawing.Size(392, 209);
            this.datosPersona1.TabIndex = 3;
            // 
            // tipoCuenta1
            // 
            this.tipoCuenta1.Location = new System.Drawing.Point(439, 17);
            this.tipoCuenta1.Margin = new System.Windows.Forms.Padding(2);
            this.tipoCuenta1.Name = "tipoCuenta1";
            this.tipoCuenta1.Size = new System.Drawing.Size(276, 84);
            this.tipoCuenta1.TabIndex = 4;
            // 
            // UCcuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tipoCuenta1);
            this.Controls.Add(this.datosPersona1);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "UCcuenta";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Load += new System.EventHandler(this.UCcuenta_Load);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.Controls.SetChildIndex(this.datosPersona1, 0);
            this.Controls.SetChildIndex(this.tipoCuenta1, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private Controles.DatosPersona datosPersona1;
        private Controles.TipoCuenta tipoCuenta1;
    }
}
