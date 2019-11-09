namespace Sistema_Bancario.Administrador
{
    partial class Permisos
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
            this.pnlAgregar = new System.Windows.Forms.Panel();
            this.pnlAgregarRoles = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnlAgregarUsuarios = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlSecundario = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Editar3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregarUsuarios = new System.Windows.Forms.Button();
            this.tabRoles = new System.Windows.Forms.TabPage();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregarRoles = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregarPermiso = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAgregar.SuspendLayout();
            this.pnlAgregarRoles.SuspendLayout();
            this.pnlAgregarUsuarios.SuspendLayout();
            this.pnlSecundario.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.tabRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAgregar
            // 
            this.pnlAgregar.Controls.Add(this.pnlAgregarRoles);
            this.pnlAgregar.Controls.Add(this.pnlAgregarUsuarios);
            this.pnlAgregar.Location = new System.Drawing.Point(41, 444);
            this.pnlAgregar.Name = "pnlAgregar";
            this.pnlAgregar.Size = new System.Drawing.Size(660, 400);
            this.pnlAgregar.TabIndex = 17;
            // 
            // pnlAgregarRoles
            // 
            this.pnlAgregarRoles.Controls.Add(this.label3);
            this.pnlAgregarRoles.Controls.Add(this.checkBox2);
            this.pnlAgregarRoles.Controls.Add(this.comboBox2);
            this.pnlAgregarRoles.Controls.Add(this.button5);
            this.pnlAgregarRoles.Controls.Add(this.button4);
            this.pnlAgregarRoles.Location = new System.Drawing.Point(398, 61);
            this.pnlAgregarRoles.Name = "pnlAgregarRoles";
            this.pnlAgregarRoles.Size = new System.Drawing.Size(284, 302);
            this.pnlAgregarRoles.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Agregar rol";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(76, 145);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(64, 17);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "Habilitar";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(35, 79);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(169, 21);
            this.comboBox2.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Window;
            this.button5.Location = new System.Drawing.Point(129, 228);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 25);
            this.button5.TabIndex = 15;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Location = new System.Drawing.Point(35, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 25);
            this.button4.TabIndex = 14;
            this.button4.Text = "Aceptar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pnlAgregarUsuarios
            // 
            this.pnlAgregarUsuarios.Controls.Add(this.label1);
            this.pnlAgregarUsuarios.Controls.Add(this.checkBox1);
            this.pnlAgregarUsuarios.Controls.Add(this.comboBox1);
            this.pnlAgregarUsuarios.Controls.Add(this.button3);
            this.pnlAgregarUsuarios.Controls.Add(this.button2);
            this.pnlAgregarUsuarios.Location = new System.Drawing.Point(82, 52);
            this.pnlAgregarUsuarios.Name = "pnlAgregarUsuarios";
            this.pnlAgregarUsuarios.Size = new System.Drawing.Size(285, 302);
            this.pnlAgregarUsuarios.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Agregar usuario";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(75, 145);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Habilitar";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(129, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 13;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(35, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 12;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pnlSecundario
            // 
            this.pnlSecundario.Controls.Add(this.btnAtras);
            this.pnlSecundario.Controls.Add(this.tabControl1);
            this.pnlSecundario.Location = new System.Drawing.Point(689, 28);
            this.pnlSecundario.Name = "pnlSecundario";
            this.pnlSecundario.Size = new System.Drawing.Size(660, 400);
            this.pnlSecundario.TabIndex = 16;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAtras.Location = new System.Drawing.Point(22, 38);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 25);
            this.btnAtras.TabIndex = 11;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUsuarios);
            this.tabControl1.Controls.Add(this.tabRoles);
            this.tabControl1.Location = new System.Drawing.Point(18, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(623, 325);
            this.tabControl1.TabIndex = 0;
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Controls.Add(this.dgvUsuarios);
            this.tabUsuarios.Controls.Add(this.btnAgregarUsuarios);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarios.Size = new System.Drawing.Size(615, 299);
            this.tabUsuarios.TabIndex = 0;
            this.tabUsuarios.Text = "Usuarios";
            this.tabUsuarios.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.NroDocumento,
            this.dataGridViewCheckBoxColumn1,
            this.Editar3,
            this.Eliminar3});
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 35);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(588, 245);
            this.dgvUsuarios.TabIndex = 17;
            this.dgvUsuarios.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvUsuarios_CellPainting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // NroDocumento
            // 
            this.NroDocumento.HeaderText = "NroDocumento";
            this.NroDocumento.Name = "NroDocumento";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Estado";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 80;
            // 
            // Editar3
            // 
            this.Editar3.HeaderText = "Editar";
            this.Editar3.Name = "Editar3";
            this.Editar3.ReadOnly = true;
            this.Editar3.Width = 50;
            // 
            // Eliminar3
            // 
            this.Eliminar3.HeaderText = "Eliminar";
            this.Eliminar3.Name = "Eliminar3";
            this.Eliminar3.ReadOnly = true;
            this.Eliminar3.Width = 50;
            // 
            // btnAgregarUsuarios
            // 
            this.btnAgregarUsuarios.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuarios.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregarUsuarios.Location = new System.Drawing.Point(525, 8);
            this.btnAgregarUsuarios.Name = "btnAgregarUsuarios";
            this.btnAgregarUsuarios.Size = new System.Drawing.Size(75, 25);
            this.btnAgregarUsuarios.TabIndex = 16;
            this.btnAgregarUsuarios.Text = "Agregar";
            this.btnAgregarUsuarios.UseVisualStyleBackColor = false;
            this.btnAgregarUsuarios.Click += new System.EventHandler(this.btnAgregarUsuarios_Click);
            // 
            // tabRoles
            // 
            this.tabRoles.Controls.Add(this.dgvRoles);
            this.tabRoles.Controls.Add(this.btnAgregarRoles);
            this.tabRoles.Location = new System.Drawing.Point(4, 22);
            this.tabRoles.Name = "tabRoles";
            this.tabRoles.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoles.Size = new System.Drawing.Size(615, 299);
            this.tabRoles.TabIndex = 1;
            this.tabRoles.Text = "Roles";
            this.tabRoles.UseVisualStyleBackColor = true;
            // 
            // dgvRoles
            // 
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.Editar4,
            this.Eliminar4});
            this.dgvRoles.Location = new System.Drawing.Point(12, 35);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.Size = new System.Drawing.Size(588, 245);
            this.dgvRoles.TabIndex = 18;
            this.dgvRoles.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvRoles_CellPainting);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // Editar4
            // 
            this.Editar4.HeaderText = "Editar";
            this.Editar4.Name = "Editar4";
            this.Editar4.ReadOnly = true;
            this.Editar4.Width = 50;
            // 
            // Eliminar4
            // 
            this.Eliminar4.HeaderText = "Eliminar";
            this.Eliminar4.Name = "Eliminar4";
            this.Eliminar4.ReadOnly = true;
            this.Eliminar4.Width = 50;
            // 
            // btnAgregarRoles
            // 
            this.btnAgregarRoles.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRoles.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregarRoles.Location = new System.Drawing.Point(525, 8);
            this.btnAgregarRoles.Name = "btnAgregarRoles";
            this.btnAgregarRoles.Size = new System.Drawing.Size(75, 25);
            this.btnAgregarRoles.TabIndex = 11;
            this.btnAgregarRoles.Text = "Agregar";
            this.btnAgregarRoles.UseVisualStyleBackColor = false;
            this.btnAgregarRoles.Click += new System.EventHandler(this.btnAgregarRoles_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.dgvPermisos);
            this.pnlPrincipal.Controls.Add(this.btnAgregarPermiso);
            this.pnlPrincipal.Controls.Add(this.label2);
            this.pnlPrincipal.Location = new System.Drawing.Point(60, 181);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(660, 400);
            this.pnlPrincipal.TabIndex = 15;
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Codigo,
            this.dataGridViewCheckBoxColumn3,
            this.Editar,
            this.Eliminar});
            this.dgvPermisos.Location = new System.Drawing.Point(35, 69);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.Size = new System.Drawing.Size(588, 245);
            this.dgvPermisos.TabIndex = 20;
            this.dgvPermisos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComponentes_CellClick);
            this.dgvPermisos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComponentes_CellDoubleClick);
            this.dgvPermisos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvComponentes_CellPainting);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 80;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.HeaderText = "Estado";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.Width = 80;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 50;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 50;
            // 
            // btnAgregarPermiso
            // 
            this.btnAgregarPermiso.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPermiso.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregarPermiso.Location = new System.Drawing.Point(548, 38);
            this.btnAgregarPermiso.Name = "btnAgregarPermiso";
            this.btnAgregarPermiso.Size = new System.Drawing.Size(75, 25);
            this.btnAgregarPermiso.TabIndex = 19;
            this.btnAgregarPermiso.Text = "Agregar";
            this.btnAgregarPermiso.UseVisualStyleBackColor = false;
            this.btnAgregarPermiso.Click += new System.EventHandler(this.btnAgregarPermiso_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Permisos";
            // 
            // Permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAgregar);
            this.Controls.Add(this.pnlSecundario);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "Permisos";
            this.Size = new System.Drawing.Size(931, 576);
            this.pnlAgregar.ResumeLayout(false);
            this.pnlAgregarRoles.ResumeLayout(false);
            this.pnlAgregarRoles.PerformLayout();
            this.pnlAgregarUsuarios.ResumeLayout(false);
            this.pnlAgregarUsuarios.PerformLayout();
            this.pnlSecundario.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.tabRoles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAgregar;
        private System.Windows.Forms.Panel pnlAgregarRoles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pnlAgregarUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlSecundario;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn Editar3;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar3;
        private System.Windows.Forms.Button btnAgregarUsuarios;
        private System.Windows.Forms.TabPage tabRoles;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn Editar4;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar4;
        private System.Windows.Forms.Button btnAgregarRoles;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Button btnAgregarPermiso;
        private System.Windows.Forms.Label label2;
    }
}
