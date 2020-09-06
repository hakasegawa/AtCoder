//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace AtCoder
//{
//  class Program
//  {
//    static void Main(string[] args)
//    {
//      int A = int.Parse(Console.ReadLine());
//      int B = int.Parse(Console.ReadLine());
//      int C = int.Parse(Console.ReadLine());
//      int X = int.Parse(Console.ReadLine());
//      int amount = 0;
//      int c = 0;
//      NewMethod(X, amount, A, B, C, ref c);
//      Console.WriteLine(c);
//      //Console.ReadLine();
//    }

//    private static void NewMethod(int X, int amount, int A, int B, int C, ref int c)
//    {
//      if(amount == X)
//        c++;

//      if(amount >= X)
//        return;

//      if(A > 0 && amount + 500 <= X)
//      {
//        NewMethod(X, amount + 500, A - 1, B, C, ref c);
//      }
//      if(B > 0 && amount + 100 <= X)
//      {
//        NewMethod2(X, amount + 100, A, B - 1, C, ref c);
//      }
//      if(C > 0 && amount + 50 <= X)
//      {
//        NewMethod3(X, amount + 50, A, B, C - 1, ref c);
//      }
//    }
//    private static void NewMethod2(int X, int amount, int A, int B, int C, ref int c)
//    {
//      if(amount == X)
//        c++;

//      if(amount >= X)
//        return;

//      if(B > 0 && amount + 100 <= X)
//      {
//        NewMethod2(X, amount + 100, A, B - 1, C, ref c);
//      }
//      if(C > 0 && amount + 50 <= X)
//      {
//        NewMethod3(X, amount + 50, A, B, C - 1, ref c);
//      }
//    }
//    private static void NewMethod3(int X, int amount, int A, int B, int C, ref int c)
//    {
//      if(amount == X)
//        c++;

//      if(amount >= X)
//        return;

//      if(C > 0 && amount + 50 <= X)
//      {
//        NewMethod3(X, amount + 50, A, B, C - 1, ref c);
//      }
//    }
//  }
//}