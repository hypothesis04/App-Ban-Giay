using System;

namespace Bán_Giày.Models
{
    internal class ThongKe
    {

        private int soLuongDonHang;
        private int soLuongKhachHang;
        private float doanhThu;
        private int soLuongBanRa;
        private int soLuongConLai;
        private string hangYeuThichNhat;
        private Giay dsGiay;
        private HoaDon dsHoaDon;
        private KhachHang dsKhachHang;

        public int SoLuongDonHang { get => soLuongDonHang; set => soLuongDonHang = value; }
        public int SoLuongKhachHang { get => soLuongKhachHang; set => soLuongKhachHang = value; }
        public float DoanhThu { get => doanhThu; set => doanhThu = value; }
        public int SoLuongBanRa { get => soLuongBanRa; set => soLuongBanRa = value; }
        public int SoLuongConLai { get => soLuongConLai; set => soLuongConLai = value; }
        public string HangYeuThichNhat { get => hangYeuThichNhat; set => hangYeuThichNhat = value; }

        public ThongKe(int soLuongDonHang, int soLuongKhachHang, float doanhThu, int soLuongBanRa, int soLuongConLai, string hangYeuThichNhat, Giay dsGiay, HoaDon dsHoaDon, KhachHang dsKhachHang)
        {
            this.SoLuongDonHang = soLuongDonHang;
            this.SoLuongKhachHang = soLuongKhachHang;
            this.DoanhThu = doanhThu;
            this.SoLuongBanRa = soLuongBanRa;
            this.SoLuongConLai = soLuongConLai;
            this.HangYeuThichNhat = hangYeuThichNhat;
            this.dsGiay = dsGiay;
            this.dsHoaDon = dsHoaDon;
            this.dsKhachHang = dsKhachHang;
        }

        public ThongKe()
        {
            this.SoLuongDonHang = 0;
            this.SoLuongKhachHang = 0;
            this.DoanhThu = 0;
            this.SoLuongBanRa = 0;
            this.SoLuongConLai = 0;
            this.HangYeuThichNhat = string.Empty;
            this.dsGiay = new Giay();
            this.dsHoaDon = new HoaDon();
            this.dsKhachHang = new KhachHang();
        }
    }
}
