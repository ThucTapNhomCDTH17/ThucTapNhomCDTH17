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
    public partial class frmKhoa : Form
    {
        string chuoiketnoi = @"Data Source=DESKTOP-U9S8HN6\SQLEXPRESS;Initial Catalog=QLThuHocPhiSV1;Integrated Security=True";
        string trangthai = "load";
        public static SqlConnection con;
        public static SqlDataAdapter da;
        public static SqlCommand cmd;
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuHocPhiSV1DataSet17.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter1.Fill(this.qLThuHocPhiSV1DataSet17.Khoa);
            connect();
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
            dataGridViewkhoa.DataSource = gettable("select * from Khoa");

        }
        private void Lock()
        {
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = false;
            btnthoat.Enabled = false;
            txtdiachi.ReadOnly = true;
            txtsdt.ReadOnly = true;
            txtten.ReadOnly = true;
        }
        private void unlock()
        {
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = true;
            btnthoat.Enabled = true;
            txtdiachi.ReadOnly = false;
            txtsdt.ReadOnly = false;
            txtten.ReadOnly = false;
        }

        private void dataGridViewkhoa_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtma.DataBindings.Clear();
                txtma.DataBindings.Add("text", dataGridViewkhoa.DataSource, "MaKhoa");
                txtten.DataBindings.Clear();
                txtten.DataBindings.Add("text", dataGridViewkhoa.DataSource, "TenKhoa");
                txtsdt.DataBindings.Clear();
                txtsdt.DataBindings.Add("text", dataGridViewkhoa.DataSource, "SoDienThoai");
                txtdiachi.DataBindings.Clear();
                txtdiachi.DataBindings.Add("text", dataGridViewkhoa.DataSource, "DiaChi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("eror!!" + ex.Message);
            }
        }

        private string Sinhmatudong(string ma)
        {
            string Matusinh = "";
            int count = 0;
            count = dataGridViewkhoa.Rows.Count;
            int chuoiso = 0;
            if (count < 2)
            {
                Matusinh = "K001";
            }
            else
            {
                string chuoima = Convert.ToString(dataGridViewkhoa.Rows[count - 2].Cells[0].Value);
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
        private void dataGridViewkhoa_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewkhoa.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            trangthai = "add";
            txtma.Text = Sinhmatudong("K");
            unlock();
            txtten.Text = txtdiachi.Text = txtsdt.Text = "";
        }
        //
        private void btnsua_Click(object sender, EventArgs e)
        {
            trangthai = "edit";
            unlock();
        }
        //
        private void btnxoa_Click(object sender, EventArgs e)
        {
            trangthai = "delete";
            unlock();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (trangthai == "add")
            {
                try
                {
                    connect();
                    string sqlinsert = "Khoa_themKhoa";
                    cmd = new SqlCommand(sqlinsert, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaKhoa", txtma.Text);
                    cmd.Parameters.AddWithValue("@TenKhoa", txtten.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtdiachi.Text);
                    cmd.Parameters.AddWithValue("@SoDienThoai", txtsdt.Text);
                    cmd.ExecuteNonQuery();
                    load();
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
                    connect();
                    string sqlinsert = "Khoa_themKhoa";
                    cmd = new SqlCommand(sqlinsert, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaKhoa", txtma.Text);
                    cmd.Parameters.AddWithValue("@TenKhoa", txtten.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtdiachi.Text);
                    cmd.Parameters.AddWithValue("@SoDienThoai", txtsdt.Text);
                    cmd.ExecuteNonQuery();
                    load();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("error" + ex.Message);
                }
            }
            else if (trangthai == "delete")
              
            {
                try
                {
                    connect();
                    string sqldelete = "Khoa_xoaKhoa";
                    cmd = new SqlCommand(sqldelete, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaKhoa", txtma.Text);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("không thể xóa vì khóa này đã là khóa ngoài của lớp " );
                }
            }
            load();
            Lock();
            txtma.Text = txtten.Text = txtdiachi.Text = txtsdt.Text = txttimkiem.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect();
            string sqlSeach = "select * from Khoa where MaKhoa LIKE @MaKhoa";
            SqlCommand cmd = new SqlCommand(sqlSeach, con);
            cmd.Parameters.AddWithValue("@MaKhoa", '%' + txttimkiem.Text + '%');
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridViewkhoa.DataSource = dt;
        }
        //
    }
}
