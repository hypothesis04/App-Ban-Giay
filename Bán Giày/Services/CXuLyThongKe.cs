using Bán_Giày.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bán_Giày.Services
{
    [Serializable]
    internal class CXuLyThongKe
    {
        private List<HoaDon> danhSachHoaDon;
        private List<Giay> danhSachGiay;
        private List<KhachHang> danhSachKhachHang;
        private List<ThongKe> danhSachThongKe;

        // Constructor với tham số
        public CXuLyThongKe(List<HoaDon> hoaDons, List<Giay> giays, List<KhachHang> khachHangs,List<ThongKe> thongKes)
        {
            danhSachHoaDon = hoaDons ?? new List<HoaDon>();
            danhSachGiay = giays ?? new List<Giay>();
            danhSachKhachHang = khachHangs ?? new List<KhachHang>();
            danhSachThongKe = thongKes ?? new List<ThongKe>();
        }

        // Thống kê tổng doanh thu
        public string ThongKeDoanhThu()
        {
            decimal doanhThu = danhSachHoaDon.Sum(hoadon =>
            {
                if (decimal.TryParse(hoadon.TongTien.ToString(), out decimal tongTien))
                {
                    return tongTien;
                }
                return 0;
            });

            return doanhThu.ToString("N0"); // Format kiểu "1,000,000"
        }

        public int ThongKeSoLuongDonHang()
        {
            return danhSachHoaDon.Count; // Đếm số lượng hóa đơn (đơn hàng)
        }

        // Thống kê số lượng giày bán ra
        public int ThongKeSoLuongGiayBan()
        {
            return danhSachGiay.Sum(giay => giay.SoLuongBan);
        }

        // Thống kê số lượng khách hàng
        public int ThongKeSoLuongKhachHang()
        {
            return danhSachKhachHang.Count;
        }

        // Thống kê giày bán chạy nhất theo thương hiệu
        public string ThongKeHangBanChayNhat()
        {
            var thongKe = danhSachGiay
                .GroupBy(giay => giay.ThuongHieu)
                .OrderByDescending(group => group.Sum(giay => giay.SoLuongBan))
                .FirstOrDefault();

            return thongKe?.Key ?? "Không có dữ liệu";
        }

        // Thống kê số lượng giày còn lại
        public int ThongKeSoLuongGiayConLai()
        {
            return danhSachGiay.Sum(giay => giay.SoLuong);
        }

        // Lấy dữ liệu doanh thu theo từng ngày để vẽ biểu đồ
        public Dictionary<DateTime, decimal> ThongKeDoanhThuTheoNgay()
        {
            return danhSachHoaDon
                .GroupBy(hoadon => hoadon.NgayBan.Date)
                .ToDictionary(
                    group => group.Key,
                    group => group.Sum(hoadon =>
                    {
                        if (decimal.TryParse(hoadon.TongTien.ToString(), out decimal tongTien))
                        {
                            return tongTien;
                        }
                        return 0;
                    })
                );
        }

        // Lấy dữ liệu bán hàng theo thương hiệu để vẽ biểu đồ
        public Dictionary<string, int> ThongKeHangGiayTheoSoLuongBan()
        {
            return danhSachGiay
                .GroupBy(giay => giay.ThuongHieu)
                .ToDictionary(
                    group => group.Key,
                    group => group.Sum(giay => giay.SoLuongBan)
                );
        }

        // Thống kê doanh thu theo tháng
        public Dictionary<int, decimal> ThongKeDoanhThuTheoThang()
        {
            return danhSachHoaDon
                .GroupBy(hoadon => hoadon.NgayBan.Month)
                .ToDictionary(
                    group => group.Key,
                    group => group.Sum(hoadon =>
                    {
                        if (decimal.TryParse(hoadon.TongTien.ToString(), out decimal tongTien))
                        {
                            return tongTien;
                        }
                        return 0;
                    })
                );
        }
    }
}
