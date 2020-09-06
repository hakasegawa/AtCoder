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
//      List<int> ns = new List<int>();
//      for(int i = 0; i < N; i++)
//        ns.Add(int.Parse(Console.ReadLine()));
//      ns.Sort();
//      int current = 200;
//      int c = 0;
//      for(int i = N - 1; i >= 0; i--)
//      {
//        if(ns[i] < current)
//        {
//          current = ns[i];
//          c++;
//        }
//      }
//      Console.WriteLine(c);
//      Console.ReadLine();
//    }

//  }
//}