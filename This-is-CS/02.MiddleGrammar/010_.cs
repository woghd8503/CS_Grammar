using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 객체지향 프로그래밍에서 다향성 Polymorphism은 객체가 여러 형태를 가질 수 있음을 의미합니다.  

namespace _002.MiddleGrammar
{
    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("Nurse()");
        }
    }

    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Bark()");
        }
    }

    class Cat : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Meow()");
        }
    }
    
    class MainApp
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Dog();
            Dog dog;

            if(mammal is Dog)
            {
                dog = (Dog)mammal;
                dog.Bark();
            }

            Mammal mammal2 = new Cat();

            Cat cat = mammal2 as Cat;
            if (cat != null)
                cat.Meow();

            Cat cat2 = mammal as Cat;
            if (cat2 != null)
                cat2.Meow();
            else
                Console.WriteLine("cat2 is not a Cat");
        }
    }
}
