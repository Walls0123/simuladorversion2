namespace Sistema_Bancario
{
   partial class VentanaPrincipal
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
         this.panel1 = new System.Windows.Forms.Panel();
         this.panel2 = new System.Windows.Forms.Panel();
         this.button11 = new System.Windows.Forms.Button();
         this.panel3 = new System.Windows.Forms.Panel();
         this.BTAdministrador = new System.Windows.Forms.Button();
         this.BTOperaciones = new System.Windows.Forms.Button();
         this.BTReportes = new System.Windows.Forms.Button();
         this.BTGestion = new System.Windows.Forms.Button();
         this.BTPlataforma = new System.Windows.Forms.Button();
         this.TituloText = new Bunifu.Framework.UI.BunifuCustomLabel();
         this.stStatus = new System.Windows.Forms.StatusStrip();
         this.lblUsertType = new System.Windows.Forms.ToolStripStatusLabel();
         this.lblUserValueType = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
         this.lblSucursal = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
         this.lblVentanilla = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
         this.lblTurno = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStripStatusLabel10 = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
         this.panel4 = new Sistema_Bancario.Controles.GradentPanel();
         this.label2 = new System.Windows.Forms.Label();
         this.panel6 = new Sistema_Bancario.Controles.GradentPanel();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.button2 = new System.Windows.Forms.Button();
         this.button1 = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.MoveFrom = new Bunifu.Framework.UI.BunifuDragControl(this.components);
         this.panel3.SuspendLayout();
         this.stStatus.SuspendLayout();
         this.panel4.SuspendLayout();
         this.panel6.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.Location = new System.Drawing.Point(209, 98);
         this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(854, 608);
         this.panel1.TabIndex = 1;
         // 
         // panel2
         // 
         this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
         this.panel2.Location = new System.Drawing.Point(0, 57);
         this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(200, 659);
         this.panel2.TabIndex = 7;
         // 
         // button11
         // 
         this.button11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
         this.button11.BackColor = System.Drawing.Color.Transparent;
         this.button11.FlatAppearance.BorderSize = 0;
         this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
         this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
         this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.button11.Location = new System.Drawing.Point(794, 0);
         this.button11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.button11.Name = "button11";
         this.button11.Size = new System.Drawing.Size(78, 32);
         this.button11.TabIndex = 10;
         this.button11.Text = "Cerrar Sesión";
         this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.button11.UseVisualStyleBackColor = false;
         this.button11.Click += new System.EventHandler(this.Button11_Click);
         // 
         // panel3
         // 
         this.panel3.BackColor = System.Drawing.SystemColors.Control;
         this.panel3.Controls.Add(this.BTAdministrador);
         this.panel3.Controls.Add(this.button11);
         this.panel3.Controls.Add(this.BTOperaciones);
         this.panel3.Controls.Add(this.BTReportes);
         this.panel3.Controls.Add(this.BTGestion);
         this.panel3.Controls.Add(this.BTPlataforma);
         this.panel3.Location = new System.Drawing.Point(200, 25);
         this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(872, 32);
         this.panel3.TabIndex = 8;
         // 
         // BTAdministrador
         // 
         this.BTAdministrador.BackColor = System.Drawing.Color.Transparent;
         this.BTAdministrador.FlatAppearance.BorderSize = 0;
         this.BTAdministrador.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
         this.BTAdministrador.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
         this.BTAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.BTAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
         this.BTAdministrador.ForeColor = System.Drawing.SystemColors.WindowText;
         this.BTAdministrador.Location = new System.Drawing.Point(364, 0);
         this.BTAdministrador.Name = "BTAdministrador";
         this.BTAdministrador.Size = new System.Drawing.Size(103, 32);
         this.BTAdministrador.TabIndex = 12;
         this.BTAdministrador.Text = "Administrador";
         this.BTAdministrador.UseVisualStyleBackColor = false;
         this.BTAdministrador.Visible = false;
         this.BTAdministrador.Click += new System.EventHandler(this.BTAdministrador_Click);
         // 
         // BTOperaciones
         // 
         this.BTOperaciones.BackColor = System.Drawing.Color.Transparent;
         this.BTOperaciones.FlatAppearance.BorderSize = 0;
         this.BTOperaciones.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
         this.BTOperaciones.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
         this.BTOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.BTOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
         this.BTOperaciones.ForeColor = System.Drawing.SystemColors.WindowText;
         this.BTOperaciones.Location = new System.Drawing.Point(-1, 0);
         this.BTOperaciones.Name = "BTOperaciones";
         this.BTOperaciones.Size = new System.Drawing.Size(110, 32);
         this.BTOperaciones.TabIndex = 8;
         this.BTOperaciones.Text = "Operaciones";
         this.BTOperaciones.UseVisualStyleBackColor = false;
         this.BTOperaciones.Click += new System.EventHandler(this.BTOperaciones_Click);
         // 
         // BTReportes
         // 
         this.BTReportes.BackColor = System.Drawing.Color.Transparent;
         this.BTReportes.FlatAppearance.BorderSize = 0;
         this.BTReportes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
         this.BTReportes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
         this.BTReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.BTReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
         this.BTReportes.ForeColor = System.Drawing.SystemColors.WindowText;
         this.BTReportes.Location = new System.Drawing.Point(274, 0);
         this.BTReportes.Name = "BTReportes";
         this.BTReportes.Size = new System.Drawing.Size(88, 32);
         this.BTReportes.TabIndex = 11;
         this.BTReportes.Text = "Reportes";
         this.BTReportes.UseVisualStyleBackColor = false;
         this.BTReportes.Click += new System.EventHandler(this.BTReportes_Click);
         // 
         // BTGestion
         // 
         this.BTGestion.BackColor = System.Drawing.Color.Transparent;
         this.BTGestion.FlatAppearance.BorderSize = 0;
         this.BTGestion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
         this.BTGestion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
         this.BTGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.BTGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
         this.BTGestion.ForeColor = System.Drawing.SystemColors.WindowText;
         this.BTGestion.Location = new System.Drawing.Point(106, 0);
         this.BTGestion.Name = "BTGestion";
         this.BTGestion.Size = new System.Drawing.Size(75, 32);
         this.BTGestion.TabIndex = 9;
         this.BTGestion.Text = "Gestión";
         this.BTGestion.UseVisualStyleBackColor = false;
         this.BTGestion.Click += new System.EventHandler(this.BTGestion_Click);
         // 
         // BTPlataforma
         // 
         this.BTPlataforma.BackColor = System.Drawing.Color.Transparent;
         this.BTPlataforma.FlatAppearance.BorderSize = 0;
         this.BTPlataforma.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
         this.BTPlataforma.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
         this.BTPlataforma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.BTPlataforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
         this.BTPlataforma.ForeColor = System.Drawing.SystemColors.WindowText;
         this.BTPlataforma.Location = new System.Drawing.Point(181, 0);
         this.BTPlataforma.Name = "BTPlataforma";
         this.BTPlataforma.Size = new System.Drawing.Size(94, 32);
         this.BTPlataforma.TabIndex = 10;
         this.BTPlataforma.Text = "Plataforma";
         this.BTPlataforma.UseVisualStyleBackColor = false;
         this.BTPlataforma.Click += new System.EventHandler(this.BTPlataforma_Click);
         // 
         // TituloText
         // 
         this.TituloText.AutoSize = true;
         this.TituloText.BackColor = System.Drawing.Color.Transparent;
         this.TituloText.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
         this.TituloText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(96)))), ((int)(((byte)(147)))));
         this.TituloText.Location = new System.Drawing.Point(204, 67);
         this.TituloText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.TituloText.Name = "TituloText";
         this.TituloText.Size = new System.Drawing.Size(80, 29);
         this.TituloText.TabIndex = 6;
         this.TituloText.Text = "Título";
         this.TituloText.Visible = false;
         // 
         // stStatus
         // 
         this.stStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(96)))), ((int)(((byte)(147)))));
         this.stStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.stStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsertType,
            this.lblUserValueType,
            this.toolStripStatusLabel7,
            this.lblSucursal,
            this.toolStripStatusLabel2,
            this.lblVentanilla,
            this.toolStripStatusLabel4,
            this.lblTurno,
            this.toolStripStatusLabel10,
            this.toolStripStatusLabel9,
            this.toolStripStatusLabel8});
         this.stStatus.Location = new System.Drawing.Point(0, 716);
         this.stStatus.Name = "stStatus";
         this.stStatus.Size = new System.Drawing.Size(1074, 25);
         this.stStatus.TabIndex = 13;
         this.stStatus.Text = "statusStrip1";
         // 
         // lblUsertType
         // 
         this.lblUsertType.BackColor = System.Drawing.Color.Transparent;
         this.lblUsertType.ForeColor = System.Drawing.SystemColors.Window;
         this.lblUsertType.Image = global::Sistema_Bancario.Properties.Resources.none;
         this.lblUsertType.Name = "lblUsertType";
         this.lblUsertType.Size = new System.Drawing.Size(88, 20);
         this.lblUsertType.Text = "Estudiante :";
         // 
         // lblUserValueType
         // 
         this.lblUserValueType.BackColor = System.Drawing.Color.Transparent;
         this.lblUserValueType.ForeColor = System.Drawing.SystemColors.Window;
         this.lblUserValueType.Name = "lblUserValueType";
         this.lblUserValueType.Size = new System.Drawing.Size(12, 20);
         this.lblUserValueType.Text = "?";
         // 
         // toolStripStatusLabel7
         // 
         this.toolStripStatusLabel7.BackColor = System.Drawing.Color.Transparent;
         this.toolStripStatusLabel7.ForeColor = System.Drawing.SystemColors.Window;
         this.toolStripStatusLabel7.Image = global::Sistema_Bancario.Properties.Resources.sucursal;
         this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
         this.toolStripStatusLabel7.Size = new System.Drawing.Size(77, 20);
         this.toolStripStatusLabel7.Text = "Sucursal :";
         // 
         // lblSucursal
         // 
         this.lblSucursal.BackColor = System.Drawing.Color.Transparent;
         this.lblSucursal.ForeColor = System.Drawing.SystemColors.Window;
         this.lblSucursal.Name = "lblSucursal";
         this.lblSucursal.Size = new System.Drawing.Size(12, 20);
         this.lblSucursal.Text = "?";
         // 
         // toolStripStatusLabel2
         // 
         this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
         this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.Window;
         this.toolStripStatusLabel2.Image = global::Sistema_Bancario.Properties.Resources.server;
         this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
         this.toolStripStatusLabel2.Size = new System.Drawing.Size(84, 20);
         this.toolStripStatusLabel2.Text = "Ventanilla :";
         // 
         // lblVentanilla
         // 
         this.lblVentanilla.BackColor = System.Drawing.Color.Transparent;
         this.lblVentanilla.ForeColor = System.Drawing.SystemColors.Window;
         this.lblVentanilla.Name = "lblVentanilla";
         this.lblVentanilla.Size = new System.Drawing.Size(12, 20);
         this.lblVentanilla.Text = "?";
         // 
         // toolStripStatusLabel4
         // 
         this.toolStripStatusLabel4.BackColor = System.Drawing.Color.Transparent;
         this.toolStripStatusLabel4.ForeColor = System.Drawing.SystemColors.Window;
         this.toolStripStatusLabel4.Image = global::Sistema_Bancario.Properties.Resources.database;
         this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
         this.toolStripStatusLabel4.Size = new System.Drawing.Size(61, 20);
         this.toolStripStatusLabel4.Text = "Turno:";
         // 
         // lblTurno
         // 
         this.lblTurno.BackColor = System.Drawing.Color.Transparent;
         this.lblTurno.ForeColor = System.Drawing.SystemColors.Window;
         this.lblTurno.Name = "lblTurno";
         this.lblTurno.Size = new System.Drawing.Size(12, 20);
         this.lblTurno.Text = "?";
         // 
         // toolStripStatusLabel10
         // 
         this.toolStripStatusLabel10.BackColor = System.Drawing.Color.Transparent;
         this.toolStripStatusLabel10.ForeColor = System.Drawing.SystemColors.Window;
         this.toolStripStatusLabel10.Name = "toolStripStatusLabel10";
         this.toolStripStatusLabel10.Size = new System.Drawing.Size(40, 20);
         this.toolStripStatusLabel10.Text = "     |     ";
         // 
         // toolStripStatusLabel9
         // 
         this.toolStripStatusLabel9.BackColor = System.Drawing.Color.Transparent;
         this.toolStripStatusLabel9.ForeColor = System.Drawing.SystemColors.Window;
         this.toolStripStatusLabel9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel9.Image")));
         this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
         this.toolStripStatusLabel9.Size = new System.Drawing.Size(110, 20);
         this.toolStripStatusLabel9.Text = "Instituto del Sur";
         // 
         // toolStripStatusLabel8
         // 
         this.toolStripStatusLabel8.BackColor = System.Drawing.Color.Transparent;
         this.toolStripStatusLabel8.ForeColor = System.Drawing.SystemColors.Window;
         this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
         this.toolStripStatusLabel8.Size = new System.Drawing.Size(0, 20);
         // 
         // panel4
         // 
         this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
         this.panel4.ColorBottom = System.Drawing.Color.MidnightBlue;
         this.panel4.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(96)))), ((int)(((byte)(147)))));
         this.panel4.Controls.Add(this.label2);
         this.panel4.Location = new System.Drawing.Point(0, 25);
         this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.panel4.Name = "panel4";
         this.panel4.Size = new System.Drawing.Size(200, 32);
         this.panel4.TabIndex = 15;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.BackColor = System.Drawing.Color.Transparent;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
         this.label2.ForeColor = System.Drawing.Color.White;
         this.label2.Location = new System.Drawing.Point(11, 8);
         this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(132, 16);
         this.label2.TabIndex = 0;
         this.label2.Text = "Cuadro de Opciones";
         // 
         // panel6
         // 
         this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.panel6.ColorBottom = System.Drawing.Color.Silver;
         this.panel6.ColorTop = System.Drawing.Color.White;
         this.panel6.Controls.Add(this.pictureBox1);
         this.panel6.Controls.Add(this.button2);
         this.panel6.Controls.Add(this.button1);
         this.panel6.Controls.Add(this.label1);
         this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel6.Location = new System.Drawing.Point(0, 0);
         this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.panel6.Name = "panel6";
         this.panel6.Size = new System.Drawing.Size(1074, 26);
         this.panel6.TabIndex = 14;
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.InitialImage = null;
         this.pictureBox1.Location = new System.Drawing.Point(0, 0);
         this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.pictureBox1.Size = new System.Drawing.Size(26, 26);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // button2
         // 
         this.button2.BackColor = System.Drawing.Color.Transparent;
         this.button2.FlatAppearance.BorderSize = 0;
         this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
         this.button2.Location = new System.Drawing.Point(1021, 0);
         this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(26, 26);
         this.button2.TabIndex = 16;
         this.button2.Text = "─";
         this.button2.UseVisualStyleBackColor = false;
         this.button2.Click += new System.EventHandler(this.Minimizar_Click);
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.Color.Transparent;
         this.button1.FlatAppearance.BorderSize = 0;
         this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
         this.button1.Location = new System.Drawing.Point(1050, 0);
         this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(23, 26);
         this.button1.TabIndex = 26;
         this.button1.Text = "X";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.Cerrar_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.Transparent;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.label1.Location = new System.Drawing.Point(28, 5);
         this.label1.Margin = new System.Windows.Forms.Padding(0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(139, 16);
         this.label1.TabIndex = 2;
         this.label1.Text = "SISTEMA BANCARIO";
         // 
         // MoveFrom
         // 
         this.MoveFrom.Fixed = true;
         this.MoveFrom.Horizontal = true;
         this.MoveFrom.TargetControl = this.panel6;
         this.MoveFrom.Vertical = true;
         // 
         // VentanaPrincipal
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Gainsboro;
         this.ClientSize = new System.Drawing.Size(1074, 741);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.stStatus);
         this.Controls.Add(this.panel3);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel4);
         this.Controls.Add(this.panel6);
         this.Controls.Add(this.TituloText);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.Name = "VentanaPrincipal";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Sistema Bancario";
         this.panel3.ResumeLayout(false);
         this.stStatus.ResumeLayout(false);
         this.stStatus.PerformLayout();
         this.panel4.ResumeLayout(false);
         this.panel4.PerformLayout();
         this.panel6.ResumeLayout(false);
         this.panel6.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Panel panel3;
      private Bunifu.Framework.UI.BunifuCustomLabel TituloText;
      private System.Windows.Forms.Button button11;
      private Bunifu.Framework.UI.BunifuDragControl MoveFrom;
      private System.Windows.Forms.Button BTReportes;
      private System.Windows.Forms.Button BTPlataforma;
      private System.Windows.Forms.Button BTGestion;
      private System.Windows.Forms.Button BTOperaciones;
      private System.Windows.Forms.StatusStrip stStatus;
      private System.Windows.Forms.ToolStripStatusLabel lblUsertType;
      private System.Windows.Forms.ToolStripStatusLabel lblUserValueType;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
      private System.Windows.Forms.ToolStripStatusLabel lblSucursal;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
      private System.Windows.Forms.ToolStripStatusLabel lblVentanilla;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
      private System.Windows.Forms.ToolStripStatusLabel lblTurno;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel10;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
      private Controles.GradentPanel panel6;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private Controles.GradentPanel panel4;
      private System.Windows.Forms.Button BTAdministrador;
      private System.Windows.Forms.PictureBox pictureBox1;
    }
}