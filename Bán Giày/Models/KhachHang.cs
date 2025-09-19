using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bán_Giày
{
     class KhachHang
    {
        private string _maKhachHang;
        private string _ten;
        private string _gioiTinh;
        private string _soDienThoai;
        private string _email;
        private string _diaChi;

        public string MaKhachHang { get => this._maKhachHang; set => this._maKhachHang = value; }
        public string Ten { get => this._ten; set => this._ten = value; }
        public string GioiTinh { get => this._gioiTinh; set => this._gioiTinh = value; }
        public string SoDienThoai { get => this._soDienThoai; set => this._soDienThoai = value; }
        public string Email { get => this._email; set => this._email = value; }
        public string DiaChi { get => this._diaChi; set => this._diaChi = value; }
  

        public KhachHang()
        {
            this._maKhachHang = "";
            this._ten = "";
            this._gioiTinh = "";
            this._soDienThoai = "";
            this._email = "";
            this._diaChi = "";
       
        }

        public KhachHang(string maKhachHang, string ten, string gioiTinh, string soDienThoai, string email, string diaChi )
        {
            this._maKhachHang = maKhachHang;
            this._ten = ten;
            this._gioiTinh = gioiTinh;
            this._soDienThoai = soDienThoai;
            this._email = email;
            this._diaChi = diaChi;
           
        }
    }
}
