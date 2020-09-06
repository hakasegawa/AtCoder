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
//      int N = int.Parse(ss[0]);
//      int Y = int.Parse(ss[1]);
//      //int amount = 0;
//      //int a = 0, b = 0, c = 0;
//      int rate = Y / N;
//      if(rate > 10000 || 1000 > rate)
//      {
//        Console.WriteLine("-1 -1 -1");
//        Console.ReadLine();
//        return;
//      }
//      //while(N > 100)
//      //{
//      //  rate = (Y - amount) / N;
//      //  if(rate > 7000)
//      //  {
//      //    a++;
//      //    amount += 10000;
//      //  }
//      //  else if(rate > 3300)
//      //  {
//      //    b++;
//      //    amount += 5000;
//      //  }
//      //  else
//      //  {
//      //    c++;
//      //    amount += 1000;
//      //  }
//      //  N--;
//      //}
//      //if(NewMethod(Y, amount, N, a, b, c))
//      //  return;
//      for(int a = 0; a <= N; a++)
//        for(int b = 0; b <= N; b++)
//        {
//          int c = N - a - b;
//          if(c < 0)
//            continue;
//          if(a * 10000 + b * 5000 + c * 1000 == Y)
//          {
//            Console.WriteLine(string.Format("{0} {1} {2}", a, b, c));
//            Console.ReadLine();
//            return;
//          }
//        }

//      Console.WriteLine("-1 -1 -1");
//      Console.ReadLine();
//    }

//  }
//}