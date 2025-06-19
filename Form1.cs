using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace winformDoAn1
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=localhost;Initial Catalog=DoAnQuizGame;Integrated Security=True";
        DataTable cauHoiTable;
        int cauHoiIndex = 0;
        public Form1()
        {
            InitializeComponent();
            LoadCauHoi();
            HienThiCauHoi();
        }
        void LoadCauHoi()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CauHoi WHERE ChuDe = N'Lịch sử'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                cauHoiTable = new DataTable();
                adapter.Fill(cauHoiTable);
            }
        }
        void HienThiCauHoi()
        {
            if (cauHoiIndex >= cauHoiTable.Rows.Count)
            {
                lblCauHoi.Text = "Hết câu hỏi rồi!";
                btnA.Enabled = btnB.Enabled = btnC.Enabled = btnD.Enabled = false;
                return;
            }

            DataRow row = cauHoiTable.Rows[cauHoiIndex];
            lblCauHoi.Text = row["NoiDung"].ToString();
            btnA.Text = "A. " + row["A"].ToString();
            btnB.Text = "B. " + row["B"].ToString();
            btnC.Text = "C. " + row["C"].ToString();
            btnD.Text = "D. " + row["D"].ToString();

            lblKetQua.Text = ""; // xóa kết quả cũ
        }
        void KiemTraDapAn(string dapAnChon)
        {
            DataRow row = cauHoiTable.Rows[cauHoiIndex];
            string dapAnDung = row["DapAn"].ToString();

            if (dapAnChon == dapAnDung)
                lblKetQua.Text = "✅ Chính xác!";
            else
                lblKetQua.Text = "❌ Sai rồi! Đáp án đúng là: " + dapAnDung;
        }

        private void btnA_Click(object sender, EventArgs e) => KiemTraDapAn("A");
        private void btnB_Click(object sender, EventArgs e) => KiemTraDapAn("B");
        private void btnC_Click(object sender, EventArgs e) => KiemTraDapAn("C");
        private void btnD_Click(object sender, EventArgs e) => KiemTraDapAn("D");

        private void btnCauTiepTheo_Click(object sender, EventArgs e)
        {
            cauHoiIndex++;
            HienThiCauHoi();
        }
    }
}