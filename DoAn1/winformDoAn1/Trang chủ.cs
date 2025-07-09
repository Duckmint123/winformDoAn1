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
    public partial class Trang_chủ : Form
    {
        BXH formBXH;
        public Trang_chủ()
        {
            InitializeComponent();
            formBXH = new BXH();
        }
        private void btnBatDau_Click(object sender, EventArgs e)
        {

            Trochoidovui form = new Trochoidovui();
            form.Show();
            this.Hide();
        }
        private void btnBXH_Click(object sender, EventArgs e)
        {
            formBXH.Show();
            formBXH.BringToFront();
        }

        private void Trang_chủ_Load(object sender, EventArgs e)
        {

        }
    }
    
}
