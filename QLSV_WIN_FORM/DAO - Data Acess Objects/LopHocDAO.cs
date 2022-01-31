using QLSVNHOM.DTO___Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace QLSVNHOM.DAO___Data_Acess_Objects
{
    public class LopHocDAO
    {
        private static LopHocDAO instance;
        public static LopHocDAO Instance
        {
            get
            {
                if (instance == null) instance = new LopHocDAO();
                return LopHocDAO.instance;
            }
            private set
            {
                LopHocDAO.instance = value;
            }
        }
        public LopHocDAO() { }
        public DataTable GetListClass()
        {
            string query = "SELECT * FROM LOP";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }
        public bool InsertClass(string malop, string tenlop, string manv)
        {
            string query = "INSERT INTO LOP(MALOP,TENLOP,MANV) VALUES ('"+malop+"', N'"+tenlop+"', '"+manv+"' )";
            int dataTable = DataProvider.Instance.ExecuteNonQuery(query);
            return dataTable > 0;
        }
        public bool UpdateClass(string malop, string tenlop, string manv)
        {
            //string query = string.Format("UPDATE LOP SET MALOP = N'{0}', TENLOP = N'{1}', MANV = {2} WHERE MALOP = {3}", malop, tenlop, manv, malop);   
            string query = "UPDATE LOP SET MALOP = '" + malop + "', TENLOP = N'" + tenlop + "', MANV = '" + manv + "' WHERE MALOP = '" + malop + "'";
            int dataTable = DataProvider.Instance.ExecuteNonQuery(query);
            return dataTable > 0;
        }
        public bool DeleteClass(string malop)
        {   
            string query = "DELETE FROM LOP WHERE MALOP = '"+malop+"'";
            int dataTable = DataProvider.Instance.ExecuteNonQuery(query);
            return dataTable > 0;
        }
        public DataTable SearchClass(string tenlop)
        {
            string query = "SELECT * FROM LOP WHERE [dbo].[utf8ConvertSQL](TENLOP) LIKE N'%'+[dbo].[utf8ConvertSQL](N'"+tenlop+"')+'%'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }
    }
}
