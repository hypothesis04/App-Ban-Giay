using Bán_Giày.Models;
using Bán_Giày.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bán_Giày.Views
{
    public partial class frmThongKe : Form
    {
        private CXuLyThongKe thongke;
        private CXuLyKhachHang khachhangs;
        private CXuLyHoaDon hoadons;
        private CXuLyGiay giays;

        // Các danh sách lưu trữ dữ liệu
        private List<HoaDon> danhSachHoaDon;
        private List<Giay> danhSachGiay;
        private List<KhachHang> danhSachKhachHang;

        public frmThongKe()
        {
            InitializeComponent();


            //settings Maximum
            this.AutoScaleMode = AutoScaleMode.Dpi;
       
            // Khởi tạo các đối tượng xử lý
            khachhangs = new CXuLyKhachHang();
            hoadons = new CXuLyHoaDon();
            giays = new CXuLyGiay();
            
            danhSachGiay = giays.getDanhSachGiay();
            danhSachHoaDon = hoadons.getDanhSachHoaDon();
            danhSachKhachHang = khachhangs.getDanhSachKhachHang();

            // Khởi tạo đối tượng thongke với dữ liệu
            thongke = new CXuLyThongKe(danhSachHoaDon, danhSachGiay, danhSachKhachHang, new List<ThongKe>());
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (danhSachHoaDon == null || danhSachHoaDon.Count == 0)
                MessageBox.Show("Danh sách hóa đơn trống!");
            if (danhSachGiay == null || danhSachGiay.Count == 0)
                MessageBox.Show("Danh sách giày trống!");
            if (danhSachKhachHang == null || danhSachKhachHang.Count == 0)
                MessageBox.Show("Danh sách khách hàng trống!");

            // Cập nhật thông tin thống kê
            lblSoLuongDonHang.Text = thongke.ThongKeSoLuongDonHang().ToString();
            lblSoLuongKhachHang.Text = thongke.ThongKeSoLuongKhachHang().ToString();
            lblTongDoanhThu.Text = thongke.ThongKeDoanhThu();
            lblSoLuongBanRa.Text = thongke.ThongKeSoLuongGiayBan().ToString();
            lblSoLuongConLai.Text = thongke.ThongKeSoLuongGiayConLai().ToString();

            // Thống kê các hãng yêu thích
            var hangYeuThichDanhSach = thongke.ThongKeHangGiayTheoSoLuongBan();

            // Lấy 5 hãng giày bán chạy nhất
            var top5HangYeuThich = hangYeuThichDanhSach.OrderByDescending(item => item.Value)
                                                        .Take(5)
                                                        .ToList();
       
            if (hangYeuThichDanhSach.Count > 5)
            {
                var otherBrands = hangYeuThichDanhSach.Skip(5)
                                                       .Select(item => item.Key)
                                                       .ToList();
                top5HangYeuThich.Add(new KeyValuePair<string, int>("Khác", otherBrands.Count));
            }

            // Hiển thị các hãng bán chạy nhất
            lblHangYeuThichNhat.Text = string.Join(", ", top5HangYeuThich.Select(item => item.Key));

            // Tìm hãng yêu thích nhất (số lượng bán cao nhất) - chỉ lấy hãng bán chạy nhất
            var hangYeuThichNhat = hangYeuThichDanhSach.OrderByDescending(item => item.Value).FirstOrDefault();
            if (hangYeuThichNhat.Key != null)
            {
                // Chỉ hiển thị tên hãng bán chạy nhất
                lblHangYeuThichNhat.Text = hangYeuThichNhat.Key;
            }

            // Cập nhật biểu đồ doanh thu theo ngày
            var doanhThuTheoNgay = thongke.ThongKeDoanhThuTheoNgay();
            chartTongDoanhThu.Series[0].Points.Clear();
            foreach (var item in doanhThuTheoNgay)
            {
                // Thêm dữ liệu doanh thu vào biểu đồ theo ngày
                chartTongDoanhThu.Series[0].Points.AddXY(item.Key.ToShortDateString(), item.Value);
                chartTongDoanhThu.ChartAreas[0].AxisX.Interval = 1; // Hiển thị tất cả các cột
            }

            // Cập nhật biểu đồ giày bán theo thương hiệu
            var hangGiayTheoSoLuongBan = thongke.ThongKeHangGiayTheoSoLuongBan();
            chartHangBanChay.Series[0].Points.Clear();
            foreach (var item in hangGiayTheoSoLuongBan)
            {
                // Thêm dữ liệu giày bán theo thương hiệu vào biểu đồ
                chartHangBanChay.Series[0].Points.AddXY(item.Key, item.Value);
            }

            // Refresh biểu đồ
            chartTongDoanhThu.Refresh();
            chartHangBanChay.Refresh();
        }


        //Maximize & Restore "Event"
        const int WM_SYSCOMMAND = 0x0112;
        const int SC_MAXIMIZE = 0xF030;
        const int SC_RESTORE = 0xF120;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_SYSCOMMAND)
            {
                if (m.WParam == (IntPtr)SC_MAXIMIZE || m.WParam == (IntPtr)SC_RESTORE)
                    this.OnResizeEnd(EventArgs.Empty);
            }
        }

        private void lblHangYeuThichNhat_Click(object sender, EventArgs e)
        {

        }
    }
}
