namespace Bán_Giày.Views
{
    partial class frmDSHoaDon
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDiaChiTT = new System.Windows.Forms.Label();
            this.lbTenkhTT = new System.Windows.Forms.Label();
            this.lbNgayBanTT = new System.Windows.Forms.Label();
            this.lbSDTTT = new System.Windows.Forms.Label();
            this.lbMakhTT = new System.Windows.Forms.Label();
            this.lbMahdTT = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lbtongtienTT = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelButtonHoaDon = new System.Windows.Forms.Panel();
            this.btnGhi = new FontAwesome.Sharp.IconButton();
            this.btnInhoadon = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.BtnDoc = new FontAwesome.Sharp.IconButton();
            this.btnNhap = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.cmbMaGiay_NHD = new System.Windows.Forms.ComboBox();
            this.cmbMaKH_NHD = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSuagiohang = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTongtien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhsachHoaDon = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelButtonHoaDon.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvGioHang);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(514, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 789);
            this.panel3.TabIndex = 1;
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGioHang.Location = new System.Drawing.Point(0, 205);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.RowHeadersWidth = 51;
            this.dgvGioHang.RowTemplate.Height = 24;
            this.dgvGioHang.Size = new System.Drawing.Size(489, 532);
            this.dgvGioHang.TabIndex = 1;
            this.dgvGioHang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGioHang_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaGiay";
            this.Column1.HeaderText = "Mã giày";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Ten";
            this.Column2.HeaderText = "Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoLuong";
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DonGia";
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbDiaChiTT);
            this.panel2.Controls.Add(this.lbTenkhTT);
            this.panel2.Controls.Add(this.lbNgayBanTT);
            this.panel2.Controls.Add(this.lbSDTTT);
            this.panel2.Controls.Add(this.lbMakhTT);
            this.panel2.Controls.Add(this.lbMahdTT);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 205);
            this.panel2.TabIndex = 3;
            // 
            // lbDiaChiTT
            // 
            this.lbDiaChiTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDiaChiTT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChiTT.ForeColor = System.Drawing.Color.Navy;
            this.lbDiaChiTT.Location = new System.Drawing.Point(210, 142);
            this.lbDiaChiTT.Name = "lbDiaChiTT";
            this.lbDiaChiTT.Size = new System.Drawing.Size(258, 33);
            this.lbDiaChiTT.TabIndex = 0;
            this.lbDiaChiTT.Text = "Địa Chỉ";
            this.lbDiaChiTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTenkhTT
            // 
            this.lbTenkhTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTenkhTT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenkhTT.ForeColor = System.Drawing.Color.Navy;
            this.lbTenkhTT.Location = new System.Drawing.Point(210, 72);
            this.lbTenkhTT.Name = "lbTenkhTT";
            this.lbTenkhTT.Size = new System.Drawing.Size(258, 33);
            this.lbTenkhTT.TabIndex = 0;
            this.lbTenkhTT.Text = "Tên khách hàng";
            this.lbTenkhTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbNgayBanTT
            // 
            this.lbNgayBanTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNgayBanTT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayBanTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbNgayBanTT.Location = new System.Drawing.Point(210, 12);
            this.lbNgayBanTT.Name = "lbNgayBanTT";
            this.lbNgayBanTT.Size = new System.Drawing.Size(258, 33);
            this.lbNgayBanTT.TabIndex = 0;
            this.lbNgayBanTT.Text = "Ngày Bán";
            this.lbNgayBanTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSDTTT
            // 
            this.lbSDTTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSDTTT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDTTT.ForeColor = System.Drawing.Color.Navy;
            this.lbSDTTT.Location = new System.Drawing.Point(28, 142);
            this.lbSDTTT.Name = "lbSDTTT";
            this.lbSDTTT.Size = new System.Drawing.Size(153, 33);
            this.lbSDTTT.TabIndex = 0;
            this.lbSDTTT.Text = "Số điện thoại";
            this.lbSDTTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbMakhTT
            // 
            this.lbMakhTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMakhTT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMakhTT.ForeColor = System.Drawing.Color.Navy;
            this.lbMakhTT.Location = new System.Drawing.Point(28, 72);
            this.lbMakhTT.Name = "lbMakhTT";
            this.lbMakhTT.Size = new System.Drawing.Size(153, 33);
            this.lbMakhTT.TabIndex = 0;
            this.lbMakhTT.Text = "Mã khách hàng";
            this.lbMakhTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbMahdTT
            // 
            this.lbMahdTT.BackColor = System.Drawing.Color.White;
            this.lbMahdTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMahdTT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMahdTT.ForeColor = System.Drawing.Color.Blue;
            this.lbMahdTT.Location = new System.Drawing.Point(28, 12);
            this.lbMahdTT.Name = "lbMahdTT";
            this.lbMahdTT.Size = new System.Drawing.Size(153, 33);
            this.lbMahdTT.TabIndex = 0;
            this.lbMahdTT.Text = "Mã hoá đơn";
            this.lbMahdTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.lbtongtienTT);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 737);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(489, 52);
            this.panel6.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tổng tiền:";
            // 
            // lbtongtienTT
            // 
            this.lbtongtienTT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbtongtienTT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbtongtienTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbtongtienTT.Location = new System.Drawing.Point(109, 11);
            this.lbtongtienTT.Name = "lbtongtienTT";
            this.lbtongtienTT.Size = new System.Drawing.Size(368, 31);
            this.lbtongtienTT.TabIndex = 0;
            this.lbtongtienTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelButtonHoaDon);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1003, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 789);
            this.panel1.TabIndex = 3;
            // 
            // panelButtonHoaDon
            // 
            this.panelButtonHoaDon.Controls.Add(this.btnGhi);
            this.panelButtonHoaDon.Controls.Add(this.btnInhoadon);
            this.panelButtonHoaDon.Controls.Add(this.iconButton1);
            this.panelButtonHoaDon.Controls.Add(this.btnSua);
            this.panelButtonHoaDon.Controls.Add(this.BtnDoc);
            this.panelButtonHoaDon.Controls.Add(this.btnNhap);
            this.panelButtonHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtonHoaDon.Location = new System.Drawing.Point(0, 570);
            this.panelButtonHoaDon.Name = "panelButtonHoaDon";
            this.panelButtonHoaDon.Size = new System.Drawing.Size(318, 217);
            this.panelButtonHoaDon.TabIndex = 9;
            // 
            // btnGhi
            // 
            this.btnGhi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGhi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGhi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.ForeColor = System.Drawing.Color.White;
            this.btnGhi.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            this.btnGhi.IconColor = System.Drawing.Color.White;
            this.btnGhi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGhi.IconSize = 30;
            this.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGhi.Location = new System.Drawing.Point(13, 159);
            this.btnGhi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(129, 42);
            this.btnGhi.TabIndex = 8;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGhi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGhi.UseVisualStyleBackColor = false;
            this.btnGhi.Click += new System.EventHandler(this.btnGhiFileHoaDon_Click);
            // 
            // btnInhoadon
            // 
            this.btnInhoadon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInhoadon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInhoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInhoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhoadon.ForeColor = System.Drawing.Color.White;
            this.btnInhoadon.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnInhoadon.IconColor = System.Drawing.Color.White;
            this.btnInhoadon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInhoadon.IconSize = 30;
            this.btnInhoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInhoadon.Location = new System.Drawing.Point(161, 84);
            this.btnInhoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInhoadon.Name = "btnInhoadon";
            this.btnInhoadon.Size = new System.Drawing.Size(148, 44);
            this.btnInhoadon.TabIndex = 6;
            this.btnInhoadon.Text = "In hoá đơn";
            this.btnInhoadon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInhoadon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInhoadon.UseVisualStyleBackColor = false;
            this.btnInhoadon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(13, 84);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(129, 44);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.Text = "Xoá";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.btnXoaThongTinHoaDon_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnSua.IconColor = System.Drawing.Color.White;
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.IconSize = 30;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(161, 14);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(148, 41);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSuaThongTinHoaDon_Click);
            // 
            // BtnDoc
            // 
            this.BtnDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDoc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoc.ForeColor = System.Drawing.Color.White;
            this.BtnDoc.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.BtnDoc.IconColor = System.Drawing.Color.White;
            this.BtnDoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDoc.IconSize = 30;
            this.BtnDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDoc.Location = new System.Drawing.Point(161, 159);
            this.BtnDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDoc.Name = "BtnDoc";
            this.BtnDoc.Size = new System.Drawing.Size(148, 41);
            this.BtnDoc.TabIndex = 7;
            this.BtnDoc.Text = "Đọc";
            this.BtnDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDoc.UseVisualStyleBackColor = false;
            this.BtnDoc.Click += new System.EventHandler(this.btnDocFileHoaDon_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.ForeColor = System.Drawing.Color.White;
            this.btnNhap.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnNhap.IconColor = System.Drawing.Color.White;
            this.btnNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhap.IconSize = 30;
            this.btnNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhap.Location = new System.Drawing.Point(13, 14);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(129, 41);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Click += new System.EventHandler(this.btnNhapThongTinHoaDon_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btnXoa);
            this.panel5.Controls.Add(this.cmbMaGiay_NHD);
            this.panel5.Controls.Add(this.cmbMaKH_NHD);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txtDongia);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.btnSuagiohang);
            this.panel5.Controls.Add(this.btnThem);
            this.panel5.Controls.Add(this.txtMaHD);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.lbTongtien);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txtSoluong);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 71);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(318, 440);
            this.panel5.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.Digging;
            this.btnXoa.IconColor = System.Drawing.Color.Snow;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 30;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(211, 386);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 43);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cmbMaGiay_NHD
            // 
            this.cmbMaGiay_NHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaGiay_NHD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaGiay_NHD.FormattingEnabled = true;
            this.cmbMaGiay_NHD.Location = new System.Drawing.Point(123, 137);
            this.cmbMaGiay_NHD.Name = "cmbMaGiay_NHD";
            this.cmbMaGiay_NHD.Size = new System.Drawing.Size(181, 33);
            this.cmbMaGiay_NHD.TabIndex = 3;
            // 
            // cmbMaKH_NHD
            // 
            this.cmbMaKH_NHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaKH_NHD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaKH_NHD.FormattingEnabled = true;
            this.cmbMaKH_NHD.Location = new System.Drawing.Point(123, 73);
            this.cmbMaKH_NHD.Name = "cmbMaKH_NHD";
            this.cmbMaKH_NHD.Size = new System.Drawing.Size(181, 33);
            this.cmbMaKH_NHD.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đơn giá:";
            // 
            // txtDongia
            // 
            this.txtDongia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDongia.Location = new System.Drawing.Point(123, 265);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(181, 34);
            this.txtDongia.TabIndex = 2;
            this.txtDongia.TextChanged += new System.EventHandler(this.txtDongiaNhaphoadon_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã giày:";
            // 
            // btnSuagiohang
            // 
            this.btnSuagiohang.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSuagiohang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuagiohang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnSuagiohang.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSuagiohang.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnSuagiohang.IconColor = System.Drawing.Color.White;
            this.btnSuagiohang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuagiohang.IconSize = 30;
            this.btnSuagiohang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuagiohang.Location = new System.Drawing.Point(109, 386);
            this.btnSuagiohang.Name = "btnSuagiohang";
            this.btnSuagiohang.Size = new System.Drawing.Size(100, 43);
            this.btnSuagiohang.TabIndex = 0;
            this.btnSuagiohang.Text = "Sửa";
            this.btnSuagiohang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuagiohang.UseVisualStyleBackColor = false;
            this.btnSuagiohang.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnThem.IconColor = System.Drawing.Color.White;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 30;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(3, 386);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 43);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(123, 10);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(181, 34);
            this.txtMaHD.TabIndex = 2;
            this.txtMaHD.TextChanged += new System.EventHandler(this.txtMaHD_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã KH:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thành tiền:";
            // 
            // lbTongtien
            // 
            this.lbTongtien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTongtien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongtien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTongtien.Location = new System.Drawing.Point(123, 333);
            this.lbTongtien.Name = "lbTongtien";
            this.lbTongtien.Size = new System.Drawing.Size(181, 31);
            this.lbTongtien.TabIndex = 0;
            this.lbTongtien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã HD:";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluong.Location = new System.Drawing.Point(123, 203);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(181, 34);
            this.txtSoluong.TabIndex = 2;
            this.txtSoluong.TextChanged += new System.EventHandler(this.txtSoluongNhaphoadon_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dtpNgayBan);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(318, 71);
            this.panel4.TabIndex = 2;
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayBan.CustomFormat = "HH:mm dd/MM/yyyy ";
            this.dtpNgayBan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBan.Location = new System.Drawing.Point(127, 37);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(178, 27);
            this.dtpNgayBan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày bán:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin hoá đơn";
            // 
            // dgvDanhsachHoaDon
            // 
            this.dgvDanhsachHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhsachHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhsachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsachHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhsachHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhsachHoaDon.Name = "dgvDanhsachHoaDon";
            this.dgvDanhsachHoaDon.RowHeadersWidth = 51;
            this.dgvDanhsachHoaDon.RowTemplate.Height = 24;
            this.dgvDanhsachHoaDon.Size = new System.Drawing.Size(514, 789);
            this.dgvDanhsachHoaDon.TabIndex = 4;
            this.dgvDanhsachHoaDon.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhsachHoaDon_RowEnter);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            // 
            // frmDSHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 789);
            this.Controls.Add(this.dgvDanhsachHoaDon);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDSHoaDon";
            this.Text = "frmDSHoaDon";
            this.Load += new System.EventHandler(this.frmDSHoaDon_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelButtonHoaDon.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbtongtienTT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSuagiohang;
        private System.Windows.Forms.ComboBox cmbMaKH_NHD;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.ComboBox cmbMaGiay_NHD;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label lbTongtien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnNhap;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDanhsachHoaDon;
        private System.Windows.Forms.Label lbMahdTT;
        private System.Windows.Forms.Label lbDiaChiTT;
        private System.Windows.Forms.Label lbTenkhTT;
        private System.Windows.Forms.Label lbNgayBanTT;
        private System.Windows.Forms.Label lbSDTTT;
        private System.Windows.Forms.Label lbMakhTT;
        private FontAwesome.Sharp.IconButton btnGhi;
        private FontAwesome.Sharp.IconButton btnInhoadon;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton BtnDoc;
        private System.Windows.Forms.Panel panelButtonHoaDon;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}