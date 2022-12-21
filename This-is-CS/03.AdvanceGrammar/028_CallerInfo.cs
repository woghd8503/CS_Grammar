using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _0003._AdvanceGrammar
{
    public static class Trace
    {
        public static void WriteLin(string message,
            [CallerFilePath] string file = "",
            [CallerLineNumber] int line = 0,
            [CallerFilePath] string member = "")
        {
            Console.WriteLine(
                $"{file}(Line:{line}) {member}: {message}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Trace.WriteLin("즐거운 프로그래밍!");
        }
    }
}
