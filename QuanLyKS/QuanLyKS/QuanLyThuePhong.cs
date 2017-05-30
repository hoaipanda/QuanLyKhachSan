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

namespace QuanLyKS
{
    public partial class QuanLyThuePhong : Form
    {
        public void showData(string sql)
        {
            Utility.OpenConnection();
            var vv = Utility.getDataTable(@"select MaPhieu,Sophong,HotenKH,CMND,Ngaynhan
                                            from PhieuThuePhong ptp, Phong p, KhachHang kh
                                            where ptp.MaKH = kh.MaKH and ptp.MaPhong = p.MaPhong");
            vv.Columns["MaPhieu"].ColumnName = "MÃ PHIẾU";
            vv.Columns["Sophong"].ColumnName = "SỐ PHÒNG";
            vv.Columns["HotenKH"].ColumnName = "HỌ TÊN KH";
            vv.Columns["CMND"].ColumnName = "CMND";
            vv.Columns["Ngaynhan"].ColumnName = "NGÀY NHẬN";
            dtQLthuephong.DataSource = vv;
            dtQLthuephong.Columns["HỌ TÊN KH"].Width = 170;
            dtQLthuephong.Columns["SỐ PHÒNG"].Width = 150;
            dtQLthuephong.Columns["NGÀY NHẬN"].Width = 170;
            dtQLthuephong.Columns["CMND"].Width = 155;
            dtQLthuephong.Columns["MÃ PHIẾU"].Width = 150;
        }
        public void clear()
        {
            txtCMNDKH.Clear();
            txtDiachi.Clear();
            txtHotenKH1.Clear();
            txtSDT.Clear();
        }
        public int LayMaPhong(string sophong)
        {
            int maphong = 0;
            Utility.OpenConnection();
            SqlCommand cmd=new SqlCommand();
            cmd.Connection = Utility.conn;
            cmd.CommandText = "select * from Phong where Sophong = @sophong";
            cmd.Parameters.AddWithValue("@sophong", sophong);
          

            using(var reader = cmd.ExecuteReader())
            {
                 while (reader.Read())
                 {
                     var tmp = reader["MaPhong"];
                     if(tmp != DBNull.Value)
                     {
                         maphong= int.Parse(reader["MaPhong"].ToString());
                     }
                 }
            }
            return maphong;
        }
        public int LayMaKH(string cmnd)
        {
            int makh = 0;
            Utility.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Utility.conn;
            cmd.CommandText = "select * from KhachHang where CMND = @cmnd";
            cmd.Parameters.AddWithValue("@cmnd", cmnd);


            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var tmp = reader["CMND"];
                    if (tmp != DBNull.Value)
                    {
                        makh = int.Parse(reader["CMND"].ToString());
                    }
                }
            }
            return makh;
        }
        public QuanLyThuePhong()
        {
            InitializeComponent();
            this.showData(@"select MaPhieu,Sophong,HotenKH,CMND,Ngaynhan
                            from PhieuThuePhong ptp, Phong p, KhachHang kh
                            where ptp.MaKH = kh.MaKH and ptp.MaPhong = p.MaPhong");
        }

        private void QuanLyThuePhong_Load(object sender, EventArgs e)
        {        
           
        }

        private void bntTaophieu_Click(object sender, EventArgs e)
        {
            int a = LayMaKH("3546566");
            int b = LayMaPhong("201");
//            try
//            {
                
//                int a = LayMaKH(txtCMNDPh.Text);
//                int b = LayMaPhong(txtSophong.Text);
//                DateTime c = DateNgaynhan.Value ;
//                string sql = "insert into KhachHang values('" + a + "','" + b + "',N'" + c + "')";
//                Utility.Excute(sql);
//                this.showData(@"select MaPhieu,Sophong,HotenKH,CMND,Ngaynhan
//                            from PhieuThuePhong ptp, Phong p, KhachHang kh
//                            where ptp.MaKH = kh.MaKH and ptp.MaPhong = p.MaPhong");
//                this.clear();
//                MessageBox.Show("Thêm thành công!");
//            }
//            catch
//            {
//                MessageBox.Show("Không thêm được!");
//            }
        }

        private void bntThemKH_Click(object sender, EventArgs e)
        {
            try {
                string a = txtHotenKH1.Text;
                string b = txtCMNDKH.Text;
                string c = txtSDT.Text;
                string d = txtDiachi.Text;
                string h = cmbGioitinh.Text;
                string sql = "insert into KhachHang values(N'" + a + "',N'" + b + "',N'" + c + "',N'" + d + "',N'" + h + "')";
                Utility.Excute(sql);
                this.showData(@"select MaPhieu,Sophong,HotenKH,CMND,Ngaynhan
                            from PhieuThuePhong ptp, Phong p, KhachHang kh
                            where ptp.MaKH = kh.MaKH and ptp.MaPhong = p.MaPhong");
                this.clear();
            }    catch
            {
                MessageBox.Show("Không thêm được!");
            }
               
                
           
        }

        private void txtHotenKH1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtCMNDKH.Focus();
        }

        private void txtCMNDKH_KeyDown(object sender, KeyEventArgs e)
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

        private void dtQLthuephong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void bntclear_Click(object sender, EventArgs e)
        {
            txtHotenKH.Clear();
            txtCMNDPh.Clear();
            txtSophong.Clear();
           
        }

        private void dtQLthuephong_SelectionChanged(object sender, EventArgs e)
        {
            int chiso = dtQLthuephong.CurrentRow.Index;
            txtHotenKH.Text = dtQLthuephong[2, chiso].Value.ToString();
            txtCMNDPh.Text = dtQLthuephong[3, chiso].Value.ToString();
            txtSophong.Text = dtQLthuephong[1, chiso].Value.ToString();
            DateNgaynhan.Text = dtQLthuephong[4, chiso].Value.ToString();
        }



    }
}
