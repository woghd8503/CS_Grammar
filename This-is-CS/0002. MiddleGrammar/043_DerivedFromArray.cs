using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 분류                /            이름              /
// 정적메소드                  Sort()                    배열을 정렬합니다.
//                            BinarySearch<T>()         이진 탐색을 수행합니다. 꺽쇠 과효<, >와 그 사이에 있는 T에 대해선 잠시 후에 설명하겠습니다.
//                            IndexOf()                 배열에서 찾고자 하는 특정 데이터의 인덱스를 반환합니다.
//                            TrueForAll<T>()           배열의 모든 요소가 지정한 조건을 부합하는지의 여부를 반환합니다.
//                            FindIndex<T>()            배열에서 지정한 조건에 부합하는 첫 번째 요소의 인덱스를 반환합니다.
//                            Resicze<T>()              배열의 크기를 재조정합니다.
//                            Clear()                   배열의 모든 요소를 초기화합니다. 배열이 숫자 형식 기반이며 0으로, 논리 형식 기반이며 false로, 참조 형식 기반이면 null로 초기화합니다.
//                            ForEach<T>()              배열의 모든 요소에 대해 동일한 작업을 수행하게 합니다.
//                            Copy<T>()                 배열의 일부를 다른 배열에 복사합니다.

// 인스턴스 메소드     /       GetLength()               배열에서 지정한 차원의 길이를 반환합니다. 이 메소드는 나중에 설명할 다차원 배열에서 유용하게 사용됩니다.

// 프로퍼티            /       Legnth                    배열의 길이를 반환합니다.
//                            Rank                      배열의 차원을 반환합니다.

namespace _0002.MiddleGrammar
{
    class _043_DerivedFromArray
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 30, 20, 7, 1 };
            Console.WriteLine($"Type Of array : {array.GetType()}");
            Console.WriteLine($"Base type Of array : {array.GetType().BaseType}");
        }
    }
}
