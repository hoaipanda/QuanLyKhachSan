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
    public partial class QuanLyThietBi : Form
    {
        public void showData(string sql)
        {
            Utility.OpenConnection();
            var vv = Utility.getDataTable("Select * from ThietBi");
            vv.Columns["MaTB"].ColumnName = "Mã Thiết Bị";
            vv.Columns["TenTB"].ColumnName = "Tên Thiết Bị";
            vv.Columns["Ghichu"].ColumnName = "Ghi Chú";
            dtThietBi.DataSource = vv;
            dtThietBi.Columns["Mã Thiết Bị"].Width = 100;
            dtThietBi.Columns["Tên Thiết Bị"].Width = 150;
            dtThietBi.Columns["Ghi Chú"].Width = 200;
        }
        public void clear()
        {
            txtTB.Clear();
            txtTenTB.Clear();
            txtGhichu.Clear();
        }
        public QuanLyThietBi()
        {
            InitializeComponent();
            this.showData("Select * from ThietBi");
        }

        private void bntSua_Click(object sender, EventArgs e)
        {

            try
            {
                int chiso = dtThietBi.CurrentRow.Index;
                string a = txtTenTB.Text;
                string b = txtGhichu.Text;
                string sql = "Update ThietBi set TenTB = N'" + a + "' ,  Ghichu = N'" + b + "'  where MaTB = '" + dtThietBi[0, chiso].Value.ToString() + "' ";
                Utility.Excute(sql);
                this.showData("Select * from ThietBi");
                this.clear();
                MessageBox.Show("Sửa thành công!");
            }

            catch
            {
                MessageBox.Show("Không sửa được!");
            }
        }

        private void dtThietBi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = dtThietBi.CurrentRow.Index;
            txtTB.Text = dtThietBi[0, chiso].Value.ToString();
            txtTenTB.Text = dtThietBi[1, chiso].Value.ToString();
            txtGhichu.Text = dtThietBi[2, chiso].Value.ToString();
            txtTB.Enabled = false;
        }

        private void bntThem_Click(object sender, EventArgs e)
        {

            try
            {
                string a = txtTenTB.Text;
                string b = txtGhichu.Text;
                string sql = "Insert into ThietBi values( N'" + a + "' , N'" + b + "' )";
                Utility.Excute(sql);
                this.showData("Select * from ThietBi");
                this.clear();
                MessageBox.Show("Thêm mới thành công!");
            }

            catch
            {
                MessageBox.Show("Không thêm mới được!");
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int chiso = dtThietBi.CurrentRow.Index;
                string sql = "Delete from ThietBi where MaTB = '" + dtThietBi[0, chiso].Value.ToString() + "' ";
                Utility.Excute(sql);
                this.showData("Select * from ThietBi");
                this.clear();
                MessageBox.Show("Xóa thành công!");
            }

            catch
            {
                MessageBox.Show("Không xóa được!");
            }
        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            this.clear();
        }
    }
}
