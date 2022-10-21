﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _0003._AdvanceGrammar
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 1*2(x-y)
            Expression const1 = Expression.Constant(1);
            Expression const2 = Expression.Constant(2);

            Expression leftExp = Expression.Multiply(const1, const2); // 1 * 2

            Expression param1 =
                Expression.Parameter(typeof(int)); // x를 위한 변수
            Expression param2 =
                Expression.Parameter(typeof(int)); // y를 위한 변수

            Expression rightExp = Expression.Subtract(param1, param2); // x - y

            Expression exp = Expression.Add(leftExp, rightExp);

            Expression<Func<int, int, int>> expression =
                Expression<Func<int, int, int>>.Lambda<Func<int, int, int>>(
                    exp, new ParameterExpression[]
                    {
                        (ParameterExpression)param1,
                        (ParameterExpression)param2
                    });
        }
    }
}
