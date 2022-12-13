using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

            ModuleBuilder newModule = newAssembly.DefineType("Sum1To100");

            MethodBuilder newType = newModule.DefineType(
                "Calculate",
                MethodAttributes.Public,
                typeof(int),   // 반환 형식
                new Type[0]);  //  매개변수

            ILGenerator generator = newMethod.GetILGenerator();

            generator.Emit(OpCodes.Ldc_I4, 1);

            for(int i = 2; i <= 100; i++)
            {
                generator.Emit(OpCodes.Ldc_I4, i);
                generator.Emit(OpCodes.Add);
            }

            generator.Emit(OpCodes.Ldc)
        }
    }
}
