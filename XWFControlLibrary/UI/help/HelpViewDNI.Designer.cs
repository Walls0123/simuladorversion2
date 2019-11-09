namespace XWFControlLibrary.UI.help
{
   partial class HelpViewDNI
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
         this.dgvItems = new System.Windows.Forms.DataGridView();
         this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.gradentPanel1 = new XWFControlLibrary.Controles.GradentPanel();
         this.btnExit = new System.Windows.Forms.Button();
         //this.MoveFrom = new Bunifu.Framework.UI.BunifuDragControl(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
         this.gradentPanel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // dgvItems
         // 
         this.dgvItems.AllowUserToAddRows = false;
         this.dgvItems.AllowUserToDeleteRows = false;
         this.dgvItems.AllowUserToOrderColumns = true;
         this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroDocumento,
            this.Apellidos,
            this.Nombres});
         this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dgvItems.Location = new System.Drawing.Point(0, 25);
         this.dgvItems.Name = "dgvItems";
         this.dgvItems.ReadOnly = true;
         this.dgvItems.Size = new System.Drawing.Size(446, 330);
         this.dgvItems.TabIndex = 1;
         this.dgvItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvItems_CellDoubleClick);
         // 
         // NroDocumento
         // 
         this.NroDocumento.HeaderText = "Documento";
         this.NroDocumento.Name = "NroDocumento";
         this.NroDocumento.ReadOnly = true;
         // 
         // Apellidos
         // 
         this.Apellidos.HeaderText = "Apellidos";
         this.Apellidos.Name = "Apellidos";
         this.Apellidos.ReadOnly = true;
         this.Apellidos.Width = 200;
         // 
         // Nombres
         // 
         this.Nombres.HeaderText = "Nombres";
         this.Nombres.Name = "Nombres";
         this.Nombres.ReadOnly = true;
         // 
         // gradentPanel1
         // 
         this.gradentPanel1.ColorBottom = System.Drawing.Color.Silver;
         this.gradentPanel1.ColorTop = System.Drawing.Color.White;
         this.gradentPanel1.Controls.Add(this.btnExit);
         this.gradentPanel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.gradentPanel1.Location = new System.Drawing.Point(0, 0);
         this.gradentPanel1.Name = "gradentPanel1";
         this.gradentPanel1.Size = new System.Drawing.Size(446, 25);
         this.gradentPanel1.TabIndex = 0;
         // 
         // btnExit
         // 
         this.btnExit.BackColor = System.Drawing.Color.Transparent;
         this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
         this.btnExit.FlatAppearance.BorderSize = 0;
         this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnExit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
         this.btnExit.Location = new System.Drawing.Point(423, 0);
         this.btnExit.Margin = new System.Windows.Forms.Padding(2);
         this.btnExit.Name = "btnExit";
         this.btnExit.Size = new System.Drawing.Size(23, 25);
         this.btnExit.TabIndex = 27;
         this.btnExit.Text = "X";
         this.btnExit.UseVisualStyleBackColor = false;
         this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
         // 
         // MoveFrom
         // 
         //this.MoveFrom.Fixed = true;
         //this.MoveFrom.Horizontal = true;
         //this.MoveFrom.TargetControl = this.gradentPanel1;
         //this.MoveFrom.Vertical = true;
         // 
         // HelpViewDNI
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(446, 355);
         this.Controls.Add(this.dgvItems);
         this.Controls.Add(this.gradentPanel1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "HelpViewDNI";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "HelpView";
         ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
         this.gradentPanel1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private Controles.GradentPanel gradentPanel1;
      private System.Windows.Forms.DataGridView dgvItems;
      private System.Windows.Forms.Button btnExit;
      private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
      private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
      private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
      //private Bunifu.Framework.UI.BunifuDragControl MoveFrom;
   }
}