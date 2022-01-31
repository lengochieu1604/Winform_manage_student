using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QLSVNHOM.DTO___Data_Transfer_Objects
{
    public class DataProvider { 

        private static DataProvider instance; //Ctrl R E
        public static DataProvider Instance {
            get { 
                if (instance == null) instance = new DataProvider();
                return DataProvider.instance;
            }
            private set { DataProvider.instance = value; }
        }
        private DataProvider() { }

        private string connectionString = "Data Source=DESKTOP-LN3LKHN\\MASTER;Initial Catalog=QLSVNHOM;Persist Security Info=True;User ID=SA;Password='123456'";
        public DataTable ExecuteQuery(string sql, object[] parameter = null)
        { 

            DataTable data = new DataTable();
            //Dùng using để connection được giải phóng dù có lỗi bất kỳ xảy ra
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //1 MO ket noi
                connection.Open();

                //2 Tạo cmd để execute và biết execute trên connection nào
                SqlCommand cmd = new SqlCommand(sql, connection);

                if (parameter != null)
                {
                    string[] listParameter = sql.Split(' '); 
                    int i=0;
                    foreach(string item in listParameter)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                //3 
                //Đổ dữ liệu ra datatable - Trung gian để lấy dữ liệu
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                connection.Close();
                return data;
            }
        }
        public int ExecuteNonQuery(string sql, object[] parameter = null)
        {
            int data = 0; //Số dòng thực thi thành công
            //Dùng using để connection được giải phóng dù có lỗi bất kỳ xảy ra
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                //Tạo cmd để execute và biết execute trên connection nào
                SqlCommand cmd = new SqlCommand(sql, connection);

                if (parameter != null)
                {
                    string[] listParameter = sql.Split(' ');
                    int i = 0;
                    foreach (string item in listParameter)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                //Đổ dữ liệu ra datatable - Trung gian để lấy dữ liệu
                data = cmd.ExecuteNonQuery();
                connection.Close();
                return data;
            }
        }
        public object ExecuteScalarQuery(string sql, object[] parameter = null)
        {
            object data = 0; //Ô đầu tiên của lệnh truy vấn
            //Dùng using để connection được giải phóng dù có lỗi bất kỳ xảy ra
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                //Tạo cmd để execute và biết execute trên connection nào
                SqlCommand cmd = new SqlCommand(sql, connection);

                if (parameter != null)
                {
                    string[] listParameter = sql.Split(' ');
                    int i = 0;
                    foreach (string item in listParameter)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                //Đổ dữ liệu ra datatable - Trung gian để lấy dữ liệu
                data = cmd.ExecuteScalar();
                connection.Close();
                return data;
            }
        }
            }
}
