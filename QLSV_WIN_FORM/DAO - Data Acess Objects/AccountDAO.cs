using QLSV_WIN_FORM.DTO___Data_Transfer_Objects;
using QLSVNHOM.DTO___Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLSVNHOM.DAO___Data_Acess_Objects
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); 
                return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }
        private AccountDAO() { }

        public bool LogIn(string username, string password)
        {

            //string sql = "SELECT * FROM ACCOUNT WHERE USERNAME = N'" + username + "' AND PASSWORD = N'" + password + "' ";
            //DataTable result = DataProvider.Instance.ExecuteQuery(sql); 
            string sql = "EXEC USP_LOGIN @USERNAME , @PASSWORD";
            DataTable result = DataProvider.Instance.ExecuteQuery(sql, new object[] { username, password });
            return result.Rows.Count > 0;
        }
        public List<AccountDTO> getListAccount()
        {
            List<AccountDTO> lvAccount = new List<AccountDTO>();
            string sql = "EXEC USP_SEL_ACCOUNT";
            DataTable result = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in result.Rows)
            {
                AccountDTO account = new AccountDTO(item);
                lvAccount.Add(account);
            }
            return lvAccount;
        }
    }
}
