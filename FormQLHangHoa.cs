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

namespace _4
{
    public partial class FormQLHangHoa : Form
    {
        private SqlConnection cnn = new SqlConnection(@"Data Source=Laptop_of_Carat\SQLEXPRESS;Initial Catalog=HangHoa;Integrated Security=True");
        public FormQLHangHoa()
        {
            InitializeComponent();
        }

        // Hàm kết nối cơ sở dữ liệu và lấy dữ liệu
        private void ketnoicsdl()
        {
            string sql = "SELECT * FROM HangHoa";
            DataTable dt = ExecuteQuery(sql);
            if (dt != null)
            {
                dataGridView1.DataSource = dt; // Đổ dữ liệu vào DataGridView
            }
        }

        // Hàm thực thi câu lệnh SQL và trả về DataTable
        private DataTable ExecuteQuery(string query)
        {
            try
            {
                cnn.Open();
                SqlCommand com = new SqlCommand(query, cnn);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                return null;
            }
            finally
            {
                cnn.Close();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                txtmavach.Text = selectedRow.Cells["MaVach"].Value.ToString();
            }
        }

        private void cmdthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { Application.Exit(); }
        }

        private void FormQLHangHoa_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void txtmavach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtmavach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiem();
            }
        }

       

        private void TimKiem()
        {
            string maVach = txtmavach.Text;

            if (maVach.Length == 13)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["MaVach"].Value.ToString() == maVach)
                    {
                        dataGridView1.ClearSelection();
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                        MessageBox.Show($"Tìm thấy số hàng hóa {maVach}");
                        txtmavach.Focus();
                        return;
                    }
                }
                MessageBox.Show("Không tìm thấy số hàng hóa.");
            }
            else
            {
                MessageBox.Show("Mã vạch không hợp lệ.");
            }

            txtmavach.Focus();
        }

       


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtmavach.Text = row.Cells["MaVach"].Value.ToString();
            }
        }

        private void cmdtim_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra nếu phím Enter được nhấn và độ dài chuỗi là 13 ký tự
            if (e.KeyCode == Keys.Enter && txtmavach.Text.Length == 13)
            {
                // Chuyển focus đến nút 
                cmdtim.Focus();
            }
            else
            {
                MessageBox.Show("Mã vạch không hợp lệ.");
                txtmavach.Focus();
            }
        }

        private void cmdtim_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtmavach.Text = row.Cells["MaVach"].Value.ToString();
            }
        }

        private void cmdtim_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void txtmavach_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Ngăn chặn ký tự không hợp lệ
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play(); // Beepppppp
            }
        }

        private void txtmavach_KeyDown_1(object sender, KeyEventArgs e)
        {
            // Kiểm tra nếu phím Enter được nhấn và độ dài chuỗi là 13 ký tự
            if (e.KeyCode == Keys.Enter && txtmavach.Text.Length == 13)
            {
                // Chuyển focus đến nút 
                cmdtim.Focus();
            }
            else
            {
                MessageBox.Show("Mã vạch không hợp lệ.");
                txtmavach.Focus();
            }
        }
    }
}
