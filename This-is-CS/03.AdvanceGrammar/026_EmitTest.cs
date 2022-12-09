using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _0003._AdvanceGrammar
{
    public class MainApp
    {
        public static void Main()
        {
            AssemblyBuilder assembly =
                AssemblyBuilder.DefineDynamicAssembly(
                    new AssemblyName("CalculatorAssemby"),
                    AssemblyBuilderAccess.Run);






        }
    }
}
