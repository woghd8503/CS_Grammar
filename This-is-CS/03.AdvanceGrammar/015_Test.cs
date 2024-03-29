﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0003._AdvanceGrammar
{
    internal class _015_Test
    {

        static void Main()
        {
            // 다음 코드의 출력 결과값은 얼마일까요?
            Func<int> func_1 = () => 10;
            Func<int, int> func_2 = (a) => a * 2;
            
            Console.WriteLine(func_1() + func_2(30));

            // 다음 코드에서 익명 메소드를 람다식으로 수정하세요.
            int[] array = { 11, 22, 33, 44, 55 };

            foreach (int a in array)
            {
                Action action = new Action
                    (
                        delegate ()
                        {
                            Console.WriteLine(a * a);
                        }
                    );
                action.Invoke();

                // 정답
                Action<int> action1 = (x) => { Console.WriteLine(x * x); };
                action1(a);
            }
        }
    }
}
