using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0002.MiddleGrammar
{
    class _044_MoreOnArray
    {
        private static bool CheckPassed(int score)
        {
            return score >= 60;
        }

        private static void Print(int value)
        {
            Console.Write($"{value} ");
        }

        static void Main(string[] args)
        {
            int[] scores = new int[] {80, 74, 81, 90, 34};

            foreach(int score in scores)
                Console.Write($"{score} ");
            Console.WriteLine();

            Array.Sort(scores);
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            Console.WriteLine($"Number of dimensions : {scores.Rank}");

            Console.WriteLine($"Binary Search : 81 is at " +
                $"{Array.BinarySearch<int>(scores, 81)}");

            Console.WriteLine($"Linear Search : 90 is at " +
                $"{Array.IndexOf(scores, 90)}");

            Console.WriteLine($"Everyone passed ? : " +
                $"{Array.TrueForAll<int>(scores, CheckPassed)}");
            // TrueForAll 메소드는 배열과 함께 조건을 검사하는 메소드를 매개변수로 받습니다.

            int index = Array.FindIndex<int>(scores, (score) => score < 60);
            // FindIndex 메소드는 특정 조건에 부합하는 메소드를 매개변수로 받습니다. 여기에선 람다식으로 구현해봤습니다.

            scores[index] = 61;
            Console.WriteLine($"Everyone passed ? : " +
                $"{Array.TrueForAll<int>(scores, CheckPassed)}"); 

            Console.WriteLine("Old length of scores : " +
                $"{scores.GetLength(0)}");

            Array.Resize<int>(ref scores, 10); // 5였던 배열의 용량을 10으로 재조정합니다.
            Console.WriteLine($"New length of scores : {scores.Length}");

            Array.ForEach<int>(scores, new Action<int>(Print)); // Action 대리자에 대해서는 14장에서 다시 자세하게 설명하겠습니다.
            Console.WriteLine();

            Array.Clear(scores, 3, 7);
            Array.ForEach<int>(scores, new Action<int>(Print)); 
            // 이 코드는 scores 배열의 0번째부터 3개 요소를 sliced 배열의 0번째~2번째 요소에 차례대로 복사합니다.
            Console.WriteLine();

            int[] sliced = new int[3];
            Array.Copy(scores, 0, sliced, 0, 3);
            Array.ForEach<int>(sliced, new Action<int>(Print));
            Console.WriteLine();
        }
    }
}
