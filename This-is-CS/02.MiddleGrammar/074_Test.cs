using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0002._MiddleGrammar
{
    internal class _074_Test
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
                arr[i] = i;

            for (int i = 0; i < 11; i++)
            {
                try
                {
                    Console.WriteLine(arr[i]);

                }
                catch(IndexOutOfRangeException e)
                {
                    Console.WriteLine("예외처리" + e.Message);
                }
            }
        }
    }
}
