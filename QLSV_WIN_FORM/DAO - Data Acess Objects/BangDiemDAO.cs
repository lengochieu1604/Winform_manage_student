using QLSVNHOM.DTO___Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace QLSVNHOM.DAO___Data_Acess_Objects
{
    public class BangDiemDAO
    {
        private static BangDiemDAO instance;

        public static BangDiemDAO Instance
        {
            get
            {
                if (instance == null) instance = new BangDiemDAO();
                return BangDiemDAO.instance;
            }
            private set
            {
                BangDiemDAO.instance = value;
            }
        }
        private BangDiemDAO() { }
        public DataTable GetListBangDiem()
        {
            string query = "EXEC SP_SELECT_BANGDIEM;";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }
        public bool InsertBangDiem(string masv, string mahp, string diemthi)
        {
            string query = "EXEC SP_INSERT_BANGDIEM @MASV , @MAHP , @DIEMTHI";
            int dataTable = DataProvider.Instance.ExecuteNonQuery(query, new object[] { masv, mahp, diemthi });
            return dataTable > 0;
        }
        public bool UpdateBangDiem(string masv, string mahp, string diemthi)
        {
            string query = "EXEC SP_UPDATE_BANGDIEM @MASV , @MAHP , @DIEMTHI";
            int dataTable = DataProvider.Instance.ExecuteNonQuery(query, new object[] { masv, mahp, diemthi });
            return dataTable > 0;
        }

        public bool DeleteBangDiem(string masv, string mahp)
        {
            string query = "EXEC SP_DELETE_BANGDIEM @MASV , @mahp";
            int dataTable = DataProvider.Instance.ExecuteNonQuery(query, new object[] { masv, mahp });
            return dataTable > 0;
        }
        public DataTable SearchBangDiem(string masv)
        {
            string query = "EXEC SP_SEARCH_BANGDIEM @masv";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { masv });
            return dataTable;
        }
    }
}
