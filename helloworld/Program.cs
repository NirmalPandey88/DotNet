// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



//String 

    string name = "Nirmal Pandey";
    Console.WriteLine("My name is " + name);// this is a simple concatenation of strings using the + operator.
    Console.WriteLine($"My Name is {name}");// the $ is used for string interpolation, which allows you to embed expressions inside string literals.


    // Trimming whitespace from a string
    string sentence = "     Nirmal    ";
    Console.WriteLine(sentence.Trim());//trim starting and ending whitespace 
    Console.WriteLine(sentence.TrimStart());//trim starting whitespace
    Console.WriteLine(sentence.TrimEnd());//trim ending whitespace  

    Console.WriteLine($"My name is {sentence.Trim()}.");
    Console.WriteLine($"My name is {sentence.TrimStart()}.");
    Console.WriteLine($"My name is {sentence.TrimEnd()}.");


    //Using .Replace() method to replace parts of a string
    // The Replace method is used to replace occurrences of a specified substring with another substring.
    string f1 = "rajan";
    string f2 = "anish";
    string friends = $"My friends are {f1} and {f2}.";
    Console.WriteLine(friends);
    Console.WriteLine(friends.Replace("rajan", "nirmal")); // Replaces "rajan" with "nirmal" in the string
    Console.WriteLine(friends.Replace("anish", "nirmal")); // Replaces "anish" with "nirmal" in the string
    Console.WriteLine(friends.Replace("rajan", "nirmal").Replace("anish", "nirmal")); // Replaces both.
    


    //Using .Contains() method to check if a string contains a substring
    string text = "Hello, World!";
    Console.WriteLine($"Does the text contain 'World'? :{ text.Contains("World")}");

    //Using .ToUpper() and .ToLower() methods to change the case of a string
    string mixedCase = "Hello, World!";
    Console.WriteLine(mixedCase.ToUpper()); // Converts to uppercase
    Console.WriteLine(mixedCase.ToLower()); // Converts to lowercase
    Console.WriteLine(mixedCase.ToLower().Replace("hello", "hi")); // Converts to lowercase and replaces "hello" with "hi"