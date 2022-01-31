using MaterialSkin.Controls;
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
    public partial class frmHomePage : MaterialForm
    {
        public string Username { get; set; }
        MaterialSkin.MaterialSkinManager materialSkinManager;
        BindingSource nhanVienList = new BindingSource();
        BindingSource lopHocList = new BindingSource();
        BindingSource sinhVienList = new BindingSource();
        BindingSource moduleList = new BindingSource();
        BindingSource pointList = new BindingSource();
        BindingSource tempList = new BindingSource();
        public frmHomePage()
        {
            InitializeComponent();
            //ShowHomeList(); 

            //NHÂN VIÊN
            dataGridViewNhanVienList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNhanVienList.DataSource = nhanVienList;
            LoadNhanVienList();
            ShowNhanVienInfoDetai();
            //LỚP 
            dataGridViewLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLop.DataSource = lopHocList;
            LoadLopHoc();
            ShowClassInfoDetail();
            //SINH VIÊN
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.DataSource = sinhVienList;
            LoadStudent();
            ShowStudentInfoDetail();
            //HỌC PHẦN
            dgvModule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvModule.DataSource = moduleList;
            LoadModuleList();
            ShowModuleInfoDetail();
            //BẢNG ĐIỂM
            dgvPoint.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPoint.DataSource = pointList;
            LoadPointList();
            ShowPointInfoDetail();
        }

        #region TEMPLATE
        void ShowHomeList()
        {
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            //materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Blue900,
                MaterialSkin.Primary.Blue900,
                MaterialSkin.Primary.Blue100,
                MaterialSkin.Accent.DeepOrange700,
                MaterialSkin.TextShade.WHITE);
        } 
        #endregion TEMPLATE
        //********************
        // QUẢN LÝ NHÂN VIÊN *
        //********************
        #region QUAN_LY_NHAN_VIEN
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
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này!!!!!!", "CẢNH BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
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
        }

        private void btnSearchNhanVien_Click(object sender, EventArgs e)
        {
            //nhanVienList.DataSource = SearchNhanVien(txtSearchHoVaTenNhanVien.Text);
            nhanVienList.DataSource = NhanVienDAO.Instance.SearchNhanVienByName(txtSearchHoVaTenNhanVien.Text);
        }

        private void btnLoadNhanVien_Click(object sender, EventArgs e)
        {
            LoadNhanVienList();
        }
        private void btnSaveNhanVien_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LƯU DỮ LIỆU NHÂN VIÊN THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        #endregion QUAN_LY_NHAN_VIEN
        #region QUAN_LY_LOP_HOC
        //********************
        // QUẢN LÝ LỚP HỌC   *
        //********************
        void LoadLopHoc()
        {
            lopHocList.DataSource = LopHocDAO.Instance.GetListClass();
        }
        void ShowClassInfoDetail()
        {
            txtMaLopLop.DataBindings.Add(new Binding("Text", dataGridViewLop.DataSource, "MaLop", true, DataSourceUpdateMode.Never));
            txtTenLopLop.DataBindings.Add(new Binding("Text", dataGridViewLop.DataSource, "TenLop", true, DataSourceUpdateMode.Never));
            txtMaNVLop.DataBindings.Add(new Binding("Text", dataGridViewLop.DataSource, "ManV", true, DataSourceUpdateMode.Never));
        }
        private void btnCapNhatLop_Click(object sender, EventArgs e)
        {
            LoadLopHoc();
        }
        private void btnThemLop_Click(object sender, EventArgs e)
        {
            string malop = txtMaLopLop.Text;
            string tenlop = txtTenLopLop.Text;
            string manv = txtMaNVLop.Text;
            if (LopHocDAO.Instance.InsertClass(malop, tenlop, manv))
            {
                MessageBox.Show("THÊM lớp thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLopHoc();
            }
            else
            {
                MessageBox.Show("THÊM lớp thất bại", "THÔNG BÁO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                LoadLopHoc();
            }
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            string malop = txtMaLopLop.Text;
            string tenlop = txtTenLopLop.Text;
            string manv = txtMaNVLop.Text;
            if (LopHocDAO.Instance.UpdateClass(malop, tenlop, manv))
            {
                MessageBox.Show("SỬA lớp thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLopHoc();
            }
            else
            {
                MessageBox.Show("SỬA lớp thất bại", "THÔNG BÁO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                LoadLopHoc();
            }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            string malop = txtMaLopLop.Text;
            if (MessageBox.Show("Bạn chắc chắn muốn xóa lớp " + malop + "!!!!!!", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                if (LopHocDAO.Instance.DeleteClass(malop))
                {
                    MessageBox.Show("XÓA lớp thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLopHoc();
                }
                else
                {
                    MessageBox.Show("XÓA lớp thất bại", "THÔNG BÁO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    LoadLopHoc();
                }
            }
        }

        private void btnSearchTenLopLop_Click(object sender, EventArgs e)
        {
            lopHocList.DataSource = LopHocDAO.Instance.SearchClass(txtSearchTenLopLop.Text);
        }
        #endregion QUAN_LY_LOP_HOC 
        #region QUAN_LY_SINH_VIEN
        //********************
        // QUẢN LÝ SINH VIÊN   *
        //********************
        void LoadStudent()
        {
            //dgvSinhVien.DataSource = SinhVienDAO.Instance.GetListStudent();
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

        private void btnCapNhatSV_Click(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void btnSearchSV_Click(object sender, EventArgs e)
        {
            sinhVienList.DataSource = SinhVienDAO.Instance.SearchStudent(txtSearchSV.Text);
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            string masv = txtMaSVSV.Text;
            string hoten = txtHoTenSV.Text;
            string ngaysinh = txtNgaySinhSV.Text;
            string diachi = txtDiaChiSV.Text;
            string malop = txtMaLopLop.Text;
            string tendn = txtTenDNSV.Text;
            string matkhau = txtMatKhauSV.Text;
            if (SinhVienDAO.Instance.InsertSinhVien(masv, hoten, ngaysinh, diachi, malop, tendn, matkhau))
            {
                MessageBox.Show("THÊM sinh viên thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStudent();
            }
            else
            {
                MessageBox.Show("THÊM sinh viên thất bại", "THÔNG BÁO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                LoadStudent();
            }
        }

        private void btnSuaSinhVien_Click(object sender, EventArgs e)
        {
            string masv = txtMaSVSV.Text;
            string user = (SinhVienDAO.Instance.DecenUpdateSinhVien(masv));

            txtDAO.Text = user;
            txtSession.Text = Username;

            if (String.Compare(user, Username, true) == 0)
            {
                MessageBox.Show("CÓ QUYỀN SỬA SINH VIÊN", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string hoten = txtHoTenSV.Text;
                string ngaysinh = txtNgaySinhSV.Text;
                string diachi = txtDiaChiSV.Text;
                string malop = txtMaLopLop.Text;
                string tendn = txtTenDNSV.Text;
                string matkhau = txtMatKhauSV.Text;
                if (SinhVienDAO.Instance.UpdateSinhVien(masv, hoten, ngaysinh, diachi, malop, tendn, matkhau))
                {
                    MessageBox.Show("SỬA sinh viên thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudent();
                }
                else
                {
                    MessageBox.Show("SỬA sinh viên thất bại", "THÔNG BÁO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    LoadStudent();
                }
            }
            else
            {
                MessageBox.Show("KHÔNG CÓ QUYỀN SỬA SINH VIÊN", "THÔNG BÁO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                LoadStudent();
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            string masv = txtMaSVSV.Text;
            if (MessageBox.Show("Bạn chắc chắn muốn xóa lớp " + masv + "!!!!!!", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                if (SinhVienDAO.Instance.DeleteSinhVien(masv))
                {
                    MessageBox.Show("XÓA sinh viên thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudent();
                }
                else
                {
                    MessageBox.Show("XÓA sinh viên thất bại", "THÔNG BÁO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    LoadStudent();
                }
            }
        }

        private void btnLuuSV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LƯU DỮ LIỆU SINH VIÊN THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        #endregion QUAN_LY_SINH_VIEN
        #region QUAN_LY_HOC_PHAN
        //********************
        // QUẢN LÝ HỌC PHẦN   *
        //********************
        void LoadModuleList()
        {
            moduleList.DataSource = HocPhanDAO.Instance.GetModuleList();
        }
        void ShowModuleInfoDetail()
        {
            txtMAHP.DataBindings.Add(new Binding("Text", dgvModule.DataSource, "MAHP", true, DataSourceUpdateMode.Never));
            txtTenHP.DataBindings.Add(new Binding("Text", dgvModule.DataSource, "tenHp", true, DataSourceUpdateMode.Never));
            txtSoTC.DataBindings.Add(new Binding("Text", dgvModule.DataSource, "sOtC", true, DataSourceUpdateMode.Never));
        }
        private void btnModuleAdd_Click(object sender, EventArgs e)
        {
            string mahp = txtMAHP.Text;
            string tenhp = txtTenHP.Text;
            string sotc = txtSoTC.Text;
            if (HocPhanDAO.Instance.InsertModule(mahp, tenhp, sotc))
            {
                MessageBox.Show("THÊM học phần thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadModuleList();
            }
            else
            {
                MessageBox.Show("THÊM học phần thất bại", "THÔNG BÁO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                LoadModuleList();
            }
        }

        private void btnModuleChange_Click(object sender, EventArgs e)
        {
            string mahp = txtMAHP.Text;
            string tenhp = txtTenHP.Text;
            string sotc = txtSoTC.Text;
            if (HocPhanDAO.Instance.UpdateModule(mahp, tenhp, sotc))
            {
                MessageBox.Show("SỬA học phần thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadModuleList();
            }
            else
            {
                MessageBox.Show("SỬA học phần thất bại", "THÔNG BÁO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                LoadModuleList();
            }
        }

        private void btnModuleDelete_Click(object sender, EventArgs e)
        {
            string mahp = txtMAHP.Text;
            if (MessageBox.Show("Bạn chắc chắn muốn xóa học phần " + txtTenHP.Text + "!!!!!!", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                if (HocPhanDAO.Instance.DeleteModule(mahp))
                {
                    MessageBox.Show("XÓA học phần thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadModuleList();
                }
                else
                {
                    MessageBox.Show("XÓA học phần thất bại", "THÔNG BÁO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    LoadModuleList();
                }
            }
        }

        private void btnModuleSearch2_Click(object sender, EventArgs e)
        {
            moduleList.DataSource = HocPhanDAO.Instance.SearchModule(txtModuleSearch.Text);
        }

        private void btnModuleUpdate2_Click(object sender, EventArgs e)
        {
            LoadModuleList();
        }

        private void btnModuleSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LƯU DỮ LIỆU HỌC PHẦN THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            LoadModuleList();
        }

        #endregion QUAN_LY_HOC_PHAN
        #region QUAN_LY_BANG_DIEM
        //********************
        // QUẢN LÝ BẢNG ĐIỂM *
        //********************
        void LoadPointList()
        {
            pointList.DataSource = BangDiemDAO.Instance.GetListBangDiem();
        }
        void ShowPointInfoDetail()
        {
            txtPointMASV.DataBindings.Add(new Binding("Text", dgvPoint.DataSource, "maSV", true, DataSourceUpdateMode.Never));
            txtPointMAHP.DataBindings.Add(new Binding("Text", dgvPoint.DataSource, "maHP", true, DataSourceUpdateMode.Never));
            txtPointDiemThi.DataBindings.Add(new Binding("Text", dgvPoint.DataSource, "diEmtHI", true, DataSourceUpdateMode.Never));
        }

        private void btnPointAdd_Click_1(object sender, EventArgs e)
        {
            string masv = txtPointMASV.Text;
            string mahp = txtPointMAHP.Text;
            string diemthi = txtPointDiemThi.Text;
            if (BangDiemDAO.Instance.InsertBangDiem(masv, mahp, diemthi))
            {
                MessageBox.Show("THÊM điểm thi thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPointList();
            }
            else
            {
                MessageBox.Show("THÊM điểm thi thất bại", "THÔNG BÁO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                LoadPointList();
            }
        }

        private void btnPointChange_Click_1(object sender, EventArgs e)
        {
            string masv = txtPointMASV.Text;
            string mahp = txtPointMAHP.Text;
            string diemthi = txtPointDiemThi.Text;
            if (BangDiemDAO.Instance.UpdateBangDiem(masv, mahp, diemthi))
            {
                MessageBox.Show("SỬA điểm thi thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPointList();
            }
            else
            {
                MessageBox.Show("SỬA điểm thi thất bại", "THÔNG BÁO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                LoadPointList();
            }
        }

        private void btnPointDelete_Click_1(object sender, EventArgs e)
        {
            string masv = txtPointMASV.Text;
            string mahp = txtPointMAHP.Text;
            if (MessageBox.Show("Bạn chắc chắn muốn xóa học phần " + txtTenHP.Text + "!!!!!!", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                if (BangDiemDAO.Instance.DeleteBangDiem(masv, mahp))
                {
                    MessageBox.Show("XÓA sinh viên thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPointList();
                }
                else
                {
                    MessageBox.Show("XÓA sinh viên thất bại", "THÔNG BÁO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    LoadPointList();
                }
            }
        }
        private void btnPointSearch_Click(object sender, EventArgs e)
        {
            pointList.DataSource = BangDiemDAO.Instance.SearchBangDiem(txtPointSearch.Text);
        }

        private void btnPointUpdate_Click(object sender, EventArgs e)
        {
            LoadPointList();
        }
        private void btnPointSave_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("LƯU DỮ LIỆU BẢNG ĐIỂM THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            LoadPointList();
        }
        #endregion QUAN_LY_BANG_DIEM  

        private void frmHomePage_FormClosing(object sender, FormClosingEventArgs e)
        { 
            if (MessageBox.Show("Bạn có muốn thoát hay không", "Thông báo!!!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
