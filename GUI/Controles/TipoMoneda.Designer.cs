namespace Sistema_Bancario.Controles
{
    partial class TipoMoneda
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
            this.CboMoneda = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CboMoneda
            // 
            this.CboMoneda.FormattingEnabled = true;
            this.CboMoneda.Location = new System.Drawing.Point(2, 2);
            this.CboMoneda.Margin = new System.Windows.Forms.Padding(2);
            this.CboMoneda.Name = "CboMoneda";
            this.CboMoneda.Size = new System.Drawing.Size(131, 21);
            this.CboMoneda.TabIndex = 4;
            // 
            // TipoMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CboMoneda);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TipoMoneda";
            this.Size = new System.Drawing.Size(134, 25);
            this.Load += new System.EventHandler(this.TipoMoneda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox CboMoneda;
    }
}
