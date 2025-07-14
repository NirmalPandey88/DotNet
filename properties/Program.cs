using System;
using properties;

namespace properties
{
    class Person
    {
        private string name;
        public string Name
        {
            get { return name; }// get the value from main function 
            set { name = value; }//sset the value to 
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Person myObject = new Person();
        myObject.Name = "John Doe"; // Using the property to set the name
        Console.WriteLine(myObject.Name); // Using the property to get the name in console/terminal
    }
}
