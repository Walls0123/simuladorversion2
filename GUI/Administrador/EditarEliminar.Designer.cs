namespace Sistema_Bancario.Administrador
{
    partial class EditarEliminar
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
            this.txtUsuarioEditar = new System.Windows.Forms.TextBox();
            this.lblUsuarioEditar = new System.Windows.Forms.Label();
            this.cmbRolesEditar = new System.Windows.Forms.ComboBox();
            this.chbActivo = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.idRolUsuario = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuarioEditar
            // 
            this.txtUsuarioEditar.Location = new System.Drawing.Point(68, 46);
            this.txtUsuarioEditar.Name = "txtUsuarioEditar";
            this.txtUsuarioEditar.Size = new System.Drawing.Size(121, 20);
            this.txtUsuarioEditar.TabIndex = 0;
            // 
            // lblUsuarioEditar
            // 
            this.lblUsuarioEditar.AutoSize = true;
            this.lblUsuarioEditar.Location = new System.Drawing.Point(19, 46);
            this.lblUsuarioEditar.Name = "lblUsuarioEditar";
            this.lblUsuarioEditar.Size = new System.Drawing.Size(43, 13);
            this.lblUsuarioEditar.TabIndex = 1;
            this.lblUsuarioEditar.Text = "Usuario";
            // 
            // cmbRolesEditar
            // 
            this.cmbRolesEditar.FormattingEnabled = true;
            this.cmbRolesEditar.Location = new System.Drawing.Point(68, 72);
            this.cmbRolesEditar.Name = "cmbRolesEditar";
            this.cmbRolesEditar.Size = new System.Drawing.Size(121, 21);
            this.cmbRolesEditar.TabIndex = 2;
            this.cmbRolesEditar.SelectedIndexChanged += new System.EventHandler(this.cmbRolesEditar_SelectedIndexChanged);
            // 
            // chbActivo
            // 
            this.chbActivo.AutoSize = true;
            this.chbActivo.Location = new System.Drawing.Point(98, 99);
            this.chbActivo.Name = "chbActivo";
            this.chbActivo.Size = new System.Drawing.Size(56, 17);
            this.chbActivo.TabIndex = 3;
            this.chbActivo.Text = "Activo";
            this.chbActivo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCancelar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.idRolUsuario);
            this.panel1.Controls.Add(this.txtIdUsuario);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.txtUsuarioEditar);
            this.panel1.Controls.Add(this.chbActivo);
            this.panel1.Controls.Add(this.lblUsuarioEditar);
            this.panel1.Controls.Add(this.cmbRolesEditar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 162);
            this.panel1.TabIndex = 4;
            // 
            // txtCancelar
            // 
            this.txtCancelar.Location = new System.Drawing.Point(159, 122);
            this.txtCancelar.Name = "txtCancelar";
            this.txtCancelar.Size = new System.Drawing.Size(75, 23);
            this.txtCancelar.TabIndex = 5;
            this.txtCancelar.Text = "Cancelar";
            this.txtCancelar.UseVisualStyleBackColor = true;
            this.txtCancelar.Click += new System.EventHandler(this.txtCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(22, 122);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // idRolUsuario
            // 
            this.idRolUsuario.Location = new System.Drawing.Point(14, 73);
            this.idRolUsuario.Name = "idRolUsuario";
            this.idRolUsuario.Size = new System.Drawing.Size(48, 20);
            this.idRolUsuario.TabIndex = 7;
            this.idRolUsuario.Visible = false;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(68, 20);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(121, 20);
            this.txtIdUsuario.TabIndex = 6;
            this.txtIdUsuario.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(22, 122);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // EditarEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 186);
            this.Controls.Add(this.panel1);
            this.Name = "EditarEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUsuarioEditar;
        private System.Windows.Forms.CheckBox chbActivo;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtUsuarioEditar;
        public System.Windows.Forms.TextBox txtIdUsuario;
        public System.Windows.Forms.TextBox idRolUsuario;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.ComboBox cmbRolesEditar;
        private System.Windows.Forms.Button txtCancelar;
    }
}