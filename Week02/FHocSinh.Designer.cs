namespace Week02
{
    partial class FHocSinh
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
            this.label9 = new System.Windows.Forms.Label();
            this.numDiemtb = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cbLocDiemtb = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.uc = new Week02.UCThongTin();
            ((System.ComponentModel.ISupportInitialize)(this.numDiemtb)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(350, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 38);
            this.label5.TabIndex = 16;
            this.label5.Text = "Thong Tin Hoc Sinh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 474);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 61;
            this.label9.Text = "Diem Trung Binh";
            // 
            // numDiemtb
            // 
            this.numDiemtb.DecimalPlaces = 1;
            this.numDiemtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDiemtb.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numDiemtb.Location = new System.Drawing.Point(182, 467);
            this.numDiemtb.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDiemtb.Name = "numDiemtb";
            this.numDiemtb.Size = new System.Drawing.Size(113, 27);
            this.numDiemtb.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(599, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(281, 20);
            this.label10.TabIndex = 64;
            this.label10.Text = "Loc danh sach theo diem trung binh:";
            // 
            // cbLocDiemtb
            // 
            this.cbLocDiemtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocDiemtb.FormattingEnabled = true;
            this.cbLocDiemtb.Items.AddRange(new object[] {
            "lon hon hoac bang 8",
            "tu 5 den nho hon 8",
            "nho hon 5"});
            this.cbLocDiemtb.Location = new System.Drawing.Point(605, 407);
            this.cbLocDiemtb.Name = "cbLocDiemtb";
            this.cbLocDiemtb.Size = new System.Drawing.Size(275, 28);
            this.cbLocDiemtb.TabIndex = 65;
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Location = new System.Drawing.Point(920, 397);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(96, 40);
            this.btnLoc.TabIndex = 66;
            this.btnLoc.Text = "Loc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // uc
            // 
            this.uc.Location = new System.Drawing.Point(-9, -40);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(1084, 643);
            this.uc.TabIndex = 67;
            // 
            // FHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 596);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.cbLocDiemtb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numDiemtb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uc);
            this.Name = "FHocSinh";
            this.Text = "FHocSinh";
            this.Load += new System.EventHandler(this.FHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDiemtb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numDiemtb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbLocDiemtb;
        private System.Windows.Forms.Button btnLoc;
        public UCThongTin uc;
    }
}

