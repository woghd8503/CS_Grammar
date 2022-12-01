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
            AssemblyBuilder newAssembly =
                AssemblyBuilder.DefineDynamicAssembly(
                    new System.Reflection.AssemblyName("CalculatorAssembly"),
                    AssemblyBuilderAccess.Run);

            ModuleBuilder newModule = newAssembly.DefineDynamicModule(
                "Calculator");
            TypeBuilder newType = newModule.DefineType("Sum1To100");

            MethodBuilder newMethod = newType.DefineMethod(
                "Calculate",
                System.Reflection.MethodAttributes.Public,
                typeof(int),   // 반환 형식
                new Type[0]);  // 매개 변수
        }
    }
}
