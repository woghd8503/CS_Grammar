using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0002.MiddleGrammar
{
    internal class MyList : IEnumerable, IEnumerator
    {
        private int[] array;
        int position = -1;

        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                if(index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }

                array[index] = value;
            }
        }

        // IEnumerator 멤버
        public object Current
        {
            get
            {
                return array[position];
            }
        }

        // IEnumerator 멤버
        public bool MoveNext()
        {
            
        }
    }
}
