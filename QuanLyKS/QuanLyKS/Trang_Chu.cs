using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKS
{
    public partial class Trang_Chu : Form
    {
        public Trang_Chu()
        {
            InitializeComponent();
        }

        private void Trang_Chu_Load(object sender, EventArgs e)
        {

        }

        private void pHÒNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyPhong qlp = new QuanLyPhong();
            qlp.Show();
        }

        private void kHÁCHHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang qlkh = new QuanLyKhachHang();
            qlkh.Show();
        }

        private void dỊCHVỤToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDichVu qldv = new QuanLyDichVu();
            qldv.Show();
        }

        private void tHIẾTBỊToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyThietBi qltb = new QuanLyThietBi();
            qltb.Show();
        }

        private void tHUÊPHÒNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyThuePhong qltp = new QuanLyThuePhong();
            qltp.Show();
        }

        private void nHÂNVIÊNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QuanLyNguoiDung qlnd = new QuanLyNguoiDung();
            qlnd.Show();
        }

        private void hÓAĐƠNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDonThanhToan hd = new HoaDonThanhToan();
            hd.Show();
        }

        private void tRỢGIÚPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDanSD hdsd = new HuongDanSD();
            hdsd.Show();
        }





    }
}
