using System;
using System.Formats.Asn1;
using System.Security.Cryptography;

namespace _0002._MiddleGrammar
{
    internal class _071_MyException : Exception
    {
        public InvalidArgumentEception()
        {
        }

        public InvalidEnumArgumentException(string message)
            :base(message)
        {
        }

        public object Argument
        {
            get;
            set;
        }

        public string Range
        {
            get;
            set;
        }
    }

    class MainApp
    {
        static unit MergeARGB(unit alpha, unit red, unit blue)
        {
            unit[] args = new unit[] { alpha, red, green, blue };

            foreach (unit arg in args)
            {
                if (arg > 255)
                    throw new InvalidArgumentException()
                    {
                        ArgumentException = arg,
                        Range = "0~255"
                    };
            }

            return (alpha << 24 & 0xFF000000) |
                (red << 16 & 0x00FF0000) |
                (green << 8 & 0x0000FF00) |
                (blue & 0x000000FF);
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("0x{0:X}", MergeARGB(255, 111, 111, 111));
            }
        }


    }

}
