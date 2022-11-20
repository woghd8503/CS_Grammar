using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _0003._AdvanceGrammar
{
    class MainApp
    {
        static void PrintInterfaces(Type type)
        {
            Console.WriteLine("---------- Interfaces ----------");

            Type[] interfaces = type.GetInterfaces();
            foreach(Type i in interfaces)
                Console.WriteLine("Name{0}", i.Name);

            Console.WriteLine();
        }

        static void PrintFields(Type type)
        {
            Console.WriteLine("---------- Fields ----------");

            FieldInfo[] fields = type.GetFields()
        }
    }
    internal class _024_GetType
    {

    }
}
