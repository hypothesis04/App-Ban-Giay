using Bán_Giày.Models;
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
    public partial class frmDSHoaDon : Form
    {
        TempGioHang dsgh = new TempGioHang();
        private CXuLyHoaDon xulyHD;
        private CXuLyGiay xulyGiay;
        private CXuLyKhachHang xulyKH;
        private int viTri = -1;
        private string MAINHOADON = string.Empty;       
        private IconButton currentBtn;
        private Panel BtnChuyenTrai;
        private CXuLyGioHang xulyGioHang;
        private List<Giay> giay;

        public frmDSHoaDon()
        {
            InitializeComponent();
            xulyHD = new CXuLyHoaDon();
            xulyGiay = new CXuLyGiay();
            xulyKH = new CXuLyKhachHang();
            xulyGioHang = new CXuLyGioHang();
            giay = xulyGiay.getDanhSachGiay();
            BtnChuyenTrai = new Panel();
            BtnChuyenTrai.Size = new Size(7, 60);
            panelButtonHoaDon.Controls.Add(BtnChuyenTrai);
        }
        private void frmDSHoaDon_Load(object sender, EventArgs e)
        {
            List<HoaDon> dshoadon = xulyHD.getDanhSachHoaDon();
            List<Giay> dsGiay = xulyGiay.getDanhSachGiay();
            List<KhachHang> dsKH = xulyKH.getDanhSachKhachHang();
            HienThiDanhSachHoaDon(dgvDanhsachHoaDon, dshoadon);
            cmbMaKH_NHD.DataSource = dsKH;
            cmbMaKH_NHD.DisplayMember = "MaKhachHang";
            cmbMaGiay_NHD.DataSource = dsGiay;
            cmbMaGiay_NHD.DisplayMember = "MaGiay";
            cmbMaGiay_NHD.SelectedIndex = -1;
            cmbMaKH_NHD.SelectedIndex = -1;
            if (CTruyCapDuLieu.DocFileHD("hoadon.json"))
            {
                xulyHD = new CXuLyHoaDon();
            }
            if (CTruyCapDuLieu.DocFileGH("giohang.json"))
            {
                xulyGioHang = new CXuLyGioHang();
                HienThiDanhSachHoaDon(dgvDanhsachHoaDon, xulyHD.getDanhSachHoaDon());
            }
        }


        private void DisableButtonHoaDon()
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

        private void ActiveButtonHoaDon(object senderBtn, System.Drawing.Color color)
        {
            if (senderBtn != null)
            {
                DisableButtonHoaDon();
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

        private void TinhTongTien()
        {
            int soLuong;
            decimal donGia;
            if (int.TryParse(txtSoluong.Text, out soLuong) &&
                decimal.TryParse(txtDongia.Text, out donGia))
            {
                decimal tongTien = soLuong * donGia;
                lbTongtien.Text = tongTien.ToString();
            }
            else
            {
                lbTongtien.Text = "0";
            }
        }
        private void HienThiDanhSachHoaDon(DataGridView dgv, List<HoaDon> ds)
        {
            dgv.DataSource = null;
            dgv.DataSource = ds.ToList();
            dgv.Refresh();
        }
        private void txtDongiaNhaphoadon_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }
        private void txtSoluongNhaphoadon_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
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
        private bool CheckComboBox(ComboBox comboBox, string message)
        {
            if (comboBox.SelectedIndex == -1)
            {
                toolTip1.Show(message, comboBox, 0, -20, 2000);
                return true;
            }
            else
            {
                toolTip1.Hide(comboBox);
                return false;
            }
        }
        private bool CheckTextBoxint(TextBox textBox, string message)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                toolTip1.Show(message, textBox, 0, -20, 2000);
                return true;
            }
            else if (!int.TryParse(textBox.Text, out int quantity) || quantity <= 0)
            {
                toolTip1.Show("Hãy Nhập số nguyên và lớn hơn 0!", textBox, 0, -20, 2000);
                return true;
            }
            else
            {
                toolTip1.Hide(textBox);
                return false;
            }
        }
        private bool CheckTextBoxSo(TextBox textBox, string message)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                toolTip1.Show(message, textBox, 0, -20, 2000);
                return true;
            }
            else if (!float.TryParse(textBox.Text, out float quantity) || quantity <= 0)
            {
                toolTip1.Show("Hãy Nhập số lớn hơn 0!", textBox, 0, -20, 2000);
                return true;
            }
            else
            {
                toolTip1.Hide(textBox);
                return false;
            }
        }
        public void resetNhap()
        {

            cmbMaKH_NHD.SelectedIndex = -1;
            txtMaHD.Text = "";
        }
        public void resetXoa()
        {
            lbNgayBanTT.Text = "Ngày bán";
            lbSDTTT.Text = "Số điện thoại";
            lbMakhTT.Text = "Mã khách hàng";
            lbMahdTT.Text = "Mã hoá đơn";
            lbNgayBanTT.Text = "Ngày bán";
            lbtongtienTT.Text = "Tổng tiền";
            lbTenkhTT.Text = "Tên khách hàng";
            lbDiaChiTT.Text = "Địa chỉ";
        }

        private void btnNhapThongTinHoaDon_Click(object sender, EventArgs e)
        {
            if (CheckComboBox(cmbMaKH_NHD, "Bạn chưa chọn mã khách hàng!")) return;
            if (dsgh.ktgiohang()) { MessageBox.Show("Giỏ hàng trống"); return; }
            if (CheckTextBox(txtMaHD, "Bạn chưa nhập mã hoá đơn!")) return;
            string ListMa = dsgh.ListMaGiay();
            decimal Tong = dsgh.TongTien();
            HoaDon hdmoi = new HoaDon(txtMaHD.Text, ListMa, cmbMaKH_NHD.Text, Tong.ToString(), dtpNgayBan.Value);
            if (xulyHD.timHD(hdmoi.MaHoaDon) == null)
            {
                xulyHD.ThemHoaDon(hdmoi);
                ActiveButtonHoaDon(sender, RGBcolors.color1);
                dsgh.xulyBAN();
                dsgh.ThemGH(txtMaHD.Text);
                xulyGioHang = new CXuLyGioHang();
                dsgh.resetGioHang();
                dsgh.HienThiDanhSachGioHang(dgvGioHang);
                HienThiDanhSachHoaDon(dgvDanhsachHoaDon, xulyHD.getDanhSachHoaDon());
                luudulieu();
                resetNhap();
            }
            else
            {
                MessageBox.Show("Mã hoá đơn " + hdmoi.MaHoaDon + " đã tồn tại. Ko thêm được.");
            }

        }
        private void btnSuaThongTinHoaDon_Click(object sender, EventArgs e)
        {
            if (CheckComboBox(cmbMaKH_NHD, "Bạn chưa chọn mã khách hàng!")) return;
            if (dsgh.ktgiohang()) { MessageBox.Show("Giỏ hàng trống không thể sửa"); return; }
            if (CheckTextBox(txtMaHD, "Bạn chưa nhập mã hoá đơn!")) return;
            string ListMa = dsgh.ListMaGiay();
            decimal Tong = dsgh.TongTien();
            HoaDon hdmoi = new HoaDon(txtMaHD.Text, ListMa, cmbMaKH_NHD.Text, Tong.ToString(), dtpNgayBan.Value);
            if (xulyHD.timHD(hdmoi.MaHoaDon) != null)
            {
                xulyHD.SuaHoaDon(hdmoi);
                ActiveButtonHoaDon(sender, RGBcolors.color1);
                dsgh.suaGH(txtMaHD.Text);
                dsgh.resetGioHang();
                xulyGioHang = new CXuLyGioHang();
                dsgh.HienThiDanhSachGioHang(dgvGioHang);
                HienThiDanhSachHoaDon(dgvDanhsachHoaDon, xulyHD.getDanhSachHoaDon());
                luudulieu();
                resetNhap();
            }
            else
            {
                MessageBox.Show("Mã hoá đơn " + hdmoi.MaHoaDon + " không tồn tại. Ko sửa được.");
            }
        }

        private void btnXoaThongTinHoaDon_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(txtMaHD, "Hãy nhập mã hoá đơn!!!!")) return;
            string mahd = txtMaHD.Text;
            if (xulyHD.timHD(mahd) != null)
            {
                xulyGioHang.Xoa(mahd);
                xulyHD.XoaHoaDon(mahd);
                dsgh.resetGioHang();
                HienThiDanhSachHoaDon(dgvDanhsachHoaDon, xulyHD.getDanhSachHoaDon());
                dsgh.HienThiDanhSachGioHang(dgvGioHang);
                ActiveButtonHoaDon(sender, RGBcolors.color1);
                resetXoa();
            }
            else
            {
                MessageBox.Show("Không tồn tại mã hoá đơn " + mahd + "  !!!", "Thông báo");
            }    
        }
        private void dgvDanhsachHoaDon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dsgh.resetGioHang();
            if (e.RowIndex < 0)
            {
                dsgh.HienThiDanhSachGioHang(dgvGioHang); return;
            }
            string mahd = dgvDanhsachHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString();
            MAINHOADON = mahd;
            HoaDon ketQuatim = xulyHD.timHD(mahd);
            lbMakhTT.Text = cmbMaKH_NHD.Text = ketQuatim.MaKhachHang;
            lbMahdTT.Text = txtMaHD.Text = ketQuatim.MaHoaDon;
            lbNgayBanTT.Text = ketQuatim.NgayBan.ToString();
            float TongTien = 0;
            TongTien = float.Parse(ketQuatim.TongTien);
            lbtongtienTT.Text = TongTien.ToString("N0") + " VNĐ";
            string makh = ketQuatim.MaKhachHang;
            KhachHang KH = xulyKH.timKH(makh);
            if (KH != null)
            {
                lbTenkhTT.Text = KH.Ten;
                lbSDTTT.Text = KH.SoDienThoai;
                lbDiaChiTT.Text = KH.DiaChi;
            }
            GioHang gioHang = xulyGioHang.timGioHang(mahd);
            string[] lines = gioHang.ThongTin.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                string[] danhSachMaGiay = line.Split(';');
                if (danhSachMaGiay.Length == 4)
                {
                    ListGioHang p = new ListGioHang();
                    p.MaGiay = danhSachMaGiay[0];
                    p.Ten = danhSachMaGiay[1];
                    p.SoLuong = int.Parse(danhSachMaGiay[2]);
                    p.DonGia = decimal.Parse(danhSachMaGiay[3]);
                    dsgh.Them(p);
                }
            }

            dsgh.HienThiDanhSachGioHang(dgvGioHang);
        }

        public void resetGH()
        {
            cmbMaGiay_NHD.SelectedIndex = -1;
            txtDongia.Text = "";
            txtSoluong.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckComboBox(cmbMaGiay_NHD, "Bạn chưa chọn mã giày!")) return;
            if (CheckTextBoxint(txtSoluong, "Bạn chưa nhập mã số lượng!")) return;
            if (CheckTextBoxSo(txtDongia, "Bạn chưa nhập đơn giá!")) return;
            if (dsgh.kiemtra(cmbMaGiay_NHD.Text)) { MessageBox.Show("Trùng mã giày!!!", "Thông báo"); return; }
            Giay Giay = xulyGiay.timGiay(cmbMaGiay_NHD.Text);
            if (Giay.SoLuong < int.Parse(txtSoluong.Text))
            {
                MessageBox.Show("Số lượng của mã giày không đủ!!!");
                return;
            }
            ListGioHang gh = new ListGioHang();
            gh.Ten = Giay.Ten;
            gh.MaGiay = Giay.MaGiay;
            gh.SoLuong = int.Parse(txtSoluong.Text);
            gh.DonGia = decimal.Parse(txtDongia.Text);
            dsgh.Them(gh);
            dsgh.HienThiDanhSachGioHang(dgvGioHang);
            resetGH();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckComboBox(cmbMaGiay_NHD, "Bạn chưa chọn mã giày!")) return;
            if (dsgh.tontai(cmbMaGiay_NHD.Text) == false) { MessageBox.Show("Không có mã giày < " + cmbMaGiay_NHD.Text + " > trong giỏ hàng!!"); return; }
            if (CheckTextBoxint(txtSoluong, "Bạn chưa nhập mã số lượng!")) return;
            if (CheckTextBoxSo(txtDongia, "Bạn chưa nhập đơn giá!")) return;
            ListGioHang gh = new ListGioHang();
            gh.SoLuong = int.Parse(txtSoluong.Text);
            gh.DonGia = decimal.Parse(txtDongia.Text);
            Giay Giay = xulyGiay.timGiay(cmbMaGiay_NHD.Text);
            gh.Ten = Giay.Ten;
            dsgh.Sua(gh, Giay.MaGiay);
            dsgh.HienThiDanhSachGioHang(dgvGioHang);
            luudulieu();
            resetGH();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CheckComboBox(cmbMaGiay_NHD, "Bạn chưa chọn mã giày!")) return;
            if (dsgh.tontai(cmbMaGiay_NHD.Text) == false) { MessageBox.Show("Không có mã giày < " + cmbMaGiay_NHD.Text + " > trong giỏ hàng!!"); return; }
            dsgh.Xoa(cmbMaGiay_NHD.Text);
            dsgh.HienThiDanhSachGioHang(dgvGioHang);
        }

        private void btnDocFileHoaDon_Click(object sender, EventArgs e)
        {
            if (xulyHD.getDanhSachHoaDon().Count > 0)
            {
                DialogResult result = MessageBox.Show("Danh sách đang có nội dung, đọc file sẽ ghi đè nội dung lên. Bạn có muốn đọc file!!!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    if (CTruyCapDuLieu.DocFileHD("hoadon.json"))
                    {
                        xulyHD = new CXuLyHoaDon();
                        MessageBox.Show("Đọc file hóa đơn thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy file hoặc file rỗng.");
                    }
                    if (CTruyCapDuLieu.DocFileGH("giohang.json"))
                    {
                        xulyGioHang = new CXuLyGioHang();
                        HienThiDanhSachHoaDon(dgvDanhsachHoaDon, xulyHD.getDanhSachHoaDon());
                        MessageBox.Show("Đọc file giỏ hàng thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy file hoặc file rỗng.");
                    }
                    ActiveButtonHoaDon(sender, RGBcolors.color1);
                }
                else { return; }
            }
            else
            {
                if (CTruyCapDuLieu.DocFileHD("hoadon.json"))
                {
                    xulyHD = new CXuLyHoaDon();
                    MessageBox.Show("Đọc file hóa đơn thành công.");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy file hoặc file rỗng.");
                }
                if (CTruyCapDuLieu.DocFileGH("giohang.json"))
                {
                    xulyGioHang = new CXuLyGioHang();
                    HienThiDanhSachHoaDon(dgvDanhsachHoaDon, xulyHD.getDanhSachHoaDon());
                    MessageBox.Show("Đọc file giỏ hàng thành công.");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy file hoặc file rỗng.");
                }

                ActiveButtonHoaDon(sender, RGBcolors.color1);
            }
        }
        public void luudulieu()
        {
            string filePathHoaDon = "hoadon.json";

            if (CTruyCapDuLieu.GhiFileHD(filePathHoaDon))
            {

            }
            string filePathGioHang = "giohang.json";
            if (CTruyCapDuLieu.GhiFileGH(filePathGioHang))
            {

            }
        }
        private void btnGhiFileHoaDon_Click(object sender, EventArgs e)
        {
            string filePathHoaDon = "hoadon.json";
            string filePathGioHang = "giohang.json";
            if (File.Exists(filePathHoaDon))
            {
                DialogResult KetQua = MessageBox.Show("Dữ liệu hiện tại sẽ bị mất. Bạn có muốn ghi đè lên file đó không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (KetQua == DialogResult.No)
                    return;
            }
            if (CTruyCapDuLieu.GhiFileHD(filePathHoaDon))
            {
                MessageBox.Show("Ghi file hóa đơn thành công.");
            }
            else
            {
                MessageBox.Show("Ghi file hóa đơn thất bại.");
            }
            if (CTruyCapDuLieu.GhiFileGH(filePathGioHang))
            {
                MessageBox.Show("Ghi file giỏ hàng thành công.");
            }
            else
            {
                MessageBox.Show("Ghi file giỏ hàng thất bại.");
            }

            ActiveButtonHoaDon(sender, RGBcolors.color1);
        }

        private void dgvGioHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string magiay = dgvGioHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            ListGioHang view = dsgh.tim(magiay);
            cmbMaGiay_NHD.Text = view.MaGiay;
            txtSoluong.Text = view.SoLuong.ToString();
            txtDongia.Text = view.DonGia.ToString();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            string SanPham = string.Empty;
            string SL = string.Empty;
            string DonGia = string.Empty;
            string Tong = string.Empty;
            GioHang gioHang = xulyGioHang.timGioHang(MAINHOADON);
            string[] lines = gioHang.ThongTin.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                string[] danhSachMaGiay = line.Split(';');
                if (danhSachMaGiay.Length == 4)
                {
                    decimal tinhtong = 0;
                    SanPham += danhSachMaGiay[1] + "\n" + "\n";
                    SL += danhSachMaGiay[2] + "\n" + "\n";
                    DonGia += danhSachMaGiay[3] + "\n" + "\n";
                    tinhtong = int.Parse(danhSachMaGiay[2]) * decimal.Parse(danhSachMaGiay[3]);
                    Tong += tinhtong.ToString() + "\n" + "\n";
                }
            }
            frmInHoaDon inhoadon = new frmInHoaDon();
            inhoadon.MaHD = lbMahdTT.Text;
            inhoadon.DiaChi = lbDiaChiTT.Text;
            inhoadon.SoDienThoai = lbSDTTT.Text;
            inhoadon.NgayBan = lbNgayBanTT.Text;
            inhoadon.SanPham = SanPham;
            inhoadon.SL = SL;
            inhoadon.DonGia = DonGia;
            inhoadon.Tong = Tong;
            inhoadon.TenKH = lbTenkhTT.Text;
            inhoadon.TongTien = lbtongtienTT.Text;
            inhoadon.Show();
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            dsgh.resetGioHang();
            resetGH();
            dsgh.HienThiDanhSachGioHang(dgvGioHang);
        }
    }
}
