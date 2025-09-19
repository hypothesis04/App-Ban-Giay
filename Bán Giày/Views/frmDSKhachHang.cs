using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bán_Giày.Views
{
    public partial class frmDSKhachHang : Form
    {
        private CXuLyKhachHang xulyKH;
        private int viTri = -1;
        private IconButton currentBtn;
        private Panel BtnChuyenTrai;
        public frmDSKhachHang()
        {
            InitializeComponent();
            xulyKH = new CXuLyKhachHang();
            BtnChuyenTrai = new Panel();
            BtnChuyenTrai.Size = new Size(7, 60);
            panelButtonNguoiDung.Controls.Add(BtnChuyenTrai);
        }
        private void frmDSKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKhachHang(dgvDanhsachKH, xulyKH.getDanhSachKhachHang());
            if (CTruyCapDuLieu.DocFileKH("khachhang.json"))
            {
                xulyKH = new CXuLyKhachHang();
                HienThiDanhSachKhachHang(dgvDanhsachKH, xulyKH.getDanhSachKhachHang());
            }
            txtMaKH.Focus();
        }
        private bool CheckTextBox(TextBox textBox, string message)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                toolTip1.Show(message, textBox, 0, -20, 2000);
                return true;
            }
            else
            {
                toolTip1.Hide(textBox);
                return false;
            }
        }
        private void DisableButtonNguoiDung()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
                currentBtn.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = System.Drawing.Color.FromArgb(255, 255, 255);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private struct RGBcolors
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(146, 185, 227);
        }
        private void ActiveButtonNguoiDung(object senderBtn, System.Drawing.Color color)
        {
            if (senderBtn != null)
            {
                DisableButtonNguoiDung();
                currentBtn = (IconButton)senderBtn;

                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleRight;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;


                BtnChuyenTrai.Location = new Point(0, currentBtn.Location.Y);
                BtnChuyenTrai.Visible = true;
                BtnChuyenTrai.BringToFront();

            }
        }
        private void resetNhap()
        {
            txtMaKH.Text = "";
            txtHoTen.Text = "";
            if (radioNam.Checked) radioNam.Checked = false;
            if (radioNu.Checked) radioNu.Checked = false;
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }
        private void HienThiDanhSachKhachHang(DataGridView dgv, List<KhachHang> ds)
        {
            dgv.DataSource = null;
            dgv.DataSource = ds.ToList();
            dgv.Refresh();

        }
        private void btnNhapNguoiDung_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(txtMaKH, "Bạn chưa nhập mã khách hàng!")) return;
            if (CheckTextBox(txtHoTen, "Bạn chưa nhập tên!")) return;
            string gioitinh = "";
            if (radioNam.Checked)
            {
                gioitinh = "Nam";
                toolTip1.Hide(grbGioitinh);
            }
            else if (radioNu.Checked)
            {
                gioitinh = "Nu";
                toolTip1.Hide(grbGioitinh);
            }
            else
            {
                toolTip1.Show("Vui lòng chọn giới tính!", grbGioitinh, 0, -20, 2000);
                return;
            }
            if (CheckTextBox(txtEmail, "Bạn chưa nhập email!")) return;
            if (CheckTextBox(txtSDT, "Bạn chưa nhập số điện thoại")) return;
            if (CheckTextBox(txtDiaChi, "Bạn chưa nhập đại chỉ!")) return;

            KhachHang KHmoi = new KhachHang(txtMaKH.Text, txtHoTen.Text, gioitinh, txtSDT.Text, txtEmail.Text, txtDiaChi.Text);
            if (xulyKH.timKH(KHmoi.MaKhachHang) == null)
            {
                xulyKH.ThemKhachHang(KHmoi);
                HienThiDanhSachKhachHang(dgvDanhsachKH, xulyKH.getDanhSachKhachHang());
                luudulieu();
                resetNhap();
            }
            else
            {
                MessageBox.Show("Mã khách hàng " + KHmoi.MaKhachHang + " đã tồn tại. Ko thêm được.");
            }
            ActiveButtonNguoiDung(sender, RGBcolors.color1);
        }
        private void btnSuaThongTinNguoiDung_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(txtMaKH, "Bạn chưa nhập mã khách hàng!")) return;
            if (CheckTextBox(txtHoTen, "Bạn chưa nhập tên!")) return;
            string gioitinh = "";
            if (radioNam.Checked)
            {
                gioitinh = "Nam";
                toolTip1.Hide(grbGioitinh);
            }
            else if (radioNu.Checked)
            {
                gioitinh = "Nu";
                toolTip1.Hide(grbGioitinh);
            }
            else
            {
                toolTip1.Show("Vui lòng chọn giới tính!", grbGioitinh, 0, -20, 2000);
                return;
            }

            if (CheckTextBox(txtEmail, "Bạn chưa nhập email!")) return;
            if (CheckTextBox(txtSDT, "Bạn chưa nhập số điện thoại")) return;
            if (CheckTextBox(txtDiaChi, "Bạn chưa nhập đại chỉ!")) return;


            KhachHang KHsua = new KhachHang(txtMaKH.Text, txtHoTen.Text, gioitinh, txtSDT.Text, txtEmail.Text, txtDiaChi.Text);
            if (xulyKH.timKH(KHsua.MaKhachHang) != null)
            {
                xulyKH.SuaKhachHang(KHsua);
                HienThiDanhSachKhachHang(dgvDanhsachKH, xulyKH.getDanhSachKhachHang());
                luudulieu();
            }
            else
            {
                MessageBox.Show("Mã khách hàng " + KHsua.MaKhachHang + " không tồn tại. Ko sửa được.");
            }
        }
        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(txtMaKH, "Hãy nhập mã khách hàng!!!!")) return;
            string maKH = txtMaKH.Text;
            if (xulyKH.timKH(maKH) != null)
            {
                xulyKH.XoaKhachHang(maKH);
                HienThiDanhSachKhachHang(dgvDanhsachKH, xulyKH.getDanhSachKhachHang());
                ActiveButtonNguoiDung(sender, RGBcolors.color1);
                resetNhap();
            }
            else
            {
                MessageBox.Show("Không tồn tại mã khách hàng " + maKH + "  !!!", "Thông báo");
            }
        }
        private void dgvDanhsachKH_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            string maKH = dgvDanhsachKH.Rows[e.RowIndex].Cells[0].Value.ToString();
            KhachHang ketQuatim = xulyKH.timKH(maKH);
            txtMaKH.Text = ketQuatim.MaKhachHang;
            txtHoTen.Text = ketQuatim.Ten;
            if (ketQuatim.GioiTinh == "Nam")
                radioNam.Checked = true;
            else
                radioNu.Checked = true;
            txtEmail.Text = ketQuatim.Email;
            txtSDT.Text = ketQuatim.SoDienThoai;
            txtDiaChi.Text = ketQuatim.DiaChi;
        }
        private void btnDocFile_Click(object sender, EventArgs e)
        {
            if (xulyKH.getDanhSachKhachHang().Count > 0)
            {
                DialogResult result = MessageBox.Show("Danh sách đang có nội dung, đọc file sẽ ghi đè nội dung lên. Bạn có muốn đọc file!!!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    if (CTruyCapDuLieu.DocFileKH("khachhang.json"))
                    {
                        xulyKH = new CXuLyKhachHang();
                        HienThiDanhSachKhachHang(dgvDanhsachKH, xulyKH.getDanhSachKhachHang());
                        MessageBox.Show("Đọc file thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy file hoặc file rỗng.");
                    }
                    ActiveButtonNguoiDung(sender, RGBcolors.color1);
                }
                else { return; }
            }
            else
            {
                if (CTruyCapDuLieu.DocFileKH("khachhang.json"))
                {
                    xulyKH = new CXuLyKhachHang();
                    HienThiDanhSachKhachHang(dgvDanhsachKH, xulyKH.getDanhSachKhachHang());
                    MessageBox.Show("Đọc file thành công.");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy file hoặc file rỗng.");
                }
                ActiveButtonNguoiDung(sender, RGBcolors.color1);
            }

        }
        private void luudulieu()
        {
            string filePathKhachHang = "khachhang.json";
            if (CTruyCapDuLieu.GhiFileKH(filePathKhachHang))
            {

            }
        }
        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            string filePathKhachHang = "khachhang.json";

            if (File.Exists(filePathKhachHang))
            {
                DialogResult KetQua = MessageBox.Show("Dữ liệu hiện tại sẽ bị mất. Bạn có muốn ghi đè file đó không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (KetQua == DialogResult.No)
                    return;
            }

            if (CTruyCapDuLieu.GhiFileKH(filePathKhachHang))
            {
                MessageBox.Show("Ghi file thành công.");
            }
            else
            {
                MessageBox.Show("Ghi file thất bại.");
            }
            ActiveButtonNguoiDung(sender, RGBcolors.color1);
        }

        private void panelButtonNguoiDung_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

