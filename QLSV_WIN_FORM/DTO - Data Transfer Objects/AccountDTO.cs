using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_WIN_FORM.DTO___Data_Transfer_Objects
{
    public class AccountDTO
    {
        private string userName;
        private string displayName;
        private string email;
        private string password; 
        public AccountDTO(string username, string displayName, string email, string password)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Email = email;
            this.Password = password; 
        }
        public AccountDTO(DataRow row)
        {
            this.UserName = row["manv"].ToString();
            this.DisplayName = row["hoten"].ToString();
            this.Email = row["email"].ToString();
            this.Password = row["matkhau"].ToString();
        }

        public string UserName { get { return userName; } set { userName = value; } }
        public string DisplayName { get { return displayName; } set { displayName = value; } }
        public string Email { get { return email; } set { email = value;} }
        public string Password { get { return password; } set { password = value; } }

    }
} 
