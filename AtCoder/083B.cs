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
//      int A = int.Parse(ss[1]);
//      int B = int.Parse(ss[2]);
//      int amount = 0;
//      int c = 0;
//      for(int i = 0; i <= N; i++)
//      {
//        int sum = GetSum(i);
//        if(A <= sum && sum <= B)
//          amount += i;
//      }
//      Console.WriteLine(amount);
//      Console.ReadLine();
//    }

//    private static int GetSum(int i)
//    {
//      int sum = 0;
//      while(true)
//      {
//        sum += i % 10;
//        i /= 10;
//        if(i == 0)
//          return sum;
//      }
//    }
//  }
//}