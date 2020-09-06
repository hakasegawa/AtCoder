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
//      List<int> ts = new List<int>();
//      List<int> xs = new List<int>();
//      List<int> ys = new List<int>();
//      for(int i = 0; i < N; i++)
//      {
//        string[] ss = Console.ReadLine().Split(' ');
//        ts.Add(int.Parse(ss[0]));
//        xs.Add(int.Parse(ss[1]));
//        ys.Add(int.Parse(ss[2]));
//      }

//      int t = 0, x = 0, y = 0;
//      for(int i = 0; i < N; i++)
//      {
//        int td = ts[i] - t;
//        int xd = xs[i] - x;
//        int yd = ys[i] - y;

//        int d = Math.Abs(xd) + Math.Abs(yd);
//        if(td < d)
//        {
//          Console.WriteLine("No");
//          //Console.ReadLine();
//          return;
//        }
//        if(td % 2 != d % 2)
//        {
//          Console.WriteLine("No");
//          //Console.ReadLine();
//          return;
//        }

//        t = ts[i];
//        x = xs[i];
//        y = ys[i];
//      }

//      Console.WriteLine("Yes");
//      //Console.ReadLine();
//    }

//  }
//}