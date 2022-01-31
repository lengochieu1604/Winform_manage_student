using QLSVNHOM.DTO___Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace QLSVNHOM.DAO___Data_Acess_Objects
{
    public class HocPhanDAO
    { 
        private static HocPhanDAO instance;
        public static HocPhanDAO Instance
        {
            get
            {
                if (instance == null) instance = new HocPhanDAO();
                return HocPhanDAO.instance;
            }
            private set
            {
                HocPhanDAO.instance = value;
            }
        }
        public HocPhanDAO() { }  
         
        public DataTable GetModuleList()
        { 
            string query = "EXEC SP_SELECT_HOCPHAN";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }
        public bool InsertModule(string mahp, string tenhp, string sotc)
        {
            string query = "EXEC SP_INSERT_HOCPHAN @MAHP , @TENHP , @SOTC";
            int dataTable = DataProvider.Instance.ExecuteNonQuery(query, new object[] {mahp, tenhp, sotc});
            return dataTable > 0;
        }
        //public string DecenUpdateModule(string masv)
        //{
        //    string query = "EXEC SP_DECEN_UPDATE_PUBLIC_SINHVIEN_LIST @MASV";
        //    string dataTable = (string)DataProvider.Instance.ExecuteScalarQuery(query, new object[] { masv });
        //    return dataTable;
        //}
        public bool UpdateModule(string mahp, string tenhp, string sotc)
        {
            string query = "EXEC SP_UPDATE_HOCPHAN @MAHP , @TENHP , @SOTC";
            int dataTable = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahp, tenhp, sotc });
            return dataTable > 0;
        }
        public bool DeleteModule(string mahp)
        {
            string query = "EXEC SP_DELETE_HOCPHAN @MAHP";
            int dataTable = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahp });
            return dataTable > 0;
        }
        public DataTable SearchModule(string tenhp)
        {
            string query = "EXEC SP_SEARCH_HOCPHAN @TENHP";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { tenhp });
            return dataTable;
        }
    }
}
