using System;
using methodOverloading;

namespace methodOverloading
{
    public class method
    {
        public static int multiDisplay(int a, int b)
        {
            return a * b;
        }
        public static int multiDisplay(int a)
        {
            return a;
        }
        public static int multiDisplay(int a, int b, int c)
        {
            return a + b + c;
        }

    }

}
class Program
{
    static void Main(string[] arg)
    {
        Console.WriteLine(method.multiDisplay(5, 6));
        Console.WriteLine(method.multiDisplay(5));
        Console.WriteLine(method.multiDisplay(5, 6, 7));
    }
}