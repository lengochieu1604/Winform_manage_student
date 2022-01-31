using QLSVNHOM.DTO___Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace QLSVNHOM.DAO___Data_Acess_Objects
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null) instance = new NhanVienDAO();
                return NhanVienDAO.instance;
            }
            private set
            {
                NhanVienDAO.instance = value;
            }
        } 
        private NhanVienDAO() { }
        public DataTable GetListNhanVien()
        {
            string query = "SP_SEL_PUBLIC_NHANVIEN_LIST;";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }
        public bool InsertNhanVien(string manv, string hoten, string email, string luong, string tendn, string matkhau)
        { 
            string query = "EXEC SP_INS_PUBLIC_NHANVIEN @MANV , @HOTEN , @EMAIL , @LUONG , @TENDN , @MATKHAU";
            int dataTable = DataProvider.Instance.ExecuteNonQuery(query, new object[] { manv, hoten, email, luong, tendn, matkhau });
            return dataTable > 0;
        }
        public bool UpdateNhanVien(string manv, string hoten, string email, string luong, string tendn, string matkhau)
        {
            string query = "EXEC SP_UPDATE_PUBLIC_NHANVIEN_LIST @MANV , @HOTEN , @EMAIL , @LUONG , @TENDN , @MATKHAU"; 
            int dataTable = DataProvider.Instance.ExecuteNonQuery(query, new object[] { manv, hoten, email, luong, tendn, matkhau });
            return dataTable > 0;
        }
        public bool DeleteNhanVien(string manv)
        {
            string query = "EXEC SP_DEL_PUBLIC_NHANVIEN_LIST "+manv;
            int dataTable = DataProvider.Instance.ExecuteNonQuery(query);
            return dataTable > 0;
        }
        public DataTable SearchNhanVienByName(string name)
        {
            string query = "EXEC SP_SEARCH_PUBLIC_NHANVIEN_LIST @hoten";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { name });
            return dataTable;  
        }
    }
}
