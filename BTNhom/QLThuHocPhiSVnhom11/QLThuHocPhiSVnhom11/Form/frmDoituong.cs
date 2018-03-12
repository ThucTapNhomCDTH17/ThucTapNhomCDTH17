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

namespace QLThuHocPhiSVnhom11
{
    public partial class frmDoituong : Form
    {
        string chuoiketnoi = @"Data Source=DESKTOP-U9S8HN6\SQLEXPRESS;Initial Catalog=QLThuHocPhiSV1;Integrated Security=True";
        string trangthai = "load";
        public static SqlConnection con;
        public static SqlDataAdapter da;
        public static SqlCommand cmd;
        public frmDoituong()
        {
            InitializeComponent();
        }

        private void frmDoituong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuHocPhiSV1DataSet16.DoiTuongMienGiam' table. You can move, or remove it, as needed.
            this.doiTuongMienGiamTableAdapter1.Fill(this.qLThuHocPhiSV1DataSet16.DoiTuongMienGiam);
            load();
            Lock();

        }
        private void connect()
        {
            try
            {
                con = new SqlConnection(chuoiketnoi);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("eror!!!!" + ex.Message);
            }

        }
        public static DataTable gettable(string sql)//chương trình lấy dữ liệu từ câu truy vấn
        {

            cmd = new SqlCommand(sql, con);//(kết nối , nhập dữ liệu)
            da = new SqlDataAdapter(cmd);
            DataTable db = new DataTable();//tạo bảng
            da.Fill(db);//đổ dữ liệu từ datadapter vào datatable
            return db;
        }
        public void load()//load bang csdl
        {
            connect();
            dataGridView1.DataSource = gettable("select * from DoiTuongMienGiam");

        }
        private void Lock()
        {
            txtMa.ReadOnly = true;// chỉ được nhìn
            txtTen.ReadOnly = true;
            txtMG.ReadOnly = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnThoat.Enabled = true;

        }
        private void UnLock()
        {
            txtMa.ReadOnly = false;
            txtTen.ReadOnly = false;
            txtMG.ReadOnly = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnThoat.Enabled = true;
            txtMa.Focus();
        }
        private string Sinhmatudong(string ma)
        {
            string Matusinh = "";
            int count = 0;
            count = dataGridView1.Rows.Count;
            int chuoiso = 0;
            if (count < 2)
            {
                Matusinh = "DT000";
            }
            else
            {
                string chuoima = Convert.ToString(dataGridView1.Rows[count - 2].Cells[1].Value);
                chuoiso = Convert.ToInt32(chuoima.Replace(ma, ""));
                if (chuoiso + 1 < 10)
                {
                    Matusinh = ma + "00" + (chuoiso + 1).ToString();

                }
                else if (chuoiso + 1 < 100)
                {
                    Matusinh = ma + "0" + (chuoiso + 1).ToString();
                }
            }

            return Matusinh;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnLock();
            txtMa.Text = txtTen.Text = txtMG.Text = "";
            txtMa.Text = Sinhmatudong("DT");
            trangthai = "add";

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UnLock();
            txtMa.Text = txtTen.Text = txtMG.Text = "";
            trangthai = "edit";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            UnLock();
            txtMa.Text = txtTen.Text = txtMG.Text = "";
            trangthai = "delete";
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtMa.DataBindings.Clear();
                txtMa.DataBindings.Add("text", dataGridView1.DataSource, "MaDoiTuong");
                txtTen.DataBindings.Clear();
                txtTen.DataBindings.Add("text", dataGridView1.DataSource, "TenDoiTuong");
                txtMG.DataBindings.Clear();
                txtMG.DataBindings.Add("text", dataGridView1.DataSource, "MienGiam");
            }
            catch(Exception ex)
            {
                MessageBox.Show("eror!!" + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (exit == DialogResult.OK)
                Application.Exit();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (trangthai == "add")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("them_dtmg", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaDT", txtMa.Text);
                    cmd.Parameters.AddWithValue("@TenDT", txtTen.Text);
                    cmd.Parameters.AddWithValue("@Miengiam", txtMG.Text);
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("eror!!" + ex.Message);
                }
            }
            else if (trangthai == "edit")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sua_dtmg", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaDT", txtMa.Text);
                    cmd.Parameters.AddWithValue("@TenDT", txtTen.Text);
                    cmd.Parameters.AddWithValue("@Miengiam", txtMG.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("eror!!" + ex.Message);
                }
            }
            else if (trangthai == "delete")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("xoa_dtmg", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaDT", txtMa.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("eror!!" + ex.Message);
                }
            }
            load();
            Lock();
            txtMa.Text = txtTen.Text = txtMG.Text = "";
        }
    }
}
