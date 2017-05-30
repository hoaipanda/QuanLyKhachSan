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
    public partial class QuanLyKhachHang : Form
    {
        public void showData(string sql)
        {
            Utility.OpenConnection();
            var vv = Utility.getDataTable("Select * from KhachHang");
            vv.Columns["MAKH"].ColumnName = "Mã Khách Hàng";
            vv.Columns["HotenKH"].ColumnName = "Họ Tên ";
            vv.Columns["CMND"].ColumnName = "CMND";
            vv.Columns["SDT"].ColumnName = "SĐT";
            vv.Columns["Diachi"].ColumnName = "Địa Chỉ";
            vv.Columns["Gioitinh"].ColumnName = "Giới Tính";
            dtKhachhang.DataSource = vv;
            
        }
        public void clear()
        {
            txtMaKH.Clear();
            txtHotenKH.Clear();
            txtCMND.Clear();
            txtSDT.Clear();
            txtDiachi.Clear();
           
        }
        public QuanLyKhachHang()
        {
            InitializeComponent();
            this.showData("Select * from KhachHang");
        }

        private void txtHotenKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtCMND.Focus();
        }

        private void txtCMND_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtSDT.Focus();
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtDiachi.Focus();
        }

        private void txtDiachi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmbGioitinh.Focus();
        }

        private void dtKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = dtKhachhang.CurrentRow.Index;
            txtMaKH.Text = dtKhachhang[0, chiso].Value.ToString();
            txtHotenKH.Text = dtKhachhang[1, chiso].Value.ToString();
            txtCMND.Text = dtKhachhang[2, chiso].Value.ToString();
            txtSDT.Text = dtKhachhang[3, chiso].Value.ToString();
            txtDiachi.Text = dtKhachhang[4, chiso].Value.ToString();
            cmbGioitinh.Text = dtKhachhang[5, chiso].Value.ToString();
            txtMaKH.Enabled = false;
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int chiso = dtKhachhang.CurrentRow.Index;
                string sql = "Delete from KhachHang where MaKH = '" + dtKhachhang[0, chiso].Value.ToString() + "' ";
                Utility.Excute(sql);
                this.showData("Select * from KhachHang");
                MessageBox.Show("Xóa thành công!");
            }
            catch
            {
                MessageBox.Show("Không xóa được!");
            }
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            try
            {
                int chiso = dtKhachhang.CurrentRow.Index;
                string a = txtHotenKH.Text;
                string b = txtCMND.Text;
                string c = txtSDT.Text;
                string h = txtDiachi.Text;
                string g = cmbGioitinh.Text;
                string sql = @"Update KhachHang set HotenKH = N'" + a + "' ,  CMND = N'" + b + "' , SDT = N'" + c + "' ,Diachi = N'" + h + "' ,Gioitinh = N'" + g + "'  where  MaKH = '" + dtKhachhang[0, chiso].Value.ToString() + "'";
                Utility.Excute(sql);
                this.showData("Select * from KhachHang");
                this.clear();
                MessageBox.Show("Sửa thành công!");
            }

            catch
            {
                MessageBox.Show("Không sửa được!");
            }
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }



    }
}
