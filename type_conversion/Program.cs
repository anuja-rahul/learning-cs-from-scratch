// type cast

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// "widening conversion" or a "narrowing conversion"

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");


// Data conversion

// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

// Converting a string to an int using the Parse() helper method

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);


// Converting a string to a int using the Convert class

// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);

/*
Why is the method name ToInt32()? Why not ToInt()?
System.Int32 is the name of the underlying data type in the .NET Class Library that the C# programming language
maps to the keyword int.
Because the Convert class is also part of the .NET Class Library,
it is called by its full name, not its C# name. By defining data types as part of the .NET Class Library,
multiple .NET languages like Visual Basic, F#, IronPython, and others can share the same data types and the same classes
in the .NET Class Library.
*/

// Comparing casting and converting a decimal into an int

int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);

/*
When you're casting int value = (int)1.5m;, the value of the float is truncated so the result is 1,
meaning the value after the decimal is ignored completely. You could change the literal float to 1.999m
and the result of casting would be the same.

When you're converting using Convert.ToInt32(), the literal float value is properly rounded up to 2.
If you changed the literal value to 1.499m, it would be rounded down to 1.
*/