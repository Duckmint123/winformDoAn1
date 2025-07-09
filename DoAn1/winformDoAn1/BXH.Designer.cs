namespace winformDoAn1
{
    partial class BXH
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
            this.dgvBXH = new System.Windows.Forms.DataGridView();
            this.bntDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBXH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBXH
            // 
            this.dgvBXH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBXH.Location = new System.Drawing.Point(142, 12);
            this.dgvBXH.Name = "dgvBXH";
            this.dgvBXH.RowHeadersWidth = 51;
            this.dgvBXH.RowTemplate.Height = 24;
            this.dgvBXH.Size = new System.Drawing.Size(460, 411);
            this.dgvBXH.TabIndex = 0;
            // 
            // bntDong
            // 
            this.bntDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDong.Location = new System.Drawing.Point(639, 368);
            this.bntDong.Name = "bntDong";
            this.bntDong.Size = new System.Drawing.Size(136, 55);
            this.bntDong.TabIndex = 1;
            this.bntDong.Text = "Đóng";
            this.bntDong.UseVisualStyleBackColor = true;
            this.bntDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // BXH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntDong);
            this.Controls.Add(this.dgvBXH);
            this.Name = "BXH";
            this.Text = "BXH";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBXH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBXH;
        private System.Windows.Forms.Button bntDong;
    }
}