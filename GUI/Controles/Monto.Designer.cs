namespace Sistema_Bancario
{
    partial class Monto
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
            this.TBMonto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TBMonto
            // 
            this.TBMonto.Location = new System.Drawing.Point(0, 0);
            this.TBMonto.Margin = new System.Windows.Forms.Padding(2);
            this.TBMonto.MaxLength = 10;
            this.TBMonto.Name = "TBMonto";
            this.TBMonto.ShortcutsEnabled = false;
            this.TBMonto.Size = new System.Drawing.Size(193, 20);
            this.TBMonto.TabIndex = 0;
            this.TBMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBMonto_KeyPress);
            // 
            // Monto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TBMonto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Monto";
            this.Size = new System.Drawing.Size(193, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox TBMonto;
    }
}
