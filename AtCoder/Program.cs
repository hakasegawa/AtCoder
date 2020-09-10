using System;
using System.Collections.Generic;
using System.Text;

namespace AtCoder
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] ss = Console.ReadLine().Split(' ');
      long a = long.Parse(ss[0]);
      long b = long.Parse(ss[1]);
      long c = long.Parse(ss[2]);
      long d = a % b;
      long amount = 0;
      for(int i = 0; i < b; i++)
      {
        amount += d;
        if(amount >= b)
          amount = amount % b;
        if(amount == c)
        {
          Console.WriteLine("YES");
          Console.ReadLine();
          return;
        }
      }

      Console.WriteLine("NO");
      Console.ReadLine();
    }

  }
}