using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.MiddleGrammar
{
    class Cat
    {
        public string Name;
        public string Color;

        public void Neow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }
    class BasicClass
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat();
            kitty.Color = "하얀색";
            kitty.Name = "키티";
            kitty.Neow();
            Console.WriteLine($"{kitty.Name}");
        }
    }
}
