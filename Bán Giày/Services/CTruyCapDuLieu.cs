using Bán_Giày.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace  Bán_Giày     
{
    [Serializable]
    class CTruyCapDuLieu
    {
        private static CTruyCapDuLieu instance = null;
        private static List<Giay> dsGiay;
        private static List<KhachHang> dsKhachHang;
        private static List<HoaDon> dsHoaDon;
        private static List<GioHang> dsGioHang;
        private CTruyCapDuLieu()
        {
            dsGiay = new List<Giay>();
            dsKhachHang = new List<KhachHang>();
            dsHoaDon = new List<HoaDon>();
            dsGioHang = new List<GioHang>();
        }
        public static CTruyCapDuLieu khoiTao()
        {
            if (instance == null)
                instance = new CTruyCapDuLieu();
            return instance;
        }
        public List<Giay> getDanhSachGiay() { return dsGiay; }

        public List<KhachHang> getDanhSachKhachHang() { return dsKhachHang; }

        public List<HoaDon> getDanhSachHoaDon() { return dsHoaDon; }
        public List<GioHang> getDanhSachGioHang() { return dsGioHang; }
        public static bool GhiFileGiay(string tenfilegiay)
        {
            try
            {
                string json = JsonSerializer.Serialize(dsGiay);
                File.WriteAllText(tenfilegiay, json);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool DocFileGiay(string tenfilegiay)
        {
            try
            {
                if (File.Exists(tenfilegiay))
                {
                    string json = File.ReadAllText(tenfilegiay);
                    dsGiay = JsonSerializer.Deserialize<List<Giay>>(json);
                    return true;
                }
                else
                {
                    dsGiay = new List<Giay>();
                    return false;
                }
            }
            catch
            {
                dsGiay = new List<Giay>();
                return false;
            }
        }
        public static bool GhiFileKH(string tenfilekhachhang)
        {
            try
            {
                string json = JsonSerializer.Serialize(dsKhachHang);
                File.WriteAllText(tenfilekhachhang, json);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool DocFileKH(string tenfilekhachhang)
        {
            try
            {
                if (File.Exists(tenfilekhachhang))
                {
                    string json = File.ReadAllText(tenfilekhachhang);

                    dsKhachHang = JsonSerializer.Deserialize<List<KhachHang>>(json);
                    return true;
                }
                else
                {
                    dsKhachHang = new List<KhachHang>();
                    return true;
                }
            }
            catch
            {
                dsKhachHang = new List<KhachHang>();
                return false;
            }
        }
        public static bool GhiFileHD(string tenfilehoadon)
        {
            try
            {
                string json = JsonSerializer.Serialize(dsHoaDon);
                File.WriteAllText(tenfilehoadon, json);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool DocFileHD(string tenfilehoadon)
        {
            try
            {
                if (File.Exists(tenfilehoadon))
                {
                    string json = File.ReadAllText(tenfilehoadon);
                    dsHoaDon = JsonSerializer.Deserialize<List<HoaDon>>(json);
                    return true;
                }
                else
                {
                    dsHoaDon = new List<HoaDon>();
                    return false;
                }
            }
            catch
            {
                dsHoaDon = new List<HoaDon>();
                return false;
            }
        }
        public static bool GhiFileGH(string tenfile)
        {
            try
            {
                string json = JsonSerializer.Serialize(dsGioHang);
                File.WriteAllText(tenfile, json);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool DocFileGH(string tenfile)
        {
            try
            {
                if (File.Exists(tenfile))
                {
                    string json = File.ReadAllText(tenfile);
                    dsGioHang = JsonSerializer.Deserialize<List<GioHang>>(json);
                    return true;
                }
                else
                {
                    dsGioHang = new List<GioHang>();
                    return false;
                }
            }
            catch
            {
                dsGioHang = new List<GioHang>();
                return false;
            }
        }


    }
}
