using Buoi5.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Buoi5.Models
{

    internal class Product
    {
        int ma;
        string ten;
        double gia;
        DateTime handung;
        string danhmuc;
        public int Ma { get; set; }
        public string Ten { get; set; }
        public double Gia { get; set; }
        public DateTime Handung { get; set; }
        public string Danhmuc { get; set; }
        public static ClassT<Category> cates = new ClassT<Category>();
    }
}
