using System;
using System.Collections.Generic;
using System.Text;

namespace AtCoder
{
  class Program
  {
    static void Main(string[] args)
    {
      int N = int.Parse(Console.ReadLine());

      List<int> primes = new List<int>();
      for(int i = 11; i <= 55555; i += 10)
        if(IsPrime(i))
        {
          primes.Add(i);
          if(primes.Count == N)
          {
            string s = "";
            foreach(int p in primes)
              s += " " + p.ToString();
            Console.WriteLine(s.Substring(1));
            Console.ReadLine();
            return;
          }
        }
    }

    static bool IsPrime(int n)
    {
      for(int i = 3; i <= n / 2; i += 2)
      {
        if(n % i == 0)
          return false;
      }
      return true;
    }
    static bool IsOK(List<int>ans,int newAns)
    {
      for(int a = 1; a < ans.Count - 3; a++)
        for(int b = a + 1; b < ans.Count - 2; b++)
          for(int c = b + 1; c < ans.Count - 1; c++)
            for(int d = c + 1; d < ans.Count; d++)
            {
              int sum = ans[a] + ans[b] + ans[c] + ans[d] + newAns;
              if(IsPrime(sum))
                return false;
            }
      return true;
    }
  }
}