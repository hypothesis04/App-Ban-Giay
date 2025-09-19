using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bán_Giày.Models
{
    internal class GioHang
    {
        string _maHoaDon;
        string _thongTin;
        public string MaHoaDon { get => this._maHoaDon; set => this._maHoaDon = value; }
        public string ThongTin { get => _thongTin; set => _thongTin = value; }

        public GioHang()
        {
            this._maHoaDon = string.Empty;
            this._thongTin = string.Empty;
        }
        public GioHang(string maHoaDon, string thongTin)
        {
            this._maHoaDon = maHoaDon;
            this._thongTin = thongTin;
        }
    }
}
