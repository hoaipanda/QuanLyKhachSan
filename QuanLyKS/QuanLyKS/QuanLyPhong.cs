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
    public partial class QuanLyPhong : Form
    {
        public void showData(string sql)
        {
            Utility.OpenConnection();
            var vv = Utility.getDataTable("Select * from Phong");
            vv.Columns["MaPhong"].ColumnName = "Mã Phòng";
            vv.Columns["SoPhong"].ColumnName = "Số Phòng";
            vv.Columns["MaLP"].ColumnName = "Mã Loại Phòng";
            vv.Columns["Trangthai"].ColumnName = "Trạng Thái ";
            dtPhong.DataSource = vv;
            dtPhong.Columns["Mã Phòng"].Width = 100;
            dtPhong.Columns["Số Phòng"].Width = 150;
            dtPhong.Columns["Mã Loại Phòng"].Width = 150;
          //  dtPhong.Columns["Trạng Thái"].Width = 100;
        }
        public void clear()
        {
            txtMaphong.Clear();
            txtSophong.Clear();
            txtMaLP.Clear();
            txtTrangthai.Clear();

        }
        public QuanLyPhong()
        {
            InitializeComponent();
            this.showData("Select * from Phong");

        }

        private void txtMaKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
               txtMaphong.Focus();
        }

        private void txtSophong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
               txtMaLP.Focus();
        }

        private void txtMaLP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
               txtTrangthai.Focus();
        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string a = txtSophong.Text;
                string b = txtMaLP.Text;
                string c = txtTrangthai.Text;
                string sql = "insert into Phong values(N'" + a + "',N'" + b + "',N'" + c + "')";
                Utility.Excute(sql);
                this.showData("Select * from Phong");
                this.clear();
                MessageBox.Show("Thêm mới thành công!");

            }  catch
            {
                MessageBox.Show("Thêm phòng mới thất bại!");
            }
        }

        private void dtPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = dtPhong.CurrentRow.Index;
            txtMaphong.Text = dtPhong[0, chiso].Value.ToString();
            txtSophong.Text = dtPhong[1, chiso].Value.ToString();
            txtMaLP.Text = dtPhong[2, chiso].Value.ToString();
            txtTrangthai.Text = dtPhong[3, chiso].Value.ToString();
            txtMaphong.Enabled = false;
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            try
            {
                int chiso = dtPhong.CurrentRow.Index;
                string a = txtSophong.Text;
                string b = txtMaLP.Text;
                string c = txtTrangthai.Text;
                string sql = "Update Phong set Sophong = N'" + a + "' ,  MaLP = N'" + b + "' , Trangthai = N'" + c + "'  where MaPhong = '" + dtPhong[0, chiso].Value.ToString() + "' ";
                Utility.Excute(sql);
                this.showData("Select * from Phong");
                this.clear();
                MessageBox.Show("Sửa thành công!");
            }
                
            catch
            {
                MessageBox.Show("Không sửa được!");
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int chiso = dtPhong.CurrentRow.Index;
                string sql = "Delete from Phong where MaPhong = '" + dtPhong[0, chiso].Value.ToString() + "' ";
                Utility.Excute(sql);
                this.showData("Select * from Phong");
                MessageBox.Show("Xóa thành công!");
            }
            catch
            {
                MessageBox.Show("Không xóa được!");
            }
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();

        }




    }
}
