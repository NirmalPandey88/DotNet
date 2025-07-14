using constructor;
using System;

namespace constructor
{
    class Bike
    {
        public string model;

        public Bike(string modelName)
        {
            model = modelName;
        }

    }
}
class Program
{
    static void Main(string[] args)
    {
        Bike harley = new Bike("Rocket3");
        Console.WriteLine(harley.model);
    }
}