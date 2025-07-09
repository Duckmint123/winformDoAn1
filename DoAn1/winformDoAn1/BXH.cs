    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;        
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace winformDoAn1
    {
        public partial class BXH : Form
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=BXHQuizGame;Integrated Security=True";
            public BXH()
            {
                InitializeComponent();
            }
            private void FormBXH_Load(object sender, EventArgs e)
            {
                HienThiBangXepHang();
            }

            void HienThiBangXepHang()
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT TOP 10 TenNguoiChoi, Diem, NgayGio 
                                     FROM XepHang 
                                     ORDER BY Diem DESC, NgayGio ASC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvBXH.DataSource = dt;
                    dgvBXH.Columns[0].HeaderText = "Tên người chơi";
                    dgvBXH.Columns[1].HeaderText = "Điểm";
                    dgvBXH.Columns[2].HeaderText = "Ngày giờ";
                }
            }

            private void btnDong_Click(object sender, EventArgs e)
            {
            this.Hide();
        }
        }
    }

