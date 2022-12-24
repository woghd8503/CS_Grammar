using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BasicGrammar
{
    [AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]
    class Histroy : System.Attribute
    {
        private string programmer;
        public double version;
        public string changes;

        public Histroy(string programmer)
        {
            this.programmer = programmer;
            version = 1.0;
            changes = "First release";
        }

        public string GetProgrammer()
        {
            return programmer;
        }
    }

    [Histroy("Sean", 
        version = 0.1, changes = "2017-11-01 Created class stub")]
    [Histroy("Bob",
        version = 0.2, changes = "2020-12-03 Added Func() Method")]
    class MyClass
    {
        public void Func()
        {
            Console.WriteLine("Func()");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Type type = typeof(MyClass);
            Attribute[] attributes = Attribute.GetCustomAttributes(type);

            Console.WriteLine();
        }
    }
}
