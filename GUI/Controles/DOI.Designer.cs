namespace Sistema_Bancario
{
    partial class Doi
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
            this.DOY = new System.Windows.Forms.Label();
            this.TBDoi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DOY
            // 
            this.DOY.AutoSize = true;
            this.DOY.Location = new System.Drawing.Point(2, 6);
            this.DOY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DOY.Name = "DOY";
            this.DOY.Size = new System.Drawing.Size(32, 13);
            this.DOY.TabIndex = 0;
            this.DOY.Text = "DOI :";
            // 
            // TBDoi
            // 
            this.TBDoi.Location = new System.Drawing.Point(51, 3);
            this.TBDoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBDoi.Name = "TBDoi";
            this.TBDoi.Size = new System.Drawing.Size(123, 20);
            this.TBDoi.TabIndex = 1;
            this.TBDoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBDoi_KeyPress);
            // 
            // Doi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TBDoi);
            this.Controls.Add(this.DOY);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Doi";
            this.Size = new System.Drawing.Size(180, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DOY;
        public System.Windows.Forms.TextBox TBDoi;
    }
}
