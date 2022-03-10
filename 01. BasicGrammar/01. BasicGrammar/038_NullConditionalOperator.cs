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
    class NullConditionalOperator
    {
        static void Main(string[] args)
        {
            ArrayList a = null;
            a?.Add("야구"); // a?.가 null을 반환하므로 Add() 메소드는 호출되지 않음
            a?.Add("축구");
            WriteLine()
        }
    }
}
