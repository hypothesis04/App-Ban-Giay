using Bán_Giày.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bán_Giày
{
    internal class TempGioHang
    {
        private CXuLyGiay xulyGiay;
        private CXuLyGioHang xuLyGioHang;
        Common<ListGioHang> dsgiohang = new Common<ListGioHang>();

        public void Them(ListGioHang x)
        {
            dsgiohang.isFull();
            dsgiohang.A[dsgiohang.N++] = x;
        }
        public void Sua(ListGioHang x, string ma)
        {
            for (int i = 0; i < dsgiohang.N; i++)
            {
                if (dsgiohang.A[i].MaGiay == ma)
                {
                    dsgiohang.A[i].Ten = x.Ten;
                    dsgiohang.A[i].SoLuong = x.SoLuong;
                    dsgiohang.A[i].DonGia = x.DonGia;
                    break;
                }
            }
        }

        public void Xoa(string ma)
        {
            dsgiohang.Remove(ma);
        }
        public void HienThiDanhSachGioHang(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.DataSource = dsgiohang.A;
            dgv.Refresh();
        }

        public string ListMaGiay()
        {
            string ma = "";
            for (int i = 0; i < dsgiohang.N; i++)
            {
                if (i + 1 == dsgiohang.N)
                    ma += dsgiohang.A[i].MaGiay;
                else
                    ma += dsgiohang.A[i].MaGiay + ",";
            }
            return ma;
        }
        public decimal TongTien()
        {
            decimal tong = 0;
            for (int i = 0; i < dsgiohang.N; i++)
            {
                tong += dsgiohang.A[i].DonGia * dsgiohang.A[i].SoLuong;
            }
            return tong;
        }
        public void xulyBAN()
        {
            xulyGiay = new CXuLyGiay();
            for (int i = 0; i < dsgiohang.N; i++)
            {
                Giay giay = xulyGiay.timGiay(dsgiohang.A[i].MaGiay);
                giay.SoLuong = giay.SoLuong - dsgiohang.A[i].SoLuong;
                giay.SoLuongBan += dsgiohang.A[i].SoLuong;
            }
            string filePathGiay = "giay.json";
            CTruyCapDuLieu.GhiFileGiay(filePathGiay);
        }
        public bool kiemtra(string ma)
        {
            xulyGiay = new CXuLyGiay();
            for (int i = 0; i < dsgiohang.N; i++)
            {
                Giay giay = xulyGiay.timGiay(dsgiohang.A[i].MaGiay);
                if (giay.MaGiay == ma)
                {
                    return true;
                }
            }
            return false;
        }
        public void resetGioHang()
        {
            dsgiohang.Clear();
        }
        public bool ktgiohang()
        {
            if (dsgiohang.N == 0) return true;
            else return false;
        }
        public ListGioHang tim(string ma)
        {
            ListGioHang hang = new ListGioHang();
            for (int i = 0; i < dsgiohang.N; i++)
                if (dsgiohang.A[i].MaGiay == ma)
                {
                    hang = dsgiohang.A[i];
                    break;
                }
            return hang;
        }
        public bool tontai(string ma)
        {
            for (int i = 0; i < dsgiohang.N; i++)
                if (dsgiohang.A[i].MaGiay == ma)
                    return true;
            return false;
        }
        public void ThemGH(string maHD)
        {
            xuLyGioHang = new CXuLyGioHang();
            GioHang ghmoi = new GioHang();
            string thongtin = string.Empty;
            for (int i = 0; i < dsgiohang.N; i++)
            {
                thongtin += dsgiohang.A[i].MaGiay + ";" + dsgiohang.A[i].Ten + ";" + dsgiohang.A[i].SoLuong + ";" + dsgiohang.A[i].DonGia + "\n";
            }
            ghmoi.MaHoaDon = maHD;
            ghmoi.ThongTin = thongtin;
            xuLyGioHang.Them(ghmoi);
        }

        public void suaGH(string maHD)
        {
            xuLyGioHang = new CXuLyGioHang();
            GioHang ghmoi = new GioHang();
            string thongtin = string.Empty;
            for (int i = 0; i < dsgiohang.N; i++)
            {
                thongtin += dsgiohang.A[i].MaGiay + ";" + dsgiohang.A[i].Ten + ";" + dsgiohang.A[i].SoLuong + ";" + dsgiohang.A[i].DonGia + "\n";
            }
            ghmoi.MaHoaDon = maHD;
            ghmoi.ThongTin = thongtin;
            xuLyGioHang.Sua(ghmoi);
        }

    }
}
