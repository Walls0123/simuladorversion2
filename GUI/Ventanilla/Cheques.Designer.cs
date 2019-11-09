namespace Sistema_Bancario.Ventanilla
{
    partial class Cheques
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
            this.TBNroCheque = new System.Windows.Forms.TextBox();
            this.CKDeposito = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monto1 = new Sistema_Bancario.Monto();
            this.nroCuenta1 = new Sistema_Bancario.Controles.NroCuenta();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dni2 = new Sistema_Bancario.Controles.DNI();
            this.label4 = new System.Windows.Forms.Label();
            this.BtActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(11, 431);
            this.proceder1.Size = new System.Drawing.Size(586, 40);
            // 
            // TBNroCheque
            // 
            this.TBNroCheque.Location = new System.Drawing.Point(111, 67);
            this.TBNroCheque.Name = "TBNroCheque";
            this.TBNroCheque.Size = new System.Drawing.Size(193, 20);
            this.TBNroCheque.TabIndex = 1;
            this.TBNroCheque.TextChanged += new System.EventHandler(this.TBNroCheque_TextChanged);
            // 
            // CKDeposito
            // 
            this.CKDeposito.AutoSize = true;
            this.CKDeposito.Location = new System.Drawing.Point(25, 123);
            this.CKDeposito.Name = "CKDeposito";
            this.CKDeposito.Size = new System.Drawing.Size(68, 17);
            this.CKDeposito.TabIndex = 4;
            this.CKDeposito.Text = "Deposito";
            this.CKDeposito.UseVisualStyleBackColor = true;
            this.CKDeposito.CheckedChanged += new System.EventHandler(this.CKDeposito_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nro Cheque";
            // 
            // monto1
            // 
            this.monto1.Location = new System.Drawing.Point(111, 91);
            this.monto1.Margin = new System.Windows.Forms.Padding(2);
            this.monto1.Name = "monto1";
            this.monto1.Size = new System.Drawing.Size(193, 20);
            this.monto1.TabIndex = 6;
            // 
            // nroCuenta1
            // 
            this.nroCuenta1.EstadoCuenta = null;
            this.nroCuenta1.Location = new System.Drawing.Point(18, 145);
            this.nroCuenta1.Margin = new System.Windows.Forms.Padding(2);
            this.nroCuenta1.Name = "nroCuenta1";
            this.nroCuenta1.Size = new System.Drawing.Size(256, 94);
            this.nroCuenta1.TabIndex = 7;
            this.nroCuenta1.VersionCuenta = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Monto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "DNI: ";
            // 
            // dni2
            // 
            this.dni2.Location = new System.Drawing.Point(111, 12);
            this.dni2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dni2.Name = "dni2";
            this.dni2.Size = new System.Drawing.Size(188, 47);
            this.dni2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nombre:";
            // 
            // BtActualizar
            // 
            this.BtActualizar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtActualizar.ForeColor = System.Drawing.Color.White;
            this.BtActualizar.Location = new System.Drawing.Point(310, 65);
            this.BtActualizar.Name = "BtActualizar";
            this.BtActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtActualizar.TabIndex = 13;
            this.BtActualizar.Text = "Actualizar";
            this.BtActualizar.UseVisualStyleBackColor = false;
            this.BtActualizar.Click += new System.EventHandler(this.BtActualizar_Click);
            // 
            // Cheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtActualizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dni2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nroCuenta1);
            this.Controls.Add(this.monto1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CKDeposito);
            this.Controls.Add(this.TBNroCheque);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cheques";
            this.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Size = new System.Drawing.Size(608, 481);
            this.Controls.SetChildIndex(this.TBNroCheque, 0);
            this.Controls.SetChildIndex(this.CKDeposito, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.monto1, 0);
            this.Controls.SetChildIndex(this.nroCuenta1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dni2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.BtActualizar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBNroCheque;
        private System.Windows.Forms.CheckBox CKDeposito;
        private System.Windows.Forms.Label label1;
        private Monto monto1;
        private Controles.NroCuenta nroCuenta1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Controles.DNI dni2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtActualizar;
    }
}
