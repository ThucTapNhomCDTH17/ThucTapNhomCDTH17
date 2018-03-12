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
    public partial class frmMonHoc : Form
    {
        string chuoiketnoi = @"Data Source=DESKTOP-U9S8HN6\SQLEXPRESS;Initial Catalog=QLThuHocPhiSV1;Integrated Security=True";
        string trangthai = "load";
        public static SqlConnection con;
        public static SqlDataAdapter da;
        public static SqlCommand cmd;
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuHocPhiSV1DataSet19.MonHoc' table. You can move, or remove it, as needed.
            this.monHocTableAdapter1.Fill(this.qLThuHocPhiSV1DataSet19.MonHoc);
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
        //
        public void load()//load bang csdl
        {
            connect();
            dataGridView1.DataSource = gettable("select * from MonHoc");

        }
        //
        private void Lock()
        {
            txtma.ReadOnly = txtten.ReadOnly = txtsotc.ReadOnly = true;
            btnluu.Enabled = false;
        }
        //
        private void unlock()
        {
            txtma.ReadOnly = txtten.ReadOnly = txtsotc.ReadOnly = false;
            btnluu.Enabled = true;
        }
        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
        //


        private string Sinhmatudong(string ma)
        {
            string Matusinh = "";
            int count = 0;
            count = dataGridView1.Rows.Count;
            int chuoiso = 0;
            if (count < 2)
            {
                Matusinh = "MH001";
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
        private void btnthem_Click(object sender, EventArgs e)
        {
            trangthai = "add";
            unlock();
            txtma.Text = Sinhmatudong("MH");
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
        //
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (trangthai == "add")
            {
                try
                {
                    connect();
                    string them = "them_monhoc";
                    SqlCommand cmd = new SqlCommand(them, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaMH", txtma.Text);
                    cmd.Parameters.AddWithValue("@TenMH", txtten.Text);
                    cmd.Parameters.AddWithValue("@SoTC", txtsotc.Text);
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
                    connect();
                    string them = "sua_monhoc";
                    SqlCommand cmd = new SqlCommand(them, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaMH", txtma.Text);
                    cmd.Parameters.AddWithValue("@TenMH", txtten.Text);
                    cmd.Parameters.AddWithValue("@SoTC", txtsotc.Text);
                    // thực thi thủ tục
                    cmd.ExecuteNonQuery();
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
                    string them = "Xoa_monhoc";
                    SqlCommand cmd = new SqlCommand(them, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaMonHoc", txtma.Text);

                    // thực thi thủ tục
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("error" + ex.Message);
                }
            }
            load();
            Lock();
            txtma.Text = txtsotc.Text = txtten.Text = txttk.Text = "";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (exit == DialogResult.OK)
                Application.Exit();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtma.DataBindings.Clear();
                txtma.DataBindings.Add("text", dataGridView1.DataSource, "MaMonHoc");
                txtten.DataBindings.Clear();
                txtten.DataBindings.Add("text", dataGridView1.DataSource, "TenMonHoc");
                txtsotc.DataBindings.Clear();
                txtsotc.DataBindings.Add("text", dataGridView1.DataSource, "SoTC");
            }
            catch (Exception ex)
            {
                MessageBox.Show("eror!!" + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            connect();
            string sqlSeach = "select * from MonHoc where MaMonHoc LIKE @MaMonHoc";
            SqlCommand cmd = new SqlCommand(sqlSeach, con);
            cmd.Parameters.AddWithValue("@MaMonHoc", '%' + txttk.Text + '%');
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
        //
    }
}
