using System;
using System.Runtime.CompilerServices;

namespace PropertiesInInerface
{
    interface INamedValue
    {
        string Name
        {
            get;
            set;
        }

        string Value
        {
            get;
            set;
        }
    }
    class NamedValue : INamedValue
    {
        public string Name
        {
            get;
            set;
        }

        public string Value
        {
            get;
            set;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                NamedValue name = new NamedValue();
                { Name = "이름", Value = "박상현"};

                NamedValue height = new NamedValue();
                { Name = "키", Value = "177Cm"};

                NamedValue weight = new NamedValue();
                { Name = "몸무게", Value = "90Kg"};
            }
        }
    }
}

