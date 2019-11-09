namespace XWFControlLibrary.Ventanilla
{
   partial class Base
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
            this.buttonProceder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonProceder
            // 
            this.buttonProceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(96)))), ((int)(((byte)(147)))));
            this.buttonProceder.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonProceder.FlatAppearance.BorderSize = 0;
            this.buttonProceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProceder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProceder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonProceder.Location = new System.Drawing.Point(365, 0);
            this.buttonProceder.Name = "buttonProceder";
            this.buttonProceder.Size = new System.Drawing.Size(111, 41);
            this.buttonProceder.TabIndex = 0;
            this.buttonProceder.Text = "PROCEDER";
            this.buttonProceder.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonProceder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 41);
            this.panel1.TabIndex = 1;
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Base";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(496, 281);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

      }

      #endregion

      public System.Windows.Forms.Button buttonProceder;
      private System.Windows.Forms.Panel panel1;
   }
}
