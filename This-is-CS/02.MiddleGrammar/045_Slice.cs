﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0002.MiddleGrammar
{
    class _045_Slice
    {

        static void Main(string[] args)
        {
            Console.WriteLine("test");
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int x = input[0];
            int y = input[1];
            int w = input[2];
            int h = input[3];

            int[] NumArray = new int[] { x, y, w - x, h - y };

            int Min = NumArray[0];

            for (int i = 1; i < NumArray.Length; i++)
            {
                if (Min > NumArray[i])
                    Min = NumArray[i];
            }
            Console.WriteLine(Min);
        }
    }
}
