namespace Sistema_Bancario.Plataforma
{
    partial class UCcliente
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
         this.UCPersona = new Sistema_Bancario.Controles.DatosPersona();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.txtEmail = new System.Windows.Forms.TextBox();
         this.txtTelefono = new System.Windows.Forms.TextBox();
         this.dtFechaNac = new System.Windows.Forms.DateTimePicker();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // proceder1
         // 
         this.proceder1.Size = new System.Drawing.Size(858, 40);
         this.proceder1.Click += new System.EventHandler(this.BTProceder_Click);
         // 
         // UCPersona
         // 
         this.UCPersona.Location = new System.Drawing.Point(15, 19);
         this.UCPersona.Name = "UCPersona";
         this.UCPersona.Size = new System.Drawing.Size(368, 216);
         this.UCPersona.TabIndex = 0;
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.txtEmail);
         this.groupBox1.Controls.Add(this.txtTelefono);
         this.groupBox1.Controls.Add(this.dtFechaNac);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Location = new System.Drawing.Point(18, 241);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(356, 165);
         this.groupBox1.TabIndex = 1;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Personal";
         // 
         // txtEmail
         // 
         this.txtEmail.Location = new System.Drawing.Point(142, 101);
         this.txtEmail.Name = "txtEmail";
         this.txtEmail.Size = new System.Drawing.Size(200, 20);
         this.txtEmail.TabIndex = 5;
         // 
         // txtTelefono
         // 
         this.txtTelefono.Location = new System.Drawing.Point(142, 73);
         this.txtTelefono.Name = "txtTelefono";
         this.txtTelefono.Size = new System.Drawing.Size(200, 20);
         this.txtTelefono.TabIndex = 4;
         // 
         // dtFechaNac
         // 
         this.dtFechaNac.Location = new System.Drawing.Point(142, 42);
         this.dtFechaNac.Name = "dtFechaNac";
         this.dtFechaNac.Size = new System.Drawing.Size(200, 20);
         this.dtFechaNac.TabIndex = 3;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(20, 104);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(34, 13);
         this.label3.TabIndex = 2;
         this.label3.Text = "e-mail";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(17, 73);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(49, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "Teléfono";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(17, 42);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(108, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Fecha de Nacimiento";
         // 
         // UCcliente
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.UCPersona);
         this.Name = "UCcliente";
         this.Size = new System.Drawing.Size(874, 618);
         this.Load += new System.EventHandler(this.UCCliente_Load);
         this.Controls.SetChildIndex(this.UCPersona, 0);
         this.Controls.SetChildIndex(this.groupBox1, 0);
         this.Controls.SetChildIndex(this.proceder1, 0);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);

        }

        #endregion

        private Controles.DatosPersona UCPersona;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DateTimePicker dtFechaNac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
