using Bán_Giày.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bán_Giày
{
    [Serializable]
    internal class CXuLyGioHang
    {

        private List<GioHang> dsGioHang;
        public CXuLyGioHang()
        {
            CTruyCapDuLieu dulieu = CTruyCapDuLieu.khoiTao();
            this.dsGioHang = dulieu.getDanhSachGioHang();
        }
        public List<GioHang> getDanhSachGioHang()
        {
            return this.dsGioHang;
        }
        public void Them(GioHang giohang)
        {
            this.dsGioHang.Add(giohang);
        }

        public void Sua(GioHang sua)
        {
            GioHang ketQuatim = timGioHang(sua.MaHoaDon);
            if (ketQuatim != null)
            {
                ketQuatim.ThongTin = sua.ThongTin;
            }
        }

        public void Xoa(string maHoaDon)
        {
            foreach (GioHang n in this.dsGioHang)
            {
                if (n.MaHoaDon.Equals(maHoaDon))
                {
                    this.dsGioHang.Remove(n);
                    break;
                }
            }
        }
        public GioHang timGioHang(string mahoadon)
        {
            foreach (GioHang n in this.dsGioHang)
            {
                if (n.MaHoaDon == mahoadon)
                    return n;
            }
            return null;
        }

    }
}
