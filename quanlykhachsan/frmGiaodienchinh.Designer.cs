namespace quanlykhachsan
{
    partial class frmGiaodienchinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaodienchinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHT_QLtaikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHT_thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQL = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQL_QLkhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQL_QLphong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQL_QLdichvu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQL_QLhoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQL_QLhoadondichvi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang_Thuephong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang_Traphong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang_sddichvu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTK_Khachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTK_Phong = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTK_dtphong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTK_dtdv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHT,
            this.mnuQL,
            this.mnuChucNang,
            this.mnuTK,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1341, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHT
            // 
            this.mnuHT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHT_QLtaikhoan,
            this.mnuHT_thoat});
            this.mnuHT.Name = "mnuHT";
            this.mnuHT.Size = new System.Drawing.Size(103, 29);
            this.mnuHT.Text = "Giới thiệu";
            // 
            // mnuHT_QLtaikhoan
            // 
            this.mnuHT_QLtaikhoan.Name = "mnuHT_QLtaikhoan";
            this.mnuHT_QLtaikhoan.Size = new System.Drawing.Size(270, 34);
            this.mnuHT_QLtaikhoan.Text = "Thông tin";
            this.mnuHT_QLtaikhoan.Click += new System.EventHandler(this.mnuHT_QLtaikhoan_Click);
            // 
            // mnuHT_thoat
            // 
            this.mnuHT_thoat.Name = "mnuHT_thoat";
            this.mnuHT_thoat.Size = new System.Drawing.Size(270, 34);
            this.mnuHT_thoat.Text = "Thoát";
            this.mnuHT_thoat.Click += new System.EventHandler(this.mnuHT_thoat_Click);
            // 
            // mnuQL
            // 
            this.mnuQL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQL_QLkhachhang,
            this.mnuQL_QLphong,
            this.mnuQL_QLdichvu,
            this.mnuQL_QLhoadon,
            this.mnuQL_QLhoadondichvi});
            this.mnuQL.Name = "mnuQL";
            this.mnuQL.Size = new System.Drawing.Size(89, 29);
            this.mnuQL.Text = "Quản lý";
            // 
            // mnuQL_QLkhachhang
            // 
            this.mnuQL_QLkhachhang.Name = "mnuQL_QLkhachhang";
            this.mnuQL_QLkhachhang.Size = new System.Drawing.Size(309, 34);
            this.mnuQL_QLkhachhang.Text = "Quản lý khách hàng";
            this.mnuQL_QLkhachhang.Click += new System.EventHandler(this.mnuQL_QLkhachhang_Click);
            // 
            // mnuQL_QLphong
            // 
            this.mnuQL_QLphong.Name = "mnuQL_QLphong";
            this.mnuQL_QLphong.Size = new System.Drawing.Size(309, 34);
            this.mnuQL_QLphong.Text = "Quản lý phòng";
            this.mnuQL_QLphong.Click += new System.EventHandler(this.mnuQL_QLphong_Click);
            // 
            // mnuQL_QLdichvu
            // 
            this.mnuQL_QLdichvu.Name = "mnuQL_QLdichvu";
            this.mnuQL_QLdichvu.Size = new System.Drawing.Size(309, 34);
            this.mnuQL_QLdichvu.Text = "Quản lý dịch vụ";
            this.mnuQL_QLdichvu.Click += new System.EventHandler(this.mnuQL_QLdichvu_Click);
            // 
            // mnuQL_QLhoadon
            // 
            this.mnuQL_QLhoadon.Name = "mnuQL_QLhoadon";
            this.mnuQL_QLhoadon.Size = new System.Drawing.Size(309, 34);
            this.mnuQL_QLhoadon.Text = "Quản lý hóa đơn";
            this.mnuQL_QLhoadon.Click += new System.EventHandler(this.mnuQL_QLhoadon_Click);
            // 
            // mnuQL_QLhoadondichvi
            // 
            this.mnuQL_QLhoadondichvi.Name = "mnuQL_QLhoadondichvi";
            this.mnuQL_QLhoadondichvi.Size = new System.Drawing.Size(309, 34);
            this.mnuQL_QLhoadondichvi.Text = "Quản lý hóa đơn dịch vụ";
            this.mnuQL_QLhoadondichvi.Click += new System.EventHandler(this.mnuQL_QLhoadondichvu_Click);
            // 
            // mnuChucNang
            // 
            this.mnuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChucNang_Thuephong,
            this.mnuChucNang_Traphong,
            this.mnuChucNang_sddichvu});
            this.mnuChucNang.Name = "mnuChucNang";
            this.mnuChucNang.Size = new System.Drawing.Size(113, 29);
            this.mnuChucNang.Text = "Chức năng";
            // 
            // mnuChucNang_Thuephong
            // 
            this.mnuChucNang_Thuephong.Name = "mnuChucNang_Thuephong";
            this.mnuChucNang_Thuephong.Size = new System.Drawing.Size(270, 34);
            this.mnuChucNang_Thuephong.Text = "Thuê phòng";
            this.mnuChucNang_Thuephong.Click += new System.EventHandler(this.mnuChucNang_Thuephong_Click);
            // 
            // mnuChucNang_Traphong
            // 
            this.mnuChucNang_Traphong.Name = "mnuChucNang_Traphong";
            this.mnuChucNang_Traphong.Size = new System.Drawing.Size(270, 34);
            this.mnuChucNang_Traphong.Text = "Trả phòng";
            this.mnuChucNang_Traphong.Click += new System.EventHandler(this.mnuChucNang_Traphong_Click);
            // 
            // mnuChucNang_sddichvu
            // 
            this.mnuChucNang_sddichvu.Name = "mnuChucNang_sddichvu";
            this.mnuChucNang_sddichvu.Size = new System.Drawing.Size(270, 34);
            this.mnuChucNang_sddichvu.Text = "Sử dụng dịch vụ";
            this.mnuChucNang_sddichvu.Click += new System.EventHandler(this.mnuChucNang_sddichvu_Click);
            // 
            // mnuTK
            // 
            this.mnuTK.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTK_Khachhang,
            this.mnuTK_Phong});
            this.mnuTK.Name = "mnuTK";
            this.mnuTK.Size = new System.Drawing.Size(100, 29);
            this.mnuTK.Text = "Tìm kiếm";
            // 
            // mnuTK_Khachhang
            // 
            this.mnuTK_Khachhang.Name = "mnuTK_Khachhang";
            this.mnuTK_Khachhang.Size = new System.Drawing.Size(282, 34);
            this.mnuTK_Khachhang.Text = "Tìm kiếm khách hàng";
            this.mnuTK_Khachhang.Click += new System.EventHandler(this.mnuTK_Khachhang_Click);
            // 
            // mnuTK_Phong
            // 
            this.mnuTK_Phong.Name = "mnuTK_Phong";
            this.mnuTK_Phong.Size = new System.Drawing.Size(282, 34);
            this.mnuTK_Phong.Text = "Tìm kiếm phòng";
            this.mnuTK_Phong.Click += new System.EventHandler(this.mnuTK_Phong_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTK_dtphong,
            this.mnuTK_dtdv});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // mnuTK_dtphong
            // 
            this.mnuTK_dtphong.Name = "mnuTK_dtphong";
            this.mnuTK_dtphong.Size = new System.Drawing.Size(270, 34);
            this.mnuTK_dtphong.Text = "Doanh thu phòng";
            this.mnuTK_dtphong.Click += new System.EventHandler(this.mnuTK_dtphong_Click);
            // 
            // mnuTK_dtdv
            // 
            this.mnuTK_dtdv.Name = "mnuTK_dtdv";
            this.mnuTK_dtdv.Size = new System.Drawing.Size(270, 34);
            this.mnuTK_dtdv.Text = "Doanh thu dịch vụ";
            this.mnuTK_dtdv.Click += new System.EventHandler(this.mnuTK_dtdv_Click);
            // 
            // frmGiaodienchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1341, 810);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGiaodienchinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý khách sạn";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.frmGiaodienchinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHT;
        private System.Windows.Forms.ToolStripMenuItem mnuHT_QLtaikhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuHT_thoat;
        private System.Windows.Forms.ToolStripMenuItem mnuQL;
        private System.Windows.Forms.ToolStripMenuItem mnuQL_QLkhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnuQL_QLphong;
        private System.Windows.Forms.ToolStripMenuItem mnuQL_QLdichvu;
        private System.Windows.Forms.ToolStripMenuItem mnuQL_QLhoadon;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang_Thuephong;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang_Traphong;
        private System.Windows.Forms.ToolStripMenuItem mnuTK;
        private System.Windows.Forms.ToolStripMenuItem mnuTK_Khachhang;
        private System.Windows.Forms.ToolStripMenuItem mnuTK_Phong;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang_sddichvu;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuTK_dtphong;
        private System.Windows.Forms.ToolStripMenuItem mnuTK_dtdv;
        private System.Windows.Forms.ToolStripMenuItem mnuQL_QLhoadondichvi;
    }
}