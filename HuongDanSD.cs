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
    public partial class HuongDanSD : Form
    {
        public HuongDanSD()
        {
            InitializeComponent();
        }

        private void hDSDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = "E:\\HDSD\\HDSD.mhtml";
            wbw_huongdan.Url = new Uri(file);
        }

        private void quanLyPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = "E:\\HDSD\\Quan Ly Phong.mhtml";
            wbw_huongdan.Url = new Uri(file);
        }

        private void quanLyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = "E:\\HDSD\\Quan Ly Thue Phong.mhtml";
            wbw_huongdan.Url = new Uri(file);
        }

        private void quanLyDichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = "E:\\HDSD\\Quan Ly Dich Vu.mhtml";
            wbw_huongdan.Url = new Uri(file);
        }

        private void quanLyThietBiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = "E:\\HDSD\\Quan Ly Thiet Bi.mhtml";
            wbw_huongdan.Url = new Uri(file);
        }

        private void quanLyKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = "E:\\HDSD\\Nhan Vien.mhtml";
            wbw_huongdan.Url = new Uri(file);
        }

        private void quanLyNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = "E:\\HDSD\\Quan Ly Nhan vien.mhtml";
            wbw_huongdan.Url = new Uri(file);
        }

        private void hoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = "E:\\HDSD\\Hoa don.mhtml";
            wbw_huongdan.Url = new Uri(file);
        }
    }
}
