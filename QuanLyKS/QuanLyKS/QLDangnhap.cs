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
    public partial class QLDangnhap : Form
    {
      //  private SqlConnection conn;
        private DataTable dt = new DataTable("NhanVien");
        private SqlDataAdapter da = new SqlDataAdapter();

        public QLDangnhap()
        {
            InitializeComponent();
        }

      //  String conStr = @"Data Source=HOAITT-PC\HAOITT;Initial Catalog=QuanLyKS;Integrated Security=True";
        
       // SqlConnection conn;
     //   SqlCommand comm;
        Trang_Chu tc = new Trang_Chu();
        private void TrangChu_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
                Utility.OpenConnection();
          //      var vv = Utility.getDataTable("Select HotenNV,password from NhanVien where HotenNV = @ten and password = @pass");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Utility.conn;
          //      cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"Select HotenNV,Matkhau from NhanVien where HotenNV = @ten and Matkhau = @pass";
                cmd.Parameters.Add("@ten",SqlDbType.NVarChar,50).Value = txtUsername.Text        ;
                cmd.Parameters.Add("@pass",SqlDbType.NVarChar,25).Value = txtPass.Text;
                da.SelectCommand = cmd;
                da.Fill(dt);
                if(dt.Rows.Count>0){
                    tc.Show();
                    Hide();
                }
                else {
                    MessageBox.Show("Đăng nhập thất bại,Bạn có muốn đăng nhập lại không?","ĐĂNG NHẬP",MessageBoxButtons.YesNo);
                }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPass.Focus();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.Focus();
        }
      
    }
}
