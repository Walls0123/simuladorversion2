namespace Sistema_Bancario.Administrador
{
    partial class Roles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roles));
            this.pnlSecundario = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpUsuarios = new System.Windows.Forms.TabPage();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.tbpPermisos = new System.Windows.Forms.TabPage();
            this.dgvPermisosRol = new System.Windows.Forms.DataGridView();
            this.pnlAgregarUsuario = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInsertarUsuario = new System.Windows.Forms.Button();
            this.chbEstado = new System.Windows.Forms.CheckBox();
            this.lblNuevoUsuario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtNombrePersona = new System.Windows.Forms.TextBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.lblBuscarUsuario = new System.Windows.Forms.Label();
            this.txtUsuarioBuscado = new System.Windows.Forms.TextBox();
            this.btnEditarRol = new System.Windows.Forms.Button();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.btnEliminarRol = new System.Windows.Forms.Button();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnAgregarPermisosRol = new System.Windows.Forms.Button();
            this.pnlComponentesParaRol = new System.Windows.Forms.Panel();
            this.btnAgregarComponentesRol = new System.Windows.Forms.Button();
            this.btnCrearRolAtras = new System.Windows.Forms.Button();
            this.lvlComponentes = new System.Windows.Forms.Label();
            this.dgvCrearComponentesRol = new System.Windows.Forms.DataGridView();
            this.pnlSecundario.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.tbpPermisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisosRol)).BeginInit();
            this.pnlAgregarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.pnlComponentesParaRol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrearComponentesRol)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSecundario
            // 
            this.pnlSecundario.Controls.Add(this.tabControl1);
            this.pnlSecundario.Location = new System.Drawing.Point(115, 15);
            this.pnlSecundario.Name = "pnlSecundario";
            this.pnlSecundario.Size = new System.Drawing.Size(640, 445);
            this.pnlSecundario.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpUsuarios);
            this.tabControl1.Controls.Add(this.tbpPermisos);
            this.tabControl1.Location = new System.Drawing.Point(10, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(617, 409);
            this.tabControl1.TabIndex = 7;
            // 
            // tbpUsuarios
            // 
            this.tbpUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.tbpUsuarios.Controls.Add(this.btnAtras);
            this.tbpUsuarios.Controls.Add(this.btnEditar);
            this.tbpUsuarios.Controls.Add(this.btnEliminar);
            this.tbpUsuarios.Controls.Add(this.btnAgregarUsuario);
            this.tbpUsuarios.Controls.Add(this.dgvUsuarios);
            this.tbpUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tbpUsuarios.Name = "tbpUsuarios";
            this.tbpUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUsuarios.Size = new System.Drawing.Size(609, 383);
            this.tbpUsuarios.TabIndex = 0;
            this.tbpUsuarios.Text = "Usuarios";
            this.tbpUsuarios.Click += new System.EventHandler(this.tbpUsuarios_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtras.BackgroundImage")));
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.Location = new System.Drawing.Point(25, 20);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(42, 43);
            this.btnAtras.TabIndex = 8;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::Sistema_Bancario.Properties.Resources.icons8_editar_32;
            this.btnEditar.Location = new System.Drawing.Point(481, 180);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Sistema_Bancario.Properties.Resources.icons8_eliminar_26;
            this.btnEliminar.Location = new System.Drawing.Point(481, 269);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(50, 50);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Image = global::Sistema_Bancario.Properties.Resources.icons8_agregar_administrador_26;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(481, 99);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(50, 50);
            this.btnAgregarUsuario.TabIndex = 7;
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(113, 64);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(329, 295);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // tbpPermisos
            // 
            this.tbpPermisos.Controls.Add(this.dgvPermisosRol);
            this.tbpPermisos.Location = new System.Drawing.Point(4, 22);
            this.tbpPermisos.Name = "tbpPermisos";
            this.tbpPermisos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPermisos.Size = new System.Drawing.Size(609, 383);
            this.tbpPermisos.TabIndex = 1;
            this.tbpPermisos.Text = "Permisos";
            this.tbpPermisos.UseVisualStyleBackColor = true;
            // 
            // dgvPermisosRol
            // 
            this.dgvPermisosRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisosRol.Location = new System.Drawing.Point(117, 18);
            this.dgvPermisosRol.Name = "dgvPermisosRol";
            this.dgvPermisosRol.Size = new System.Drawing.Size(353, 327);
            this.dgvPermisosRol.TabIndex = 0;
            // 
            // pnlAgregarUsuario
            // 
            this.pnlAgregarUsuario.Controls.Add(this.btnCancelar);
            this.pnlAgregarUsuario.Controls.Add(this.btnInsertarUsuario);
            this.pnlAgregarUsuario.Controls.Add(this.chbEstado);
            this.pnlAgregarUsuario.Controls.Add(this.lblNuevoUsuario);
            this.pnlAgregarUsuario.Controls.Add(this.lblUsuario);
            this.pnlAgregarUsuario.Controls.Add(this.txtNombrePersona);
            this.pnlAgregarUsuario.Controls.Add(this.btnBuscarUsuario);
            this.pnlAgregarUsuario.Controls.Add(this.lblBuscarUsuario);
            this.pnlAgregarUsuario.Controls.Add(this.txtUsuarioBuscado);
            this.pnlAgregarUsuario.Location = new System.Drawing.Point(115, 15);
            this.pnlAgregarUsuario.Name = "pnlAgregarUsuario";
            this.pnlAgregarUsuario.Size = new System.Drawing.Size(640, 445);
            this.pnlAgregarUsuario.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(344, 270);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnInsertarUsuario
            // 
            this.btnInsertarUsuario.Location = new System.Drawing.Point(208, 270);
            this.btnInsertarUsuario.Name = "btnInsertarUsuario";
            this.btnInsertarUsuario.Size = new System.Drawing.Size(99, 23);
            this.btnInsertarUsuario.TabIndex = 10;
            this.btnInsertarUsuario.Text = "Agregar Usuario";
            this.btnInsertarUsuario.UseVisualStyleBackColor = true;
            this.btnInsertarUsuario.Click += new System.EventHandler(this.btnInsertarUsuario_Click);
            // 
            // chbEstado
            // 
            this.chbEstado.AutoSize = true;
            this.chbEstado.Location = new System.Drawing.Point(284, 186);
            this.chbEstado.Name = "chbEstado";
            this.chbEstado.Size = new System.Drawing.Size(59, 17);
            this.chbEstado.TabIndex = 9;
            this.chbEstado.Text = "Estado";
            this.chbEstado.UseVisualStyleBackColor = true;
            // 
            // lblNuevoUsuario
            // 
            this.lblNuevoUsuario.AutoSize = true;
            this.lblNuevoUsuario.Location = new System.Drawing.Point(36, 28);
            this.lblNuevoUsuario.Name = "lblNuevoUsuario";
            this.lblNuevoUsuario.Size = new System.Drawing.Size(78, 13);
            this.lblNuevoUsuario.TabIndex = 7;
            this.lblNuevoUsuario.Text = "Nuevo Usuario";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(264, 122);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtNombrePersona
            // 
            this.txtNombrePersona.Location = new System.Drawing.Point(264, 138);
            this.txtNombrePersona.Name = "txtNombrePersona";
            this.txtNombrePersona.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePersona.TabIndex = 3;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Location = new System.Drawing.Point(370, 74);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(30, 23);
            this.btnBuscarUsuario.TabIndex = 2;
            this.btnBuscarUsuario.Text = "...";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // lblBuscarUsuario
            // 
            this.lblBuscarUsuario.AutoSize = true;
            this.lblBuscarUsuario.Location = new System.Drawing.Point(261, 57);
            this.lblBuscarUsuario.Name = "lblBuscarUsuario";
            this.lblBuscarUsuario.Size = new System.Drawing.Size(82, 13);
            this.lblBuscarUsuario.TabIndex = 1;
            this.lblBuscarUsuario.Text = "Buscar Usuario:";
            // 
            // txtUsuarioBuscado
            // 
            this.txtUsuarioBuscado.Location = new System.Drawing.Point(264, 76);
            this.txtUsuarioBuscado.Name = "txtUsuarioBuscado";
            this.txtUsuarioBuscado.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioBuscado.TabIndex = 0;
            // 
            // btnEditarRol
            // 
            this.btnEditarRol.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarRol.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEditarRol.Location = new System.Drawing.Point(445, 218);
            this.btnEditarRol.Name = "btnEditarRol";
            this.btnEditarRol.Size = new System.Drawing.Size(100, 40);
            this.btnEditarRol.TabIndex = 4;
            this.btnEditarRol.Text = "Editar rol";
            this.btnEditarRol.UseVisualStyleBackColor = false;
            this.btnEditarRol.Click += new System.EventHandler(this.btnEditarRol_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(442, 103);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(73, 13);
            this.lblRol.TabIndex = 0;
            this.lblRol.Text = "Nombre de rol";
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(445, 122);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(100, 20);
            this.txtRol.TabIndex = 1;
            // 
            // btnEliminarRol
            // 
            this.btnEliminarRol.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRol.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEliminarRol.Location = new System.Drawing.Point(445, 273);
            this.btnEliminarRol.Name = "btnEliminarRol";
            this.btnEliminarRol.Size = new System.Drawing.Size(100, 40);
            this.btnEliminarRol.TabIndex = 5;
            this.btnEliminarRol.Text = "Eliminar rol";
            this.btnEliminarRol.UseVisualStyleBackColor = false;
            this.btnEliminarRol.Click += new System.EventHandler(this.btnEliminarRol_Click);
            // 
            // dgvRoles
            // 
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(127, 73);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.ReadOnly = true;
            this.dgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoles.Size = new System.Drawing.Size(247, 283);
            this.dgvRoles.TabIndex = 2;
            this.dgvRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellClick);
            this.dgvRoles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(445, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar rol";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnAgregarRol_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.btnAgregarPermisosRol);
            this.pnlPrincipal.Controls.Add(this.button1);
            this.pnlPrincipal.Controls.Add(this.dgvRoles);
            this.pnlPrincipal.Controls.Add(this.btnEliminarRol);
            this.pnlPrincipal.Controls.Add(this.txtRol);
            this.pnlPrincipal.Controls.Add(this.lblRol);
            this.pnlPrincipal.Controls.Add(this.btnEditarRol);
            this.pnlPrincipal.Location = new System.Drawing.Point(115, 15);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(640, 445);
            this.pnlPrincipal.TabIndex = 6;
            //this.pnlPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPrincipal_Paint);
            // 
            // btnAgregarPermisosRol
            // 
            this.btnAgregarPermisosRol.Location = new System.Drawing.Point(423, 346);
            this.btnAgregarPermisosRol.Name = "btnAgregarPermisosRol";
            this.btnAgregarPermisosRol.Size = new System.Drawing.Size(137, 23);
            this.btnAgregarPermisosRol.TabIndex = 6;
            this.btnAgregarPermisosRol.Text = "Agregar permisos a rol";
            this.btnAgregarPermisosRol.UseVisualStyleBackColor = true;
            this.btnAgregarPermisosRol.Click += new System.EventHandler(this.btnAgregarPermisosRol_Click);
            // 
            // pnlComponentesParaRol
            // 
            this.pnlComponentesParaRol.Controls.Add(this.btnAgregarComponentesRol);
            this.pnlComponentesParaRol.Controls.Add(this.btnCrearRolAtras);
            this.pnlComponentesParaRol.Controls.Add(this.lvlComponentes);
            this.pnlComponentesParaRol.Controls.Add(this.dgvCrearComponentesRol);
            this.pnlComponentesParaRol.Location = new System.Drawing.Point(115, 15);
            this.pnlComponentesParaRol.Name = "pnlComponentesParaRol";
            this.pnlComponentesParaRol.Size = new System.Drawing.Size(640, 445);
            this.pnlComponentesParaRol.TabIndex = 8;
            // 
            // btnAgregarComponentesRol
            // 
            this.btnAgregarComponentesRol.Location = new System.Drawing.Point(488, 398);
            this.btnAgregarComponentesRol.Name = "btnAgregarComponentesRol";
            this.btnAgregarComponentesRol.Size = new System.Drawing.Size(112, 23);
            this.btnAgregarComponentesRol.TabIndex = 3;
            this.btnAgregarComponentesRol.Text = "Agregar componentes";
            this.btnAgregarComponentesRol.UseVisualStyleBackColor = true;
            this.btnAgregarComponentesRol.Click += new System.EventHandler(this.btnAgregarComponentesRol_Click);
            // 
            // btnCrearRolAtras
            // 
            this.btnCrearRolAtras.Location = new System.Drawing.Point(525, 21);
            this.btnCrearRolAtras.Name = "btnCrearRolAtras";
            this.btnCrearRolAtras.Size = new System.Drawing.Size(75, 23);
            this.btnCrearRolAtras.TabIndex = 2;
            this.btnCrearRolAtras.Text = "Atras";
            this.btnCrearRolAtras.UseVisualStyleBackColor = true;
            this.btnCrearRolAtras.Click += new System.EventHandler(this.btnCrearRolAtras_Click);
            // 
            // lvlComponentes
            // 
            this.lvlComponentes.AutoSize = true;
            this.lvlComponentes.Location = new System.Drawing.Point(22, 26);
            this.lvlComponentes.Name = "lvlComponentes";
            this.lvlComponentes.Size = new System.Drawing.Size(204, 13);
            this.lvlComponentes.TabIndex = 1;
            this.lvlComponentes.Text = "Seleccionar componentes para nuevo rol:";
            // 
            // dgvCrearComponentesRol
            // 
            this.dgvCrearComponentesRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrearComponentesRol.Location = new System.Drawing.Point(25, 46);
            this.dgvCrearComponentesRol.Name = "dgvCrearComponentesRol";
            this.dgvCrearComponentesRol.Size = new System.Drawing.Size(575, 321);
            this.dgvCrearComponentesRol.TabIndex = 0;
            this.dgvCrearComponentesRol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCrearComponentesRol_CellContentClick);
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlSecundario);
            this.Controls.Add(this.pnlAgregarUsuario);
            this.Controls.Add(this.pnlComponentesParaRol);
            this.Name = "Roles";
            this.Size = new System.Drawing.Size(2181, 926);
            this.pnlSecundario.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbpUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.tbpPermisos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisosRol)).EndInit();
            this.pnlAgregarUsuario.ResumeLayout(false);
            this.pnlAgregarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlComponentesParaRol.ResumeLayout(false);
            this.pnlComponentesParaRol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrearComponentesRol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSecundario;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TabPage tbpPermisos;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Panel pnlAgregarUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInsertarUsuario;
        private System.Windows.Forms.CheckBox chbEstado;
        private System.Windows.Forms.Label lblNuevoUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtNombrePersona;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Label lblBuscarUsuario;
        private System.Windows.Forms.TextBox txtUsuarioBuscado;
        private System.Windows.Forms.DataGridView dgvPermisosRol;
        private System.Windows.Forms.Button btnEditarRol;
        private System.Windows.Forms.Label lblRol;
        public System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.Button btnEliminarRol;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Panel pnlComponentesParaRol;
        private System.Windows.Forms.DataGridView dgvCrearComponentesRol;
        private System.Windows.Forms.Label lvlComponentes;
        private System.Windows.Forms.Button btnCrearRolAtras;
        private System.Windows.Forms.Button btnAgregarComponentesRol;
        private System.Windows.Forms.Button btnAgregarPermisosRol;
    }
}
