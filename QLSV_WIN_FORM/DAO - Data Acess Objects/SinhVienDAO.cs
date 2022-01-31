using QLSVNHOM.DTO___Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace QLSVNHOM.DAO___Data_Acess_Objects
{
    public class SinhVienDAO
    { 
        private static SinhVienDAO instance;
        public static SinhVienDAO Instance
        {
            get
            {
                if (instance == null) instance = new SinhVienDAO();
                return SinhVienDAO.instance;
            }
            private set
            {
                SinhVienDAO.instance = value;
            }
        }
        public SinhVienDAO() { }
        public SinhVienDAO(string username)
        {
            this.Username = username;
        }
        public string Username { get; set; }
         
        public DataTable GetListStudent()
        { 
            string query = "EXEC SP_SEL_PUBLIC_SINHVIEN_LIST";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }
        public DataTable SearchStudent(string name)
        {
            string query = "EXEC SP_SEARCH_PUBLIC_SINHVIEN_LIST @HOTEN";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { name });
            return dataTable;
        }
        public bool InsertSinhVien(string masv, string hoten, string ngaysinh, string diachi, string malop, string tendn, string matkhau)
        {
            string query = "EXEC SP_INSERT_PUBLIC_SINHVIEN @MASV , @HOTEN , @NGAYSINH , @DIACHI , @MALOP , @TENDN , @MATKHAU";
            int dataTable = DataProvider.Instance.ExecuteNonQuery(query, new object[] {masv, hoten, ngaysinh, diachi, malop, tendn, matkhau});
            return dataTable > 0;
        }
        public string DecenUpdateSinhVien(string masv)
        {
            string query = "EXEC SP_DECEN_UPDATE_PUBLIC_SINHVIEN_LIST @MASV";
            string dataTable = (string)DataProvider.Instance.ExecuteScalarQuery(query, new object[] { masv });
            return dataTable;
        }
        public bool UpdateSinhVien(string masv, string hoten, string ngaysinh, string diachi, string malop, string tendn, string matkhau)
        {
            string query = "EXEC SP_UPDATE_PUBLIC_SINHVIEN_LIST @MASV , @HOTEN , @NGAYSINH , @DIACHI , @MALOP , @TENDN , @MATKHAU";
            int dataTable = DataProvider.Instance.ExecuteNonQuery(query, new object[] { masv, hoten, ngaysinh, diachi, malop, tendn, matkhau });
            return dataTable > 0;
        }
        public bool DeleteSinhVien(string masv)
        {
            string query = "EXEC SP_DELETE_PUBLIC_SINHVIEN_LIST @MASV";
            int dataTable = DataProvider.Instance.ExecuteNonQuery(query, new object[] { masv });
            return dataTable > 0;
        }
    }
}
