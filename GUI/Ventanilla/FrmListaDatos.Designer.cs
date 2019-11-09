namespace Sistema_Bancario.Ventanilla
{
    partial class FrmListaDatos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaDatos));
            this.DGVlistaDatos = new System.Windows.Forms.DataGridView();
            this.BTAceptar = new System.Windows.Forms.Button();
            this.BTCancelar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVlistaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVlistaDatos
            // 
            this.DGVlistaDatos.AllowUserToAddRows = false;
            this.DGVlistaDatos.AllowUserToDeleteRows = false;
            this.DGVlistaDatos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGVlistaDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVlistaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVlistaDatos.EnableHeadersVisualStyles = false;
            this.DGVlistaDatos.GridColor = System.Drawing.Color.Gray;
            this.DGVlistaDatos.Location = new System.Drawing.Point(3, 32);
            this.DGVlistaDatos.Name = "DGVlistaDatos";
            this.DGVlistaDatos.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVlistaDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVlistaDatos.Size = new System.Drawing.Size(608, 361);
            this.DGVlistaDatos.TabIndex = 0;
            this.DGVlistaDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVlistaDatos_CellContentClick);
            this.DGVlistaDatos.SelectionChanged += new System.EventHandler(this.DGVlistaDatos_SelectionChanged);
            // 
            // BTAceptar
            // 
            this.BTAceptar.BackColor = System.Drawing.Color.ForestGreen;
            this.BTAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTAceptar.FlatAppearance.BorderSize = 0;
            this.BTAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTAceptar.ForeColor = System.Drawing.SystemColors.Window;
            this.BTAceptar.Location = new System.Drawing.Point(203, 399);
            this.BTAceptar.Name = "BTAceptar";
            this.BTAceptar.Size = new System.Drawing.Size(75, 23);
            this.BTAceptar.TabIndex = 1;
            this.BTAceptar.Text = "Aceptar";
            this.BTAceptar.UseVisualStyleBackColor = false;
            this.BTAceptar.Click += new System.EventHandler(this.BTAceptar_Click);
            // 
            // BTCancelar
            // 
            this.BTCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTCancelar.ForeColor = System.Drawing.Color.Black;
            this.BTCancelar.Location = new System.Drawing.Point(331, 399);
            this.BTCancelar.Name = "BTCancelar";
            this.BTCancelar.Size = new System.Drawing.Size(75, 23);
            this.BTCancelar.TabIndex = 2;
            this.BTCancelar.Text = "Cancelar";
            this.BTCancelar.UseVisualStyleBackColor = true;
            this.BTCancelar.Click += new System.EventHandler(this.BTCancelar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtro";
            this.label1.Visible = false;
            // 
            // FrmListaDatos
            // 
            this.AcceptButton = this.BTAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(615, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BTCancelar);
            this.Controls.Add(this.BTAceptar);
            this.Controls.Add(this.DGVlistaDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListaDatos";
            this.Tag = "";
            this.Text = "FrmListaDatos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmListaDatos_FormClosed);
            this.Load += new System.EventHandler(this.FrmListaDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVlistaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTCancelar;
        private System.Windows.Forms.Button BTAceptar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView DGVlistaDatos;
    }
}