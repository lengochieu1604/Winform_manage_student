using MaterialSkin;
using QLSV_WIN_FORM.DTO___Data_Transfer_Objects;
using QLSVNHOM.DAO___Data_Acess_Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_WIN_FORM.VIEW
{
    public partial class frmAccount : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        public frmAccount()
        {
            InitializeComponent();
            TemplateSkinManager();
            ShowAccount();
        }
        void TemplateSkinManager()
        {
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green900,
            Primary.Green900, Accent.LightBlue200, TextShade.WHITE);
        }
        void ShowAccount()
        {
            TemplateSkinManager();
            List<AccountDTO> lvAccount = AccountDAO.Instance.getListAccount();
            foreach (AccountDTO item in lvAccount)
            {
                ListViewItem listViewAccount = new ListViewItem(item.UserName.ToString());
                listViewAccount.SubItems.Add(item.DisplayName.ToString());
                listViewAccount.SubItems.Add(item.Email.ToString());
                listViewAccount.SubItems.Add(item.Password.ToString());
                materialListViewAccount.Items.Add(listViewAccount);
            }
        }
    }
}
