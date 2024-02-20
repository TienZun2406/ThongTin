using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OnTapCK
{
    public partial class Form1 : Form
    {
        private string connstr = "Data Source=TIENDUONG;Initial Catalog=CuoiKy;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtAccount.Text;
            string pass = txtPass.Text;

            // Kiểm tra xem cả hai trường đều đã được nhập
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();

                string query = "SELECT * FROM TAIKHOAN WHERE taikhoan = @username AND matkhau = @pass";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue ("@username", username);
                    cmd.Parameters.AddWithValue ("@pass", pass);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Đăng nhập thành công có thể lấy thông tin từ cột khác nếu cần


                            MessageBox.Show($"Dang nhap thanh cong!");
                           this.Hide();
                           frmTHONGTIN thongtin = new frmTHONGTIN();
                           thongtin.ShowDialog();


                        }
                        else
                        {
                            MessageBox.Show("Dang nhap that bai");
                        }
                    }
                }
                conn.Close();

            }
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = (checkBox1.Checked) ? '\0' : '*';

        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            signUp dangky = new signUp();
            dangky.ShowDialog();

        }
    }
}
