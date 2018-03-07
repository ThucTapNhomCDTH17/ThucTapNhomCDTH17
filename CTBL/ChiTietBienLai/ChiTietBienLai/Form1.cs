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

namespace ChiTietBienLai
{

    public partial class Form1 : Form
    {
        string chuoiketnoi = @"Data Source=DESKTOP-U9S8HN6\SQLEXPRESS;Initial Catalog=QLThuHocPhiSV1;Integrated Security=True";
        string trangthai = "load";
        public static SqlConnection con;
        public static SqlDataAdapter da;
        public static SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuHocPhiSV1DataSet.ChiTietBienLai' table. You can move, or remove it, as needed.
            this.chiTietBienLaiTableAdapter.Fill(this.qLThuHocPhiSV1DataSet.ChiTietBienLai);

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
            btnluu.Enabled = true; 
        }
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
        private void Show_cmbmh(string mh)
        {
            connect();
            string sql = "select MaMonHoc from MonHoc";
            if (mh != "")
            {
                sql = sql + "where MaMonHoc= '" + mh + "'";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbmh.DataSource = dt;
            cmbmh.ValueMember = "MaMonHoc";
            cmbmh.DisplayMember = "TenMonHoc";
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
                    SqlParameter p1 = new SqlParameter("@Malhp", cmbmh.SelectedValue.ToString());
                    cmd.Parameters.Add(p1);                

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
                    SqlParameter p1 = new SqlParameter("@Malhp", cmbmh.SelectedValue.ToString());
                    cmd.Parameters.Add(p1);
                 

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

                int index = dataGridView1.CurrentCell.RowIndex;
                cmbsobl.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                int index1 = dataGridView1.CurrentCell.RowIndex;
                cmbmh.Text = dataGridView1.Rows[index1].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("eror!!" + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

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

        private void btnthem_Click(object sender, EventArgs e)
        {
            unlock();
            trangthai = "add";
        }
    }
}
