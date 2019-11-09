namespace Sistema_Bancario
{
    partial class Nro_Documento
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
            this.LblNombreControl = new System.Windows.Forms.Label();
            this.TBNroDocumento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblNombreControl
            // 
            this.LblNombreControl.AutoSize = true;
            this.LblNombreControl.Location = new System.Drawing.Point(3, 6);
            this.LblNombreControl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombreControl.Name = "LblNombreControl";
            this.LblNombreControl.Size = new System.Drawing.Size(82, 13);
            this.LblNombreControl.TabIndex = 0;
            this.LblNombreControl.Text = "Nro Documento";
            // 
            // TBNroDocumento
            // 
            this.TBNroDocumento.Location = new System.Drawing.Point(91, 3);
            this.TBNroDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.TBNroDocumento.Name = "TBNroDocumento";
            this.TBNroDocumento.Size = new System.Drawing.Size(186, 20);
            this.TBNroDocumento.TabIndex = 1;
            // 
            // Nro_Documento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TBNroDocumento);
            this.Controls.Add(this.LblNombreControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Nro_Documento";
            this.Size = new System.Drawing.Size(283, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox TBNroDocumento;
        public System.Windows.Forms.Label LblNombreControl;
    }
}
