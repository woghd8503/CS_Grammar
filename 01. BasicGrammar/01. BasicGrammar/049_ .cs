using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _01.BasicGrammar
{
    class Switch
    {
        static void Main(string[] args)
        {
            object obj = null;

            string S = Console.ReadLine();
            if (int.TryParse(S, out int out_i))
                obj = out_i;
            else if (float.TryParse(S, out float out_f))
                obj = out_f;
            else
                obj = S;

            switch (obj)
            {
                case int i:
                    Console.WriteLine($"{i}는 int 형식입니다.");
                    break;
                case float f:
                    Console.WriteLine($"{f}는 float 형식입니다.");
                    break;
                default:
                    Console.WriteLine($"{obj}(은)는 모르는 형식입니다.");
                    break;
            }
        }
    }
}
