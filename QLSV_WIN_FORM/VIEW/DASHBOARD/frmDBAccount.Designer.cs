
namespace QLSV_WIN_FORM.VIEW.DASHBOARD
{
    partial class frmDBAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLoadNhanVien = new System.Windows.Forms.Button();
            this.btnSaveNhanVien = new System.Windows.Forms.Button();
            this.btnUpdateNhanVien = new System.Windows.Forms.Button();
            this.btnDeleteNhanVien = new System.Windows.Forms.Button();
            this.btnAddNhanVien = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewNhanVienList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchNhanVien = new System.Windows.Forms.Button();
            this.txtSearchHoVaTenNhanVien = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPasswordNhanVien = new System.Windows.Forms.TextBox();
            this.lblMatKhauNhanVien = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtEmailNhanVien = new System.Windows.Forms.TextBox();
            this.lblMailNhanVien = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtDoanhNghiepNhanVien = new System.Windows.Forms.TextBox();
            this.lblDoanhNghiepNhanVien = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txtHoVaTenNhanVien = new System.Windows.Forms.TextBox();
            this.lblHoVaTen = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtSalaryNhanVien = new System.Windows.Forms.TextBox();
            this.lblSalaryNhanVien = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.txtMaNVNhanVien = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVienList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel19.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(-5, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(811, 43);
            this.panel8.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Harrington", 20.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(274, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.btnLoadNhanVien);
            this.panel3.Controls.Add(this.btnSaveNhanVien);
            this.panel3.Controls.Add(this.btnUpdateNhanVien);
            this.panel3.Controls.Add(this.btnDeleteNhanVien);
            this.panel3.Controls.Add(this.btnAddNhanVien);
            this.panel3.Location = new System.Drawing.Point(-5, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(811, 67);
            this.panel3.TabIndex = 10;
            // 
            // btnLoadNhanVien
            // 
            this.btnLoadNhanVien.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLoadNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoadNhanVien.Location = new System.Drawing.Point(196, 12);
            this.btnLoadNhanVien.Name = "btnLoadNhanVien";
            this.btnLoadNhanVien.Size = new System.Drawing.Size(92, 42);
            this.btnLoadNhanVien.TabIndex = 4;
            this.btnLoadNhanVien.Text = "Cập nhật";
            this.btnLoadNhanVien.UseVisualStyleBackColor = false;
            this.btnLoadNhanVien.Click += new System.EventHandler(this.btnLoadNhanVien_Click);
            // 
            // btnSaveNhanVien
            // 
            this.btnSaveNhanVien.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveNhanVien.Location = new System.Drawing.Point(527, 13);
            this.btnSaveNhanVien.Name = "btnSaveNhanVien";
            this.btnSaveNhanVien.Size = new System.Drawing.Size(73, 42);
            this.btnSaveNhanVien.TabIndex = 3;
            this.btnSaveNhanVien.Text = "Lưu";
            this.btnSaveNhanVien.UseVisualStyleBackColor = false;
            this.btnSaveNhanVien.Click += new System.EventHandler(this.btnSaveNhanVien_Click);
            // 
            // btnUpdateNhanVien
            // 
            this.btnUpdateNhanVien.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdateNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateNhanVien.Location = new System.Drawing.Point(371, 12);
            this.btnUpdateNhanVien.Name = "btnUpdateNhanVien";
            this.btnUpdateNhanVien.Size = new System.Drawing.Size(73, 42);
            this.btnUpdateNhanVien.TabIndex = 2;
            this.btnUpdateNhanVien.Text = "Sửa";
            this.btnUpdateNhanVien.UseVisualStyleBackColor = false;
            this.btnUpdateNhanVien.Click += new System.EventHandler(this.btnUpdateNhanVien_Click);
            // 
            // btnDeleteNhanVien
            // 
            this.btnDeleteNhanVien.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeleteNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteNhanVien.Location = new System.Drawing.Point(449, 13);
            this.btnDeleteNhanVien.Name = "btnDeleteNhanVien";
            this.btnDeleteNhanVien.Size = new System.Drawing.Size(73, 42);
            this.btnDeleteNhanVien.TabIndex = 1;
            this.btnDeleteNhanVien.Text = "Xóa";
            this.btnDeleteNhanVien.UseVisualStyleBackColor = false;
            this.btnDeleteNhanVien.Click += new System.EventHandler(this.btnDeleteNhanVien_Click);
            // 
            // btnAddNhanVien
            // 
            this.btnAddNhanVien.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNhanVien.Location = new System.Drawing.Point(293, 12);
            this.btnAddNhanVien.Name = "btnAddNhanVien";
            this.btnAddNhanVien.Size = new System.Drawing.Size(73, 42);
            this.btnAddNhanVien.TabIndex = 0;
            this.btnAddNhanVien.Text = "Thêm";
            this.btnAddNhanVien.UseVisualStyleBackColor = false;
            this.btnAddNhanVien.Click += new System.EventHandler(this.btnAddNhanVien_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewNhanVienList);
            this.panel2.Location = new System.Drawing.Point(-5, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 205);
            this.panel2.TabIndex = 9;
            // 
            // dataGridViewNhanVienList
            // 
            this.dataGridViewNhanVienList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewNhanVienList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhanVienList.Location = new System.Drawing.Point(34, 2);
            this.dataGridViewNhanVienList.Name = "dataGridViewNhanVienList";
            this.dataGridViewNhanVienList.RowTemplate.Height = 25;
            this.dataGridViewNhanVienList.Size = new System.Drawing.Size(812, 200);
            this.dataGridViewNhanVienList.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnSearchNhanVien);
            this.panel1.Controls.Add(this.txtSearchHoVaTenNhanVien);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel16);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel19);
            this.panel1.Location = new System.Drawing.Point(-5, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 128);
            this.panel1.TabIndex = 8;
            // 
            // btnSearchNhanVien
            // 
            this.btnSearchNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearchNhanVien.Location = new System.Drawing.Point(679, 48);
            this.btnSearchNhanVien.Name = "btnSearchNhanVien";
            this.btnSearchNhanVien.Size = new System.Drawing.Size(88, 35);
            this.btnSearchNhanVien.TabIndex = 5;
            this.btnSearchNhanVien.Text = "Tìm kiếm";
            this.btnSearchNhanVien.UseVisualStyleBackColor = true;
            this.btnSearchNhanVien.Click += new System.EventHandler(this.btnSearchNhanVien_Click);
            // 
            // txtSearchHoVaTenNhanVien
            // 
            this.txtSearchHoVaTenNhanVien.Location = new System.Drawing.Point(650, 12);
            this.txtSearchHoVaTenNhanVien.Name = "txtSearchHoVaTenNhanVien";
            this.txtSearchHoVaTenNhanVien.Size = new System.Drawing.Size(151, 20);
            this.txtSearchHoVaTenNhanVien.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtPasswordNhanVien);
            this.panel5.Controls.Add(this.lblMatKhauNhanVien);
            this.panel5.Location = new System.Drawing.Point(288, 88);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(348, 36);
            this.panel5.TabIndex = 11;
            // 
            // txtPasswordNhanVien
            // 
            this.txtPasswordNhanVien.Location = new System.Drawing.Point(145, 7);
            this.txtPasswordNhanVien.Name = "txtPasswordNhanVien";
            this.txtPasswordNhanVien.Size = new System.Drawing.Size(191, 20);
            this.txtPasswordNhanVien.TabIndex = 1;
            // 
            // lblMatKhauNhanVien
            // 
            this.lblMatKhauNhanVien.AutoSize = true;
            this.lblMatKhauNhanVien.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblMatKhauNhanVien.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMatKhauNhanVien.Location = new System.Drawing.Point(3, 7);
            this.lblMatKhauNhanVien.Name = "lblMatKhauNhanVien";
            this.lblMatKhauNhanVien.Size = new System.Drawing.Size(96, 25);
            this.lblMatKhauNhanVien.TabIndex = 0;
            this.lblMatKhauNhanVien.Text = "Mật khẩu";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtEmailNhanVien);
            this.panel4.Controls.Add(this.lblMailNhanVien);
            this.panel4.Location = new System.Drawing.Point(4, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 36);
            this.panel4.TabIndex = 8;
            // 
            // txtEmailNhanVien
            // 
            this.txtEmailNhanVien.Location = new System.Drawing.Point(99, 7);
            this.txtEmailNhanVien.Name = "txtEmailNhanVien";
            this.txtEmailNhanVien.Size = new System.Drawing.Size(166, 20);
            this.txtEmailNhanVien.TabIndex = 1;
            // 
            // lblMailNhanVien
            // 
            this.lblMailNhanVien.AutoSize = true;
            this.lblMailNhanVien.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblMailNhanVien.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMailNhanVien.Location = new System.Drawing.Point(3, 7);
            this.lblMailNhanVien.Name = "lblMailNhanVien";
            this.lblMailNhanVien.Size = new System.Drawing.Size(59, 25);
            this.lblMailNhanVien.TabIndex = 0;
            this.lblMailNhanVien.Text = "Email";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtDoanhNghiepNhanVien);
            this.panel6.Controls.Add(this.lblDoanhNghiepNhanVien);
            this.panel6.Location = new System.Drawing.Point(288, 47);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(348, 36);
            this.panel6.TabIndex = 10;
            // 
            // txtDoanhNghiepNhanVien
            // 
            this.txtDoanhNghiepNhanVien.Location = new System.Drawing.Point(145, 7);
            this.txtDoanhNghiepNhanVien.Name = "txtDoanhNghiepNhanVien";
            this.txtDoanhNghiepNhanVien.Size = new System.Drawing.Size(191, 20);
            this.txtDoanhNghiepNhanVien.TabIndex = 1;
            // 
            // lblDoanhNghiepNhanVien
            // 
            this.lblDoanhNghiepNhanVien.AutoSize = true;
            this.lblDoanhNghiepNhanVien.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDoanhNghiepNhanVien.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDoanhNghiepNhanVien.Location = new System.Drawing.Point(2, 4);
            this.lblDoanhNghiepNhanVien.Name = "lblDoanhNghiepNhanVien";
            this.lblDoanhNghiepNhanVien.Size = new System.Drawing.Size(138, 25);
            this.lblDoanhNghiepNhanVien.TabIndex = 0;
            this.lblDoanhNghiepNhanVien.Text = "Doanh nghiệp";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.txtHoVaTenNhanVien);
            this.panel16.Controls.Add(this.lblHoVaTen);
            this.panel16.Location = new System.Drawing.Point(4, 47);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(267, 36);
            this.panel16.TabIndex = 7;
            // 
            // txtHoVaTenNhanVien
            // 
            this.txtHoVaTenNhanVien.Location = new System.Drawing.Point(99, 7);
            this.txtHoVaTenNhanVien.Name = "txtHoVaTenNhanVien";
            this.txtHoVaTenNhanVien.Size = new System.Drawing.Size(166, 20);
            this.txtHoVaTenNhanVien.TabIndex = 1;
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.AutoSize = true;
            this.lblHoVaTen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblHoVaTen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHoVaTen.Location = new System.Drawing.Point(3, 7);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(98, 25);
            this.lblHoVaTen.TabIndex = 0;
            this.lblHoVaTen.Text = "Họ và tên";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtSalaryNhanVien);
            this.panel7.Controls.Add(this.lblSalaryNhanVien);
            this.panel7.Location = new System.Drawing.Point(288, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(348, 36);
            this.panel7.TabIndex = 9;
            // 
            // txtSalaryNhanVien
            // 
            this.txtSalaryNhanVien.Location = new System.Drawing.Point(145, 7);
            this.txtSalaryNhanVien.Name = "txtSalaryNhanVien";
            this.txtSalaryNhanVien.Size = new System.Drawing.Size(191, 20);
            this.txtSalaryNhanVien.TabIndex = 1;
            // 
            // lblSalaryNhanVien
            // 
            this.lblSalaryNhanVien.AutoSize = true;
            this.lblSalaryNhanVien.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSalaryNhanVien.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSalaryNhanVien.Location = new System.Drawing.Point(3, 7);
            this.lblSalaryNhanVien.Name = "lblSalaryNhanVien";
            this.lblSalaryNhanVien.Size = new System.Drawing.Size(71, 25);
            this.lblSalaryNhanVien.TabIndex = 0;
            this.lblSalaryNhanVien.Text = "Lương";
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.txtMaNVNhanVien);
            this.panel19.Controls.Add(this.lblMaNV);
            this.panel19.Location = new System.Drawing.Point(4, 5);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(267, 36);
            this.panel19.TabIndex = 6;
            // 
            // txtMaNVNhanVien
            // 
            this.txtMaNVNhanVien.Location = new System.Drawing.Point(99, 7);
            this.txtMaNVNhanVien.Name = "txtMaNVNhanVien";
            this.txtMaNVNhanVien.Size = new System.Drawing.Size(166, 20);
            this.txtMaNVNhanVien.TabIndex = 1;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblMaNV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMaNV.Location = new System.Drawing.Point(3, 7);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(68, 25);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "MaNV";
            // 
            // frmDBAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDBAccount";
            this.Text = "Account";
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVienList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLoadNhanVien;
        private System.Windows.Forms.Button btnSaveNhanVien;
        private System.Windows.Forms.Button btnUpdateNhanVien;
        private System.Windows.Forms.Button btnDeleteNhanVien;
        private System.Windows.Forms.Button btnAddNhanVien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewNhanVienList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchNhanVien;
        private System.Windows.Forms.TextBox txtSearchHoVaTenNhanVien;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtPasswordNhanVien;
        private System.Windows.Forms.Label lblMatKhauNhanVien;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtEmailNhanVien;
        private System.Windows.Forms.Label lblMailNhanVien;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtDoanhNghiepNhanVien;
        private System.Windows.Forms.Label lblDoanhNghiepNhanVien;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox txtHoVaTenNhanVien;
        private System.Windows.Forms.Label lblHoVaTen;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtSalaryNhanVien;
        private System.Windows.Forms.Label lblSalaryNhanVien;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.TextBox txtMaNVNhanVien;
        private System.Windows.Forms.Label lblMaNV;
    }
}