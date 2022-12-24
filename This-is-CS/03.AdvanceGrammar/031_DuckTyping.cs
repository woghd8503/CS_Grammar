using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0003._AdvanceGrammar
{
    class Duck
    {
        public void Walk()
        { Console.WriteLine(this.GetType() + ".Walk"); }

        public void Swim()
        { Console.WriteLine(this.GetType() + ".Swim"); }

        public void Quack()
        { Console.WriteLine(this.GetType() + ".Quack"); }

        class Mallard : Duck 
        { }

        class Robot
        {

        }
    }
}
