using System; // This is a simple C# program that demonstrates basic output operations.


Console.WriteLine("Hello, World!");



//Now declaration of a variable and printing its value
// The variable is of type string and holds a name(variable_name).
string name = "aashish panthee";
Console.WriteLine(name);




// the below line is added to demonstrate string interpolation
Console.WriteLine($"My friend's name is {name} and he is gay");




//the below code represents how we trim the whitespace.
string textWithWhitespace = "   Hello, World!   ";
Console.WriteLine(textWithWhitespace.Trim());

//triming the whitespace from the start and end of a string
string textWithWhitespace2 = "   Hello, World!   ";
Console.WriteLine(textWithWhitespace2.TrimStart()); // Trims whitespace from the start
Console.WriteLine(textWithWhitespace2.TrimEnd());   // Trims whitespace from the end




// The below code demonstrates how to convert a string to uppercase and lowercase.
string originalText = "Hello, World!";
string upperText = originalText.ToUpper(); // Converts to uppercase
string lowerText = originalText.ToLower(); // Converts to lowercase
Console.WriteLine(upperText); // Output: HELLO, WORLD!
Console.WriteLine(lowerText); // Output: hello, world!


//Searching for a substring within a string
string sentence = "The quick brown fox jumps over the lazy dog.";
string wordToFind = "fox";
Console.WriteLine(sentence.Contains(wordToFind)); // Output: True




//Type conversion example:
//Implicit conversion from int to double
//implicit conversion is when a smaller data type is converted to a larger data type without losing information.
//In this case, an int is converted to a double without any explicit cast.  
int intValue = 42;
double doubleValue = intValue; // Implicit conversion
Console.WriteLine(doubleValue); // Output: 42.0 




//Explicit conversion from double to int
//Explicit conversion is when a larger data type is converted to a smaller data type, which may result in data loss.
//In this case, a double is converted to an int, which truncates the decimal part.
double anotherDoubleValue = 42.99;
int anotherIntValue = (int)anotherDoubleValue; // Explicit conversion
Console.WriteLine(anotherIntValue); // Output: 42 (decimal part is truncated)





