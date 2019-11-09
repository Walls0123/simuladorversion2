namespace Sistema_Bancario.Plataforma
{
    partial class UCactualizarCuenta
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
         this.nroCuenta1 = new Sistema_Bancario.Controles.NroCuenta();
         this.label1 = new System.Windows.Forms.Label();
         this.cmbEstado = new System.Windows.Forms.ComboBox();
         this.label2 = new System.Windows.Forms.Label();
         this.txtTarjeta = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // proceder1
         // 
         this.proceder1.Location = new System.Drawing.Point(6, 572);
         this.proceder1.Size = new System.Drawing.Size(862, 40);
         // 
         // nroCuenta1
         // 
         this.nroCuenta1.Location = new System.Drawing.Point(34, 28);
         this.nroCuenta1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.nroCuenta1.Name = "nroCuenta1";
         this.nroCuenta1.Size = new System.Drawing.Size(270, 30);
         this.nroCuenta1.TabIndex = 5;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(36, 73);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(40, 13);
         this.label1.TabIndex = 6;
         this.label1.Text = "Estado";
         // 
         // cmbEstado
         // 
         this.cmbEstado.FormattingEnabled = true;
         this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Bloqueado"});
         this.cmbEstado.Location = new System.Drawing.Point(101, 69);
         this.cmbEstado.Name = "cmbEstado";
         this.cmbEstado.Size = new System.Drawing.Size(121, 21);
         this.cmbEstado.TabIndex = 7;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(36, 107);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(54, 13);
         this.label2.TabIndex = 8;
         this.label2.Text = "ID Tarjeta";
         // 
         // txtTarjeta
         // 
         this.txtTarjeta.Location = new System.Drawing.Point(101, 104);
         this.txtTarjeta.Name = "txtTarjeta";
         this.txtTarjeta.Size = new System.Drawing.Size(121, 20);
         this.txtTarjeta.TabIndex = 9;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(36, 145);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(67, 13);
         this.label3.TabIndex = 10;
         this.label3.Text = "Contadores?";
         // 
         // UCactualizarCuenta
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.label3);
         this.Controls.Add(this.txtTarjeta);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.cmbEstado);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.nroCuenta1);
         this.Margin = new System.Windows.Forms.Padding(3);
         this.Name = "UCactualizarCuenta";
         this.Padding = new System.Windows.Forms.Padding(6);
         this.Size = new System.Drawing.Size(874, 618);
         this.Load += new System.EventHandler(this.UCactualizarCuenta_Load);
         this.Controls.SetChildIndex(this.proceder1, 0);
         this.Controls.SetChildIndex(this.nroCuenta1, 0);
         this.Controls.SetChildIndex(this.label1, 0);
         this.Controls.SetChildIndex(this.cmbEstado, 0);
         this.Controls.SetChildIndex(this.label2, 0);
         this.Controls.SetChildIndex(this.txtTarjeta, 0);
         this.Controls.SetChildIndex(this.label3, 0);
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private Controles.NroCuenta nroCuenta1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Label label3;
    }
}
