using System;
using System.Runtime.CompilerServices;

// 불변 immutable 객체는 내부 상태 데이터를 변경할 수 없는 객체를 말하는데요. 상태를 변경할 수 없다는 특성 때문에 불변 객체에서는 데이터 복사와 비교가
// 많이 이뤄집니다. 새로운 상태를 표현하려고 기존 상태를 복사한 뒤 이 중 일부를 수정해서 새로운 객체를 만들고, 상태를 확인하기 위해 객체내용을 작주 비교합니다.


namespace WithExp
{
    record RTransaction
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
            RTransaction tr1 = new RTransaction{From = "Alice", To = "Bob", Amount = 100};
            RTransaction tr2 = tr1 with { To = "Charlie" };
            RTransaction tr3 = tr2 with { From = "Dabe", Amount=30 };

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
            Console.WriteLine(tr3);
        }
    }

}

