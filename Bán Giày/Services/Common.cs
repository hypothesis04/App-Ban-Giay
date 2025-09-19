using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bán_Giày
{
    public class Common<T>
    {
        int n;
        T[] a;
        public Common()
        {
            this.n = 0;
            this.a = new T[1];
        }
        public int N { get { return n; } set { n = value; } }
        public T[] A { get { return a; } set { a = value; } }
        public void isFull()
        {
            if (this.n + 1 > this.a.Length)
            {
                T[] temp = new T[this.a.Length + 1];
                Array.Copy(this.a, temp, this.a.Length);
                this.a = temp;
            }
        }
        public void Remove(string ma)
        {

            List<T> newList = new List<T>();
            foreach (var item in this.a)
            {

                if (item is ListGioHang i && i.MaGiay != ma)
                {
                    newList.Add(item);
                }
            }
            this.a = newList.ToArray();
            this.n = this.a.Length;
        }
        public void Clear()
        {
            this.a = new T[0];
            this.n = 0;
        }
    }
}
