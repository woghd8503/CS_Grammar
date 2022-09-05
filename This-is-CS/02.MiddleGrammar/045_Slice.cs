using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0002.MiddleGrammar
{
    class _045_Slice
    {
        static void PrintArray(System.Array array)
        {
            foreach (var e in array)
                Console.Write(e);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            char[] array = new char['Z' - 'A' + 1];
            for (int i = 0; i < array.Length; i++)
                array[i] = (char)('A' + i);

            PrintArray(array[..]);  // 0부터 마지막까지
            PrintArray(array[5..])  // 5부터 끝까지

            Range range_5_10 = 5..10;
            PrintArray(array[range_5_10]); // 5번째부터 9(10-1)번째까지

            Index last = ^0;
        }
    }
}
