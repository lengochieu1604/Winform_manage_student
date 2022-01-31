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

namespace QLSV_WIN_FORM.VIEW.DASHBOARD
{
    public partial class frmDBAccount : Form
    { 
        public string Username { get; set; }
        MaterialSkin.MaterialSkinManager materialSkinManager;
        BindingSource nhanVienList = new BindingSource();
        public frmDBAccount()
        {
            InitializeComponent();
            //ShowHomeList(); 

            //NHÂN VIÊN
            dataGridViewNhanVienList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNhanVienList.DataSource = nhanVienList;
            LoadNhanVienList();
            ShowNhanVienInfoDetai();
        }
        void LoadNhanVienList()
        {
            nhanVienList.DataSource = NhanVienDAO.Instance.GetListNhanVien();
        }
        void ShowNhanVienInfoDetai()
        {
            txtMaNVNhanVien.DataBindings.Add(new Binding("Text", dataGridViewNhanVienList.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
            txtHoVaTenNhanVien.DataBindings.Add(new Binding("Text", dataGridViewNhanVienList.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
            txtEmailNhanVien.DataBindings.Add(new Binding("Text", dataGridViewNhanVienList.DataSource, "email", true, DataSourceUpdateMode.Never));
            txtSalaryNhanVien.DataBindings.Add(new Binding("Text", dataGridViewNhanVienList.DataSource, "lUONG", true, DataSourceUpdateMode.Never));
            txtDoanhNghiepNhanVien.DataBindings.Add(new Binding("Text", dataGridViewNhanVienList.DataSource, "tendn", true, DataSourceUpdateMode.Never));
            txtPasswordNhanVien.DataBindings.Add(new Binding("Text", dataGridViewNhanVienList.DataSource, "matkhau", true, DataSourceUpdateMode.Never));
        }

        private void btnLoadNhanVien_Click(object sender, EventArgs e)
        { 
            LoadNhanVienList();
        }

        private void btnAddNhanVien_Click(object sender, EventArgs e)
        {
            string manv = txtMaNVNhanVien.Text;
            string hoten = txtHoVaTenNhanVien.Text;
            string email = txtEmailNhanVien.Text;
            string luong = txtSalaryNhanVien.Text;
            string tendn = txtDoanhNghiepNhanVien.Text;
            string matkhau = txtPasswordNhanVien.Text;
            if (NhanVienDAO.Instance.InsertNhanVien(manv, hoten, email, luong, tendn, matkhau))
            {
                MessageBox.Show("Thêm nhân viên thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanVienList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm nhân viên!!!!", "THÔNG BÁO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                LoadNhanVienList();
            } 
        }

        private void btnUpdateNhanVien_Click(object sender, EventArgs e)
        { 
            string manv = txtMaNVNhanVien.Text;
            string hoten = txtHoVaTenNhanVien.Text;
            string email = txtEmailNhanVien.Text;
            string luong = txtSalaryNhanVien.Text;
            string tendn = txtDoanhNghiepNhanVien.Text;
            string matkhau = txtPasswordNhanVien.Text;
            if (NhanVienDAO.Instance.UpdateNhanVien(manv, hoten, email, luong, tendn, matkhau))
            {
                MessageBox.Show("Cập nhật nhân viên thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanVienList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật nhân viên!!!!", "THÔNG BÁO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                LoadNhanVienList();
            }
        }

        private void btnDeleteNhanVien_Click(object sender, EventArgs e)
        {
            string manv = txtMaNVNhanVien.Text;
            if (NhanVienDAO.Instance.DeleteNhanVien(manv))
            {
                MessageBox.Show("Xóa nhân viên thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanVienList();
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại!!!", "THÔNG BÁO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                LoadNhanVienList();
            }
        }

        private void btnSaveNhanVien_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LƯU DỮ LIỆU NHÂN VIÊN THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            LoadNhanVienList(); 
        }  
        private void btnSearchNhanVien_Click(object sender, EventArgs e)
        {
            nhanVienList.DataSource = NhanVienDAO.Instance.SearchNhanVienByName(txtSearchHoVaTenNhanVien.Text);
        }
    }
}
