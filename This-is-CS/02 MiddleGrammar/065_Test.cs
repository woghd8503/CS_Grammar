using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic["하나"] = "one";
            dic["둘"] = "two";
            dic["셋"] = "three";
            dic["넷"] = "four";
            dic["다섯"] = "five";

            Console.WriteLine(dic["하나"]);
            Console.WriteLine(dic["둘"]);
            Console.WriteLine(dic["셋"]);
            Console.WriteLine(dic["넷"]);
            Console.WriteLine(dic["다섯"]);
        }  



    }
}
