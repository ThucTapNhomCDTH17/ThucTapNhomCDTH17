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

    public partial class frmBienLai : Form
    {
        string chuoiketnoi = @"Data Source=DESKTOP-U9S8HN6\SQLEXPRESS;Initial Catalog=QLThuHocPhiSV1;Integrated Security=True";
        string trangthai = "load";
        public static SqlConnection con;
        public static SqlDataAdapter da;
        public static SqlCommand cmd;
        public frmBienLai()
        {
            InitializeComponent();
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
            dataGridView1.DataSource = gettable("select * from BienLaiTienHoc");

        }
        //
        private void Lock()
        {
            txtngaythu.ReadOnly = txtsobl.ReadOnly = txtnguoithu.ReadOnly = true;
            btnluu.Enabled = false;
        }
        //
        private void unlock()
        {
            txtngaythu.ReadOnly = txtsobl.ReadOnly = txtnguoithu.ReadOnly = false;
            btnluu.Enabled = true;
        }

        private void frmBienLai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuHocPhiSV1DataSet14.ChiTietBienLai' table. You can move, or remove it, as needed.
            this.chiTietBienLaiTableAdapter.Fill(this.qLThuHocPhiSV1DataSet14.ChiTietBienLai);
            // TODO: This line of code loads data into the 'qLThuHocPhiSV1DataSet13.BienLaiTienHoc' table. You can move, or remove it, as needed.
            this.bienLaiTienHocTableAdapter.Fill(this.qLThuHocPhiSV1DataSet13.BienLaiTienHoc);
            load();
            Lock();
            Show_cmbsobl("");
        }
        //
        private void Show_cmbsobl(string sobl)
        {
            connect();
            string sql = "select SoBienLai from BienLaiTienHoc";
            if (sobl != "")
            {
                sql = sql + "where MaLopHocphan= '" + sobl + "'";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbsobl.DataSource = dt;
            cmbsobl.ValueMember = "SoBienLai";
            cmbsobl.DisplayMember = "SoBienLai";
        }
        //


        private string matudong(string ma)
        {
            string matudong = "";
            int count = 0;
            count = dataGridView1.Rows.Count;
            int chuoiso = 0;
            if (count < 2)
            {
                matudong = "BL001";
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

        private void dataGridView1_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtsobl.Text = txtngaythu.Text = txtnguoithu.Text = "";
            unlock();
            txtsobl.Text = matudong("BL");
            trangthai = "add";

        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            unlock();
            trangthai = "edit";
            txtsobl.Text = txtngaythu.Text = txtnguoithu.Text = "";
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            unlock();
            trangthai = "delete";
            txtsobl.Text = txtngaythu.Text = txtnguoithu.Text = "";
        }

        private void cmbsobl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {

                connect();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sear_ctbl";
                command.Parameters.AddWithValue("@MaBL", cmbsobl.SelectedValue);
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

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (trangthai == "add")
            {
                try
                {
                    connect();
                    string them = "them_blth";
                    SqlCommand cmd = new SqlCommand(them, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SoBL", txtsobl.Text);
                    cmd.Parameters.AddWithValue("@Ngaythu", txtngaythu.Text);
                    cmd.Parameters.AddWithValue("@Nguoithu", txtnguoithu.Text);
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
                    string them = "sua_blth";
                    SqlCommand cmd = new SqlCommand(them, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SoBL", txtsobl.Text);
                    cmd.Parameters.AddWithValue("@Ngaythu", txtngaythu.Text);
                    cmd.Parameters.AddWithValue("@Nguoithu", txtnguoithu.Text);
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
                    string them = "xoa_blth";
                    SqlCommand cmd = new SqlCommand(them, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SoBL", txtsobl.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("eror!!!" + ex.Message);
                }
            }
            load();
            Lock();
            txtsobl.Text = txtngaythu.Text = txtnguoithu.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtsobl.DataBindings.Clear();
                txtsobl.DataBindings.Add("text", dataGridView1.DataSource, "SoBienLai");
                txtnguoithu.DataBindings.Clear();
                txtnguoithu.DataBindings.Add("text", dataGridView1.DataSource, "NguoiThu");
                txtngaythu.DataBindings.Clear();
                txtngaythu.DataBindings.Add("text", dataGridView1.DataSource, "NgayThu");
            }
            catch(Exception ex)
            {
                MessageBox.Show("eror!!" + ex.Message);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (exit == DialogResult.OK)
                Application.Exit();
        }
    }
}

