using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bán_Giày
{
     class Giay
    {
        private string _maGiay;
        private string _ten;
        private string _thuongHieu;
        private string _mauSac;
        private int _size;
        private int _soLuong;
        private int _soluongban;

        public string MaGiay { get => this._maGiay; set => this._maGiay = value; }
        public string Ten { get => this._ten; set => this._ten = value; }
        public string ThuongHieu { get => this._thuongHieu; set => this._thuongHieu = value; }
        public string MauSac { get => this._mauSac; set => this._mauSac = value; }
        public int Size { get => this._size; set => this._size = value; }
        public int SoLuong { get => this._soLuong; set => this._soLuong = value; }
        public int SoLuongBan { get => this._soluongban; set => this._soluongban = value; }

        public Giay()
        {
            this._maGiay = "";
            this._ten = "";
            this._thuongHieu = "";
            this._mauSac = "";
            this._size = 0;
            this._soLuong = 0;
            this._soluongban = 0;
        }

        public Giay(string maGiay, string ten, string thuongHieu, string mauSac, int size, int soLuong,int daBan )
        {
            this._maGiay = maGiay;
            this._ten = ten;
            this._thuongHieu = thuongHieu;
            this._mauSac = mauSac;
            this._size = size;
            this._soLuong = soLuong;
            this._soluongban = daBan;
        }
    }
}
