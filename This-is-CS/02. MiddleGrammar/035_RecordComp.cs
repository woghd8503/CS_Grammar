using System;
using System.Runtime.CompilerServices;

namespace RecordComp
{
    class CTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init;]}

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }

    class RTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            CTransaction trA = new CTransaction { From = "Alice", To = "Bob", Amount = 100 };
        }
    }
}



