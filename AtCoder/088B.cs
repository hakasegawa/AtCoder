//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace AtCoder
//{
//  class Program
//  {
//    static void Main(string[] args)
//    {
//      int N = int.Parse(Console.ReadLine());
//      string[] ss = Console.ReadLine().Split(' ');
//      List<int> ns = new List<int>();
//      for(int i = 0; i < ss.Length; i++)
//        ns.Add(int.Parse(ss[i]));
//      ns.Sort();
//      int amount = 0;
//      int a = 0, b = 0;
//      for(int i = N - 1; i >= 0; i -= 2)
//      {
//        a += ns[i];
//        if(i - 1 >= 0)
//          b += ns[i - 1];
//      }
//      Console.WriteLine(a - b);
//      Console.ReadLine();
//    }

//  }
//}