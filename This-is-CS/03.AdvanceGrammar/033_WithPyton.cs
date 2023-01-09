using Microsoft.Scripting.Hosting;
using Microsoft.Scripting;
using IronPython.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0003._AdvanceGrammar
{
    internal class _033_WithPyton
    {
        class MainApp
        {
            static void Main(string[] args)
            {
                ScriptEngine engine = Python.CreateEngine();
                ScriptScope scope = engine.CreateScope();
                scope.SetVariable("n", "박상현");
                scope.SetVariable("p", "010-123-4566");
            }
        }
        // 

    }
}
