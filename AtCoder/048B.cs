//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace AtCoder
//{
//  class Program
//  {
//    static void Main(string[] args)
//    {
//      string[] ss = Console.ReadLine().Split(' ');
//      long a = long.Parse(ss[0]);
//      long b = long.Parse(ss[1]);
//      long x = long.Parse(ss[2]);
//      long l = b - a + 1;
//      if(a % x == 0)
//        l += x;
//      l += (a % x) - 1;
//      long c = l / x;

//      Console.WriteLine(c);
//      Console.ReadLine();
//    }

//  }
//}