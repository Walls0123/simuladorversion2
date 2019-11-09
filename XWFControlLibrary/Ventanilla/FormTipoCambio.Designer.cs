namespace XWFControlLibrary.Ventanilla
{
   partial class FormTipoCambio
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
         this.conversionMoneyFull1 = new XWFControlLibrary.UI.ucontrol.ConversionMoneyFull();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.btnProceder = new System.Windows.Forms.Button();
         this.exChange1 = new XWFControlLibrary.UI.ucontrol.ExChange();
         this.SuspendLayout();
         // 
         // conversionMoneyFull1
         // 
         this.conversionMoneyFull1.Location = new System.Drawing.Point(110, 12);
         this.conversionMoneyFull1.Name = "conversionMoneyFull1";
         this.conversionMoneyFull1.Size = new System.Drawing.Size(200, 57);
         this.conversionMoneyFull1.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(19, 15);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(48, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "Monto :";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(19, 52);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(71, 13);
         this.label2.TabIndex = 2;
         this.label2.Text = "Conversion :";
         // 
         // btnProceder
         // 
         this.btnProceder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnProceder.Location = new System.Drawing.Point(166, 87);
         this.btnProceder.Name = "btnProceder";
         this.btnProceder.Size = new System.Drawing.Size(75, 23);
         this.btnProceder.TabIndex = 3;
         this.btnProceder.Text = "Proceder";
         this.btnProceder.UseVisualStyleBackColor = true;
         this.btnProceder.Click += new System.EventHandler(this.BtnProceder_Click);
         // 
         // exChange1
         // 
         this.exChange1.Location = new System.Drawing.Point(316, 11);
         this.exChange1.Name = "exChange1";
         this.exChange1.Size = new System.Drawing.Size(161, 99);
         this.exChange1.TabIndex = 4;
         // 
         // FormTipoCambio
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(494, 126);
         this.Controls.Add(this.exChange1);
         this.Controls.Add(this.btnProceder);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.conversionMoneyFull1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FormTipoCambio";
         this.Text = "Tipo Cambio";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private UI.ucontrol.ConversionMoneyFull conversionMoneyFull1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button btnProceder;
      private UI.ucontrol.ExChange exChange1;
   }
}