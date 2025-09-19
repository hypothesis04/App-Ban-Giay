using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5.Models
{
    internal class Category
    {
        int ma;
        string ten;
        DateTime ngay;
        public int Ma { get;set; }
        public string Ten { get;set; }
        public DateTime Ngay { get;set; }
        public override string ToString()
        {
            return Ma + " - " + Ten + "  -  "+ Ngay;
        }
    }
}
