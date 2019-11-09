namespace Sistema_Bancario.Froms_opciones
{
    partial class Retiros
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtClave = new Sistema_Bancario.Controles.TextBoxViewPassword();
            this.nroCuenta1 = new Sistema_Bancario.Controles.NroCuenta();
            this.monto1 = new Sistema_Bancario.Monto();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tipoMoneda1 = new Sistema_Bancario.Controles.TipoMoneda();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(6, 299);
            this.proceder1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.proceder1.Size = new System.Drawing.Size(712, 40);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Clave :";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(72, 114);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(141, 20);
            this.txtClave.TabIndex = 19;
            // 
            // nroCuenta1
            // 
            this.nroCuenta1.Location = new System.Drawing.Point(6, 8);
            this.nroCuenta1.Margin = new System.Windows.Forms.Padding(2);
            this.nroCuenta1.Name = "nroCuenta1";
            this.nroCuenta1.Size = new System.Drawing.Size(773, 77);
            this.nroCuenta1.TabIndex = 21;
            // 
            // monto1
            // 
            this.monto1.Location = new System.Drawing.Point(73, 87);
            this.monto1.Margin = new System.Windows.Forms.Padding(2);
            this.monto1.Name = "monto1";
            this.monto1.Size = new System.Drawing.Size(204, 22);
            this.monto1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Monto :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(13, 147);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 35, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.panel1.Size = new System.Drawing.Size(679, 0);
            this.panel1.TabIndex = 29;
            // 
            // tipoMoneda1
            // 
            this.tipoMoneda1.Location = new System.Drawing.Point(280, 84);
            this.tipoMoneda1.Margin = new System.Windows.Forms.Padding(2);
            this.tipoMoneda1.Name = "tipoMoneda1";
            this.tipoMoneda1.Size = new System.Drawing.Size(138, 26);
            this.tipoMoneda1.TabIndex = 20;
            // 
            // Retiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monto1);
            this.Controls.Add(this.nroCuenta1);
            this.Controls.Add(this.tipoMoneda1);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Retiros";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(724, 345);
            this.Tag = "1";
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtClave, 0);
            this.Controls.SetChildIndex(this.tipoMoneda1, 0);
            this.Controls.SetChildIndex(this.nroCuenta1, 0);
            this.Controls.SetChildIndex(this.monto1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
      private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
      private System.Windows.Forms.Label label3;
      private Controles.TextBoxViewPassword txtClave;
        private Controles.NroCuenta nroCuenta1;
        private Monto monto1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Controles.TipoMoneda tipoMoneda1;
    }
}
