using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace winformDoAn1
{
    public partial class BXH : Form
    {
        // 🔗 Chuỗi kết nối đến đúng database đã có VIEW
        string connectionString = @"Data Source=localhost;Initial Catalog=DoAnQuizGame;Integrated Security=True";

        public BXH()
        {
            InitializeComponent();
        }

        private void BXH_Load(object sender, EventArgs e)
        {
            HienThiBangXepHang();
        }

        void HienThiBangXepHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM V_XepHang"; // gọi view

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvBXH.DataSource = dt;

                    // Tùy chỉnh hiển thị
                    dgvBXH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvBXH.Columns[0].HeaderText = "Tên người chơi";
                    dgvBXH.Columns[1].HeaderText = "Điểm";
                    dgvBXH.Columns[2].HeaderText = "Ngày giờ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hiển thị BXH: " + ex.Message);
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close(); // đóng form BXH
        }

        private void dgvBXH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

