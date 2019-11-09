namespace Sistema_Bancario.plataforma_controles
{
    partial class NuevaMoneda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaMoneda));
            this.btnDescripcion = new System.Windows.Forms.Button();
            this.btnCodigo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.buttonDeshacer = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
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
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDescripcion
            // 
            this.btnDescripcion.Location = new System.Drawing.Point(392, 73);
            this.btnDescripcion.Name = "btnDescripcion";
            this.btnDescripcion.Size = new System.Drawing.Size(33, 23);
            this.btnDescripcion.TabIndex = 21;
            this.btnDescripcion.Text = "...";
            this.btnDescripcion.UseVisualStyleBackColor = true;
            this.btnDescripcion.Click += new System.EventHandler(this.btnDescripcion_Click);
            // 
            // btnCodigo
            // 
            this.btnCodigo.Location = new System.Drawing.Point(224, 46);
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Size = new System.Drawing.Size(33, 23);
            this.btnCodigo.TabIndex = 20;
            this.btnCodigo.Text = "...";
            this.btnCodigo.UseVisualStyleBackColor = true;
            this.btnCodigo.Click += new System.EventHandler(this.btnCodigo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(118, 75);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(268, 20);
            this.txtDescripcion.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(118, 49);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 16;
            // 
            // buttonDeshacer
            // 
            this.buttonDeshacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeshacer.FlatAppearance.BorderSize = 0;
            this.buttonDeshacer.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeshacer.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeshacer.Image")));
            this.buttonDeshacer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeshacer.Location = new System.Drawing.Point(439, 138);
            this.buttonDeshacer.Name = "buttonDeshacer";
            this.buttonDeshacer.Size = new System.Drawing.Size(95, 23);
            this.buttonDeshacer.TabIndex = 468;
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
            this.buttonEliminar.Location = new System.Drawing.Point(332, 138);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(95, 23);
            this.buttonEliminar.TabIndex = 467;
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
            this.buttonActualizar.Location = new System.Drawing.Point(225, 138);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(95, 23);
            this.buttonActualizar.TabIndex = 466;
            this.buttonActualizar.Text = "ACTUALIZAR";
            this.buttonActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonCrear
            // 
            this.buttonCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrear.FlatAppearance.BorderSize = 0;
            this.buttonCrear.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrear.Image = ((System.Drawing.Image)(resources.GetObject("buttonCrear.Image")));
            this.buttonCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCrear.Location = new System.Drawing.Point(118, 138);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(95, 23);
            this.buttonCrear.TabIndex = 464;
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
            this.buttonNuevo.Location = new System.Drawing.Point(11, 138);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(95, 23);
            this.buttonNuevo.TabIndex = 465;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 187);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(551, 22);
            this.statusStrip1.TabIndex = 469;
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
            // NuevaMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonDeshacer);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.btnDescripcion);
            this.Controls.Add(this.btnCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Name = "NuevaMoneda";
            this.Size = new System.Drawing.Size(551, 209);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDescripcion;
        private System.Windows.Forms.Button btnCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.Button buttonDeshacer;
        public System.Windows.Forms.Button buttonEliminar;
        public System.Windows.Forms.Button buttonActualizar;
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
    }
}
