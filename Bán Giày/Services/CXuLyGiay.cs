using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text.Json;


namespace Bán_Giày
{
    [Serializable]
    class CXuLyGiay
    {
        private List<Giay> dsGiay;
        public CXuLyGiay()
        {
            CTruyCapDuLieu dulieu = CTruyCapDuLieu.khoiTao();
            this.dsGiay = dulieu.getDanhSachGiay();
        }
        public List<Giay> getDanhSachGiay()
        {
            return this.dsGiay;
        }
        public void ThemGiay(Giay giay)
        {
            this.dsGiay.Add(giay);
        }

        public void SuaGiay(Giay giayMoi)
        {
            Giay ketQuatim = timGiay(giayMoi.MaGiay);
            if (ketQuatim != null)
            {
                ketQuatim.Ten = giayMoi.Ten;
                ketQuatim.ThuongHieu = giayMoi.ThuongHieu;
                ketQuatim.MauSac = giayMoi.MauSac;
                ketQuatim.Size = giayMoi.Size;
                ketQuatim.SoLuong = giayMoi.SoLuong;
            }
        }

        public void XoaGiay(string maGiay)
        {
            foreach (Giay n in this.dsGiay)
            {
                if (n.MaGiay.Equals(maGiay))
                {
                    this.dsGiay.Remove(n);
                    break;
                }
            }
        }
        public Giay timGiay(string maGiay)
        {
            foreach (Giay n in this.dsGiay)
            {
                if (n.MaGiay == maGiay)
                    return n;
            }
            return null;
        }
       
    }
}

