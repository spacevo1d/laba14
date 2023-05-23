using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb14
{
    internal class MinHeap
    {
        public int[] arr = new int[10000];
        public int MaxSize = 10000;
        public int Count;
        public MinHeap(int[] a)
        {
            BuildHead(a);
        }
        public MinHeap(){}
        public MinHeap(int a)
        {
            arr[0]=a; Count = 1;
        }
        public void siftDown(int i=0)
        {
            while (2 * i + 1 < Count)
            {
                int left=2* i + 1;
                int right=2* i + 2;
                int j = left;
                if (right<Count && arr[right] < arr[left])
                {
                    j = right;
                }
                if (arr[i] <= arr[j])
                {
                    break;
                }
                int temp = arr[i];
                arr[i]= arr[j];
                arr[j]= temp;
                i = j;
            }
        }
        public void siftUp(int i)
        {
            while (arr[i] < arr[(i - 1) / 2])
            {
                int temp = arr[i];
                arr[i] = arr[(i-1) / 2];
                arr[(i-1) / 2] = temp;
                i = (i - 1) / 2;
            }
        }
        public int Parent(int i)
        {
            if (i == 0 || i>Count) { throw new Exception("У корня нет родителей!"); }
            else { 
                if (i % 2 == 0)
                {
                    return arr[i/2-1];
                }
                else
                {
                    return arr[(i - 1) / 2];
                }
            }
        }
        public int LeftKid(int i = 0)
        {
            if((2*i+1)>Count) { throw new Exception("Детей нет!"); }
            else
            {
                if (arr[2 * i + 1] != null)
                {
                    return arr[2 * i + 1];
                }
                else
                {
                    throw new Exception("Детей нет!");
                }
            }
        }
        public int RightKid(int i = 0)
        {
            if ((2 * i +2) > Count) { throw new Exception("Детей нет!"); }
            else
            {
                if (arr[2 * i + 2] != null)
                {
                    return arr[2 * i + 2];
                }
                else
                {
                    throw new Exception("Детей нет!");
                }
            }
        }
        public void BuildHead(int[] a)
        {
            Array.Copy(a,arr,a.Length);
            int n=a.Length;
            Count = n;
            for(int i = n / 2; i > 0; i--)
            {
                siftDown(i);
            }
        }
        public int Min()
        {
            int min = arr[0];
            Count--;
            if (Count >= 1)
            {
                arr[0] = arr[Count ];
                siftDown();
            }
            else
            {
                arr=new int[1];
            }
            return min;
        }
        public int Min(int x)
        {
            int min = arr[0];
            return min;
        }
        public virtual void Add(int a)
        {
            Count++;
            arr[Count-1] =a;
            siftUp(Count-1);
        }
        public override string ToString()
        {
            var str=new StringBuilder();
            for(int i = 0; i < Count; i++)
            {
                str.Append(arr[i] + " ");
            }
            return str.ToString(); 
        }
    }
}
