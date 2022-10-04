using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0002._MiddleGrammar
{
    internal class _065_Test
    {
        void Main(string[] args)
        {
            // 다음 코드에서 문제를 찾고, 그 원인을 설명하세요.
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue("한글");
            queue.Enqueue(3.14);

            Queue<int> queue2 = new Queue<int>();
            queue2.Enqueue(10);
            //queue2.Enqueue("한글");
            //queue2.Enqueue(3.14);

            
        }  



    }
}
