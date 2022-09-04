using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 분류                /            이름              /
// 정적메소드                       Sort()                         배열을 정렬합니다.
//                            BinarySearch<T>()         이진 탐색을 수행합니다. 꺽쇠 과효<, >와 그 사이에 있는 T에 대해선 잠시 후에 설명하겠습니다.          
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
