namespace Week02
{
    partial class FGiaoVien
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
            this.label5 = new System.Windows.Forms.Label();
            this.uc = new Week02.UCThongTin();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(369, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 38);
            this.label5.TabIndex = 25;
            this.label5.Text = "Thong Tin Giao Vien";
            // 
            // uc
            // 
            this.uc.Location = new System.Drawing.Point(-10, -36);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(1084, 643);
            this.uc.TabIndex = 26;
            // 
            // FGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 596);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uc);
            this.Name = "FGiaoVien";
            this.Text = "FGiaoVien";
            this.Load += new System.EventHandler(this.FGiaoVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        public UCThongTin uc;
    }
}