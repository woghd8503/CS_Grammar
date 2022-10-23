using System;
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


        }
    }
}
