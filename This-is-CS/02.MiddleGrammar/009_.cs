using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 자식이 달라고 하면 부모는 무조건 물려눠야 하나요?
// 그렇지 않습니다. 기반 클래스의 작성자는 의도하지 않은 상속이나 파생 클래스의 구현을 막기 위해 상속이 불가능하도록 클래스를 선언할 수 있습니다.
// 바로 sealed 한정자를 이용하는 것이죠. 다음과 같이 sealed 한정자로 클래스를 수식하면, 이 클래스는 "상속 봉인"이 되어 
namespace _002.MiddleGrammar
{
    class Base
    {
        protected string Name;
        public Base(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Base()");
        }

        ~Base()
        {
            Console.WriteLine($"{this.Name}.~Base()");
        }

        public void BaseMethod()
        {
            Console.WriteLine($"{Name}.BaseMethod()");
        }
    }

    class Derived : Base
    {
        public Derived(string Name) : base(Name)
        {
            Console.WriteLine($"{this.Name}.Derived()");
        }

        ~Derived()
        {
            Console.WriteLine($"{this.Name}.~Derived()");
        }

        public void DerivedMethod()
        {
            Console.WriteLine($"{Name}.DerivedMethod()");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Base a = new Base("a");
            a.BaseMethod();

            Derived b = new Derived("b");
            b.BaseMethod();
            b.DerivedMethod();
        }
    }
}
