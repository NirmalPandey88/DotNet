using System;

namespace Array
{
    class array
    {
        static void Main(string[] arg)
        {
            var numbers = new int[] { 5, 6, 7, 4, 3, 5, 6 };
            Console.WriteLine(numbers.Length); // Output the length of the array
            foreach (int x in numbers)
            {
                Console.WriteLine(x);
            }
        }
    }
}