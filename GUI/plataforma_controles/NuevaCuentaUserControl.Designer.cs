namespace Sistema_Bancario.plataforma_controles
{
    partial class NuevaCuentaUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaCuentaUserControl));
            this.cboMoneda = new System.Windows.Forms.ComboBox();
            this.cboTipoCuenta = new System.Windows.Forms.ComboBox();
            this.btnNombres = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.btnDocumento = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumero_documento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTipo_documento = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDeshacer = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SlblUsuario_creador = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SlblFecha_creacion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SlblUsuario_modificador = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SlblFecha_modificacion = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCodigo = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboMoneda
            // 
            this.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(129, 113);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(187, 21);
            this.cboMoneda.TabIndex = 0;
            // 
            // cboTipoCuenta
            // 
            this.cboTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCuenta.FormattingEnabled = true;
            this.cboTipoCuenta.Location = new System.Drawing.Point(129, 140);
            this.cboTipoCuenta.Name = "cboTipoCuenta";
            this.cboTipoCuenta.Size = new System.Drawing.Size(187, 21);
            this.cboTipoCuenta.TabIndex = 1;
            // 
            // btnNombres
            // 
            this.btnNombres.Location = new System.Drawing.Point(403, 59);
            this.btnNombres.Name = "btnNombres";
            this.btnNombres.Size = new System.Drawing.Size(33, 23);
            this.btnNombres.TabIndex = 18;
            this.btnNombres.Text = "...";
            this.btnNombres.UseVisualStyleBackColor = true;
            this.btnNombres.Click += new System.EventHandler(this.btnNombres_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombres:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(129, 61);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(268, 20);
            this.txtNombres.TabIndex = 16;
            // 
            // btnDocumento
            // 
            this.btnDocumento.Location = new System.Drawing.Point(322, 85);
            this.btnDocumento.Name = "btnDocumento";
            this.btnDocumento.Size = new System.Drawing.Size(33, 23);
            this.btnDocumento.TabIndex = 469;
            this.btnDocumento.Text = "...";
            this.btnDocumento.UseVisualStyleBackColor = true;
            this.btnDocumento.Click += new System.EventHandler(this.btnDocumento_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 468;
            this.label6.Text = "Numero Documento:";
            // 
            // txtNumero_documento
            // 
            this.txtNumero_documento.Location = new System.Drawing.Point(129, 87);
            this.txtNumero_documento.Name = "txtNumero_documento";
            this.txtNumero_documento.Size = new System.Drawing.Size(187, 20);
            this.txtNumero_documento.TabIndex = 467;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 466;
            this.label5.Text = "Tipo Documento:";
            this.label5.Visible = false;
            // 
            // cboTipo_documento
            // 
            this.cboTipo_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo_documento.FormattingEnabled = true;
            this.cboTipo_documento.Location = new System.Drawing.Point(129, 87);
            this.cboTipo_documento.Name = "cboTipo_documento";
            this.cboTipo_documento.Size = new System.Drawing.Size(187, 21);
            this.cboTipo_documento.TabIndex = 465;
            this.cboTipo_documento.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(129, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(268, 20);
            this.txtCodigo.TabIndex = 470;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 471;
            this.label1.Text = "Moneda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 472;
            this.label3.Text = "Tipo Cuenta:";
            // 
            // buttonDeshacer
            // 
            this.buttonDeshacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeshacer.FlatAppearance.BorderSize = 0;
            this.buttonDeshacer.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeshacer.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeshacer.Image")));
            this.buttonDeshacer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeshacer.Location = new System.Drawing.Point(449, 200);
            this.buttonDeshacer.Name = "buttonDeshacer";
            this.buttonDeshacer.Size = new System.Drawing.Size(95, 23);
            this.buttonDeshacer.TabIndex = 478;
            this.buttonDeshacer.Text = "DESHACER";
            this.buttonDeshacer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeshacer.UseVisualStyleBackColor = true;
            this.buttonDeshacer.Click += new System.EventHandler(this.buttonDeshacer_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.Image")));
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminar.Location = new System.Drawing.Point(342, 200);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(95, 23);
            this.buttonEliminar.TabIndex = 477;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonCrear
            // 
            this.buttonCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrear.FlatAppearance.BorderSize = 0;
            this.buttonCrear.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrear.Image = ((System.Drawing.Image)(resources.GetObject("buttonCrear.Image")));
            this.buttonCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCrear.Location = new System.Drawing.Point(128, 200);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(95, 23);
            this.buttonCrear.TabIndex = 474;
            this.buttonCrear.Text = "CREAR";
            this.buttonCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNuevo.FlatAppearance.BorderSize = 0;
            this.buttonNuevo.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevo.Image = ((System.Drawing.Image)(resources.GetObject("buttonNuevo.Image")));
            this.buttonNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNuevo.Location = new System.Drawing.Point(21, 200);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(95, 23);
            this.buttonNuevo.TabIndex = 475;
            this.buttonNuevo.Text = "NUEVO";
            this.buttonNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.SlblUsuario_creador,
            this.toolStripStatusLabel3,
            this.SlblFecha_creacion,
            this.toolStripStatusLabel5,
            this.SlblUsuario_modificador,
            this.toolStripStatusLabel7,
            this.SlblFecha_modificacion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 297);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(602, 22);
            this.statusStrip1.TabIndex = 473;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(51, 17);
            this.toolStripStatusLabel1.Text = "U. Creador :";
            // 
            // SlblUsuario_creador
            // 
            this.SlblUsuario_creador.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlblUsuario_creador.Name = "SlblUsuario_creador";
            this.SlblUsuario_creador.Size = new System.Drawing.Size(74, 17);
            this.SlblUsuario_creador.Text = "[usuario_creador]";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabel3.Text = "F. Creación :";
            // 
            // SlblFecha_creacion
            // 
            this.SlblFecha_creacion.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlblFecha_creacion.Name = "SlblFecha_creacion";
            this.SlblFecha_creacion.Size = new System.Drawing.Size(70, 17);
            this.SlblFecha_creacion.Text = "[fecha_creacion]";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(64, 17);
            this.toolStripStatusLabel5.Text = "U. Modificador:";
            // 
            // SlblUsuario_modificador
            // 
            this.SlblUsuario_modificador.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlblUsuario_modificador.Name = "SlblUsuario_modificador";
            this.SlblUsuario_modificador.Size = new System.Drawing.Size(91, 17);
            this.SlblUsuario_modificador.Text = "[usuario_modificador]";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabel7.Text = "F. Modificacion:";
            // 
            // SlblFecha_modificacion
            // 
            this.SlblFecha_modificacion.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.SlblFecha_modificacion.Name = "SlblFecha_modificacion";
            this.SlblFecha_modificacion.Size = new System.Drawing.Size(96, 17);
            this.SlblFecha_modificacion.Text = "[fecha_modificacion]";
            // 
            // btnCodigo
            // 
            this.btnCodigo.Location = new System.Drawing.Point(403, 33);
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Size = new System.Drawing.Size(33, 23);
            this.btnCodigo.TabIndex = 479;
            this.btnCodigo.Text = "...";
            this.btnCodigo.UseVisualStyleBackColor = true;
            this.btnCodigo.Click += new System.EventHandler(this.btnCodigo_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActualizar.FlatAppearance.BorderSize = 0;
            this.buttonActualizar.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.Image = ((System.Drawing.Image)(resources.GetObject("buttonActualizar.Image")));
            this.buttonActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonActualizar.Location = new System.Drawing.Point(235, 200);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(95, 23);
            this.buttonActualizar.TabIndex = 476;
            this.buttonActualizar.Text = "ACTUALIZAR";
            this.buttonActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 481;
            this.label8.Text = "Estado:";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(129, 167);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(15, 14);
            this.chkEstado.TabIndex = 480;
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 482;
            this.label4.Text = "Cuenta:";
            // 
            // NuevaCuentaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.btnCodigo);
            this.Controls.Add(this.buttonDeshacer);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnDocumento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumero_documento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboTipo_documento);
            this.Controls.Add(this.btnNombres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.cboTipoCuenta);
            this.Controls.Add(this.cboMoneda);
            this.Name = "NuevaCuentaUserControl";
            this.Size = new System.Drawing.Size(602, 319);
            this.Load += new System.EventHandler(this.NuevaCuentaUserControl_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMoneda;
        private System.Windows.Forms.ComboBox cboTipoCuenta;
        private System.Windows.Forms.Button btnNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Button btnDocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumero_documento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTipo_documento;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button buttonDeshacer;
        public System.Windows.Forms.Button buttonEliminar;
        public System.Windows.Forms.Button buttonCrear;
        public System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel SlblUsuario_creador;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel SlblFecha_creacion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel SlblUsuario_modificador;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel SlblFecha_modificacion;
        private System.Windows.Forms.Button btnCodigo;
        public System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label label4;
    }
}
