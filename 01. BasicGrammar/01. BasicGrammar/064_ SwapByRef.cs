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
    class RefReturn
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            Console.WriteLine($"Price :{price}");
        }
    }

    class MainApp
    { 
        static void Main(string[] args)
        {
            
        }
    }
}