namespace winformDoAn1
{
    partial class Trang_chủ
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.btnXemXepHang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRÒ CHƠI ĐỐ VUI";
            // 
            // btnBatDau
            // 
            this.btnBatDau.BackColor = System.Drawing.Color.White;
            this.btnBatDau.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.Location = new System.Drawing.Point(343, 206);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(132, 71);
            this.btnBatDau.TabIndex = 1;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = false;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // btnXemXepHang
            // 
            this.btnXemXepHang.BackColor = System.Drawing.Color.White;
            this.btnXemXepHang.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnXemXepHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemXepHang.Location = new System.Drawing.Point(343, 318);
            this.btnXemXepHang.Name = "btnXemXepHang";
            this.btnXemXepHang.Size = new System.Drawing.Size(132, 71);
            this.btnXemXepHang.TabIndex = 2;
            this.btnXemXepHang.Text = "Bảng xếp hạng";
            this.btnXemXepHang.UseVisualStyleBackColor = false;
            this.btnXemXepHang.Click += new System.EventHandler(this.btnBXH_Click);
            // 
            // Trang_chủ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(808, 442);
            this.Controls.Add(this.btnXemXepHang);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.label1);
            this.Name = "Trang_chủ";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.Trang_chủ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Button btnXemXepHang;
    }
}