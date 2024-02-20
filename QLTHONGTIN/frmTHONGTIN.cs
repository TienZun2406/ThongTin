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
    public partial class frmTHONGTIN : Form
    {
        private string connstr = "Data Source=TIENDUONG;Initial Catalog=CuoiKy;Integrated Security=True";
        public frmTHONGTIN()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }

        private void frmTHONGTIN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cuoiKyDataSetTHONGTIN1.THONGTIN' table. You can move, or remove it, as needed.
            this.tHONGTINTableAdapter3.Fill(this.cuoiKyDataSetTHONGTIN1.THONGTIN);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow dtv = dataGridView1.Rows[e.RowIndex];
                string maNV = dtv.Cells["maNV"].Value.ToString();
                string ten = dtv.Cells["ten"].Value.ToString();
                string tuoi = dtv.Cells["tuoi"].Value.ToString();
                string noilamviec = dtv.Cells["noilamviec"].Value.ToString();

                txtMANV.Text = maNV;
                txtTEN.Text = ten;
                txtTUOI.Text = tuoi;
                txtNOILAMVIEC.Text = noilamviec;

                // Check if the column "ngaysinh" exists
                if (dataGridView1.Columns.Contains("ngaysinh"))
                {
                    // Retrieve the value from the "ngaysinh" cell
                    object ngaysinhValue = dtv.Cells["ngaysinh"].Value;

                    // Check if the value is not null
                    if (ngaysinhValue != null && ngaysinhValue != DBNull.Value)
                    {
                        // Convert the value to DateTime
                        DateTime ngaysinh = Convert.ToDateTime(ngaysinhValue);

                        // Set the DateTimePicker value
                        timeDOB.Value = ngaysinh;
                    }
                    else
                    {
                        // Clear the DateTimePicker if the value is null
                        timeDOB.Value = DateTime.Now;
                    }
                }

            }
        }
        private void LoadDataIntoDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(connstr))
            {
                connection.Open();

                string query = "SELECT * FROM THONGTIN";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }
        private void ReloadDataGridView()
        {
            LoadDataIntoDataGridView();
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            string ten = txtTEN.Text;
            string maNV = txtMANV.Text;
            //int tuoi = Convert.ToInt32(txtTUOI.Text);
            string tuoiText = txtTUOI.Text;
            string noilamviec = txtNOILAMVIEC.Text;
            DateTime ngaysinh = timeDOB.Value;

            if (string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(noilamviec) || string.IsNullOrWhiteSpace(tuoiText) || string.IsNullOrWhiteSpace(maNV))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            if (!int.TryParse(tuoiText, out int tuoi))
            {
                MessageBox.Show("Vui lòng nhập tuổi là một số nguyên.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();

                string querycheck = "SELECT COUNT(*) FROM THONGTIN WHERE maNV = @maNV ";
                using (SqlCommand cmd = new SqlCommand(querycheck,conn))
                {
                    cmd.Parameters.AddWithValue("@maNV", maNV);

                    int exist = (int)cmd.ExecuteScalar();

                    if (exist>0)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng chọn mã nhân viên khác.");
                        return;
                    }
                }
            }

            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();

                string query = "INSERT INTO THONGTIN (maNV ,ten, tuoi, noilamviec, ngaysinh) VALUES (@maNV ,@ten, @tuoi, @noilamviec, @ngaysinh)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ten", ten);
                    cmd.Parameters.AddWithValue("@maNV", maNV);
                    cmd.Parameters.AddWithValue("@tuoi", tuoi);
                    cmd.Parameters.AddWithValue("@noilamviec", noilamviec);
                    cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Dữ liệu đã được thêm vào cơ sở dữ liệu thành công.");
                        this.frmTHONGTIN_Load(sender,e);
                        txtMANV.Clear();
                        txtNOILAMVIEC.Clear();
                        txtTEN.Clear();
                        txtTUOI.Clear();
                        LoadDataIntoDataGridView();
                    }
                }
            }
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 logIn = new Form1();
            logIn.ShowDialog();
            this.Hide();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                using (SqlConnection connection = new SqlConnection(connstr))
                {
                    connection.Open();

                    string query = "DELETE FROM THONGTIN WHERE ID = @ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", selectedID);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dữ liệu đã được xóa khỏi cơ sở dữ liệu thành công.");
                            txtMANV.Clear();
                            txtNOILAMVIEC.Clear();
                            txtTEN.Clear();
                            txtTUOI.Clear();
                            LoadDataIntoDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa dữ liệu. Kiểm tra lại thông tin.");
                        }
                    }
                }
            }
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                using (SqlConnection connection = new SqlConnection(connstr))
                {
                    connection.Open();

                    string query = "UPDATE THONGTIN " +
                        "SET ten = @ten, " +
                        "maNV= @maNV" +
                        "tuoi = @tuoi, " +
                        "noilamviec = @noilamviec, " +
                        "ngaysinh = @ngaysinh " +
                        "WHERE ID = @ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", selectedID);
                        command.Parameters.AddWithValue("@ten", txtTEN.Text);
                        command.Parameters.AddWithValue("@maNV", txtMANV.Text);
                        command.Parameters.AddWithValue("@tuoi", txtTUOI.Text);
                        command.Parameters.AddWithValue("@noilamviec", txtNOILAMVIEC.Text);
                        command.Parameters.AddWithValue("@ngaysinh", timeDOB.Value);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dữ liệu đã được sửa thành công.");
                            txtMANV.Clear();
                            txtNOILAMVIEC.Clear();
                            txtTEN.Clear();
                            txtTUOI.Clear();
                            LoadDataIntoDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa dữ liệu. Kiểm tra lại thông tin.");
                        }
                    }
                }
            }
        }

        private void btnTIM_Click(object sender, EventArgs e)
        {
            string maNV = txtTIM.Text;
            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Hãy nhập thông tin cần tìm ");
                return;
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connstr))
                {
                    connection.Open();
                    string query = "SELECT * FROM THONGTIN WHERE maNV=@maNV";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@maNV", maNV);
                        DataTable dataTable = new DataTable();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu.");
                        }
                        txtTIM.Clear();
                    }
                }
            }
        }
    }
}
