using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bán_Giày
{
    public class HoaDon
    {
        private string _maHoaDon;
        private string _maGiay; 
        private string _maKhachHang;
        private string _tongTien;
        private DateTime _ngayBan;

        public string MaHoaDon { get => this._maHoaDon; set => this._maHoaDon = value; }
        public string MaGiay { get => this._maGiay; set => this._maGiay = value; }
        public string MaKhachHang { get => this._maKhachHang; set => this._maKhachHang = value; }
        public string TongTien { get => this._tongTien; set => this._tongTien = value; }
        public DateTime NgayBan { get => this._ngayBan; set => this._ngayBan = value; }

        public HoaDon()
        {
            this._maHoaDon = "";
            this._maGiay = "";
            this._maKhachHang = "";
            this._tongTien = "";
            this._ngayBan = DateTime.MinValue;
        }

        public HoaDon(string maHoaDon, string maGiay, string maKhachHang, string tongTien, DateTime ngayBan)
        {
            this._maHoaDon = maHoaDon;
            this._maGiay = maGiay;
            this._maKhachHang = maKhachHang;
            this._tongTien = tongTien;
            this._ngayBan = ngayBan;
        }
    }
}
