using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bán_Giày
{
    [Serializable]
    class CXuLyHoaDon
    {

        private List<Giay> dsGiay;
        private List<KhachHang> dsKhachHang;
        private List<HoaDon> dsHoaDon;
        public CXuLyHoaDon()
        {
            dsGiay = new List<Giay>();
            dsKhachHang = new List<KhachHang>();
            CTruyCapDuLieu dulieu = CTruyCapDuLieu.khoiTao();
            this.dsGiay = dulieu.getDanhSachGiay();
            this.dsKhachHang = dulieu.getDanhSachKhachHang();
            this.dsHoaDon = dulieu.getDanhSachHoaDon();
        }
        public List<Giay> getDanhSachGiay()
        {
            return this.dsGiay;
        }

        public List<KhachHang> getDanhSachKhachHang()
        {
            return dsKhachHang;
        }
        public List<HoaDon> getDanhSachHoaDon()
        {
            return dsHoaDon;
        }
        public void ThemHoaDon(HoaDon hoaDon)
        {
            dsHoaDon.Add(hoaDon);
        }

        public void SuaHoaDon(HoaDon hoaDonMoi)
        {
            HoaDon ketQuatim = timHD(hoaDonMoi.MaHoaDon);
            if (ketQuatim != null)
            {
                ketQuatim.MaHoaDon = hoaDonMoi.MaHoaDon;
                ketQuatim.MaGiay = hoaDonMoi.MaGiay;
                ketQuatim.MaKhachHang = hoaDonMoi.MaKhachHang;
                ketQuatim.TongTien = hoaDonMoi.TongTien;
                ketQuatim.NgayBan = hoaDonMoi.NgayBan;
            }
        }
        public void XoaHoaDon(string maHoaDon)
        {
            foreach (HoaDon n in this.dsHoaDon)
            {
                if (n.MaHoaDon.Equals(maHoaDon))
                {
                    this.dsHoaDon.Remove(n);
                    break;
                }
            }
        }
        public HoaDon timHD(string maHD)
        {
            {
                foreach (HoaDon n in this.dsHoaDon)
                {
                    if (n.MaHoaDon == maHD)
                        return n;
                }
                return null;
            }
        }
       
    }
}
