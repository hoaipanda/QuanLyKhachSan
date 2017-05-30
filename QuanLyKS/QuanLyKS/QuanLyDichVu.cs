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
    public partial class QuanLyDichVu : Form
    {
        public void showData(string sql)
        {
            Utility.OpenConnection();
            var vv = Utility.getDataTable("Select * from DichVu");
            vv.Columns["MaDV"].ColumnName = "Mã Dịch Vụ";
            vv.Columns["TenDV"].ColumnName = "Tên Dịch Vụ";
            vv.Columns["GiaDV"].ColumnName = "Giá";
            dtDV.DataSource = vv;

        }
        public void clear()
        {
            txtMaDV.Clear();
            txtTenDV.Clear();
            txtGiaDV.Clear();
        }
        public QuanLyDichVu()
        {
            InitializeComponent();
            this.showData("Select * from DichVu");
        }

        private void txtTenDV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtGiaDV.Focus();
        }

        private void dtDV_SelectionChanged(object sender, EventArgs e)
        {
            int chiso = dtDV.CurrentRow.Index;
            txtMaDV.Text = dtDV[0, chiso].Value.ToString();
            txtTenDV.Text = dtDV[1, chiso].Value.ToString();
            txtGiaDV.Text = dtDV[2, chiso].Value.ToString();
            txtMaDV.Enabled = false;
        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string a = txtTenDV.Text;
                float b = float.Parse(txtGiaDV.Text);
                string sql = "insert into DichVu values(N'" + a + "','" + b + "')";
                Utility.Excute(sql);
                this.showData("Select * from DichVu");
                this.clear();
                MessageBox.Show("Thêm mới thành công!");
            }
            catch
            {
                MessageBox.Show("Thêm mới thất bại!");
            }

        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            try
            {
                int chiso = dtDV.CurrentRow.Index;
                string a = txtTenDV.Text;
                float b = float.Parse(txtGiaDV.Text);
                string sql = "update DichVu set TenDV = N'" + a + "' , GiaDV = '" + b + "' where  MaDV = '" + dtDV[0, chiso].Value.ToString() + "' ";
                Utility.Excute(sql);
                this.showData("Select * from DichVu");
                this.clear();
                MessageBox.Show("Sửa thành công!");
            }
            catch
            {
                MessageBox.Show("Sửa không thành công!");
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int chiso = dtDV.CurrentRow.Index;
                string sql = "Delete from DichVu  where  MaDV = '" + dtDV[0, chiso].Value.ToString() + "' ";
                Utility.Excute(sql);
                this.showData("Select * from DichVu");
                this.clear();
                MessageBox.Show("Xóa thành công!");
            }
            catch
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();

        }






    }
}
