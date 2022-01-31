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
    public partial class frmDBStudent : Form
    {
        public string Username { get; set; } 
        BindingSource sinhVienList = new BindingSource();
        public frmDBStudent()
        {
            InitializeComponent();
            //SINH VIÊN
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.DataSource = sinhVienList;
            LoadStudent();
            ShowStudentInfoDetail();
        }
        void LoadStudent()
        { 
            sinhVienList.DataSource = SinhVienDAO.Instance.GetListStudent();

        }
        void ShowStudentInfoDetail()
        {
            txtMaSVSV.DataBindings.Add(new Binding("Text", dgvSinhVien.DataSource, "MaSV", true, DataSourceUpdateMode.Never));
            txtHoTenSV.DataBindings.Add(new Binding("Text", dgvSinhVien.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
            txtNgaySinhSV.DataBindings.Add(new Binding("Text", dgvSinhVien.DataSource, "ngaySINH", true, DataSourceUpdateMode.Never));
            txtDiaChiSV.DataBindings.Add(new Binding("Text", dgvSinhVien.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txtMaLopSV.DataBindings.Add(new Binding("Text", dgvSinhVien.DataSource, "maLOp", true, DataSourceUpdateMode.Never));
            txtTenDNSV.DataBindings.Add(new Binding("Text", dgvSinhVien.DataSource, "tenDn", true, DataSourceUpdateMode.Never));
            txtMatKhauSV.DataBindings.Add(new Binding("Text", dgvSinhVien.DataSource, "Matkhau", true, DataSourceUpdateMode.Never));
        }

    }
}
