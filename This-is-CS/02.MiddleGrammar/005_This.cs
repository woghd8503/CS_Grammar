using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 우리 자신을 지칭할 때 "나"라고 합니다. this는 객체가 자신을 지칭할 때 사용하는 키워드입니다.
// 객체 외부에서는 객체의 필드나 메소드에 접근할 때 객체의 이름(변수 또는 식별자)을 사용한다면, 객체 내부에서는 자신의 필드나
// 메소드에 접근할 때 this 키워드를 사용한다는 것입니다.

namespace _002.MiddleGrammar
{
    class Employee
    {
        private string Name;
        private string Position;

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetPosition(string Position)
        {
            this.Position = Position;
        }

        public string GetPosition()
        {
            return this.Position;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Employee pooh = new Employee();
            pooh.SetName("Pooh");
            pooh.SetPosition("Waiter");
            Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");

            Employee tigger = nwe Employee();
            tigger.SetName("Tigger");
            tigger.SetPosition("Cleaner");
            Console.WriteLine($"{tigger.GetName()} {tigger.GetPosition()}");
        }
    }
}
