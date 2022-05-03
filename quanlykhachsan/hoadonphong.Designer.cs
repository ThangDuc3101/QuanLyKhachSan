namespace quanlykhachsan
{
    partial class hoadonphong
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
            this.components = new System.ComponentModel.Container();
            this.dgvPhieuthue = new System.Windows.Forms.DataGridView();
            this.mAPHIEUTHUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANHANVIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAKHACHHANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYDENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYDIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAPHONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblphieuthuephongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlykhachsandemo2304DataSet = new quanlykhachsan.quanlykhachsandemo2304DataSet();
            this.btnTaoHD = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvHoadonphong = new System.Windows.Forms.DataGridView();
            this.tbl_phieuthuephongTableAdapter = new quanlykhachsan.quanlykhachsandemo2304DataSetTableAdapters.tbl_phieuthuephongTableAdapter();
            this.tblhoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_hoadonTableAdapter = new quanlykhachsan.quanlykhachsandemo2304DataSetTableAdapters.tbl_hoadonTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaphieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNgayTT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSongay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGiaphong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTKMaphieu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuthue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblphieuthuephongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhachsandemo2304DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadonphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblhoadonBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhieuthue
            // 
            this.dgvPhieuthue.AutoGenerateColumns = false;
            this.dgvPhieuthue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuthue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuthue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAPHIEUTHUEDataGridViewTextBoxColumn,
            this.mANHANVIENDataGridViewTextBoxColumn,
            this.mAKHACHHANGDataGridViewTextBoxColumn,
            this.nGAYDENDataGridViewTextBoxColumn,
            this.nGAYDIDataGridViewTextBoxColumn,
            this.mAPHONGDataGridViewTextBoxColumn});
            this.dgvPhieuthue.DataSource = this.tblphieuthuephongBindingSource;
            this.dgvPhieuthue.Location = new System.Drawing.Point(25, 64);
            this.dgvPhieuthue.Name = "dgvPhieuthue";
            this.dgvPhieuthue.Size = new System.Drawing.Size(750, 195);
            this.dgvPhieuthue.TabIndex = 0;
            this.dgvPhieuthue.Click += new System.EventHandler(this.dgvPhieuthue_Click);
            // 
            // mAPHIEUTHUEDataGridViewTextBoxColumn
            // 
            this.mAPHIEUTHUEDataGridViewTextBoxColumn.DataPropertyName = "MAPHIEUTHUE";
            this.mAPHIEUTHUEDataGridViewTextBoxColumn.HeaderText = "MAPHIEUTHUE";
            this.mAPHIEUTHUEDataGridViewTextBoxColumn.Name = "mAPHIEUTHUEDataGridViewTextBoxColumn";
            // 
            // mANHANVIENDataGridViewTextBoxColumn
            // 
            this.mANHANVIENDataGridViewTextBoxColumn.DataPropertyName = "MANHANVIEN";
            this.mANHANVIENDataGridViewTextBoxColumn.HeaderText = "MANHANVIEN";
            this.mANHANVIENDataGridViewTextBoxColumn.Name = "mANHANVIENDataGridViewTextBoxColumn";
            // 
            // mAKHACHHANGDataGridViewTextBoxColumn
            // 
            this.mAKHACHHANGDataGridViewTextBoxColumn.DataPropertyName = "MAKHACHHANG";
            this.mAKHACHHANGDataGridViewTextBoxColumn.HeaderText = "MAKHACHHANG";
            this.mAKHACHHANGDataGridViewTextBoxColumn.Name = "mAKHACHHANGDataGridViewTextBoxColumn";
            // 
            // nGAYDENDataGridViewTextBoxColumn
            // 
            this.nGAYDENDataGridViewTextBoxColumn.DataPropertyName = "NGAYDEN";
            this.nGAYDENDataGridViewTextBoxColumn.HeaderText = "NGAYDEN";
            this.nGAYDENDataGridViewTextBoxColumn.Name = "nGAYDENDataGridViewTextBoxColumn";
            // 
            // nGAYDIDataGridViewTextBoxColumn
            // 
            this.nGAYDIDataGridViewTextBoxColumn.DataPropertyName = "NGAYDI";
            this.nGAYDIDataGridViewTextBoxColumn.HeaderText = "NGAYDI";
            this.nGAYDIDataGridViewTextBoxColumn.Name = "nGAYDIDataGridViewTextBoxColumn";
            // 
            // mAPHONGDataGridViewTextBoxColumn
            // 
            this.mAPHONGDataGridViewTextBoxColumn.DataPropertyName = "MAPHONG";
            this.mAPHONGDataGridViewTextBoxColumn.HeaderText = "MAPHONG";
            this.mAPHONGDataGridViewTextBoxColumn.Name = "mAPHONGDataGridViewTextBoxColumn";
            // 
            // tblphieuthuephongBindingSource
            // 
            this.tblphieuthuephongBindingSource.DataMember = "tbl_phieuthuephong";
            this.tblphieuthuephongBindingSource.DataSource = this.quanlykhachsandemo2304DataSet;
            // 
            // quanlykhachsandemo2304DataSet
            // 
            this.quanlykhachsandemo2304DataSet.DataSetName = "quanlykhachsandemo2304DataSet";
            this.quanlykhachsandemo2304DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTaoHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoHD.Location = new System.Drawing.Point(33, 385);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(90, 25);
            this.btnTaoHD.TabIndex = 1;
            this.btnTaoHD.Text = "Tạo HĐ";
            this.btnTaoHD.UseVisualStyleBackColor = false;
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHD_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(345, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thanh toán";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(651, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvHoadonphong
            // 
            this.dgvHoadonphong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoadonphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoadonphong.Location = new System.Drawing.Point(27, 417);
            this.dgvHoadonphong.Name = "dgvHoadonphong";
            this.dgvHoadonphong.Size = new System.Drawing.Size(750, 206);
            this.dgvHoadonphong.TabIndex = 5;
            this.dgvHoadonphong.Click += new System.EventHandler(this.dgvHoadonphong_Click);
            // 
            // tbl_phieuthuephongTableAdapter
            // 
            this.tbl_phieuthuephongTableAdapter.ClearBeforeFill = true;
            // 
            // tblhoadonBindingSource
            // 
            this.tblhoadonBindingSource.DataMember = "tbl_hoadon";
            this.tblhoadonBindingSource.DataSource = this.quanlykhachsandemo2304DataSet;
            // 
            // tbl_hoadonTableAdapter
            // 
            this.tbl_hoadonTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã HĐ tự động";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(114, 16);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 20);
            this.txtMaHD.TabIndex = 7;
            // 
            // txtMaphieu
            // 
            this.txtMaphieu.Location = new System.Drawing.Point(114, 46);
            this.txtMaphieu.Name = "txtMaphieu";
            this.txtMaphieu.Size = new System.Drawing.Size(100, 20);
            this.txtMaphieu.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(21, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã phiếu thuê";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(114, 75);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 20);
            this.txtMaKH.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(21, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã KH";
            // 
            // txtMaphong
            // 
            this.txtMaphong.Location = new System.Drawing.Point(375, 19);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(100, 20);
            this.txtMaphong.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(282, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mã phòng";
            // 
            // txtNgayTT
            // 
            this.txtNgayTT.Location = new System.Drawing.Point(629, 19);
            this.txtNgayTT.Name = "txtNgayTT";
            this.txtNgayTT.Size = new System.Drawing.Size(100, 20);
            this.txtNgayTT.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(536, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ngày thanh toán";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(629, 49);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(536, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mã NV";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(629, 78);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(100, 20);
            this.txtTongtien.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(536, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tổng tiền";
            // 
            // txtSongay
            // 
            this.txtSongay.Location = new System.Drawing.Point(375, 77);
            this.txtSongay.Name = "txtSongay";
            this.txtSongay.Size = new System.Drawing.Size(100, 20);
            this.txtSongay.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(282, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Số ngày ở";
            // 
            // txtGiaphong
            // 
            this.txtGiaphong.Location = new System.Drawing.Point(375, 49);
            this.txtGiaphong.Name = "txtGiaphong";
            this.txtGiaphong.Size = new System.Drawing.Size(100, 20);
            this.txtGiaphong.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(282, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Giá phòng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaphong);
            this.groupBox1.Controls.Add(this.txtGiaphong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.txtSongay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMaphieu);
            this.groupBox1.Controls.Add(this.txtTongtien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNgayTT);
            this.groupBox1.Location = new System.Drawing.Point(27, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 114);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "-- Nhập mã phiếu thuê --";
            // 
            // txtTKMaphieu
            // 
            this.txtTKMaphieu.Location = new System.Drawing.Point(321, 22);
            this.txtTKMaphieu.Name = "txtTKMaphieu";
            this.txtTKMaphieu.Size = new System.Drawing.Size(170, 20);
            this.txtTKMaphieu.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(522, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 25);
            this.button1.TabIndex = 27;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // hoadonphong
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 635);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTKMaphieu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvHoadonphong);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTaoHD);
            this.Controls.Add(this.dgvPhieuthue);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "hoadonphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý khách sạn";
            this.Load += new System.EventHandler(this.hoadonphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuthue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblphieuthuephongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhachsandemo2304DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadonphong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblhoadonBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhieuthue;
        private System.Windows.Forms.Button btnTaoHD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvHoadonphong;
        private quanlykhachsandemo2304DataSet quanlykhachsandemo2304DataSet;
        private System.Windows.Forms.BindingSource tblphieuthuephongBindingSource;
        private quanlykhachsandemo2304DataSetTableAdapters.tbl_phieuthuephongTableAdapter tbl_phieuthuephongTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAPHIEUTHUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANHANVIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHACHHANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYDENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYDIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAPHONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblhoadonBindingSource;
        private quanlykhachsandemo2304DataSetTableAdapters.tbl_hoadonTableAdapter tbl_hoadonTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaphieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNgayTT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSongay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGiaphong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTKMaphieu;
        private System.Windows.Forms.Button button1;
    }
}