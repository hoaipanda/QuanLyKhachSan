using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLyKS
{
    public partial class QuanLyNguoiDung : Form
    {
        public void showData(string sql)
        {
            Utility.OpenConnection();
            var vv = Utility.getDataTable("Select * from NhanVien");
            vv.Columns["MaNV"].ColumnName = "Mã NV";
            vv.Columns["HotenNV"].ColumnName = "Họ Tên";
            vv.Columns["CMND"].ColumnName = "CMND";
            vv.Columns["Ngaysinh"].ColumnName = "Ngày Sinh";
            vv.Columns["Diachi"].ColumnName = "Địa Chỉ ";
            vv.Columns["Chucvu"].ColumnName = "Chức Vụ";
            vv.Columns["Gioitinh"].ColumnName = "Giới Tính";
            dtgQLNhanvien.DataSource =vv;
            dtgQLNhanvien.Columns["Matkhau"].Visible=false;
            dtgQLNhanvien.Columns["Họ Tên"].Width = 150;

        }
       
        public void clear()
        {
            txtMaNV.Clear();
            txtHotenNV.Clear();                                                              
            txtPass.Clear();
            txtDiachiNV.Clear();
            txtChucVu.Clear();
            txtCMNDNV.Clear();
            txtSDTNV.Clear();
            txtTimkiem.Clear();
            dateNgaysinh.Value = DateTime.Now;
            //cmbGioitinh.SelectedIndex = 0;
            txtMaNV.Focus();
          
        }
        public string  Chuan_hoa_chuoi(string a)
        {
            string s = "";
            if(a=="")
            {

            }else
            {
                a = a.Trim().ToLower();
                while(a.IndexOf("\t")>=0)
                {
                    a = a.Replace("\t", " ");
                }
                while(a.IndexOf(" ")>=0)
                {
                    a = a.Replace(" ", " ");
                }
                string[] arr = a.Split(' ');
                
                foreach(string item in arr)
                {
                    s += item.Substring(0, 1).ToLower() + item.Substring(1).ToLower() + " ";
                }
            }
            return s;
        }
        public bool Kiem_tra_chuoi(string a,string b,string c,string d,string e,string f,string g)
        {
            if(txtChucVu.Text==" " || txtCMNDNV.Text==" " || txtDiachiNV.Text==" " ||txtHotenNV.Text==" " ||txtSDTNV.Text==" " ||dateNgaysinh.Text ==" " || cmbGioitinh.Text==" " || txtPass.Text==" " )
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ dữ liệu!");
                txtHotenNV.Focus();
                return true;
            }
            return true;
        }
     
        public QuanLyNguoiDung()
        {
            InitializeComponent();
            this.showData(@"Select * from NhanVien");
        
        }

        private void QuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
         //   bindding();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();

        }

        private void txtHotenNV_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
                txtPass.Focus();

        }
        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtCMNDNV.Focus();
        }

        private void txtCMNDNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dateNgaysinh.Focus();
        }

        private void dateNgaysinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtSDTNV.Focus();
        }

        private void txtSDTNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtDiachiNV.Focus();
        }

        private void txtDiachiNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtChucVu.Focus();
        }

        private void txtChucVu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmbGioitinh.Focus();
        }
        private void bntThemNV_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            try
            {
                int chiso = dtgQLNhanvien.CurrentRow.Index;
                string sql = "Delete from NhanVien where MaNV = '" + dtgQLNhanvien[0, chiso].Value.ToString() + "'";
                Utility.Excute(sql);
                this.showData("Select * from NhanVien");
                this.clear();
                MessageBox.Show("Xóa thành công!");
            }
            catch
            {
                MessageBox.Show("Xóa không thành công!");
            }

        }

        private void dtgQLNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bntSuaNV_Click(object sender, EventArgs e)
        {
            try
            {
                int chiso = dtgQLNhanvien.CurrentRow.Index;
                string a = txtHotenNV.Text;
                string b = txtPass.Text;
                string c = txtCMNDNV.Text;
                DateTime d = dateNgaysinh.Value;
                string f = txtSDTNV.Text;
                string g = txtDiachiNV.Text;
                string h = txtChucVu.Text;
                string k = cmbGioitinh.Text;

                string sql = "Update  NhanVien set HotenNV = N'" + a + "',CMND = N'" +c + "',Ngaysinh = N'" + d+ "',Gioitinh = N'" + k + "',SDT = N'" + f + "',Diachi = N'" + g + "',Chucvu = N'" + h + "', Matkhau = N'" + b + "' where MaNV ='" + dtgQLNhanvien[0, chiso].Value.ToString() + "' ";
                Utility.Excute(sql);
                this.showData("Select * from NhanVien");
                MessageBox.Show("Sửa thành công!");
            }catch
            {
                MessageBox.Show("Sửa không thành công!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string a = txtHotenNV.Text;
                string b = txtPass.Text;
                string c = txtCMNDNV.Text;
                DateTime d = dateNgaysinh.Value;
                string f = txtSDTNV.Text;
                string g = txtDiachiNV.Text;
                string h = txtChucVu.Text;
                string k = cmbGioitinh.Text;

                string sql = "insert into NhanVien values(N'" + a + "',N'" + c + "',N'" + d + "',N'" + k + "',N'" + f + "',N'" + g + "',N'" + h + "',N'" + b + "')";
                    Utility.Excute(sql);
                    this.showData("Select * from NhanVien");
                    this.clear();
                    MessageBox.Show("Thêm thành công!");

            }
            catch
            {
                MessageBox.Show("Không thêm được!");
            }
        }

        private void dtgQLNhanvien_SelectionChanged(object sender, EventArgs e)
        {
            int chiso = dtgQLNhanvien.CurrentRow.Index;
            txtMaNV.Text = dtgQLNhanvien[0, chiso].Value.ToString();
            txtHotenNV.Text = dtgQLNhanvien[1, chiso].Value.ToString();
            txtPass.Text = dtgQLNhanvien[8, chiso].Value.ToString();
            txtCMNDNV.Text = dtgQLNhanvien[2, chiso].Value.ToString();
            dateNgaysinh.Text = dtgQLNhanvien[3, chiso].Value.ToString();
            txtSDTNV.Text = dtgQLNhanvien[5, chiso].Value.ToString();
            txtDiachiNV.Text = dtgQLNhanvien[6, chiso].Value.ToString();
            txtChucVu.Text = dtgQLNhanvien[7, chiso].Value.ToString();
            cmbGioitinh.Text = dtgQLNhanvien[4, chiso].Value.ToString();
            txtMaNV.Enabled = false;  
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
           // this.showData("Select * From NhanVien where HotenNV like '" + txtHotenNV.Text.Trim() + "'");
            Utility.OpenConnection();
            var vv = Utility.getDataTable("Select * From NhanVien where HotenNV like N'%"+txtHotenNV.Text.Trim()+"%'");
            vv.Columns["MaNV"].ColumnName = "Mã NV";
            vv.Columns["HotenNV"].ColumnName = "Họ Tên";
            vv.Columns["CMND"].ColumnName = "CMND";
            vv.Columns["Ngaysinh"].ColumnName = "Ngày Sinh";
            vv.Columns["Diachi"].ColumnName = "Địa Chỉ ";
            vv.Columns["Chucvu"].ColumnName = "Chức Vụ";
            vv.Columns["Gioitinh"].ColumnName = "Giới Tính";
            dtgQLNhanvien.DataSource = vv;
            dtgQLNhanvien.Columns["Matkhau"].Visible = false;
            dtgQLNhanvien.Columns["Họ Tên"].Width = 150;
        }

      
       
        



    }
}
