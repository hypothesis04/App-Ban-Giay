using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bán_Giày
{
    public class ListGioHang
    {
        string _maGiay;
        string _ten;
        int _soLuong;
        decimal _donGia;
        public string MaGiay { get => this._maGiay; set => this._maGiay = value; }
        public string Ten { get => this._ten; set => this._ten = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
        public decimal DonGia { get => _donGia; set => _donGia = value; }
    }
}
