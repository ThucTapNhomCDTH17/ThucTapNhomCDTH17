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
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }

        string chuoiketnoi = @"Data Source=DESKTOP-U9S8HN6\SQLEXPRESS;Initial Catalog=QLThuHocPhiSV1;Integrated Security=True";
        string trangthai = "load";
        public static SqlConnection con;
        public static SqlDataAdapter da;
        public static SqlCommand cmd;

        private void frmLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuHocPhiSV1DataSet18.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter2.Fill(this.qLThuHocPhiSV1DataSet18.Lop);
            // TODO: This line of code loads data into the 'qLThuHocPhiSV1DataSet5.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter1.Fill(this.qLThuHocPhiSV1DataSet5.Lop);
            SqlConnection con = new SqlConnection(chuoiketnoi);
            Show_cmbKhoa("");
            Lock();
            load();
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
            dataGridView1.DataSource = gettable("select * from Lop");

        }
        private void Lock()
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnLuu.Enabled = false;
            txtMa.ReadOnly = txtsiso.ReadOnly = txtTen.ReadOnly = true;

        }
        private void Unlock()
        {
            btnLuu.Enabled = true;
            txtsiso.ReadOnly = txtTen.ReadOnly = false;
            txtsiso.Clear();
            txtTen.Clear();
        }

    
        private string Sinhmatudong(string ma)
        {
            string Matusinh = "";
            int count = 0;
            count = dataGridView1.Rows.Count;
            int chuoiso = 0;
            if (count < 2)
            {
                Matusinh = "Lop001";
            }
            else
            {
                string chuoima = Convert.ToString(dataGridView1.Rows[count - 2].Cells[0].Value);
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
        private void Show_cmbKhoa(string makhoa)
        {
            SqlConnection con = new SqlConnection(chuoiketnoi);
            string sql = "select MaKhoa, TenKhoa from Khoa";
            if (makhoa != "")
            {
                sql = sql + "where MaKhoa= '" + makhoa + "'";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbmakhoa.DataSource = dt;
            cmbmakhoa.ValueMember = "MaKhoa";
            cmbmakhoa.DisplayMember = "TenKhoa";

        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            Unlock();
            trangthai = "add";
            txtMa.Text = Sinhmatudong("Lop");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Unlock();
            trangthai = "edit";
            txtMa.ReadOnly = false;
            txtMa.Focus();
            txtMa.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            trangthai = "delete";
            txtMa.ReadOnly = false;
            txtMa.Focus();
            txtMa.Clear();
            Unlock();
        }

        private void dataGridView1_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMa.DataBindings.Clear();
                txtMa.DataBindings.Add("text", dataGridView1.DataSource, "MaLop");
                txtTen.DataBindings.Clear();
                txtTen.DataBindings.Add("text", dataGridView1.DataSource, "TenLop");
                txtsiso.DataBindings.Clear();
                txtsiso.DataBindings.Add("text", dataGridView1.DataSource, "SiSo");
                int index = dataGridView1.CurrentCell.RowIndex;
                cmbmakhoa.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (trangthai == "add")
            {
                try
                {
                    SqlConnection con = new SqlConnection(chuoiketnoi);
                    con.Open();
                    string them = "Lop_themLop";
                    SqlCommand cmd = new SqlCommand(them, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaLop", txtMa.Text);
                    cmd.Parameters.AddWithValue("@TenLop", txtTen.Text);
                    cmd.Parameters.AddWithValue("@SiSo", txtsiso.Text);
                    SqlParameter p = new SqlParameter("@MaKhoa", cmbmakhoa.SelectedValue.ToString());
                    cmd.Parameters.Add(p);
                    // thực thi thủ tục
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("error" + ex.Message);
                }

            }
            else if (trangthai == "edit")
            {
                try
                {
                    SqlConnection con = new SqlConnection(chuoiketnoi);
                    con.Open();
                    string sua = "Lop_suaLop";
                    SqlCommand cmd = new SqlCommand(sua, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaLop", txtMa.Text);
                    cmd.Parameters.AddWithValue("@TenLop", txtTen.Text);
                    cmd.Parameters.AddWithValue("@SiSo", txtsiso.Text);
                    SqlParameter p = new SqlParameter("@MaKhoa", cmbmakhoa.SelectedValue.ToString());
                    cmd.Parameters.Add(p);
                    //thực thi thủ tục
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("error" + ex.Message);
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
                        string xóa = "Lop_xoaLop";
                        SqlCommand cmd = new SqlCommand(xóa, con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaLop", txtMa.Text);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Không thể xóa trường là khóa ngoại của trường khác :" + ex.Message);
                    }
                }

            }
            load();
            Lock();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(chuoiketnoi);
            con.Open();
            string sqlSeach = "select * from Lop where MaLop LIKE @MaLop";
            SqlCommand cmd = new SqlCommand(sqlSeach, con);
            cmd.Parameters.AddWithValue("@MaLop", '%' + txtTK.Text + '%');
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (exit == DialogResult.OK)
                Application.Exit();
        }

        private void dataGridView1_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("text", dataGridView1.DataSource, "MaLop");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("text", dataGridView1.DataSource, "TenLop");
            txtsiso.DataBindings.Clear();
            txtsiso.DataBindings.Add("text", dataGridView1.DataSource, "SiSo");

        }
    }
}
