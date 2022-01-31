
namespace QLSV_WIN_FORM.VIEW
{
    partial class frmAccount
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
            System.Windows.Forms.ColumnHeader columnHeader4;
            this.materialListViewAccount = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // materialListViewAccount
            // 
            this.materialListViewAccount.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.materialListViewAccount.AllowColumnReorder = true;
            this.materialListViewAccount.AllowDrop = true;
            this.materialListViewAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListViewAccount.CheckBoxes = true;
            this.materialListViewAccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            columnHeader4});
            this.materialListViewAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialListViewAccount.Depth = 0;
            this.materialListViewAccount.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.materialListViewAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.materialListViewAccount.FullRowSelect = true;
            this.materialListViewAccount.HideSelection = false;
            this.materialListViewAccount.HotTracking = true;
            this.materialListViewAccount.HoverSelection = true;
            this.materialListViewAccount.ImeMode = System.Windows.Forms.ImeMode.On;
            this.materialListViewAccount.LabelEdit = true;
            this.materialListViewAccount.Location = new System.Drawing.Point(1, 64);
            this.materialListViewAccount.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListViewAccount.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListViewAccount.Name = "materialListViewAccount";
            this.materialListViewAccount.OwnerDraw = true;
            this.materialListViewAccount.ShowItemToolTips = true;
            this.materialListViewAccount.Size = new System.Drawing.Size(1367, 707);
            this.materialListViewAccount.TabIndex = 10;
            this.materialListViewAccount.UseCompatibleStateImageBehavior = false;
            this.materialListViewAccount.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "USER NAME";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 2;
            this.columnHeader2.Text = "DISPLAY NAME";
            this.columnHeader2.Width = 400;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "PASSWORD";
            columnHeader4.Width = 400;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "EMAIL";
            this.columnHeader3.Width = 300;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.materialListViewAccount);
            this.Name = "frmAccount";
            this.Text = "VIEW ACCOUNT";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView materialListViewAccount;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}