using System;

namespace CodingStudy
{
    class 3DArray
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int x = input[0];
            int y = input[1];
            int w = input[2];
            int h = input[3];

            int[] NumArray = new int[] { x, y, w - x, h - y };

            int Min = NumArray[0];

            for (int i = 1; i < NumArray.Length; i++)
            {
                if (Min > NumArray[i])
                    Min = NumArray[i];
            }
            Console.WriteLine(Min);
        }
    }
}