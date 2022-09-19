using static System.Console;
using System.Collections;


namespace _0002.MiddleGrammar
{
    internal class _052_InitializingCollections
    {
        static void Main(string[] args)
        {
            int[] arr = { 123, 456, 789 };

            ArrayList list = new ArrayList(arr);
            foreach (object item in list)
                WriteLine($"ArrayList : {item}");
            WriteLine();

            Stack stack = new Stack(arr);
            foreach (object item in stack)
                WriteLine($"Stack : {item}");
            WriteLine();

            Queue queue = new Queue(arr);
            foreach (object item in queue)
                WriteLine($"Queue : {item}");
            WriteLine();

            ArrayList list2 = new ArrayList() { 11, 22, 33 };
            foreach (object item in list2)
                WriteLine($"ArrayList2 : {item}");
            WriteLine();
        }
    }
}
