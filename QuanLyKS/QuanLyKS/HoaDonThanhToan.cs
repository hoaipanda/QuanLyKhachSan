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
    public partial class HoaDonThanhToan : Form
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlConnection conn = new SqlConnection(@"Data Source=QUYETTHANG;Initial Catalog=QuanLKS;Integrated Security=True");
        public HoaDonThanhToan()
        {
            InitializeComponent();
        }
        private void hienthi()
        {
            conn.Open();
            string tk = "select HotenKH,CMND, ptp.NgayNhan ,SoPhong, TenLP, dvsd.Tongtien,kh.MaKH,p.MaPhong  from PhieuThuePhong ptp, Phong p, KhachHang kh,DichVu_SD dvsd, LoaiPhong lp where ptp.MaKH = kh.MaKH and ptp.MaPhong = p.MaPhong and p.MaLP = lp.MaLP and p.MaLP = dvsd.MaPhong ";
            da = new SqlDataAdapter(tk, conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            dg1.DataSource = tb;
            dg1.Columns[0].HeaderText = "Họ Tên Khách Hàng";
            dg1.Columns[0].Width = 150;
            dg1.Columns[1].HeaderText = "CMND";
            dg1.Columns[1].Width = 80;
            dg1.Columns[2].HeaderText = "Ngày Nhận phòng";
            dg1.Columns[2].Width = 130;
            dg1.Columns[3].HeaderText = "Phòng số";
            dg1.Columns[3].Width = 80;
            dg1.Columns[4].HeaderText = "Loại Phòng";
            dg1.Columns[4].Width = 80;
            dg1.Columns[5].HeaderText = "Tiền Dịch Vụ ";
            dg1.Columns[5].Width = 110;
            dg1.Columns[6].HeaderText = "Mã Khách Hàng";
            dg1.Columns[6].Visible = true;
            dg1.Columns[7].HeaderText = "Mã Phòng";
            dg1.Columns[7].Visible = true;
            conn.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void dateNT_ValueChanged(object sender, EventArgs e)
        {

            string sql1 = "select distinct lp.GiaPhong*datediff(day,NgayNhan,'" + dateNT.Value + "') from KhachHang kh,PhieuThuePhong ptp,Phong p,LoaiPhong lp where kh.MaKH=ptp.MaKH and ptp.MaPhong=p.MaPhong and p.MaLP=lp.MaLP and HotenKH=N'" + txttenkhach.Text + "'";
            cmd = new SqlCommand(sql1, conn);
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                txtTien.Text = sdr[0].ToString();
            }
            conn.Close();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void txtMKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void HoaDonThanhToan_Load_1(object sender, EventArgs e)
        {
            hienthi();
        }

        private void bttongtien_Click_1(object sender, EventArgs e)
        {
            try
            {
                float tongtien;
                float tienphong;
                if (txtGG.Text == "")
                    tienphong = float.Parse(txtTien.Text);
                else
                    tienphong = float.Parse(txtTien.Text) - float.Parse(txtTien.Text) * float.Parse(txtGG.Text);
                tongtien = float.Parse(txtDV.Text) + tienphong;
                labTongTien.Text = tongtien.ToString();
            }
            catch
            {
                MessageBox.Show("click vao khach hang can thanh toan .");
            }

        }

        private void btThanh_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql1 = "insert into HoaDon(MaKH,MaNV,NgayLap,TongTien) values('" + txtMKH.Text + "','" + txtMNV.Text + "','" + datelapphieu.Value + "','" + labTongTien.Text + "') insert into ChitietHD values(@@identity,'" + txtmap.Text + "','" + txtGG.Text + "','" + dateNN.Value + "','" + dateNT.Value + "','" + labTongTien.Text + "')";
                cmd = new SqlCommand(sql1, conn);
                da = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thành công .", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setnull();
            }
            catch
            {
                MessageBox.Show("Không thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void txttenkhach_TextChanged(object sender, EventArgs e)
        {
        }
        private void setnull()
        {
            txttenkhach.Clear();
            txtCMND.Clear();
            txtSP.Clear();
            txtMNV.Clear();
            txtmap.Clear();
            txtGG.Clear();
            txtLP.Clear();
            txtDV.Clear();
            txtTien.Clear();
        }

        private void dg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int t = dg1.CurrentRow.Index;
            txttenkhach.Text = dg1.Rows[t].Cells[0].Value.ToString();
            txtCMND.Text = dg1.Rows[t].Cells[1].Value.ToString();
            dateNN.Value = (DateTime)dg1.Rows[t].Cells[2].Value;
            txtSP.Text = dg1.Rows[t].Cells[3].Value.ToString();
            txtLP.Text = dg1.Rows[t].Cells[4].Value.ToString();
            txtDV.Text = dg1.Rows[t].Cells[5].Value.ToString();
            txtMKH.Text = dg1.Rows[t].Cells[6].Value.ToString();
            txtmap.Text = dg1.Rows[t].Cells[7].Value.ToString();

            string sql1 = "select distinct lp.GiaPhong*datediff(day,NgayNhan,getdate()) from KhachHang kh,PhieuThuePhong ptp,Phong p,LoaiPhong lp where kh.MaKH=ptp.MaKH and ptp.MaPhong=p.MaPhong and p.MaLP=lp.MaLP and HotenKH=N'" + dg1.Rows[t].Cells[0].Value.ToString() + "'";
            cmd = new SqlCommand(sql1, conn);
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                txtTien.Text = sdr[0].ToString();
                conn.Close();
            }
            conn.Close();


        }
    }
}
