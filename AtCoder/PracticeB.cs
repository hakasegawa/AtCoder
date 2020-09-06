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
//      string[] input = Console.ReadLine().Split(' ');
//      int n = int.Parse(input[0]);
//      int q = int.Parse(input[1]);
//      List<char> cs = new List<char>();
//      for(int i = 0; i < n; i++)
//        cs.Add((char)('A' + i));
//      List<char> result = new List<char>();
//      char c = cs[0];
//      cs.RemoveAt(0);
//      result.Add(c);
//      while(cs.Count > 0)
//      {
//        c = cs[0];
//        cs.RemoveAt(0);
//        aaa(c, 0, result.Count, result);
//      }
//      // 文字列の入力
//      //string s = Console.ReadLine();
//      WriteResult(result);
//      Console.ReadLine();
//    }

//    private static void WriteResult(List<char> result)
//    {
//      //出力
//      string s = "! ";
//      foreach(char c2 in result)
//        s += c2.ToString();
//      Console.WriteLine(s);
//    }

//    static void aaa(char c, int min, int max, List<char> result)
//    {
//      int index = min + (max - min) / 2;
//      WriteResult(result);
//      Console.WriteLine(c.ToString() + " " + min.ToString() + " " + index.ToString() + " " + max.ToString());
//      Console.WriteLine("? " + c.ToString() + " " + result[index].ToString());
//      string r = Console.ReadLine();
//      if(r == "<")
//        max = index;
//      else
//        min = index + 1;

//      if(max == min)
//      {
//        result.Insert(max, c);
//        return;
//      }

//      aaa(c, min, max, result);
//    }
//  }
//}