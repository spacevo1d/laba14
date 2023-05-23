using lb14;

#region zadanie1
//StreamReader str = new StreamReader(@"..\..\..\1.txt");
//string s1=str.ReadLine();
//string s2=str.ReadLine();
//string[] a = s2.Split(" ");
//int[] b = new int[int.Parse(s1)];
//for(int i=0;i<a.Length; i++)
//{
//    b[i] = Convert.ToInt16(a[i]);
//}
//for(int i= 0;i<b.Length; i++)
//{
//    if (2 * i + 1 <= b.Length-1)
//    {
//        if (b[i] > b[2 * i +1])
//        {
//            Console.WriteLine("NO");
//            break;
//        }
//    }
//    if (2 * i +2 <= b.Length-1)
//    {
//        if (b[i] > b[2 * i + 2])
//        {
//            Console.WriteLine("NO");
//            break;
//        }
//    } 
//}
//Console.WriteLine("Yes");
#endregion

#region zadanie2
//StreamReader str = new StreamReader(@"..\..\..\2.txt");
//string s1 = str.ReadLine();
//var b = s1.Split(" ");
//var c=new int[b.Length];
//for (int i = 0; i < b.Length; i++)
//{
//    c[i] = Convert.ToInt16(b[i]);
//    Console.Write(c[i]+" ");
//}
//Console.WriteLine();
//var a=new MinHeap(c);
//for (int i = 0; i < b.Length; i++)
//{
//    Console.Write(a.arr[i] + " ");
//}
#endregion

#region zadanie3
StreamReader str = new StreamReader(@"..\..\..\2.txt");
string s1 = str.ReadLine();
var b = s1.Split(" ");
var c = new int[b.Length];
for (int i = 0; i < b.Length; i++)
{
    c[i] = Convert.ToInt16(b[i]);
    Console.Write(c[i] + " ");
}
Console.WriteLine();
var a = PirSort1(c);
for (int i = 0; i < a.Length; i++)
{
    Console.Write(a[i] + " ");
}
#endregion

#region zadanie4
//StreamReader str = new StreamReader(@"..\..\..\3.txt");
//var a = new MinHeap2();
//string s=str.ReadLine();
//while (s != null)
//{
//    switch (s[0].ToString())
//    {
//        case "A":
//            a.Add(Convert.ToInt16(s[2].ToString()));
//            break;
//        case "X":
//            if (a.A.Count > 0)
//            {
//                Console.WriteLine(a.Min());
//                a.A.siftUp(a.A.Count);
//            }
//            else
//            {
//                Console.WriteLine("*");
//            }
//            break;
//        case "D":
//            a.A.arr[Convert.ToInt16(s[2].ToString())-1] = Convert.ToInt16(s[4].ToString());
//            a.A.siftUp(a.A.Count);
//            break;
//        default:
//            break;
//    }
//    //Console.WriteLine(a.ToString()+" "+a.Min(1));
//    s = str.ReadLine();
//}
#endregion

#region PirSort

int[] PirSort1(int[] arr)
{
    int n=arr.Length-1;
    var temp = new int[arr.Length];
    var a=new MinHeap(arr);
    while (n>=0)
    {
        temp[n--] = a.Min();
    }
    return temp;
}
#endregion

int[] Copy(int[] arr,int a,int b)
{
    var temp=new int[b-a+1];
    int j = 0;
    for(int i=a;i<b+1; i++,j++)
    {
        temp[j] = arr[i];
    }
    return temp;
}