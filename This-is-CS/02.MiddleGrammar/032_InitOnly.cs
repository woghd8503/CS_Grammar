﻿using System;


// 의도치 않게 데이터가 오염되는 일이 종종 있는데 C#에는 데이터 오염을 방지할 수 있는 장치가 여럿 있습니다. 접근 한정자, readonly 필드, readonly 구조체, 튜플 등이
// 그 예죠. 하지만 프로퍼티를 읽기 전용으로 선언하는 방법이 불편했는데요. 다음과 같이 생성자를 통해 필드를 초기화하고 그 필드에 접근하는 프로퍼티는 get 접근자만 갖도록 해야 했습니다.

namespace InitOnly
{
    class Transaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Transaction tr1 = new Transaction { From = "Alice", To = "Bob", Amount = 100 };
            Transaction tr2 = new Transaction { From = "Bob", To = "Charlie", Amount = 50 };
            Transaction tr3 = new Transaction { From = "Charlie", To = "Alice", Amount = 50 };

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
            Console.WriteLine(tr3);
        }
    }

}

