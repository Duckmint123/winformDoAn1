using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformDoAn1
{
    public partial class Nhập_tên : Form
    {
        public string TenNguoiChoi { get; private set; }
        public Nhập_tên()
        {
            InitializeComponent();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTen.Text))
            {
                TenNguoiChoi = txtTen.Text.Trim();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên người chơi!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
