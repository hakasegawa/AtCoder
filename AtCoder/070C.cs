//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace AtCoder
//{
//  class Program
//  {
//    static void Main(string[] args)
//    {
//      List<long> ts = new List<long>();
//      int N = int.Parse(Console.ReadLine());
//      for(int i = 0; i < N; i++)
//        ts.Add(long.Parse(Console.ReadLine()));

//      long c = 1;
//      foreach(long t in ts)
//        c = GetLCM(c, t);

//      Console.WriteLine(c);
//      Console.ReadLine();
//    }

//    static long GetLCM(long a, long b)
//    {
//      return a / GetGCD(a, b) * b;
//    }

//    static long gcd(long a, long b)
//    {
//      if(b == 0)
//        return a;
//      return gcd(b, a % b);
//    }

//    static long GetGCD(long a, long b)
//    {
//      Align(ref a, ref b);

//      while(true)
//      {
//        long c = a % b;
//        if(c == 0)
//          return b;

//        a = b;
//        b = c;
//      }
//    }

//    static void Align(ref long a, ref long b)
//    {
//      if(a >= b)
//        return;

//      long c = a;
//      a = b;
//      b = c;
//    }
//  }
//}