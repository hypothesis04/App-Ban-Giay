using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;


namespace Bán_Giày
{
    [Serializable]
    class CXuLyKhachHang
    {

        private List<KhachHang> dsKhachHang;

        public CXuLyKhachHang()
        {
            CTruyCapDuLieu dulieu = CTruyCapDuLieu.khoiTao();
            this.dsKhachHang = dulieu.getDanhSachKhachHang();
        }
        public List<KhachHang> getDanhSachKhachHang()
        {
            return dsKhachHang;
        }
        public void ThemKhachHang(KhachHang kh)
        {
            this.dsKhachHang.Add(kh);
        }

        public void SuaKhachHang(KhachHang khachHangMoi)
        {
            KhachHang ketQuatim = timKH(khachHangMoi.MaKhachHang);
            if (ketQuatim != null)
            {
                ketQuatim.Ten = khachHangMoi.Ten;
                ketQuatim.GioiTinh = khachHangMoi.GioiTinh;
                ketQuatim.DiaChi = khachHangMoi.DiaChi;
                ketQuatim.Email = khachHangMoi.Email;
                ketQuatim.SoDienThoai = khachHangMoi.SoDienThoai;
            }


        }

        public void XoaKhachHang(string maKhachHang)
        {
            foreach (KhachHang kh in this.dsKhachHang)
            {
                if (kh.MaKhachHang == maKhachHang)
                {
                    this.dsKhachHang.Remove(kh);
                    break;
                }
            }
        }
        public KhachHang timKH(string maKH)
        {
            foreach (KhachHang n in this.dsKhachHang)
            {
                if (n.MaKhachHang == maKH)
                    return n;

            }
            return null;
        }
       
    }
}

