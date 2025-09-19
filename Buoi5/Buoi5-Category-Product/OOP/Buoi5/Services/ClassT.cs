using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5.Services
{
    internal class ClassT<T>
    {
        int n;
        T[] a;
        public ClassT(){
            n=0;
            a=new T[1];
        }
        public void isFull() {
            if (n == a.Length)
            {
                T[] tmp = new T[a.Length+1];
                Array.Copy(a,tmp,a.Length);
                a = tmp;
            }
        }
        public T[] A
        {
            get { return a; } set { a = value; }
        }
        public int N
        {
            set;get;
        }
        public void Add(T x)
        {
            isFull();
            a[n++] = x;
        }
        public void RemoveAt(int idx)
        {
            if(idx <0 || idx >= a.Length)
                return;
            for (int i = idx; i < a.Length - 1; i++)
            {
                a[i] = a[i + 1];
            }
            if (n > 0)
            {
                n--;
            }
            else
            {
                n = 0;
            }
            T[] tmp = new T[a.Length - 1];
            Array.Copy(a, tmp, n);
            a = tmp;
            
        }
        
    }
}
