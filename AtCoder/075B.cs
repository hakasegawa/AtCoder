﻿//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace AtCoder
//{
//  class Program
//  {
//    static void Main(string[] args)
//    {
//      string[] ss = Console.ReadLine().Split(' ');
//      int H = int.Parse(ss[0]);
//      int W = int.Parse(ss[1]);
//      char[][] map = new char[H][];
//      for(int i = 0; i < H; i++)
//      {
//        map[i] = Console.ReadLine().ToCharArray();
//      }

//      int[] dx = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 };
//      int[] dy = new int[] { -1, -1, -1, 0, 0, 1, 1, 1 };

//      for(int y = 0; y < H; y++)
//        for(int x = 0;x < W; x++)
//        {
//          if(map[y][x] != '.')
//            continue;

//          int c = 0;
//          for(int i = 0; i < 8; i++)
//          {
//            int cy = y + dy[i];
//            int cx = x + dx[i];
//            if(cy < 0 || map.Length <= cy)
//              continue;
//            if(cx < 0 || map[cy].Length <= cx)
//              continue;
//            if(map[cy][cx] == '#')
//              c++;
//          }
//          map[y][x] = (char)('0' + c);
//        }

//      foreach(char[] s in map)
//      {
//        Console.WriteLine(new string(s));
//      }
//      Console.ReadLine();
//    }

//  }
//}