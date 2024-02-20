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

namespace OnTapCK
{
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }
        private string connstr = "Data Source=TIENDUONG;Initial Catalog=CuoiKy;Integrated Security=True";

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTAIKHOAN.Text.Trim();
            string matKhau1 = txtPASS1.Text;
            string matKhau2 = txtPASS2.Text;

            if (string.IsNullOrWhiteSpace(taiKhoan) || string.IsNullOrWhiteSpace(matKhau1) || string.IsNullOrWhiteSpace(matKhau2))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu.");
                return;
            }

            if (matKhau1 != matKhau2)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp. Vui lòng thử lại.");
                return;
            }
            else
            {
                InsertTaiKhoan(taiKhoan, matKhau1);
            }
 


        }
        private void InsertTaiKhoan(string taiKhoan, string matKhau)
        {
            // Insert a new account into the TAIKHOAN table
            using (SqlConnection connection = new SqlConnection(connstr))
            {
                connection.Open();

                string query = "INSERT INTO TAIKHOAN (TAIKHOAN, MATKHAU) VALUES (@taiKhoan, @matKhau)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@taiKhoan", taiKhoan);
                    command.Parameters.AddWithValue("@matKhau", matKhau);

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Đăng ký thành công!");
                this.Hide();
                Form1 dangnhap = new Form1();
                dangnhap.ShowDialog();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 dangnhap = new Form1();
            dangnhap.ShowDialog();
        }
    }
}
