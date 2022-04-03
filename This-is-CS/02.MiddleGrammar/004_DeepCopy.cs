﻿using System;

// 클래스는 태생이 참조 형식이기 때문에 처음 데이터 형식을 설명할 때 참조 형식과 값 형식이 메모리에 저장되는 방식의 차이에 대해 알아야합니다.
// 참조 형식은 힘 영역에 객체를 할당하고 스택에 있는 참조가  힘 영역에 할당된 메모리를 가리킵니다. 

// 얕은 복사 Shallow Copy 는 실제 객체가 아닌 스택에 있는 참조를 복사해서 받습니다.
// 깊은 복사 Deep Copy 는 힙에 보관되어 있는 내용을 복사해서 받아 별도의 힙 공간에 객체를 보관하기를 바라는 것이죠.

namespace _002.MiddleGrammar
{
    class MyClass
    {
        public int MyField1;
        public int MyField2;

        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();
            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2;

            return newCopy;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");

            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source;
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {source.MyField2}");
            }

            Console.WriteLine("Deep Copy");

            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source.DeepCopy();
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");
            }
        }
    }
}
