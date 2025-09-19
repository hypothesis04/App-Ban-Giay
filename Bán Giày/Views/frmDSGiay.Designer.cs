namespace Bán_Giày.Views
{
    partial class frmDSGiay
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
            this.panelButtonGiay = new System.Windows.Forms.Panel();
            this.btnGhi = new FontAwesome.Sharp.IconButton();
            this.BtnDoc = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnNhap = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.cmbMau = new System.Windows.Forms.ComboBox();
            this.cmbThuongHieu = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenGiay = new System.Windows.Forms.TextBox();
            this.txtMaGiay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDanhsachGiay = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelButtonGiay.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachGiay)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtonGiay
            // 
            this.panelButtonGiay.BackColor = System.Drawing.Color.White;
            this.panelButtonGiay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelButtonGiay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtonGiay.Controls.Add(this.btnGhi);
            this.panelButtonGiay.Controls.Add(this.BtnDoc);
            this.panelButtonGiay.Controls.Add(this.btnXoa);
            this.panelButtonGiay.Controls.Add(this.btnSua);
            this.panelButtonGiay.Controls.Add(this.btnNhap);
            this.panelButtonGiay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtonGiay.Location = new System.Drawing.Point(0, 515);
            this.panelButtonGiay.Name = "panelButtonGiay";
            this.panelButtonGiay.Size = new System.Drawing.Size(962, 82);
            this.panelButtonGiay.TabIndex = 0;
            // 
            // btnGhi
            // 
            this.btnGhi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGhi.AutoSize = true;
            this.btnGhi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGhi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.ForeColor = System.Drawing.Color.White;
            this.btnGhi.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.btnGhi.IconColor = System.Drawing.Color.White;
            this.btnGhi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGhi.Location = new System.Drawing.Point(51, 12);
            this.btnGhi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(138, 58);
            this.btnGhi.TabIndex = 4;
            this.btnGhi.Text = "Ghi File";
            this.btnGhi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGhi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGhi.UseVisualStyleBackColor = false;
            this.btnGhi.Click += new System.EventHandler(this.btnGhiFileGiay_Click);
            // 
            // BtnDoc
            // 
            this.BtnDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDoc.AutoSize = true;
            this.BtnDoc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoc.ForeColor = System.Drawing.Color.White;
            this.BtnDoc.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.BtnDoc.IconColor = System.Drawing.Color.White;
            this.BtnDoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDoc.Location = new System.Drawing.Point(216, 12);
            this.BtnDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDoc.Name = "BtnDoc";
            this.BtnDoc.Size = new System.Drawing.Size(153, 58);
            this.BtnDoc.TabIndex = 3;
            this.BtnDoc.Text = "Đọc File";
            this.BtnDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDoc.UseVisualStyleBackColor = false;
            this.BtnDoc.Click += new System.EventHandler(this.btnDocFileGiay_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.AutoSize = true;
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.FileCircleXmark;
            this.btnXoa.IconColor = System.Drawing.Color.White;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(392, 12);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(136, 58);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Huỷ Bỏ";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.AutoSize = true;
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.FileCircleQuestion;
            this.btnSua.IconColor = System.Drawing.Color.White;
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(552, 12);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(153, 58);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa ";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNhap.AutoSize = true;
            this.btnNhap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.ForeColor = System.Drawing.Color.White;
            this.btnNhap.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.btnNhap.IconColor = System.Drawing.Color.White;
            this.btnNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhap.Location = new System.Drawing.Point(720, 12);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(159, 58);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Xác Nhận";
            this.btnNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cmbSize);
            this.panel2.Controls.Add(this.cmbMau);
            this.panel2.Controls.Add(this.cmbThuongHieu);
            this.panel2.Controls.Add(this.txtSoLuong);
            this.panel2.Controls.Add(this.txtTenGiay);
            this.panel2.Controls.Add(this.txtMaGiay);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(962, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 597);
            this.panel2.TabIndex = 0;
            // 
            // cmbSize
            // 
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45"});
            this.cmbSize.Location = new System.Drawing.Point(146, 352);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(193, 31);
            this.cmbSize.TabIndex = 4;
            // 
            // cmbMau
            // 
            this.cmbMau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMau.FormattingEnabled = true;
            this.cmbMau.Items.AddRange(new object[] {
            "Đen",
            "Đỏ ",
            "Xanh",
            "Vàng",
            "Trắng",
            "Xanh Lá",
            "Tím",
            "Hồng",
            "Cam"});
            this.cmbMau.Location = new System.Drawing.Point(146, 289);
            this.cmbMau.Name = "cmbMau";
            this.cmbMau.Size = new System.Drawing.Size(193, 31);
            this.cmbMau.TabIndex = 3;
            // 
            // cmbThuongHieu
            // 
            this.cmbThuongHieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThuongHieu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbThuongHieu.FormattingEnabled = true;
            this.cmbThuongHieu.Items.AddRange(new object[] {
            "Nike",
            "Adidas",
            "Puma",
            "Asia",
            "Bitit\'s",
            "Converse",
            "Reebok",
            "Vans",
            "Under Armour",
            "Không có"});
            this.cmbThuongHieu.Location = new System.Drawing.Point(146, 227);
            this.cmbThuongHieu.Name = "cmbThuongHieu";
            this.cmbThuongHieu.Size = new System.Drawing.Size(193, 33);
            this.cmbThuongHieu.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(146, 416);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(193, 34);
            this.txtSoLuong.TabIndex = 5;
            // 
            // txtTenGiay
            // 
            this.txtTenGiay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGiay.Location = new System.Drawing.Point(146, 157);
            this.txtTenGiay.Name = "txtTenGiay";
            this.txtTenGiay.Size = new System.Drawing.Size(193, 34);
            this.txtTenGiay.TabIndex = 1;
            // 
            // txtMaGiay
            // 
            this.txtMaGiay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGiay.Location = new System.Drawing.Point(146, 96);
            this.txtMaGiay.Name = "txtMaGiay";
            this.txtMaGiay.Size = new System.Drawing.Size(193, 34);
            this.txtMaGiay.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Màu sắc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên giày:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Size:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hiệu:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã giày:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Bán_Giày.Properties.Resources.logo_search_grid_1x;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 513);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(360, 80);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(360, 83);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập thông tin giày";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ShoeShi Sneakers";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDanhsachGiay);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(962, 515);
            this.panel3.TabIndex = 2;
            // 
            // dgvDanhsachGiay
            // 
            this.dgvDanhsachGiay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhsachGiay.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDanhsachGiay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsachGiay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhsachGiay.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhsachGiay.Name = "dgvDanhsachGiay";
            this.dgvDanhsachGiay.RowHeadersWidth = 51;
            this.dgvDanhsachGiay.RowTemplate.Height = 24;
            this.dgvDanhsachGiay.Size = new System.Drawing.Size(962, 515);
            this.dgvDanhsachGiay.TabIndex = 0;
            this.dgvDanhsachGiay.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhsachGiay_RowEnter);
            // 
            // frmDSGiay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 597);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelButtonGiay);
            this.Controls.Add(this.panel2);
            this.Name = "frmDSGiay";
            this.Text = "frmDSGiay";
            this.Load += new System.EventHandler(this.frmDSGiay_Load);
            this.panelButtonGiay.ResumeLayout(false);
            this.panelButtonGiay.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachGiay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtonGiay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvDanhsachGiay;
        private FontAwesome.Sharp.IconButton btnNhap;
        private FontAwesome.Sharp.IconButton btnGhi;
        private FontAwesome.Sharp.IconButton BtnDoc;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenGiay;
        private System.Windows.Forms.TextBox txtMaGiay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.ComboBox cmbMau;
        private System.Windows.Forms.ComboBox cmbThuongHieu;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}