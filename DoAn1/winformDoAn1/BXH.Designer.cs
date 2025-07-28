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
            this.dgvBXH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBXH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBXH.Location = new System.Drawing.Point(4, 4);
            this.dgvBXH.Name = "dgvBXH";
            this.dgvBXH.RowHeadersWidth = 51;
            this.dgvBXH.RowTemplate.Height = 24;
            this.dgvBXH.Size = new System.Drawing.Size(795, 373);
            this.dgvBXH.TabIndex = 0;
            this.dgvBXH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBXH_CellContentClick);
            // 
            // bntDong
            // 
            this.bntDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntDong.BackColor = System.Drawing.Color.White;
            this.bntDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDong.Location = new System.Drawing.Point(652, 383);
            this.bntDong.Name = "bntDong";
            this.bntDong.Size = new System.Drawing.Size(136, 55);
            this.bntDong.TabIndex = 1;
            this.bntDong.Text = "Đóng";
            this.bntDong.UseVisualStyleBackColor = false;
            this.bntDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // BXH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntDong);
            this.Controls.Add(this.dgvBXH);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "BXH";
            this.Text = "BXH";
            this.Load += new System.EventHandler(this.BXH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBXH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBXH;
        private System.Windows.Forms.Button bntDong;
    }
}