using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuHocPhiSVnhom11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhoa khoa = new frmKhoa();
            khoa.ShowDialog();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLop Lop = new frmLop();
            Lop.ShowDialog();
        }


    
      

        private void muToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMucthu mt = new frmMucthu();
            mt.ShowDialog();
        }

        private void mứcThuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonHoc mh = new frmMonHoc();
            mh.ShowDialog();
        }

        private void thôngTinChiTiếtSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSinhVien SV = new frmSinhVien();
            SV.ShowDialog();
        }

        private void đốiTượngMiễnGiảmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoituong dt = new frmDoituong();
            dt.ShowDialog();
        }

        private void biênLaiHọcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBienLai bl = new frmBienLai();
            bl.ShowDialog();
        }

        private void chiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCTBL ctbl = new frmCTBL();
            ctbl.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lớpMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LopMonHoc lmh = new LopMonHoc();
            lmh.ShowDialog();
        }
    }
}
