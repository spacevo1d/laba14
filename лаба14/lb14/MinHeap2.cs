using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb14
{
    internal class MinHeap2
    {
        public MinHeap A = new MinHeap(); 
        public MinHeap2() { }
        public void Add(int x)
        {
           A.Add(x);
        }
        public int Min()
        {
            return A.Min();
        }
        public int Min(int x)
        {
            return (int)A.Min(x);
        }
        public override string ToString()
        {
            return A.ToString();
        }
    }
}
