using QLSV_WIN_FORM.VIEW;
using QLSVNHOM.DAO___Data_Acess_Objects;
using QLSVNHOM.VIEW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSVNHOM
{
    public partial class frmLogin : Form
    {  
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        { 
            string username = txtUsername.Text;
            string password = txtPassword.Text;
              
            StringBuilder hash = new StringBuilder(); 
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(password));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            password = "0x" + hash.ToString();
            if (LogIn(username, password))
            { 
                this.Hide();
                string version = "";
                if (radioButtonVersion1.Checked)
                {
                    frmMain f = new frmMain();
                    f.Username = txtUsername.Text;
                    SinhVienDAO sinhVienDAO = new SinhVienDAO(txtUsername.Text);
                    f.ShowDialog();
                }
                if (radioButtonVersion2.Checked)
                {
                    frmHomePage f = new frmHomePage(); 
                    f.ShowDialog();
                }
                if (radioButtonVersion3.Checked)
                {
                    frmDashBoard f = new frmDashBoard();
                    f.ShowDialog();
                }
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên hoặc mật khẩu!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
        }
        bool LogIn(string username, string password)
        {
            return AccountDAO.Instance.LogIn(username, password);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hay không", "Thông báo!!!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

         
    }
}
