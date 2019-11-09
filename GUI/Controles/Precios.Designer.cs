namespace Sistema_Bancario.Controles
{
    partial class Precios
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
            this.Soles = new System.Windows.Forms.Label();
            this.LbCompraDolares = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbVentaDolares = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Soles
            // 
            this.Soles.AutoSize = true;
            this.Soles.BackColor = System.Drawing.Color.Transparent;
            this.Soles.ForeColor = System.Drawing.SystemColors.Window;
            this.Soles.Location = new System.Drawing.Point(52, 26);
            this.Soles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Soles.Name = "Soles";
            this.Soles.Size = new System.Drawing.Size(43, 13);
            this.Soles.TabIndex = 0;
            this.Soles.Text = "Compra";
            // 
            // LbCompraDolares
            // 
            this.LbCompraDolares.AutoSize = true;
            this.LbCompraDolares.BackColor = System.Drawing.Color.Transparent;
            this.LbCompraDolares.ForeColor = System.Drawing.SystemColors.Window;
            this.LbCompraDolares.Location = new System.Drawing.Point(52, 48);
            this.LbCompraDolares.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbCompraDolares.Name = "LbCompraDolares";
            this.LbCompraDolares.Size = new System.Drawing.Size(43, 13);
            this.LbCompraDolares.TabIndex = 1;
            this.LbCompraDolares.Text = "Dolares";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(106, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Venta";
            // 
            // LbVentaDolares
            // 
            this.LbVentaDolares.AutoSize = true;
            this.LbVentaDolares.BackColor = System.Drawing.Color.Transparent;
            this.LbVentaDolares.ForeColor = System.Drawing.SystemColors.Window;
            this.LbVentaDolares.Location = new System.Drawing.Point(107, 48);
            this.LbVentaDolares.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbVentaDolares.Name = "LbVentaDolares";
            this.LbVentaDolares.Size = new System.Drawing.Size(43, 13);
            this.LbVentaDolares.TabIndex = 4;
            this.LbVentaDolares.Text = "Dolares";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(11, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soles";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.Soles);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LbCompraDolares);
            this.groupBox1.Controls.Add(this.LbVentaDolares);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(173, 76);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precios";
            // 
            // Precios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Precios";
            this.Size = new System.Drawing.Size(177, 81);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Soles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label LbCompraDolares;
        public System.Windows.Forms.Label LbVentaDolares;
    }
}
