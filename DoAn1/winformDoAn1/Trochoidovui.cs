using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace winformDoAn1
{
    public partial class Trochoidovui : Form
    {
        string connectionString = @"Data Source=localhost;Initial Catalog=DoAnQuizGame;Integrated Security=True";
        DataTable cauHoiTable;
        int cauHoiIndex = 0;
        int diem = 0;
        public Trochoidovui()
        {
            InitializeComponent();

            // Khởi tạo chủ đề
            cbChuDe.Items.Add("Tin học");
            cbChuDe.Items.Add("Lịch sử");
            cbChuDe.Items.Add("Địa lý");
            cbChuDe.SelectedIndex = 0;

            btnReset.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tải câu hỏi đầu tiên khi form load
            LoadCauHoi();
            HienThiCauHoi();
        }

        void LoadCauHoi()
        {
            if (cbChuDe.SelectedItem == null)
            {
                cauHoiTable = null;
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string chuDeChon = cbChuDe.SelectedItem.ToString();
                string query = "SELECT * FROM CauHoi WHERE ChuDe = @ChuDe";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@ChuDe", chuDeChon);

                cauHoiTable = new DataTable();
                try
                {
                    adapter.Fill(cauHoiTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải câu hỏi: " + ex.Message);
                    cauHoiTable = null;
                }
            }
        }

        void HienThiCauHoi()
        {
            if (cauHoiTable == null || cauHoiTable.Rows.Count == 0)
            {
                lblCauHoi.Text = "Không có câu hỏi nào cho chủ đề này.";
                btnA.Visible = btnB.Visible = btnC.Visible = btnD.Visible = false;
                btnReset.Visible = true;
                return;
            }

            if (cauHoiIndex >= cauHoiTable.Rows.Count)
            {
                lblCauHoi.Text = $"Hết câu hỏi! Tổng điểm của bạn: {diem}/{cauHoiTable.Rows.Count}";
                btnA.Visible = btnB.Visible = btnC.Visible = btnD.Visible = false;
                btnReset.Visible = true;
                using (Nhập_tên formNhap = new Nhập_tên())
                {
                    if (formNhap.ShowDialog() == DialogResult.OK)
                    {
                        string tenNguoiChoi = formNhap.TenNguoiChoi;
                        CapNhatDiem(diem, tenNguoiChoi); // Gọi hàm mới với tên truyền vào
                    }
                }
                return;
            }

            DataRow row = cauHoiTable.Rows[cauHoiIndex];
            lblCauHoi.Text = row["NoiDung"].ToString();
            btnA.Text = "A. " + row["A"].ToString();
            btnB.Text = "B. " + row["B"].ToString();
            btnC.Text = "C. " + row["C"].ToString();
            btnD.Text = "D. " + row["D"].ToString();

            lblKetQua.Text = "";
            lblDiem.Text = $"Điểm: {diem}";

            btnA.Enabled = btnB.Enabled = btnC.Enabled = btnD.Enabled = true;
            btnA.Visible = btnB.Visible = btnC.Visible = btnD.Visible = true;
        }

        void KiemTraDapAn(string dapAnChon)
        {
            if (cauHoiTable == null || cauHoiIndex >= cauHoiTable.Rows.Count)
                return;

            DataRow row = cauHoiTable.Rows[cauHoiIndex];
            string dapAnDung = row["DapAn"].ToString();

            if (dapAnChon == dapAnDung)
            {
                lblKetQua.Text = "✅ Chính xác!";
                diem++;
            }
            else
            {
                lblKetQua.Text = "❌ Sai rồi! Đáp án đúng là: " + dapAnDung;
            }

            btnA.Enabled = btnB.Enabled = btnC.Enabled = btnD.Enabled = false;
            lblDiem.Text = $"Điểm: {diem}";
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            cauHoiIndex = 0;
            diem = 0;
            LoadCauHoi();
            HienThiCauHoi();
            btnReset.Visible = false;
        }

        private void cbChuDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            cauHoiIndex = 0;
            diem = 0;
            LoadCauHoi();
            HienThiCauHoi();
        }

        private void lblKetQua_Click(object sender, EventArgs e)
        {

        }

        private void lblCauHoi_Click(object sender, EventArgs e)
        {

        }
        void CapNhatDiem(int diem, string tenNguoiChoi)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Kiểm tra đã có tên người chơi chưa
                string checkQuery = "SELECT Diem FROM XepHang WHERE TenNguoiChoi = @ten";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@ten", tenNguoiChoi);
                var result = checkCmd.ExecuteScalar();

                if (result == null)
                {
                    // Nếu chưa có, thêm mới
                    string insertQuery = "INSERT INTO XepHang (TenNguoiChoi, Diem, NgayGio) VALUES (@ten, @diem, @ngaygio)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@ten", tenNguoiChoi);
                    insertCmd.Parameters.AddWithValue("@diem", diem);
                    insertCmd.Parameters.AddWithValue("@ngaygio", DateTime.Now);
                    insertCmd.ExecuteNonQuery();
                }
                else
                {
                    int diemCu = Convert.ToInt32(result);
                    if (diem > diemCu)
                    {
                        // Nếu điểm mới cao hơn, cập nhật
                        string updateQuery = "UPDATE XepHang SET Diem = @diem, NgayGio = @ngaygio WHERE TenNguoiChoi = @ten";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@ten", tenNguoiChoi);
                        updateCmd.Parameters.AddWithValue("@diem", diem);
                        updateCmd.Parameters.AddWithValue("@ngaygio", DateTime.Now);
                        updateCmd.ExecuteNonQuery();
                    }
                }
            }
        }
        private void KetThucTroChoi()
        {
            // Gọi form nhập tên
            using (Nhập_tên formNhap = new Nhập_tên())
            {
                if (formNhap.ShowDialog() == DialogResult.OK)
                {
                    string tenNguoiChoi = formNhap.TenNguoiChoi;
                    CapNhatDiem(diem, tenNguoiChoi);
                    MessageBox.Show("Điểm đã được lưu!");
                    BXH formBXH = new BXH();
                    formBXH.ShowDialog();
                }
            }

            // Sau đó có thể trở lại menu hoặc đóng game
            this.Close(); // hoặc mở lại form menu
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close(); // Chỉ đóng game, quay lại menu gốc đã ẩn
            Application.OpenForms["Trang_chủ"]?.Show(); 
        }
        private void Trochoidovui_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["Trang_chủ"]?.Show();
        }
    }
}
