//Numbers 

int a = 10;
int b = 20;
int c = a + b;
Console.WriteLine(c);



//Long handles the overflow of int
//Long is a 64-bit signed integer, which can hold larger values than int (32-bit signed integer).
int d = 2100000000;
int e = 2100000000;
long f = checked(d + e);// checked is a exceptational handelling function which throws exact error why it happened in place of garbage value.
Console.WriteLine(f);


//This is casting
//Casting is the process of converting a variable from one type to another.
//Here we are casting a double to an int, which will truncate the decimal part.
int g = (int)22.33;
int h = (int)43.33;
Console.WriteLine(g);// Output: 22
Console.WriteLine(h);// Output: 43

Console.WriteLine($"The sum of {g} and {h} is {g + h}"); // Output: The sum of 22 and 43 is 65
Console.WriteLine($"The sum of {g} and {h} is {g + h}"); // Output: The sum of 22 and 43 is 65


