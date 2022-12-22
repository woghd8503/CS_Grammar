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

    [Histroy]
}
