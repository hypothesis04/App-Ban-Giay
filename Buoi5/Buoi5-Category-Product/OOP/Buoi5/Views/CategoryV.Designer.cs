namespace Buoi5
{
    partial class CategoryV
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnThem = new Button();
            txtMa = new TextBox();
            groupBox1 = new GroupBox();
            btnThoat = new Button();
            dtpNgayTao = new DateTimePicker();
            lstDanhMuc = new ListBox();
            label3 = new Label();
            label2 = new Label();
            txtTimKiem = new TextBox();
            txtTen = new TextBox();
            btnTimKiem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(45, 21);
            label1.Name = "label1";
            label1.Size = new Size(32, 21);
            label1.TabIndex = 0;
            label1.Text = "Mã";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(192, 255, 192);
            btnThem.FlatStyle = FlatStyle.Popup;
            btnThem.Font = new Font("Segoe UI Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.Red;
            btnThem.Image = Buoi51.Properties.Resources.icons8_add_20;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(37, 7);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(138, 34);
            btnThem.TabIndex = 4;
            btnThem.Text = "&Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(134, 23);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(199, 23);
            txtMa.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(lstDanhMuc);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(747, 369);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh mục";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(192, 255, 192);
            btnThoat.FlatStyle = FlatStyle.Popup;
            btnThoat.Location = new Point(216, 59);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(138, 35);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.Location = new Point(133, 88);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(200, 23);
            dtpNgayTao.TabIndex = 2;
            // 
            // lstDanhMuc
            // 
            lstDanhMuc.Dock = DockStyle.Bottom;
            lstDanhMuc.FormattingEnabled = true;
            lstDanhMuc.ItemHeight = 15;
            lstDanhMuc.Location = new Point(3, 182);
            lstDanhMuc.Name = "lstDanhMuc";
            lstDanhMuc.Size = new Size(741, 184);
            lstDanhMuc.TabIndex = 8;
            lstDanhMuc.SelectedIndexChanged += lstDanhMuc_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(45, 88);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 0;
            label3.Text = "Ngày tạo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(45, 56);
            label2.Name = "label2";
            label2.Size = new Size(33, 21);
            label2.TabIndex = 0;
            label2.Text = "Tên";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(37, 125);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(166, 23);
            txtTimKiem.TabIndex = 3;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(134, 57);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(199, 23);
            txtTen.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = Buoi51.Properties.Resources.icons8_search_20;
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.Location = new Point(216, 119);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(138, 32);
            btnTimKiem.TabIndex = 7;
            btnTimKiem.Text = "&Find";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(192, 255, 192);
            btnSua.FlatStyle = FlatStyle.Popup;
            btnSua.Image = Buoi51.Properties.Resources.icons8_edit_20;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(37, 59);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(138, 35);
            btnSua.TabIndex = 6;
            btnSua.Text = "&Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(192, 255, 192);
            btnXoa.FlatStyle = FlatStyle.Popup;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.FromArgb(192, 192, 0);
            btnXoa.Image = Buoi51.Properties.Resources.icons8_remove_20;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(216, 9);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(138, 33);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "&Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtTimKiem);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(381, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 163);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(dtpNgayTao);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtTen);
            panel2.Controls.Add(txtMa);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(378, 163);
            panel2.TabIndex = 11;
            // 
            // CategoryV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 369);
            Controls.Add(groupBox1);
            Name = "CategoryV";
            Text = "Danh Mục";
            Load += CategoryV_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnThem;
        private TextBox txtMa;
        private GroupBox groupBox1;
        private ListBox lstDanhMuc;
        private Label label2;
        private Button btnTimKiem;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtTimKiem;
        private TextBox txtTen;
        private DateTimePicker dtpNgayTao;
        private Label label3;
        private Button btnThoat;
        private Panel panel1;
        private Panel panel2;
    }
}
