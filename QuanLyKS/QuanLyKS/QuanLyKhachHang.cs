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
        public void showData()
        {
            Utility.OpenConnection();
            var vv = Utility.getDataTable("Select * from KhachHang");
            dtKhachhang.AutoGenerateColumns = false;
            dtKhachhang.DataSource = vv;
            dtKhachhang.Refresh();
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
            DataGridViewColumn cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "MAKH";
            cl.HeaderText = "MÃ";
            cl.Width = 90;
            dtKhachhang.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "HotenKH";
            cl.HeaderText = "HỌ TÊN";
            cl.Width = 130;
            dtKhachhang.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "Diachi";
            cl.HeaderText = "ĐỊA CHỈ";
            cl.Width = 140;
            dtKhachhang.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "SDT";
            cl.HeaderText = "SĐT";
            cl.Width = 100;
            dtKhachhang.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "Gioitinh";
            cl.HeaderText = "GIỚI TÍNH";
            cl.Width = 90;
            dtKhachhang.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "CMND";
            cl.HeaderText = "SỐ CMTND";
            cl.Width = 90;
            dtKhachhang.Columns.Add(cl);
            this.showData();
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
            txtCMND.Text = dtKhachhang[5, chiso].Value.ToString();
            txtSDT.Text = dtKhachhang[3, chiso].Value.ToString();
            txtDiachi.Text = dtKhachhang[2, chiso].Value.ToString();
            cmbGioitinh.Text = dtKhachhang[4, chiso].Value.ToString();
            txtMaKH.Enabled = false;
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int chiso = dtKhachhang.CurrentRow.Index;
                string sql = "Delete from KhachHang where MaKH = '" + dtKhachhang[0, chiso].Value.ToString() + "' ";
                Utility.Excute(sql);
                this.showData();
                MessageBox.Show("Xóa thành công!");
            }
            catch
            {
                MessageBox.Show("Không xóa được!");
            }
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            if (txtCMND.Text.Length>=10)
            {
                MessageBox.Show("Số CMTND không được dài quá 10 ký tự số !");
                return;
            }
            try
            {
                Convert.ToInt32(txtCMND.Text);
            }
            catch
            {
                MessageBox.Show("CMTND phải bào gồm các ký tự số 0-9 !");
                return;
            }
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
                this.showData();
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

        private void btn_find_Click(object sender, EventArgs e)
        {
            Utility.OpenConnection();
            DataTable vv;
            if (!string.IsNullOrWhiteSpace(txtTimkiem.Text))
            {
                vv = Utility.getDataTable("Select * from KhachHang where HotenKH like '%'+@khoatk+'%'", txtTimkiem.Text);
            }
            else vv = Utility.getDataTable("Select * from KhachHang");
            dtKhachhang.AutoGenerateColumns = false;
            dtKhachhang.DataSource = vv;
            dtKhachhang.Refresh();
        }

        private void txtTimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btn_find_Click(sender,e);
        }



    }
}
