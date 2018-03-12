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
    public partial class frmMucthu : Form
    {
        string chuoiketnoi = @"Data Source=DESKTOP-U9S8HN6\SQLEXPRESS;Initial Catalog=QLThuHocPhiSV1;Integrated Security=True";
        string trangthai = "load";
        public static SqlConnection con;
        public static SqlDataAdapter da;
        public static SqlCommand cmd;
        public frmMucthu()
        {
            InitializeComponent();
        }

        private void frmMucthu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuHocPhiSV1DataSet21.Mucthu' table. You can move, or remove it, as needed.
            this.mucthuTableAdapter2.Fill(this.qLThuHocPhiSV1DataSet21.Mucthu);
            // TODO: This line of code loads data into the 'qLThuHocPhiSV1DataSet20.Mucthu' table. You can move, or remove it, as needed.
            this.mucthuTableAdapter1.Fill(this.qLThuHocPhiSV1DataSet20.Mucthu);

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
        //
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
            dataGridView1.DataSource = gettable("select * from MucThu");

        }
        //
        private void Lock()
        {
            txtSoTien.ReadOnly =txtMa.ReadOnly= true;
            btnLuu.Enabled = false;
        }
        //
        private void unlock()
        {
            txtSoTien.ReadOnly = false;
            btnLuu.Enabled = true;
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
                Matusinh = "Mt001";
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
        //
        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            unlock();
            trangthai = "add";
            txtMa.Text = Sinhmatudong("Mt");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            unlock();
            trangthai = "edit";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            unlock();
            trangthai = "delete";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (trangthai == "add")
            {
                try
                {
                    connect();
                    string sqlinsert = "them_Mucthu";
                    cmd = new SqlCommand(sqlinsert, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaMucThu", txtMa.Text);
                    cmd.Parameters.AddWithValue("@tien1TC", txtSoTien.Text);
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
                    string sqlinsert = "sua_Mucthu";
                    cmd = new SqlCommand(sqlinsert, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaMucThu", txtMa.Text);
                    cmd.Parameters.AddWithValue("@tien1TC", txtSoTien.Text);
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
                    string sqlinsert = "xoa_Mucthu";
                    cmd = new SqlCommand(sqlinsert, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaMucThu", txtMa.Text);
                    cmd.ExecuteNonQuery();
                    load();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("error" + ex.Message);
                }
            }
            load();
            Lock();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            connect();
            string sqlSeach = "select * from MucThu where MaMucthu LIKE @MaMucthu";
            SqlCommand cmd = new SqlCommand(sqlSeach, con);
            cmd.Parameters.AddWithValue("@MaMucthu", '%' + txtTk.Text + '%');
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMa.DataBindings.Clear();
                txtMa.DataBindings.Add("text", dataGridView1.DataSource, "MaMucthu");
                txtSoTien.DataBindings.Clear();
                txtSoTien.DataBindings.Add("text", dataGridView1.DataSource, "Tien1TinChi");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (exit == DialogResult.OK)
                Application.Exit();
        }
    }
}
