namespace Buoi5.Views
{
    partial class ProductV
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
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnSua = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            btnThem = new Button();
            dtpHanDung = new DateTimePicker();
            cmbDanhMuc = new ComboBox();
            dgvSanPham = new DataGridView();
            btnDanhMuc = new Button();
            txtGia = new TextBox();
            txtTen = new TextBox();
            label6 = new Label();
            txtMa = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 255, 255);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(dtpHanDung);
            groupBox1.Controls.Add(cmbDanhMuc);
            groupBox1.Controls.Add(dgvSanPham);
            groupBox1.Controls.Add(btnDanhMuc);
            groupBox1.Controls.Add(txtGia);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(731, 428);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản Phẩm";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(btnThem);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(452, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 187);
            panel1.TabIndex = 11;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.FromArgb(192, 255, 192);
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(21, 97);
            button4.Name = "button4";
            button4.Size = new Size(106, 36);
            button4.TabIndex = 10;
            button4.Text = "Xóa";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(192, 255, 192);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(159, 97);
            button3.Name = "button3";
            button3.Size = new Size(108, 36);
            button3.TabIndex = 9;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(159, 53);
            button2.Name = "button2";
            button2.Size = new Size(108, 36);
            button2.TabIndex = 9;
            button2.Text = "Load File";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(159, 11);
            button1.Name = "button1";
            button1.Size = new Size(108, 36);
            button1.TabIndex = 9;
            button1.Text = "Ghi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.BackColor = Color.FromArgb(192, 255, 192);
            btnSua.FlatStyle = FlatStyle.Popup;
            btnSua.Location = new Point(21, 57);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(106, 32);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.Location = new Point(177, 155);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(91, 23);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.Location = new Point(21, 156);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(150, 23);
            txtTimKiem.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.BackColor = Color.FromArgb(192, 255, 192);
            btnThem.FlatStyle = FlatStyle.Popup;
            btnThem.Location = new Point(21, 11);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(106, 36);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dtpHanDung
            // 
            dtpHanDung.Anchor = AnchorStyles.None;
            dtpHanDung.Location = new Point(115, 139);
            dtpHanDung.Name = "dtpHanDung";
            dtpHanDung.Size = new Size(331, 23);
            dtpHanDung.TabIndex = 3;
            // 
            // cmbDanhMuc
            // 
            cmbDanhMuc.Anchor = AnchorStyles.None;
            cmbDanhMuc.FormattingEnabled = true;
            cmbDanhMuc.Location = new Point(115, 177);
            cmbDanhMuc.Name = "cmbDanhMuc";
            cmbDanhMuc.Size = new Size(225, 23);
            cmbDanhMuc.TabIndex = 4;
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Dock = DockStyle.Bottom;
            dgvSanPham.Location = new Point(3, 206);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.Size = new Size(725, 219);
            dgvSanPham.TabIndex = 8;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // btnDanhMuc
            // 
            btnDanhMuc.Anchor = AnchorStyles.None;
            btnDanhMuc.Location = new Point(345, 176);
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Size = new Size(101, 23);
            btnDanhMuc.TabIndex = 2;
            btnDanhMuc.Text = "...";
            btnDanhMuc.UseVisualStyleBackColor = true;
            btnDanhMuc.Click += btnDanhMuc_Click;
            // 
            // txtGia
            // 
            txtGia.Anchor = AnchorStyles.None;
            txtGia.Location = new Point(115, 101);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(331, 23);
            txtGia.TabIndex = 2;
            // 
            // txtTen
            // 
            txtTen.Anchor = AnchorStyles.None;
            txtTen.Location = new Point(115, 63);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(331, 23);
            txtTen.TabIndex = 1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(11, 177);
            label6.Name = "label6";
            label6.Size = new Size(81, 21);
            label6.TabIndex = 0;
            label6.Text = "Danh mục";
            // 
            // txtMa
            // 
            txtMa.Anchor = AnchorStyles.None;
            txtMa.Location = new Point(115, 30);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(331, 23);
            txtMa.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 140);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 0;
            label5.Text = "Hạn Dùng";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 140);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 0;
            label4.Text = "label1";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(33, 21);
            label3.TabIndex = 0;
            label3.Text = "Giá";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(33, 21);
            label2.TabIndex = 0;
            label2.Text = "Tên";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(32, 21);
            label1.TabIndex = 0;
            label1.Text = "Mã";
            // 
            // ProductV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 428);
            Controls.Add(groupBox1);
            Name = "ProductV";
            Text = "Sản Phẩm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbDanhMuc;
        private DataGridView dgvSanPham;
        private Button btnThem;
        private TextBox txtGia;
        private TextBox txtTen;
        private Label label6;
        private TextBox txtMa;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDanhMuc;
        private Button btnTimKiem;
        private Button btnSua;
        private DateTimePicker dtpHanDung;
        private TextBox txtTimKiem;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Panel panel1;
    }
}