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
    public partial class frmCTBL : Form
    {
        string chuoiketnoi = @"Data Source=DESKTOP-U9S8HN6\SQLEXPRESS;Initial Catalog=QLThuHocPhiSV1;Integrated Security=True";
        string trangthai = "load";
        public static SqlConnection con;
        public static SqlDataAdapter da;
        public static SqlCommand cmd;
        public frmCTBL()
        {
            InitializeComponent();
        }



        private void frmCTBL_Load(object sender, EventArgs e)
        {
            load();
            Lock();
            Show_cmblhp("");
            Show_cmbmasv("");
            Show_cmbsobl("");
            Show_cmbtksobl("");

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
            dataGridView1.DataSource = gettable("select * from ChiTietBienLai");

        }
        //
        private void Lock()
        {
            btnluu.Enabled = false;
        }
        //
        private void unlock()
        {
            btnluu.Enabled = true; txtsoien.ReadOnly = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            unlock();
            trangthai = "add";
        }
        //
        private void Show_cmbsobl(string sobl)
        {
            connect();
            string sql = "select SoBienLai from BienLaiTienHoc";
            if (sobl != "")
            {
                sql = sql + "where SoBienLai= '" + sobl + "'";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbsobl.DataSource = dt;
            cmbsobl.ValueMember = "SoBienLai";
            cmbsobl.DisplayMember = "SoBienLai";
        }
        /// <summary>
        //

        private void Show_cmblhp(string lhp)
        {
            connect();
            string sql = "select MaLopHocPhan from Lop_Hocphan";
            if (lhp != "")
            {
                sql = sql + "where MaLopHocPhan= '" + lhp + "'";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmblhp.DataSource = dt;
            cmblhp.ValueMember = "MaLopHocPhan";
            cmblhp.DisplayMember = "MaLopHocPhan";
        }
        //
        private void Show_cmbmasv(string masv)
        {
            connect();
            string sql = "select MaSV,HoTen from SinhVien";
            if (masv != "")
            {
                sql = sql + "where MaSV= '" + masv + "'";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbmasv.DataSource = dt;
            cmbmasv.ValueMember = "MaSV";
            cmbmasv.DisplayMember = "HoTen";
        }
        //
        private void Show_cmbtksobl(string tksobl)
        {
            connect();
            string sql = "select SoBienLai from BienLaiTienHoc";
            if (tksobl != "")
            {
                sql = sql + "where SoBienLai= '" + tksobl + "'";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbtk.DataSource = dt;
            cmbtk.ValueMember = "SoBienLai";
            cmbtk.DisplayMember = "SoBienLai";
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (trangthai == "add")
            {
                try
                {
                    SqlConnection con = new SqlConnection(chuoiketnoi);
                    con.Open();
                    string them = "them_ctbl";
                    SqlCommand cmd = new SqlCommand(them, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@SoBL", cmbsobl.SelectedValue.ToString());
                    cmd.Parameters.Add(p);
                    SqlParameter p1 = new SqlParameter("@Malhp", cmblhp.SelectedValue.ToString());
                    cmd.Parameters.Add(p1);
                    SqlParameter p2 = new SqlParameter("@MaSV", cmbmasv.SelectedValue.ToString());
                    cmd.Parameters.Add(p2);

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
                    string them = "sua_ctbl";
                    SqlCommand cmd = new SqlCommand(them, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@SoBL", cmbsobl.SelectedValue.ToString());
                    cmd.Parameters.Add(p);
                    SqlParameter p1 = new SqlParameter("@Malhp", cmblhp.SelectedValue.ToString());
                    cmd.Parameters.Add(p1);
                    SqlParameter p2 = new SqlParameter("@MaSV", cmbmasv.SelectedValue.ToString());
                    cmd.Parameters.Add(p2);

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
                    SqlConnection con = new SqlConnection(chuoiketnoi);
                    con.Open();
                    string them = "xoa_ctbl";
                    SqlCommand cmd = new SqlCommand(them, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p = new SqlParameter("@SoBL", cmbsobl.SelectedValue.ToString());
                    cmd.Parameters.Add(p);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("error" + ex.Message);
                }
            }
            load();
            Lock();
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
                txtsoien.DataBindings.Clear();
                txtsoien.DataBindings.Add("text", dataGridView1.DataSource, "SoTien");
                int index = dataGridView1.CurrentCell.RowIndex;
                cmbsobl.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                int index1 = dataGridView1.CurrentCell.RowIndex;
                cmblhp.Text = dataGridView1.Rows[index1].Cells[2].Value.ToString();
                int index2 = dataGridView1.CurrentCell.RowIndex;
                cmbmasv.Text = dataGridView1.Rows[index2].Cells[3].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("eror!!" + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)//tìm kiếm
        {
            connect();
            string sqlSeach = "select * from ChiTietBienLai where SoBienLai=@SoBL ";
            SqlCommand cmd = new SqlCommand(sqlSeach, con);
            SqlParameter p = new SqlParameter("@SoBL", cmbtk.SelectedValue.ToString());
            cmd.Parameters.Add(p);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            unlock();
            trangthai = "edit";
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            unlock();
            trangthai = "delete";
        }
    }
}
