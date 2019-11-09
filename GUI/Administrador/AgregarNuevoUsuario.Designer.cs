namespace Sistema_Bancario.Administrador
{
    partial class AgregarNuevoUsuario
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
            this.pnlAgregarUsuario = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInsertarUsuario = new System.Windows.Forms.Button();
            this.chbEstado = new System.Windows.Forms.CheckBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.lblBuscarUsuario = new System.Windows.Forms.Label();
            this.txtUsuarioBuscado = new System.Windows.Forms.TextBox();
            this.pnlAgregarUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAgregarUsuario
            // 
            this.pnlAgregarUsuario.Controls.Add(this.btnCancelar);
            this.pnlAgregarUsuario.Controls.Add(this.btnInsertarUsuario);
            this.pnlAgregarUsuario.Controls.Add(this.chbEstado);
            this.pnlAgregarUsuario.Controls.Add(this.txtContraseña);
            this.pnlAgregarUsuario.Controls.Add(this.lblContraseña);
            this.pnlAgregarUsuario.Controls.Add(this.lblUsuario);
            this.pnlAgregarUsuario.Controls.Add(this.txtUsuario);
            this.pnlAgregarUsuario.Controls.Add(this.btnBuscarUsuario);
            this.pnlAgregarUsuario.Controls.Add(this.lblBuscarUsuario);
            this.pnlAgregarUsuario.Controls.Add(this.txtUsuarioBuscado);
            this.pnlAgregarUsuario.Location = new System.Drawing.Point(96, 24);
            this.pnlAgregarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAgregarUsuario.Name = "pnlAgregarUsuario";
            this.pnlAgregarUsuario.Size = new System.Drawing.Size(357, 418);
            this.pnlAgregarUsuario.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(210, 313);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnInsertarUsuario
            // 
            this.btnInsertarUsuario.Location = new System.Drawing.Point(28, 313);
            this.btnInsertarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertarUsuario.Name = "btnInsertarUsuario";
            this.btnInsertarUsuario.Size = new System.Drawing.Size(132, 28);
            this.btnInsertarUsuario.TabIndex = 10;
            this.btnInsertarUsuario.Text = "Agregar Usuario";
            this.btnInsertarUsuario.UseVisualStyleBackColor = true;
            this.btnInsertarUsuario.Click += new System.EventHandler(this.btnInsertarUsuario_Click);
            // 
            // chbEstado
            // 
            this.chbEstado.AutoSize = true;
            this.chbEstado.Location = new System.Drawing.Point(130, 268);
            this.chbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.chbEstado.Name = "chbEstado";
            this.chbEstado.Size = new System.Drawing.Size(74, 21);
            this.chbEstado.TabIndex = 9;
            this.chbEstado.Text = "Estado";
            this.chbEstado.UseVisualStyleBackColor = true;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(103, 223);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(132, 22);
            this.txtContraseña.TabIndex = 6;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(103, 204);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(81, 17);
            this.lblContraseña.TabIndex = 5;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(103, 131);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 17);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(103, 151);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtUsuario.TabIndex = 3;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Location = new System.Drawing.Point(244, 72);
            this.btnBuscarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(40, 28);
            this.btnBuscarUsuario.TabIndex = 2;
            this.btnBuscarUsuario.Text = "...";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // lblBuscarUsuario
            // 
            this.lblBuscarUsuario.AutoSize = true;
            this.lblBuscarUsuario.Location = new System.Drawing.Point(99, 51);
            this.lblBuscarUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarUsuario.Name = "lblBuscarUsuario";
            this.lblBuscarUsuario.Size = new System.Drawing.Size(109, 17);
            this.lblBuscarUsuario.TabIndex = 1;
            this.lblBuscarUsuario.Text = "Buscar Usuario:";
            // 
            // txtUsuarioBuscado
            // 
            this.txtUsuarioBuscado.Location = new System.Drawing.Point(103, 75);
            this.txtUsuarioBuscado.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuarioBuscado.Name = "txtUsuarioBuscado";
            this.txtUsuarioBuscado.Size = new System.Drawing.Size(132, 22);
            this.txtUsuarioBuscado.TabIndex = 0;
            // 
            // AgregarNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 455);
            this.Controls.Add(this.pnlAgregarUsuario);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AgregarNuevoUsuario";
            this.Text = "frmAgregarNuevoUsuario";
            this.pnlAgregarUsuario.ResumeLayout(false);
            this.pnlAgregarUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInsertarUsuario;
        private System.Windows.Forms.CheckBox chbEstado;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Label lblBuscarUsuario;
        public System.Windows.Forms.Panel pnlAgregarUsuario;
        public System.Windows.Forms.TextBox txtUsuarioBuscado;
        public System.Windows.Forms.TextBox txtContraseña;
        public System.Windows.Forms.TextBox txtUsuario;
    }
}