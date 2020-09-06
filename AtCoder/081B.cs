//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace AtCoder
//{
//  class Program
//  {
//    static void Main(string[] args)
//    {
//      // スペース区切りの整数の入力
//      string s = Console.ReadLine();
//      string[] ss = Console.ReadLine().Split(' ');
//      List<int> ns = new List<int>();
//      for(int i = 0; i < ss.Length; i++)
//        ns.Add(int.Parse(ss[i]));
//      int c = 0;
//      NewMethod(ns, ref c);
//      Console.WriteLine(c);
//    }

//    private static void NewMethod(List<int> ns, ref int c)
//    {
//      while(true)
//      {
//        for(int i = 0; i < ns.Count; i++)
//        {
//          if(ns[i] % 2 == 1)
//            return;
//          ns[i] /= 2;
//        }
//        c++;
//      }
//    }
//  }
//}