namespace Sistema_Bancario.plataforma_controles
{
    partial class NuevoPrestamoUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoPrestamoUserControl));
            this.label4 = new System.Windows.Forms.Label();
            this.btnCodigo = new System.Windows.Forms.Button();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.nudPlazoMeses = new System.Windows.Forms.NumericUpDown();
            this.nudPorcentajeInteres = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCuenta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMoneda = new System.Windows.Forms.ComboBox();
            this.dtpFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMontoPrestamo = new System.Windows.Forms.TextBox();
            this.txtMontoMora = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudDiaPago = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.buttonDeshacer = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
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
            this.btnApellidos = new System.Windows.Forms.Button();
            this.btnDocumento = new System.Windows.Forms.Button();
            this.btnNombres = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumero_documento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboTipo_documento = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlazoMeses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentajeInteres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiaPago)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 485;
            this.label4.Text = "Cuenta:";
            // 
            // btnCodigo
            // 
            this.btnCodigo.Location = new System.Drawing.Point(242, 223);
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Size = new System.Drawing.Size(33, 23);
            this.btnCodigo.TabIndex = 484;
            this.btnCodigo.Text = "...";
            this.btnCodigo.UseVisualStyleBackColor = true;
            this.btnCodigo.Click += new System.EventHandler(this.btnCodigo_Click);
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(136, 250);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(268, 20);
            this.txtCuenta.TabIndex = 483;
            // 
            // nudPlazoMeses
            // 
            this.nudPlazoMeses.Location = new System.Drawing.Point(136, 385);
            this.nudPlazoMeses.Name = "nudPlazoMeses";
            this.nudPlazoMeses.Size = new System.Drawing.Size(92, 20);
            this.nudPlazoMeses.TabIndex = 486;
            this.nudPlazoMeses.ValueChanged += NudPlazoMeses_ValueChanged;
            // 
            // nudPorcentajeInteres
            // 
            this.nudPorcentajeInteres.Location = new System.Drawing.Point(136, 411);
            this.nudPorcentajeInteres.Name = "nudPorcentajeInteres";
            this.nudPorcentajeInteres.Size = new System.Drawing.Size(92, 20);
            this.nudPorcentajeInteres.TabIndex = 487;
            this.nudPorcentajeInteres.ValueChanged += NudPorcentajeInteres_ValueChanged;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 488;
            this.label1.Text = "TEA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 489;
            this.label2.Text = "Plazo Meses:";
            // 
            // btnCuenta
            // 
            this.btnCuenta.Location = new System.Drawing.Point(410, 248);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(33, 23);
            this.btnCuenta.TabIndex = 492;
            this.btnCuenta.Text = "...";
            this.btnCuenta.UseVisualStyleBackColor = true;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 491;
            this.label3.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(136, 223);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 490;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 494;
            this.label5.Text = "Moneda:";
            // 
            // cboMoneda
            // 
            this.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(136, 276);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(187, 21);
            this.cboMoneda.TabIndex = 493;
            // 
            // dtpFechaPrestamo
            // 
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(136, 304);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            this.dtpFechaPrestamo.Size = new System.Drawing.Size(187, 20);
            this.dtpFechaPrestamo.TabIndex = 495;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 496;
            this.label6.Text = "Fecha Prestamo:";
            // 
            // txtMontoPrestamo
            // 
            this.txtMontoPrestamo.Location = new System.Drawing.Point(136, 331);
            this.txtMontoPrestamo.Name = "txtMontoPrestamo";
            this.txtMontoPrestamo.Size = new System.Drawing.Size(100, 20);
            this.txtMontoPrestamo.TabIndex = 497;
            this.txtMontoPrestamo.KeyPress += TxtMontoPrestamo_KeyPress;
            // 
            // txtMontoMora
            // 
            this.txtMontoMora.Location = new System.Drawing.Point(136, 357);
            this.txtMontoMora.Name = "txtMontoMora";
            this.txtMontoMora.Size = new System.Drawing.Size(100, 20);
            this.txtMontoMora.TabIndex = 498;
            this.txtMontoMora.KeyPress += TxtMontoMora_KeyPress;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 499;
            this.label7.Text = "Monto Prestamo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 500;
            this.label8.Text = "Monto Mora:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 439);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 502;
            this.label9.Text = "Dia Pago:";
            // 
            // nudDiaPago
            // 
            this.nudDiaPago.Location = new System.Drawing.Point(136, 437);
            this.nudDiaPago.Name = "nudDiaPago";
            this.nudDiaPago.Size = new System.Drawing.Size(92, 20);
            this.nudDiaPago.TabIndex = 501;
            this.nudDiaPago.ValueChanged += NudDiaPago_ValueChanged;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 463);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 504;
            this.label10.Text = "Asegurado:";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(136, 463);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(15, 14);
            this.chkEstado.TabIndex = 503;
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // buttonDeshacer
            // 
            this.buttonDeshacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeshacer.FlatAppearance.BorderSize = 0;
            this.buttonDeshacer.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeshacer.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeshacer.Image")));
            this.buttonDeshacer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeshacer.Location = new System.Drawing.Point(449, 504);
            this.buttonDeshacer.Name = "buttonDeshacer";
            this.buttonDeshacer.Size = new System.Drawing.Size(95, 23);
            this.buttonDeshacer.TabIndex = 510;
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
            this.buttonEliminar.Location = new System.Drawing.Point(342, 504);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(95, 23);
            this.buttonEliminar.TabIndex = 509;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActualizar.FlatAppearance.BorderSize = 0;
            this.buttonActualizar.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.Image = ((System.Drawing.Image)(resources.GetObject("buttonActualizar.Image")));
            this.buttonActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonActualizar.Location = new System.Drawing.Point(235, 504);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(95, 23);
            this.buttonActualizar.TabIndex = 508;
            this.buttonActualizar.Text = "REFINANCIAR";
            this.buttonActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditar.FlatAppearance.BorderSize = 0;
            this.buttonEditar.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditar.Location = new System.Drawing.Point(280, 381);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(95, 23);
            this.buttonEditar.TabIndex = 508;
            this.buttonEditar.Text = "EDITAR";
            this.buttonEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonCrear
            // 
            this.buttonCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrear.FlatAppearance.BorderSize = 0;
            this.buttonCrear.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrear.Image = ((System.Drawing.Image)(resources.GetObject("buttonCrear.Image")));
            this.buttonCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCrear.Location = new System.Drawing.Point(128, 504);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(95, 23);
            this.buttonCrear.TabIndex = 506;
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
            this.buttonNuevo.Location = new System.Drawing.Point(21, 504);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(95, 23);
            this.buttonNuevo.TabIndex = 507;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 385);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(576, 22);
            this.statusStrip1.TabIndex = 505;
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
            this.SlblFecha_modificacion.Size = new System.Drawing.Size(96, 12);
            this.SlblFecha_modificacion.Text = "[fecha_modificacion]";
            // 
            // btnApellidos
            // 
            this.btnApellidos.Location = new System.Drawing.Point(389, 61);
            this.btnApellidos.Name = "btnApellidos";
            this.btnApellidos.Size = new System.Drawing.Size(33, 23);
            this.btnApellidos.TabIndex = 521;
            this.btnApellidos.Text = "...";
            this.btnApellidos.UseVisualStyleBackColor = true;
            this.btnApellidos.Click += new System.EventHandler(this.btnApellidos_Click);
            // 
            // btnDocumento
            // 
            this.btnDocumento.Location = new System.Drawing.Point(308, 114);
            this.btnDocumento.Name = "btnDocumento";
            this.btnDocumento.Size = new System.Drawing.Size(33, 23);
            this.btnDocumento.TabIndex = 520;
            this.btnDocumento.Text = "...";
            this.btnDocumento.UseVisualStyleBackColor = true;
            this.btnDocumento.Click += new System.EventHandler(this.btnDocumento_Click);
            // 
            // btnNombres
            // 
            this.btnNombres.Location = new System.Drawing.Point(389, 35);
            this.btnNombres.Name = "btnNombres";
            this.btnNombres.Size = new System.Drawing.Size(33, 23);
            this.btnNombres.TabIndex = 519;
            this.btnNombres.Text = "...";
            this.btnNombres.UseVisualStyleBackColor = true;
            this.btnNombres.Click += new System.EventHandler(this.btnNombres_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 518;
            this.label11.Text = "Numero Documento:";
            // 
            // txtNumero_documento
            // 
            this.txtNumero_documento.Location = new System.Drawing.Point(115, 116);
            this.txtNumero_documento.Name = "txtNumero_documento";
            this.txtNumero_documento.Size = new System.Drawing.Size(187, 20);
            this.txtNumero_documento.TabIndex = 517;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 516;
            this.label12.Text = "Tipo Documento:";
            // 
            // cboTipo_documento
            // 
            this.cboTipo_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo_documento.FormattingEnabled = true;
            this.cboTipo_documento.Location = new System.Drawing.Point(115, 89);
            this.cboTipo_documento.Name = "cboTipo_documento";
            this.cboTipo_documento.Size = new System.Drawing.Size(187, 21);
            this.cboTipo_documento.TabIndex = 515;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(57, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 514;
            this.label13.Text = "Apellidos:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(57, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 513;
            this.label14.Text = "Nombres:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(115, 63);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(268, 20);
            this.txtApellidos.TabIndex = 512;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(115, 37);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(268, 20);
            this.txtNombres.TabIndex = 511;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumero_documento);
            this.groupBox1.Controls.Add(this.btnApellidos);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.btnDocumento);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.btnNombres);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cboTipo_documento);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(19, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 152);
            this.groupBox1.TabIndex = 522;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda Avanzada";
            // 
            // NuevoPrestamoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDeshacer);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudDiaPago);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMontoMora);
            this.Controls.Add(this.txtMontoPrestamo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFechaPrestamo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboMoneda);
            this.Controls.Add(this.btnCuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPorcentajeInteres);
            this.Controls.Add(this.nudPlazoMeses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCodigo);
            this.Controls.Add(this.txtCuenta);
            this.Name = "NuevoPrestamoUserControl";
            this.Size = new System.Drawing.Size(576, 407);
            ((System.ComponentModel.ISupportInitialize)(this.nudPlazoMeses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentajeInteres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiaPago)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCodigo;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.NumericUpDown nudPlazoMeses;
        private System.Windows.Forms.NumericUpDown nudPorcentajeInteres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMoneda;
        private System.Windows.Forms.DateTimePicker dtpFechaPrestamo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMontoPrestamo;
        private System.Windows.Forms.TextBox txtMontoMora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudDiaPago;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkEstado;
        public System.Windows.Forms.Button buttonDeshacer;
        public System.Windows.Forms.Button buttonEliminar;
        public System.Windows.Forms.Button buttonActualizar;
        public System.Windows.Forms.Button buttonEditar;
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
        private System.Windows.Forms.Button btnApellidos;
        private System.Windows.Forms.Button btnDocumento;
        private System.Windows.Forms.Button btnNombres;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumero_documento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboTipo_documento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
