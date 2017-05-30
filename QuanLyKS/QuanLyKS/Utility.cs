using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QuanLyKS
{
    class Utility
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
      //  DataTable dt = new DataTable();
        //public SqlConnection OpenDB()
        //{
        //    conn = new SqlConnection(@"Data Source=HOAITT-PC\HAOITT;Initial Catalog=QuanLyKS;Integrated Security=True");
        //    return conn;
        //}
        // hàm mở kết nối tới CSDL
        public static void OpenConnection()
        {
            string sql = @"Data Source=HOAITT-PC\HAOITT;Initial Catalog=QuanLyKS;Integrated Security=True";

                conn = new SqlConnection(sql);
                conn.Open();
        }
        // hàm đóng kết nối 
        public static void DisConnection()
        {
            //đóng kết nối 
            conn.Close();
            conn.Dispose();// ngắt kết nối 
            conn = null;
        }
        // tạo bảng để lưu csdl
        public static DataTable  getDataTable(string sql)
        {
            // tạo đối tượng trỏ tới dl trong database 
            cmd = new SqlCommand(sql,conn);
            // dtg để lưu dữ liệu lên database 
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            // tạo database để hiển thị dl
            DataTable table = new DataTable();
            da.Fill(table);
            da.Dispose();
            cmd.Dispose();
            return table;
        }
       
        //tọa hàm Excute để thao tác vs CSDL
        public static void Excute(string sql)
        {
            OpenConnection();
            cmd = new SqlCommand(sql, conn);
           
            //gọi hàm để có thể thực hiện thao tác Delete Insert Update
            cmd.ExecuteNonQuery();
            
        }
        //public static DataTable timkiem(string sql, string chuoitimkiem)
        //{
        //    //OpenConnection();
        //    //cmd = new SqlCommand(sql, conn);
        //    //cmd.CommandType = CommandType.StoredProcedure;
        //    //da = new SqlDataAdapter(cmd);
        //    //DataTable dt = new DataTable();
        //    //da.Fill(dt);
        //    //DisConnection();
        //    //return dt;
             

        //}

    }
}
