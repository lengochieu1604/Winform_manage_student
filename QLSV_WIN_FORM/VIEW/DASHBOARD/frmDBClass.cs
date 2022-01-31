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
    public partial class frmDBClass : Form
    {
        BindingSource lopHocList = new BindingSource();
        public frmDBClass()
        {
            InitializeComponent();
            //LỚP 
            dataGridViewLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLop.DataSource = lopHocList;
            LoadLopHoc();
            ShowClassInfoDetail();
        }
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
    }
}
