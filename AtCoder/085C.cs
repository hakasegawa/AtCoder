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
//      int amount = 0;
//      int a = 0, b = 0, c = 0;
//      int rate = Y / N;
//      if(rate > 10000 || 1000 > rate)
//      {
//        Console.WriteLine("-1 -1 -1");
//        Console.ReadLine();
//        return;
//      }
//      while(N > 100)
//      {
//        rate = (Y - amount) / N;
//        if(rate > 7000)
//        {
//          a++;
//          amount += 10000;
//        }
//        else if(rate > 3300)
//        {
//          b++;
//          amount += 5000;
//        }
//        else
//        {
//          c++;
//          amount += 1000;
//        }
//        N--;
//      }
//      if(NewMethod(Y, amount, N, a, b, c))
//        return;

//      Console.WriteLine("-1 -1 -1");
//      Console.ReadLine();
//    }
//    private static bool NewMethod(int X, int amount, int N, int A, int B, int C)
//    {
//      if(amount == X && N == 0)
//      {
//        Console.WriteLine(string.Format("{0} {1} {2}", A, B, C));
//        Console.ReadLine();
//        return true;
//      }

//      if(N == 0)
//        return false;

//      if(amount > X)
//        return false;

//      if(NewMethod(X, amount + 10000, N - 1, A + 1, B, C))
//        return true;
//      if(NewMethod2(X, amount + 5000, N - 1, A, B + 1, C))
//        return true;
//      if(NewMethod3(X, amount + 1000, N - 1, A, B, C + 1))
//        return true;
//      return false;
//    }
//    private static bool NewMethod2(int X, int amount, int N, int A, int B, int C)
//    {
//      if(amount == X && N == 0)
//      {
//        Console.WriteLine(string.Format("{0} {1} {2}", A, B, C));
//        Console.ReadLine();
//        return true;
//      }

//      if(amount >= X || N == 0)
//        return false;

//      if(NewMethod2(X, amount + 5000, N - 1, A, B + 1, C))
//        return true;
//      if(NewMethod3(X, amount + 1000, N - 1, A, B, C + 1))
//        return true;
//      return false;
//    }
//    private static bool NewMethod3(int X, int amount, int N, int A, int B, int C)
//    {
//      if(amount == X && N == 0)
//      {
//        Console.WriteLine(string.Format("{0} {1} {2}", A, B, C));
//        Console.ReadLine();
//        return true;
//      }

//      if(amount >= X || N == 0)
//        return false;

//      if(NewMethod3(X, amount + 1000, N - 1, A, B, C + 1))
//        return true;
//      return false;
//    }

//  }
//}