using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.MiddleGrammar
{
    class MyClass
    {
        public int MyField1;
        public int MyField2;

        public MyClass DeepCopy()
        {
            MyClass newCopy = new DeepCopy();
            new
            Console.WriteLine($"Global.Count : {Global.Count}");
        }
    }
}
