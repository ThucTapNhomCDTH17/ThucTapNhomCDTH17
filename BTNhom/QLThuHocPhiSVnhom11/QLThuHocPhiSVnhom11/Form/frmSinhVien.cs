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
    public partial class frmSinhVien : Form
    {
        string chuoiketnoi = @"Data Source=DESKTOP-U9S8HN6\SQLEXPRESS;Initial Catalog=QLThuHocPhiSV1;Integrated Security=True";
        string trangthai = "load";
        public static SqlConnection con;
        public static SqlDataAdapter da;
        public static SqlCommand cmd;

        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuHocPhiSV1DataSet23.MonHoc' table. You can move, or remove it, as needed.
            this.monHocTableAdapter.Fill(this.qLThuHocPhiSV1DataSet23.MonHoc);
            // TODO: This line of code loads data into the 'qLThuHocPhiSV1DataSet15.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter1.Fill(this.qLThuHocPhiSV1DataSet15.SinhVien);
            connect();
            load();
            Lock();
            Show_cmbDoituongMG("");
            Show_cmbL("");
            Show_ttlop("");
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
            dataGridView1.DataSource = gettable("select * from SinhVien");

        }
        private void Lock()
        {
            txtMa.ReadOnly = true;// chỉ được nhìn
            txtTen.ReadOnly = true;
            txtGT.ReadOnly = true;
            txtNS.ReadOnly = false;
            cmbMaDT.Enabled = false;
            cmbL.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnThoat.Enabled = true;
        }
        private void Unlock()
        {
            txtMa.ReadOnly = false;// chỉ được nhìn
            txtTen.ReadOnly = false;
            txtGT.ReadOnly = false;
            txtNS.ReadOnly = false;
            cmbMaDT.Enabled = true;
            cmbL.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnThoat.Enabled = true;
            txtMa.Focus(); // chỉ con trỏ chuột về đây
        }
        private void Show_cmbDoituongMG(string MaDoiTuong)
        {
            SqlConnection con = new SqlConnection(chuoiketnoi);
            string sql = "select MaDoiTuong, TenDoiTuong from DoiTuongMienGiam";
            if (MaDoiTuong != "")
            {
                sql = sql + "where MaDoiTuong= '" + MaDoiTuong + "'";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMaDT.DataSource = dt;
            cmbMaDT.ValueMember = "MaDoiTuong";
            cmbMaDT.DisplayMember = "TenDoiTuong";
        }
        private void Show_cmbL(string MaLop)
        {
            SqlConnection con = new SqlConnection(chuoiketnoi);
            string sql = "select MaLop, TenLop from Lop";
            if (MaLop != "")
            {
                sql = sql + "where MaLop= '" + MaLop + "'";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbL.DataSource = dt;
            cmbL.ValueMember = "MaLop";
            cmbL.DisplayMember = "TenLop";
        }

        private void Show_ttlop(string MaLop)
        {
            SqlConnection con = new SqlConnection(chuoiketnoi);
            string sql = "select MaLop, TenLop from Lop";
            if (MaLop != "")
            {
                sql = sql + "where MaLop= '" + MaLop + "'";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbmalop.DataSource = dt;
            cmbmalop.ValueMember = "MaLop";
            cmbmalop.DisplayMember = "TenLop";
        }

        private string matudong(string ma)
        {
            string matudong = "";
            int count = 0;
            count = dataGridView1.Rows.Count;
            int chuoiso = 0;
            if (count < 2)
            {
                matudong = "SV001";
            }
            else
            {
                string chuoima = Convert.ToString(dataGridView1.Rows[count - 2].Cells[1].Value);
                chuoiso = Convert.ToInt32(chuoima.Replace(ma, ""));
                if (chuoiso + 1 < 10)
                {
                    matudong = ma + "00" + (chuoiso + 1).ToString();

                }
                else if (chuoiso + 1 < 100)
                {
                    matudong = ma + "0" + (chuoiso + 1).ToString();
                }
            }

            return matudong;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Unlock();
            txtMa.Text = matudong("SV");
            trangthai = "add";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            trangthai = "edit";
            Unlock();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Unlock();
            trangthai = "delete";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (trangthai == "add")
            {
                try
                {
                    connect();
                    string them = "them_sv";
                    SqlCommand cmd = new SqlCommand(them, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSV", txtMa.Text);
                    cmd.Parameters.AddWithValue("@TenSV", txtTen.Text);
                    cmd.Parameters.AddWithValue("@Gioitinh", txtGT.Text);
                    SqlParameter p2 = new SqlParameter("@Ngaysinh", Convert.ToString(txtNS.Text));
                    cmd.Parameters.Add(p2);
                    SqlParameter p = new SqlParameter("@Madt", cmbMaDT.SelectedValue.ToString());
                    cmd.Parameters.Add(p);
                    SqlParameter p1 = new SqlParameter("@Mal", cmbL.SelectedValue.ToString());
                    cmd.Parameters.Add(p1);
                    // thực thi thủ tục
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("eror!!!" + ex.Message);
                }
            }
            else if (trangthai == "edit")
            {
                try
                {
                    SqlConnection con = new SqlConnection(chuoiketnoi);
                    con.Open();
                    string them = "sua_sv";
                    SqlCommand cmd = new SqlCommand(them, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSV", txtMa.Text);
                    cmd.Parameters.AddWithValue("@TenSV", txtTen.Text);
                    cmd.Parameters.AddWithValue("@Gioitinh", txtGT.Text);
                    SqlParameter p2 = new SqlParameter("@Ngaysinh", Convert.ToString(txtNS.Text));
                    cmd.Parameters.Add(p2);
                    SqlParameter p = new SqlParameter("@Madt", cmbMaDT.SelectedValue.ToString());
                    cmd.Parameters.Add(p);
                    SqlParameter p1 = new SqlParameter("@Mal", cmbL.SelectedValue.ToString());
                    cmd.Parameters.Add(p1);
                    // thực thi thủ tục
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("eror!!!" + ex.Message);
                }
            }
            else if (trangthai == "delete")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa lớp không?" + txtMa.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(chuoiketnoi);
                        con.Open();
                        string them = "xoa_sv";
                        SqlCommand cmd = new SqlCommand(them, con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaSV", txtMa.Text);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("eror!!!" + ex.Message);
                    }
                }
            }
                load();
                Lock();
                txtMa.Text = txtTen.Text = txtNS.Text = txtGT.Text = "";
            }
        

        private void btnTK_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(chuoiketnoi);
                con.Open();
                string sqlSeach = "select * from Lop where MaSinhVien LIKE @MaSinhVien";
                SqlCommand cmd = new SqlCommand(sqlSeach, con);
                cmd.Parameters.AddWithValue("@MaSinhVien", '%' + txtTK.Text + '%');
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show("Lỗi Kết Nối..!!!" + ex.Message); }
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
                txtMa.DataBindings.Add("text", dataGridView1.DataSource, "MaSv");
                txtTen.DataBindings.Clear();
                txtTen.DataBindings.Add("text", dataGridView1.DataSource, "HoTen");
                txtGT.DataBindings.Clear();
                txtGT.DataBindings.Add("text", dataGridView1.DataSource, "GioiTinh");
                txtNS.DataBindings.Clear();
                txtNS.DataBindings.Add("text", dataGridView1.DataSource, "NgaySinh");
                int index = dataGridView1.CurrentCell.RowIndex;
                cmbMaDT.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
                int index1 = dataGridView1.CurrentCell.RowIndex;
                cmbL.Text = dataGridView1.Rows[index1].Cells[6].Value.ToString();
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

        private void cmbtenlop_SelectionChangeCommitted(object sender, EventArgs e)

        {
            try
            {

                connect();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sear_mh";
                command.Parameters.AddWithValue("@Mal", cmbmalop.SelectedValue);
                command.Connection = con;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("error!! " + ex.Message);
            }
        }
    }
}
