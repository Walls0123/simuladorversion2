namespace Sistema_Bancario.Controles
{
    partial class Clave
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
            this.TBClave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TBClave
            // 
            this.TBClave.Location = new System.Drawing.Point(0, 0);
            this.TBClave.Name = "TBClave";
            this.TBClave.PasswordChar = '*';
            this.TBClave.Size = new System.Drawing.Size(159, 20);
            this.TBClave.TabIndex = 1;
            // 
            // Clave
            // 
            this.Controls.Add(this.TBClave);
            this.Name = "Clave";
            this.Size = new System.Drawing.Size(159, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        public System.Windows.Forms.TextBox TBClave;
    }
}
