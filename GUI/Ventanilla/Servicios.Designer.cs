namespace Sistema_Bancario.Froms_opciones
{
    partial class Servicios
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
            this.empresa1 = new Sistema_Bancario.Controles.Empresa();
            this.nroContrato1 = new Sistema_Bancario.Controles.NroContrato();
            this.GEmpresas = new System.Windows.Forms.DataGridView();
            this.GNroContrato = new System.Windows.Forms.DataGridView();
            this.BTBuscarEmpresa = new System.Windows.Forms.Button();
            this.BTNroContrato = new System.Windows.Forms.Button();
            this.dni1 = new Sistema_Bancario.Controles.DNI();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GNroContrato)).BeginInit();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(6, 518);
            this.proceder1.Size = new System.Drawing.Size(613, 40);
            // 
            // empresa1
            // 
            this.empresa1.Location = new System.Drawing.Point(10, 11);
            this.empresa1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.empresa1.Name = "empresa1";
            this.empresa1.Size = new System.Drawing.Size(261, 26);
            this.empresa1.TabIndex = 3;
            // 
            // nroContrato1
            // 
            this.nroContrato1.Location = new System.Drawing.Point(10, 181);
            this.nroContrato1.Margin = new System.Windows.Forms.Padding(2);
            this.nroContrato1.Name = "nroContrato1";
            this.nroContrato1.Size = new System.Drawing.Size(261, 26);
            this.nroContrato1.TabIndex = 4;
            // 
            // GEmpresas
            // 
            this.GEmpresas.AllowUserToAddRows = false;
            this.GEmpresas.AllowUserToDeleteRows = false;
            this.GEmpresas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GEmpresas.Location = new System.Drawing.Point(10, 41);
            this.GEmpresas.Margin = new System.Windows.Forms.Padding(2);
            this.GEmpresas.Name = "GEmpresas";
            this.GEmpresas.ReadOnly = true;
            this.GEmpresas.RowTemplate.Height = 24;
            this.GEmpresas.Size = new System.Drawing.Size(585, 85);
            this.GEmpresas.TabIndex = 5;
            // 
            // GNroContrato
            // 
            this.GNroContrato.AllowUserToAddRows = false;
            this.GNroContrato.AllowUserToDeleteRows = false;
            this.GNroContrato.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GNroContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GNroContrato.Location = new System.Drawing.Point(10, 211);
            this.GNroContrato.Margin = new System.Windows.Forms.Padding(2);
            this.GNroContrato.Name = "GNroContrato";
            this.GNroContrato.ReadOnly = true;
            this.GNroContrato.RowTemplate.Height = 24;
            this.GNroContrato.Size = new System.Drawing.Size(585, 143);
            this.GNroContrato.TabIndex = 6;
            this.GNroContrato.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GNroContrato_CellClick);
            // 
            // BTBuscarEmpresa
            // 
            this.BTBuscarEmpresa.BackColor = System.Drawing.Color.ForestGreen;
            this.BTBuscarEmpresa.FlatAppearance.BorderSize = 0;
            this.BTBuscarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTBuscarEmpresa.ForeColor = System.Drawing.SystemColors.Window;
            this.BTBuscarEmpresa.Location = new System.Drawing.Point(276, 11);
            this.BTBuscarEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.BTBuscarEmpresa.Name = "BTBuscarEmpresa";
            this.BTBuscarEmpresa.Size = new System.Drawing.Size(88, 25);
            this.BTBuscarEmpresa.TabIndex = 7;
            this.BTBuscarEmpresa.Text = "Buscar";
            this.BTBuscarEmpresa.UseVisualStyleBackColor = false;
            this.BTBuscarEmpresa.Click += new System.EventHandler(this.BTBuscarEmpresa_Click);
            // 
            // BTNroContrato
            // 
            this.BTNroContrato.BackColor = System.Drawing.Color.ForestGreen;
            this.BTNroContrato.FlatAppearance.BorderSize = 0;
            this.BTNroContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNroContrato.ForeColor = System.Drawing.SystemColors.Window;
            this.BTNroContrato.Location = new System.Drawing.Point(275, 179);
            this.BTNroContrato.Margin = new System.Windows.Forms.Padding(2);
            this.BTNroContrato.Name = "BTNroContrato";
            this.BTNroContrato.Size = new System.Drawing.Size(88, 28);
            this.BTNroContrato.TabIndex = 8;
            this.BTNroContrato.Text = "Buscar";
            this.BTNroContrato.UseVisualStyleBackColor = false;
            this.BTNroContrato.Click += new System.EventHandler(this.BTNroContrato_Click);
            // 
            // dni1
            // 
            this.dni1.Location = new System.Drawing.Point(83, 130);
            this.dni1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dni1.Name = "dni1";
            this.dni1.Size = new System.Drawing.Size(188, 47);
            this.dni1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "DNI :  ";
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dni1);
            this.Controls.Add(this.BTNroContrato);
            this.Controls.Add(this.BTBuscarEmpresa);
            this.Controls.Add(this.GNroContrato);
            this.Controls.Add(this.GEmpresas);
            this.Controls.Add(this.nroContrato1);
            this.Controls.Add(this.empresa1);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "Servicios";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(625, 564);
            this.Controls.SetChildIndex(this.empresa1, 0);
            this.Controls.SetChildIndex(this.nroContrato1, 0);
            this.Controls.SetChildIndex(this.GEmpresas, 0);
            this.Controls.SetChildIndex(this.GNroContrato, 0);
            this.Controls.SetChildIndex(this.BTBuscarEmpresa, 0);
            this.Controls.SetChildIndex(this.BTNroContrato, 0);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.Controls.SetChildIndex(this.dni1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GNroContrato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.Empresa empresa1;
        private Controles.NroContrato nroContrato1;
        private System.Windows.Forms.DataGridView GEmpresas;
        private System.Windows.Forms.DataGridView GNroContrato;
        private System.Windows.Forms.Button BTBuscarEmpresa;
        private System.Windows.Forms.Button BTNroContrato;
        private Controles.DNI dni1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
