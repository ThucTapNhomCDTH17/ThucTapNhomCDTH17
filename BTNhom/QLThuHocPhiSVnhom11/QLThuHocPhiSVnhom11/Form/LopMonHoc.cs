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
    public partial class LopMonHoc : Form
    {
        public LopMonHoc()
        {
            InitializeComponent();
        }

        private void LopMonHoc_Load(object sender, EventArgs e)
        {
            load();
            Lock();
            Show_cmbMalop("");
            Show_cmbMaMT("");
        }

        string chuoiketnoi = @"Data Source=DESKTOP-U9S8HN6\SQLEXPRESS;Initial Catalog=QLThuHocPhiSV1;Integrated Security=True";
        string trangthai = "load";
        public static SqlConnection con;
        public static SqlDataAdapter da;
        public static SqlCommand cmd;
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
            dataGridView1.DataSource = gettable("select * from LopMonHoc");

        }


        //Show combobox
        private void Show_cmbMaMT(string Mamt)
        {
            connect();
            string sql = "select MaMucThu from MucThu";
            if (Mamt != "")
            {
                sql = sql + "where MaMucThu= '" + Mamt + "'";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbmucthu.DataSource = dt;
            cmbmucthu.ValueMember = "MaMucThu";
            cmbmucthu.DisplayMember = "MaMucThu";
        }

        private void Show_cmbMalop(string lop)
        {
            connect();
            string sql = "select MaLop from Lop";
            if (lop != "")
            {
                sql = sql + "where MaLop= '" + lop + "'";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbmalop.DataSource = dt;
            cmbmalop.ValueMember = "MaLop";
            cmbmalop.DisplayMember = "TenLop";
        }
        public void Lock()
        {
            txtmalop.ReadOnly = txthocki.ReadOnly = txtnamhoc.ReadOnly = txtsiso.ReadOnly = true;
            btnluu.Enabled = false;
        }
        public void Unlock()
        {
            txthocki.ReadOnly = txtnamhoc.ReadOnly = txtsiso.ReadOnly = false;
            btnluu.Enabled = true;
        }

        private string matudong(string ma)
        {
            string matudong = "";
            int count = 0;
            count = dataGridView1.Rows.Count;
            int chuoiso = 0;
            if (count < 2)
            {
                matudong = "MLMH001";
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            Unlock();
            trangthai = "add";
            txtmalop.Text = matudong("MLMH");
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Unlock();
            trangthai = "edit";
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            Unlock();
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
                txtmalop.DataBindings.Clear();
                txtmalop.DataBindings.Add("text", dataGridView1.DataSource, "MaLop");
                txthocki.DataBindings.Clear();
                txthocki.DataBindings.Add("text", dataGridView1.DataSource, "HocKi");
                txtnamhoc.DataBindings.Clear();
                txtnamhoc.DataBindings.Add("text", dataGridView1.DataSource, "NamHoc");
                txtsiso.DataBindings.Clear();
                txtsiso.DataBindings.Add("text", dataGridView1.DataSource, "Siso");
                int index = dataGridView1.CurrentCell.RowIndex;
                cmbmucthu.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
                int index1 = dataGridView1.CurrentCell.RowIndex;
                cmbmalop.Text = dataGridView1.Rows[index1].Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("eror!!" + ex.Message);
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (trangthai == "add")
            {
                try
                {
                    connect();
                    string them = "Them_LopMH";
                    SqlCommand cmd = new SqlCommand(them, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaLMH", txtmalop.Text);
                    cmd.Parameters.AddWithValue("@NamHoc", txtnamhoc.Text);
                    cmd.Parameters.AddWithValue("@Hocki", txthocki.Text);
                    cmd.Parameters.AddWithValue("@Siso", txtsiso.Text);
                    SqlParameter p = new SqlParameter("@MaMucThu", cmbmucthu.SelectedValue.ToString());
                    cmd.Parameters.Add(p);
                    SqlParameter p1 = new SqlParameter("@MaLop", cmbmalop.SelectedValue.ToString());
                    cmd.Parameters.Add(p1);
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
                    connect();
                    string them = "Sua_LopMH";
                    SqlCommand cmd = new SqlCommand(them, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaLMH", txtmalop.Text);
                    cmd.Parameters.AddWithValue("@NamHoc", txtnamhoc.Text);
                    cmd.Parameters.AddWithValue("@Hocki", txthocki.Text);
                    cmd.Parameters.AddWithValue("@Siso", txtsiso.Text);
                    SqlParameter p = new SqlParameter("@MaMucThu", cmbmucthu.SelectedValue.ToString());
                    cmd.Parameters.Add(p);
                    SqlParameter p1 = new SqlParameter("@MaLop", cmbmalop.SelectedValue.ToString());
                    cmd.Parameters.Add(p1);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("eror!!!" + ex.Message);
                }
            }
            else if (trangthai == "delete")
            {
                try
                {
                    connect();
                    string them = "Xoa_LopMH";
                    SqlCommand cmd = new SqlCommand(them, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaLMH", txtmalop.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("eror!!!" + ex.Message);
                }
            }
            load();
            Lock();
            txtnamhoc.Text = txthocki.Text = txtsiso.Text = "";
        }
    }
}

