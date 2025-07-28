namespace winformDoAn1
{
    partial class Trochoidovui
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCauTiepTheo = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.cbChuDe = new System.Windows.Forms.ComboBox();
            this.lblCauHoi = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(222, 462);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(152, 40);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Chơi lại";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCauTiepTheo
            // 
            this.btnCauTiepTheo.BackColor = System.Drawing.Color.White;
            this.btnCauTiepTheo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCauTiepTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauTiepTheo.Location = new System.Drawing.Point(699, 460);
            this.btnCauTiepTheo.Name = "btnCauTiepTheo";
            this.btnCauTiepTheo.Size = new System.Drawing.Size(152, 42);
            this.btnCauTiepTheo.TabIndex = 6;
            this.btnCauTiepTheo.Text = "câu tiếp theo";
            this.btnCauTiepTheo.UseVisualStyleBackColor = false;
            this.btnCauTiepTheo.Click += new System.EventHandler(this.btnCauTiepTheo_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.White;
            this.btnD.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.ForeColor = System.Drawing.Color.Black;
            this.btnD.Location = new System.Drawing.Point(591, 347);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(304, 60);
            this.btnD.TabIndex = 3;
            this.btnD.Text = "button4";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.White;
            this.btnB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnB.FlatAppearance.BorderSize = 0;
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.ForeColor = System.Drawing.Color.Black;
            this.btnB.Location = new System.Drawing.Point(591, 229);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(304, 60);
            this.btnB.TabIndex = 1;
            this.btnB.Text = "button2";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(217, 155);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(81, 29);
            this.lblKetQua.TabIndex = 5;
            this.lblKetQua.Text = "label2";
            this.lblKetQua.Click += new System.EventHandler(this.lblKetQua_Click);
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiem.Location = new System.Drawing.Point(803, 31);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(48, 20);
            this.lblDiem.TabIndex = 7;
            this.lblDiem.Text = "Điểm";
            // 
            // cbChuDe
            // 
            this.cbChuDe.BackColor = System.Drawing.SystemColors.Window;
            this.cbChuDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChuDe.FormattingEnabled = true;
            this.cbChuDe.Location = new System.Drawing.Point(324, 23);
            this.cbChuDe.Name = "cbChuDe";
            this.cbChuDe.Size = new System.Drawing.Size(229, 28);
            this.cbChuDe.TabIndex = 8;
            this.cbChuDe.SelectedIndexChanged += new System.EventHandler(this.cbChuDe_SelectedIndexChanged);
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.AllowDrop = true;
            this.lblCauHoi.AutoSize = true;
            this.lblCauHoi.BackColor = System.Drawing.Color.Transparent;
            this.lblCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCauHoi.ForeColor = System.Drawing.Color.Black;
            this.lblCauHoi.Location = new System.Drawing.Point(152, 81);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(81, 29);
            this.lblCauHoi.TabIndex = 4;
            this.lblCauHoi.Text = "label1";
            this.lblCauHoi.Click += new System.EventHandler(this.lblCauHoi_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.White;
            this.btnA.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.ForeColor = System.Drawing.Color.Black;
            this.btnA.Location = new System.Drawing.Point(83, 229);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(304, 60);
            this.btnA.TabIndex = 0;
            this.btnA.Text = "button1";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.White;
            this.btnC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.Black;
            this.btnC.Location = new System.Drawing.Point(83, 347);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(304, 60);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "button3";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Trang chủ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Trochoidovui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(972, 518);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.lblCauHoi);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCauTiepTheo);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.cbChuDe);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "Trochoidovui";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Trochoidovui_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCauTiepTheo;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.ComboBox cbChuDe;
        private System.Windows.Forms.Label lblCauHoi;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button button1;
    }
}

